using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace Color.Token
{
	internal class Classifier
	:
		IClassifier
	{
		private          bool        IsClassificationRunning;
		private readonly IClassifier IClassifier;

		#pragma warning disable 67
		public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
		#pragma warning restore 67

		private readonly Dictionary<int, IClassificationType> Tokens = new Dictionary<int, IClassificationType>();

		internal Classifier
		(
			IClassificationTypeRegistryService Registry,
			IClassifier                        Classifier
		)
		{
			IsClassificationRunning = false;
			IClassifier = Classifier;

			for (int i = 1; i <= 32; ++i)
			{
				Tokens.Add(i, Registry.GetClassificationType("Token" + i.ToString()));
			}
		}

		public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan Span)
		{
			if (IsClassificationRunning) return new List<ClassificationSpan>();

			try
			{
				IsClassificationRunning = true;
				return Classify(Span);
			}
			finally
			{
				IsClassificationRunning = false;
			}
		}

		private IList<ClassificationSpan> Classify(SnapshotSpan Span)
		{
			IList<ClassificationSpan> Spans = new List<ClassificationSpan>();

			if (Span.IsEmpty) return Spans;
			var Text = Span.GetText();

			if (!Options.Tokens.Contains("\n")) return Spans;
			string[] Entries = Options.Tokens.Split('\n');
			foreach (string Entry in Entries)
			{
				if (!Entry.Contains("\t")) continue;
				string[] Fields = Entry.Split('\t');
				if (Fields.Length == 0) continue;

				string Name       = Fields[0];
				   int ID         = System.Convert.ToInt32(Fields[1]);
				  bool ColorMacro = Fields[2] == "1";

				var TokenName = Name;
				foreach
				(
					Match Match in new Regex
					(
							"(?<!" + Utils.IdentifierCharacter + ")"
						+	"(?<Token>" + TokenName            + ")"
						+	"(?!"  + Utils.IdentifierCharacter + ")"
					)
					.Matches(Text)
				)
				{
					var MatchedSpan = new SnapshotSpan(Span.Snapshot, new Span(Span.Start + Match.Index, Match.Length));

					var Intersections = IClassifier.GetClassificationSpans(Span);
					foreach (var Intersection in Intersections)
					{
						if (!Intersection.Span.OverlapsWith(MatchedSpan)) continue;

						var Classifications = Intersection.ClassificationType.Classification.Split(new[]{" - "}, StringSplitOptions.None);
						if (!Utils.IsClassifiedAs(Classifications, PredefinedClassificationTypeNames.Keyword)) goto NextToken;

						// Token can't be classified as neither
						// "preprocessor keyword" nor "Attribute".
						if (Utils.IsClassifiedAs(Classifications, new[]{PredefinedClassificationTypeNames.PreprocessorKeyword, "Attribute"})) goto NextToken;

						// Token can be also classified as "macro".
						if (!ColorMacro && Utils.IsClassifiedAs(Classifications, "cppMacro")) continue;

						// Token classification can't begin with "cpp"
						// (except inactive code classification).
						if (Utils.IsClassifiedAs(Classifications, new Regex("^cpp(?!InactiveCodeClassification)", RegexOptions.IgnoreCase))) goto NextToken;
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan
					(
						Span.Snapshot, new Span
						(
							Span.Start + Match.Groups["Token"].Index,
							Match.Groups["Token"].Length
						)), Tokens[ID]
					));

					NextToken:;
				}
			}

			return Spans;
		}
	}
}