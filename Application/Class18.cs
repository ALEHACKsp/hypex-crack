using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;

// Token: 0x02000053 RID: 83
internal class Class18
{
	// Token: 0x060003C9 RID: 969 RVA: 0x0103A6BC File Offset: 0x010388BC
	public void method_0()
	{
		Thread[] array = new Thread[Class18.int_0];
		Console.WriteLine("\n*** Named pipe server stream with impersonation example ***\n");
		Console.WriteLine("Waiting for client connect...\n");
		int i;
		for (i = 0; i < Class18.int_0; i++)
		{
			array[i] = new Thread(new ParameterizedThreadStart(Class18.smethod_0));
			array[i].Start();
		}
		Thread.Sleep(250);
		while (i > 0)
		{
			for (int j = 0; j < Class18.int_0; j++)
			{
				if (array[j] != null && array[j].Join(250))
				{
					Console.WriteLine("Server thread[{0}] finished.", array[j].ManagedThreadId);
					array[j] = null;
					i--;
				}
			}
		}
		Console.WriteLine("\nServer threads exhausted, exiting.");
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0103A774 File Offset: 0x01038974
	private static void smethod_0(object object_0)
	{
		NamedPipeServerStream namedPipeServerStream = new NamedPipeServerStream("IHpipe", PipeDirection.InOut, Class18.int_0);
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		namedPipeServerStream.WaitForConnection();
		Console.WriteLine("Client connected on thread[{0}].", managedThreadId);
		try
		{
			GClass17 gclass = new GClass17(namedPipeServerStream);
			string a = gclass.method_0();
			if (a == "heyIMgay")
			{
				gclass.method_1("I am the one true gayceptor server!");
				gclass.method_1("H" + Local.MD5HWID);
			}
			if (!(a == "GetPath"))
			{
				gclass.method_1("I like dicks");
			}
			else
			{
				gclass.method_1("");
				gclass.method_1(Settings.Default.GamePath);
				Class18.bool_0 = true;
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine("ERROR: {0}", ex.Message);
		}
		namedPipeServerStream.Close();
	}

	// Token: 0x0400023C RID: 572
	private static int int_0 = 3;

	// Token: 0x0400023D RID: 573
	public static bool bool_0 = false;
}
