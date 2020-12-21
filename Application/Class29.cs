using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200006A RID: 106
internal static class Class29
{
	// Token: 0x060007EA RID: 2026
	[DllImport("Kernel32.dll")]
	private static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] uint uint_0, [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_1);

	// Token: 0x060007EB RID: 2027 RVA: 0x01050130 File Offset: 0x0104E330
	public static string smethod_0(this Process process_0, int int_0 = 1024)
	{
		StringBuilder stringBuilder = new StringBuilder(int_0);
		uint num = (uint)(stringBuilder.Capacity + 1);
		if (!Class29.QueryFullProcessImageName(process_0.Handle, 0u, stringBuilder, ref num))
		{
			return null;
		}
		return stringBuilder.ToString();
	}
}
