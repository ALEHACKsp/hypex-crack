using System;
using System.Runtime.InteropServices;

// Token: 0x0200003D RID: 61
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GStruct13
{
	// Token: 0x040001F0 RID: 496
	[FieldOffset(4)]
	public uint DataEntryRva;

	// Token: 0x040001F1 RID: 497
	[FieldOffset(0)]
	public uint IntegerId;

	// Token: 0x040001F2 RID: 498
	[FieldOffset(0)]
	public uint NameRva;

	// Token: 0x040001F3 RID: 499
	[FieldOffset(4)]
	public uint SubdirectoryRva;
}
