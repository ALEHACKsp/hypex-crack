using System;
using System.Runtime.InteropServices;

// Token: 0x02000038 RID: 56
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct8
{
	// Token: 0x040001BF RID: 447
	public uint OriginalFirstThunk;

	// Token: 0x040001C0 RID: 448
	public uint TimeDateStamp;

	// Token: 0x040001C1 RID: 449
	public uint ForwarderChain;

	// Token: 0x040001C2 RID: 450
	public uint Name;

	// Token: 0x040001C3 RID: 451
	public uint FirstThunkPtr;
}
