using System;
using System.IO;
using System.Text;

// Token: 0x02000055 RID: 85
public class GClass17
{
	// Token: 0x060003EC RID: 1004 RVA: 0x0103AA2C File Offset: 0x01038C2C
	public GClass17(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.unicodeEncoding_0 = new UnicodeEncoding();
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0103AA54 File Offset: 0x01038C54
	public string method_0()
	{
		int num = this.stream_0.ReadByte() * 256;
		num += this.stream_0.ReadByte();
		byte[] array = new byte[num];
		this.stream_0.Read(array, 0, num);
		return this.unicodeEncoding_0.GetString(array);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0103AAA8 File Offset: 0x01038CA8
	public int method_1(string string_0)
	{
		byte[] bytes = this.unicodeEncoding_0.GetBytes(string_0);
		int num = bytes.Length;
		if (num > 65535)
		{
			num = 65535;
		}
		this.stream_0.WriteByte((byte)(num / 256));
		this.stream_0.WriteByte((byte)(num & 255));
		this.stream_0.Write(bytes, 0, num);
		this.stream_0.Flush();
		return bytes.Length + 2;
	}

	// Token: 0x04000240 RID: 576
	private Stream stream_0;

	// Token: 0x04000241 RID: 577
	private UnicodeEncoding unicodeEncoding_0;
}
