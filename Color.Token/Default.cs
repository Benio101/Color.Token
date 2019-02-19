namespace Color.Token
{
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

			internal static readonly Color Access    = GreenDark;
			internal static readonly Color Assembler = Purple;
			internal static readonly Color Flow      = BlueDark;
			internal static readonly Color Important = RedDark;
			internal static readonly Color Keyword   = Blue;
			internal static readonly Color Static    = Red;
			internal static readonly Color Type      = Green;
		}
	}
}