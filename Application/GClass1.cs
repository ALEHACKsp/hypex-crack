using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000019 RID: 25
[SuppressUnmanagedCodeSecurity]
public class GClass1
{
	// Token: 0x060000CC RID: 204
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetLastError();

	// Token: 0x060000CD RID: 205
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateNamedPipe(string string_0, GEnum3 genum3_0, GEnum4 genum4_0, uint uint_4, uint uint_5, uint uint_6, uint uint_7, IntPtr intptr_0);

	// Token: 0x060000CE RID: 206
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ConnectNamedPipe(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x060000CF RID: 207
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WaitNamedPipe(string string_0, int int_1);

	// Token: 0x060000D0 RID: 208
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetNamedPipeHandleState(IntPtr intptr_0, ref GEnum4 genum4_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x060000D1 RID: 209
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, GEnum0 genum0_0, GEnum1 genum1_0, IntPtr intptr_0, GEnum2 genum2_0, uint uint_4, uint uint_5);

	// Token: 0x060000D2 RID: 210
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadFile(IntPtr intptr_0, byte[] byte_0, uint uint_4, out uint uint_5, IntPtr intptr_1);

	// Token: 0x060000D3 RID: 211
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteFile(IntPtr intptr_0, byte[] byte_0, uint uint_4, out uint uint_5, IntPtr intptr_1);

	// Token: 0x060000D4 RID: 212
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x060000D5 RID: 213
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FlushFileBuffers(IntPtr intptr_0);

	// Token: 0x060000D6 RID: 214
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool DisconnectNamedPipe(IntPtr intptr_0);

	// Token: 0x0400005F RID: 95
	public const uint uint_0 = 255u;

	// Token: 0x04000060 RID: 96
	public const ulong ulong_0 = 0UL;

	// Token: 0x04000061 RID: 97
	public const ulong ulong_1 = 2UL;

	// Token: 0x04000062 RID: 98
	public const ulong ulong_2 = 231UL;

	// Token: 0x04000063 RID: 99
	public const ulong ulong_3 = 232UL;

	// Token: 0x04000064 RID: 100
	public const ulong ulong_4 = 233UL;

	// Token: 0x04000065 RID: 101
	public const ulong ulong_5 = 234UL;

	// Token: 0x04000066 RID: 102
	public const ulong ulong_6 = 535UL;

	// Token: 0x04000067 RID: 103
	public const ulong ulong_7 = 536UL;

	// Token: 0x04000068 RID: 104
	public const uint uint_1 = 4294967295u;

	// Token: 0x04000069 RID: 105
	public const uint uint_2 = 1u;

	// Token: 0x0400006A RID: 106
	public const uint uint_3 = 0u;

	// Token: 0x0400006B RID: 107
	public const int int_0 = -1;
}
