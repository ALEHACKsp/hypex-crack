using System;
using System.Runtime.InteropServices;

// Token: 0x02000039 RID: 57
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct9
{
	// Token: 0x040001C4 RID: 452
	public int Signature;

	// Token: 0x040001C5 RID: 453
	public GStruct7 FileHeader;

	// Token: 0x040001C6 RID: 454
	public GStruct10 OptionalHeader;
}
