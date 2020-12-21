using System;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000092 RID: 146
	public class Senders : Enums
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x0105778C File Offset: 0x0105598C
		public static void Handshake(byte[] keys)
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				0,
				keys
			}));
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x010577C0 File Offset: 0x010559C0
		public static void Authentication(Authentication auth, string username, string password, string hwid, string IP)
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				2,
				username,
				password,
				hwid,
				IP
			}));
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x01057804 File Offset: 0x01055A04
		public static void Products()
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				3
			}));
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x01057804 File Offset: 0x01055A04
		public static void News()
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				3
			}));
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x01057834 File Offset: 0x01055A34
		public static void Load(string product)
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				4,
				product
			}));
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x01057868 File Offset: 0x01055A68
		public static void HtmlResponse(string link)
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				5,
				link
			}));
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0105789C File Offset: 0x01055A9C
		public static void FileUpload(string typeUsername, string compressedFile)
		{
			Worker.instance.Send(Senders.pack.method_0(new object[]
			{
				6,
				typeUsername,
				compressedFile
			}));
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x010578D4 File Offset: 0x01055AD4
		public static void Loader()
		{
			Worker.instance.DontSend();
		}

		// Token: 0x0400047E RID: 1150
		private static GClass3 pack = new GClass3();
	}
}
