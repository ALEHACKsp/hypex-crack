using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200004B RID: 75
internal class Class7 : GClass10
{
	// Token: 0x06000349 RID: 841 RVA: 0x01038528 File Offset: 0x01036728
	private static byte[] smethod_1(GClass8 gclass8_0)
	{
		byte[] result = null;
		GClass13 gclass = new GClass13(gclass8_0);
		GClass13.GClass15 gclass2 = null;
		int num = 0;
		while (num < gclass.GClass15_0.GClass15_0.Length && gclass2 == null)
		{
			if ((long)gclass.GClass15_0.GClass15_0[num].Int32_0 == 24L)
			{
				gclass2 = gclass.GClass15_0.GClass15_0[num];
			}
			num++;
		}
		if (gclass2 != null && gclass2.GClass15_0.Length != 0 && Class7.smethod_4(gclass2.GClass15_0[0].Int32_0) && gclass2.GClass15_0[0].GClass16_0.Length == 1)
		{
			result = gclass2.GClass15_0[0].GClass16_0[0].method_0();
		}
		return result;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x010385D4 File Offset: 0x010367D4
	private static uint smethod_2(IntPtr intptr_7, IntPtr intptr_8)
	{
		if (intptr_7.smethod_4() || intptr_7.smethod_2(-1L))
		{
			throw new ArgumentException("Invalid process handle.", "hProcess");
		}
		if (intptr_8.smethod_4())
		{
			throw new ArgumentException("Invalid module handle.", "hModule");
		}
		byte[] array = GClass5.smethod_4(intptr_7, intptr_8, (uint)Marshal.SizeOf(typeof(GStruct6)));
		if (array != null)
		{
			ushort num = BitConverter.ToUInt16(array, 0);
			uint num2 = BitConverter.ToUInt32(array, 60);
			if (num == 23117)
			{
				byte[] array2 = GClass5.smethod_4(intptr_7, intptr_8.smethod_0((long)((ulong)num2)), (uint)Marshal.SizeOf(typeof(GStruct9)));
				if (array2 != null && BitConverter.ToUInt32(array2, 0) == 17744u)
				{
					GStruct9 gstruct = default(GStruct9);
					uint addressOfEntryPoint;
					using (GClass9 gclass = new GClass9(256))
					{
						if (!gclass.method_9<GStruct9>(array2, out gstruct))
						{
							return 0u;
						}
						addressOfEntryPoint = gstruct.OptionalHeader.AddressOfEntryPoint;
					}
					return addressOfEntryPoint;
				}
			}
		}
		return 0u;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x010386E4 File Offset: 0x010368E4
	private static IntPtr smethod_3(string string_0, int int_0)
	{
		IntPtr result = IntPtr.Zero;
		Process processById = Process.GetProcessById(int_0);
		int num = 0;
		while (num < processById.Modules.Count && result.smethod_4())
		{
			if (processById.Modules[num].ModuleName.ToLower() == string_0.ToLower())
			{
				result = processById.Modules[num].BaseAddress;
			}
			num++;
		}
		return result;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x01038754 File Offset: 0x01036954
	public override IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(GClass8 gclass8_0, IntPtr intptr_7)
	{
		this.vmethod_0();
		IntPtr result;
		try
		{
			result = Class7.smethod_6(GClass11.smethod_0<GClass8>(gclass8_0), intptr_7, true);
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			result = IntPtr.Zero;
		}
		return result;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0103879C File Offset: 0x0103699C
	public override IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string string_0, IntPtr intptr_7)
	{
		this.vmethod_0();
		IntPtr result;
		try
		{
			using (GClass8 gclass = new GClass8(string_0))
			{
				result = this.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(gclass, intptr_7);
			}
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			result = IntPtr.Zero;
		}
		return result;
	}

	// Token: 0x0600034E RID: 846 RVA: 0x010387FC File Offset: 0x010369FC
	public override IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(GClass8[] gclass8_0, IntPtr intptr_7)
	{
		Class7.Class13 @class = new Class7.Class13();
		@class.class7_0 = this;
		@class.intptr_0 = intptr_7;
		this.vmethod_0();
		return Array.ConvertAll<GClass8, IntPtr>(gclass8_0, new Converter<GClass8, IntPtr>(@class.method_0));
	}

	// Token: 0x0600034F RID: 847 RVA: 0x01038838 File Offset: 0x01036A38
	public override IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(string[] string_0, IntPtr intptr_7)
	{
		Class7.Class14 @class = new Class7.Class14();
		@class.class7_0 = this;
		@class.intptr_0 = intptr_7;
		this.vmethod_0();
		return Array.ConvertAll<string, IntPtr>(string_0, new Converter<string, IntPtr>(@class.method_0));
	}

	// Token: 0x06000350 RID: 848 RVA: 0x01038874 File Offset: 0x01036A74
	private static bool smethod_4(int int_0)
	{
		return int_0 - 1 <= 2;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0103888C File Offset: 0x01036A8C
	private static bool smethod_5(GClass8 gclass8_0, IntPtr intptr_7, int int_0)
	{
		List<string> list = new List<string>();
		string empty = string.Empty;
		bool result = false;
		foreach (GStruct8 gstruct in gclass8_0.method_8())
		{
			if (gclass8_0.method_4((long)((ulong)gclass8_0.method_11(gstruct.Name)), SeekOrigin.Begin, out empty, -1, null) && !string.IsNullOrEmpty(empty) && Class7.smethod_3(empty, int_0).smethod_4())
			{
				list.Add(empty);
			}
		}
		if (list.Count > 0)
		{
			byte[] array = Class7.smethod_1(gclass8_0);
			string text = string.Empty;
			if (array != null)
			{
				text = GClass11.smethod_2(array);
			}
			else
			{
				if (string.IsNullOrEmpty(gclass8_0.String_0) || !File.Exists(Path.Combine(Path.GetDirectoryName(gclass8_0.String_0), Path.GetFileName(gclass8_0.String_0) + ".manifest")))
				{
					IntPtr[] array2 = GClass10.smethod_0(GEnum7.Standard).GClass10.\u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(list.ToArray(), intptr_7);
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i].smethod_4())
						{
							return false;
						}
					}
					return true;
				}
				text = Path.Combine(Path.GetDirectoryName(gclass8_0.String_0), Path.GetFileName(gclass8_0.String_0) + ".manifest");
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			IntPtr intPtr = GClass5.VirtualAllocEx(intptr_7, IntPtr.Zero, (uint)Class7.byte_1.Length, 12288, 64);
			IntPtr intPtr2 = GClass5.smethod_0(intptr_7, Encoding.ASCII.GetBytes(text + "\0"), 4);
			IntPtr intPtr3 = GClass5.smethod_0(intptr_7, Encoding.ASCII.GetBytes(string.Join("\0", list.ToArray()) + "\0"), 4);
			if (!intPtr.smethod_4())
			{
				byte[] array3 = (byte[])Class7.byte_1.Clone();
				uint num = 0u;
				BitConverter.GetBytes(Class7.intptr_1.smethod_7(intPtr.smethod_0(63L)).ToInt32()).CopyTo(array3, 59);
				BitConverter.GetBytes(Class7.intptr_0.smethod_7(intPtr.smethod_0(88L)).ToInt32()).CopyTo(array3, 84);
				BitConverter.GetBytes(Class7.intptr_3.smethod_7(intPtr.smethod_0(132L)).ToInt32()).CopyTo(array3, 128);
				BitConverter.GetBytes(Class7.intptr_4.smethod_7(intPtr.smethod_0(146L)).ToInt32()).CopyTo(array3, 142);
				BitConverter.GetBytes(Class7.intptr_2.smethod_7(intPtr.smethod_0(200L)).ToInt32()).CopyTo(array3, 196);
				BitConverter.GetBytes(Class7.intptr_5.smethod_7(intPtr.smethod_0(209L)).ToInt32()).CopyTo(array3, 205);
				BitConverter.GetBytes(intPtr2.ToInt32()).CopyTo(array3, 31);
				BitConverter.GetBytes(list.Count).CopyTo(array3, 40);
				BitConverter.GetBytes(intPtr3.ToInt32()).CopyTo(array3, 49);
				if (GClass5.WriteProcessMemory(intptr_7, intPtr, array3, array3.Length, out num) && (ulong)num == (ulong)((long)array3.Length))
				{
					uint num2 = GClass5.smethod_7(intptr_7, intPtr, 0u, 5000);
					result = (num2 != uint.MaxValue && num2 > 0u);
				}
				GClass5.VirtualFreeEx(intptr_7, intPtr3, 0, 32768);
				GClass5.VirtualFreeEx(intptr_7, intPtr2, 0, 32768);
				GClass5.VirtualFreeEx(intptr_7, intPtr, 0, 32768);
			}
		}
		return result;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x01038C54 File Offset: 0x01036E54
	private static IntPtr smethod_6(GClass8 gclass8_0, IntPtr intptr_7, bool bool_0 = false)
	{
		if (intptr_7.smethod_4() || intptr_7.smethod_2(-1L))
		{
			throw new ArgumentException("Invalid process handle.", "hProcess");
		}
		if (gclass8_0 == null)
		{
			throw new ArgumentException("Cannot map a non-existant PE Image.", "image");
		}
		int processId = GClass5.GetProcessId(intptr_7);
		if (processId == 0)
		{
			throw new ArgumentException("Provided handle doesn't have sufficient permissions to inject", "hProcess");
		}
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		uint num = 0u;
		try
		{
			intPtr = GClass5.VirtualAllocEx(intptr_7, IntPtr.Zero, gclass8_0.GStruct9_0.OptionalHeader.SizeOfImage, 12288, 4);
			if (intPtr.smethod_4())
			{
				throw new InvalidOperationException("Unable to allocate memory in the remote process.");
			}
			Class7.smethod_9(gclass8_0, intPtr);
			Class7.smethod_5(gclass8_0, intptr_7, processId);
			Class7.smethod_8(gclass8_0, intptr_7, processId);
			if (bool_0)
			{
				byte[] array = new byte[(ulong)gclass8_0.GStruct6_0.e_lfanew + (ulong)((long)Marshal.SizeOf(typeof(GStruct7))) + 4UL + (ulong)gclass8_0.GStruct9_0.FileHeader.SizeOfOptionalHeader];
				if (gclass8_0.method_2(0L, SeekOrigin.Begin, array))
				{
					GClass5.WriteProcessMemory(intptr_7, intPtr, array, array.Length, out num);
				}
			}
			Class7.smethod_7(gclass8_0, intptr_7, intPtr);
			if (gclass8_0.GStruct9_0.OptionalHeader.AddressOfEntryPoint <= 0u)
			{
				return intPtr;
			}
			byte[] array2 = (byte[])Class7.byte_0.Clone();
			BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(array2, 11);
			intPtr2 = GClass5.VirtualAllocEx(intptr_7, IntPtr.Zero, (uint)Class7.byte_0.Length, 12288, 64);
			if (!intPtr2.smethod_4() && GClass5.WriteProcessMemory(intptr_7, intPtr2, array2, array2.Length, out num))
			{
				if ((ulong)num == (ulong)((long)array2.Length))
				{
					IntPtr intPtr3 = GClass5.CreateRemoteThread(intptr_7, 0, 0, intPtr2, (uint)intPtr.smethod_0((long)((ulong)gclass8_0.GStruct9_0.OptionalHeader.AddressOfEntryPoint)).ToInt32(), 0, 0);
					if ((ulong)GClass5.WaitForSingleObject(intPtr3, 5000) != 0UL)
					{
						return intPtr;
					}
					GClass5.GetExitCodeThread(intPtr3, out num);
					if (num == 0u)
					{
						GClass5.VirtualFreeEx(intptr_7, intPtr, 0, 32768);
						throw new Exception("Entry method of module reported a failure " + Marshal.GetLastWin32Error().ToString());
					}
					GClass5.VirtualFreeEx(intptr_7, intPtr2, 0, 32768);
					GClass5.CloseHandle(intPtr3);
					return intPtr;
				}
			}
			throw new InvalidOperationException("Unable to write stub to the remote process.");
		}
		catch (Exception ex)
		{
			if (!intPtr.smethod_4())
			{
				GClass5.VirtualFreeEx(intptr_7, intPtr, 0, 32768);
			}
			if (!intPtr2.smethod_4())
			{
				GClass5.VirtualFreeEx(intptr_7, intPtr, 0, 32768);
			}
			intPtr = IntPtr.Zero;
			throw ex;
		}
		return intPtr;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x01038F04 File Offset: 0x01037104
	private static void smethod_7(GClass8 gclass8_0, IntPtr intptr_7, IntPtr intptr_8)
	{
		foreach (GStruct14 gstruct in gclass8_0.method_9())
		{
			byte[] array = new byte[gstruct.SizeOfRawData];
			if (!gclass8_0.method_2((long)((ulong)gstruct.PointerToRawData), SeekOrigin.Begin, array))
			{
				throw gclass8_0.vmethod_1();
			}
			if ((gstruct.Characteristics & 33554432u) == 0u)
			{
				uint num;
				GClass5.WriteProcessMemory(intptr_7, intptr_8.smethod_0((long)((ulong)gstruct.VirtualAddress)), array, array.Length, out num);
				IntPtr intPtr = intptr_8.smethod_0((long)((ulong)gstruct.VirtualAddress));
				GClass5.VirtualProtectEx(intptr_7, intPtr, gstruct.SizeOfRawData, gstruct.Characteristics & 16777215u, out num);
			}
		}
	}

	// Token: 0x06000354 RID: 852 RVA: 0x01038FC8 File Offset: 0x010371C8
	private static void smethod_8(GClass8 gclass8_0, IntPtr intptr_7, int int_0)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		foreach (GStruct8 gstruct in gclass8_0.method_8())
		{
			if (gclass8_0.method_4((long)((ulong)gclass8_0.method_11(gstruct.Name)), SeekOrigin.Begin, out empty, -1, null))
			{
				IntPtr intPtr = IntPtr.Zero;
				intPtr = Class7.smethod_3(empty, int_0);
				if (intPtr.smethod_4())
				{
					throw new FileNotFoundException(string.Format("Unable to load dependent module '{0}'.", empty));
				}
				uint num = gclass8_0.method_11(gstruct.FirstThunkPtr);
				uint num2 = (uint)Marshal.SizeOf(typeof(GStruct15));
				GStruct15 gstruct2;
				while (gclass8_0.method_3<GStruct15>((long)((ulong)num), SeekOrigin.Begin, out gstruct2) && gstruct2.u1.AddressOfData > 0u)
				{
					IntPtr intPtr2 = IntPtr.Zero;
					object obj;
					if ((gstruct2.u1.Ordinal & 2147483648u) != 0u)
					{
						obj = (ushort)(gstruct2.u1.Ordinal & 65535u);
					}
					else
					{
						if (!gclass8_0.method_4((long)((ulong)(gclass8_0.method_11(gstruct2.u1.AddressOfData) + 2u)), SeekOrigin.Begin, out empty2, -1, null))
						{
							throw gclass8_0.vmethod_1();
						}
						obj = empty2;
					}
					if (!(intPtr2 = GClass5.GetModuleHandleA(empty)).smethod_4())
					{
						IntPtr intPtr3 = obj.GetType().Equals(typeof(string)) ? GClass5.GetProcAddress(intPtr2, (string)obj) : GClass5.GetProcAddress_1(intPtr2, (uint)((ushort)obj & ushort.MaxValue));
						if (!intPtr3.smethod_4())
						{
							intPtr2 = intPtr.smethod_0((long)intPtr3.smethod_6((long)intPtr2.ToInt32()).ToInt32());
						}
					}
					else
					{
						intPtr2 = GClass5.smethod_3(intptr_7, intPtr, obj);
					}
					if (intPtr2.smethod_4())
					{
						throw new EntryPointNotFoundException(string.Format("Unable to locate imported function '{0}' from module '{1}' in the remote process.", empty2, empty));
					}
					gclass8_0.method_7<int>((long)((ulong)num), SeekOrigin.Begin, intPtr2.ToInt32());
					num += num2;
				}
			}
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x010391E4 File Offset: 0x010373E4
	private static void smethod_9(GClass8 gclass8_0, IntPtr intptr_7)
	{
		GStruct5 gstruct = gclass8_0.GStruct9_0.OptionalHeader.DataDirectory[5];
		if (gstruct.Size > 0u)
		{
			uint num = 0u;
			uint num2 = (uint)(intptr_7.ToInt32() - (int)gclass8_0.GStruct9_0.OptionalHeader.ImageBase);
			uint num3 = gclass8_0.method_11(gstruct.VirtualAddress);
			uint num4 = (uint)Marshal.SizeOf(typeof(GStruct4));
			GStruct4 gstruct2;
			while (num < gstruct.Size && gclass8_0.method_3<GStruct4>((long)((ulong)num3), SeekOrigin.Begin, out gstruct2))
			{
				int num5 = (int)((gstruct2.SizeOfBlock - num4) / 2u);
				uint num6 = gclass8_0.method_11(gstruct2.VirtualAddress);
				for (int i = 0; i < num5; i++)
				{
					ushort num7;
					if (gclass8_0.method_3<ushort>((long)((ulong)(num3 + num4) + (ulong)((long)((long)i << 1))), SeekOrigin.Begin, out num7) && (num7 >> 12 & 3) != 0)
					{
						uint num8 = num6 + (uint)(num7 & 4095);
						uint num9;
						if (!gclass8_0.method_3<uint>((long)((ulong)num8), SeekOrigin.Begin, out num9))
						{
							throw gclass8_0.vmethod_1();
						}
						gclass8_0.method_7<uint>(-4L, SeekOrigin.Current, num9 + num2);
					}
				}
				num += gstruct2.SizeOfBlock;
				num3 += gstruct2.SizeOfBlock;
			}
		}
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0103930C File Offset: 0x0103750C
	public override bool \u200E\u206C\u202E\u202D\u200C\u202E\u206B\u202C\u206D\u202E\u206C\u202B\u206E\u200B\u202C\u206D\u200D\u200D\u202C\u206F\u202D\u200D\u202C\u202C\u206D\u200E\u200B\u206A\u200E\u206B\u200E\u200B\u206A\u206A\u202D\u202C\u200E\u202E\u202A\u200E\u202E(IntPtr intptr_7, IntPtr intptr_8)
	{
		this.vmethod_0();
		if (intptr_7.smethod_4())
		{
			throw new ArgumentNullException("hModule", "Invalid module handle");
		}
		if (!intptr_8.smethod_4() && !intptr_8.smethod_2(-1L))
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0u;
			try
			{
				uint num2 = Class7.smethod_2(intptr_8, intptr_7);
				if (num2 == 0u)
				{
					return GClass5.VirtualFreeEx(intptr_8, intptr_7, 0, 32768);
				}
				byte[] array = (byte[])Class7.byte_0.Clone();
				BitConverter.GetBytes(intptr_7.ToInt32()).CopyTo(array, 11);
				BitConverter.GetBytes(0u).CopyTo(array, 6);
				BitConverter.GetBytes(1000u).CopyTo(array, 1);
				intPtr = GClass5.VirtualAllocEx(intptr_8, IntPtr.Zero, (uint)Class7.byte_0.Length, 12288, 64);
				if (intPtr.smethod_4() || !GClass5.WriteProcessMemory(intptr_8, intPtr, array, array.Length, out num) || (ulong)num != (ulong)((long)array.Length))
				{
					throw new InvalidOperationException("Unable to write stub to the remote process.");
				}
				IntPtr intPtr2 = GClass5.CreateRemoteThread(intptr_8, 0, 0, intPtr, (uint)intptr_7.smethod_0((long)((ulong)num2)).ToInt32(), 0, 0);
				if ((ulong)GClass5.WaitForSingleObject(intPtr2, 5000) == 0UL)
				{
					GClass5.VirtualFreeEx(intptr_8, intPtr, 0, 32768);
					GClass5.CloseHandle(intPtr2);
					return GClass5.VirtualFreeEx(intptr_8, intptr_7, 0, 32768);
				}
				return false;
			}
			catch (Exception exception_)
			{
				this.vmethod_2(exception_);
				return false;
			}
		}
		throw new ArgumentException("Invalid process handle.", "hProcess");
	}

	// Token: 0x06000357 RID: 855 RVA: 0x01039490 File Offset: 0x01037690
	public override bool[] \u202B\u200E\u206C\u200C\u202C\u200F\u202C\u206C\u202D\u200F\u206B\u200B\u200B\u206E\u200D\u200C\u206C\u200C\u206F\u206E\u206D\u200C\u200B\u202C\u200B\u202D\u202C\u206B\u206B\u206D\u202E\u202B\u202D\u200C\u206D\u206D\u206D\u202A\u202D\u206C\u202E(IntPtr[] intptr_7, IntPtr intptr_8)
	{
		this.vmethod_0();
		if (intptr_7 != null)
		{
			if (!intptr_8.smethod_4() && !intptr_8.smethod_2(-1L))
			{
				try
				{
					bool[] array = new bool[intptr_7.Length];
					for (int i = 0; i < intptr_7.Length; i++)
					{
						array[i] = this.GClass10.\u200E\u206C\u202E\u202D\u200C\u202E\u206B\u202C\u206D\u202E\u206C\u202B\u206E\u200B\u202C\u206D\u200D\u200D\u202C\u206F\u202D\u200D\u202C\u202C\u206D\u200E\u200B\u206A\u200E\u206B\u200E\u200B\u206A\u206A\u202D\u202C\u200E\u202E\u202A\u200E\u202E(intptr_7[i], intptr_8);
					}
					return array;
				}
				catch (Exception exception_)
				{
					this.vmethod_2(exception_);
					return null;
				}
			}
			throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
		}
		throw new ArgumentNullException("hModules", "Parameter cannot be null.");
	}

	// Token: 0x04000225 RID: 549
	private static readonly byte[] byte_0 = new byte[]
	{
		104,
		0,
		0,
		0,
		0,
		104,
		1,
		0,
		0,
		0,
		104,
		0,
		0,
		0,
		0,
		byte.MaxValue,
		84,
		36,
		16,
		195
	};

	// Token: 0x04000226 RID: 550
	private static readonly IntPtr intptr_0 = GClass5.GetProcAddress(Class7.intptr_6, "ActivateActCtx");

	// Token: 0x04000227 RID: 551
	private static readonly IntPtr intptr_1 = GClass5.GetProcAddress(Class7.intptr_6, "CreateActCtxA");

	// Token: 0x04000228 RID: 552
	private static readonly IntPtr intptr_2 = GClass5.GetProcAddress(Class7.intptr_6, "DeactivateActCtx");

	// Token: 0x04000229 RID: 553
	private static readonly IntPtr intptr_3 = GClass5.GetProcAddress(Class7.intptr_6, "GetModuleHandleA");

	// Token: 0x0400022A RID: 554
	private static readonly IntPtr intptr_4 = GClass5.GetProcAddress(Class7.intptr_6, "LoadLibraryA");

	// Token: 0x0400022B RID: 555
	private static readonly IntPtr intptr_5 = GClass5.GetProcAddress(Class7.intptr_6, "ReleaseActCtx");

	// Token: 0x0400022C RID: 556
	private static readonly IntPtr intptr_6 = GClass5.GetModuleHandleA("KERNEL32.dll");

	// Token: 0x0400022D RID: 557
	private static readonly byte[] byte_1 = new byte[]
	{
		85,
		139,
		236,
		131,
		236,
		60,
		139,
		204,
		139,
		209,
		131,
		194,
		60,
		199,
		1,
		0,
		0,
		0,
		0,
		131,
		193,
		4,
		59,
		202,
		126,
		243,
		198,
		4,
		36,
		32,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		8,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		40,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		44,
		84,
		232,
		0,
		0,
		0,
		0,
		131,
		56,
		byte.MaxValue,
		15,
		132,
		137,
		0,
		0,
		0,
		137,
		68,
		36,
		48,
		139,
		204,
		131,
		193,
		32,
		81,
		80,
		232,
		0,
		0,
		0,
		0,
		131,
		248,
		0,
		116,
		107,
		198,
		68,
		36,
		36,
		1,
		139,
		76,
		36,
		40,
		131,
		249,
		0,
		126,
		62,
		131,
		233,
		1,
		137,
		76,
		36,
		40,
		139,
		76,
		36,
		36,
		131,
		249,
		0,
		116,
		46,
		byte.MaxValue,
		116,
		36,
		44,
		232,
		0,
		0,
		0,
		0,
		131,
		248,
		0,
		117,
		9,
		byte.MaxValue,
		116,
		36,
		44,
		232,
		0,
		0,
		0,
		0,
		137,
		68,
		36,
		36,
		139,
		76,
		36,
		44,
		138,
		1,
		131,
		193,
		1,
		60,
		0,
		117,
		247,
		137,
		76,
		36,
		44,
		235,
		185,
		139,
		68,
		36,
		36,
		185,
		1,
		0,
		0,
		0,
		35,
		193,
		137,
		76,
		36,
		36,
		131,
		249,
		0,
		117,
		20,
		byte.MaxValue,
		116,
		36,
		32,
		106,
		0,
		232,
		0,
		0,
		0,
		0,
		byte.MaxValue,
		116,
		36,
		48,
		232,
		0,
		0,
		0,
		0,
		139,
		68,
		36,
		36,
		139,
		229,
		93,
		195
	};

	// Token: 0x0200004C RID: 76
	[CompilerGenerated]
	private sealed class Class13
	{
		// Token: 0x0600037C RID: 892 RVA: 0x01039604 File Offset: 0x01037804
		internal IntPtr method_0(GClass8 gclass8_0)
		{
			return this.class7_0.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(gclass8_0, this.intptr_0);
		}

		// Token: 0x0400022E RID: 558
		public Class7 class7_0;

		// Token: 0x0400022F RID: 559
		public IntPtr intptr_0;
	}

	// Token: 0x0200004D RID: 77
	[CompilerGenerated]
	private sealed class Class14
	{
		// Token: 0x0600037E RID: 894 RVA: 0x01039624 File Offset: 0x01037824
		internal IntPtr method_0(string string_0)
		{
			return this.class7_0.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string_0, this.intptr_0);
		}

		// Token: 0x04000230 RID: 560
		public Class7 class7_0;

		// Token: 0x04000231 RID: 561
		public IntPtr intptr_0;
	}
}
