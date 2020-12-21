using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000052 RID: 82
internal class Class17
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060003B7 RID: 951 RVA: 0x0103A210 File Offset: 0x01038410
	// (set) Token: 0x060003B8 RID: 952 RVA: 0x0103A224 File Offset: 0x01038424
	public static List<string> List_0 { get; set; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060003B9 RID: 953 RVA: 0x0103A238 File Offset: 0x01038438
	// (set) Token: 0x060003BA RID: 954 RVA: 0x0103A24C File Offset: 0x0103844C
	public static List<string> List_1 { get; set; }

	// Token: 0x060003BC RID: 956 RVA: 0x0103A260 File Offset: 0x01038460
	public void method_0()
	{
		string text = string.Format("\\\\{0}\\pipe\\{1}", ".", "IHMPipe");
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
		IntPtr intptr_ = GClass1.CreateNamedPipe(text, GEnum3.PIPE_ACCESS_DUPLEX, (GEnum4)6u, 255u, 4096u, 4096u, 0u, intPtr);
		if (intptr_.ToInt32() == -1)
		{
			Console.WriteLine("Unable to create named pipe {0} w/err 0x{1:X}", text, GClass1.GetLastError());
			return;
		}
		Console.WriteLine("The named pipe, {0}, is created.", text);
		Console.WriteLine("Waiting for the client's connection...");
		if (!GClass1.ConnectNamedPipe(intptr_, IntPtr.Zero) && (ulong)GClass1.GetLastError() != 535UL)
		{
			Console.WriteLine("Error occurred while connecting to the client: 0x{0:X}", GClass1.GetLastError());
			GClass1.CloseHandle(intptr_);
			return;
		}
		for (;;)
		{
			byte[] array = new byte[4096];
			uint num;
			if (!GClass1.ReadFile(intptr_, array, 4096u, out num, IntPtr.Zero))
			{
				goto IL_12A;
			}
			if (num == 0u)
			{
				goto IL_12A;
			}
			IL_134:
			string text2 = Encoding.Default.GetString(array).TrimEnd(new char[1]);
			Console.WriteLine("Receives {0} bytes; Message: \"{1}\"", num, text2);
			if (!(text2 == "why are you gao\nlol\t\r\n"))
			{
				continue;
			}
			break;
			IL_12A:
			Console.WriteLine("Read Failed or Finished!");
			goto IL_134;
		}
		Class17.bool_0 = true;
		GClass1.FlushFileBuffers(intptr_);
		GClass1.DisconnectNamedPipe(intptr_);
		GClass1.CloseHandle(intptr_);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0103A420 File Offset: 0x01038620
	public void method_1()
	{
		string text = string.Format("\\\\{0}\\pipe\\{1}", ".", "IHMHPipe");
		while (!Class17.bool_0)
		{
			Thread.Sleep(100);
		}
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
		IntPtr intptr_ = GClass1.CreateNamedPipe(text, GEnum3.PIPE_ACCESS_DUPLEX, (GEnum4)6u, 255u, 4096u, 4096u, 0u, intPtr);
		if (intptr_.ToInt32() == -1)
		{
			Console.WriteLine("Unable to create named pipe {0} w/err 0x{1:X}", text, GClass1.GetLastError());
			return;
		}
		Console.WriteLine("The named pipe, {0}, is created.", text);
		Console.WriteLine("Waiting for the client's connection...");
		if (!GClass1.ConnectNamedPipe(intptr_, IntPtr.Zero) && (ulong)GClass1.GetLastError() != 535UL)
		{
			Console.WriteLine("Error occurred while connecting to the client: 0x{0:X}", GClass1.GetLastError());
			GClass1.CloseHandle(intptr_);
			return;
		}
		byte[] array = new byte[4096];
		Thread.Sleep(1000);
		uint num;
		if (!GClass1.ReadFile(intptr_, array, 4096u, out num, IntPtr.Zero) || num == 0u)
		{
			Console.WriteLine("Read Failed or Finished!");
		}
		string text2 = Encoding.Default.GetString(array).TrimEnd(new char[1]);
		Console.WriteLine("Receives {0} bytes; Message: \"{1}\"", num, text2);
		if (text2.Contains(Class17.List_1[0]))
		{
			string text3 = Class17.List_0[1];
			byte[] bytes = Encoding.Default.GetBytes(text3);
			uint num2 = (uint)bytes.Length;
			Thread.Sleep(5000);
			uint num3;
			if (!GClass1.WriteFile(intptr_, bytes, num2, out num3, IntPtr.Zero) || num2 != num3)
			{
				Console.WriteLine("WriteFile failed w/err 0x{0:X}", GClass1.GetLastError());
			}
			Console.WriteLine("Sends {0} bytes; Message: \"{1}\"", num3, text3.TrimEnd(new char[1]));
			Thread.Sleep(1000);
			GClass1.FlushFileBuffers(intptr_);
			GClass1.DisconnectNamedPipe(intptr_);
			GClass1.CloseHandle(intptr_);
		}
	}

	// Token: 0x060003BE RID: 958 RVA: 0x0103A67C File Offset: 0x0103887C
	public void method_2()
	{
		Thread thread = new Thread(new ThreadStart(this.method_1));
		thread.Start();
		thread.Join();
	}

	// Token: 0x04000238 RID: 568
	private const int int_0 = 4096;

	// Token: 0x04000239 RID: 569
	private static bool bool_0 = true;

	// Token: 0x0400023A RID: 570
	[CompilerGenerated]
	private static List<string> list_0;

	// Token: 0x0400023B RID: 571
	[CompilerGenerated]
	private static List<string> list_1;
}
