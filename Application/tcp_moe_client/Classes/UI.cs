using System;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000087 RID: 135
	public class UI
	{
		// Token: 0x02000088 RID: 136
		public class MsgBox
		{
			// Token: 0x060009CF RID: 2511 RVA: 0x010565CC File Offset: 0x010547CC
			public static void Show(string body, string title = "", MessageBoxIcon icon = MessageBoxIcon.None)
			{
				UI.MsgBox.smethod_0(body, title, MessageBoxButtons.OK, icon);
			}

			// Token: 0x060009D1 RID: 2513 RVA: 0x010565E4 File Offset: 0x010547E4
			static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
			{
				return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
			}
		}
	}
}
