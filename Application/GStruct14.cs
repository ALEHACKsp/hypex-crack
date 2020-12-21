using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200003E RID: 62
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct14
{
	// Token: 0x060002F0 RID: 752 RVA: 0x01037748 File Offset: 0x01035948
	public string ToString()
	{
		string text = Encoding.UTF8.GetString(this.Name);
		if (text.Contains("\0"))
		{
			text = text.Substring(0, text.IndexOf("\0"));
		}
		return text;
	}

	// Token: 0x040001F4 RID: 500
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public byte[] Name;

	// Token: 0x040001F5 RID: 501
	public uint VirtualSize;

	// Token: 0x040001F6 RID: 502
	public uint VirtualAddress;

	// Token: 0x040001F7 RID: 503
	public uint SizeOfRawData;

	// Token: 0x040001F8 RID: 504
	public uint PointerToRawData;

	// Token: 0x040001F9 RID: 505
	public uint PointerToRelocations;

	// Token: 0x040001FA RID: 506
	public uint PointerToLineNumbers;

	// Token: 0x040001FB RID: 507
	public ushort NumberOfRelocations;

	// Token: 0x040001FC RID: 508
	public ushort NumberOfLineNumbers;

	// Token: 0x040001FD RID: 509
	public uint Characteristics;
}
