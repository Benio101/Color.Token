namespace Color.Token
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color Red        = Color.FromRgb(224, 128, 128);
			private  static readonly Color Lime       = Color.FromRgb(176, 224, 128);
			private  static readonly Color Blue       = Color.FromRgb(128, 176, 224);
			private  static readonly Color Violet     = Color.FromRgb(128, 128, 224);
			private  static readonly Color Purple     = Color.FromRgb(200, 176, 224);

			private  static readonly Color GreenDark  = Color.FromRgb( 80, 176,  80);
			private  static readonly Color YellowDark = Color.FromRgb(176, 176,  80);
			private  static readonly Color RedDark    = Color.FromRgb(176,  80,  80);

			internal static readonly Color Public     = GreenDark;
			internal static readonly Color Protected  = YellowDark;
			internal static readonly Color Private    = RedDark;

			internal static readonly Color Assembler  = Purple;
			internal static readonly Color Flow       = Violet;
			internal static readonly Color Important  = Red;
			internal static readonly Color Keyword    = Blue;
			internal static readonly Color Static     = Red;
			internal static readonly Color Type       = Lime;
		}
	}
}