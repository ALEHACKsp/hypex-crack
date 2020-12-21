using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000093 RID: 147
[CompilerGenerated]
internal sealed class Class34
{
	// Token: 0x06000A78 RID: 2680 RVA: 0x01057904 File Offset: 0x01055B04
	internal static uint smethod_0(string string_0)
	{
		uint num;
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = ((uint)string_0[i] ^ num) * 16777619u;
			}
		}
		return num;
	}

	// Token: 0x0400047F RID: 1151 RVA: 0x01025D90 File Offset: 0x01023F90
	internal static readonly Class34.Struct10 struct10_0;

	// Token: 0x04000480 RID: 1152 RVA: 0x01025DA0 File Offset: 0x01023FA0
	internal static readonly Class34.Struct11 struct11_0;

	// Token: 0x04000481 RID: 1153 RVA: 0x01025DB8 File Offset: 0x01023FB8
	internal static readonly Class34.Struct12 struct12_0;

	// Token: 0x04000482 RID: 1154 RVA: 0x01025E18 File Offset: 0x01024018
	internal static readonly Class34.Struct13 CD967338E085493A16CEAABE9096FB7326B51D42;

	// Token: 0x04000483 RID: 1155 RVA: 0x01025E80 File Offset: 0x01024080
	internal static readonly Class34.Struct14 E0370EF2594425030A525FFA3BDDB7FBC11AC627;

	// Token: 0x02000094 RID: 148
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 14)]
	private struct Struct10
	{
	}

	// Token: 0x02000095 RID: 149
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct11
	{
	}

	// Token: 0x02000096 RID: 150
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 95)]
	private struct Struct12
	{
	}

	// Token: 0x02000097 RID: 151
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 103)]
	private struct Struct13
	{
	}

	// Token: 0x02000098 RID: 152
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 217)]
	private struct Struct14
	{
	}
}
