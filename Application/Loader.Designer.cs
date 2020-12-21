// Token: 0x0200006F RID: 111
public partial class Loader : global::System.Windows.Forms.Form
{
	// Token: 0x0600086E RID: 2158 RVA: 0x010538F8 File Offset: 0x01051AF8
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Loader));
		this.lstCheatList = new global::System.Windows.Forms.ListBox();
		this.grpCheatInfo = new global::System.Windows.Forms.GroupBox();
		this.lblInfo = new global::System.Windows.Forms.Label();
		this.grpCheatList = new global::System.Windows.Forms.GroupBox();
		this.loadBtn = new global::MetroFramework.Controls.MetroButton();
		this.status = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.prgLoad = new global::tcp_moe_client.Classes.CProgressBar();
		this.btnLoad = new global::System.Windows.Forms.Button();
		this.grpUserInfo = new global::System.Windows.Forms.GroupBox();
		this.lblRank = new global::System.Windows.Forms.Label();
		this.lblUser = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.label1 = new global::System.Windows.Forms.Label();
		this.picLogo = new global::System.Windows.Forms.PictureBox();
		this.betterFolderBrowser_0 = new global::WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.icontainer_0);
		this.grpCheatInfo.SuspendLayout();
		this.grpCheatList.SuspendLayout();
		this.grpUserInfo.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picLogo).BeginInit();
		base.SuspendLayout();
		this.lstCheatList.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.lstCheatList.ForeColor = global::System.Drawing.Color.DarkGray;
		this.lstCheatList.FormattingEnabled = true;
		this.lstCheatList.ItemHeight = 18;
		this.lstCheatList.Location = new global::System.Drawing.Point(11, 26);
		this.lstCheatList.Name = "lstCheatList";
		this.lstCheatList.Size = new global::System.Drawing.Size(252, 130);
		this.lstCheatList.TabIndex = 0;
		this.lstCheatList.SelectedIndexChanged += new global::System.EventHandler(this.lstCheatList_SelectedIndexChanged);
		this.grpCheatInfo.Controls.Add(this.lblInfo);
		this.grpCheatInfo.Font = new global::System.Drawing.Font("Calibri Light", 11.25f);
		this.grpCheatInfo.ForeColor = global::System.Drawing.Color.DarkGray;
		this.grpCheatInfo.Location = new global::System.Drawing.Point(293, 109);
		this.grpCheatInfo.Name = "grpCheatInfo";
		this.grpCheatInfo.Size = new global::System.Drawing.Size(294, 219);
		this.grpCheatInfo.TabIndex = 5;
		this.grpCheatInfo.TabStop = false;
		this.grpCheatInfo.Text = "Information";
		this.lblInfo.Location = new global::System.Drawing.Point(11, 25);
		this.lblInfo.Name = "lblInfo";
		this.lblInfo.Size = new global::System.Drawing.Size(273, 184);
		this.lblInfo.TabIndex = 0;
		this.lblInfo.Text = "-";
		this.grpCheatList.Controls.Add(this.loadBtn);
		this.grpCheatList.Controls.Add(this.status);
		this.grpCheatList.Controls.Add(this.label3);
		this.grpCheatList.Controls.Add(this.label2);
		this.grpCheatList.Controls.Add(this.prgLoad);
		this.grpCheatList.Controls.Add(this.btnLoad);
		this.grpCheatList.Controls.Add(this.lstCheatList);
		this.grpCheatList.Font = new global::System.Drawing.Font("Calibri Light", 11.25f);
		this.grpCheatList.ForeColor = global::System.Drawing.Color.DarkGray;
		this.grpCheatList.Location = new global::System.Drawing.Point(12, 109);
		this.grpCheatList.Name = "grpCheatList";
		this.grpCheatList.Size = new global::System.Drawing.Size(275, 219);
		this.grpCheatList.TabIndex = 6;
		this.grpCheatList.TabStop = false;
		this.grpCheatList.Text = "Products";
		this.loadBtn.Enabled = false;
		this.loadBtn.Location = new global::System.Drawing.Point(11, 176);
		this.loadBtn.Name = "loadBtn";
		this.loadBtn.Size = new global::System.Drawing.Size(84, 32);
		this.loadBtn.TabIndex = 9;
		this.loadBtn.Text = "Load";
		this.loadBtn.Theme = 2;
		this.loadBtn.UseSelectable = true;
		this.loadBtn.Click += new global::System.EventHandler(this.loadBtn_Click);
		this.status.AutoSize = true;
		this.status.Font = new global::System.Drawing.Font("Calibri Light", 10f);
		this.status.Location = new global::System.Drawing.Point(101, 159);
		this.status.Name = "status";
		this.status.Size = new global::System.Drawing.Size(56, 17);
		this.status.TabIndex = 2;
		this.status.Text = "Injection";
		this.status.Visible = false;
		this.label3.Location = new global::System.Drawing.Point(94, 159);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(10, 50);
		this.label3.TabIndex = 11;
		this.label2.Location = new global::System.Drawing.Point(101, 158);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(162, 21);
		this.label2.TabIndex = 10;
		this.prgLoad.Location = new global::System.Drawing.Point(102, 177);
		this.prgLoad.Name = "prgLoad";
		this.prgLoad.Size = new global::System.Drawing.Size(161, 32);
		this.prgLoad.TabIndex = 8;
		this.prgLoad.Visible = false;
		this.prgLoad.Click += new global::System.EventHandler(this.prgLoad_Click);
		this.btnLoad.BackColor = global::System.Drawing.Color.DarkGray;
		this.btnLoad.Enabled = false;
		this.btnLoad.Location = new global::System.Drawing.Point(11, 176);
		this.btnLoad.Name = "btnLoad";
		this.btnLoad.Size = new global::System.Drawing.Size(84, 33);
		this.btnLoad.TabIndex = 7;
		this.btnLoad.Text = "Load";
		this.btnLoad.UseVisualStyleBackColor = false;
		this.grpUserInfo.Controls.Add(this.lblRank);
		this.grpUserInfo.Controls.Add(this.lblUser);
		this.grpUserInfo.Font = new global::System.Drawing.Font("Calibri Light", 11.25f);
		this.grpUserInfo.ForeColor = global::System.Drawing.Color.DarkGray;
		this.grpUserInfo.Location = new global::System.Drawing.Point(293, 14);
		this.grpUserInfo.Name = "grpUserInfo";
		this.grpUserInfo.Size = new global::System.Drawing.Size(294, 84);
		this.grpUserInfo.TabIndex = 6;
		this.grpUserInfo.TabStop = false;
		this.grpUserInfo.Text = "User Information";
		this.lblRank.AutoSize = true;
		this.lblRank.Location = new global::System.Drawing.Point(11, 50);
		this.lblRank.Name = "lblRank";
		this.lblRank.Size = new global::System.Drawing.Size(101, 18);
		this.lblRank.TabIndex = 1;
		this.lblRank.Text = "Rank: {{ RANK }}";
		this.lblUser.AutoSize = true;
		this.lblUser.Location = new global::System.Drawing.Point(11, 25);
		this.lblUser.Name = "lblUser";
		this.lblUser.Size = new global::System.Drawing.Size(135, 18);
		this.lblUser.TabIndex = 0;
		this.lblUser.Text = "User: {{ USERNAME }}";
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.label1.Location = new global::System.Drawing.Point(0, -9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(604, 22);
		this.label1.TabIndex = 7;
		this.picLogo.BackgroundImage = global::Class24.Bitmap_27;
		this.picLogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
		this.picLogo.Location = new global::System.Drawing.Point(12, 14);
		this.picLogo.Name = "picLogo";
		this.picLogo.Size = new global::System.Drawing.Size(275, 89);
		this.picLogo.TabIndex = 3;
		this.picLogo.TabStop = false;
		this.betterFolderBrowser_0.Multiselect = false;
		this.betterFolderBrowser_0.RootFolder = "C:\\";
		this.betterFolderBrowser_0.Title = "Select 'common' folder! Example: 'C:\\Steam\\steamapps\\common'";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 20f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		base.ClientSize = new global::System.Drawing.Size(599, 338);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.grpUserInfo);
		base.Controls.Add(this.grpCheatList);
		base.Controls.Add(this.grpCheatInfo);
		base.Controls.Add(this.picLogo);
		this.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.ForeColor = global::System.Drawing.Color.DarkGray;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		base.MaximizeBox = false;
		base.Name = "Loader";
		base.ShowIcon = false;
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Loader_FormClosing);
		base.Load += new global::System.EventHandler(this.Loader_Load);
		base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Loader_Paint);
		this.grpCheatInfo.ResumeLayout(false);
		this.grpCheatList.ResumeLayout(false);
		this.grpCheatList.PerformLayout();
		this.grpUserInfo.ResumeLayout(false);
		this.grpUserInfo.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picLogo).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x0400041A RID: 1050
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x0400041B RID: 1051
	private global::System.Windows.Forms.ListBox lstCheatList;

	// Token: 0x0400041C RID: 1052
	private global::System.Windows.Forms.PictureBox picLogo;

	// Token: 0x0400041D RID: 1053
	private global::System.Windows.Forms.GroupBox grpCheatInfo;

	// Token: 0x0400041E RID: 1054
	private global::System.Windows.Forms.Label lblInfo;

	// Token: 0x0400041F RID: 1055
	private global::System.Windows.Forms.GroupBox grpCheatList;

	// Token: 0x04000420 RID: 1056
	private global::System.Windows.Forms.GroupBox grpUserInfo;

	// Token: 0x04000421 RID: 1057
	private global::System.Windows.Forms.Label lblUser;

	// Token: 0x04000422 RID: 1058
	private global::System.Windows.Forms.Button btnLoad;

	// Token: 0x04000423 RID: 1059
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000424 RID: 1060
	private global::System.Windows.Forms.Label lblRank;

	// Token: 0x04000425 RID: 1061
	private global::MetroFramework.Controls.MetroButton loadBtn;

	// Token: 0x04000426 RID: 1062
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000427 RID: 1063
	public global::tcp_moe_client.Classes.CProgressBar prgLoad;

	// Token: 0x04000428 RID: 1064
	public global::System.Windows.Forms.Label status;

	// Token: 0x04000429 RID: 1065
	private global::System.Windows.Forms.Label label3;

	// Token: 0x0400042A RID: 1066
	private global::System.Windows.Forms.Label label2;

	// Token: 0x0400042B RID: 1067
	private global::WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser_0;
}
