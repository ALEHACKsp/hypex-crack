using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000025 RID: 37
public partial class PerPixelAlphaForm : Form
{
	// Token: 0x06000247 RID: 583 RVA: 0x01036538 File Offset: 0x01034738
	public PerPixelAlphaForm()
	{
		base.FormBorderStyle = FormBorderStyle.None;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Load += this.PerPixelAlphaForm_Load;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x01036574 File Offset: 0x01034774
	private void PerPixelAlphaForm_Load(object sender, EventArgs e)
	{
		base.TopMost = true;
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000249 RID: 585 RVA: 0x01036588 File Offset: 0x01034788
	protected virtual CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			if (!base.DesignMode)
			{
				createParams.ExStyle |= 524288;
			}
			return createParams;
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x010365B8 File Offset: 0x010347B8
	protected virtual void WndProc(ref Message m)
	{
		if (m.Msg == 132)
		{
			m.Result = (IntPtr)2;
			return;
		}
		base.WndProc(ref m);
	}

	// Token: 0x0600024B RID: 587 RVA: 0x010365E8 File Offset: 0x010347E8
	public void method_0(Bitmap bitmap_0)
	{
		this.method_1(bitmap_0, 255);
	}

	// Token: 0x0600024C RID: 588 RVA: 0x01036604 File Offset: 0x01034804
	public void method_1(Bitmap bitmap_0, int int_4)
	{
		if (bitmap_0.PixelFormat != PixelFormat.Format32bppArgb)
		{
			throw new ApplicationException("The bitmap must be 32bpp with alpha-channel.");
		}
		IntPtr dc = PerPixelAlphaForm.GetDC(IntPtr.Zero);
		IntPtr intPtr = PerPixelAlphaForm.CreateCompatibleDC(dc);
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			intPtr2 = bitmap_0.GetHbitmap(Color.FromArgb(0));
			intptr_ = PerPixelAlphaForm.SelectObject(intPtr, intPtr2);
			PerPixelAlphaForm.Struct7 @struct = new PerPixelAlphaForm.Struct7(bitmap_0.Width, bitmap_0.Height);
			PerPixelAlphaForm.Struct6 struct2 = new PerPixelAlphaForm.Struct6(0, 0);
			PerPixelAlphaForm.Struct6 struct3 = new PerPixelAlphaForm.Struct6(base.Left, base.Top);
			PerPixelAlphaForm.Struct9 struct4 = default(PerPixelAlphaForm.Struct9);
			struct4.byte_0 = 0;
			struct4.byte_1 = 0;
			struct4.byte_2 = (byte)int_4;
			struct4.byte_3 = 1;
			PerPixelAlphaForm.UpdateLayeredWindow(this.method_3(), dc, ref struct3, ref @struct, intPtr, ref struct2, 0, ref struct4, 2);
		}
		finally
		{
			PerPixelAlphaForm.ReleaseDC(IntPtr.Zero, dc);
			if (intPtr2 != IntPtr.Zero)
			{
				PerPixelAlphaForm.SelectObject(intPtr, intptr_);
				PerPixelAlphaForm.DeleteObject(intPtr2);
			}
			PerPixelAlphaForm.DeleteDC(intPtr);
		}
	}

	// Token: 0x0600024D RID: 589
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UpdateLayeredWindow(IntPtr intptr_0, IntPtr intptr_1, ref PerPixelAlphaForm.Struct6 struct6_0, ref PerPixelAlphaForm.Struct7 struct7_0, IntPtr intptr_2, ref PerPixelAlphaForm.Struct6 struct6_1, int int_4, ref PerPixelAlphaForm.Struct9 struct9_0, int int_5);

	// Token: 0x0600024E RID: 590
	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

	// Token: 0x0600024F RID: 591
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetDC(IntPtr intptr_0);

	// Token: 0x06000250 RID: 592
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06000251 RID: 593
	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteDC(IntPtr intptr_0);

	// Token: 0x06000252 RID: 594
	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06000253 RID: 595
	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteObject(IntPtr intptr_0);

	// Token: 0x06000254 RID: 596 RVA: 0x01036710 File Offset: 0x01034910
	private void method_2()
	{
		base.SuspendLayout();
		base.ClientSize = new Size(284, 261);
		base.Name = "PerPixelAlphaForm";
		base.ResumeLayout(false);
	}

	// Token: 0x06000263 RID: 611 RVA: 0x010352F8 File Offset: 0x010334F8
	IntPtr method_3()
	{
		return base.Handle;
	}

	// Token: 0x04000141 RID: 321
	private const int int_0 = 524288;

	// Token: 0x04000142 RID: 322
	private const int int_1 = 2;

	// Token: 0x04000143 RID: 323
	private const int int_2 = 132;

	// Token: 0x04000144 RID: 324
	private const int int_3 = 2;

	// Token: 0x04000145 RID: 325
	private const byte byte_0 = 0;

	// Token: 0x04000146 RID: 326
	private const byte byte_1 = 1;

	// Token: 0x02000026 RID: 38
	private struct Struct6
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0103674C File Offset: 0x0103494C
		public Struct6(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x04000147 RID: 327
		public int int_0;

		// Token: 0x04000148 RID: 328
		public int int_1;
	}

	// Token: 0x02000027 RID: 39
	private struct Struct7
	{
		// Token: 0x06000266 RID: 614 RVA: 0x01036768 File Offset: 0x01034968
		public Struct7(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x04000149 RID: 329
		public int int_0;

		// Token: 0x0400014A RID: 330
		public int int_1;
	}

	// Token: 0x02000028 RID: 40
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct8
	{
		// Token: 0x0400014B RID: 331
		public byte byte_0;

		// Token: 0x0400014C RID: 332
		public byte byte_1;

		// Token: 0x0400014D RID: 333
		public byte byte_2;

		// Token: 0x0400014E RID: 334
		public byte byte_3;
	}

	// Token: 0x02000029 RID: 41
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct9
	{
		// Token: 0x0400014F RID: 335
		public byte byte_0;

		// Token: 0x04000150 RID: 336
		public byte byte_1;

		// Token: 0x04000151 RID: 337
		public byte byte_2;

		// Token: 0x04000152 RID: 338
		public byte byte_3;
	}
}
