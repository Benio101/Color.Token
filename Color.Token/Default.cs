namespace Color.Token
{
    using System.Collections.Generic;
    using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color Blue      = Color.FromRgb(128, 176, 224);
			private  static readonly Color BlueDark  = Color.FromRgb( 96, 128, 224);
			private  static readonly Color Green     = Color.FromRgb(176, 224, 128);
			private  static readonly Color GreenDark = Color.FromRgb(128, 176,  96);
			private  static readonly Color Purple    = Color.FromRgb(176, 128, 224);
			private  static readonly Color Red       = Color.FromRgb(224, 128, 128);
			private  static readonly Color RedDark   = Color.FromRgb(224,  96,  96);
			
			internal static readonly Color Keyword   = Blue;      // 1
			internal static readonly Color Type      = Green;     // 2
			internal static readonly Color Flow      = BlueDark;  // 3
			internal static readonly Color Static    = Red;       // 4
			internal static readonly Color Important = RedDark;   // 5
			internal static readonly Color Access    = GreenDark; // 6
			internal static readonly Color Assembler = Purple;    // 7
		}

		internal static class Strings
		{
			internal static readonly string Keyword   = "1";
			internal static readonly string Type      = "2";
			internal static readonly string Flow      = "3";
			internal static readonly string Static    = "4";
			internal static readonly string Important = "5";
			internal static readonly string Access    = "6";
			internal static readonly string Assembler = "7";
		}

		internal static readonly Dictionary<string, string> Tokens = new Dictionary<string, string>
		{
			{"alignas",						Strings.Keyword},
			{"alignof",						Strings.Keyword},
			{"_{0,2}asm_{0,2}",				Strings.Assembler},
			{"atomic_cancel",				Strings.Keyword},
			{"atomic_commit",				Strings.Keyword},
			{"atomic_noexcept",				Strings.Keyword},
			{"auto",						Strings.Type},
			{"bool",						Strings.Type},
			{"break",						Strings.Flow},
			{"case",						Strings.Flow},
			{"catch",						Strings.Flow},
			{"char",						Strings.Type},
			{"char8_t",						Strings.Type},
			{"char16_t",					Strings.Type},
			{"char32_t",					Strings.Type},
			{"class",						Strings.Keyword},
			{"concept",						Strings.Keyword},
			{"const",						Strings.Keyword},
			{"consteval",					Strings.Keyword},
			{"constexpr",					Strings.Keyword},
			{"const_cast",					Strings.Keyword},
			{"continue",					Strings.Flow},
			{"co_await",					Strings.Flow},
			{"co_return",					Strings.Flow},
			{"co_yield",					Strings.Flow},
			{"decltype",					Strings.Keyword},
			{@"default(?![ \t\v\n\f]*:)",	Strings.Keyword},   // function definition
			{@"default(?=[ \t\v\n\f]*:)",	Strings.Flow},      // switch statement
			{"delete",						Strings.Important},
			{"do",							Strings.Flow},
			{"double",						Strings.Type},
			{"dynamic_cast",				Strings.Keyword},
			{"else",						Strings.Flow},
			{"enum",						Strings.Keyword},
			{"explicit",					Strings.Keyword},
			{"export",						Strings.Keyword},
			{"extern",						Strings.Keyword},
			{"false",						Strings.Static},
			{"final",						Strings.Keyword},
			{"float",						Strings.Type},
			{"for",							Strings.Flow},
			{"friend",						Strings.Keyword},
			{"goto",						Strings.Flow},
			{"if",							Strings.Flow},
			{"import",						Strings.Keyword},
			{"inline",						Strings.Keyword},
			{"int",							Strings.Type},
			{"long",						Strings.Type},
			{"module",						Strings.Keyword},
			{"mutable",						Strings.Keyword},
			{"namespace",					Strings.Keyword},
			{"new",							Strings.Important},
			{"noexcept",					Strings.Keyword},
			{"nullptr",						Strings.Static},
			{"operator",					Strings.Keyword},
			{"override",					Strings.Keyword},
			{"private",						Strings.Access},
			{"protected",					Strings.Access},
			{"public",						Strings.Access},
			{"reflexpr",					Strings.Keyword},
			{"reinterpret_cast",			Strings.Keyword},
			{"requires",					Strings.Keyword},
			{"return",						Strings.Flow},
			{"short",						Strings.Type},
			{"signed",						Strings.Type},
			{"sizeof",						Strings.Keyword},
			{"static",						Strings.Keyword},
			{"static_assert",				Strings.Keyword},
			{"static_cast",					Strings.Keyword},
			{"struct",						Strings.Keyword},
			{"switch",						Strings.Flow},
			{"synchronized",				Strings.Keyword},
			{"template",					Strings.Keyword},
			{"this",						Strings.Keyword},
			{"thread_local",				Strings.Keyword},
			{"throw",						Strings.Flow},
			{"transaction_safe",			Strings.Keyword},
			{"transaction_safe_dynamic",	Strings.Keyword},
			{"true",						Strings.Static},
			{"try",							Strings.Flow},
			{"typedef",						Strings.Keyword},
			{"typeid",						Strings.Keyword},
			{"typename",					Strings.Keyword},
			{"union",						Strings.Keyword},
			{"unsigned",					Strings.Type},
			{"using",						Strings.Keyword},
			{"virtual",						Strings.Keyword},
			{"void",						Strings.Type},
			{"volatile",					Strings.Keyword},
			{"wchar_t",						Strings.Type},
			{"while",						Strings.Flow},
		};
	}
}