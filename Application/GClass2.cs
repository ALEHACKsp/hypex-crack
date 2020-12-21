using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x0200001C RID: 28
[SuppressUnmanagedCodeSecurity]
public class GClass2
{
	// Token: 0x060000D8 RID: 216
	[DllImport("Advapi32.dll", SetLastError = true)]
	public static extern bool SetSecurityDescriptorDacl(ref GStruct0 gstruct0_0, bool bool_0, IntPtr intptr_0, bool bool_1);

	// Token: 0x060000D9 RID: 217
	[DllImport("Advapi32.dll", SetLastError = true)]
	public static extern bool InitializeSecurityDescriptor(out GStruct0 gstruct0_0, int int_0);
}
