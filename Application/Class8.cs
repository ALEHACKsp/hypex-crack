using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004E RID: 78
internal abstract class Class8 : GClass10
{
	// Token: 0x06000380 RID: 896 RVA: 0x01039644 File Offset: 0x01037844
	protected virtual IntPtr vmethod_10(string[] string_0, IntPtr intptr_0, out IntPtr intptr_1, uint uint_0 = 0u)
	{
		intptr_1 = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr result;
		try
		{
			IntPtr moduleHandleA = GClass5.GetModuleHandleA("kernel32.dll");
			IntPtr procAddress = GClass5.GetProcAddress(moduleHandleA, "LoadLibraryA");
			IntPtr procAddress2 = GClass5.GetProcAddress(moduleHandleA, "GetModuleHandleA");
			if (!procAddress.smethod_4() && !procAddress2.smethod_4())
			{
				intptr_1 = GClass5.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)((uint)string_0.Length << 2), 12288, 4);
				IntPtr intPtr2 = GClass5.smethod_0(intptr_0, Encoding.ASCII.GetBytes(string.Join("\0", string_0) + "\0"), 4);
				if (!intptr_1.smethod_4() && !intPtr2.smethod_4())
				{
					try
					{
						uint num = 0u;
						byte[] array = new byte[string_0.Length << 2];
						for (int i = 0; i < array.Length >> 2; i++)
						{
							BitConverter.GetBytes(uint_0).CopyTo(array, i << 2);
						}
						GClass5.WriteProcessMemory(intptr_0, intptr_1, array, array.Length, out num);
						byte[] array2 = (byte[])Class8.byte_0.Clone();
						intPtr = GClass5.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)array2.Length, 12288, 64);
						if (intPtr.smethod_4())
						{
							throw new InvalidOperationException("Unable to allocate memory in the remote process");
						}
						BitConverter.GetBytes(intPtr2.ToInt32()).CopyTo(array2, 7);
						BitConverter.GetBytes(string_0.Length).CopyTo(array2, 15);
						BitConverter.GetBytes(intptr_1.ToInt32()).CopyTo(array2, 24);
						BitConverter.GetBytes(procAddress2.smethod_7(intPtr.smethod_0(56L)).ToInt32()).CopyTo(array2, 52);
						BitConverter.GetBytes(procAddress.smethod_7(intPtr.smethod_0(69L)).ToInt32()).CopyTo(array2, 65);
						if (GClass5.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num) && (ulong)num == (ulong)((long)array2.Length))
						{
							result = intPtr;
							goto IL_231;
						}
						throw new Exception("Error creating the remote function stub.");
					}
					finally
					{
						GClass5.VirtualFreeEx(intptr_0, intptr_1, 0, 32768);
						GClass5.VirtualFreeEx(intptr_0, intPtr2, 0, 32768);
						if (!intPtr.smethod_4())
						{
							GClass5.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
						}
						intptr_1 = IntPtr.Zero;
					}
					goto IL_21B;
					IL_231:
					return result;
				}
				IL_21B:
				throw new InvalidOperationException("Unable to allocate memory in the remote process");
			}
			throw new Exception("Unable to find necessary function entry points in the remote process");
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			result = IntPtr.Zero;
		}
		return result;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x010398CC File Offset: 0x01037ACC
	public override IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(GClass8 gclass8_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		string text = GClass11.smethod_2(gclass8_0.method_12());
		IntPtr result = IntPtr.Zero;
		if (!string.IsNullOrEmpty(text))
		{
			result = this.GClass10.\u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(text, intptr_0);
			try
			{
				File.Delete(text);
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x01039920 File Offset: 0x01037B20
	public override IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(GClass8[] gclass8_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		return this.GClass10.\u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(Array.ConvertAll<GClass8, string>(gclass8_0, new Converter<GClass8, string>(Class8.Class15.<>9.method_0)), intptr_0);
	}

	// Token: 0x06000383 RID: 899 RVA: 0x01039960 File Offset: 0x01037B60
	public override bool \u200E\u206C\u202E\u202D\u200C\u202E\u206B\u202C\u206D\u202E\u206C\u202B\u206E\u200B\u202C\u206D\u200D\u200D\u202C\u206F\u202D\u200D\u202C\u202C\u206D\u200E\u200B\u206A\u200E\u206B\u200E\u200B\u206A\u206A\u202D\u202C\u200E\u202E\u202A\u200E\u202E(IntPtr intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		if (!intptr_1.smethod_4() && !intptr_1.smethod_2(-1L))
		{
			if (intptr_0.smethod_4())
			{
				throw new ArgumentNullException("hModule", "Invalid module handle");
			}
			try
			{
				IntPtr[] intptr_2 = new IntPtr[]
				{
					intptr_0
				};
				bool[] array = this.GClass10.\u202B\u200E\u206C\u200C\u202C\u200F\u202C\u206C\u202D\u200F\u206B\u200B\u200B\u206E\u200D\u200C\u206C\u200C\u206F\u206E\u206D\u200C\u200B\u202C\u200B\u202D\u202C\u206B\u206B\u206D\u202E\u202B\u202D\u200C\u206D\u206D\u206D\u202A\u202D\u206C\u202E(intptr_2, intptr_1);
				return array != null && array.Length != 0 && array[0];
			}
			catch (Exception exception_)
			{
				this.vmethod_2(exception_);
				return false;
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x06000384 RID: 900 RVA: 0x010399F8 File Offset: 0x01037BF8
	public override bool[] \u202B\u200E\u206C\u200C\u202C\u200F\u202C\u206C\u202D\u200F\u206B\u200B\u200B\u206E\u200D\u200C\u206C\u200C\u206F\u206E\u206D\u200C\u200B\u202C\u200B\u202D\u202C\u206B\u206B\u206D\u202E\u202B\u202D\u200C\u206D\u206D\u206D\u202A\u202D\u206C\u202E(IntPtr[] intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		bool[] result;
		try
		{
			uint num = 0u;
			IntPtr procAddress = GClass5.GetProcAddress(GClass5.GetModuleHandleA("kernel32.dll"), "FreeLibrary");
			if (procAddress.smethod_4())
			{
				throw new Exception("Unable to find necessary function entry points in the remote process");
			}
			intPtr = GClass5.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)((uint)intptr_0.Length << 2), 12288, 4);
			intPtr2 = GClass5.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)((uint)(intptr_0.Length + 1) << 2), 12288, 4);
			intPtr3 = GClass5.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)Class8.byte_1.Length, 12288, 64);
			if (!intPtr.smethod_4() && !intPtr2.smethod_4() && !intPtr3.smethod_4())
			{
				byte[] array = new byte[intptr_0.Length + 1 << 2];
				for (int i = 0; i < intptr_0.Length; i++)
				{
					BitConverter.GetBytes(intptr_0[i].ToInt32()).CopyTo(array, i << 2);
				}
				GClass5.WriteProcessMemory(intptr_1, intPtr2, array, array.Length, out num);
				byte[] array2 = (byte[])Class8.byte_1.Clone();
				BitConverter.GetBytes(intPtr2.ToInt32()).CopyTo(array2, 7);
				BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(array2, 15);
				BitConverter.GetBytes(procAddress.smethod_7(intPtr3.smethod_0(56L)).ToInt32()).CopyTo(array2, 52);
				if (GClass5.WriteProcessMemory(intptr_1, intPtr3, array2, array2.Length, out num))
				{
					if ((ulong)num == (ulong)((long)array2.Length))
					{
						if (GClass5.smethod_7(intptr_1, intPtr3, 0u, 1000) == 4294967295u)
						{
							throw new InvalidOperationException("Error occurred when running remote function stub.");
						}
						byte[] array3 = GClass5.smethod_4(intptr_1, intPtr, (uint)((uint)intptr_0.Length << 2));
						if (array3 == null)
						{
							throw new Exception("Unable to read results from the remote process.");
						}
						bool[] array4 = new bool[intptr_0.Length];
						for (int i = 0; i < array4.Length; i++)
						{
							array4[i] = (BitConverter.ToInt32(array3, i << 2) != 0);
						}
						return array4;
					}
				}
				throw new InvalidOperationException("Unable to write the function stub to the remote process.");
			}
			throw new InvalidOperationException("Unable to allocate memory in the remote process");
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			result = null;
		}
		finally
		{
			GClass5.VirtualFreeEx(intptr_1, intPtr3, 0, 32768);
			GClass5.VirtualFreeEx(intptr_1, intPtr, 0, 32768);
			GClass5.VirtualFreeEx(intptr_1, intPtr2, 0, 32768);
		}
		return result;
	}

	// Token: 0x04000232 RID: 562
	protected static readonly byte[] byte_0 = new byte[]
	{
		85,
		139,
		236,
		131,
		236,
		12,
		185,
		0,
		0,
		0,
		0,
		137,
		12,
		36,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		4,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		8,
		139,
		76,
		36,
		4,
		131,
		249,
		0,
		116,
		58,
		131,
		233,
		1,
		137,
		76,
		36,
		4,
		byte.MaxValue,
		52,
		36,
		232,
		0,
		0,
		0,
		0,
		131,
		248,
		0,
		117,
		8,
		byte.MaxValue,
		52,
		36,
		232,
		0,
		0,
		0,
		0,
		139,
		76,
		36,
		8,
		137,
		1,
		131,
		193,
		4,
		137,
		76,
		36,
		8,
		139,
		12,
		36,
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
		12,
		36,
		235,
		189,
		139,
		229,
		93,
		195
	};

	// Token: 0x04000233 RID: 563
	protected static readonly byte[] byte_1 = new byte[]
	{
		85,
		139,
		236,
		131,
		236,
		12,
		185,
		0,
		0,
		0,
		0,
		137,
		12,
		36,
		185,
		0,
		0,
		0,
		0,
		137,
		76,
		36,
		4,
		139,
		12,
		36,
		139,
		9,
		131,
		249,
		0,
		116,
		58,
		137,
		76,
		36,
		8,
		139,
		76,
		36,
		4,
		199,
		1,
		0,
		0,
		0,
		0,
		byte.MaxValue,
		116,
		36,
		8,
		232,
		0,
		0,
		0,
		0,
		131,
		248,
		0,
		116,
		8,
		139,
		76,
		36,
		4,
		137,
		1,
		235,
		234,
		139,
		12,
		36,
		131,
		193,
		4,
		137,
		12,
		36,
		139,
		76,
		36,
		4,
		131,
		193,
		4,
		137,
		76,
		36,
		4,
		235,
		188,
		139,
		229,
		93,
		195
	};

	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	[Serializable]
	private sealed class Class15
	{
		// Token: 0x06000396 RID: 918 RVA: 0x01039CD0 File Offset: 0x01037ED0
		internal string method_0(GClass8 gclass8_0)
		{
			return GClass11.smethod_2(gclass8_0.method_12());
		}

		// Token: 0x04000234 RID: 564
		public static readonly Class8.Class15 <>9 = new Class8.Class15();

		// Token: 0x04000235 RID: 565
		public static Converter<GClass8, string> <>9__5_0;
	}
}
