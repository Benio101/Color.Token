namespace Color.Token
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color Red			= Color.FromRgb(224, 128, 128);
			private  static readonly Color Lime			= Color.FromRgb(176, 224, 128);
			private  static readonly Color Blue			= Color.FromRgb(128, 176, 224);
			private  static readonly Color Violet		= Color.FromRgb(128, 128, 224);
			private  static readonly Color Purple		= Color.FromRgb(200, 176, 224);

			private  static readonly Color GreenDark	= Color.FromRgb( 80, 176,  80);
			private  static readonly Color YellowDark	= Color.FromRgb(176, 176,  80);
			private  static readonly Color RedDark		= Color.FromRgb(176,  80,  80);

			internal static readonly Color Public		= GreenDark;
			internal static readonly Color Protected	= YellowDark;
			internal static readonly Color Private		= RedDark;

			internal static readonly Color Assembler	= Purple;
			internal static readonly Color Flow			= Violet;
			internal static readonly Color Important	= Red;
			internal static readonly Color Keyword		= Blue;
			internal static readonly Color Static		= Red;
			internal static readonly Color Type			= Lime;

            internal static readonly Color FRotator		= Color.FromRgb(141, 158, 224);
            internal static readonly Color FString		= Color.FromRgb(239, 0, 200);
            internal static readonly Color FText		= Color.FromRgb(246, 170, 255);
            internal static readonly Color FTransform	= Color.FromRgb(242, 109, 0);
            internal static readonly Color FVector		= Color.FromRgb(227, 179, 29);
            internal static readonly Color FVector2D	= Color.FromRgb(1, 88, 202);
            internal static readonly Color int32		= Color.FromRgb(26, 208, 159);
            internal static readonly Color int8			= Color.FromRgb(0, 95, 87);
        }
	}
}