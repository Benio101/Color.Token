using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Token
{
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.alignas")]
	[Name("Token.alignas")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_alignas
	:
		ClassificationFormatDefinition
	{
		public Format_Token_alignas()
		{
			DisplayName = "C++ Token: \"alignas\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.alignof")]
	[Name("Token.alignof")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_alignof
	:
		ClassificationFormatDefinition
	{
		public Format_Token_alignof()
		{
			DisplayName = "C++ Token: \"alignof\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.asm")]
	[Name("Token.asm")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_asm
	:
		ClassificationFormatDefinition
	{
		public Format_Token_asm()
		{
			DisplayName = "C++ Token: \"asm\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Assembler;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.atomic_cancel")]
	[Name("Token.atomic_cancel")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_atomic_cancel
	:
		ClassificationFormatDefinition
	{
		public Format_Token_atomic_cancel()
		{
			DisplayName = "C++ Token: \"atomic_cancel\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.atomic_commit")]
	[Name("Token.atomic_commit")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_atomic_commit
	:
		ClassificationFormatDefinition
	{
		public Format_Token_atomic_commit()
		{
			DisplayName = "C++ Token: \"atomic_commit\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.atomic_noexcept")]
	[Name("Token.atomic_noexcept")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_atomic_noexcept
	:
		ClassificationFormatDefinition
	{
		public Format_Token_atomic_noexcept()
		{
			DisplayName = "C++ Token: \"atomic_noexcept\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.auto")]
	[Name("Token.auto")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_auto
	:
		ClassificationFormatDefinition
	{
		public Format_Token_auto()
		{
			DisplayName = "C++ Token: \"auto\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.bool")]
	[Name("Token.bool")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_bool
	:
		ClassificationFormatDefinition
	{
		public Format_Token_bool()
		{
			DisplayName = "C++ Token: \"bool\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.break")]
	[Name("Token.break")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_break
	:
		ClassificationFormatDefinition
	{
		public Format_Token_break()
		{
			DisplayName = "C++ Token: \"break\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.case")]
	[Name("Token.case")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_case
	:
		ClassificationFormatDefinition
	{
		public Format_Token_case()
		{
			DisplayName = "C++ Token: \"case\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.catch")]
	[Name("Token.catch")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_catch
	:
		ClassificationFormatDefinition
	{
		public Format_Token_catch()
		{
			DisplayName = "C++ Token: \"catch\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.char")]
	[Name("Token.char")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_char
	:
		ClassificationFormatDefinition
	{
		public Format_Token_char()
		{
			DisplayName = "C++ Token: \"char\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.char8_t")]
	[Name("Token.char8_t")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_char8_t
	:
		ClassificationFormatDefinition
	{
		public Format_Token_char8_t()
		{
			DisplayName = "C++ Token: \"char8_t\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.char16_t")]
	[Name("Token.char16_t")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_char16_t
	:
		ClassificationFormatDefinition
	{
		public Format_Token_char16_t()
		{
			DisplayName = "C++ Token: \"char16_t\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.char32_t")]
	[Name("Token.char32_t")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_char32_t
	:
		ClassificationFormatDefinition
	{
		public Format_Token_char32_t()
		{
			DisplayName = "C++ Token: \"char32_t\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.class")]
	[Name("Token.class")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_class
	:
		ClassificationFormatDefinition
	{
		public Format_Token_class()
		{
			DisplayName = "C++ Token: \"class\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.concept")]
	[Name("Token.concept")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_concept
	:
		ClassificationFormatDefinition
	{
		public Format_Token_concept()
		{
			DisplayName = "C++ Token: \"concept\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.const")]
	[Name("Token.const")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_const
	:
		ClassificationFormatDefinition
	{
		public Format_Token_const()
		{
			DisplayName = "C++ Token: \"const\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.consteval")]
	[Name("Token.consteval")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_consteval
	:
		ClassificationFormatDefinition
	{
		public Format_Token_consteval()
		{
			DisplayName = "C++ Token: \"consteval\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.constexpr")]
	[Name("Token.constexpr")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_constexpr
	:
		ClassificationFormatDefinition
	{
		public Format_Token_constexpr()
		{
			DisplayName = "C++ Token: \"constexpr\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.const_cast")]
	[Name("Token.const_cast")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_const_cast
	:
		ClassificationFormatDefinition
	{
		public Format_Token_const_cast()
		{
			DisplayName = "C++ Token: \"const_cast\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.continue")]
	[Name("Token.continue")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_continue
	:
		ClassificationFormatDefinition
	{
		public Format_Token_continue()
		{
			DisplayName = "C++ Token: \"continue\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.co_await")]
	[Name("Token.co_await")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_co_await
	:
		ClassificationFormatDefinition
	{
		public Format_Token_co_await()
		{
			DisplayName = "C++ Token: \"co_await\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.co_return")]
	[Name("Token.co_return")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_co_return
	:
		ClassificationFormatDefinition
	{
		public Format_Token_co_return()
		{
			DisplayName = "C++ Token: \"co_return\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.co_yield")]
	[Name("Token.co_yield")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_co_yield
	:
		ClassificationFormatDefinition
	{
		public Format_Token_co_yield()
		{
			DisplayName = "C++ Token: \"co_yield\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.decltype")]
	[Name("Token.decltype")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_decltype
	:
		ClassificationFormatDefinition
	{
		public Format_Token_decltype()
		{
			DisplayName = "C++ Token: \"decltype\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.default")]
	[Name("Token.default")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_default
	:
		ClassificationFormatDefinition
	{
		public Format_Token_default()
		{
			DisplayName = "C++ Token: \"default\" (function definition)";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.default.statement")]
	[Name("Token.default.statement")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_default_statement
	:
		ClassificationFormatDefinition
	{
		public Format_Token_default_statement()
		{
			DisplayName = "C++ Token: \"default\" (switch statement)";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.delete")]
	[Name("Token.delete")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_delete
	:
		ClassificationFormatDefinition
	{
		public Format_Token_delete()
		{
			DisplayName = "C++ Token: \"delete\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Important;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.do")]
	[Name("Token.do")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_do
	:
		ClassificationFormatDefinition
	{
		public Format_Token_do()
		{
			DisplayName = "C++ Token: \"do\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.double")]
	[Name("Token.double")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_double
	:
		ClassificationFormatDefinition
	{
		public Format_Token_double()
		{
			DisplayName = "C++ Token: \"double\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.dynamic_cast")]
	[Name("Token.dynamic_cast")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_dynamic_cast
	:
		ClassificationFormatDefinition
	{
		public Format_Token_dynamic_cast()
		{
			DisplayName = "C++ Token: \"dynamic_cast\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.else")]
	[Name("Token.else")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_else
	:
		ClassificationFormatDefinition
	{
		public Format_Token_else()
		{
			DisplayName = "C++ Token: \"else\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.enum")]
	[Name("Token.enum")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_enum
	:
		ClassificationFormatDefinition
	{
		public Format_Token_enum()
		{
			DisplayName = "C++ Token: \"enum\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.explicit")]
	[Name("Token.explicit")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_explicit
	:
		ClassificationFormatDefinition
	{
		public Format_Token_explicit()
		{
			DisplayName = "C++ Token: \"explicit\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.export")]
	[Name("Token.export")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_export
	:
		ClassificationFormatDefinition
	{
		public Format_Token_export()
		{
			DisplayName = "C++ Token: \"export\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.extern")]
	[Name("Token.extern")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_extern
	:
		ClassificationFormatDefinition
	{
		public Format_Token_extern()
		{
			DisplayName = "C++ Token: \"extern\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.false")]
	[Name("Token.false")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_false
	:
		ClassificationFormatDefinition
	{
		public Format_Token_false()
		{
			DisplayName = "C++ Token: \"false\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.final")]
	[Name("Token.final")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_final
	:
		ClassificationFormatDefinition
	{
		public Format_Token_final()
		{
			DisplayName = "C++ Token: \"final\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.float")]
	[Name("Token.float")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_float
	:
		ClassificationFormatDefinition
	{
		public Format_Token_float()
		{
			DisplayName = "C++ Token: \"float\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.for")]
	[Name("Token.for")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_for
	:
		ClassificationFormatDefinition
	{
		public Format_Token_for()
		{
			DisplayName = "C++ Token: \"for\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.friend")]
	[Name("Token.friend")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_friend
	:
		ClassificationFormatDefinition
	{
		public Format_Token_friend()
		{
			DisplayName = "C++ Token: \"friend\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.goto")]
	[Name("Token.goto")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_goto
	:
		ClassificationFormatDefinition
	{
		public Format_Token_goto()
		{
			DisplayName = "C++ Token: \"goto\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.if")]
	[Name("Token.if")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_if
	:
		ClassificationFormatDefinition
	{
		public Format_Token_if()
		{
			DisplayName = "C++ Token: \"if\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.import")]
	[Name("Token.import")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_import
	:
		ClassificationFormatDefinition
	{
		public Format_Token_import()
		{
			DisplayName = "C++ Token: \"import\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.inline")]
	[Name("Token.inline")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_inline
	:
		ClassificationFormatDefinition
	{
		public Format_Token_inline()
		{
			DisplayName = "C++ Token: \"inline\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.int")]
	[Name("Token.int")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_int
	:
		ClassificationFormatDefinition
	{
		public Format_Token_int()
		{
			DisplayName = "C++ Token: \"int\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.long")]
	[Name("Token.long")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_long
	:
		ClassificationFormatDefinition
	{
		public Format_Token_long()
		{
			DisplayName = "C++ Token: \"long\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.module")]
	[Name("Token.module")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_module
	:
		ClassificationFormatDefinition
	{
		public Format_Token_module()
		{
			DisplayName = "C++ Token: \"module\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.mutable")]
	[Name("Token.mutable")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_mutable
	:
		ClassificationFormatDefinition
	{
		public Format_Token_mutable()
		{
			DisplayName = "C++ Token: \"mutable\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.namespace")]
	[Name("Token.namespace")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_namespace
	:
		ClassificationFormatDefinition
	{
		public Format_Token_namespace()
		{
			DisplayName = "C++ Token: \"namespace\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.new")]
	[Name("Token.new")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_new
	:
		ClassificationFormatDefinition
	{
		public Format_Token_new()
		{
			DisplayName = "C++ Token: \"new\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Important;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.noexcept")]
	[Name("Token.noexcept")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_noexcept
	:
		ClassificationFormatDefinition
	{
		public Format_Token_noexcept()
		{
			DisplayName = "C++ Token: \"noexcept\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.nullptr")]
	[Name("Token.nullptr")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_nullptr
	:
		ClassificationFormatDefinition
	{
		public Format_Token_nullptr()
		{
			DisplayName = "C++ Token: \"nullptr\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.operator")]
	[Name("Token.operator")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_operator
	:
		ClassificationFormatDefinition
	{
		public Format_Token_operator()
		{
			DisplayName = "C++ Token: \"operator\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.override")]
	[Name("Token.override")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_override
	:
		ClassificationFormatDefinition
	{
		public Format_Token_override()
		{
			DisplayName = "C++ Token: \"override\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.private")]
	[Name("Token.private")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_private
	:
		ClassificationFormatDefinition
	{
		public Format_Token_private()
		{
			DisplayName = "C++ Token: \"private\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.protected")]
	[Name("Token.protected")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_protected
	:
		ClassificationFormatDefinition
	{
		public Format_Token_protected()
		{
			DisplayName = "C++ Token: \"protected\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.public")]
	[Name("Token.public")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_public
	:
		ClassificationFormatDefinition
	{
		public Format_Token_public()
		{
			DisplayName = "C++ Token: \"public\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.reflexpr")]
	[Name("Token.reflexpr")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_reflexpr
	:
		ClassificationFormatDefinition
	{
		public Format_Token_reflexpr()
		{
			DisplayName = "C++ Token: \"reflexpr\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.reinterpret_cast")]
	[Name("Token.reinterpret_cast")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_reinterpret_cast
	:
		ClassificationFormatDefinition
	{
		public Format_Token_reinterpret_cast()
		{
			DisplayName = "C++ Token: \"reinterpret_cast\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.requires")]
	[Name("Token.requires")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_requires
	:
		ClassificationFormatDefinition
	{
		public Format_Token_requires()
		{
			DisplayName = "C++ Token: \"requires\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.return")]
	[Name("Token.return")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_return
	:
		ClassificationFormatDefinition
	{
		public Format_Token_return()
		{
			DisplayName = "C++ Token: \"return\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.short")]
	[Name("Token.short")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_short
	:
		ClassificationFormatDefinition
	{
		public Format_Token_short()
		{
			DisplayName = "C++ Token: \"short\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.signed")]
	[Name("Token.signed")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_signed
	:
		ClassificationFormatDefinition
	{
		public Format_Token_signed()
		{
			DisplayName = "C++ Token: \"signed\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.sizeof")]
	[Name("Token.sizeof")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_sizeof
	:
		ClassificationFormatDefinition
	{
		public Format_Token_sizeof()
		{
			DisplayName = "C++ Token: \"sizeof\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.static")]
	[Name("Token.static")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_static
	:
		ClassificationFormatDefinition
	{
		public Format_Token_static()
		{
			DisplayName = "C++ Token: \"static\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.static_assert")]
	[Name("Token.static_assert")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_static_assert
	:
		ClassificationFormatDefinition
	{
		public Format_Token_static_assert()
		{
			DisplayName = "C++ Token: \"static_assert\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.static_cast")]
	[Name("Token.static_cast")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_static_cast
	:
		ClassificationFormatDefinition
	{
		public Format_Token_static_cast()
		{
			DisplayName = "C++ Token: \"static_cast\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.struct")]
	[Name("Token.struct")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_struct
	:
		ClassificationFormatDefinition
	{
		public Format_Token_struct()
		{
			DisplayName = "C++ Token: \"struct\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.switch")]
	[Name("Token.switch")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_switch
	:
		ClassificationFormatDefinition
	{
		public Format_Token_switch()
		{
			DisplayName = "C++ Token: \"switch\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.synchronized")]
	[Name("Token.synchronized")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_synchronized
	:
		ClassificationFormatDefinition
	{
		public Format_Token_synchronized()
		{
			DisplayName = "C++ Token: \"synchronized\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.template")]
	[Name("Token.template")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_template
	:
		ClassificationFormatDefinition
	{
		public Format_Token_template()
		{
			DisplayName = "C++ Token: \"template\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.this")]
	[Name("Token.this")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_this
	:
		ClassificationFormatDefinition
	{
		public Format_Token_this()
		{
			DisplayName = "C++ Token: \"this\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.thread_local")]
	[Name("Token.thread_local")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_thread_local
	:
		ClassificationFormatDefinition
	{
		public Format_Token_thread_local()
		{
			DisplayName = "C++ Token: \"thread_local\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.throw")]
	[Name("Token.throw")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_throw
	:
		ClassificationFormatDefinition
	{
		public Format_Token_throw()
		{
			DisplayName = "C++ Token: \"throw\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.transaction_safe")]
	[Name("Token.transaction_safe")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_transaction_safe
	:
		ClassificationFormatDefinition
	{
		public Format_Token_transaction_safe()
		{
			DisplayName = "C++ Token: \"transaction_safe\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.transaction_safe_dynamic")]
	[Name("Token.transaction_safe_dynamic")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_transaction_safe_dynamic
	:
		ClassificationFormatDefinition
	{
		public Format_Token_transaction_safe_dynamic()
		{
			DisplayName = "C++ Token: \"transaction_safe_dynamic\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.true")]
	[Name("Token.true")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_true
	:
		ClassificationFormatDefinition
	{
		public Format_Token_true()
		{
			DisplayName = "C++ Token: \"true\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.try")]
	[Name("Token.try")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_try
	:
		ClassificationFormatDefinition
	{
		public Format_Token_try()
		{
			DisplayName = "C++ Token: \"try\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.typedef")]
	[Name("Token.typedef")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_typedef
	:
		ClassificationFormatDefinition
	{
		public Format_Token_typedef()
		{
			DisplayName = "C++ Token: \"typedef\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.typeid")]
	[Name("Token.typeid")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_typeid
	:
		ClassificationFormatDefinition
	{
		public Format_Token_typeid()
		{
			DisplayName = "C++ Token: \"typeid\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.typename")]
	[Name("Token.typename")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_typename
	:
		ClassificationFormatDefinition
	{
		public Format_Token_typename()
		{
			DisplayName = "C++ Token: \"typename\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.union")]
	[Name("Token.union")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_union
	:
		ClassificationFormatDefinition
	{
		public Format_Token_union()
		{
			DisplayName = "C++ Token: \"union\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.unsigned")]
	[Name("Token.unsigned")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_unsigned
	:
		ClassificationFormatDefinition
	{
		public Format_Token_unsigned()
		{
			DisplayName = "C++ Token: \"unsigned\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.using")]
	[Name("Token.using")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_using
	:
		ClassificationFormatDefinition
	{
		public Format_Token_using()
		{
			DisplayName = "C++ Token: \"using\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.virtual")]
	[Name("Token.virtual")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_virtual
	:
		ClassificationFormatDefinition
	{
		public Format_Token_virtual()
		{
			DisplayName = "C++ Token: \"virtual\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.void")]
	[Name("Token.void")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_void
	:
		ClassificationFormatDefinition
	{
		public Format_Token_void()
		{
			DisplayName = "C++ Token: \"void\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.volatile")]
	[Name("Token.volatile")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_volatile
	:
		ClassificationFormatDefinition
	{
		public Format_Token_volatile()
		{
			DisplayName = "C++ Token: \"volatile\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.wchar_t")]
	[Name("Token.wchar_t")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_wchar_t
	:
		ClassificationFormatDefinition
	{
		public Format_Token_wchar_t()
		{
			DisplayName = "C++ Token: \"wchar_t\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Token.while")]
	[Name("Token.while")]
	[BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
	[UserVisible(true)]
	[Order(After = Priority.High)]
	internal sealed class Format_Token_while
	:
		ClassificationFormatDefinition
	{
		public Format_Token_while()
		{
			DisplayName = "C++ Token: \"while\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Flow;
		}
	}
}