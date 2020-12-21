using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200005D RID: 93
public class GClass19
{
	// Token: 0x060005D8 RID: 1496
	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string string_1, string string_2, string string_3, string string_4);

	// Token: 0x060005D9 RID: 1497
	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

	// Token: 0x060005DA RID: 1498 RVA: 0x0103EE54 File Offset: 0x0103D054
	public GClass19(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0103EE70 File Offset: 0x0103D070
	public void method_0(string string_1, string string_2, string string_3)
	{
		GClass19.WritePrivateProfileString(string_1, string_2, string_3, this.string_0);
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0103EE8C File Offset: 0x0103D08C
	public string method_1(string string_1, string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GClass19.GetPrivateProfileString(string_1, string_2, "", stringBuilder, 255, this.string_0);
		return stringBuilder.ToString();
	}

	// Token: 0x0400024F RID: 591
	public string string_0;
}
