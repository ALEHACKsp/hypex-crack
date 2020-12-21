using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;

// Token: 0x0200001F RID: 31
public class sett6 : UserControl
{
	// Token: 0x0600016D RID: 365 RVA: 0x0102FA34 File Offset: 0x0102DC34
	public sett6(int int_2)
	{
		this.int_1 = int_2;
		this.InitializeComponent();
		this.SelectedWPN.Text = "";
		this.status.Text = "";
		this.timer_1.Start();
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0102FA88 File Offset: 0x0102DC88
	private void method_0()
	{
		this.method_3();
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0102FA9C File Offset: 0x0102DC9C
	public int method_1()
	{
		return this.int_1;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0102FAB0 File Offset: 0x0102DCB0
	public bool method_2()
	{
		if (this.int_0 >= 0 && this.int_0 <= 9)
		{
			if (Settings.Default.Terminate == "TAB")
			{
				Settings.Default.TerminateKey = (Keys)Enum.Parse(typeof(Keys), "TAB", true);
			}
			if (Settings.Default.Crosshair == "*")
			{
				Settings.Default.CrosshairKey = (Keys)Enum.Parse(typeof(Keys), "Multiply", true);
			}
			if (Settings.Default.NextWeapon == "-")
			{
				Settings.Default.NextWeaponKey = (Keys)Enum.Parse(typeof(Keys), "Subtract", true);
			}
			this.timer_1.Stop();
			this.status.Text = "";
			Settings.Default.SavedWeapon = this.int_0;
			Settings.Default.Save();
			return true;
		}
		this.timer_2.Start();
		return false;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0102FBC8 File Offset: 0x0102DDC8
	private void method_3()
	{
		switch (this.int_1)
		{
		case 1:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.ak;
			this.sett3.Text = "Sensitivity: " + Settings.Default.aksensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.akfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.akrapid;
			this.method_8(Settings.Default.rageSwitchAK);
			this.firerateBar.Value = Settings.Default.akfire;
			this.bunifuTrackbar1.Value = Settings.Default.aksensY;
			break;
		case 2:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.lr;
			this.sett3.Text = "Sensitivity: " + Settings.Default.lrsensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.lrfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.lrrapid;
			this.method_8(Settings.Default.rageSwitchLR);
			this.firerateBar.Value = Settings.Default.lrfire;
			this.bunifuTrackbar1.Value = Settings.Default.lrsensY;
			break;
		case 3:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.thompson;
			this.sett3.Text = "Sensitivity: " + Settings.Default.thompsonsensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.thompsonfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.thompsonrapid;
			this.method_8(Settings.Default.rageSwitchTHOMPSON);
			this.firerateBar.Value = Settings.Default.thompsonfire;
			this.bunifuTrackbar1.Value = Settings.Default.thompsonsensY;
			break;
		case 4:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.m249;
			this.sett3.Text = "Sensitivity: " + Settings.Default.m249sensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.m249fire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.m249rapid;
			this.method_8(Settings.Default.rageSwitchM249);
			this.firerateBar.Value = Settings.Default.m249fire;
			this.bunifuTrackbar1.Value = Settings.Default.m249sensY;
			break;
		case 5:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.p250;
			this.sett3.Text = "Sensitivity: " + Settings.Default.p250sensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.p250fire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.p250rapid;
			this.method_8(Settings.Default.rageSwitchP250);
			this.firerateBar.Value = Settings.Default.p250fire;
			this.bunifuTrackbar1.Value = Settings.Default.p250sensY;
			break;
		case 6:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.semi;
			this.sett3.Text = "Sensitivity: " + Settings.Default.semisensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.semifire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.semirapid;
			this.method_8(Settings.Default.rageSwitchSEMI);
			this.firerateBar.Value = Settings.Default.semifire;
			this.bunifuTrackbar1.Value = Settings.Default.semisensY;
			break;
		case 7:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.baretta;
			this.sett3.Text = "Sensitivity: " + Settings.Default.barettasensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.barettafire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.barettarapid;
			this.method_8(Settings.Default.rageSwitchBARETTA);
			this.firerateBar.Value = Settings.Default.barettafire;
			this.bunifuTrackbar1.Value = Settings.Default.barettasensY;
			break;
		case 8:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.python;
			this.sett3.Text = "Sensitivity: " + Settings.Default.pythonsensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.pythonfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.pythonrapid;
			this.method_8(Settings.Default.rageSwitchPYTHON);
			this.firerateBar.Value = Settings.Default.pythonfire;
			this.bunifuTrackbar1.Value = Settings.Default.pythonsensY;
			break;
		case 9:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.revolver;
			this.sett3.Text = "Sensitivity: " + Settings.Default.revolversensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.revolverfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.revolverrapid;
			this.method_8(Settings.Default.rageSwitchREVOLVER);
			this.firerateBar.Value = Settings.Default.revolverfire;
			this.bunifuTrackbar1.Value = Settings.Default.revolversensY;
			break;
		case 10:
			this.label1.Text = "Profile " + this.int_1.ToString();
			this.sett0.Text = "Settings";
			this.sett1.Text = "Terminate hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.Terminate;
			this.sett2.Text = "Profile hotkey: " + Settings.Default.Modifier + " + " + Settings.Default.nailgun;
			this.sett3.Text = "Sensitivity: " + Settings.Default.nailgunsensY;
			this.sett4.Text = "Rage Sensitivity: " + Settings.Default.nailgunfire;
			this.sett5.Text = "Rapidfire rate: " + Settings.Default.nailgunrapid;
			this.method_8(Settings.Default.rageSwitchNAILGUN);
			this.firerateBar.Value = Settings.Default.nailgunfire;
			this.bunifuTrackbar1.Value = Settings.Default.nailgunsensY;
			break;
		}
		if (this.sett2.Text == "Profile hotkey: " + Settings.Default.Modifier + " + ")
		{
			this.sett2.Text = "Profile hotkey: Unassigned";
		}
		BunifuCustomLabel bunifuCustomLabel = this.sett5;
		bunifuCustomLabel.Text += " ms";
	}

	// Token: 0x06000172 RID: 370 RVA: 0x01030888 File Offset: 0x0102EA88
	private void method_4(int int_2)
	{
		switch (this.int_1)
		{
		case 1:
			Settings.Default.aksensY = int_2;
			return;
		case 2:
			Settings.Default.lrsensY = int_2;
			return;
		case 3:
			Settings.Default.thompsonsensY = int_2;
			return;
		case 4:
			Settings.Default.m249sensY = int_2;
			return;
		case 5:
			Settings.Default.p250sensY = int_2;
			return;
		case 6:
			Settings.Default.semisensY = int_2;
			return;
		case 7:
			Settings.Default.barettasensY = int_2;
			return;
		case 8:
			Settings.Default.pythonsensY = int_2;
			return;
		case 9:
			Settings.Default.revolversensY = int_2;
			return;
		case 10:
			Settings.Default.nailgunsensY = int_2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06000173 RID: 371 RVA: 0x01030944 File Offset: 0x0102EB44
	private void method_5(int int_2)
	{
		switch (this.int_1)
		{
		case 1:
			Settings.Default.akfire = int_2;
			return;
		case 2:
			Settings.Default.lrfire = int_2;
			return;
		case 3:
			Settings.Default.thompsonfire = int_2;
			return;
		case 4:
			Settings.Default.m249fire = int_2;
			return;
		case 5:
			Settings.Default.p250fire = int_2;
			return;
		case 6:
			Settings.Default.semifire = int_2;
			return;
		case 7:
			Settings.Default.barettafire = int_2;
			return;
		case 8:
			Settings.Default.pythonfire = int_2;
			return;
		case 9:
			Settings.Default.revolverfire = int_2;
			return;
		case 10:
			Settings.Default.nailgunfire = int_2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x01030A00 File Offset: 0x0102EC00
	private void method_6(int int_2)
	{
		switch (this.int_1)
		{
		case 1:
			Settings.Default.akrapid = int_2;
			return;
		case 2:
			Settings.Default.lrrapid = int_2;
			return;
		case 3:
			Settings.Default.thompsonrapid = int_2;
			return;
		case 4:
			Settings.Default.m249rapid = int_2;
			return;
		case 5:
			Settings.Default.p250rapid = int_2;
			return;
		case 6:
			Settings.Default.semirapid = int_2;
			return;
		case 7:
			Settings.Default.barettarapid = int_2;
			return;
		case 8:
			Settings.Default.pythonrapid = int_2;
			return;
		case 9:
			Settings.Default.revolverrapid = int_2;
			return;
		case 10:
			Settings.Default.nailgunrapid = int_2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0102FA88 File Offset: 0x0102DC88
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_3();
	}

	// Token: 0x06000176 RID: 374 RVA: 0x01030ABC File Offset: 0x0102ECBC
	private void firerateBar_Scroll(object sender, EventArgs e)
	{
		this.timer_2.Stop();
		this.method_5(this.firerateBar.Value);
		Settings.Default.Save();
		this.timer_2.Start();
	}

	// Token: 0x06000177 RID: 375 RVA: 0x01030AFC File Offset: 0x0102ECFC
	private void bunifuTrackbar1_Scroll(object sender, EventArgs e)
	{
		this.timer_2.Stop();
		this.method_4(this.bunifuTrackbar1.Value);
		Settings.Default.Save();
		this.timer_2.Start();
	}

	// Token: 0x06000178 RID: 376 RVA: 0x01030B3C File Offset: 0x0102ED3C
	private void rapidBar_Scroll(object sender, EventArgs e)
	{
		this.timer_2.Stop();
		this.method_6(this.rapidBar.Value + 30);
		Settings.Default.Save();
		this.timer_2.Start();
	}

	// Token: 0x06000179 RID: 377 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void sett5_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void sett6_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x01030B80 File Offset: 0x0102ED80
	private void method_7(bool bool_0)
	{
		switch (this.int_1)
		{
		case 1:
			Settings.Default.rageSwitchAK = bool_0;
			break;
		case 2:
			Settings.Default.rageSwitchLR = bool_0;
			break;
		case 3:
			Settings.Default.rageSwitchTHOMPSON = bool_0;
			break;
		case 4:
			Settings.Default.rageSwitchM249 = bool_0;
			break;
		case 5:
			Settings.Default.rageSwitchP250 = bool_0;
			break;
		case 6:
			Settings.Default.rageSwitchSEMI = bool_0;
			break;
		case 7:
			Settings.Default.rageSwitchBARETTA = bool_0;
			break;
		case 8:
			Settings.Default.rageSwitchPYTHON = bool_0;
			break;
		case 9:
			Settings.Default.rageSwitchREVOLVER = bool_0;
			break;
		case 10:
			Settings.Default.rageSwitchNAILGUN = bool_0;
			break;
		}
		this.method_8(bool_0);
		Settings.Default.Save();
	}

	// Token: 0x0600017C RID: 380 RVA: 0x01030C5C File Offset: 0x0102EE5C
	private void rageSwitch_Click(object sender, EventArgs e)
	{
		this.method_7(this.rageSwitch.Value);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x01030C7C File Offset: 0x0102EE7C
	private void method_8(bool bool_0)
	{
		this.rageSwitch.Value = bool_0;
		if (this.rageSwitch.Value)
		{
			this.ran1.Visible = true;
			this.firerateBar.Visible = true;
			this.sett4.Visible = true;
			this.rageLabel.Text = "ON";
			return;
		}
		this.ran1.Visible = false;
		this.firerateBar.Visible = false;
		this.sett4.Visible = false;
		this.rageLabel.Text = "OFF";
	}

	// Token: 0x0600017E RID: 382 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void sett4_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x01030D0C File Offset: 0x0102EF0C
	private void timer_2_Tick(object sender, EventArgs e)
	{
		this.SelectedWPN.Focus();
		this.status.Text = "";
		this.timer_2.Stop();
	}

	// Token: 0x06000180 RID: 384 RVA: 0x01030D40 File Offset: 0x0102EF40
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x01030D6C File Offset: 0x0102EF6C
	private void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		Animation animation = new Animation();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(sett6));
		this.bunifuTransition_0 = new BunifuTransition(this.icontainer_0);
		this.SelectedWPN = new BunifuCustomLabel();
		this.status = new BunifuCustomLabel();
		this.sett0 = new BunifuCustomLabel();
		this.sett1 = new BunifuCustomLabel();
		this.sett2 = new BunifuCustomLabel();
		this.sett3 = new BunifuCustomLabel();
		this.label1 = new Label();
		this.bunifuCustomLabel1 = new BunifuCustomLabel();
		this.ran1 = new BunifuCustomLabel();
		this.sett4 = new BunifuCustomLabel();
		this.firerateBar = new NoFocusTrackBar();
		this.bunifuTrackbar1 = new NoFocusTrackBar();
		this.rapidBar = new NoFocusTrackBar();
		this.bunifuCustomLabel3 = new BunifuCustomLabel();
		this.sett5 = new BunifuCustomLabel();
		this.rageSwitch = new BunifuSwitch();
		this.rageLabel = new BunifuCustomLabel();
		this.bunifuCustomLabel4 = new BunifuCustomLabel();
		this.timer_0 = new Timer(this.icontainer_0);
		this.timer_1 = new Timer(this.icontainer_0);
		this.timer_2 = new Timer(this.icontainer_0);
		((ISupportInitialize)this.firerateBar).BeginInit();
		((ISupportInitialize)this.bunifuTrackbar1).BeginInit();
		((ISupportInitialize)this.rapidBar).BeginInit();
		base.SuspendLayout();
		this.bunifuTransition_0.AnimationType = 3;
		this.bunifuTransition_0.Cursor = null;
		animation.AnimateOnlyDifferences = true;
		animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
		animation.LeafCoeff = 0f;
		animation.MaxTime = 1f;
		animation.MinTime = 0f;
		animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
		animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation2.MosaicShift");
		animation.MosaicSize = 0;
		animation.Padding = new Padding(0);
		animation.RotateCoeff = 0f;
		animation.RotateLimit = 0f;
		animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
		animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
		animation.TimeCoeff = 0f;
		animation.TransparencyCoeff = 0f;
		this.bunifuTransition_0.DefaultAnimation = animation;
		this.SelectedWPN.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.SelectedWPN, 0);
		this.SelectedWPN.Font = new Font("Microsoft Sans Serif", 8f);
		this.SelectedWPN.ForeColor = Color.Gray;
		this.SelectedWPN.Location = new Point(302, 4);
		this.SelectedWPN.Name = "SelectedWPN";
		this.SelectedWPN.Size = new Size(51, 13);
		this.SelectedWPN.TabIndex = 51;
		this.SelectedWPN.Text = "Weapon:";
		this.status.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.status, 0);
		this.status.Font = new Font("Microsoft Sans Serif", 8f);
		this.status.ForeColor = Color.Gray;
		this.status.Location = new Point(302, 146);
		this.status.Name = "status";
		this.status.Size = new Size(25, 13);
		this.status.TabIndex = 52;
		this.status.Text = "111";
		this.sett0.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett0, 0);
		this.sett0.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.sett0.ForeColor = Color.Gray;
		this.sett0.Location = new Point(302, 24);
		this.sett0.Name = "sett0";
		this.sett0.Size = new Size(59, 15);
		this.sett0.TabIndex = 53;
		this.sett0.Text = "Settings";
		this.sett1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett1, 0);
		this.sett1.Font = new Font("Microsoft Sans Serif", 8f);
		this.sett1.ForeColor = Color.Gray;
		this.sett1.Location = new Point(302, 40);
		this.sett1.Name = "sett1";
		this.sett1.Size = new Size(45, 13);
		this.sett1.TabIndex = 54;
		this.sett1.Text = "Settings";
		this.sett2.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett2, 0);
		this.sett2.Font = new Font("Microsoft Sans Serif", 8f);
		this.sett2.ForeColor = Color.Gray;
		this.sett2.Location = new Point(302, 53);
		this.sett2.Name = "sett2";
		this.sett2.Size = new Size(45, 13);
		this.sett2.TabIndex = 55;
		this.sett2.Text = "Settings";
		this.sett3.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett3, 0);
		this.sett3.Font = new Font("Microsoft Sans Serif", 8f);
		this.sett3.ForeColor = Color.Gray;
		this.sett3.Location = new Point(302, 66);
		this.sett3.Name = "sett3";
		this.sett3.Size = new Size(45, 13);
		this.sett3.TabIndex = 56;
		this.sett3.Text = "Settings";
		this.label1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.label1, 0);
		this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label1.ForeColor = Color.Gray;
		this.label1.Location = new Point(23, 8);
		this.label1.Name = "label1";
		this.label1.Size = new Size(41, 13);
		this.label1.TabIndex = 59;
		this.label1.Text = "label1";
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel1, 0);
		this.bunifuCustomLabel1.Font = new Font("Microsoft Sans Serif", 8f);
		this.bunifuCustomLabel1.ForeColor = Color.Gray;
		this.bunifuCustomLabel1.Location = new Point(23, 26);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new Size(74, 13);
		this.bunifuCustomLabel1.TabIndex = 63;
		this.bunifuCustomLabel1.Text = "Set sensitivity:";
		this.ran1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.ran1, 0);
		this.ran1.Font = new Font("Microsoft Sans Serif", 8f);
		this.ran1.ForeColor = Color.Gray;
		this.ran1.Location = new Point(23, 106);
		this.ran1.Name = "ran1";
		this.ran1.Size = new Size(123, 13);
		this.ran1.TabIndex = 65;
		this.ran1.Text = "Set rage RCS sensitivity:";
		this.sett4.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett4, 0);
		this.sett4.Font = new Font("Microsoft Sans Serif", 8f);
		this.sett4.ForeColor = Color.Gray;
		this.sett4.Location = new Point(302, 93);
		this.sett4.Name = "sett4";
		this.sett4.Size = new Size(83, 13);
		this.sett4.TabIndex = 66;
		this.sett4.Text = "Settings random";
		this.sett4.Click += this.sett4_Click;
		this.firerateBar.AutoSize = false;
		this.firerateBar.BackColor = Color.FromArgb(17, 17, 17);
		this.firerateBar.CausesValidation = false;
		this.bunifuTransition_0.SetDecoration(this.firerateBar, 0);
		this.firerateBar.Location = new Point(26, 122);
		this.firerateBar.Maximum = 100;
		this.firerateBar.Minimum = 1;
		this.firerateBar.Name = "firerateBar";
		this.firerateBar.Size = new Size(240, 24);
		this.firerateBar.TabIndex = 68;
		this.firerateBar.TabStop = false;
		this.firerateBar.TickStyle = TickStyle.None;
		this.firerateBar.Value = 1;
		this.firerateBar.Scroll += this.firerateBar_Scroll;
		this.bunifuTrackbar1.AutoSize = false;
		this.bunifuTrackbar1.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuTrackbar1, 0);
		this.bunifuTrackbar1.Location = new Point(26, 42);
		this.bunifuTrackbar1.Maximum = 100;
		this.bunifuTrackbar1.Minimum = 1;
		this.bunifuTrackbar1.Name = "bunifuTrackbar1";
		this.bunifuTrackbar1.Size = new Size(240, 24);
		this.bunifuTrackbar1.TabIndex = 69;
		this.bunifuTrackbar1.TabStop = false;
		this.bunifuTrackbar1.TickStyle = TickStyle.None;
		this.bunifuTrackbar1.Value = 1;
		this.bunifuTrackbar1.Scroll += this.bunifuTrackbar1_Scroll;
		this.rapidBar.AutoSize = false;
		this.rapidBar.BackColor = Color.FromArgb(17, 17, 17);
		this.rapidBar.CausesValidation = false;
		this.bunifuTransition_0.SetDecoration(this.rapidBar, 0);
		this.rapidBar.Location = new Point(26, 82);
		this.rapidBar.Maximum = 100;
		this.rapidBar.Minimum = 10;
		this.rapidBar.Name = "rapidBar";
		this.rapidBar.Size = new Size(240, 24);
		this.rapidBar.TabIndex = 71;
		this.rapidBar.TabStop = false;
		this.rapidBar.TickStyle = TickStyle.None;
		this.rapidBar.Value = 30;
		this.rapidBar.Scroll += this.rapidBar_Scroll;
		this.bunifuCustomLabel3.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel3, 0);
		this.bunifuCustomLabel3.Font = new Font("Microsoft Sans Serif", 8f);
		this.bunifuCustomLabel3.ForeColor = Color.Gray;
		this.bunifuCustomLabel3.Location = new Point(23, 66);
		this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		this.bunifuCustomLabel3.Size = new Size(87, 13);
		this.bunifuCustomLabel3.TabIndex = 70;
		this.bunifuCustomLabel3.Text = "Set rapidfire rate:";
		this.sett5.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.sett5, 0);
		this.sett5.Font = new Font("Microsoft Sans Serif", 8f);
		this.sett5.ForeColor = Color.Gray;
		this.sett5.Location = new Point(302, 79);
		this.sett5.Name = "sett5";
		this.sett5.Size = new Size(45, 13);
		this.sett5.TabIndex = 72;
		this.sett5.Text = "Settings";
		this.sett5.Click += this.sett5_Click;
		this.rageSwitch.BackColor = Color.FromArgb(64, 64, 64);
		this.rageSwitch.BorderRadius = 0;
		this.rageSwitch.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.rageSwitch, 0);
		this.rageSwitch.ForeColor = Color.FromArgb(224, 224, 224);
		this.rageSwitch.Location = new Point(581, 20);
		this.rageSwitch.Name = "rageSwitch";
		this.rageSwitch.Oncolor = Color.DeepSkyBlue;
		this.rageSwitch.Onoffcolor = Color.DarkGray;
		this.rageSwitch.Size = new Size(51, 19);
		this.rageSwitch.TabIndex = 73;
		this.rageSwitch.Textcolor = Color.Transparent;
		this.rageSwitch.Value = true;
		this.rageSwitch.Click += this.rageSwitch_Click;
		this.rageLabel.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.rageLabel, 0);
		this.rageLabel.Font = new Font("Microsoft Sans Serif", 8f);
		this.rageLabel.ForeColor = Color.Gray;
		this.rageLabel.Location = new Point(634, 22);
		this.rageLabel.Name = "rageLabel";
		this.rageLabel.Size = new Size(27, 13);
		this.rageLabel.TabIndex = 74;
		this.rageLabel.Text = "OFF";
		this.bunifuCustomLabel4.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel4, 0);
		this.bunifuCustomLabel4.Font = new Font("Microsoft Sans Serif", 8f);
		this.bunifuCustomLabel4.ForeColor = Color.Gray;
		this.bunifuCustomLabel4.Location = new Point(519, 23);
		this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		this.bunifuCustomLabel4.Size = new Size(58, 13);
		this.bunifuCustomLabel4.TabIndex = 75;
		this.bunifuCustomLabel4.Text = "Rage RCS";
		this.timer_1.Interval = 200;
		this.timer_1.Tick += this.timer_1_Tick;
		this.timer_2.Interval = 4000;
		this.timer_2.Tick += this.timer_2_Tick;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(17, 17, 17);
		base.Controls.Add(this.bunifuCustomLabel4);
		base.Controls.Add(this.rageLabel);
		base.Controls.Add(this.rageSwitch);
		base.Controls.Add(this.bunifuCustomLabel1);
		base.Controls.Add(this.bunifuCustomLabel3);
		base.Controls.Add(this.ran1);
		base.Controls.Add(this.sett3);
		base.Controls.Add(this.sett4);
		base.Controls.Add(this.sett5);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.sett2);
		base.Controls.Add(this.sett1);
		base.Controls.Add(this.sett0);
		base.Controls.Add(this.status);
		base.Controls.Add(this.SelectedWPN);
		base.Controls.Add(this.rapidBar);
		base.Controls.Add(this.firerateBar);
		base.Controls.Add(this.bunifuTrackbar1);
		this.bunifuTransition_0.SetDecoration(this, 0);
		base.Name = "sett6";
		base.Size = new Size(724, 170);
		base.Load += this.sett6_Load;
		((ISupportInitialize)this.firerateBar).EndInit();
		((ISupportInitialize)this.bunifuTrackbar1).EndInit();
		((ISupportInitialize)this.rapidBar).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040000C9 RID: 201
	protected int int_0 = -1;

	// Token: 0x040000CA RID: 202
	protected int int_1;

	// Token: 0x040000CB RID: 203
	private IContainer icontainer_0;

	// Token: 0x040000CC RID: 204
	private BunifuTransition bunifuTransition_0;

	// Token: 0x040000CD RID: 205
	private Timer timer_0;

	// Token: 0x040000CE RID: 206
	private BunifuCustomLabel SelectedWPN;

	// Token: 0x040000CF RID: 207
	private BunifuCustomLabel status;

	// Token: 0x040000D0 RID: 208
	private BunifuCustomLabel sett0;

	// Token: 0x040000D1 RID: 209
	private BunifuCustomLabel sett1;

	// Token: 0x040000D2 RID: 210
	private BunifuCustomLabel sett2;

	// Token: 0x040000D3 RID: 211
	private BunifuCustomLabel sett3;

	// Token: 0x040000D4 RID: 212
	private Timer timer_1;

	// Token: 0x040000D5 RID: 213
	private Timer timer_2;

	// Token: 0x040000D6 RID: 214
	private Label label1;

	// Token: 0x040000D7 RID: 215
	private BunifuCustomLabel bunifuCustomLabel1;

	// Token: 0x040000D8 RID: 216
	private BunifuCustomLabel ran1;

	// Token: 0x040000D9 RID: 217
	private BunifuCustomLabel sett4;

	// Token: 0x040000DA RID: 218
	private TrackBar firerateBar;

	// Token: 0x040000DB RID: 219
	private TrackBar bunifuTrackbar1;

	// Token: 0x040000DC RID: 220
	private TrackBar rapidBar;

	// Token: 0x040000DD RID: 221
	private BunifuCustomLabel bunifuCustomLabel3;

	// Token: 0x040000DE RID: 222
	private BunifuCustomLabel sett5;

	// Token: 0x040000DF RID: 223
	private BunifuSwitch rageSwitch;

	// Token: 0x040000E0 RID: 224
	private BunifuCustomLabel rageLabel;

	// Token: 0x040000E1 RID: 225
	private BunifuCustomLabel bunifuCustomLabel4;
}
