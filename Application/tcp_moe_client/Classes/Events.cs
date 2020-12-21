using System;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000090 RID: 144
	public class Events
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x01057200 File Offset: 0x01055400
		public static void Client_WritePacket(GClass0 sender, int size)
		{
			Debug.Log(<Module>.smethod_5<string>(59299968u), new object[]
			{
				size
			});
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0105722C File Offset: 0x0105542C
		public static void Client_StateChanged(GClass0 sender, bool connected)
		{
			Debug.Log(<Module>.smethod_6<string>(4044026439u), new object[]
			{
				(!connected) ? <Module>.smethod_6<string>(1990903618u) : ""
			});
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x01057268 File Offset: 0x01055468
		public static void Client_ReadPacket(GClass0 sender, byte[] data)
		{
			Debug.Log(<Module>.smethod_6<string>(2739271556u), new object[]
			{
				data.Length
			});
			Handlers.Incoming(data);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0105729C File Offset: 0x0105549C
		public static void Client_ExceptionThrown(GClass0 sender, Exception ex)
		{
			Debug.Log("[client] exception: {0}", new object[]
			{
				ex.Message
			});
			if (!Worker.instance.ClientConnected() && Worker.instance.running)
			{
				UI.MsgBox.Show("Can't connect to server.", "Connection failure", MessageBoxIcon.Hand);
				Worker.instance.Shutdown();
			}
		}
	}
}
