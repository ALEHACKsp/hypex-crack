using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;

// Token: 0x02000054 RID: 84
internal class Class19
{
	// Token: 0x060003DB RID: 987 RVA: 0x0103A874 File Offset: 0x01038A74
	public void method_0()
	{
		Thread[] array = new Thread[Class19.int_0];
		Console.WriteLine("\n*** Named pipe server stream with impersonation example ***\n");
		Console.WriteLine("Waiting for client connect...\n");
		int i;
		for (i = 0; i < Class19.int_0; i++)
		{
			array[i] = new Thread(new ParameterizedThreadStart(Class19.smethod_0));
			array[i].Start();
		}
		Thread.Sleep(250);
		while (i > 0)
		{
			for (int j = 0; j < Class19.int_0; j++)
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

	// Token: 0x060003DC RID: 988 RVA: 0x0103A92C File Offset: 0x01038B2C
	private static void smethod_0(object object_0)
	{
		NamedPipeServerStream namedPipeServerStream = new NamedPipeServerStream("IHHpipe", PipeDirection.InOut, Class19.int_0);
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
			if (a == "GetPath")
			{
				gclass.method_1("");
				gclass.method_1(Settings.Default.GamePath);
				Class19.bool_0 = true;
			}
			else
			{
				gclass.method_1("I like dicks");
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine("ERROR: {0}", ex.Message);
		}
		namedPipeServerStream.Close();
	}

	// Token: 0x0400023E RID: 574
	private static int int_0 = 3;

	// Token: 0x0400023F RID: 575
	public static bool bool_0 = false;
}
