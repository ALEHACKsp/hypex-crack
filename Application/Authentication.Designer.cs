// Token: 0x0200005E RID: 94
public partial class Authentication : global::System.Windows.Forms.Form
{
	// Token: 0x060005EA RID: 1514 RVA: 0x0103F1B4 File Offset: 0x0103D3B4
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Authentication));
		this.grpLogin = new global::System.Windows.Forms.GroupBox();
		this.cProgressBar1 = new global::tcp_moe_client.Classes.CProgressBar();
		this.status = new global::MetroFramework.Controls.MetroLabel();
		this.lblUsername = new global::MetroFramework.Controls.MetroLabel();
		this.status1 = new global::MetroFramework.Controls.MetroLabel();
		this.metroTile1 = new global::MetroFramework.Controls.MetroTile();
		this.label1 = new global::MetroFramework.Controls.MetroLabel();
		this.chkRemember = new global::MetroFramework.Controls.MetroCheckBox();
		this.btnLogin = new global::MetroFramework.Controls.MetroButton();
		this.txtPassword = new global::System.Windows.Forms.TextBox();
		this.txtUsername = new global::System.Windows.Forms.TextBox();
		this.picLogo = new global::System.Windows.Forms.PictureBox();
		this.grpLogin.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picLogo).BeginInit();
		base.SuspendLayout();
		this.grpLogin.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.grpLogin.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.grpLogin.Controls.Add(this.cProgressBar1);
		this.grpLogin.Controls.Add(this.status);
		this.grpLogin.Controls.Add(this.lblUsername);
		this.grpLogin.Controls.Add(this.status1);
		this.grpLogin.Controls.Add(this.metroTile1);
		this.grpLogin.Controls.Add(this.label1);
		this.grpLogin.Controls.Add(this.chkRemember);
		this.grpLogin.Controls.Add(this.btnLogin);
		this.grpLogin.Controls.Add(this.txtPassword);
		this.grpLogin.Controls.Add(this.txtUsername);
		this.grpLogin.Location = new global::System.Drawing.Point(-1, 93);
		this.grpLogin.Name = "grpLogin";
		this.grpLogin.Size = new global::System.Drawing.Size(312, 165);
		this.grpLogin.TabIndex = 0;
		this.grpLogin.TabStop = false;
		this.grpLogin.Text = " ";
		this.cProgressBar1.ForeColor = global::System.Drawing.Color.Red;
		this.cProgressBar1.Location = new global::System.Drawing.Point(-3, 20);
		this.cProgressBar1.Name = "cProgressBar1";
		this.cProgressBar1.Size = new global::System.Drawing.Size(316, 135);
		this.cProgressBar1.TabIndex = 12;
		this.cProgressBar1.Visible = false;
		this.cProgressBar1.Click += new global::System.EventHandler(this.cProgressBar1_Click);
		this.status.AutoSize = true;
		this.status.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.status.ForeColor = global::System.Drawing.Color.FromArgb(170, 170, 170);
		this.status.Location = new global::System.Drawing.Point(1, 0);
		this.status.Name = "status";
		this.status.Size = new global::System.Drawing.Size(86, 19);
		this.status.TabIndex = 13;
		this.status.Text = "Downloading";
		this.status.Theme = 2;
		this.status.Visible = false;
		this.lblUsername.AutoSize = true;
		this.lblUsername.Location = new global::System.Drawing.Point(40, 30);
		this.lblUsername.Name = "lblUsername";
		this.lblUsername.Size = new global::System.Drawing.Size(68, 19);
		this.lblUsername.TabIndex = 10;
		this.lblUsername.Text = "Username";
		this.lblUsername.Theme = 2;
		this.status1.AutoSize = true;
		this.status1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.status1.ForeColor = global::System.Drawing.Color.FromArgb(170, 170, 170);
		this.status1.Location = new global::System.Drawing.Point(273, 0);
		this.status1.Name = "status1";
		this.status1.Size = new global::System.Drawing.Size(39, 19);
		this.status1.TabIndex = 14;
		this.status1.Text = "100%";
		this.status1.Theme = 2;
		this.status1.Visible = false;
		this.metroTile1.ActiveControl = null;
		this.metroTile1.Enabled = false;
		this.metroTile1.Location = new global::System.Drawing.Point(0, 10);
		this.metroTile1.Name = "metroTile1";
		this.metroTile1.Size = new global::System.Drawing.Size(383, 10);
		this.metroTile1.TabIndex = 11;
		this.metroTile1.Text = "metroTile1";
		this.metroTile1.UseSelectable = true;
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(40, 76);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(63, 19);
		this.label1.TabIndex = 9;
		this.label1.Text = "Password";
		this.label1.Theme = 2;
		this.chkRemember.AutoSize = true;
		this.chkRemember.Location = new global::System.Drawing.Point(42, 125);
		this.chkRemember.Name = "chkRemember";
		this.chkRemember.Size = new global::System.Drawing.Size(101, 15);
		this.chkRemember.TabIndex = 8;
		this.chkRemember.Text = "Remember me";
		this.chkRemember.Theme = 2;
		this.chkRemember.UseSelectable = true;
		this.btnLogin.Enabled = false;
		this.btnLogin.Location = new global::System.Drawing.Point(190, 125);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new global::System.Drawing.Size(75, 23);
		this.btnLogin.TabIndex = 7;
		this.btnLogin.Text = "Login";
		this.btnLogin.Theme = 2;
		this.btnLogin.UseSelectable = true;
		this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
		this.txtPassword.BackColor = global::System.Drawing.Color.DarkGray;
		this.txtPassword.Location = new global::System.Drawing.Point(42, 95);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.Size = new global::System.Drawing.Size(223, 27);
		this.txtPassword.TabIndex = 4;
		this.txtPassword.UseSystemPasswordChar = true;
		this.txtPassword.TextChanged += new global::System.EventHandler(this.txtUsername_TextChanged);
		this.txtUsername.BackColor = global::System.Drawing.Color.DarkGray;
		this.txtUsername.Font = new global::System.Drawing.Font("Calibri Light", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtUsername.Location = new global::System.Drawing.Point(42, 49);
		this.txtUsername.Name = "txtUsername";
		this.txtUsername.Size = new global::System.Drawing.Size(223, 26);
		this.txtUsername.TabIndex = 2;
		this.txtUsername.TextChanged += new global::System.EventHandler(this.txtUsername_TextChanged);
		this.picLogo.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.picLogo.BackgroundImage = global::Class24.Bitmap_27;
		this.picLogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
		this.picLogo.Location = new global::System.Drawing.Point(-4, 0);
		this.picLogo.Name = "picLogo";
		this.picLogo.Size = new global::System.Drawing.Size(316, 90);
		this.picLogo.TabIndex = 2;
		this.picLogo.TabStop = false;
		base.AcceptButton = this.btnLogin;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 20f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		base.ClientSize = new global::System.Drawing.Size(309, 251);
		base.Controls.Add(this.picLogo);
		base.Controls.Add(this.grpLogin);
		this.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Authentication";
		base.ShowIcon = false;
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Authentication_FormClosing);
		base.Load += new global::System.EventHandler(this.Authentication_Load);
		base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Authentication_Paint);
		this.grpLogin.ResumeLayout(false);
		this.grpLogin.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picLogo).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000253 RID: 595
	private global::System.Windows.Forms.PictureBox picLogo;

	// Token: 0x04000254 RID: 596
	public global::tcp_moe_client.Classes.CProgressBar cProgressBar1;

	// Token: 0x04000255 RID: 597
	public global::MetroFramework.Controls.MetroLabel status;

	// Token: 0x04000256 RID: 598
	public global::MetroFramework.Controls.MetroTile metroTile1;

	// Token: 0x04000257 RID: 599
	private global::System.Windows.Forms.GroupBox grpLogin;

	// Token: 0x04000258 RID: 600
	private global::System.Windows.Forms.TextBox txtPassword;

	// Token: 0x04000259 RID: 601
	private global::System.Windows.Forms.TextBox txtUsername;

	// Token: 0x0400025A RID: 602
	private global::MetroFramework.Controls.MetroCheckBox chkRemember;

	// Token: 0x0400025B RID: 603
	private global::MetroFramework.Controls.MetroButton btnLogin;

	// Token: 0x0400025C RID: 604
	private global::MetroFramework.Controls.MetroLabel lblUsername;

	// Token: 0x0400025D RID: 605
	private global::MetroFramework.Controls.MetroLabel label1;

	// Token: 0x0400025E RID: 606
	public global::MetroFramework.Controls.MetroLabel status1;
}
