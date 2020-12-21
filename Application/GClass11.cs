using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

// Token: 0x02000031 RID: 49
public static class GClass11
{
	// Token: 0x060002E0 RID: 736 RVA: 0x01037670 File Offset: 0x01035870
	public static T smethod_0<T>(T gparam_0)
	{
		T result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, gparam_0);
			memoryStream.Position = 0L;
			result = (T)((object)binaryFormatter.Deserialize(memoryStream));
		}
		return result;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x010376D0 File Offset: 0x010358D0
	public static uint smethod_1(this Type type_0)
	{
		return (uint)Marshal.SizeOf(type_0);
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x010376E4 File Offset: 0x010358E4
	public static string smethod_2(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		string text = null;
		try
		{
			text = Path.GetTempFileName();
		}
		catch (IOException)
		{
			text = Path.Combine(Directory.GetCurrentDirectory(), Path.GetRandomFileName());
		}
		try
		{
			File.WriteAllBytes(text, byte_0);
		}
		catch
		{
			text = null;
		}
		return text;
	}
}
