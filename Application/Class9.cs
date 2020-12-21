using System;
using System.Text;

// Token: 0x02000048 RID: 72
internal class Class9 : Class8
{
	// Token: 0x0600032F RID: 815 RVA: 0x01038120 File Offset: 0x01036320
	public override IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		if (!intptr_0.smethod_4() && !intptr_0.smethod_2(-1L))
		{
			try
			{
				IntPtr result = IntPtr.Zero;
				IntPtr procAddress = GClass5.GetProcAddress(GClass5.GetModuleHandleA("kernel32.dll"), "LoadLibraryW");
				if (procAddress.smethod_4())
				{
					throw new Exception("Unable to locate the LoadLibraryW entry point");
				}
				IntPtr intPtr = GClass5.smethod_0(intptr_0, Encoding.Unicode.GetBytes(string_0 + "\0"), 4);
				if (!intPtr.smethod_4())
				{
					try
					{
						uint num = GClass5.smethod_7(intptr_0, procAddress, (uint)intPtr.ToInt32(), 10000);
						if (num == 0u)
						{
							throw new Exception("Failed to load module into remote process. Error code: " + GClass5.smethod_1(intptr_0).ToString());
						}
						if (num != 4294967295u)
						{
							result = GClass4.smethod_3((long)((ulong)num));
							goto IL_E5;
						}
						throw new Exception("Error occurred when calling function in the remote process");
					}
					finally
					{
						GClass5.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
					}
					goto IL_DA;
					IL_E5:
					return result;
				}
				IL_DA:
				throw new InvalidOperationException("Failed to allocate memory in the remote process");
			}
			catch (Exception exception_)
			{
				this.vmethod_2(exception_);
				return IntPtr.Zero;
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0103825C File Offset: 0x0103645C
	public override IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(string[] string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		if (!intptr_0.smethod_4() && !intptr_0.smethod_2(-1L))
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr intPtr = this.vmethod_10(string_0, intptr_0, out zero, 0u);
				IntPtr[] array = null;
				if (!intPtr.smethod_4())
				{
					try
					{
						if (GClass5.smethod_7(intptr_0, intPtr, 0u, 10000) == 4294967295u)
						{
							throw new Exception("Error occurred while executing remote thread.");
						}
						byte[] array2 = GClass5.smethod_4(intptr_0, zero, (uint)((uint)string_0.Length << 2));
						if (array2 == null)
						{
							throw new InvalidOperationException("Unable to read from the remote process.");
						}
						array = new IntPtr[string_0.Length];
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = new IntPtr(BitConverter.ToInt32(array2, i << 2));
						}
					}
					finally
					{
						GClass5.VirtualFreeEx(intptr_0, zero, 0, 32768);
						GClass5.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
					}
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
}
