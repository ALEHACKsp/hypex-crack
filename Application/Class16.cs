using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Security.Principal;
using System.Threading;
using tcp_moe_client.Classes;

// Token: 0x02000051 RID: 81
internal class Class16
{
	// Token: 0x060003A5 RID: 933 RVA: 0x0103A054 File Offset: 0x01038254
	public Class16()
	{
		NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(<Module>.smethod_7<string>(343830083u), <Module>.smethod_7<string>(3259497652u), PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.Impersonation);
		Console.WriteLine(<Module>.smethod_8<string>(1479745066u));
		namedPipeClientStream.Connect();
		GClass17 gclass = new GClass17(namedPipeClientStream);
		gclass.method_1(<Module>.smethod_7<string>(2229885238u));
		if (gclass.method_0() == <Module>.smethod_8<string>(3628184980u))
		{
			string a = gclass.method_0();
			string b = <Module>.smethod_6<string>(622882003u) + Local.MD5HWID;
			if (a == b)
			{
				Console.WriteLine(<Module>.smethod_8<string>(2400778248u));
			}
		}
		else
		{
			Console.WriteLine(<Module>.smethod_7<string>(1518004576u));
		}
		namedPipeClientStream.Close();
		Thread.Sleep(400000);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0103A11C File Offset: 0x0103831C
	private static void smethod_0()
	{
		string text = Environment.CommandLine;
		Process[] array = new Process[Class16.int_0];
		Console.WriteLine("Spawning client processes...\n");
		if (text.Contains(Environment.CurrentDirectory))
		{
			text = text.Replace(Environment.CurrentDirectory, string.Empty);
		}
		text = text.Replace("\\", string.Empty);
		text = text.Replace("\"", string.Empty);
		int i;
		for (i = 0; i < Class16.int_0; i++)
		{
			array[i] = Process.Start(text, "spawnclient");
		}
		while (i > 0)
		{
			for (int j = 0; j < Class16.int_0; j++)
			{
				if (array[j] != null)
				{
					if (!array[j].HasExited)
					{
						Thread.Sleep(250);
					}
					else
					{
						Console.WriteLine("Client process[{0}] has exited.", array[j].Id);
						array[j] = null;
						i--;
					}
				}
			}
		}
		Console.WriteLine("\nClient processes finished, exiting.");
	}

	// Token: 0x04000237 RID: 567
	private static int int_0 = 1;
}
