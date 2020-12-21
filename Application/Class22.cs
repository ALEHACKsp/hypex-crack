using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000059 RID: 89
internal class Class22
{
	// Token: 0x0600040D RID: 1037 RVA: 0x0103ADDC File Offset: 0x01038FDC
	public static void smethod_0()
	{
		string text2;
		IntPtr intptr_;
		for (;;)
		{
			string text = string.Empty;
			text2 = string.Format("\\\\{0}\\pipe\\{1}", ".", "IHPipe");
			IntPtr intPtr = IntPtr.Zero;
			GStruct1 gstruct = default(GStruct1);
			GStruct0 structure;
			GClass2.InitializeSecurityDescriptor(out structure, 1);
			GClass2.SetSecurityDescriptorDacl(ref structure, true, IntPtr.Zero, false);
			gstruct.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GStruct0)));
			Marshal.StructureToPtr<GStruct0>(structure, gstruct.intptr_0, false);
			gstruct.bool_0 = false;
			gstruct.int_0 = Marshal.SizeOf(typeof(GStruct1));
			intPtr = Marshal.AllocHGlobal(gstruct.int_0);
			Marshal.StructureToPtr<GStruct1>(gstruct, intPtr, false);
			intptr_ = GClass1.CreateNamedPipe(text2, GEnum3.PIPE_ACCESS_DUPLEX, (GEnum4)6u, 255u, 4096u, 4096u, 0u, intPtr);
			if (intptr_.ToInt32() == -1)
			{
				break;
			}
			Console.WriteLine("The named pipe, {0}, is created.", text2);
			Console.WriteLine("Waiting for the client's connection...");
			if (!GClass1.ConnectNamedPipe(intptr_, IntPtr.Zero) && (ulong)GClass1.GetLastError() != 535UL)
			{
				goto IL_28F;
			}
			byte[] array = new byte[4096];
			Thread.Sleep(1000);
			uint num;
			if (!GClass1.ReadFile(intptr_, array, 4096u, out num, IntPtr.Zero) || num == 0u)
			{
				Console.WriteLine("Read Failed or Finished!");
			}
			string text3 = Encoding.Unicode.GetString(array).TrimEnd(new char[1]);
			Console.WriteLine("Receives {0} bytes; Message: \"{1}\"", num, text3);
			if (!text3.Contains("Initialize"))
			{
				if (text3.Contains("GetPath"))
				{
					text = "\\DosDevices\\C:\\PUBG\\steamapps\\common\\PUBG\\TslGame\\Content\\Paks\\pakchunk5500-WindowsNoEditor_sound.pak";
				}
				else if (!text3.Contains("Injector"))
				{
					if (text3.Contains("GetData"))
					{
						Class22.bool_0 = true;
						text = "l1l11llll1ll1l11llll1ll11ll1";
					}
					else if (text3.Contains("lnitialize"))
					{
						Class22.bool_2 = true;
						text = "l am stIll the only true gayceptor";
					}
				}
				else
				{
					text = "l1l11lllllllll11llllllllllll";
				}
			}
			else
			{
				Class22.bool_0 = true;
				text = "I am the only true gayceptor";
			}
			if (text != string.Empty)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(text);
				uint num2 = (uint)bytes.Length;
				uint num3;
				if (!GClass1.WriteFile(intptr_, bytes, num2, out num3, IntPtr.Zero) || num2 != num3)
				{
					Console.WriteLine("WriteFile failed w/err 0x{0:X}", GClass1.GetLastError());
				}
				Console.WriteLine("Sends {0} bytes; Message: \"{1}\"", num3, text.TrimEnd(new char[1]));
				Thread.Sleep(500);
			}
			GClass1.FlushFileBuffers(intptr_);
			GClass1.DisconnectNamedPipe(intptr_);
			GClass1.CloseHandle(intptr_);
		}
		Console.WriteLine("Unable to create named pipe {0} w/err 0x{1:X}", text2, GClass1.GetLastError());
		return;
		IL_28F:
		Console.WriteLine("Error occurred while connecting to the client: 0x{0:X}", GClass1.GetLastError());
		GClass1.CloseHandle(intptr_);
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x0103B094 File Offset: 0x01039294
	public static void smethod_1()
	{
		Thread thread = new Thread(new ThreadStart(Class22.smethod_0));
		thread.Start();
		thread.Join();
	}

	// Token: 0x04000247 RID: 583
	private const int int_0 = 4096;

	// Token: 0x04000248 RID: 584
	public static bool bool_0;

	// Token: 0x04000249 RID: 585
	public static bool bool_1;

	// Token: 0x0400024A RID: 586
	public static bool bool_2;
}
