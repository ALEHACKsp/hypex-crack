using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200000D RID: 13
public sealed class GClass0 : IDisposable
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600005B RID: 91 RVA: 0x01028424 File Offset: 0x01026624
	// (remove) Token: 0x0600005C RID: 92 RVA: 0x0102845C File Offset: 0x0102665C
	public event GClass0.GDelegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate0 gdelegate = this.gdelegate0_0;
			GClass0.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate0 value2 = (GClass0.GDelegate0)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate0 gdelegate = this.gdelegate0_0;
			GClass0.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate0 value2 = (GClass0.GDelegate0)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x01028498 File Offset: 0x01026698
	private void method_0(Exception exception_0)
	{
		if (this.gdelegate0_0 != null)
		{
			this.gdelegate0_0(this, exception_0);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x0600005E RID: 94 RVA: 0x010284BC File Offset: 0x010266BC
	// (remove) Token: 0x0600005F RID: 95 RVA: 0x010284F8 File Offset: 0x010266F8
	public event GClass0.GDelegate1 Event_1
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate1 gdelegate = this.gdelegate1_0;
			GClass0.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate1 value2 = (GClass0.GDelegate1)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate1 gdelegate = this.gdelegate1_0;
			GClass0.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate1 value2 = (GClass0.GDelegate1)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x01028534 File Offset: 0x01026734
	private void method_1(bool bool_4)
	{
		if (this.gdelegate1_0 != null)
		{
			this.gdelegate1_0(this, bool_4);
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000061 RID: 97 RVA: 0x01028558 File Offset: 0x01026758
	// (remove) Token: 0x06000062 RID: 98 RVA: 0x01028590 File Offset: 0x01026790
	public event GClass0.GDelegate2 Event_2
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate2 gdelegate = this.gdelegate2_0;
			GClass0.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate2 value2 = (GClass0.GDelegate2)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate2 gdelegate = this.gdelegate2_0;
			GClass0.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate2 value2 = (GClass0.GDelegate2)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x010285CC File Offset: 0x010267CC
	private void method_2(byte[] byte_2)
	{
		if (this.gdelegate2_0 != null)
		{
			this.gdelegate2_0(this, byte_2);
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06000064 RID: 100 RVA: 0x010285F0 File Offset: 0x010267F0
	// (remove) Token: 0x06000065 RID: 101 RVA: 0x01028628 File Offset: 0x01026828
	public event GClass0.GDelegate3 Event_3
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate3 gdelegate = this.gdelegate3_0;
			GClass0.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate3 value2 = (GClass0.GDelegate3)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate3 gdelegate = this.gdelegate3_0;
			GClass0.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate3 value2 = (GClass0.GDelegate3)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x01028660 File Offset: 0x01026860
	private void method_3(double double_0, int int_3, int int_4)
	{
		if (this.gdelegate3_0 != null)
		{
			this.gdelegate3_0(this, double_0, int_3, int_4);
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000067 RID: 103 RVA: 0x01028684 File Offset: 0x01026884
	// (remove) Token: 0x06000068 RID: 104 RVA: 0x010286BC File Offset: 0x010268BC
	public event GClass0.GDelegate4 Event_4
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate4 gdelegate = this.gdelegate4_0;
			GClass0.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate4 value2 = (GClass0.GDelegate4)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate4>(ref this.gdelegate4_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate4 gdelegate = this.gdelegate4_0;
			GClass0.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate4 value2 = (GClass0.GDelegate4)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate4>(ref this.gdelegate4_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x010286F8 File Offset: 0x010268F8
	private void method_4(int int_3)
	{
		if (this.gdelegate4_0 != null)
		{
			this.gdelegate4_0(this, int_3);
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x0600006A RID: 106 RVA: 0x0102871C File Offset: 0x0102691C
	// (remove) Token: 0x0600006B RID: 107 RVA: 0x01028754 File Offset: 0x01026954
	public event GClass0.GDelegate5 Event_5
	{
		[CompilerGenerated]
		add
		{
			GClass0.GDelegate5 gdelegate = this.gdelegate5_0;
			GClass0.GDelegate5 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate5 value2 = (GClass0.GDelegate5)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate5>(ref this.gdelegate5_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass0.GDelegate5 gdelegate = this.gdelegate5_0;
			GClass0.GDelegate5 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass0.GDelegate5 value2 = (GClass0.GDelegate5)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass0.GDelegate5>(ref this.gdelegate5_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x01028790 File Offset: 0x01026990
	private void method_5(double double_0, int int_3, int int_4)
	{
		if (this.gdelegate5_0 != null)
		{
			this.gdelegate5_0(this, double_0, int_3, int_4);
		}
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600006D RID: 109 RVA: 0x010287B4 File Offset: 0x010269B4
	// (set) Token: 0x0600006E RID: 110 RVA: 0x010287C8 File Offset: 0x010269C8
	public ushort UInt16_0
	{
		get
		{
			return this.ushort_0;
		}
		set
		{
			if (value < 1)
			{
				throw new Exception("Value must be greater than 0.");
			}
			this.ushort_0 = value;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600006F RID: 111 RVA: 0x010287EC File Offset: 0x010269EC
	// (set) Token: 0x06000070 RID: 112 RVA: 0x01028800 File Offset: 0x01026A00
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			if (value < 1)
			{
				throw new Exception("Value must be greater than 0.");
			}
			this.int_0 = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000071 RID: 113 RVA: 0x01028824 File Offset: 0x01026A24
	// (set) Token: 0x06000072 RID: 114 RVA: 0x01028838 File Offset: 0x01026A38
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (this.bool_1)
			{
				throw new Exception("Unable to change this option while connected.");
			}
			this.bool_0 = value;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000073 RID: 115 RVA: 0x01028860 File Offset: 0x01026A60
	// (set) Token: 0x06000074 RID: 116 RVA: 0x01028874 File Offset: 0x01026A74
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000075 RID: 117 RVA: 0x01028888 File Offset: 0x01026A88
	public IPEndPoint IPEndPoint_0
	{
		get
		{
			if (this.ipendPoint_0 != null)
			{
				return this.ipendPoint_0;
			}
			return new IPEndPoint(IPAddress.None, 0);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000076 RID: 118 RVA: 0x010288B0 File Offset: 0x01026AB0
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x010288C4 File Offset: 0x01026AC4
	public GClass0()
	{
		this.asyncOperation_0 = AsyncOperationManager.CreateOperation(null);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0102890C File Offset: 0x01026B0C
	public void method_6(string string_0, ushort ushort_1)
	{
		try
		{
			this.method_11();
			this.method_9();
			IPAddress none = IPAddress.None;
			if (!IPAddress.TryParse(string_0, out none))
			{
				Dns.BeginGetHostEntry(string_0, new AsyncCallback(this.method_7), ushort_1);
			}
			else
			{
				this.method_8(none, ushort_1);
			}
		}
		catch (Exception arg)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_18), arg);
			this.method_11();
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0102898C File Offset: 0x01026B8C
	private void method_7(IAsyncResult iasyncResult_0)
	{
		try
		{
			this.method_8(Dns.EndGetHostEntry(iasyncResult_0).AddressList[0], (ushort)iasyncResult_0.AsyncState);
		}
		catch (Exception arg)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_19), arg);
			this.method_11();
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x010289EC File Offset: 0x01026BEC
	private void method_8(IPAddress ipaddress_0, ushort ushort_1)
	{
		try
		{
			this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.socket_0.NoDelay = true;
			if (this.bool_0)
			{
				this.socket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 20000);
			}
			this.socketAsyncEventArgs_0[0].RemoteEndPoint = new IPEndPoint(ipaddress_0, (int)ushort_1);
			if (!this.socket_0.ConnectAsync(this.socketAsyncEventArgs_0[0]))
			{
				this.method_10(null, this.socketAsyncEventArgs_0[0]);
			}
		}
		catch (Exception arg)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_20), arg);
			this.method_11();
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x01028A9C File Offset: 0x01026C9C
	private void method_9()
	{
		this.bool_2 = new bool[2];
		this.int_1 = 0;
		this.int_2 = 0;
		this.byte_0 = new byte[0];
		this.byte_1 = new byte[0];
		this.queue_0 = new Queue<byte[]>();
		this.socketAsyncEventArgs_0 = new SocketAsyncEventArgs[2];
		this.socketAsyncEventArgs_0[0] = new SocketAsyncEventArgs();
		this.socketAsyncEventArgs_0[1] = new SocketAsyncEventArgs();
		this.socketAsyncEventArgs_0[0].Completed += this.method_10;
		this.socketAsyncEventArgs_0[1].Completed += this.method_10;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x01028B40 File Offset: 0x01026D40
	private void method_10(object sender, SocketAsyncEventArgs e)
	{
		try
		{
			if (e.SocketError == SocketError.Success)
			{
				SocketAsyncOperation lastOperation = e.LastOperation;
				if (lastOperation == SocketAsyncOperation.Connect)
				{
					this.ipendPoint_0 = (IPEndPoint)this.socket_0.RemoteEndPoint;
					this.bool_1 = true;
					this.socketAsyncEventArgs_0[0].SetBuffer(new byte[(int)this.ushort_0], 0, (int)this.ushort_0);
					this.asyncOperation_0.Post(new SendOrPostCallback(this.method_21), null);
					if (!this.socket_0.ReceiveAsync(e))
					{
						this.method_10(null, e);
					}
				}
				else if (lastOperation == SocketAsyncOperation.Receive)
				{
					if (this.bool_1)
					{
						if (e.BytesTransferred == 0)
						{
							this.method_11();
						}
						else
						{
							this.method_14(e.Buffer, 0, e.BytesTransferred);
							if (!this.socket_0.ReceiveAsync(e))
							{
								this.method_10(null, e);
							}
						}
					}
				}
				else if (lastOperation == SocketAsyncOperation.Send)
				{
					if (this.bool_1)
					{
						bool flag = false;
						this.int_1 += e.BytesTransferred;
						this.asyncOperation_0.Post(new SendOrPostCallback(this.method_16), new object[]
						{
							this.int_1 / this.byte_0.Length * 100,
							this.int_1,
							this.byte_0.Length
						});
						if (this.int_1 >= this.byte_0.Length)
						{
							flag = true;
							this.asyncOperation_0.Post(new SendOrPostCallback(this.method_22), this.byte_0.Length - 4);
						}
						if (this.queue_0.Count == 0 && flag)
						{
							this.bool_2[1] = false;
						}
						else
						{
							this.method_13();
						}
					}
				}
			}
			else
			{
				this.asyncOperation_0.Post(new SendOrPostCallback(this.method_23), new SocketException((int)e.SocketError));
				this.method_11();
			}
		}
		catch (Exception arg)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_24), arg);
			this.method_11();
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x01028D6C File Offset: 0x01026F6C
	public void method_11()
	{
		if (this.bool_2[0])
		{
			return;
		}
		this.bool_2[0] = true;
		bool flag = this.bool_1;
		this.bool_1 = false;
		if (this.socket_0 != null)
		{
			this.socket_0.Close();
		}
		if (this.queue_0 != null)
		{
			this.queue_0.Clear();
		}
		this.byte_0 = new byte[0];
		this.byte_1 = new byte[0];
		if (flag)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_25), null);
		}
		if (this.socketAsyncEventArgs_0 != null)
		{
			this.socketAsyncEventArgs_0[0].Dispose();
			this.socketAsyncEventArgs_0[1].Dispose();
		}
		this.object_0 = null;
		this.ipendPoint_0 = null;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x01028E24 File Offset: 0x01027024
	public void method_12(byte[] byte_2)
	{
		if (!this.bool_1)
		{
			return;
		}
		this.queue_0.Enqueue(byte_2);
		if (!this.bool_2[1])
		{
			this.bool_2[1] = true;
			this.method_13();
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x01028E60 File Offset: 0x01027060
	private void method_13()
	{
		try
		{
			if (this.int_1 >= this.byte_0.Length)
			{
				this.int_1 = 0;
				this.byte_0 = GClass0.smethod_0(this.queue_0.Dequeue());
			}
			int count = Math.Min(this.byte_0.Length - this.int_1, (int)this.ushort_0);
			this.socketAsyncEventArgs_0[1].SetBuffer(this.byte_0, this.int_1, count);
			if (!this.socket_0.SendAsync(this.socketAsyncEventArgs_0[1]))
			{
				this.method_10(null, this.socketAsyncEventArgs_0[1]);
			}
		}
		catch (Exception arg)
		{
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_26), arg);
			this.method_11();
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x01028F28 File Offset: 0x01027128
	private static byte[] smethod_0(byte[] byte_2)
	{
		byte[] array = new byte[byte_2.Length + 4];
		Buffer.BlockCopy(BitConverter.GetBytes(byte_2.Length), 0, array, 0, 4);
		Buffer.BlockCopy(byte_2, 0, array, 4, byte_2.Length);
		return array;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x01028F60 File Offset: 0x01027160
	private void method_14(byte[] byte_2, int int_3, int int_4)
	{
		if (this.int_2 >= this.byte_1.Length)
		{
			this.int_2 = 0;
			if (byte_2.Length < 4)
			{
				this.asyncOperation_0.Post(new SendOrPostCallback(this.method_27), null);
				this.method_11();
				return;
			}
			int num = BitConverter.ToInt32(byte_2, int_3);
			if (num > this.int_0)
			{
				this.asyncOperation_0.Post(new SendOrPostCallback(this.method_28), null);
				this.method_11();
				return;
			}
			Array.Resize<byte>(ref this.byte_1, num);
			int_3 += 4;
		}
		int num2 = Math.Min(this.byte_1.Length - this.int_2, int_4 - int_3);
		Buffer.BlockCopy(byte_2, int_3, this.byte_1, this.int_2, num2);
		this.int_2 += num2;
		this.asyncOperation_0.Post(new SendOrPostCallback(this.method_15), new object[]
		{
			this.int_2 / this.byte_1.Length * 100,
			this.int_2,
			this.byte_1.Length
		});
		if (this.int_2 >= this.byte_1.Length)
		{
			byte[] array = new byte[this.byte_1.Length];
			Buffer.BlockCopy(this.byte_1, 0, array, 0, this.byte_1.Length);
			this.asyncOperation_0.Post(new SendOrPostCallback(this.method_29), array);
		}
		if (num2 < int_4 - int_3)
		{
			this.method_14(byte_2, int_3 + num2, int_4);
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x010290D8 File Offset: 0x010272D8
	private void method_15(object object_1)
	{
		object[] array = (object[])object_1;
		this.method_3((double)((int)array[0]), (int)array[1], (int)array[2]);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0102910C File Offset: 0x0102730C
	private void method_16(object object_1)
	{
		object[] array = (object[])object_1;
		this.method_5((double)((int)array[0]), (int)array[1], (int)array[2]);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x01029140 File Offset: 0x01027340
	private void method_17(bool bool_4)
	{
		if (!this.bool_3 && bool_4)
		{
			this.method_11();
		}
		this.bool_3 = true;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x01029168 File Offset: 0x01027368
	public void Dispose()
	{
		this.method_17(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x01029184 File Offset: 0x01027384
	[CompilerGenerated]
	private void method_18(object object_1)
	{
		this.method_0((Exception)object_1);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x01029184 File Offset: 0x01027384
	[CompilerGenerated]
	private void method_19(object object_1)
	{
		this.method_0((Exception)object_1);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x01029184 File Offset: 0x01027384
	[CompilerGenerated]
	private void method_20(object object_1)
	{
		this.method_0((Exception)object_1);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x010291A0 File Offset: 0x010273A0
	[CompilerGenerated]
	private void method_21(object object_1)
	{
		this.method_1(true);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x010291B4 File Offset: 0x010273B4
	[CompilerGenerated]
	private void method_22(object object_1)
	{
		this.method_4((int)object_1);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x010291D0 File Offset: 0x010273D0
	[CompilerGenerated]
	private void method_23(object object_1)
	{
		this.method_0((SocketException)object_1);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x01029184 File Offset: 0x01027384
	[CompilerGenerated]
	private void method_24(object object_1)
	{
		this.method_0((Exception)object_1);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x010291EC File Offset: 0x010273EC
	[CompilerGenerated]
	private void method_25(object object_1)
	{
		this.method_1(false);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x01029184 File Offset: 0x01027384
	[CompilerGenerated]
	private void method_26(object object_1)
	{
		this.method_0((Exception)object_1);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x01029200 File Offset: 0x01027400
	[CompilerGenerated]
	private void method_27(object object_1)
	{
		this.method_0(new Exception(<Module>.smethod_5<string>(57085031u)));
	}

	// Token: 0x06000090 RID: 144 RVA: 0x01029224 File Offset: 0x01027424
	[CompilerGenerated]
	private void method_28(object object_1)
	{
		this.method_0(new Exception(<Module>.smethod_8<string>(3689386004u)));
	}

	// Token: 0x06000091 RID: 145 RVA: 0x01029248 File Offset: 0x01027448
	[CompilerGenerated]
	private void method_29(object object_1)
	{
		this.method_2((byte[])object_1);
	}

	// Token: 0x0400002E RID: 46
	[CompilerGenerated]
	private GClass0.GDelegate0 gdelegate0_0;

	// Token: 0x0400002F RID: 47
	[CompilerGenerated]
	private GClass0.GDelegate1 gdelegate1_0;

	// Token: 0x04000030 RID: 48
	[CompilerGenerated]
	private GClass0.GDelegate2 gdelegate2_0;

	// Token: 0x04000031 RID: 49
	[CompilerGenerated]
	private GClass0.GDelegate3 gdelegate3_0;

	// Token: 0x04000032 RID: 50
	[CompilerGenerated]
	private GClass0.GDelegate4 gdelegate4_0;

	// Token: 0x04000033 RID: 51
	[CompilerGenerated]
	private GClass0.GDelegate5 gdelegate5_0;

	// Token: 0x04000034 RID: 52
	private ushort ushort_0 = 8192;

	// Token: 0x04000035 RID: 53
	private int int_0 = 10485760;

	// Token: 0x04000036 RID: 54
	private bool bool_0 = true;

	// Token: 0x04000037 RID: 55
	private object object_0;

	// Token: 0x04000038 RID: 56
	private IPEndPoint ipendPoint_0;

	// Token: 0x04000039 RID: 57
	private bool bool_1;

	// Token: 0x0400003A RID: 58
	private AsyncOperation asyncOperation_0;

	// Token: 0x0400003B RID: 59
	private Socket socket_0;

	// Token: 0x0400003C RID: 60
	private int int_1;

	// Token: 0x0400003D RID: 61
	private byte[] byte_0;

	// Token: 0x0400003E RID: 62
	private int int_2;

	// Token: 0x0400003F RID: 63
	private byte[] byte_1;

	// Token: 0x04000040 RID: 64
	private Queue<byte[]> queue_0;

	// Token: 0x04000041 RID: 65
	private SocketAsyncEventArgs[] socketAsyncEventArgs_0;

	// Token: 0x04000042 RID: 66
	private bool[] bool_2 = new bool[2];

	// Token: 0x04000043 RID: 67
	private bool bool_3;

	// Token: 0x0200000E RID: 14
	// (Invoke) Token: 0x060000B5 RID: 181
	public delegate void GDelegate0(GClass0 sender, Exception ex);

	// Token: 0x0200000F RID: 15
	// (Invoke) Token: 0x060000B9 RID: 185
	public delegate void GDelegate1(GClass0 sender, bool connected);

	// Token: 0x02000010 RID: 16
	// (Invoke) Token: 0x060000BD RID: 189
	public delegate void GDelegate2(GClass0 sender, byte[] data);

	// Token: 0x02000011 RID: 17
	// (Invoke) Token: 0x060000C1 RID: 193
	public delegate void GDelegate3(GClass0 sender, double progress, int bytesRead, int bytesToRead);

	// Token: 0x02000012 RID: 18
	// (Invoke) Token: 0x060000C5 RID: 197
	public delegate void GDelegate4(GClass0 sender, int size);

	// Token: 0x02000013 RID: 19
	// (Invoke) Token: 0x060000C9 RID: 201
	public delegate void GDelegate5(GClass0 sender, double progress, int bytesWritten, int bytesToWrite);
}
