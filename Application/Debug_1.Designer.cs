// Token: 0x0200006E RID: 110
public partial class Debug_1 : global::System.Windows.Forms.Form
{
	// Token: 0x06000850 RID: 2128 RVA: 0x01053074 File Offset: 0x01051274
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.lstLog = new global::System.Windows.Forms.ListBox();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.lstLog.FormattingEnabled = true;
		this.lstLog.Location = new global::System.Drawing.Point(13, 13);
		this.lstLog.Name = "lstLog";
		this.lstLog.Size = new global::System.Drawing.Size(595, 238);
		this.lstLog.TabIndex = 0;
		this.timer_0.Enabled = true;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(620, 261);
		base.Controls.Add(this.lstLog);
		this.Font = new global::System.Drawing.Font("Consolas", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Debug";
		base.ShowIcon = false;
		this.Text = "Debug";
		base.ResumeLayout(false);
	}

	// Token: 0x04000412 RID: 1042
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000413 RID: 1043
	private global::System.Windows.Forms.ListBox lstLog;

	// Token: 0x04000414 RID: 1044
	private global::System.Windows.Forms.Timer timer_0;
}
