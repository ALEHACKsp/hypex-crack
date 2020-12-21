// Token: 0x02000020 RID: 32
public partial class RS6Menu : global::System.Windows.Forms.Form
{
	// Token: 0x060001C7 RID: 455 RVA: 0x01033C60 File Offset: 0x01031E60
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::BunifuAnimatorNS.Animation animation = new global::BunifuAnimatorNS.Animation();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RS6Menu));
		this.bunifuElipse_0 = new global::Bunifu.Framework.UI.BunifuElipse(this.icontainer_0);
		this.bunifuDragControl_0 = new global::Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.ProfileTab = new global::MetroFramework.Controls.MetroTabControl();
		this.metroTabPage10 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage5 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage7 = new global::MetroFramework.Controls.MetroTabPage();
		this.PistolsTab = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage4 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage1 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage8 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage2 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage3 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage6 = new global::MetroFramework.Controls.MetroTabPage();
		this.metroTabPage9 = new global::MetroFramework.Controls.MetroTabPage();
		this.bunifuCustomLabel2 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
		this.container = new global::System.Windows.Forms.Panel();
		this.backBtn = new global::Bunifu.Framework.UI.BunifuImageButton();
		this.EditButton = new global::Bunifu.Framework.UI.BunifuThinButton2();
		this.startButton = new global::Bunifu.Framework.UI.BunifuThinButton2();
		this.settings1 = new global::settings();
		this.hotkeys1 = new global::hotkeys();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.bunifuTransition_0 = new global::BunifuAnimatorNS.BunifuTransition(this.icontainer_0);
		this.bunifuImageButton1 = new global::Bunifu.Framework.UI.BunifuImageButton();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.panel1.SuspendLayout();
		this.container.SuspendLayout();
		this.backBtn.BeginInit();
		this.panel2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		this.bunifuImageButton1.BeginInit();
		base.SuspendLayout();
		this.bunifuElipse_0.ElipseRadius = 7;
		this.bunifuElipse_0.TargetControl = this;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this;
		this.bunifuDragControl_0.Vertical = true;
		this.panel1.Controls.Add(this.ProfileTab);
		this.bunifuTransition_0.SetDecoration(this.panel1, 0);
		this.panel1.Location = new global::System.Drawing.Point(2, 40);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(718, 38);
		this.panel1.TabIndex = 5;
		this.ProfileTab.Appearance = global::System.Windows.Forms.TabAppearance.Buttons;
		this.bunifuTransition_0.SetDecoration(this.ProfileTab, 0);
		this.ProfileTab.Location = new global::System.Drawing.Point(-2, -1);
		this.ProfileTab.Name = "ProfileTab";
		this.ProfileTab.Size = new global::System.Drawing.Size(737, 78);
		this.ProfileTab.Style = 4;
		this.ProfileTab.TabIndex = 0;
		this.ProfileTab.Theme = 2;
		this.ProfileTab.UseSelectable = true;
		this.ProfileTab.SelectedIndexChanged += new global::System.EventHandler(this.ProfileTab_SelectedIndexChanged);
		this.bunifuTransition_0.SetDecoration(this.metroTabPage10, 0);
		this.metroTabPage10.HorizontalScrollbarBarColor = true;
		this.metroTabPage10.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage10.HorizontalScrollbarSize = 10;
		this.metroTabPage10.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage10.Name = "metroTabPage10";
		this.metroTabPage10.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage10.TabIndex = 11;
		this.metroTabPage10.Text = "Profile 1";
		this.metroTabPage10.VerticalScrollbarBarColor = true;
		this.metroTabPage10.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage10.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage5, 0);
		this.metroTabPage5.HorizontalScrollbarBarColor = true;
		this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage5.HorizontalScrollbarSize = 10;
		this.metroTabPage5.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage5.Name = "metroTabPage5";
		this.metroTabPage5.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage5.TabIndex = 6;
		this.metroTabPage5.Text = "Settings";
		this.metroTabPage5.VerticalScrollbarBarColor = true;
		this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage5.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage7, 0);
		this.metroTabPage7.HorizontalScrollbarBarColor = true;
		this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage7.HorizontalScrollbarSize = 10;
		this.metroTabPage7.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage7.Name = "metroTabPage7";
		this.metroTabPage7.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage7.TabIndex = 8;
		this.metroTabPage7.Text = "Profile 2";
		this.metroTabPage7.VerticalScrollbarBarColor = true;
		this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage7.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.PistolsTab, 0);
		this.PistolsTab.HorizontalScrollbarBarColor = true;
		this.PistolsTab.HorizontalScrollbarHighlightOnWheel = false;
		this.PistolsTab.HorizontalScrollbarSize = 10;
		this.PistolsTab.Location = new global::System.Drawing.Point(4, 41);
		this.PistolsTab.Name = "PistolsTab";
		this.PistolsTab.Size = new global::System.Drawing.Size(729, 33);
		this.PistolsTab.Style = 4;
		this.PistolsTab.TabIndex = 1;
		this.PistolsTab.Text = "Profile 3";
		this.PistolsTab.Theme = 2;
		this.PistolsTab.VerticalScrollbarBarColor = false;
		this.PistolsTab.VerticalScrollbarHighlightOnWheel = false;
		this.PistolsTab.VerticalScrollbarSize = 0;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage4, 0);
		this.metroTabPage4.HorizontalScrollbarBarColor = true;
		this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage4.HorizontalScrollbarSize = 10;
		this.metroTabPage4.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage4.Name = "metroTabPage4";
		this.metroTabPage4.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage4.TabIndex = 5;
		this.metroTabPage4.Text = "Profile 4";
		this.metroTabPage4.VerticalScrollbarBarColor = true;
		this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage4.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage1, 0);
		this.metroTabPage1.HorizontalScrollbarBarColor = true;
		this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage1.HorizontalScrollbarSize = 10;
		this.metroTabPage1.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage1.Name = "metroTabPage1";
		this.metroTabPage1.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage1.TabIndex = 2;
		this.metroTabPage1.Text = "Profile 5";
		this.metroTabPage1.VerticalScrollbarBarColor = true;
		this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage1.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage8, 0);
		this.metroTabPage8.HorizontalScrollbarBarColor = true;
		this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage8.HorizontalScrollbarSize = 10;
		this.metroTabPage8.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage8.Name = "metroTabPage8";
		this.metroTabPage8.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage8.TabIndex = 9;
		this.metroTabPage8.Text = "Profile 6";
		this.metroTabPage8.VerticalScrollbarBarColor = true;
		this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage8.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage2, 0);
		this.metroTabPage2.HorizontalScrollbarBarColor = true;
		this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage2.HorizontalScrollbarSize = 10;
		this.metroTabPage2.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage2.Name = "metroTabPage2";
		this.metroTabPage2.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage2.TabIndex = 3;
		this.metroTabPage2.Text = "Profile 8";
		this.metroTabPage2.VerticalScrollbarBarColor = true;
		this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage2.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage3, 0);
		this.metroTabPage3.HorizontalScrollbarBarColor = true;
		this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage3.HorizontalScrollbarSize = 10;
		this.metroTabPage3.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage3.Name = "metroTabPage3";
		this.metroTabPage3.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage3.TabIndex = 4;
		this.metroTabPage3.Text = "Profile 9";
		this.metroTabPage3.VerticalScrollbarBarColor = true;
		this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage3.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage6, 0);
		this.metroTabPage6.HorizontalScrollbarBarColor = true;
		this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage6.HorizontalScrollbarSize = 10;
		this.metroTabPage6.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage6.Name = "metroTabPage6";
		this.metroTabPage6.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage6.TabIndex = 7;
		this.metroTabPage6.Text = "Profile 10";
		this.metroTabPage6.VerticalScrollbarBarColor = true;
		this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage6.VerticalScrollbarSize = 10;
		this.bunifuTransition_0.SetDecoration(this.metroTabPage9, 0);
		this.metroTabPage9.HorizontalScrollbarBarColor = true;
		this.metroTabPage9.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage9.HorizontalScrollbarSize = 10;
		this.metroTabPage9.Location = new global::System.Drawing.Point(4, 41);
		this.metroTabPage9.Name = "metroTabPage9";
		this.metroTabPage9.Size = new global::System.Drawing.Size(729, 33);
		this.metroTabPage9.TabIndex = 10;
		this.metroTabPage9.Text = "Profile 7";
		this.metroTabPage9.VerticalScrollbarBarColor = true;
		this.metroTabPage9.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage9.VerticalScrollbarSize = 10;
		this.bunifuCustomLabel2.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel2, 0);
		this.bunifuCustomLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.bunifuCustomLabel2.ForeColor = global::System.Drawing.Color.Gray;
		this.bunifuCustomLabel2.Location = new global::System.Drawing.Point(37, 1);
		this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		this.bunifuCustomLabel2.Size = new global::System.Drawing.Size(124, 13);
		this.bunifuCustomLabel2.TabIndex = 8;
		this.bunifuCustomLabel2.Text = "Welcome {USERNAME}";
		this.bunifuCustomLabel2.Visible = false;
		this.container.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.container.Controls.Add(this.backBtn);
		this.container.Controls.Add(this.EditButton);
		this.container.Controls.Add(this.startButton);
		this.container.Controls.Add(this.settings1);
		this.container.Controls.Add(this.hotkeys1);
		this.bunifuTransition_0.SetDecoration(this.container, 0);
		this.container.Location = new global::System.Drawing.Point(2, 81);
		this.container.Name = "container";
		this.container.Size = new global::System.Drawing.Size(786, 375);
		this.container.TabIndex = 9;
		this.backBtn.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.backBtn, 0);
		this.backBtn.Image = global::Class24.Bitmap_10;
		this.backBtn.ImageActive = null;
		this.backBtn.Location = new global::System.Drawing.Point(4, 0);
		this.backBtn.Name = "backBtn";
		this.backBtn.Size = new global::System.Drawing.Size(28, 30);
		this.backBtn.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.backBtn.TabIndex = 121;
		this.backBtn.TabStop = false;
		this.backBtn.Zoom = 10;
		this.backBtn.Click += new global::System.EventHandler(this.backBtn_Click);
		this.EditButton.ActiveBorderThickness = 1;
		this.EditButton.ActiveCornerRadius = 20;
		this.EditButton.ActiveFillColor = global::System.Drawing.Color.DeepSkyBlue;
		this.EditButton.ActiveForecolor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.EditButton.ActiveLineColor = global::System.Drawing.Color.DeepSkyBlue;
		this.EditButton.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.EditButton.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("EditButton.BackgroundImage");
		this.EditButton.ButtonText = "Edit";
		this.EditButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.EditButton, 0);
		this.EditButton.Font = new global::System.Drawing.Font("Century Gothic", 9f);
		this.EditButton.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
		this.EditButton.IdleBorderThickness = 1;
		this.EditButton.IdleCornerRadius = 20;
		this.EditButton.IdleFillColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.EditButton.IdleForecolor = global::System.Drawing.Color.DeepSkyBlue;
		this.EditButton.IdleLineColor = global::System.Drawing.Color.DeepSkyBlue;
		this.EditButton.Location = new global::System.Drawing.Point(293, 49);
		this.EditButton.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
		this.EditButton.Name = "EditButton";
		this.EditButton.Size = new global::System.Drawing.Size(52, 34);
		this.EditButton.TabIndex = 29;
		this.EditButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.EditButton.Click += new global::System.EventHandler(this.EditButton_Click);
		this.startButton.ActiveBorderThickness = 1;
		this.startButton.ActiveCornerRadius = 20;
		this.startButton.ActiveFillColor = global::System.Drawing.Color.DeepSkyBlue;
		this.startButton.ActiveForecolor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.startButton.ActiveLineColor = global::System.Drawing.Color.DeepSkyBlue;
		this.startButton.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.startButton.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("startButton.BackgroundImage");
		this.startButton.ButtonText = "Start";
		this.startButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.startButton, 0);
		this.startButton.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.startButton.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
		this.startButton.IdleBorderThickness = 1;
		this.startButton.IdleCornerRadius = 20;
		this.startButton.IdleFillColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.startButton.IdleForecolor = global::System.Drawing.Color.DeepSkyBlue;
		this.startButton.IdleLineColor = global::System.Drawing.Color.DeepSkyBlue;
		this.startButton.Location = new global::System.Drawing.Point(335, 119);
		this.startButton.Margin = new global::System.Windows.Forms.Padding(5);
		this.startButton.Name = "startButton";
		this.startButton.Size = new global::System.Drawing.Size(380, 41);
		this.startButton.TabIndex = 51;
		this.startButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.startButton.Visible = false;
		this.startButton.Click += new global::System.EventHandler(this.startButton_Click);
		this.settings1.AutoSize = true;
		this.settings1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.settings1, 0);
		this.settings1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.settings1.Location = new global::System.Drawing.Point(0, 0);
		this.settings1.Name = "settings1";
		this.settings1.Size = new global::System.Drawing.Size(786, 375);
		this.settings1.TabIndex = 0;
		this.settings1.Load += new global::System.EventHandler(this.settings1_Load);
		this.hotkeys1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.hotkeys1, 0);
		this.hotkeys1.Location = new global::System.Drawing.Point(0, 0);
		this.hotkeys1.Name = "hotkeys1";
		this.hotkeys1.Size = new global::System.Drawing.Size(786, 202);
		this.hotkeys1.TabIndex = 0;
		this.panel2.Controls.Add(this.pictureBox2);
		this.panel2.Controls.Add(this.bunifuCustomLabel2);
		this.bunifuTransition_0.SetDecoration(this.panel2, 0);
		this.panel2.Location = new global::System.Drawing.Point(2, 3);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(486, 36);
		this.panel2.TabIndex = 11;
		this.bunifuTransition_0.SetDecoration(this.pictureBox2, 0);
		this.pictureBox2.Image = global::Class24.Bitmap_16;
		this.pictureBox2.InitialImage = global::Class24.Bitmap_16;
		this.pictureBox2.Location = new global::System.Drawing.Point(0, -5);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new global::System.Drawing.Size(36, 47);
		this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 14;
		this.pictureBox2.TabStop = false;
		this.bunifuTransition_0.AnimationType = 2;
		this.bunifuTransition_0.Cursor = null;
		animation.AnimateOnlyDifferences = true;
		animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
		animation.LeafCoeff = 0f;
		animation.MaxTime = 1f;
		animation.MinTime = 0f;
		animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
		animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
		animation.MosaicSize = 0;
		animation.Padding = new global::System.Windows.Forms.Padding(0);
		animation.RotateCoeff = 0f;
		animation.RotateLimit = 0f;
		animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
		animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
		animation.TimeCoeff = 0f;
		animation.TransparencyCoeff = 0f;
		this.bunifuTransition_0.DefaultAnimation = animation;
		this.bunifuImageButton1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.bunifuImageButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.bunifuImageButton1, 0);
		this.bunifuImageButton1.Image = global::Class24.Bitmap_13;
		this.bunifuImageButton1.ImageActive = null;
		this.bunifuImageButton1.Location = new global::System.Drawing.Point(683, 3);
		this.bunifuImageButton1.Name = "bunifuImageButton1";
		this.bunifuImageButton1.Size = new global::System.Drawing.Size(29, 28);
		this.bunifuImageButton1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.bunifuImageButton1.TabIndex = 13;
		this.bunifuImageButton1.TabStop = false;
		this.bunifuImageButton1.Zoom = 10;
		this.bunifuImageButton1.Click += new global::System.EventHandler(this.bunifuImageButton1_Click);
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		base.ClientSize = new global::System.Drawing.Size(724, 255);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuImageButton1);
		base.Controls.Add(this.container);
		this.bunifuTransition_0.SetDecoration(this, 0);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "RS6Menu";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		base.Load += new global::System.EventHandler(this.RS6Menu_Load);
		this.panel1.ResumeLayout(false);
		this.container.ResumeLayout(false);
		this.container.PerformLayout();
		this.backBtn.EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		this.bunifuImageButton1.EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x0400010A RID: 266
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x0400010B RID: 267
	private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse_0;

	// Token: 0x0400010C RID: 268
	private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_0;

	// Token: 0x0400010D RID: 269
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x0400010E RID: 270
	private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

	// Token: 0x0400010F RID: 271
	private global::System.Windows.Forms.Panel container;

	// Token: 0x04000110 RID: 272
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04000111 RID: 273
	private global::settings settings1;

	// Token: 0x04000112 RID: 274
	private global::hotkeys hotkeys1;

	// Token: 0x04000113 RID: 275
	private global::BunifuAnimatorNS.BunifuTransition bunifuTransition_0;

	// Token: 0x04000114 RID: 276
	private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

	// Token: 0x04000115 RID: 277
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000116 RID: 278
	private global::Bunifu.Framework.UI.BunifuThinButton2 startButton;

	// Token: 0x04000117 RID: 279
	private global::Bunifu.Framework.UI.BunifuThinButton2 EditButton;

	// Token: 0x04000118 RID: 280
	private global::Bunifu.Framework.UI.BunifuImageButton backBtn;

	// Token: 0x04000119 RID: 281
	private global::System.Windows.Forms.PictureBox pictureBox2;

	// Token: 0x0400011A RID: 282
	private global::MetroFramework.Controls.MetroTabControl ProfileTab;

	// Token: 0x0400011B RID: 283
	private global::MetroFramework.Controls.MetroTabPage PistolsTab;

	// Token: 0x0400011C RID: 284
	private global::MetroFramework.Controls.MetroTabPage metroTabPage1;

	// Token: 0x0400011D RID: 285
	private global::MetroFramework.Controls.MetroTabPage metroTabPage2;

	// Token: 0x0400011E RID: 286
	private global::MetroFramework.Controls.MetroTabPage metroTabPage3;

	// Token: 0x0400011F RID: 287
	private global::MetroFramework.Controls.MetroTabPage metroTabPage4;

	// Token: 0x04000120 RID: 288
	private global::MetroFramework.Controls.MetroTabPage metroTabPage5;

	// Token: 0x04000121 RID: 289
	private global::MetroFramework.Controls.MetroTabPage metroTabPage6;

	// Token: 0x04000122 RID: 290
	private global::MetroFramework.Controls.MetroTabPage metroTabPage7;

	// Token: 0x04000123 RID: 291
	private global::MetroFramework.Controls.MetroTabPage metroTabPage8;

	// Token: 0x04000124 RID: 292
	private global::MetroFramework.Controls.MetroTabPage metroTabPage9;

	// Token: 0x04000125 RID: 293
	private global::MetroFramework.Controls.MetroTabPage metroTabPage10;

	// Token: 0x04000126 RID: 294
	private global::System.Windows.Forms.Timer timer_1;
}
