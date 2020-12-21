using System;

// Token: 0x0200002A RID: 42
public static class GClass4
{
	// Token: 0x06000267 RID: 615 RVA: 0x01036784 File Offset: 0x01034984
	public static IntPtr smethod_0(this IntPtr intptr_0, long long_0)
	{
		return new IntPtr(intptr_0.ToInt32() + (int)long_0);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x010367A0 File Offset: 0x010349A0
	public static IntPtr smethod_1(this IntPtr intptr_0, IntPtr intptr_1)
	{
		return new IntPtr(intptr_0.ToInt32() + intptr_1.ToInt32());
	}

	// Token: 0x06000269 RID: 617 RVA: 0x010367C4 File Offset: 0x010349C4
	public static bool smethod_2(this IntPtr intptr_0, long long_0)
	{
		return intptr_0.ToInt64() == long_0;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x010367DC File Offset: 0x010349DC
	public static IntPtr smethod_3(long long_0)
	{
		return new IntPtr((int)long_0);
	}

	// Token: 0x0600026B RID: 619 RVA: 0x010367F0 File Offset: 0x010349F0
	public static bool smethod_4(this IntPtr intptr_0)
	{
		return intptr_0 == IntPtr.Zero;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x01036808 File Offset: 0x01034A08
	public static bool smethod_5(this UIntPtr uintptr_0)
	{
		return uintptr_0 == UIntPtr.Zero;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x01036820 File Offset: 0x01034A20
	public static IntPtr smethod_6(this IntPtr intptr_0, long long_0)
	{
		return new IntPtr((int)(intptr_0.ToInt64() - long_0));
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0103683C File Offset: 0x01034A3C
	public static IntPtr smethod_7(this IntPtr intptr_0, IntPtr intptr_1)
	{
		return new IntPtr((int)(intptr_0.ToInt64() - intptr_1.ToInt64()));
	}
}
