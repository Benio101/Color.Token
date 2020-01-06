using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace Color.Token
{
	[
		PackageRegistration
		(
			AllowsBackgroundLoading = true,
			UseManagedResourcesOnly = true
		),

		ProvideAutoLoad
		(
			VSConstants.UICONTEXT.ShellInitialized_string,
			PackageAutoLoadFlags.BackgroundLoad
		),

		InstalledProductRegistration("#110", "#112", "1.3", IconResourceID = 400),
		Guid("0000436F-6C6F-722E-546F-6B656E2E6374"),

		ProvideMenuResource("Menus.ctmenu", 1),
		ProvideOptionPage(typeof(OptionsPage_Tokens), "Color.Token", "Tokens", 0, 0, true)
	]

	public sealed class Package
	:
		AsyncPackage
	{
		protected override async Task InitializeAsync
		(
			CancellationToken              Token,
			IProgress<ServiceProgressData> Progress
		)
		{
			Project.Package = this;

			await base.InitializeAsync(Token, Progress);
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Token);
		}
	}

	internal static class Project
	{
		internal static Package Package;
	}
}