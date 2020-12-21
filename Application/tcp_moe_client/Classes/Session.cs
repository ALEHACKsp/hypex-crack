using System;
using System.Security.Cryptography;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000086 RID: 134
	public class Session
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x01056594 File Offset: 0x01054794
		public static byte[] encrypt(byte[] data)
		{
			return Session.encryptor.TransformFinalBlock(data, 0, data.Length);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x010565B0 File Offset: 0x010547B0
		public static byte[] decrypt(byte[] data)
		{
			return Session.decryptor.TransformFinalBlock(data, 0, data.Length);
		}

		// Token: 0x04000455 RID: 1109
		public static string Username;

		// Token: 0x04000456 RID: 1110
		public static string Rank;

		// Token: 0x04000457 RID: 1111
		public static bool Authenticated;

		// Token: 0x04000458 RID: 1112
		public static bool HandshakeDone;

		// Token: 0x04000459 RID: 1113
		public static ICryptoTransform encryptor;

		// Token: 0x0400045A RID: 1114
		public static ICryptoTransform decryptor;
	}
}
