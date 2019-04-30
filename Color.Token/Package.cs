using System;
using System.Runtime.InteropServices;
using System.Threading;

using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;

namespace Color.Token
{
	[ProvideAutoLoad(VSConstants.UICONTEXT.VCProject_string, PackageAutoLoadFlags.BackgroundLoad)]
	[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
	[InstalledProductRegistration("#110", "#112", "1.2", IconResourceID = 400)]
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[Guid("0000436F-6C6F-722E-546F-6B656E2E6374")]
	[ProvideOptionPage(typeof(OptionsPage), "Color.Token", "Options", 0, 0, true)]
	public sealed class Package
		: AsyncPackage
	{
		protected override async System.Threading.Tasks.Task InitializeAsync(
			CancellationToken cancellationToken,
			IProgress<ServiceProgressData> progress
		){
			Project.Package = this;

			await base.InitializeAsync(cancellationToken, progress);
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
		}
	}

	internal static class Project
	{
		internal static Package Package = null;
	}
}