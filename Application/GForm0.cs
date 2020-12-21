using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000072 RID: 114
public partial class GForm0 : PerPixelAlphaForm
{
	// Token: 0x060008BD RID: 2237 RVA: 0x01054490 File Offset: 0x01052690
	public GForm0(Bitmap bitmap_0)
	{
		base.Visible = true;
		base.method_0(bitmap_0);
		Rectangle workingArea = Screen.GetWorkingArea(this);
		base.Location = new Point(workingArea.Right - base.Size.Width, workingArea.Bottom - base.Size.Height);
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x010544F0 File Offset: 0x010526F0
	public void method_5()
	{
		base.SuspendLayout();
		base.ClientSize = new Size(300, 300);
		base.Name = <Module>.smethod_9<string>(3641247653u);
		base.TopMost = true;
		base.ResumeLayout(false);
	}
}
