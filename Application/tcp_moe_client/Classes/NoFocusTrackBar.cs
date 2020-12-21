using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000083 RID: 131
	internal class NoFocusTrackBar : TrackBar
	{
		// Token: 0x060009BF RID: 2495
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

		// Token: 0x060009C0 RID: 2496 RVA: 0x010564F8 File Offset: 0x010546F8
		private static int MakeParam(int loWord, int hiWord)
		{
			return hiWord << 16 | (loWord & 65535);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x01056514 File Offset: 0x01054714
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			NoFocusTrackBar.SendMessage(this.method_0(), 296u, NoFocusTrackBar.MakeParam(1, 1), 0);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x010352F8 File Offset: 0x010334F8
		IntPtr method_0()
		{
			return base.Handle;
		}
	}
}
