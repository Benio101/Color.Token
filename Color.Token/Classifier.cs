using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

		private readonly Dictionary<string, IClassificationType> Tokens = new Dictionary<string, IClassificationType>();

		internal Classifier
		(
			IClassificationTypeRegistryService Registry,
			IClassifier                        Classifier
		)
		{
			IsClassificationRunning = false;
			IClassifier = Classifier;

			foreach (var Token in Meta.List)
			{
				Tokens.Add(Token, Registry.GetClassificationType("Token." + Token));
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

			foreach (var Token in Meta.List)
			{
				var TokenName = Token;

				// ReSharper disable once SwitchStatementMissingSomeCases
				switch (Token)
				{
					// Alternative form: asm
					case "asm":

						TokenName = "_{0,2}" + Token + "_{0,2}";
						break;

					// default (function definition)
					case "default":

						TokenName = @"default(?![ \t\v\n\f]*:)";
						break;

					// default (switch statement)
					case "default.statement":

						TokenName = @"default(?=[ \t\v\n\f]*:)";
						break;
				}

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

						// Token classified as "macro" is optionally valid.
						if (Options.ColorMacro && Utils.IsClassifiedAs(Classifications, "cppMacro"))
							continue;

						// Token must be classified as "keyword".
						if (!Utils.IsClassifiedAs(Classifications, PredefinedClassificationTypeNames.Keyword)) goto NextToken;

						// Token can't be classified as neither
						// "preprocessor keyword" nor "Attribute".
						if (Utils.IsClassifiedAs(Classifications, new[]{PredefinedClassificationTypeNames.PreprocessorKeyword, "Attribute"})) goto NextToken;

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
						)), Tokens[Token]
					));

					NextToken:;
				}
			}

			return Spans;
		}
	}
}