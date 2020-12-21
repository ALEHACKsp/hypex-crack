using System;
using System.Runtime.InteropServices;

// Token: 0x02000037 RID: 55
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct7
{
	// Token: 0x040001B8 RID: 440
	public ushort Machine;

	// Token: 0x040001B9 RID: 441
	public ushort NumberOfSections;

	// Token: 0x040001BA RID: 442
	public uint TimeDateStamp;

	// Token: 0x040001BB RID: 443
	public uint PointerToSymbolTable;

	// Token: 0x040001BC RID: 444
	public uint NumberOfSymbols;

	// Token: 0x040001BD RID: 445
	public ushort SizeOfOptionalHeader;

	// Token: 0x040001BE RID: 446
	public ushort Characteristics;
}
