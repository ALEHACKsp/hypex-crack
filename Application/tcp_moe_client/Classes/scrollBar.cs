using System;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000085 RID: 133
	public class scrollBar : WebBrowser
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x01056558 File Offset: 0x01054758
		public scrollBar()
		{
			new VScrollBar();
			base.ScrollBarsEnabled = true;
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x01056580 File Offset: 0x01054780
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}
	}
}
