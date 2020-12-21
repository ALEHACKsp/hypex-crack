using System;
using System.Drawing;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x0200007C RID: 124
	public class CProgressBar : ProgressBar
	{
		// Token: 0x0600098A RID: 2442 RVA: 0x01056064 File Offset: 0x01054264
		public CProgressBar()
		{
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x01056080 File Offset: 0x01054280
		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle clipRectangle = e.ClipRectangle;
			Rectangle clipRectangle2 = e.ClipRectangle;
			clipRectangle.Width = (int)((double)clipRectangle.Width * ((double)base.Value / (double)base.Maximum)) - 4;
			if (ProgressBarRenderer.IsSupported)
			{
				ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
			}
			clipRectangle.Height -= 4;
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(17, 17, 17)), 2, 2, clipRectangle2.Width, clipRectangle2.Height);
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(170, 0, 0)), 2, 2, clipRectangle.Width, clipRectangle.Height);
		}
	}
}
