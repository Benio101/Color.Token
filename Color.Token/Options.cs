using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace Color.Token
{
	public sealed class OptionsPage
	:
		DialogPage
	{
		[
			Category    ("Color.Token"),
			DisplayName ("Color macros"),
			Description
			(
					"Color macros which text is exact as tokens "
				+	"(eg color `bool` macro defined by `stdbool.h` header in C)."
			)
		]

		// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
		// Reason: Setter is automated by externals. Removing it shall made option readonly.

		public bool ColorMacro { set; get; } = false;

		// ReSharper restore AutoPropertyCanBeMadeGetOnly.Global
	}

	internal static class Options
	{
		// If macros should also be colored.
		internal static bool ColorMacro
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return false;

				var Page = Package.GetDialogPage(typeof(OptionsPage)) as OptionsPage;
				if (Page == null) return false;

				return Page.ColorMacro;
			}
		}
	}
}