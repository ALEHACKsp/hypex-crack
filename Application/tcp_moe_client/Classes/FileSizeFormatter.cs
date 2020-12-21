using System;

namespace tcp_moe_client.Classes
{
	// Token: 0x0200007B RID: 123
	public static class FileSizeFormatter
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x01055F94 File Offset: 0x01054194
		public static string FormatSize(long bytes)
		{
			int num = 0;
			decimal num2 = bytes;
			while (Math.Round(num2 / 1024m) >= 1m)
			{
				num2 /= 1024m;
				num++;
			}
			return string.Format("{0:n1}{1}", num2, FileSizeFormatter.suffixes[num]);
		}

		// Token: 0x0400043F RID: 1087
		private static readonly string[] suffixes = new string[]
		{
			<Module>.smethod_7<string>(3479343502u),
			<Module>.smethod_9<string>(2347894417u),
			<Module>.smethod_9<string>(2835065867u),
			<Module>.smethod_6<string>(2618996021u),
			<Module>.smethod_9<string>(1860722967u),
			<Module>.smethod_8<string>(1302248020u)
		};
	}
}
