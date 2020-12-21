using System;
using System.Runtime.InteropServices;

// Token: 0x0200003A RID: 58
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct10
{
	// Token: 0x040001C7 RID: 455
	public ushort Magic;

	// Token: 0x040001C8 RID: 456
	public byte MajorLinkerVersion;

	// Token: 0x040001C9 RID: 457
	public byte MinorLinkerVersion;

	// Token: 0x040001CA RID: 458
	public uint SizeOfCode;

	// Token: 0x040001CB RID: 459
	public uint SizeOfInitializedData;

	// Token: 0x040001CC RID: 460
	public uint SizeOfUninitializedData;

	// Token: 0x040001CD RID: 461
	public uint AddressOfEntryPoint;

	// Token: 0x040001CE RID: 462
	public uint BaseOfCode;

	// Token: 0x040001CF RID: 463
	public uint BaseOfData;

	// Token: 0x040001D0 RID: 464
	public uint ImageBase;

	// Token: 0x040001D1 RID: 465
	public uint SectionAlignment;

	// Token: 0x040001D2 RID: 466
	public uint FileAlignment;

	// Token: 0x040001D3 RID: 467
	public ushort MajorOperatingSystemVersion;

	// Token: 0x040001D4 RID: 468
	public ushort MinorOperatingSystemVersion;

	// Token: 0x040001D5 RID: 469
	public ushort MajorImageVersion;

	// Token: 0x040001D6 RID: 470
	public ushort MinorImageVersion;

	// Token: 0x040001D7 RID: 471
	public ushort MajorSubsystemVersion;

	// Token: 0x040001D8 RID: 472
	public ushort MinorSubsystemVersion;

	// Token: 0x040001D9 RID: 473
	public uint Win32VersionValue;

	// Token: 0x040001DA RID: 474
	public uint SizeOfImage;

	// Token: 0x040001DB RID: 475
	public uint SizeOfHeaders;

	// Token: 0x040001DC RID: 476
	public uint CheckSum;

	// Token: 0x040001DD RID: 477
	public ushort Subsystem;

	// Token: 0x040001DE RID: 478
	public ushort DllCharacteristics;

	// Token: 0x040001DF RID: 479
	public uint SizeOfStackReserve;

	// Token: 0x040001E0 RID: 480
	public uint SizeOfStackCommit;

	// Token: 0x040001E1 RID: 481
	public uint SizeOfHeapReserve;

	// Token: 0x040001E2 RID: 482
	public uint SizeOfHeapCommit;

	// Token: 0x040001E3 RID: 483
	public uint LoaderFlags;

	// Token: 0x040001E4 RID: 484
	public uint NumberOfRvaAndSizes;

	// Token: 0x040001E5 RID: 485
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public GStruct5[] DataDirectory;
}
