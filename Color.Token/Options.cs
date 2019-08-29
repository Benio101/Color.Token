using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace Color.Token
{
	public sealed class OptionsPage
		: DialogPage
	{
		[Category("Color.Token")]
		[DisplayName("Color macros")]
		[Description(
				"Color macros which text is exact as tokens "
			+	"(eg color `bool` macro defined by `stdbool.h` header in C)."
		)]
		public bool ColorMacro { set; get; } = false;
	}

	internal static class Options
	{
		// If macros should also be colored.
		internal static bool ColorMacro
		{
			get
			{
				var Package = Project.Package;

				var Page = (OptionsPage) Package?.GetDialogPage(typeof(OptionsPage));
				return Page != null && Page.ColorMacro;
			}
		}
	}
}