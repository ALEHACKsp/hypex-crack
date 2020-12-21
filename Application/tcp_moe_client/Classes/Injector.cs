using System;
using System.Diagnostics;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000081 RID: 129
	public class Injector
	{
		// Token: 0x06000992 RID: 2450 RVA: 0x010561AC File Offset: 0x010543AC
		public static void Inject(string process, byte[] data)
		{
			Process[] processes = Process.GetProcesses(process);
			GClass8 gclass8_ = new GClass8(data);
			new Class7().vmethod_4(gclass8_, processes[0].Id);
			Worker.instance.loader.method_6();
		}
	}
}
