using System;

namespace tcp_moe_client.Classes
{
	// Token: 0x0200007E RID: 126
	public class Enums
	{
		// Token: 0x0200007F RID: 127
		public enum PacketHeader
		{
			// Token: 0x04000442 RID: 1090
			Handshake,
			// Token: 0x04000443 RID: 1091
			Error,
			// Token: 0x04000444 RID: 1092
			Authentication,
			// Token: 0x04000445 RID: 1093
			Products,
			// Token: 0x04000446 RID: 1094
			Load,
			// Token: 0x04000447 RID: 1095
			HtmlResponse,
			// Token: 0x04000448 RID: 1096
			FileUpload
		}

		// Token: 0x02000080 RID: 128
		public enum AuthResponse
		{
			// Token: 0x0400044A RID: 1098
			Success,
			// Token: 0x0400044B RID: 1099
			UnknownUser,
			// Token: 0x0400044C RID: 1100
			InvalidPassword,
			// Token: 0x0400044D RID: 1101
			InvalidHwid,
			// Token: 0x0400044E RID: 1102
			Banned,
			// Token: 0x0400044F RID: 1103
			Unverified,
			// Token: 0x04000450 RID: 1104
			ServerError
		}
	}
}
