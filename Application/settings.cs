using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using tcp_moe_client.Properties;

// Token: 0x02000024 RID: 36
public class settings : UserControl
{
	// Token: 0x06000222 RID: 546 RVA: 0x01035478 File Offset: 0x01033678
	public settings()
	{
		this.InitializeComponent();
		this.status.Text = "";
		this.method_0();
	}

	// Token: 0x06000223 RID: 547 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void settings_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x010354A8 File Offset: 0x010336A8
	public void method_0()
	{
		this.rapidSwitch.Value = Settings.Default.rapid;
		this.sountSwitch.Value = Settings.Default.sound;
		this.autohideSwitch.Value = Settings.Default.autohide;
		this.method_3();
		Settings.Default.Save();
	}

	// Token: 0x06000225 RID: 549 RVA: 0x01029904 File Offset: 0x01027B04
	public void method_1()
	{
		Settings.Default.Save();
	}

	// Token: 0x06000226 RID: 550 RVA: 0x01029904 File Offset: 0x01027B04
	private void method_2(object sender, EventArgs e)
	{
		Settings.Default.Save();
	}

	// Token: 0x06000227 RID: 551 RVA: 0x01035504 File Offset: 0x01033704
	private void method_3()
	{
		if (this.sountSwitch.Value)
		{
			this.soundLabel.Text = "ON";
		}
		else
		{
			this.soundLabel.Text = "OFF";
		}
		if (this.rapidSwitch.Value)
		{
			this.rapidlabel.Text = "ON";
		}
		else
		{
			this.rapidlabel.Text = "OFF";
		}
		if (!this.autohideSwitch.Value)
		{
			this.autohideLabel.Text = "OFF";
			return;
		}
		this.autohideLabel.Text = "ON";
	}

	// Token: 0x06000228 RID: 552 RVA: 0x010355A0 File Offset: 0x010337A0
	private void sountSwitch_Click(object sender, EventArgs e)
	{
		if (this.sountSwitch.Value)
		{
			Settings.Default.sound = true;
		}
		else
		{
			Settings.Default.sound = false;
		}
		this.method_3();
		Settings.Default.Save();
	}

	// Token: 0x06000229 RID: 553 RVA: 0x010355E4 File Offset: 0x010337E4
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.status.Text = "";
		this.timer_1.Stop();
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0103560C File Offset: 0x0103380C
	private void SaveButton_Click(object sender, EventArgs e)
	{
		this.method_1();
		this.method_0();
		this.status.Text = "Settings sucessfully saved!";
		this.timer_1.Start();
	}

	// Token: 0x0600022B RID: 555 RVA: 0x01035640 File Offset: 0x01033840
	private void rapidSwitch_Click(object sender, EventArgs e)
	{
		if (this.rapidSwitch.Value)
		{
			Settings.Default.rapid = true;
		}
		else
		{
			Settings.Default.rapid = false;
		}
		this.method_3();
		Settings.Default.Save();
	}

	// Token: 0x0600022C RID: 556 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel4_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void soundLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x01035684 File Offset: 0x01033884
	private void autohideSwitch_Click(object sender, EventArgs e)
	{
		if (this.autohideSwitch.Value)
		{
			Settings.Default.autohide = true;
		}
		else
		{
			Settings.Default.autohide = false;
		}
		this.method_3();
		Settings.Default.Save();
	}

