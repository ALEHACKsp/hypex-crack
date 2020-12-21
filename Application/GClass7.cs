using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200002F RID: 47
[Serializable]
public class GClass7 : GClass6, IDisposable
{
	// Token: 0x060002A7 RID: 679 RVA: 0x01036E50 File Offset: 0x01035050
	public GClass7(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentException("Unable to iterate a null reference", "iterable");
		}
		this._base = new MemoryStream(byte_0, 0, byte_0.Length, true);
		this._ubuffer = new GClass9(256);
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x01036E98 File Offset: 0x01035098
	public void Dispose()
	{
		this.vmethod_4(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x01036EB4 File Offset: 0x010350B4
	protected virtual void vmethod_4(bool bool_0)
	{
		if (!this._disposed)
		{
			if (bool_0)
			{
				this._ubuffer.Dispose();
				this._base.Dispose();
			}
			this._disposed = true;
		}
	}

	// Token: 0x060002AA RID: 682 RVA: 0x01036EEC File Offset: 0x010350EC
	protected byte[] method_0()
	{
		return this._base.ToArray();
	}

	// Token: 0x060002AB RID: 683 RVA: 0x01036F04 File Offset: 0x01035104
	public bool method_1<T>(out T gparam_0) where T : struct
	{
		return this.method_3<T>(0L, SeekOrigin.Current, out gparam_0);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x01036F24 File Offset: 0x01035124
	public bool method_2(long long_0, SeekOrigin seekOrigin_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("buffer", "Parameter cannot be null");
		}
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			this._base.Read(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			this.vmethod_2(exception_);
			byte_0 = null;
		}
		return byte_0 != null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x01036F88 File Offset: 0x01035188
	public bool method_3<T>(long long_0, SeekOrigin seekOrigin_0, out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		bool result;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			byte[] array = new byte[Marshal.SizeOf(typeof(T))];
			this._base.Read(array, 0, array.Length);
			if (!this._ubuffer.method_9<T>(array, out gparam_0))
			{
				throw this._ubuffer.vmethod_1();
			}
			result = true;
		}
		catch (Exception exception_)
		{
			result = base.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0103700C File Offset: 0x0103520C
	public bool method_4(long long_0, SeekOrigin seekOrigin_0, out string string_0, int int_0 = -1, Encoding encoding_0 = null)
	{
		string_0 = null;
		byte[] array = new byte[(int_0 > 0) ? int_0 : 64];
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.ASCII;
		}
		bool result;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			StringBuilder stringBuilder = new StringBuilder((int_0 > 0) ? int_0 : 260);
			int num = -1;
			int num2 = 0;
			int num3;
			while (num == -1 && (num3 = this._base.Read(array, 0, array.Length)) > 0)
			{
				stringBuilder.Append(encoding_0.GetString(array));
				num = stringBuilder.ToString().IndexOf('\0', num2);
				num2 += num3;
				if (int_0 > 0 && num2 >= int_0)
				{
					break;
				}
			}
			if (num <= -1)
			{
				if (num2 >= int_0 && int_0 > 0)
				{
					string_0 = stringBuilder.ToString().Substring(0, int_0);
				}
			}
			else
			{
				string_0 = stringBuilder.ToString().Substring(0, num);
			}
			result = (string_0 != null);
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x01037108 File Offset: 0x01035308
	public long method_5(long long_0, SeekOrigin seekOrigin_0)
	{
		return this._base.Seek(long_0, seekOrigin_0);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x01037124 File Offset: 0x01035324
	public bool method_6(long long_0, SeekOrigin seekOrigin_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("Parameter 'data' cannot be null");
		}
		bool result;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			this._base.Write(byte_0, 0, byte_0.Length);
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x01037180 File Offset: 0x01035380
	public bool method_7<T>(long long_0, SeekOrigin seekOrigin_0, T gparam_0) where T : struct
	{
		bool result;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			byte[] array = null;
			if (!this._ubuffer.method_8<T>(gparam_0, out array))
			{
				throw this._ubuffer.vmethod_1();
			}
			this._base.Write(array, 0, array.Length);
			result = true;
		}
		catch (Exception exception_)
		{
			result = this.vmethod_2(exception_);
		}
		return result;
	}

	// Token: 0x04000176 RID: 374
	private MemoryStream _base;

	// Token: 0x04000177 RID: 375
	private bool _disposed;

	// Token: 0x04000178 RID: 376
	private GClass9 _ubuffer;
}
