using System;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
public abstract class GClass10 : GClass6
{
	// Token: 0x0600033A RID: 826 RVA: 0x0103839C File Offset: 0x0103659C
	public static GClass10 smethod_0(GEnum7 genum7_1)
	{
		GClass10 gclass;
		switch (genum7_1)
		{
		case GEnum7.Standard:
			gclass = new Class9();
			break;
		case GEnum7.ThreadHijack:
			gclass = new Class10();
			break;
		case GEnum7.ManualMap:
			gclass = new Class7();
			break;
		default:
			return null;
		}
		if (gclass != null)
		{
			gclass.GEnum7_0 = genum7_1;
		}
		return gclass;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x010383E0 File Offset: 0x010365E0
	public virtual IntPtr vmethod_4(GClass8 gclass8_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intptr_ = GClass5.OpenProcess(1082u, false, int_0);
		IntPtr result = this.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(gclass8_0, intptr_);
		GClass5.CloseHandle(intptr_);
		return result;
	}

	// Token: 0x0600033C RID: 828
	public abstract IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(GClass8 gclass8_0, IntPtr intptr_0);

	// Token: 0x0600033D RID: 829 RVA: 0x01038410 File Offset: 0x01036610
	public virtual IntPtr vmethod_5(string string_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intptr_ = GClass5.OpenProcess(1082u, false, int_0);
		IntPtr result = this.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string_0, intptr_);
		GClass5.CloseHandle(intptr_);
		return result;
	}

	// Token: 0x0600033E RID: 830
	public abstract IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string string_0, IntPtr intptr_0);

	// Token: 0x0600033F RID: 831 RVA: 0x01038440 File Offset: 0x01036640
	public virtual IntPtr[] vmethod_6(GClass8[] gclass8_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intptr_ = GClass5.OpenProcess(1082u, false, int_0);
		IntPtr[] result = this.GClass10.\u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(gclass8_0, intptr_);
		GClass5.CloseHandle(intptr_);
		return result;
	}

	// Token: 0x06000340 RID: 832
	public abstract IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(GClass8[] gclass8_0, IntPtr intptr_0);

	// Token: 0x06000341 RID: 833 RVA: 0x01038470 File Offset: 0x01036670
	public virtual IntPtr[] vmethod_7(string[] string_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intptr_ = GClass5.OpenProcess(1082u, false, int_0);
		IntPtr[] result = this.GClass10.\u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(string_0, intptr_);
		GClass5.CloseHandle(intptr_);
		return result;
	}

	// Token: 0x06000342 RID: 834
	public abstract IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(string[] string_0, IntPtr intptr_0);

	// Token: 0x06000343 RID: 835 RVA: 0x010384A0 File Offset: 0x010366A0
	public virtual bool vmethod_8(IntPtr intptr_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass5.OpenProcess(1082u, false, int_0);
		bool result = this.GClass10.\u200E\u206C\u202E\u202D\u200C\u202E\u206B\u202C\u206D\u202E\u206C\u202B\u206E\u200B\u202C\u206D\u200D\u200D\u202C\u206F\u202D\u200D\u202C\u202C\u206D\u200E\u200B\u206A\u200E\u206B\u200E\u200B\u206A\u206A\u202D\u202C\u200E\u202E\u202A\u200E\u202E(intptr_0, intPtr);
		GClass5.CloseHandle(intPtr);
		return result;
	}

	// Token: 0x06000344 RID: 836
	public abstract bool \u200E\u206C\u202E\u202D\u200C\u202E\u206B\u202C\u206D\u202E\u206C\u202B\u206E\u200B\u202C\u206D\u200D\u200D\u202C\u206F\u202D\u200D\u202C\u202C\u206D\u200E\u200B\u206A\u200E\u206B\u200E\u200B\u206A\u206A\u202D\u202C\u200E\u202E\u202A\u200E\u202E(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06000345 RID: 837 RVA: 0x010384D0 File Offset: 0x010366D0
	public virtual bool[] vmethod_9(IntPtr[] intptr_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass5.OpenProcess(1082u, false, int_0);
		bool[] result = this.GClass10.\u202B\u200E\u206C\u200C\u202C\u200F\u202C\u206C\u202D\u200F\u206B\u200B\u200B\u206E\u200D\u200C\u206C\u200C\u206F\u206E\u206D\u200C\u200B\u202C\u200B\u202D\u202C\u206B\u206B\u206D\u202E\u202B\u202D\u200C\u206D\u206D\u206D\u202A\u202D\u206C\u202E(intptr_0, intPtr);
		GClass5.CloseHandle(intPtr);
		return result;
	}

	// Token: 0x06000346 RID: 838
	public abstract bool[] \u202B\u200E\u206C\u200C\u202C\u200F\u202C\u206C\u202D\u200F\u206B\u200B\u200B\u206E\u200D\u200C\u206C\u200C\u206F\u206E\u206D\u200C\u200B\u202C\u200B\u202D\u202C\u206B\u206B\u206D\u202E\u202B\u202D\u200C\u206D\u206D\u206D\u202A\u202D\u206C\u202E(IntPtr[] intptr_0, IntPtr intptr_1);

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000347 RID: 839 RVA: 0x01038500 File Offset: 0x01036700
	// (set) Token: 0x06000348 RID: 840 RVA: 0x01038514 File Offset: 0x01036714
	public GEnum7 GEnum7_0 { get; protected set; }

	// Token: 0x04000220 RID: 544
	[CompilerGenerated]
	private GEnum7 genum7_0;
}
