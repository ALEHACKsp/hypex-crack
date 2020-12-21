using System;
using System.Collections.Generic;

namespace tcp_moe_client.Classes
{
	// Token: 0x0200007D RID: 125
	internal class Debug
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x0105613C File Offset: 0x0105433C
		public static void Log(string format, params object[] args)
		{
			Debug.entries.Add(string.Format(<Module>.smethod_8<string>(2836028302u), DateTime.Now.ToString(<Module>.smethod_6<string>(3367363959u)), string.Format(format, args)));
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x01056180 File Offset: 0x01054380
		public static List<string> GetLog()
		{
			return Debug.entries;
		}

		// Token: 0x04000440 RID: 1088
		private static List<string> entries = new List<string>();
	}
}
