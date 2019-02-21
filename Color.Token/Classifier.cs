using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace Color.Token
{
	internal class Classifier
		: IClassifier
	{
		private bool IsClassificationRunning;
		private IClassifier IClassifier;

		#pragma warning disable 67
		public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
		#pragma warning restore 67

		private readonly Dictionary<string, IClassificationType> Tokens =
			new Dictionary<string, IClassificationType>();

		internal Classifier(
			IClassificationTypeRegistryService Registry,
			IClassifier Classifier
		){
			IsClassificationRunning = false;
			IClassifier = Classifier;

			foreach (string Token in Meta.List){
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

		private IList<ClassificationSpan> Classify(SnapshotSpan Span){
			IList<ClassificationSpan> Spans = new List<ClassificationSpan>();

			if (Span.IsEmpty) return Spans;
			string Text = Span.GetText();

			foreach (string Token in Meta.List){
				foreach (Match Match in new Regex(
						@"(?<!" + Utils.Identifier + @")"
					+	@"(?<Token>" + Token       + @")"
					+	@"(?!"  + Utils.Identifier + @")"
				).Matches(Text))
				{
					var MatchedSpan = new SnapshotSpan(
						Span.Snapshot, new Span(Span.Start + Match.Index, Match.Length)
					);

					var Intersections = IClassifier.GetClassificationSpans(MatchedSpan);
					foreach (ClassificationSpan Intersection in Intersections){
						var Classification = Intersection.ClassificationType.Classification;
						if (Classification != PredefinedClassificationTypeNames.Keyword){
							goto NextToken;
						}
					}

					Spans.Add(new ClassificationSpan(new SnapshotSpan(
						Span.Snapshot, new Span(
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