using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200002B RID: 43
public static class GClass5
{
	// Token: 0x0600026F RID: 623
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000270 RID: 624 RVA: 0x01036860 File Offset: 0x01034A60
	public static IntPtr smethod_0(IntPtr intptr_0, byte[] byte_0, int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (byte_0 != null && intptr_0 != IntPtr.Zero)
		{
			intPtr = GClass5.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)byte_0.Length, 12288, int_0);
			uint num = 0u;
			if (intPtr != IntPtr.Zero && GClass5.WriteProcessMemory(intptr_0, intPtr, byte_0, byte_0.Length, out num) && (ulong)num == (ulong)((long)byte_0.Length))
			{
				return intPtr;
			}
			if (intPtr != IntPtr.Zero)
			{
				GClass5.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
				intPtr = IntPtr.Zero;
			}
		}
		return intPtr;
	}

	// Token: 0x06000271 RID: 625
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, uint uint_0, int int_2, int int_3);

	// Token: 0x06000272 RID: 626
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetExitCodeThread(IntPtr intptr_0, out uint uint_0);

	// Token: 0x06000273 RID: 627 RVA: 0x010368E4 File Offset: 0x01034AE4
	public static uint smethod_1(IntPtr intptr_0)
	{
		IntPtr procAddress = GClass5.GetProcAddress(GClass5.GetModuleHandleA(<Module>.smethod_6<string>(4068761860u)), <Module>.smethod_9<string>(3522936248u));
		return GClass5.smethod_7(intptr_0, procAddress, 0u, 1000);
	}

	// Token: 0x06000274 RID: 628
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetModuleHandleA(string string_0);

	// Token: 0x06000275 RID: 629 RVA: 0x01036920 File Offset: 0x01034B20
	public static IntPtr smethod_2(IntPtr intptr_0, string string_0)
	{
		IntPtr procAddress = GClass5.GetProcAddress(GClass5.GetModuleHandleA("kernel32.dll"), "GetModuleHandleW");
		IntPtr result = IntPtr.Zero;
		if (!procAddress.smethod_4())
		{
			IntPtr intPtr = GClass5.smethod_0(intptr_0, Encoding.Unicode.GetBytes(string_0 + "\0"), 4);
			if (!intPtr.smethod_4())
			{
				result = GClass4.smethod_3((long)((ulong)GClass5.smethod_7(intptr_0, procAddress, (uint)intPtr.ToInt32(), 1000)));
				GClass5.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
			}
		}
		return result;
	}

	// Token: 0x06000276 RID: 630
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	// Token: 0x06000277 RID: 631
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", SetLastError = true)]
	public static extern IntPtr GetProcAddress_1(IntPtr intptr_0, uint uint_0);

	// Token: 0x06000278 RID: 632 RVA: 0x010369A0 File Offset: 0x01034BA0
	public static IntPtr smethod_3(IntPtr intptr_0, IntPtr intptr_1, object object_0)
	{
		IntPtr result = IntPtr.Zero;
		byte[] array = GClass5.smethod_4(intptr_0, intptr_1, 64u);
		if (array == null || BitConverter.ToUInt16(array, 0) != 23117)
		{
			return result;
		}
		uint num = BitConverter.ToUInt32(array, 60);
		if (num > 0u)
		{
			byte[] array2 = GClass5.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num)), 264u);
			if (array2 != null)
			{
				if (BitConverter.ToUInt32(array2, 0) == 17744u)
				{
					uint num2 = BitConverter.ToUInt32(array2, 120);
					uint num3 = BitConverter.ToUInt32(array2, 124);
					if (num2 <= 0u || num3 <= 0u)
					{
						return result;
					}
					byte[] array3 = GClass5.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num2)), 40u);
					uint num4 = BitConverter.ToUInt32(array3, 28);
					uint num5 = BitConverter.ToUInt32(array3, 36);
					uint num6 = BitConverter.ToUInt32(array3, 20);
					int num7 = -1;
					if (num4 <= 0u || num5 <= 0u)
					{
						return result;
					}
					if (object_0.GetType().Equals(typeof(string)))
					{
						int num8 = GClass5.smethod_8(intptr_0, intptr_1, array3, (string)object_0);
						if (num8 > -1)
						{
							byte[] array4 = GClass5.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num5 + (ulong)((long)((long)num8 << 1)))), 2u);
							num7 = ((array4 == null) ? -1 : ((int)BitConverter.ToUInt16(array4, 0)));
						}
					}
					else if (object_0.GetType().Equals(typeof(short)) || object_0.GetType().Equals(typeof(ushort)))
					{
						num7 = int.Parse(object_0.ToString());
					}
					if (num7 <= -1 || (long)num7 >= (long)((ulong)num6))
					{
						return result;
					}
					byte[] array5 = GClass5.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num4 + (ulong)((long)((long)num7 << 2)))), 4u);
					if (array5 == null)
					{
						return result;
					}
					uint num9 = BitConverter.ToUInt32(array5, 0);
					if (num9 >= num2 && num9 < num2 + num3)
					{
						string text = GClass5.smethod_6(intptr_0, intptr_1.smethod_0((long)((ulong)num9)), null);
						if (!string.IsNullOrEmpty(text) && text.Contains("."))
						{
							result = GClass5.smethod_3(intptr_0, GClass5.smethod_2(intptr_0, text.Split(new char[]
							{
								'.'
							})[0]), text.Split(new char[]
							{
								'.'
							})[1]);
						}
						return result;
					}
					return intptr_1.smethod_0((long)((ulong)num9));
				}
			}
			return result;
		}
		return result;
	}

	// Token: 0x06000279 RID: 633
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int GetProcessId(IntPtr intptr_0);

	// Token: 0x0600027A RID: 634
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetThreadContext(IntPtr intptr_0, ref GClass5.GStruct2 gstruct2_0);

	// Token: 0x0600027B RID: 635
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	// Token: 0x0600027C RID: 636
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenThread(uint uint_0, bool bool_0, int int_0);

	// Token: 0x0600027D RID: 637
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, out uint uint_0);

	// Token: 0x0600027E RID: 638 RVA: 0x01036BD4 File Offset: 0x01034DD4
	public static byte[] smethod_4(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		byte[] array = new byte[uint_0];
		uint num = 0u;
		if (!GClass5.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num) || num != uint_0)
		{
			array = null;
		}
		return array;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x01036C04 File Offset: 0x01034E04
	public static IntPtr smethod_5(IntPtr intptr_0, IntPtr intptr_1)
	{
		IntPtr zero = IntPtr.Zero;
		if (!intptr_0.smethod_4() && !intptr_1.smethod_4())
		{
			byte[] array = GClass5.smethod_4(intptr_0, intptr_1, (uint)IntPtr.Size);
			if (array != null)
			{
				zero = new IntPtr(BitConverter.ToInt32(array, 0));
			}
		}
		return zero;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x01036C48 File Offset: 0x01034E48
	public static string smethod_6(IntPtr intptr_0, IntPtr intptr_1, Encoding encoding_0 = null)
	{
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.ASCII;
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = new byte[256];
		uint num = 0u;
		int num2 = -1;
		while (num2 < 0 && GClass5.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num) && num > 0u)
		{
			intptr_1 = intptr_1.smethod_0((long)((ulong)num));
			int length = stringBuilder.Length;
			stringBuilder.Append(encoding_0.GetString(array, 0, (int)num));
			num2 = stringBuilder.ToString().IndexOf('\0', length);
		}
		return stringBuilder.ToString().Substring(0, num2);
	}

	// Token: 0x06000281 RID: 641
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint ResumeThread(IntPtr intptr_0);

	// Token: 0x06000282 RID: 642 RVA: 0x01036CD0 File Offset: 0x01034ED0
	public static uint smethod_7(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0 = 1000)
	{
		uint maxValue = uint.MaxValue;
		IntPtr intPtr = GClass5.CreateRemoteThread(intptr_0, 0, 0, intptr_1, uint_0, 0, 0);
		if (intPtr != IntPtr.Zero && (ulong)GClass5.WaitForSingleObject(intPtr, int_0) == 0UL)
		{
			GClass5.GetExitCodeThread(intPtr, out maxValue);
		}
		return maxValue;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x01036D10 File Offset: 0x01034F10
	private static int smethod_8(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, string string_0)
	{
		uint num = BitConverter.ToUInt32(byte_0, 24);
		uint num2 = BitConverter.ToUInt32(byte_0, 32);
		int num3 = -1;
		if (num > 0u && num2 > 0u)
		{
			byte[] array = GClass5.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num2)), num << 2);
			if (array == null)
			{
				return num3;
			}
			uint[] array2 = new uint[num];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = BitConverter.ToUInt32(array, i << 2);
			}
			int j = 0;
			int num4 = array2.Length - 1;
			string text = string.Empty;
			while (j >= 0)
			{
				if (j > num4)
				{
					break;
				}
				if (num3 != -1)
				{
					break;
				}
				int num5 = (j + num4) / 2;
				text = GClass5.smethod_6(intptr_0, intptr_1.smethod_0((long)((ulong)array2[num5])), null);
				if (!text.Equals(string_0))
				{
					if (string.CompareOrdinal(text, string_0) < 0)
					{
						j = num5 - 1;
					}
					else
					{
						num4 = num5 + 1;
					}
				}
				else
				{
					num3 = num5;
				}
			}
		}
		return num3;
	}

	// Token: 0x06000284 RID: 644
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetThreadContext(IntPtr intptr_0, ref GClass5.GStruct2 gstruct2_0);

	// Token: 0x06000285 RID: 645
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x06000286 RID: 646
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0, int int_1);

	// Token: 0x06000287 RID: 647
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1);

	// Token: 0x06000288 RID: 648
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, out uint uint_2);

	// Token: 0x06000289 RID: 649
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr intptr_0, int int_0);

	// Token: 0x0600028A RID: 650
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, out uint uint_0);

	// Token: 0x0200002C RID: 44
	public struct GStruct2
	{
		// Token: 0x04000153 RID: 339
		public uint uint_0;

		// Token: 0x04000154 RID: 340
		public uint uint_1;

		// Token: 0x04000155 RID: 341
		public uint uint_2;

		// Token: 0x04000156 RID: 342
		public uint uint_3;

		// Token: 0x04000157 RID: 343
		public uint uint_4;

		// Token: 0x04000158 RID: 344
		public uint uint_5;

		// Token: 0x04000159 RID: 345
		public uint uint_6;

		// Token: 0x0400015A RID: 346
		public GClass5.GStruct3 gstruct3_0;

		// Token: 0x0400015B RID: 347
		public uint uint_7;

		// Token: 0x0400015C RID: 348
		public uint uint_8;

		// Token: 0x0400015D RID: 349
		public uint uint_9;

		// Token: 0x0400015E RID: 350
		public uint uint_10;

		// Token: 0x0400015F RID: 351
		public uint uint_11;

		// Token: 0x04000160 RID: 352
		public uint uint_12;

		// Token: 0x04000161 RID: 353
		public uint uint_13;

		// Token: 0x04000162 RID: 354
		public uint uint_14;

		// Token: 0x04000163 RID: 355
		public uint uint_15;

		// Token: 0x04000164 RID: 356
		public uint uint_16;

		// Token: 0x04000165 RID: 357
		public uint uint_17;

		// Token: 0x04000166 RID: 358
		public uint uint_18;

		// Token: 0x04000167 RID: 359
		public uint uint_19;

		// Token: 0x04000168 RID: 360
		public uint uint_20;

		// Token: 0x04000169 RID: 361
		public uint uint_21;

		// Token: 0x0400016A RID: 362
		public uint uint_22;

		// Token: 0x0400016B RID: 363
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	// Token: 0x0200002D RID: 45
	public struct GStruct3
	{
		// Token: 0x0400016C RID: 364
		public uint uint_0;

		// Token: 0x0400016D RID: 365
		public uint uint_1;

		// Token: 0x0400016E RID: 366
		public uint uint_2;

		// Token: 0x0400016F RID: 367
		public uint uint_3;

		// Token: 0x04000170 RID: 368
		public uint uint_4;

		// Token: 0x04000171 RID: 369
		public uint uint_5;

		// Token: 0x04000172 RID: 370
		public uint uint_6;

		// Token: 0x04000173 RID: 371
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		// Token: 0x04000174 RID: 372
		public uint uint_7;
	}
}
