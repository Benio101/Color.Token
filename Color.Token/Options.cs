using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Color.Token
{
	internal static class Options
	{
		internal static string Tokens
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return "";

				var Page = (OptionsPage_Tokens) Package.GetDialogPage(typeof(OptionsPage_Tokens));
				if (Page == null) return "";

				return Page.OptionData;
			}
		}
	}

	[System.Runtime.InteropServices.Guid("025872CD-004B-4FF3-B3C6-18CCC18C0C93")]
	public class OptionsPage_Tokens
	:
		DialogPage
	{
		public static string GetDefaultData()
		{
			string Data = "";
			bool FirstToken = true;
			foreach (var Token in Default.Tokens)
			{
				if (FirstToken)
				{
					FirstToken = false;
				}
				else
				{
					Data += "\n";
				}

				Data += Token.Key;          // Token (regexp)
				Data += "\t" + Token.Value; // Color (uint, 1–32)
				Data += "\t" + "1";         // Macro (uint, 0–1)
			}

			return Data;
		}

		public string Data = GetDefaultData();

		public string OptionData
		{
			get
			{
				if (Data == "")
					return GetDefaultData();
				return Data;
			}

			set { Data = value; }
		}

		protected override IWin32Window Window
		{
			get
			{
				UserControl_Options_Tokens Page = new UserControl_Options_Tokens
				{
					OptionsPage = this
				};
				Page.Initialize();
				return Page;
			}
		}
	}
}