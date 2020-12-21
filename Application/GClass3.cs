using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Token: 0x0200001D RID: 29
public sealed class GClass3
{
	// Token: 0x060000DB RID: 219 RVA: 0x01029264 File Offset: 0x01027464
	public GClass3()
	{
		this.dictionary_0 = new Dictionary<Type, byte>();
		this.dictionary_0.Add(typeof(bool), 0);
		this.dictionary_0.Add(typeof(byte), 1);
		this.dictionary_0.Add(typeof(byte[]), 2);
		this.dictionary_0.Add(typeof(char), 3);
		this.dictionary_0.Add(typeof(char[]), 4);
		this.dictionary_0.Add(typeof(decimal), 5);
		this.dictionary_0.Add(typeof(double), 6);
		this.dictionary_0.Add(typeof(int), 7);
		this.dictionary_0.Add(typeof(long), 8);
		this.dictionary_0.Add(typeof(sbyte), 9);
		this.dictionary_0.Add(typeof(short), 10);
		this.dictionary_0.Add(typeof(float), 11);
		this.dictionary_0.Add(typeof(string), 12);
		this.dictionary_0.Add(typeof(uint), 13);
		this.dictionary_0.Add(typeof(ulong), 14);
		this.dictionary_0.Add(typeof(ushort), 15);
		this.dictionary_0.Add(typeof(DateTime), 16);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x01029400 File Offset: 0x01027600
	public byte[] method_0(params object[] object_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.UTF8);
		binaryWriter.Write(Convert.ToByte(object_0.Length));
		for (int i = 0; i <= object_0.Length - 1; i++)
		{
			byte value = this.dictionary_0[object_0[i].GetType()];
			binaryWriter.Write(value);
			switch (value)
			{
			case 0:
				binaryWriter.Write((bool)object_0[i]);
				break;
			case 1:
				binaryWriter.Write((byte)object_0[i]);
				break;
			case 2:
				binaryWriter.Write(((byte[])object_0[i]).Length);
				binaryWriter.Write((byte[])object_0[i]);
				break;
			case 3:
				binaryWriter.Write((char)object_0[i]);
				break;
			case 4:
				binaryWriter.Write(((char[])object_0[i]).ToString());
				break;
			case 5:
				binaryWriter.Write((decimal)object_0[i]);
				break;
			case 6:
				binaryWriter.Write((double)object_0[i]);
				break;
			case 7:
				binaryWriter.Write((int)object_0[i]);
				break;
			case 8:
				binaryWriter.Write((long)object_0[i]);
				break;
			case 9:
				binaryWriter.Write((sbyte)object_0[i]);
				break;
			case 10:
				binaryWriter.Write((short)object_0[i]);
				break;
			case 11:
				binaryWriter.Write((float)object_0[i]);
				break;
			case 12:
				binaryWriter.Write((string)object_0[i]);
				break;
			case 13:
				binaryWriter.Write((uint)object_0[i]);
				break;
			case 14:
				binaryWriter.Write((ulong)object_0[i]);
				break;
			case 15:
				binaryWriter.Write((ushort)object_0[i]);
				break;
			case 16:
				binaryWriter.Write(((DateTime)object_0[i]).ToBinary());
				break;
			}
		}
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	// Token: 0x060000DD RID: 221 RVA: 0x01029604 File Offset: 0x01027804
	public object[] method_1(byte[] byte_0)
	{
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(byte_0), Encoding.UTF8);
		List<object> list = new List<object>();
		byte b = binaryReader.ReadByte();
		for (int i = 0; i <= (int)(b - 1); i++)
		{
			switch (binaryReader.ReadByte())
			{
			case 0:
				list.Add(binaryReader.ReadBoolean());
				break;
			case 1:
				list.Add(binaryReader.ReadByte());
				break;
			case 2:
				list.Add(binaryReader.ReadBytes(binaryReader.ReadInt32()));
				break;
			case 3:
				list.Add(binaryReader.ReadChar());
				break;
			case 4:
				list.Add(binaryReader.ReadString().ToCharArray());
				break;
			case 5:
				list.Add(binaryReader.ReadDecimal());
				break;
			case 6:
				list.Add(binaryReader.ReadDouble());
				break;
			case 7:
				list.Add(binaryReader.ReadInt32());
				break;
			case 8:
				list.Add(binaryReader.ReadInt64());
				break;
			case 9:
				list.Add(binaryReader.ReadSByte());
				break;
			case 10:
				list.Add(binaryReader.ReadInt16());
				break;
			case 11:
				list.Add(binaryReader.ReadSingle());
				break;
			case 12:
				list.Add(binaryReader.ReadString());
				break;
			case 13:
				list.Add(binaryReader.ReadUInt32());
				break;
			case 14:
				list.Add(binaryReader.ReadUInt64());
				break;
			case 15:
				list.Add(binaryReader.ReadUInt16());
				break;
			case 16:
				list.Add(DateTime.FromBinary(binaryReader.ReadInt64()));
				break;
			}
		}
		binaryReader.Close();
		return list.ToArray();
	}

	// Token: 0x04000076 RID: 118
	private Dictionary<Type, byte> dictionary_0;
}
