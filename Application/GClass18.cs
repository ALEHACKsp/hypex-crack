using System;
using System.IO;

// Token: 0x02000056 RID: 86
public class GClass18
{
	// Token: 0x060003F7 RID: 1015 RVA: 0x0103AB18 File Offset: 0x01038D18
	public GClass18(GClass17 gclass17_1, string string_1)
	{
		this.string_0 = string_1;
		this.gclass17_0 = gclass17_1;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0103AB3C File Offset: 0x01038D3C
	public void method_0()
	{
		string text = File.ReadAllText(this.string_0);
		this.gclass17_0.method_1(text);
	}

	// Token: 0x04000242 RID: 578
	private string string_0;

	// Token: 0x04000243 RID: 579
	private GClass17 gclass17_0;
}
