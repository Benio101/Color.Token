using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color.Token
{
	public partial class UserControl_Options_Tokens
	:
		UserControl
	{
		public UserControl_Options_Tokens()
		{
			InitializeComponent();
		}

		public void Initialize()
		{
			IsInitialized = true;
			if (!OptionsPage.OptionData.Contains('\n')) return;
			string[] Entries = OptionsPage.OptionData.Split('\n');
			foreach (string Entry in Entries)
			{
				if (!Entry.Contains('\t')) continue;
				string[] Fields = Entry.Split('\t');
				if (Fields.Length != 3) continue;

				string Token = Fields[0];
				string ID    = Fields[1];
				string Macro = Fields[2];

				DataGridView.Rows.Add(Token, ID, Macro);
			}
		}

		private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!IsInitialized) return;

			string Data = "";
			int RowNumber = 0;
			foreach (DataGridViewRow Row in DataGridView.Rows)
			{
				foreach (string Color in new string[]{"ID"})
				if (Row.Cells[Color].Value != null)
				{
					var Value = Convert.ToInt32(Row.Cells[Color].Value);
					Value = Math.Max(1, Math.Min(32, Value));
				}

				foreach (string Boolean in new string[]{"Macro"})
				if (Row.Cells[Boolean].Value != null)
				{
					var Value = Convert.ToInt32(Row.Cells[Boolean].Value);
					Value = Math.Max(0, Math.Min(1, Value));
				}

				if
				(		Row.Cells["Token"].Value == null
					||	Row.Cells["ID"]   .Value == null
					||	Row.Cells["Macro"].Value == null
				) continue;

				Data += Row.Cells["Token"].Value.ToString();
				Data += "\t" + Row.Cells["ID"].Value.ToString();
				Data += "\t" + Row.Cells["Macro"].Value.ToString();

				if (RowNumber != DataGridView.Rows.Count)
					Data += '\n';
			}

			OptionsPage.OptionData = Data;
		}

		private DataGridView DataGridView;
		internal OptionsPage_Tokens OptionsPage;
		private DataGridViewTextBoxColumn Token;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn Macro;
		bool IsInitialized = false;

		public void InitializeComponent()
		{
			DataGridView = new System.Windows.Forms.DataGridView
			{
				Width  = 600,
				Height = 600
			};

			DataGridView.CellValueChanged += OnCellValueChanged;

			Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ID    = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Macro = new System.Windows.Forms.DataGridViewTextBoxColumn();

			SuspendLayout();

			DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {Token, ID, Macro});
			DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			DataGridView.Location = new System.Drawing.Point(0, 0);
			DataGridView.Name = "DataGridView";
			DataGridView.RowHeadersWidth = 50;
			DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			DataGridView.Size = new System.Drawing.Size(600, 600);
			DataGridView.TabIndex = 0;

			System.Windows.Forms.DataGridViewCellStyle TokenFieldStyle = new System.Windows.Forms.DataGridViewCellStyle
			{
				Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
			};

			Token.DefaultCellStyle = TokenFieldStyle;
			Token.HeaderText = "Token (regexp)";
			Token.MinimumWidth = 100;
			Token.Name = "Token";
			Token.Width = 400;

			System.Windows.Forms.DataGridViewCellStyle IDFieldStyle = new System.Windows.Forms.DataGridViewCellStyle
			{
				Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight,
				Format    = "N0",
				NullValue = "1",
			};

			ID.DefaultCellStyle = IDFieldStyle;
			ID.HeaderText = "Color";
			ID.ToolTipText = "C++ Token Color ID (uint, 1–32)";
			ID.MinimumWidth = 50;
			ID.Name = "ID";
			ID.Width = 50;
			
			System.Windows.Forms.DataGridViewCellStyle MacroFieldStyle = new System.Windows.Forms.DataGridViewCellStyle
			{
				Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight,
				NullValue = "1",
			};

			Macro.DefaultCellStyle = MacroFieldStyle;
			Macro.HeaderText = "Macro";
			Macro.ToolTipText = "If color macros which text is exact as this token.";
			Macro.MinimumWidth = 50;
			Macro.Name = "Macro";
			Macro.Width = 50;

			Controls.Add(DataGridView);
			Name = "UserControl_Options_Tokens";
			ResumeLayout(false);
		}
	}
}