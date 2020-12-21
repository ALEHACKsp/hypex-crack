using System;
using System.Runtime.InteropServices;

// Token: 0x02000030 RID: 48
[Serializable]
public class GClass9 : GClass6, IDisposable
{
	// Token: 0x060002C5 RID: 709 RVA: 0x010371EC File Offset: 0x010353EC
	public GClass9(int int_0)
	{
		if (int_0 <= 0)
		{
			this.IntPtr_0 = IntPtr.Zero;
			this.Int32_0 = 0;
			return;
		}
		this.IntPtr_0 = Marshal.AllocHGlobal(int_0);
		this.Int32_0 = int_0;
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0103722C File Offset: 0x0103542C
	private bool method_0(int int_0)
	{
		bool result;
		try
		{
			if (int_0 > this.Int32_0)
			{
				this.IntPtr_0 = ((this.IntPtr_0 == IntPtr.Zero) ? Marshal.AllocHGlobal(int_0) : Marshal.ReAllocHGlobal(this.IntPtr_0, new IntPtr(int_0)));
				this.Int32_0 = int_0;
			}
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0103729C File Offset: 0x0103549C
	public bool method_1<T>(T gparam_0) where T : struct
	{
		bool result;
		try
		{
			if (this.method_0(Marshal.SizeOf(typeof(T))))
			{
				Marshal.StructureToPtr<T>(gparam_0, this.IntPtr_0, false);
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x010372F4 File Offset: 0x010354F4
	public bool method_2(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 != null && this.method_0(int_1))
		{
			Marshal.Copy(byte_0, int_0, this.IntPtr_0, int_1);
			return true;
		}
		if (byte_0 == null)
		{
			this.vmethod_2(new ArgumentException("Attempting to commit a null reference", "data"));
		}
		return false;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x01037338 File Offset: 0x01035538
	public void Dispose()
	{
		this.method_3(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x01037354 File Offset: 0x01035554
	private void method_3(bool bool_0)
	{
		if (!this._disposed)
		{
			if (bool_0)
			{
				this.method_6(0);
			}
			this._disposed = true;
		}
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0103737C File Offset: 0x0103557C
	public byte[] method_4(int int_0)
	{
		byte[] result;
		try
		{
			if (int_0 > this.Int32_0 || int_0 <= 0)
			{
				throw new ArgumentException("There is either not enough memory allocated to read 'count' bytes, or 'count' is negative (" + int_0.ToString() + ")", "count");
			}
			byte[] array = new byte[int_0];
			Marshal.Copy(this.IntPtr_0, array, 0, int_0);
			result = array;
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			result = null;
		}
		return result;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x010373F0 File Offset: 0x010355F0
	public bool method_5<T>(out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		bool result;
		try
		{
			if (this.Int32_0 < Marshal.SizeOf(typeof(T)))
			{
				throw new InvalidCastException("Not enough unmanaged memory is allocated to contain this structure type.");
			}
			gparam_0 = (T)((object)Marshal.PtrToStructure(this.IntPtr_0, typeof(T)));
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x01037468 File Offset: 0x01035668
	public bool method_6(int int_0)
	{
		if (int_0 < 0)
		{
			return this.vmethod_2(new ArgumentException("Attempting to resize to less than zero bytes of memory", "size"));
		}
		if (int_0 == this.Int32_0)
		{
			return true;
		}
		if (int_0 > this.Int32_0)
		{
			return this.method_0(int_0);
		}
		bool result;
		try
		{
			if (int_0 == 0)
			{
				Marshal.FreeHGlobal(this.IntPtr_0);
				this.IntPtr_0 = IntPtr.Zero;
			}
			else if (int_0 > 0)
			{
				this.IntPtr_0 = Marshal.ReAllocHGlobal(this.IntPtr_0, new IntPtr(int_0));
			}
			this.Int32_0 = int_0;
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0103750C File Offset: 0x0103570C
	public bool method_7<T>() where T : struct
	{
		bool result;
		try
		{
			if (this.Int32_0 < Marshal.SizeOf(typeof(T)))
			{
				throw new InvalidCastException("Not enough unmanaged memory is allocated to contain this structure type.");
			}
			Marshal.DestroyStructure(this.IntPtr_0, typeof(T));
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x01037570 File Offset: 0x01035770
	public bool method_8<T>(T gparam_0, out byte[] byte_0) where T : struct
	{
		byte_0 = null;
		if (this.method_1<T>(gparam_0))
		{
			byte_0 = this.method_4(Marshal.SizeOf(typeof(T)));
			this.method_7<T>();
		}
		return byte_0 != null;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x010375AC File Offset: 0x010357AC
	public bool method_9<T>(byte[] byte_0, out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		if (byte_0 == null)
		{
			return this.vmethod_2(new ArgumentException("Attempted to translate a null reference to a structure.", "buffer"));
		}
		return this.method_2(byte_0, 0, byte_0.Length) && this.method_5<T>(out gparam_0);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x010375F0 File Offset: 0x010357F0
	public bool method_10<T, U>(T gparam_0, out U gparam_1) where T : struct where U : struct
	{
		gparam_1 = default(U);
		return this.method_1<T>(gparam_0) && this.method_5<U>(out gparam_1) && this.method_7<T>();
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060002D2 RID: 722 RVA: 0x01037620 File Offset: 0x01035820
	// (set) Token: 0x060002D3 RID: 723 RVA: 0x01037634 File Offset: 0x01035834
	public IntPtr IntPtr_0 { get; private set; }

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x01037648 File Offset: 0x01035848
	// (set) Token: 0x060002D5 RID: 725 RVA: 0x0103765C File Offset: 0x0103585C
	public int Int32_0 { get; private set; }

	// Token: 0x04000179 RID: 377
	private bool _disposed;
}
