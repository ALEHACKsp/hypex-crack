using System;
using System.Runtime.InteropServices;

// Token: 0x02000047 RID: 71
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GStruct16
{
	// Token: 0x0400021C RID: 540
	[FieldOffset(0)]
	public uint AddressOfData;

	// Token: 0x0400021D RID: 541
	[FieldOffset(0)]
	public uint ForwarderString;

	// Token: 0x0400021E RID: 542
	[FieldOffset(0)]
	public uint Function;

	// Token: 0x0400021F RID: 543
	[FieldOffset(0)]
	public uint Ordinal;
}