	// Token: 0x0600022F RID: 559 RVA: 0x010356C8 File Offset: 0x010338C8
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x010356F4 File Offset: 0x010338F4
	private void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		Animation animation = new Animation();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(settings));
		this.bunifuCustomLabel1 = new BunifuCustomLabel();
		this.bunifuTransition_0 = new BunifuTransition(this.icontainer_0);
		this.SaveButton = new BunifuThinButton2();
		this.status = new BunifuCustomLabel();
		this.bunifuCustomLabel3 = new BunifuCustomLabel();
		this.sountSwitch = new BunifuSwitch();
		this.soundLabel = new BunifuCustomLabel();
		this.bunifuCustomLabel2 = new BunifuCustomLabel();
		this.bunifuCustomLabel4 = new BunifuCustomLabel();
		this.rapidlabel = new BunifuCustomLabel();
		this.rapidSwitch = new BunifuSwitch();
		this.timer_0 = new Timer(this.icontainer_0);
		this.timer_1 = new Timer(this.icontainer_0);
		this.bunifuCustomLabel5 = new BunifuCustomLabel();
		this.autohideLabel = new BunifuCustomLabel();
		this.autohideSwitch = new BunifuSwitch();
		base.SuspendLayout();
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel1, 0);
		this.bunifuCustomLabel1.Font = new Font("Microsoft Sans Serif", 10f);
		this.bunifuCustomLabel1.ForeColor = Color.Gray;
		this.bunifuCustomLabel1.Location = new Point(618, 139);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new Size(48, 17);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Profile";
		this.bunifuCustomLabel1.Visible = false;
		this.bunifuTransition_0.AnimationType = 3;
		this.bunifuTransition_0.Cursor = null;
		animation.AnimateOnlyDifferences = true;
		animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
		animation.LeafCoeff = 0f;
		animation.MaxTime = 1f;
		animation.MinTime = 0f;
		animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
		animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation1.MosaicShift");
		animation.MosaicSize = 0;
		animation.Padding = new Padding(0);
		animation.RotateCoeff = 0f;
		animation.RotateLimit = 0f;
		animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
		animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
		animation.TimeCoeff = 0f;
		animation.TransparencyCoeff = 0f;
		this.SaveButton.ActiveBorderThickness = 1;
		this.SaveButton.ActiveCornerRadius = 20;
		this.SaveButton.ActiveFillColor = Color.DeepSkyBlue;
		this.SaveButton.ActiveForecolor = Color.FromArgb(17, 17, 17);
		this.SaveButton.ActiveLineColor = Color.DeepSkyBlue;
		this.SaveButton.BackColor = Color.FromArgb(17, 17, 17);
		this.SaveButton.BackgroundImage = (Image)componentResourceManager.GetObject("SaveButton.BackgroundImage");
		this.SaveButton.ButtonText = " Save";
		this.SaveButton.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.SaveButton, 0);
		this.SaveButton.Font = new Font("Century Gothic", 8f);
		this.SaveButton.ForeColor = Color.DeepSkyBlue;
		this.SaveButton.IdleBorderThickness = 1;
		this.SaveButton.IdleCornerRadius = 20;
		this.SaveButton.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.SaveButton.IdleForecolor = Color.DeepSkyBlue;
		this.SaveButton.IdleLineColor = Color.DeepSkyBlue;
		this.SaveButton.Location = new Point(667, 133);
		this.SaveButton.Margin = new Padding(5);
		this.SaveButton.Name = "SaveButton";
		this.SaveButton.Size = new Size(45, 28);
		this.SaveButton.TabIndex = 34;
		this.SaveButton.TextAlign = ContentAlignment.MiddleCenter;
		this.SaveButton.Visible = false;
		this.SaveButton.Click += this.SaveButton_Click;
		this.status.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.status, 0);
		this.status.Font = new Font("Microsoft Sans Serif", 8f);
		this.status.ForeColor = Color.Gray;
		this.status.Location = new Point(212, 144);
		this.status.Name = "status";
		this.status.Size = new Size(134, 13);
		this.status.TabIndex = 53;
		this.status.Text = "Settings sucessfully saved!";
		this.bunifuCustomLabel3.AutoSize = true;
		this.bunifuCustomLabel3.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel3, 0);
		this.bunifuCustomLabel3.Font = new Font("Microsoft Sans Serif", 10f);
		this.bunifuCustomLabel3.ForeColor = Color.Gray;
		this.bunifuCustomLabel3.Location = new Point(41, 56);
		this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		this.bunifuCustomLabel3.Size = new Size(59, 17);
		this.bunifuCustomLabel3.TabIndex = 24;
		this.bunifuCustomLabel3.Text = "Hotkeys";
		this.sountSwitch.BackColor = Color.FromArgb(64, 64, 64);
		this.sountSwitch.BorderRadius = 0;
		this.sountSwitch.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.sountSwitch, 0);
		this.sountSwitch.ForeColor = Color.FromArgb(224, 224, 224);
		this.sountSwitch.Location = new Point(294, 97);
		this.sountSwitch.Name = "sountSwitch";
		this.sountSwitch.Oncolor = Color.DeepSkyBlue;
		this.sountSwitch.Onoffcolor = Color.DarkGray;
		this.sountSwitch.Size = new Size(51, 19);
		this.sountSwitch.TabIndex = 31;
		this.sountSwitch.Textcolor = Color.Transparent;
		this.sountSwitch.Value = true;
		this.sountSwitch.Click += this.sountSwitch_Click;
		this.soundLabel.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.soundLabel, 0);
		this.soundLabel.Font = new Font("Microsoft Sans Serif", 8f);
		this.soundLabel.ForeColor = Color.Gray;
		this.soundLabel.Location = new Point(346, 99);
		this.soundLabel.Name = "soundLabel";
		this.soundLabel.Size = new Size(27, 13);
		this.soundLabel.TabIndex = 35;
		this.soundLabel.Text = "OFF";
		this.soundLabel.Click += this.soundLabel_Click;
		this.bunifuCustomLabel2.AutoSize = true;
		this.bunifuCustomLabel2.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel2, 0);
		this.bunifuCustomLabel2.Font = new Font("Microsoft Sans Serif", 10f);
		this.bunifuCustomLabel2.ForeColor = Color.Gray;
		this.bunifuCustomLabel2.Location = new Point(42, 96);
		this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		this.bunifuCustomLabel2.Size = new Size(49, 17);
		this.bunifuCustomLabel2.TabIndex = 54;
		this.bunifuCustomLabel2.Text = "Sound";
		this.bunifuCustomLabel4.AutoSize = true;
		this.bunifuCustomLabel4.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel4, 0);
		this.bunifuCustomLabel4.Font = new Font("Microsoft Sans Serif", 10f);
		this.bunifuCustomLabel4.ForeColor = Color.Gray;
		this.bunifuCustomLabel4.Location = new Point(41, 18);
		this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		this.bunifuCustomLabel4.Size = new Size(65, 17);
		this.bunifuCustomLabel4.TabIndex = 57;
		this.bunifuCustomLabel4.Text = "Rapidfire";
		this.bunifuCustomLabel4.Click += this.bunifuCustomLabel4_Click;
		this.rapidlabel.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.rapidlabel, 0);
		this.rapidlabel.Font = new Font("Microsoft Sans Serif", 8f);
		this.rapidlabel.ForeColor = Color.Gray;
		this.rapidlabel.Location = new Point(346, 22);
		this.rapidlabel.Name = "rapidlabel";
		this.rapidlabel.Size = new Size(27, 13);
		this.rapidlabel.TabIndex = 56;
		this.rapidlabel.Text = "OFF";
		this.rapidSwitch.BackColor = Color.FromArgb(64, 64, 64);
		this.rapidSwitch.BorderRadius = 0;
		this.rapidSwitch.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.rapidSwitch, 0);
		this.rapidSwitch.ForeColor = Color.FromArgb(224, 224, 224);
		this.rapidSwitch.Location = new Point(294, 20);
		this.rapidSwitch.Name = "rapidSwitch";
		this.rapidSwitch.Oncolor = Color.DeepSkyBlue;
		this.rapidSwitch.Onoffcolor = Color.DarkGray;
		this.rapidSwitch.Size = new Size(51, 19);
		this.rapidSwitch.TabIndex = 55;
		this.rapidSwitch.Textcolor = Color.Transparent;
		this.rapidSwitch.Value = true;
		this.rapidSwitch.Click += this.rapidSwitch_Click;
		this.timer_1.Interval = 3000;
		this.timer_1.Tick += this.timer_1_Tick;
		this.bunifuCustomLabel5.AutoSize = true;
		this.bunifuCustomLabel5.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel5, 0);
		this.bunifuCustomLabel5.Font = new Font("Microsoft Sans Serif", 10f);
		this.bunifuCustomLabel5.ForeColor = Color.Gray;
		this.bunifuCustomLabel5.Location = new Point(391, 19);
		this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
		this.bunifuCustomLabel5.Size = new Size(92, 17);
		this.bunifuCustomLabel5.TabIndex = 60;
		this.bunifuCustomLabel5.Text = "Autohide GUI";
		this.autohideLabel.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.autohideLabel, 0);
		this.autohideLabel.Font = new Font("Microsoft Sans Serif", 8f);
		this.autohideLabel.ForeColor = Color.Gray;
		this.autohideLabel.Location = new Point(686, 21);
		this.autohideLabel.Name = "autohideLabel";
		this.autohideLabel.Size = new Size(27, 13);
		this.autohideLabel.TabIndex = 59;
		this.autohideLabel.Text = "OFF";
		this.autohideSwitch.BackColor = Color.FromArgb(64, 64, 64);
		this.autohideSwitch.BorderRadius = 0;
		this.autohideSwitch.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.autohideSwitch, 0);
		this.autohideSwitch.ForeColor = Color.FromArgb(224, 224, 224);
		this.autohideSwitch.Location = new Point(634, 19);
		this.autohideSwitch.Name = "autohideSwitch";
		this.autohideSwitch.Oncolor = Color.DeepSkyBlue;
		this.autohideSwitch.Onoffcolor = Color.DarkGray;
		this.autohideSwitch.Size = new Size(51, 19);
		this.autohideSwitch.TabIndex = 58;
		this.autohideSwitch.Textcolor = Color.Transparent;
		this.autohideSwitch.Value = true;
		this.autohideSwitch.Click += this.autohideSwitch_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(17, 17, 17);
		base.Controls.Add(this.bunifuCustomLabel5);
		base.Controls.Add(this.autohideLabel);
		base.Controls.Add(this.autohideSwitch);
		base.Controls.Add(this.bunifuCustomLabel4);
		base.Controls.Add(this.rapidlabel);
		base.Controls.Add(this.rapidSwitch);
		base.Controls.Add(this.bunifuCustomLabel2);
		base.Controls.Add(this.soundLabel);
		base.Controls.Add(this.sountSwitch);
		base.Controls.Add(this.status);
		base.Controls.Add(this.SaveButton);
		base.Controls.Add(this.bunifuCustomLabel3);
		base.Controls.Add(this.bunifuCustomLabel1);
		this.bunifuTransition_0.SetDecoration(this, 0);
		base.Name = "settings";
		base.Size = new Size(724, 170);
		base.Load += this.settings_Load;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000130 RID: 304
	private IContainer icontainer_0;

	// Token: 0x04000131 RID: 305
	private BunifuCustomLabel bunifuCustomLabel1;

	// Token: 0x04000132 RID: 306
	private BunifuTransition bunifuTransition_0;

	// Token: 0x04000133 RID: 307
	private Timer timer_0;

	// Token: 0x04000134 RID: 308
	private BunifuThinButton2 SaveButton;

	// Token: 0x04000135 RID: 309
	private BunifuCustomLabel status;

	// Token: 0x04000136 RID: 310
	private Timer timer_1;

	// Token: 0x04000137 RID: 311
	private BunifuCustomLabel bunifuCustomLabel3;

	// Token: 0x04000138 RID: 312
	private BunifuSwitch sountSwitch;

	// Token: 0x04000139 RID: 313
	private BunifuCustomLabel soundLabel;

	// Token: 0x0400013A RID: 314
	private BunifuCustomLabel bunifuCustomLabel2;

	// Token: 0x0400013B RID: 315
	private BunifuCustomLabel bunifuCustomLabel4;

	// Token: 0x0400013C RID: 316
	private BunifuCustomLabel rapidlabel;

	// Token: 0x0400013D RID: 317
	private BunifuSwitch rapidSwitch;

	// Token: 0x0400013E RID: 318
	private BunifuCustomLabel bunifuCustomLabel5;

	// Token: 0x0400013F RID: 319
	private BunifuCustomLabel autohideLabel;

	// Token: 0x04000140 RID: 320
	private BunifuSwitch autohideSwitch;
}
