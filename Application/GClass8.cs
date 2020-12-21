using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000040 RID: 64
[Serializable]
public class GClass8 : GClass7
{
	// Token: 0x060002F6 RID: 758 RVA: 0x01037788 File Offset: 0x01035988
	public GClass8(string string_0) : this(File.ReadAllBytes(string_0))
	{
		this.String_0 = string_0;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x010377A8 File Offset: 0x010359A8
	public GClass8(byte[] byte_0) : base(byte_0)
	{
		string text = string.Empty;
		GStruct9 gstruct = default(GStruct9);
		GStruct6 gstruct2 = default(GStruct6);
		if (base.method_1<GStruct6>(out gstruct2))
		{
			if (gstruct2.e_magic == 23117)
			{
				if (base.method_3<GStruct9>((long)((ulong)gstruct2.e_lfanew), SeekOrigin.Begin, out gstruct))
				{
					if ((long)gstruct.Signature == 17744L)
					{
						if (gstruct.OptionalHeader.Magic != 267)
						{
							text = "File is of the PE32+ format. Currently support only extends to PE32 images. Either recompile the binary as x86, or choose a different target.";
							goto IL_A6;
						}
						if (gstruct.OptionalHeader.DataDirectory[14].Size > 0u)
						{
							text = "Image contains a CLR runtime header. Currently only native binaries are supported; no .NET dependent libraries.";
							goto IL_A6;
						}
						goto IL_A6;
					}
				}
				text = "Invalid NT header found in image.";
				goto IL_A6;
			}
		}
		text = "Invalid DOS Header found in image";
		IL_A6:
		if (!string.IsNullOrEmpty(text))
		{
			base.Dispose();
			throw new ArgumentException(text);
		}
		this.GStruct9_0 = gstruct;
		this.GStruct6_0 = gstruct2;
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x01037880 File Offset: 0x01035A80
	public IEnumerable<GStruct8> method_8()
	{
		GStruct5 gstruct = this.GStruct9_0.OptionalHeader.DataDirectory[1];
		if (gstruct.Size > 0u)
		{
			uint num = this.method_11(gstruct.VirtualAddress);
			uint num2 = GClass8.Class11.smethod_1(typeof(GStruct8).TypeHandle).smethod_1();
			GStruct8 gstruct2;
			while (base.method_3<GStruct8>((long)((ulong)num), SeekOrigin.Begin, out gstruct2) && gstruct2.OriginalFirstThunk > 0u && gstruct2.Name > 0u)
			{
				yield return gstruct2;
				num += num2;
			}
		}
		yield break;
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0103789C File Offset: 0x01035A9C
	public IEnumerable<GStruct14> method_9()
	{
		uint numberOfSections = (uint)this.GStruct9_0.FileHeader.NumberOfSections;
		long num = (long)((ulong)((uint)this.GStruct9_0.FileHeader.SizeOfOptionalHeader + GClass8.Class12.smethod_1(typeof(GStruct7).TypeHandle).smethod_1() + 4u + this.GStruct6_0.e_lfanew));
		uint num2 = GClass8.Class12.smethod_1(typeof(GStruct14).TypeHandle).smethod_1();
		uint num5;
		for (uint num3 = 0u; num3 < numberOfSections; num3 = num5 + 1u)
		{
			GStruct14 gstruct;
			if (base.method_3<GStruct14>(num + (long)((ulong)(num3 * num2)), SeekOrigin.Begin, out gstruct))
			{
				yield return gstruct;
				int num4;
				if (num4 != 1)
				{
					yield break;
				}
			}
			num5 = num3;
		}
		yield break;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x010378B8 File Offset: 0x01035AB8
	private GStruct14 method_10(uint uint_0)
	{
		foreach (GStruct14 gstruct in this.method_9())
		{
			if (uint_0 >= gstruct.VirtualAddress && uint_0 < gstruct.VirtualAddress + ((gstruct.VirtualSize > 0u) ? gstruct.VirtualSize : gstruct.SizeOfRawData))
			{
				return gstruct;
			}
		}
		throw new EntryPointNotFoundException("RVA does not exist within any of the current sections.");
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0103793C File Offset: 0x01035B3C
	public uint method_11(uint uint_0)
	{
		GStruct14 gstruct = this.method_10(uint_0);
		return uint_0 - (gstruct.VirtualAddress - gstruct.PointerToRawData);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x01037960 File Offset: 0x01035B60
	public byte[] method_12()
	{
		return base.method_0();
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060002FD RID: 765 RVA: 0x01037974 File Offset: 0x01035B74
	// (set) Token: 0x060002FE RID: 766 RVA: 0x01037988 File Offset: 0x01035B88
	public GStruct6 GStruct6_0 { get; private set; }

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060002FF RID: 767 RVA: 0x0103799C File Offset: 0x01035B9C
	// (set) Token: 0x06000300 RID: 768 RVA: 0x010379B0 File Offset: 0x01035BB0
	public string String_0 { get; private set; }

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000301 RID: 769 RVA: 0x010379C4 File Offset: 0x01035BC4
	// (set) Token: 0x06000302 RID: 770 RVA: 0x010379D8 File Offset: 0x01035BD8
	public GStruct9 GStruct9_0 { get; private set; }
}
