using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Token
{
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token1")]
	[Name("Token1")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_1
	:
		ClassificationFormatDefinition
	{
		public Format_Token_1()
		{
			DisplayName = "C++ Token Color #​1";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token2")]
	[Name("Token2")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_2
	:
		ClassificationFormatDefinition
	{
		public Format_Token_2()
		{
			DisplayName = "C++ Token Color #​2";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token3")]
	[Name("Token3")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_3
	:
		ClassificationFormatDefinition
	{
		public Format_Token_3()
		{
			DisplayName = "C++ Token Color #​3";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token4")]
	[Name("Token4")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_4
	:
		ClassificationFormatDefinition
	{
		public Format_Token_4()
		{
			DisplayName = "C++ Token Color #​4";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token5")]
	[Name("Token5")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_5
	:
		ClassificationFormatDefinition
	{
		public Format_Token_5()
		{
			DisplayName = "C++ Token Color #​5";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Important;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token6")]
	[Name("Token6")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_6
	:
		ClassificationFormatDefinition
	{
		public Format_Token_6()
		{
			DisplayName = "C++ Token Color #​6";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token7")]
	[Name("Token7")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_7
	:
		ClassificationFormatDefinition
	{
		public Format_Token_7()
		{
			DisplayName = "C++ Token Color #​7";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Assembler;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token8")]
	[Name("Token8")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_8
	:
		ClassificationFormatDefinition
	{
		public Format_Token_8()
		{
			DisplayName = "C++ Token Color #​8";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token9")]
	[Name("Token9")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_9
	:
		ClassificationFormatDefinition
	{
		public Format_Token_9()
		{
			DisplayName = "C++ Token Color #​9";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token10")]
	[Name("Token10")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_10
	:
		ClassificationFormatDefinition
	{
		public Format_Token_10()
		{
			DisplayName = "C++ Token Color #10";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token11")]
	[Name("Token11")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_11
	:
		ClassificationFormatDefinition
	{
		public Format_Token_11()
		{
			DisplayName = "C++ Token Color #11";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token12")]
	[Name("Token12")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_12
	:
		ClassificationFormatDefinition
	{
		public Format_Token_12()
		{
			DisplayName = "C++ Token Color #12";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token13")]
	[Name("Token13")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_13
	:
		ClassificationFormatDefinition
	{
		public Format_Token_13()
		{
			DisplayName = "C++ Token Color #13";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token14")]
	[Name("Token14")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_14
	:
		ClassificationFormatDefinition
	{
		public Format_Token_14()
		{
			DisplayName = "C++ Token Color #14";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token15")]
	[Name("Token15")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_15
	:
		ClassificationFormatDefinition
	{
		public Format_Token_15()
		{
			DisplayName = "C++ Token Color #15";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token16")]
	[Name("Token16")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_16
	:
		ClassificationFormatDefinition
	{
		public Format_Token_16()
		{
			DisplayName = "C++ Token Color #16";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token17")]
	[Name("Token17")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_17
	:
		ClassificationFormatDefinition
	{
		public Format_Token_17()
		{
			DisplayName = "C++ Token Color #17";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token18")]
	[Name("Token18")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_18
	:
		ClassificationFormatDefinition
	{
		public Format_Token_18()
		{
			DisplayName = "C++ Token Color #18";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token19")]
	[Name("Token19")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_19
	:
		ClassificationFormatDefinition
	{
		public Format_Token_19()
		{
			DisplayName = "C++ Token Color #19";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token20")]
	[Name("Token20")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_20
	:
		ClassificationFormatDefinition
	{
		public Format_Token_20()
		{
			DisplayName = "C++ Token Color #20";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token21")]
	[Name("Token21")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_21
	:
		ClassificationFormatDefinition
	{
		public Format_Token_21()
		{
			DisplayName = "C++ Token Color #21";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token22")]
	[Name("Token22")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_22
	:
		ClassificationFormatDefinition
	{
		public Format_Token_22()
		{
			DisplayName = "C++ Token Color #22";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token23")]
	[Name("Token23")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_23
	:
		ClassificationFormatDefinition
	{
		public Format_Token_23()
		{
			DisplayName = "C++ Token Color #23";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token24")]
	[Name("Token24")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_24
	:
		ClassificationFormatDefinition
	{
		public Format_Token_24()
		{
			DisplayName = "C++ Token Color #24";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token25")]
	[Name("Token25")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_25
	:
		ClassificationFormatDefinition
	{
		public Format_Token_25()
		{
			DisplayName = "C++ Token Color #25";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token26")]
	[Name("Token26")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_26
	:
		ClassificationFormatDefinition
	{
		public Format_Token_26()
		{
			DisplayName = "C++ Token Color #26";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token27")]
	[Name("Token27")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_27
	:
		ClassificationFormatDefinition
	{
		public Format_Token_27()
		{
			DisplayName = "C++ Token Color #27";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token28")]
	[Name("Token28")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_28
	:
		ClassificationFormatDefinition
	{
		public Format_Token_28()
		{
			DisplayName = "C++ Token Color #28";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token29")]
	[Name("Token29")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_29
	:
		ClassificationFormatDefinition
	{
		public Format_Token_29()
		{
			DisplayName = "C++ Token Color #29";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token30")]
	[Name("Token30")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_30
	:
		ClassificationFormatDefinition
	{
		public Format_Token_30()
		{
			DisplayName = "C++ Token Color #30";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token31")]
	[Name("Token31")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_31
	:
		ClassificationFormatDefinition
	{
		public Format_Token_31()
		{
			DisplayName = "C++ Token Color #31";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
	
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token32")]
	[Name("Token32")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	[Order(After = "cppMacro")]
	internal sealed class Format_Token_32
	:
		ClassificationFormatDefinition
	{
		public Format_Token_32()
		{
			DisplayName = "C++ Token Color #32";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}
}