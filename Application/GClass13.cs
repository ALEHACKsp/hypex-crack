using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000043 RID: 67
public class GClass13
{
	// Token: 0x0600031F RID: 799 RVA: 0x01037D64 File Offset: 0x01035F64
	public GClass13(GClass8 gclass8_0)
	{
		GStruct5 gstruct = gclass8_0.GStruct9_0.OptionalHeader.DataDirectory[2];
		if (gstruct.VirtualAddress > 0u && gstruct.Size > 0u)
		{
			uint uint_;
			GStruct12 gstruct2;
			if (!gclass8_0.method_3<GStruct12>((long)((ulong)(uint_ = gclass8_0.method_11(gstruct.VirtualAddress))), SeekOrigin.Begin, out gstruct2))
			{
				throw gclass8_0.vmethod_1();
			}
			GStruct13 gstruct13_ = new GStruct13
			{
				SubdirectoryRva = 2147483648u
			};
			this.GClass15_0 = new GClass13.GClass15(gclass8_0, gstruct13_, false, uint_);
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000320 RID: 800 RVA: 0x01037DEC File Offset: 0x01035FEC
	// (set) Token: 0x06000321 RID: 801 RVA: 0x01037E00 File Offset: 0x01036000
	public GClass13.GClass15 GClass15_0 { get; private set; }

	// Token: 0x04000210 RID: 528
	[CompilerGenerated]
	private GClass13.GClass15 gclass15_0;

	// Token: 0x02000044 RID: 68
	public class GClass15 : GClass13.GClass14
	{
		// Token: 0x06000322 RID: 802 RVA: 0x01037E14 File Offset: 0x01036014
		public GClass15(GClass8 gclass8_1, GStruct13 gstruct13_1, bool bool_1, uint uint_3) : base(gclass8_1, gstruct13_1, bool_1, uint_3)
		{
			if (!gclass8_1.method_3<GStruct12>((long)((ulong)(uint_3 + (gstruct13_1.SubdirectoryRva ^ 2147483648u))), SeekOrigin.Begin, out this.gstruct12_0))
			{
				throw gclass8_1.vmethod_1();
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x01037E54 File Offset: 0x01036054
		private void method_0()
		{
			List<GClass13.GClass15> list = new List<GClass13.GClass15>();
			List<GClass13.GClass16> list2 = new List<GClass13.GClass16>();
			int numberOfNamedEntries = (int)this.gstruct12_0.NumberOfNamedEntries;
			for (int i = 0; i < numberOfNamedEntries + (int)this.gstruct12_0.NumberOfIdEntries; i++)
			{
				GStruct13 gstruct;
				if (this.gclass8_0.method_3<GStruct13>((long)((ulong)(this.uint_0 + 16u + (this.gstruct13_0.SubdirectoryRva ^ 2147483648u)) + (ulong)((long)i * 8L)), SeekOrigin.Begin, out gstruct))
				{
					if ((gstruct.SubdirectoryRva & 2147483648u) != 0u)
					{
						list.Add(new GClass13.GClass15(this.gclass8_0, gstruct, i < numberOfNamedEntries, this.uint_0));
					}
					else
					{
						list2.Add(new GClass13.GClass16(this.gclass8_0, gstruct, i < numberOfNamedEntries, this.uint_0));
					}
				}
			}
			this.gclass16_0 = list2.ToArray();
			this.gclass15_0 = list.ToArray();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000324 RID: 804 RVA: 0x01037F34 File Offset: 0x01036134
		public GClass13.GClass15[] GClass15_0
		{
			get
			{
				if (this.gclass15_0 == null)
				{
					this.method_0();
				}
				return this.gclass15_0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000325 RID: 805 RVA: 0x01037F58 File Offset: 0x01036158
		public GClass13.GClass16[] GClass16_0
		{
			get
			{
				if (this.gclass16_0 == null)
				{
					this.method_0();
				}
				return this.gclass16_0;
			}
		}

		// Token: 0x04000211 RID: 529
		private GStruct12 gstruct12_0;

		// Token: 0x04000212 RID: 530
		private GClass13.GClass15[] gclass15_0;

		// Token: 0x04000213 RID: 531
		private GClass13.GClass16[] gclass16_0;

		// Token: 0x04000214 RID: 532
		private const uint uint_1 = 16u;

		// Token: 0x04000215 RID: 533
		private const uint uint_2 = 8u;
	}

	// Token: 0x02000045 RID: 69
	public class GClass16 : GClass13.GClass14
	{
		// Token: 0x06000326 RID: 806 RVA: 0x01037F7C File Offset: 0x0103617C
		public GClass16(GClass8 gclass8_1, GStruct13 gstruct13_1, bool bool_1, uint uint_1) : base(gclass8_1, gstruct13_1, bool_1, uint_1)
		{
			if (!gclass8_1.method_3<GStruct11>((long)((ulong)(this.uint_0 + gstruct13_1.DataEntryRva)), SeekOrigin.Begin, out this.gstruct11_0))
			{
				throw gclass8_1.vmethod_1();
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x01037FB8 File Offset: 0x010361B8
		public byte[] method_0()
		{
			byte[] array = new byte[this.gstruct11_0.Size];
			if (!this.gclass8_0.method_2((long)((ulong)this.gclass8_0.method_11(this.gstruct11_0.OffsetToData)), SeekOrigin.Begin, array))
			{
				throw this.gclass8_0.vmethod_1();
			}
			return array;
		}

		// Token: 0x04000216 RID: 534
		private GStruct11 gstruct11_0;
	}

	// Token: 0x02000046 RID: 70
	public abstract class GClass14
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0103800C File Offset: 0x0103620C
		public GClass14(GClass8 gclass8_1, GStruct13 gstruct13_1, bool bool_1, uint uint_1)
		{
			this.gclass8_0 = gclass8_1;
			this.gstruct13_0 = gstruct13_1;
			this.Boolean_0 = bool_1;
			if (bool_1)
			{
				ushort num = 0;
				if (gclass8_1.method_3<ushort>((long)((ulong)(uint_1 + (gstruct13_1.NameRva & 2147483647u))), SeekOrigin.Begin, out num))
				{
					byte[] byte_ = new byte[(int)num << 1];
					if (gclass8_1.method_2(0L, SeekOrigin.Current, byte_))
					{
						this.string_0 = GClass13.GClass14.smethod_1(GClass13.GClass14.smethod_0(), byte_);
					}
				}
				if (this.string_0 == null)
				{
					throw gclass8_1.vmethod_1();
				}
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000329 RID: 809 RVA: 0x01038098 File Offset: 0x01036298
		public int Int32_0
		{
			get
			{
				if (!this.Boolean_0)
				{
					return (int)this.gstruct13_0.IntegerId;
				}
				return -1;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600032A RID: 810 RVA: 0x010380BC File Offset: 0x010362BC
		// (set) Token: 0x0600032B RID: 811 RVA: 0x010380D0 File Offset: 0x010362D0
		public bool Boolean_0 { get; protected set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600032C RID: 812 RVA: 0x010380E4 File Offset: 0x010362E4
		public string String_0
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x010380F8 File Offset: 0x010362F8
		static Encoding smethod_0()
		{
			return Encoding.Unicode;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0103810C File Offset: 0x0103630C
		static string smethod_1(Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		// Token: 0x04000217 RID: 535
		protected GStruct13 gstruct13_0;

		// Token: 0x04000218 RID: 536
		private string string_0;

		// Token: 0x04000219 RID: 537
		protected GClass8 gclass8_0;

		// Token: 0x0400021A RID: 538
		protected uint uint_0;

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private bool bool_0;
	}
}
