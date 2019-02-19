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

		private readonly Dictionary<string, IClassificationType> Tokens
			= new Dictionary<string, IClassificationType>()
		;

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

			string SpanText = Span.GetText();
			string[] Lines = Regex.Split(SpanText, "\n");

			foreach(string Text in Lines)
			{
				bool IsComment = new Regex(@"^\t*//").IsMatch(Text);
				bool IsDirective = new Regex(@"^\t*#").IsMatch(Text);

				if(
						!IsComment
					&&	!IsDirective
				){
					foreach (string Token in Meta.List){
						foreach (Match Match in new Regex(
								@"(?<!" + Utils.Identifier + @")"
							+	@"(?<Token>" + Token + @")"
							+	@"(?!"  + Utils.Identifier + @")"
						).Matches(Text)){
							if(!Utils.IsInsideStringLiteral(
								Text.Substring(0, Match.Groups["Token"].Index)
							)){
								var CurrentSpans = IClassifier.GetClassificationSpans(Span);
								foreach(ClassificationSpan CurrentSpan in CurrentSpans){
									var Name = CurrentSpan.ClassificationType.Classification;
									if(Name == PredefinedClassificationTypeNames.Keyword){
										Spans.Add(new ClassificationSpan(new SnapshotSpan(
											Span.Snapshot, new Span(
												Span.Start + Match.Groups["Token"].Index,
												Match.Groups["Token"].Length
											)), this.Tokens[Token]
										));
									}
								}
							}
						}
					}
				}
			}

			return Spans;
		}
	}
}