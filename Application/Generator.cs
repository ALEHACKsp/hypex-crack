using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ExHtmlEditor.ColorPicker;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing.Html;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;
using WK.Libraries.BetterFolderBrowserNS;

// Token: 0x02000060 RID: 96
public partial class Generator : Form
{
	// Token: 0x06000613 RID: 1555
	[DllImport("Shell32.dll")]
	private static extern int SHChangeNotify(int int_11, int int_12, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000614 RID: 1556 RVA: 0x0103FB38 File Offset: 0x0103DD38
	// (set) Token: 0x06000615 RID: 1557 RVA: 0x0103FB4C File Offset: 0x0103DD4C
	private Color Color_0 { get; set; }

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x0103FB60 File Offset: 0x0103DD60
	// (set) Token: 0x06000617 RID: 1559 RVA: 0x0103FB74 File Offset: 0x0103DD74
	private Color Color_1 { get; set; }

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000618 RID: 1560 RVA: 0x0103FB88 File Offset: 0x0103DD88
	// (set) Token: 0x06000619 RID: 1561 RVA: 0x0103FB9C File Offset: 0x0103DD9C
	private Color Color_2 { get; set; }

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x0600061A RID: 1562 RVA: 0x0103FBB0 File Offset: 0x0103DDB0
	// (set) Token: 0x0600061B RID: 1563 RVA: 0x0103FBC4 File Offset: 0x0103DDC4
	private Color Color_3 { get; set; }

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x0103FBD8 File Offset: 0x0103DDD8
	// (set) Token: 0x0600061D RID: 1565 RVA: 0x0103FBEC File Offset: 0x0103DDEC
	private Color Color_4 { get; set; }

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x0600061E RID: 1566 RVA: 0x0103FC00 File Offset: 0x0103DE00
	// (set) Token: 0x0600061F RID: 1567 RVA: 0x0103FC14 File Offset: 0x0103DE14
	public static object Object_0 { get; private set; }

	// Token: 0x06000620 RID: 1568
	[DllImport("kernel32.dll")]
	private static extern bool CreateSymbolicLink(string string_83, string string_84, Generator.Enum0 enum0_0);

	// Token: 0x06000621 RID: 1569
	[DllImport("user32.dll")]
	private static extern int SendMessage(int int_11, uint uint_1, uint uint_2, uint uint_3);

	// Token: 0x06000622 RID: 1570 RVA: 0x0103FC28 File Offset: 0x0103DE28
	private void method_0()
	{
		if (this.thread_0 != null)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x0103FC48 File Offset: 0x0103DE48
	private void method_1()
	{
		if (this.thread_2 != null)
		{
			this.thread_2.Abort();
		}
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0103FC68 File Offset: 0x0103DE68
	private void method_2()
	{
		if (this.thread_3 != null)
		{
			this.thread_3.Abort();
		}
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0103FC88 File Offset: 0x0103DE88
	private void method_3()
	{
		if (this.thread_1 != null)
		{
			this.thread_1.Abort();
		}
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0103FCA8 File Offset: 0x0103DEA8
	public Generator(Worker worker_1)
	{
		this.worker_0 = worker_1;
		Settings.Default.fullhideTiming = 1000;
		Settings.Default.autofullhide = true;
		Settings.Default.Save();
		this.InitializeComponent();
		this.fullhide.Enabled = false;
		GClass21.smethod_2(false, true);
		if (File.Exists(Generator.string_1 + "edit.zip") || Directory.Exists(Generator.string_2))
		{
			this.method_26();
			anti_anal.found("Illegal termination");
		}
		this.method_53();
		this.method_6();
		this.method_48();
		this.metroToggle26.Checked = false;
		this.metroToggle22.Checked = false;
		this.statusRecoil.Text = this.metroTrackBar1.Value.ToString() + "%";
		if (this.metroTrackBar2.Value >= 5)
		{
			this.string_27 += "all";
			this.statusTrees.Text = "At all";
		}
		else
		{
			this.string_27 += "400";
			this.statusTrees.Text = "After 400m";
		}
		if (!this.metroToggle1.Checked)
		{
			this.metroTrackBar1.Enabled = false;
		}
		if (!this.metroToggle22.Checked)
		{
			this.metroTrackBar2.Enabled = false;
		}
		this.status.Text = "Settings Successfully loaded!";
		this.gamepath.Text = Settings.Default.GamePath;
		this.metroTabControl1.SelectedTab = this.metroTabPage1;
		this.metroTabControl1.SelectTab("metroTabPage1");
		this.metroToggle22.Enabled = false;
		this.method_21();
		new Thread(new ThreadStart(this.method_69)).Start();
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x01040120 File Offset: 0x0103E320
	public static string smethod_0(int int_11)
	{
		return new string(Enumerable.Repeat<string>(<Module>.smethod_9<string>(1245902320u), int_11).Select(new Func<string, char>(Generator.Class26.<>9.method_0)).ToArray<char>());
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0104016C File Offset: 0x0103E36C
	public void method_5()
	{
		base.Invoke(new MethodInvoker(this.method_70));
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0104018C File Offset: 0x0103E38C
	private void Generator_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 174, 219), 16f), 0, 0, this.method_76().Right, 0);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void Generator_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x010401D0 File Offset: 0x0103E3D0
	private void method_6()
	{
		this.webBrowser1.AllowWebBrowserDrop = false;
		this.webBrowser1.Url = new Uri(Config.News);
		string text = anti_anal.HtmlResponse(Config.News);
		if (string.IsNullOrEmpty(text) || text == "")
		{
			text = new WebClient().DownloadString(Config.News);
		}
		string[] array = Regex.Match(text, "\\<title\\b[^>]*\\>\\s*(?<Title>[\\s\\S]*?)\\</title\\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Split(new char[]
		{
			' '
		});
		if (array.Length > 1)
		{
			string a = array[0];
			if (!(a == "0"))
			{
				if (a == "1")
				{
					this.statusLabel.Text = "Undetected";
					this.statusLabel.ForeColor = Color.Chartreuse;
				}
				else if (a == "2")
				{
					this.statusLabel.Text = "Maintenance";
					this.statusLabel.ForeColor = Color.Gold;
					this.generate.Enabled = false;
				}
			}
			else
			{
				this.statusLabel.Text = "Detected";
				this.statusLabel.ForeColor = Color.OrangeRed;
				this.generate.Enabled = false;
			}
			this.lastUpd.Text = array[1];
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x01040320 File Offset: 0x0103E520
	private void Generator_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.bool_1)
		{
			this.worker_0.Shutdown();
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x01040340 File Offset: 0x0103E540
	public void method_7()
	{
		this.bool_1 = false;
		base.Invoke(new MethodInvoker(this.method_71));
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x01040368 File Offset: 0x0103E568
	private void method_8(string string_83)
	{
		DateTime now = DateTime.Now;
		if (File.Exists(string_83))
		{
			File.SetLastWriteTime(string_83, now);
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0104038C File Offset: 0x0103E58C
	public void method_9(string string_83)
	{
		try
		{
			if (File.Exists(string_83))
			{
				File.Delete(string_83);
			}
		}
		catch
		{
			this.method_28("Taskkill /IM " + string_83 + " /F");
			Thread.Sleep(100);
			if (File.Exists(string_83))
			{
				File.Delete(string_83);
			}
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x010403E8 File Offset: 0x0103E5E8
	public bool method_10()
	{
		/*
An exception occurred when decompiling this method (06000632)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Generator::method_10()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x01040478 File Offset: 0x0103E678
	public int method_11(string string_83)
	{
		Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_8<string>(1675191760u), <Module>.smethod_9<string>(394106356u) + string_83)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_8<string>(293641987u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		int exitCode = process.ExitCode;
		process.Close();
		return exitCode;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x010404E8 File Offset: 0x0103E6E8
	private bool method_12()
	{
		return Settings.Default.autofullhide;
	}

	// Token: 0x06000635 RID: 1589
	[DllImport("user32.dll")]
	private static extern bool EnumWindows(Generator.Delegate0 delegate0_0, IntPtr intptr_1);

	// Token: 0x06000636 RID: 1590
	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowThreadProcessId(IntPtr intptr_1, out IntPtr intptr_2);

	// Token: 0x06000637 RID: 1591
	[DllImport("user32.dll")]
	private static extern uint RealGetWindowClass(IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_1);

	// Token: 0x06000638 RID: 1592
	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_1, uint uint_1, IntPtr intptr_2, IntPtr intptr_3);

	// Token: 0x06000639 RID: 1593 RVA: 0x01040500 File Offset: 0x0103E700
	private static bool smethod_1(IntPtr intptr_1, IntPtr intptr_2)
	{
		IntPtr intPtr = 0;
		Generator.GetWindowThreadProcessId(intptr_1, out intPtr);
		Process processById = Process.GetProcessById(intPtr.ToInt32());
		StringBuilder stringBuilder = new StringBuilder(255);
		Generator.RealGetWindowClass(intptr_1, stringBuilder, 255u);
		if (processById.ProcessName == "explorer" && stringBuilder.ToString() == "CabinetWClass")
		{
			Generator.SendMessage_1(intptr_1, Generator.uint_0, IntPtr.Zero, IntPtr.Zero);
		}
		return true;
	}

	// Token: 0x0600063A RID: 1594
	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessageTimeout(IntPtr intptr_1, int int_11, IntPtr intptr_2, string string_83, uint uint_1, uint uint_2, IntPtr intptr_3);

	// Token: 0x0600063B RID: 1595 RVA: 0x0104057C File Offset: 0x0103E77C
	public void method_13()
	{
		try
		{
			Generator.Delegate0 delegate0_ = new Generator.Delegate0(Generator.smethod_1);
			Thread.Sleep(1);
			Generator.EnumWindows(delegate0_, IntPtr.Zero);
			Thread.Sleep(1);
			bool flag;
			do
			{
				flag = this.method_46(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", 2, RegistryValueKind.DWord);
				Thread.Sleep(10);
			}
			while (!flag);
			do
			{
				flag = this.method_46(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", 0, RegistryValueKind.DWord);
				Thread.Sleep(10);
			}
			while (!flag);
			Thread.Sleep(10);
		}
		catch
		{
		}
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x01040620 File Offset: 0x0103E820
	private void method_14()
	{
		Class17 @class = new Class17();
		Class17.List_1 = new List<string>
		{
			<Module>.smethod_9<string>(3163125085u)
		};
		Class17.List_0 = new List<string>
		{
			<Module>.smethod_5<string>(2988271152u),
			<Module>.smethod_6<string>(4140787326u)
		};
		@class.method_1();
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0104067C File Offset: 0x0103E87C
	private void method_15()
	{
		/*
An exception occurred when decompiling this method (0600063D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_15()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x01040844 File Offset: 0x0103EA44
	private void generate_Click(object sender, EventArgs e)
	{
		/*
An exception occurred when decompiling this method (0600063E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::generate_Click(System.Object,System.EventArgs)
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x01041144 File Offset: 0x0103F344
	private void method_16(string string_83)
	{
		try
		{
			ZipFile.ExtractToDirectory(string_83 + <Module>.smethod_7<string>(1392201551u), string_83);
		}
		catch
		{
		}
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0104117C File Offset: 0x0103F37C
	private void method_17(string string_83)
	{
		/*
An exception occurred when decompiling this method (06000640)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_17(System.String)
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x01041B50 File Offset: 0x0103FD50
	private string method_18(float float_0)
	{
		return BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0).ToString(<Module>.smethod_6<string>(1737955208u));
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x01041B7C File Offset: 0x0103FD7C
	private float method_19(string string_83)
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(Convert.ToInt32(string_83, 16)), 0);
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x01041B9C File Offset: 0x0103FD9C
	public bool method_20(string string_83)
	{
		bool result;
		try
		{
			using (ServiceController serviceController = new ServiceController(string_83))
			{
				result = (serviceController.Status == ServiceControllerStatus.Running);
			}
		}
		catch (ArgumentException)
		{
			result = false;
		}
		catch (Win32Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x01041BFC File Offset: 0x0103FDFC
	private void method_21()
	{
		List<MetroLabel> list = new List<MetroLabel>
		{
			this.status1,
			this.status2,
			this.status3,
			this.status4,
			this.status5,
			this.status6,
			this.status7,
			this.status8,
			this.status9,
			this.status10,
			this.status11,
			this.status12,
			this.status13,
			this.status14,
			this.status15,
			this.status16,
			this.status17,
			this.status18,
			this.status19,
			this.status20,
			this.status21,
			this.status22,
			this.status23,
			this.status24,
			this.status25,
			this.status26,
			this.status27,
			this.status28,
			this.status29,
			this.status30,
			this.status31,
			this.status32,
			this.status33,
			this.status34,
			this.status35,
			this.status36,
			this.bypassLabel,
			this.oldbypassLabel,
			this.automaticLabel,
			this.autoLaunchLabel,
			this.status37,
			this.status38,
			this.status39,
			this.status40,
			this.status41,
			this.status42,
			this.status43,
			this.status44,
			this.status45,
			this.newbypassLabel
		};
		List<bool> list2 = new List<bool>
		{
			this.metroToggle1.Checked,
			this.metroToggle2.Checked,
			this.metroToggle3.Checked,
			this.metroToggle4.Checked,
			this.metroToggle5.Checked,
			this.metroToggle6.Checked,
			this.metroToggle7.Checked,
			this.metroToggle8.Checked,
			this.metroToggle9.Checked,
			this.metroToggle10.Checked,
			this.metroToggle11.Checked,
			this.metroToggle12.Checked,
			this.metroToggle13.Checked,
			this.metroToggle14.Checked,
			this.metroToggle15.Checked,
			this.metroToggle16.Checked,
			this.metroToggle17.Checked,
			this.metroToggle18.Checked,
			this.metroToggle19.Checked,
			this.metroToggle20.Checked,
			this.metroToggle21.Checked,
			this.metroToggle22.Checked,
			this.metroToggle23.Checked,
			this.metroToggle24.Checked,
			this.metroToggle25.Checked,
			this.metroToggle26.Checked,
			this.metroToggle27.Checked,
			this.metroToggle28.Checked,
			this.metroToggle29.Checked,
			this.metroToggle30.Checked,
			this.metroToggle31.Checked,
			this.metroToggle32.Checked,
			this.metroToggle33.Checked,
			this.metroToggle34.Checked,
			this.metroToggle35.Checked,
			this.metroToggle36.Checked,
			this.bypassToggle.Checked,
			this.oldbypassToggle.Checked,
			this.automaticToggle.Checked,
			this.autoLaunchToggle.Checked,
			this.metroToggle37.Checked,
			this.metroToggle38.Checked,
			this.metroToggle39.Checked,
			this.metroToggle40.Checked,
			this.metroToggle41.Checked,
			this.metroToggle42.Checked,
			this.metroToggle43.Checked,
			this.metroToggle44.Checked,
			this.metroToggle45.Checked,
			this.newbypassToggle.Checked
		};
		for (int i = 0; i < list.Count; i++)
		{
			this.method_22(list[i], list2[i]);
		}
		if (this.automaticToggle.Checked)
		{
			this.fullhide.Visible = false;
			this.generate.Text = "Inject";
			this.generate.Size = new Size(208, 40);
			this.metroLabel23.Visible = false;
			return;
		}
		this.generate.Text = "Generate";
		this.fullhide.Visible = true;
		this.generate.Size = new Size(93, 40);
		this.metroLabel23.Visible = true;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x01042270 File Offset: 0x01040470
	private void method_22(MetroLabel metroLabel_0, bool bool_2)
	{
		if (bool_2)
		{
			metroLabel_0.Text = "ON";
			return;
		}
		metroLabel_0.Text = "OFF";
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x01042298 File Offset: 0x01040498
	private void method_23(bool bool_2, string string_83, int int_11)
	{
		if (!new List<bool>
		{
			this.metroToggle1.Enabled,
			this.metroToggle2.Enabled,
			this.metroToggle3.Enabled,
			this.metroToggle4.Enabled,
			this.metroToggle5.Enabled,
			this.metroToggle6.Enabled,
			this.metroToggle7.Enabled,
			this.metroToggle8.Enabled,
			this.metroToggle9.Enabled,
			this.metroToggle10.Enabled,
			this.metroToggle11.Enabled,
			this.metroToggle12.Enabled,
			this.metroToggle13.Enabled,
			this.metroToggle14.Enabled,
			this.metroToggle15.Enabled,
			this.metroToggle16.Enabled,
			this.metroToggle17.Enabled,
			this.metroToggle18.Enabled,
			this.metroToggle19.Enabled,
			this.metroToggle20.Enabled,
			this.metroToggle21.Enabled,
			this.metroToggle22.Enabled,
			this.metroToggle23.Enabled,
			this.metroToggle24.Enabled,
			this.metroToggle25.Enabled,
			this.metroToggle26.Enabled,
			this.metroToggle27.Enabled,
			this.metroToggle28.Enabled,
			this.metroToggle29.Enabled,
			this.metroToggle30.Enabled,
			this.metroToggle31.Enabled,
			this.metroToggle32.Enabled,
			this.metroToggle33.Enabled,
			this.metroToggle34.Enabled,
			this.metroToggle35.Enabled,
			this.metroToggle36.Enabled,
			this.metroToggle37.Enabled,
			this.metroToggle38.Enabled,
			this.metroToggle39.Enabled,
			this.metroToggle40.Enabled,
			this.metroToggle41.Enabled,
			this.metroToggle42.Enabled,
			this.metroToggle43.Enabled,
			this.metroToggle44.Enabled,
			this.metroToggle45.Enabled
		}[int_11])
		{
			bool_2 = false;
		}
		if (bool_2)
		{
			this.method_16(Generator.string_2 + string_83);
			this.method_17(string_83);
		}
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x010425D0 File Offset: 0x010407D0
	public static void smethod_2(string string_83, byte[] byte_0, string string_84, string string_85)
	{
		foreach (string path in Directory.GetFiles(string_83, "*.*", System.IO.SearchOption.AllDirectories))
		{
			try
			{
				File.SetAttributes(path, FileAttributes.Normal);
				string text = BitConverter.ToString(File.ReadAllBytes(path));
				if (text.Contains(string_84))
				{
					string text2 = text.Replace(string_84, BitConverter.ToString(byte_0) + string_85);
					File.WriteAllBytes(path, Generator.smethod_6(text2.Replace("-", string.Empty)));
				}
			}
			catch
			{
			}
			Thread.Sleep(1);
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x01042668 File Offset: 0x01040868
	public static string smethod_3(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		foreach (byte b in byte_0)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x010426AC File Offset: 0x010408AC
	public static void smethod_4(string string_83, byte[] byte_0, string string_84)
	{
		foreach (string path in Directory.GetFiles(string_83, "*.*", System.IO.SearchOption.AllDirectories))
		{
			try
			{
				File.SetAttributes(path, FileAttributes.Normal);
				string text = Generator.smethod_3(File.ReadAllBytes(path)).ToUpper();
				if (text.Contains(string_84.ToUpper()))
				{
					string text2 = text.Replace(string_84.ToUpper(), BitConverter.ToString(byte_0).Replace("-", string.Empty).ToUpper());
					File.WriteAllBytes(path, Generator.smethod_6(text2.Replace("-", string.Empty)));
				}
			}
			catch
			{
			}
			Thread.Sleep(1);
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x01042768 File Offset: 0x01040968
	public static void smethod_5(string string_83, string string_84, string string_85)
	{
		foreach (string path in Directory.GetFiles(string_83, "*.*", System.IO.SearchOption.AllDirectories))
		{
			try
			{
				File.SetAttributes(path, FileAttributes.Normal);
				string text = BitConverter.ToString(File.ReadAllBytes(path));
				if (text.Contains(string_84))
				{
					string text2 = text.Replace(string_84, string_85);
					File.WriteAllBytes(path, Generator.smethod_6(text2.Replace("-", string.Empty)));
				}
			}
			catch
			{
			}
			Thread.Sleep(1);
		}
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x010427F8 File Offset: 0x010409F8
	public static byte[] smethod_6(string string_83)
	{
		Generator.Class27 @class = new Generator.Class27();
		@class.string_0 = string_83;
		return Enumerable.Range(0, @class.string_0.Length).Where(new Func<int, bool>(Generator.Class26.<>9.method_3)).Select(new Func<int, byte>(@class.method_0)).ToArray<byte>();
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x01042860 File Offset: 0x01040A60
	private void method_24(string string_83, string string_84)
	{
		if (!Directory.Exists(string_84))
		{
			Directory.CreateDirectory(string_84);
		}
		foreach (string text in Directory.GetFiles(string_83))
		{
			File.Copy(text, Path.Combine(string_84, Path.GetFileName(text)), true);
		}
		foreach (string text2 in Directory.GetDirectories(string_83))
		{
			this.method_24(text2, Path.Combine(string_84, Path.GetFileName(text2)));
		}
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x010428D4 File Offset: 0x01040AD4
	public static void smethod_7(string string_83, string string_84, string string_85)
	{
		DirectoryInfo directoryInfo_ = new DirectoryInfo(string_83);
		DirectoryInfo directoryInfo_2 = new DirectoryInfo(string_84);
		Generator.smethod_8(directoryInfo_, directoryInfo_2, string_85);
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x010428F8 File Offset: 0x01040AF8
	public static void smethod_8(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1, string string_83)
	{
		Directory.CreateDirectory(directoryInfo_1.FullName);
		foreach (FileInfo fileInfo in directoryInfo_0.GetFiles())
		{
			if (directoryInfo_1.Name != string_83)
			{
				Console.WriteLine("Copying {0}\\{1}", directoryInfo_1.FullName, fileInfo.Name);
				fileInfo.CopyTo(Path.Combine(directoryInfo_1.FullName, fileInfo.Name), true);
			}
		}
		foreach (DirectoryInfo directoryInfo in directoryInfo_0.GetDirectories())
		{
			if (directoryInfo.Name != string_83)
			{
				DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
				Generator.smethod_8(directoryInfo, directoryInfo_2, string_83);
			}
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x010429AC File Offset: 0x01040BAC
	private void method_25()
	{
		if (Directory.Exists(this.string_4))
		{
			this.method_26();
		}
		if (Directory.Exists(this.string_3))
		{
			this.method_26();
		}
		if (Directory.Exists(Generator.string_1 + "edit.zip"))
		{
			this.method_26();
		}
		if (Directory.Exists(Generator.string_2))
		{
			this.method_26();
		}
		Directory.CreateDirectory(this.string_4);
		File.SetAttributes(this.string_4, File.GetAttributes(this.string_4) | (FileAttributes.Hidden | FileAttributes.System));
		Directory.CreateDirectory(this.string_3);
		File.SetAttributes(this.string_3, File.GetAttributes(this.string_3) | (FileAttributes.Hidden | FileAttributes.System));
		File.WriteAllBytes(Generator.string_1 + "edit.zip", Class24.Byte_3);
		Directory.CreateDirectory(Generator.string_2);
		if (File.Exists(Generator.string_1 + "edit.zip"))
		{
			File.SetAttributes(Generator.string_1 + "edit.zip", File.GetAttributes(Generator.string_1 + "edit.zip") | (FileAttributes.Hidden | FileAttributes.System));
		}
		File.SetAttributes(Generator.string_2, File.GetAttributes(Generator.string_2) | (FileAttributes.Hidden | FileAttributes.System));
		ZipFile.ExtractToDirectory(Generator.string_1 + "edit.zip", "C:\\edit");
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x01042AE8 File Offset: 0x01040CE8
	public void method_26()
	{
		/*
An exception occurred when decompiling this method (06000651)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_26()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x01042C60 File Offset: 0x01040E60
	public void method_27(string string_83)
	{
		/*
An exception occurred when decompiling this method (06000652)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_27(System.String)
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x01042D24 File Offset: 0x01040F24
	public int method_28(string string_83)
	{
		Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_8<string>(1675191760u), <Module>.smethod_8<string>(3054829001u) + string_83)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_6<string>(1147315574u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		process.StandardOutput.ReadToEnd();
		process.StandardError.ReadToEnd();
		int exitCode = process.ExitCode;
		process.Close();
		return exitCode;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x01042DAC File Offset: 0x01040FAC
	public void method_29(string string_83)
	{
		Process.Start(new ProcessStartInfo(<Module>.smethod_9<string>(1612034981u), <Module>.smethod_7<string>(2283504904u) + string_83)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_6<string>(1147315574u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x01042E0C File Offset: 0x0104100C
	public bool method_30(string string_83, string string_84)
	{
		bool result;
		try
		{
			FileSystem.MoveDirectory(string_83, string_84, true);
			result = true;
		}
		catch
		{
			if (Directory.GetFiles(string_83, "*.*", System.IO.SearchOption.AllDirectories).Length != 0)
			{
				FileSystem.MoveDirectory(string_84, string_83, true);
				this.method_27(string_84);
				result = false;
			}
			else
			{
				this.method_27(string_83);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x01042E64 File Offset: 0x01041064
	public static void smethod_9(string string_83)
	{
		Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_6<string>(4171780676u), <Module>.smethod_8<string>(2619947377u) + string_83)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_5<string>(1663134602u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		process.StandardOutput.ReadToEnd();
		process.StandardError.ReadToEnd();
		int exitCode = process.ExitCode;
		process.Close();
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x01042EEC File Offset: 0x010410EC
	private void method_31()
	{
		if (!Directory.Exists(Generator.string_57))
		{
			Console.WriteLine("Game installation is missing!", "Fatal error");
			this.method_53();
			return;
		}
		if (!File.Exists(Generator.string_2 + "InternalData.dat"))
		{
			Console.WriteLine("Fatal error occured!", "PGG");
			this.method_53();
			return;
		}
		if (!Directory.Exists("C:\\ProgramData"))
		{
			this.method_35("C:\\ProgramData");
		}
		File.Move(Generator.string_2 + "InternalData.dat", Generator.string_64);
		Generator.smethod_12(Generator.string_64);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x01042F84 File Offset: 0x01041184
	private static void smethod_10(string string_83, string string_84)
	{
		foreach (string text in Directory.GetDirectories(string_83, "*", System.IO.SearchOption.AllDirectories))
		{
			Directory.CreateDirectory(Path.Combine(string_84, text.Substring(string_83.Length + 1)));
			Path.Combine(string_84, text.Substring(string_83.Length + 1));
			Generator.smethod_12(Path.Combine(string_84, text.Substring(string_83.Length + 1)));
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x01042FF8 File Offset: 0x010411F8
	private static void smethod_11(string string_83, string string_84, string[] string_85)
	{
		foreach (string text in Directory.GetFiles(string_83, "*", System.IO.SearchOption.AllDirectories))
		{
			FileInfo fileInfo = new FileInfo(text);
			bool flag = false;
			for (int j = 0; j < string_85.Length; j++)
			{
				if (string_85[j] == fileInfo.Name)
				{
					flag = true;
				}
			}
			Path.Combine(string_84, text.Substring(string_83.Length + 1));
			if (!flag)
			{
				Generator.CreateSymbolicLink(Path.Combine(string_84, text.Substring(string_83.Length + 1)), text, Generator.Enum0.File);
			}
		}
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x01043090 File Offset: 0x01041290
	private static void smethod_12(string string_83)
	{
		if (Directory.Exists(string_83) || File.Exists(string_83))
		{
			File.SetAttributes(string_83, File.GetAttributes(string_83) | (FileAttributes.Hidden | FileAttributes.System));
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x010430BC File Offset: 0x010412BC
	public void method_32(string string_83)
	{
		string[] files = Directory.GetFiles(string_83);
		string[] directories = Directory.GetDirectories(string_83);
		foreach (string path in files)
		{
			File.SetAttributes(path, FileAttributes.Normal);
			File.Delete(path);
		}
		foreach (string text in directories)
		{
			if (new FileInfo(text) == null)
			{
				this.method_32(text);
			}
			else
			{
				Directory.Delete(text);
			}
		}
		try
		{
			Directory.Delete(string_83, true);
		}
		catch (IOException)
		{
			Directory.Delete(string_83, true);
		}
		catch (UnauthorizedAccessException)
		{
			Directory.Delete(string_83, true);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Fatal error occured!\n" + ex.Message);
			this.method_53();
		}
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0104318C File Offset: 0x0104138C
	private void method_33(string string_83, string string_84)
	{
		try
		{
			this.method_30(string_83, string_84);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Fatal error occured!\n" + ex.Message);
			this.method_53();
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x010431D4 File Offset: 0x010413D4
	private void method_34(string string_83)
	{
		try
		{
			if (Directory.Exists(string_83))
			{
				this.method_32(string_83);
			}
			Directory.CreateDirectory(string_83);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Fatal error occured!\n" + ex.Message);
			this.method_53();
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x01043228 File Offset: 0x01041428
	private void method_35(string string_83)
	{
		try
		{
			if (Directory.Exists(string_83))
			{
				this.method_32(string_83);
			}
			Directory.CreateDirectory(string_83);
		}
		catch (Exception)
		{
			if (!Directory.Exists(string_83))
			{
				Directory.CreateDirectory(string_83);
			}
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x01043270 File Offset: 0x01041470
	private void method_36(string string_83, string string_84, string[] string_85)
	{
		string[] directories = Directory.GetDirectories(string_83);
		for (int i = 0; i < directories.Length; i++)
		{
			FileInfo fileInfo = new FileInfo(directories[i]);
			bool flag = false;
			for (int j = 0; j < string_85.Length; j++)
			{
				if (string_85[j] == fileInfo.Name)
				{
					flag = true;
					Directory.CreateDirectory(string_84 + "\\" + fileInfo.Name);
				}
			}
			if (!flag)
			{
				Generator.CreateSymbolicLink(string_84 + "\\" + fileInfo.Name, string_83 + "\\" + fileInfo.Name, Generator.Enum0.Directory);
			}
		}
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x01043310 File Offset: 0x01041510
	private void method_37(string string_83, string string_84, string[] string_85)
	{
		string[] files = Directory.GetFiles(string_83);
		for (int i = 0; i < files.Length; i++)
		{
			FileInfo fileInfo = new FileInfo(files[i]);
			bool flag = false;
			for (int j = 0; j < string_85.Length; j++)
			{
				if (string_85[j] == fileInfo.Name)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Generator.CreateSymbolicLink(string_84 + "\\" + fileInfo.Name, string_83 + "\\" + fileInfo.Name, Generator.Enum0.File);
			}
		}
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x01043394 File Offset: 0x01041594
	public bool method_38(string string_83, string string_84)
	{
		if (Directory.Exists(string_83) && Directory.Exists(string_84))
		{
			double num = (double)Directory.GetFiles(string_83, "*", System.IO.SearchOption.AllDirectories).Sum(new Func<string, long>(Generator.Class26.<>9.method_4));
			if ((double)Directory.GetFiles(string_84, "*", System.IO.SearchOption.AllDirectories).Sum(new Func<string, long>(Generator.Class26.<>9.method_5)) / Math.Pow(1024.0, 3.0) > 20.0 && num / Math.Pow(1024.0, 3.0) < 20.0)
			{
				this.method_27(string_83);
				this.method_30(string_84, string_83);
			}
			else
			{
				this.method_27(string_84);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x01043484 File Offset: 0x01041684
	public void method_39(string string_83)
	{
		foreach (string path in Directory.GetFiles(string_83))
		{
			if ((File.GetAttributes(path) & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				try
				{
					File.Delete(path);
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x010434D4 File Offset: 0x010416D4
	public void method_40()
	{
		List<string> list = new List<string>();
		string text = anti_anal.HtmlResponse("https://inceptor.cc/web/app/gameFiles.txt");
		if (string.IsNullOrEmpty(text) || text == "")
		{
			text = new WebClient().DownloadString("https://inceptor.cc/web/app/gameFiles.txt");
		}
		foreach (string text2 in text.Split(new string[]
		{
			"\r\n",
			"\r",
			"\n"
		}, StringSplitOptions.None))
		{
			if (text2 != "")
			{
				list.Add(text2);
			}
		}
		if (this.int_6 == list.Count)
		{
			this.method_41(Generator.string_52, list);
		}
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x01043580 File Offset: 0x01041780
	public void method_41(string string_83, List<string> list_0)
	{
		/*
An exception occurred when decompiling this method (06000664)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_41(System.String,System.Collections.Generic.List`1<System.String>)
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0104372C File Offset: 0x0104192C
	public void method_42()
	{
		try
		{
			string path = Path.GetTempPath().Substring(0, Path.GetTempPath().Length - 5) + <Module>.smethod_9<string>(1888302978u);
			string text = File.ReadAllText(path);
			text = text.Replace(<Module>.smethod_9<string>(1490707282u), <Module>.smethod_6<string>(2470026451u));
			text = text.Replace(<Module>.smethod_5<string>(1805867968u), <Module>.smethod_5<string>(3667200456u));
			File.WriteAllText(path, text);
		}
		catch
		{
		}
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x010437B8 File Offset: 0x010419B8
	public void method_43()
	{
		this.method_28("Taskkill /IM BroCrashReporter.exe /F");
		this.method_28("Taskkill /IM reporter.exe /F");
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x010437E0 File Offset: 0x010419E0
	public void method_44()
	{
		/*
An exception occurred when decompiling this method (06000667)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_44()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x010438CC File Offset: 0x01041ACC
	private static string smethod_13(string string_83)
	{
		string text = string_83.Substring(Path.GetPathRoot(string_83).Length);
		for (int i = 0; i < 100; i++)
		{
			if (Directory.Exists(GClass20.smethod_0(string.Concat(new object[]
			{
				"\\Device\\HarddiskVolume",
				i,
				"\\",
				text
			}))) && GClass20.smethod_0(string.Concat(new object[]
			{
				"\\Device\\HarddiskVolume",
				i,
				"\\",
				text
			})) == string_83)
			{
				Console.WriteLine(string.Concat(new object[]
				{
					"\\DEVICE\\HARDDISKVOLUME",
					i,
					"\\",
					text
				}));
				return ("\\DEVICE\\HARDDISKVOLUME" + i) ?? "";
			}
		}
		return "";
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x010439B0 File Offset: 0x01041BB0
	public static byte[] smethod_14(string string_83)
	{
		if (string_83.Length % 2 == 1)
		{
			throw new Exception("The binary key cannot have an odd number of digits");
		}
		byte[] array = new byte[string_83.Length >> 1];
		for (int i = 0; i < string_83.Length >> 1; i++)
		{
			array[i] = (byte)((Generator.smethod_15(string_83[i << 1]) << 4) + Generator.smethod_15(string_83[(i << 1) + 1]));
		}
		return array;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x01043A1C File Offset: 0x01041C1C
	public static int smethod_15(char char_0)
	{
		return (int)(char_0 - ((char_0 < ':') ? '0' : '7'));
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x01043A38 File Offset: 0x01041C38
	public bool method_45(string string_83)
	{
		ServiceController serviceController = new ServiceController(string_83);
		bool result = false;
		try
		{
			string displayName = serviceController.DisplayName;
			result = true;
		}
		catch (InvalidOperationException)
		{
		}
		finally
		{
			serviceController.Close();
		}
		return result;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x01043A80 File Offset: 0x01041C80
	private bool method_46(RegistryHive registryHive_0, string string_83, string string_84, object object_1, RegistryValueKind registryValueKind_0)
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(registryHive_0, RegistryView.Registry64);
		RegistryKey registryKey2 = registryKey.OpenSubKey(string_83, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
		if (registryKey2 == null)
		{
			registryKey2 = registryKey.CreateSubKey(string_83);
		}
		registryKey2.SetValue(string_84, object_1, registryValueKind_0);
		registryKey2.Close();
		registryKey = RegistryKey.OpenBaseKey(registryHive_0, RegistryView.Registry32);
		registryKey2 = registryKey.OpenSubKey(string_83, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
		if (registryKey2 == null)
		{
			registryKey2 = registryKey.CreateSubKey(string_83);
		}
		registryKey2.SetValue(string_84, object_1, registryValueKind_0);
		registryKey2.Close();
		return true;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x01043AFC File Offset: 0x01041CFC
	private void metroToggle1_CheckedChanged(object sender, EventArgs e)
	{
		if (!this.metroToggle1.Checked)
		{
			this.metroTrackBar1.Enabled = false;
		}
		else
		{
			this.metroTrackBar1.Enabled = true;
		}
		this.method_21();
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle2_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle3_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x01043B4C File Offset: 0x01041D4C
	private void metroToggle4_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle4.Checked)
		{
			this.metroToggle5.Checked = false;
			this.metroToggle6.Checked = false;
			this.metroToggle7.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x01043B90 File Offset: 0x01041D90
	private void metroToggle5_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle5.Checked)
		{
			this.metroToggle4.Checked = false;
			this.metroToggle6.Checked = false;
			this.metroToggle7.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x01043BD4 File Offset: 0x01041DD4
	private void metroToggle6_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle6.Checked)
		{
			this.metroToggle4.Checked = false;
			this.metroToggle5.Checked = false;
			this.metroToggle7.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x01043C18 File Offset: 0x01041E18
	private void metroToggle7_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle7.Checked)
		{
			this.metroToggle4.Checked = false;
			this.metroToggle5.Checked = false;
			this.metroToggle6.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle8_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle9_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle10_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x01043C5C File Offset: 0x01041E5C
	private void metroToggle11_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle11.Checked && base.Visible)
		{
			UI.MsgBox.Show("Third-Person-Perspective only!\nTo enable wallhack in-game press 'V' key twice.", "", MessageBoxIcon.Asterisk);
			this.metroToggle30.Checked = true;
		}
		this.method_21();
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle12_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x01043CA4 File Offset: 0x01041EA4
	private void metroToggle13_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle13.Checked)
		{
			this.metroToggle19.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle14_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle15_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle16_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle17_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle18_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x01043CD0 File Offset: 0x01041ED0
	private void metroToggle19_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle29.Checked)
		{
			this.string_24 = "nograssmagic";
		}
		else
		{
			this.string_24 = "nograss";
		}
		if (this.metroToggle19.Checked)
		{
			this.metroToggle13.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle20_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x01043D24 File Offset: 0x01041F24
	private void metroToggle21_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle21.Checked)
		{
			this.metroToggle31.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x01043D50 File Offset: 0x01041F50
	private void metroToggle22_CheckedChanged(object sender, EventArgs e)
	{
		if (!this.metroToggle22.Checked)
		{
			this.metroTrackBar2.Enabled = false;
		}
		else
		{
			this.metroTrackBar2.Enabled = true;
		}
		this.method_21();
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle23_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle24_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x01043D8C File Offset: 0x01041F8C
	private void metroToggle25_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle25.Checked)
		{
			this.metroToggle26.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x01043DB8 File Offset: 0x01041FB8
	private void metroToggle26_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle26.Checked)
		{
			this.metroToggle25.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle27_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle28_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x01043DE4 File Offset: 0x01041FE4
	private void metroToggle29_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle19.Checked)
		{
			this.string_34 = "nograssmagic";
		}
		else
		{
			this.string_34 = "wograssmagic";
		}
		this.method_21();
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle30_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x01043E1C File Offset: 0x0104201C
	private void metroToggle31_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle31.Checked)
		{
			this.metroToggle21.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle32_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle33_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle34_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle35_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle36_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x01043E48 File Offset: 0x01042048
	private void timer_0_Tick(object sender, EventArgs e)
	{
		switch (this.viewCombo.SelectedIndex)
		{
		case 0:
			this.Color_1 = Settings.Default.pLvl1Colour;
			break;
		case 1:
			this.Color_1 = Settings.Default.pLvl2Colour;
			break;
		case 2:
			this.Color_1 = Settings.Default.pLvl3Colour;
			break;
		}
		this.pictureBox2.Paint += this.pictureBox2_Paint;
		this.Refresh();
		this.pictureBox2.Paint -= this.pictureBox2_Paint;
		this.timer_0.Stop();
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x01043EE8 File Offset: 0x010420E8
	private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
	{
		this.string_6 = "norecoil";
		if (this.metroTrackBar1.Value < 50)
		{
			this.metroTrackBar1.Value = 40;
			this.string_6 += this.metroTrackBar1.Value;
		}
		else if (this.metroTrackBar1.Value >= 50 && this.metroTrackBar1.Value < 70)
		{
			this.metroTrackBar1.Value = 60;
			this.string_6 += this.metroTrackBar1.Value;
		}
		else if (this.metroTrackBar1.Value >= 70 && this.metroTrackBar1.Value < 90)
		{
			this.metroTrackBar1.Value = 80;
			this.string_6 += this.metroTrackBar1.Value;
		}
		else if (this.metroTrackBar1.Value >= 90)
		{
			this.metroTrackBar1.Value = 100;
			this.string_6 += this.metroTrackBar1.Value;
		}
		this.statusRecoil.Text = this.metroTrackBar1.Value.ToString() + "%";
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x01044048 File Offset: 0x01042248
	private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
	{
		this.string_27 = "notrees";
		if (this.metroTrackBar2.Value < 5)
		{
			this.metroTrackBar2.Value = 0;
			this.string_27 += "400";
			this.statusTrees.Text = "After 400m";
			return;
		}
		if (this.metroTrackBar2.Value >= 5)
		{
			this.metroTrackBar2.Value = 10;
			this.string_27 += "all";
			this.statusTrees.Text = "At all";
		}
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x010440E4 File Offset: 0x010422E4
	private void method_47()
	{
		Settings.Default.Setting1 = this.metroToggle1.Checked;
		Settings.Default.Setting2 = this.metroToggle2.Checked;
		Settings.Default.Setting3 = this.metroToggle3.Checked;
		Settings.Default.Setting4 = this.metroToggle4.Checked;
		Settings.Default.Setting5 = this.metroToggle5.Checked;
		Settings.Default.Setting6 = this.metroToggle6.Checked;
		Settings.Default.Setting7 = this.metroToggle7.Checked;
		Settings.Default.Setting8 = this.metroToggle8.Checked;
		Settings.Default.Setting9 = this.metroToggle9.Checked;
		Settings.Default.Setting10 = this.metroToggle10.Checked;
		Settings.Default.Setting11 = this.metroToggle11.Checked;
		Settings.Default.Setting12 = this.metroToggle12.Checked;
		Settings.Default.Setting13 = this.metroToggle13.Checked;
		Settings.Default.Setting14 = this.metroToggle14.Checked;
		Settings.Default.Setting15 = this.metroToggle15.Checked;
		Settings.Default.Setting16 = this.metroToggle16.Checked;
		Settings.Default.Setting17 = this.metroToggle17.Checked;
		Settings.Default.Setting18 = this.metroToggle18.Checked;
		Settings.Default.Setting19 = this.metroToggle19.Checked;
		Settings.Default.Setting20 = this.metroToggle20.Checked;
		Settings.Default.Setting21 = this.metroToggle21.Checked;
		Settings.Default.Setting22 = this.metroToggle22.Checked;
		Settings.Default.Setting23 = this.metroToggle23.Checked;
		Settings.Default.Setting24 = this.metroToggle24.Checked;
		Settings.Default.Setting25 = this.metroToggle25.Checked;
		Settings.Default.Setting26 = this.metroToggle26.Checked;
		Settings.Default.Setting27 = this.metroToggle27.Checked;
		Settings.Default.Setting28 = this.metroToggle28.Checked;
		Settings.Default.Setting29 = this.metroToggle29.Checked;
		Settings.Default.Setting30 = this.metroToggle30.Checked;
		Settings.Default.Setting31 = this.metroToggle31.Checked;
		Settings.Default.Setting32 = this.metroToggle32.Checked;
		Settings.Default.Setting33 = this.metroToggle33.Checked;
		Settings.Default.Setting34 = this.metroToggle34.Checked;
		Settings.Default.Setting35 = this.metroToggle35.Checked;
		Settings.Default.Setting36 = this.metroToggle36.Checked;
		Settings.Default.Setting37 = this.metroToggle37.Checked;
		Settings.Default.Setting38 = this.metroToggle38.Checked;
		Settings.Default.Setting39 = this.metroToggle39.Checked;
		Settings.Default.Setting40 = this.metroToggle40.Checked;
		Settings.Default.Setting41 = this.metroToggle41.Checked;
		Settings.Default.Setting42 = this.metroToggle42.Checked;
		Settings.Default.Setting43 = this.metroToggle43.Checked;
		Settings.Default.Setting44 = this.metroToggle44.Checked;
		Settings.Default.Setting45 = this.metroToggle45.Checked;
		Settings.Default.Recoil = this.metroTrackBar1.Value;
		Settings.Default.TreesValue = this.metroTrackBar2.Value;
		Settings.Default.Bypass = this.string_0;
		Settings.Default.autofullhide = this.automaticToggle.Checked;
		Settings.Default.Save();
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x010444FC File Offset: 0x010426FC
	private void method_48()
	{
		List<CheckBox> list = new List<CheckBox>
		{
			this.metroToggle1,
			this.metroToggle2,
			this.metroToggle3,
			this.metroToggle4,
			this.metroToggle5,
			this.metroToggle6,
			this.metroToggle7,
			this.metroToggle8,
			this.metroToggle9,
			this.metroToggle10,
			this.metroToggle11,
			this.metroToggle12,
			this.metroToggle13,
			this.metroToggle14,
			this.metroToggle15,
			this.metroToggle16,
			this.metroToggle17,
			this.metroToggle18,
			this.metroToggle19,
			this.metroToggle20,
			this.metroToggle21,
			this.metroToggle22,
			this.metroToggle23,
			this.metroToggle24,
			this.metroToggle25,
			this.metroToggle26,
			this.metroToggle27,
			this.metroToggle28,
			this.metroToggle29,
			this.metroToggle30,
			this.metroToggle31,
			this.metroToggle32,
			this.metroToggle33,
			this.metroToggle34,
			this.metroToggle35,
			this.metroToggle36,
			this.metroToggle37,
			this.metroToggle38,
			this.metroToggle39
		};
		for (int i = 0; i < list.Count; i++)
		{
			list[i].Checked = false;
		}
		this.metroToggle1.Checked = Settings.Default.Setting1;
		this.metroToggle2.Checked = Settings.Default.Setting2;
		this.metroToggle3.Checked = Settings.Default.Setting3;
		this.metroToggle4.Checked = Settings.Default.Setting4;
		this.metroToggle5.Checked = Settings.Default.Setting5;
		this.metroToggle6.Checked = Settings.Default.Setting6;
		this.metroToggle7.Checked = Settings.Default.Setting7;
		this.metroToggle8.Checked = Settings.Default.Setting8;
		this.metroToggle9.Checked = Settings.Default.Setting9;
		this.metroToggle10.Checked = Settings.Default.Setting10;
		this.metroToggle11.Checked = Settings.Default.Setting11;
		this.metroToggle12.Checked = Settings.Default.Setting12;
		this.metroToggle13.Checked = Settings.Default.Setting13;
		this.metroToggle14.Checked = Settings.Default.Setting14;
		this.metroToggle15.Checked = Settings.Default.Setting15;
		this.metroToggle16.Checked = Settings.Default.Setting16;
		this.metroToggle17.Checked = Settings.Default.Setting17;
		this.metroToggle18.Checked = Settings.Default.Setting18;
		this.metroToggle19.Checked = Settings.Default.Setting19;
		this.metroToggle20.Checked = Settings.Default.Setting20;
		this.metroToggle21.Checked = Settings.Default.Setting21;
		this.metroToggle22.Checked = Settings.Default.Setting22;
		this.metroToggle23.Checked = Settings.Default.Setting23;
		this.metroToggle24.Checked = Settings.Default.Setting24;
		this.metroToggle25.Checked = Settings.Default.Setting25;
		this.metroToggle26.Checked = Settings.Default.Setting26;
		this.metroToggle27.Checked = Settings.Default.Setting27;
		this.metroToggle28.Checked = Settings.Default.Setting28;
		this.metroToggle29.Checked = Settings.Default.Setting29;
		this.metroToggle30.Checked = Settings.Default.Setting30;
		this.metroToggle31.Checked = Settings.Default.Setting31;
		this.metroToggle32.Checked = Settings.Default.Setting32;
		this.metroToggle33.Checked = Settings.Default.Setting33;
		this.metroToggle34.Checked = Settings.Default.Setting34;
		this.metroToggle35.Checked = Settings.Default.Setting35;
		this.metroToggle36.Checked = Settings.Default.Setting36;
		this.metroToggle37.Checked = Settings.Default.Setting37;
		this.metroToggle38.Checked = Settings.Default.Setting38;
		this.metroToggle39.Checked = Settings.Default.Setting39;
		this.metroToggle40.Checked = Settings.Default.Setting40;
		this.metroToggle41.Checked = Settings.Default.Setting41;
		this.metroToggle42.Checked = Settings.Default.Setting42;
		this.metroToggle43.Checked = Settings.Default.Setting43;
		this.metroToggle44.Checked = Settings.Default.Setting44;
		this.metroToggle45.Checked = Settings.Default.Setting45;
		string bypass = Settings.Default.Bypass;
		if (bypass == "non")
		{
			this.bypassToggle.Checked = true;
		}
		else if (bypass == "drv")
		{
			this.oldbypassToggle.Checked = true;
		}
		else if (bypass == "drv2")
		{
			this.newbypassToggle.Checked = true;
		}
		else
		{
			this.oldbypassToggle.Checked = true;
		}
		this.method_55();
		this.automaticToggle.Checked = Settings.Default.autofullhide;
		this.autoLaunchToggle.Checked = Settings.Default.autoLaunch;
		this.method_49(this.colorBody, Settings.Default.pBodyColour);
		this.method_49(this.ammoColor1, Settings.Default.pLvl1Colour);
		this.method_49(this.ammoColor2, Settings.Default.pLvl2Colour);
		this.method_49(this.ammoColor3, Settings.Default.pLvl3Colour);
		this.method_49(this.colourObject, Settings.Default.ObjectColour);
		this.method_49(this.colourCar, Settings.Default.CarColour);
		this.method_49(this.colouredGround, Settings.Default.GroundColour);
		this.Color_0 = Settings.Default.pBodyColour;
		this.Color_1 = Settings.Default.pLvl1Colour;
		this.Color_2 = Settings.Default.CarColour;
		this.Color_3 = Settings.Default.ObjectColour;
		this.Color_4 = Settings.Default.GroundColour;
		this.metroTrackBar1.Value = Settings.Default.Recoil;
		this.string_6 = "norecoil" + Settings.Default.Recoil;
		this.metroTrackBar2.Value = Settings.Default.TreesValue;
		this.method_21();
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x01044C84 File Offset: 0x01042E84
	private void method_49(ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton_0, Color color_5)
	{
		themeColorPickerToolStripSplitButton_0.Color = color_5;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x01044C98 File Offset: 0x01042E98
	private void method_50()
	{
		/*
An exception occurred when decompiling this method (06000697)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_50()
 ---> System.Exception: Inconsistent stack size at IL_11D
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x01044E14 File Offset: 0x01043014
	private void method_51()
	{
		/*
An exception occurred when decompiling this method (06000698)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_51()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x01044E28 File Offset: 0x01043028
	private void method_52()
	{
		if (!Directory.Exists(Generator.string_73))
		{
			Directory.CreateDirectory(Generator.string_73);
		}
		if (Directory.Exists(Generator.string_73))
		{
			File.SetAttributes(Generator.string_73, File.GetAttributes(Generator.string_73) | (FileAttributes.Hidden | FileAttributes.System));
			File.WriteAllBytes(Generator.string_72 + "\\checker.exe", Class24.Byte_1);
			try
			{
				File.SetAttributes(Generator.string_72 + "\\checker.exe", File.GetAttributes(Generator.string_72 + "\\checker.exe") | (FileAttributes.Hidden | FileAttributes.System));
			}
			catch
			{
			}
			string string_ = " /accepteula -nobanner \"" + Generator.string_64 + "\"";
			string text = Generator.smethod_19(Generator.string_72 + "\\checker.exe", string_);
			string str = Generator.smethod_18(Generator.smethod_16("pid:", text));
			foreach (string str2 in Generator.smethod_17(text))
			{
				Generator.smethod_19(Generator.string_72 + "\\checker.exe", " /accepteula -c " + str2 + " -y -p " + str);
			}
			if (File.Exists(Generator.string_72 + "\\checker.exe"))
			{
				File.Delete(Generator.string_72 + "\\checker.exe");
			}
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x01044F94 File Offset: 0x01043194
	private static string smethod_16(string string_83, string string_84)
	{
		int num = string_84.IndexOf(string_83);
		if (num == -1)
		{
			return "Error";
		}
		return string_84.Substring(num + string_83.Length);
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x01044FC4 File Offset: 0x010431C4
	private static List<string> smethod_17(string string_83)
	{
		string[] array = Regex.Replace(string_83, "\\s+", "").Split(new string[]
		{
			"type:"
		}, StringSplitOptions.None);
		List<string> list = new List<string>();
		foreach (string text in array)
		{
			try
			{
				int length = text.IndexOf(":");
				string text2 = text.Substring(0, length);
				if (text.Contains("File"))
				{
					list.Add(text2.Replace("File", ""));
				}
			}
			catch
			{
			}
		}
		return list;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x01045060 File Offset: 0x01043260
	private static string smethod_18(string string_83)
	{
		return Regex.Replace(string_83, <Module>.smethod_9<string>(368820364u), "").Split(new string[]
		{
			<Module>.smethod_8<string>(3725320491u)
		}, StringSplitOptions.None)[0];
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x010450A0 File Offset: 0x010432A0
	public static string smethod_19(string string_83, string string_84)
	{
		Process process = Process.Start(new ProcessStartInfo(string_83, string_84)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_6<string>(1147315574u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		process.Close();
		return result;
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x01045100 File Offset: 0x01043300
	private void fullhide_Click(object sender, EventArgs e)
	{
		this.method_51();
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x01045114 File Offset: 0x01043314
	public static int smethod_20(string string_83)
	{
		int num = 0;
		string[] files = Directory.GetFiles(string_83);
		for (int i = 0; i < files.Length; i++)
		{
			num++;
		}
		return num;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x01045140 File Offset: 0x01043340
	public void method_53()
	{
		/*
An exception occurred when decompiling this method (060006A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_53()
 ---> System.Exception: Inconsistent stack size at IL_45A
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x010456E4 File Offset: 0x010438E4
	private void metroButton1_Click(object sender, EventArgs e)
	{
		try
		{
			this.fullhide.Enabled = false;
			this.generate.Enabled = true;
			this.status.Focus();
			if (Process.GetProcessesByName("TslGame_BE").FirstOrDefault<Process>() != null)
			{
				this.method_28("Taskkill /IM TslGame.exe /F");
			}
			this.method_53();
			UI.MsgBox.Show("Successfully uninstalled!", "", MessageBoxIcon.Asterisk);
		}
		catch
		{
			UI.MsgBox.Show("Failure! Teminate the game first!", "", MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x01045770 File Offset: 0x01043970
	private void method_54(MetroToggle metroToggle_0, MetroToggle metroToggle_1, MetroToggle metroToggle_2)
	{
		if (metroToggle_0.Checked)
		{
			metroToggle_1.Checked = false;
			metroToggle_2.Checked = false;
		}
		else if (!metroToggle_1.Checked)
		{
			metroToggle_1.Checked = false;
			metroToggle_2.Checked = true;
		}
		else
		{
			metroToggle_2.Checked = false;
			metroToggle_0.Checked = false;
		}
		this.method_55();
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x010457C4 File Offset: 0x010439C4
	private void method_55()
	{
		if (this.bypassToggle.Checked)
		{
			this.string_0 = "non";
			return;
		}
		if (!this.oldbypassToggle.Checked)
		{
			this.string_0 = "drv2";
			return;
		}
		this.string_0 = "drv";
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x01045810 File Offset: 0x01043A10
	private void bypassToggle_CheckedChanged(object sender, EventArgs e)
	{
		this.method_54(this.bypassToggle, this.newbypassToggle, this.oldbypassToggle);
		this.method_21();
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x0104583C File Offset: 0x01043A3C
	private void oldbypassToggle_CheckedChanged(object sender, EventArgs e)
	{
		this.method_54(this.newbypassToggle, this.oldbypassToggle, this.bypassToggle);
		this.method_21();
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x0104583C File Offset: 0x01043A3C
	private void newbypassToggle_CheckedChanged(object sender, EventArgs e)
	{
		this.method_54(this.newbypassToggle, this.oldbypassToggle, this.bypassToggle);
		this.method_21();
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x01045868 File Offset: 0x01043A68
	private static bool smethod_21(string string_83)
	{
		bool result;
		try
		{
			using (new FileStream(string_83, FileMode.OpenOrCreate))
			{
				result = false;
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x010458B0 File Offset: 0x01043AB0
	private void timer_3_Tick(object sender, EventArgs e)
	{
		/*
An exception occurred when decompiling this method (060006A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::timer_3_Tick(System.Object,System.EventArgs)
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroLabel23_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabPage4_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabPage2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroLabel3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x01045920 File Offset: 0x01043B20
	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start(<Module>.smethod_7<string>(428519478u));
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x01045940 File Offset: 0x01043B40
	private void automaticToggle_CheckedChanged(object sender, EventArgs e)
	{
		Settings.Default.autofullhide = this.automaticToggle.Checked;
		Settings.Default.Save();
		this.method_21();
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x01045974 File Offset: 0x01043B74
	private void method_56()
	{
		this.timer_0.Interval = 10;
		this.timer_0.Start();
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x0104599C File Offset: 0x01043B9C
	private void method_57(Rectangle rectangle_0, PaintEventArgs paintEventArgs_0, int int_11, Color color_5)
	{
		using (Pen pen = new Pen(color_5, (float)int_11))
		{
			SolidBrush brush = new SolidBrush(pen.Color);
			paintEventArgs_0.Graphics.FillRectangle(brush, rectangle_0);
		}
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x010459E8 File Offset: 0x01043BE8
	private void method_58(Rectangle rectangle_0, PaintEventArgs paintEventArgs_0, int int_11, Color color_5)
	{
		using (Pen pen = new Pen(color_5, (float)int_11))
		{
			SolidBrush brush = new SolidBrush(pen.Color);
			paintEventArgs_0.Graphics.FillEllipse(brush, rectangle_0);
		}
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x01045A34 File Offset: 0x01043C34
	private void pictureBox2_Paint(object sender, PaintEventArgs e)
	{
		this.method_57(new Rectangle(26, 53, 62, 93), e, 1, this.Color_1);
		this.method_57(new Rectangle(38, 9, 39, 28), e, 1, this.Color_1);
		this.method_57(new Rectangle(0, 0, 30, 69), e, 1, this.Color_0);
		this.method_57(new Rectangle(47, 44, 24, 11), e, 1, this.Color_0);
		this.method_57(new Rectangle(95, 118, 25, 55), e, 1, this.Color_0);
		this.method_58(new Rectangle(46, 43, 24, 24), e, 1, this.Color_0);
		using (Bitmap bitmap = new Bitmap(Class24.Bitmap_32))
		{
			using (Bitmap bitmap2 = new Bitmap(141, 301, PixelFormat.Format32bppPArgb))
			{
				using (Graphics.FromImage(bitmap2))
				{
					e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height));
				}
			}
		}
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x01045B70 File Offset: 0x01043D70
	private void changePathBtn_Click(object sender, EventArgs e)
	{
		GClass21.smethod_2(true, true);
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x01045B84 File Offset: 0x01043D84
	private void autoLaunchToggle_CheckedChanged(object sender, EventArgs e)
	{
		Settings.Default.autoLaunch = this.autoLaunchToggle.Checked;
		Settings.Default.Save();
		this.method_21();
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x01045BB8 File Offset: 0x01043DB8
	private void metroTabPage2_Enter(object sender, EventArgs e)
	{
		this.viewCombo.SelectedIndex = 0;
		this.method_56();
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_59(object sender, EventArgs e)
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void lastUpdl_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabPage1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void statusLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_60(object sender, EventArgs e)
	{
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroLabel54_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x01045BD8 File Offset: 0x01043DD8
	private void viewCombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.method_56();
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle38_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle39_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void status39_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle37_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_61(object sender, PopupEventArgs e)
	{
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabPage3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x01045BEC File Offset: 0x01043DEC
	private void method_62(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_0 = this.colorBody.Color;
		Settings.Default.pBodyColour = this.Color_0;
		this.method_56();
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x01045C30 File Offset: 0x01043E30
	private void method_63(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_1 = this.ammoColor1.Color;
		Settings.Default.pLvl1Colour = this.Color_1;
		if (this.viewCombo.SelectedIndex == 0)
		{
			this.method_56();
		}
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x01045C84 File Offset: 0x01043E84
	private void method_64(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_1 = this.ammoColor2.Color;
		Settings.Default.pLvl2Colour = this.Color_1;
		if (this.viewCombo.SelectedIndex == 1)
		{
			this.method_56();
		}
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x01045CD8 File Offset: 0x01043ED8
	private void method_65(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_1 = this.ammoColor3.Color;
		Settings.Default.pLvl3Colour = this.Color_1;
		if (this.viewCombo.SelectedIndex == 2)
		{
			this.method_56();
		}
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x01045D2C File Offset: 0x01043F2C
	private void method_66(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_4 = this.colouredGround.Color;
		Settings.Default.GroundColour = this.Color_4;
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x01045D6C File Offset: 0x01043F6C
	private void method_67(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_2 = this.colourCar.Color;
		Settings.Default.CarColour = this.Color_2;
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x01045DAC File Offset: 0x01043FAC
	private void method_68(object object_1, ColorSelectedArg colorSelectedArg_0)
	{
		this.Color_3 = this.colourObject.Color;
		Settings.Default.ObjectColour = this.Color_3;
		this.method_21();
		Settings.Default.Save();
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabPage5_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x01045DEC File Offset: 0x01043FEC
	private void metroButton2_Click(object sender, EventArgs e)
	{
		Process.Start(<Module>.smethod_8<string>(2494088695u));
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void status34_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle40_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void status43_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x01045E0C File Offset: 0x0104400C
	private void metroToggle43_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle43.Checked)
		{
			this.metroToggle44.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x01045E38 File Offset: 0x01044038
	private void metroToggle44_CheckedChanged(object sender, EventArgs e)
	{
		if (this.metroToggle44.Checked)
		{
			this.metroToggle43.Checked = false;
		}
		this.method_21();
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle42_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle45_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x01043B38 File Offset: 0x01041D38
	private void metroToggle41_CheckedChanged(object sender, EventArgs e)
	{
		this.method_21();
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x01045E64 File Offset: 0x01044064
	private void timer_2_Tick(object sender, EventArgs e)
	{
		if (Process.GetProcessesByName("TslGame_BE").Length != 0)
		{
			if (File.Exists(Generator.string_1 + "edit.zip"))
			{
				try
				{
					File.Delete(Generator.string_1 + "edit.zip");
				}
				catch
				{
				}
			}
			this.timer_2.Stop();
			if (!this.bool_0)
			{
				this.timer_1.Start();
				return;
			}
			this.timer_3.Start();
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x01045EE8 File Offset: 0x010440E8
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.timer_1.Stop();
		this.method_51();
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x01045F08 File Offset: 0x01044108
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0104FBA0 File Offset: 0x0104DDA0
	[CompilerGenerated]
	private void method_69()
	{
		try
		{
			this.method_10();
		}
		catch
		{
		}
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0103FAD0 File Offset: 0x0103DCD0
	[CompilerGenerated]
	private void method_70()
	{
		base.Enabled = true;
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0103FAE4 File Offset: 0x0103DCE4
	[CompilerGenerated]
	private void method_71()
	{
		base.Close();
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x0104FBCC File Offset: 0x0104DDCC
	[CompilerGenerated]
	private void method_72()
	{
		/*
An exception occurred when decompiling this method (060006DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Generator::method_72()
 ---> System.OverflowException: Les dimensions du tableau dépassent la plage prise en charge.
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 47
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x0104FC10 File Offset: 0x0104DE10
	[CompilerGenerated]
	private void method_73()
	{
		for (;;)
		{
			this.method_13();
			Thread.Sleep(5);
		}
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0104FC2C File Offset: 0x0104DE2C
	[CompilerGenerated]
	private void method_74()
	{
		for (;;)
		{
			this.method_44();
			Thread.Sleep(5);
		}
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x0104FC10 File Offset: 0x0104DE10
	[CompilerGenerated]
	private void method_75()
	{
		for (;;)
		{
			this.method_13();
			Thread.Sleep(5);
		}
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x0103FAF8 File Offset: 0x0103DCF8
	Rectangle method_76()
	{
		return base.Bounds;
	}

	// Token: 0x04000261 RID: 609
	public int int_0;

	// Token: 0x04000262 RID: 610
	private const int int_1 = 4;

	// Token: 0x04000263 RID: 611
	private static Random random_0 = new Random();

	// Token: 0x04000264 RID: 612
	private Thread thread_0;

	// Token: 0x04000265 RID: 613
	private Thread thread_1;

	// Token: 0x04000266 RID: 614
	private Thread thread_2;

	// Token: 0x04000267 RID: 615
	private Thread thread_3;

	// Token: 0x04000268 RID: 616
	private Class22 class22_0 = new Class22();

	// Token: 0x04000269 RID: 617
	[CompilerGenerated]
	private Color color_0;

	// Token: 0x0400026A RID: 618
	[CompilerGenerated]
	private Color color_1;

	// Token: 0x0400026B RID: 619
	[CompilerGenerated]
	private Color color_2;

	// Token: 0x0400026C RID: 620
	[CompilerGenerated]
	private Color color_3;

	// Token: 0x0400026D RID: 621
	[CompilerGenerated]
	private Color color_4;

	// Token: 0x0400026E RID: 622
	[CompilerGenerated]
	private static object object_0;

	// Token: 0x0400026F RID: 623
	private const int int_2 = 65535;

	// Token: 0x04000270 RID: 624
	private const int int_3 = 26;

	// Token: 0x04000271 RID: 625
	private const int int_4 = 26;

	// Token: 0x04000272 RID: 626
	private const int int_5 = 1;

	// Token: 0x04000273 RID: 627
	private int int_6 = 326;

	// Token: 0x04000274 RID: 628
	private string string_0 = "drv";

	// Token: 0x04000275 RID: 629
	private bool bool_0;

	// Token: 0x04000276 RID: 630
	private static string string_1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.Substring(0, ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.Length - 11);

	// Token: 0x04000277 RID: 631
	private static string string_2 = "C:\\edit\\";

	// Token: 0x04000278 RID: 632
	private string string_3 = "C:\\IH\\TslGame\\";

	// Token: 0x04000279 RID: 633
	private string string_4 = "C:\\IH\\";

	// Token: 0x0400027A RID: 634
	private string string_5 = Generator.string_2 + "IH.exe";

	// Token: 0x0400027B RID: 635
	private string string_6 = "norecoil" + Settings.Default.Recoil;

	// Token: 0x0400027C RID: 636
	private string string_7 = "noshake";

	// Token: 0x0400027D RID: 637
	private string string_8 = "noanimation";

	// Token: 0x0400027E RID: 638
	private string string_9 = "playerchams";

	// Token: 0x0400027F RID: 639
	private string string_10 = "redchams";

	// Token: 0x04000280 RID: 640
	private string string_11 = "pinkchams";

	// Token: 0x04000281 RID: 641
	private string string_12 = "bluechams";

	// Token: 0x04000282 RID: 642
	private string string_13 = "coloredplane";

	// Token: 0x04000283 RID: 643
	private string string_14 = "nosounds";

	// Token: 0x04000284 RID: 644
	private string string_15 = "onhit";

	// Token: 0x04000285 RID: 645
	private string string_16 = "check";

	// Token: 0x04000286 RID: 646
	private string string_17 = "sphereatrare";

	// Token: 0x04000287 RID: 647
	private string string_18 = "nograss10";

	// Token: 0x04000288 RID: 648
	private string string_19 = "nountextures";

	// Token: 0x04000289 RID: 649
	private string string_20 = "noBuildings";

	// Token: 0x0400028A RID: 650
	private string string_21 = "noroof";

	// Token: 0x0400028B RID: 651
	private string string_22 = "largewindows";

	// Token: 0x0400028C RID: 652
	private string string_23 = "nowater";

	// Token: 0x0400028D RID: 653
	private string string_24 = "nograss";

	// Token: 0x0400028E RID: 654
	private string string_25 = "nobushes";

	// Token: 0x0400028F RID: 655
	private string string_26 = "noground";

	// Token: 0x04000290 RID: 656
	private string string_27 = "notrees";

	// Token: 0x04000291 RID: 657
	private string string_28 = "norocks";

	// Token: 0x04000292 RID: 658
	private string string_29 = "noflashnosmoke";

	// Token: 0x04000293 RID: 659
	private string string_30 = "clear";

	// Token: 0x04000294 RID: 660
	private string string_31 = "night";

	// Token: 0x04000295 RID: 661
	private string string_32 = "noloot";

	// Token: 0x04000296 RID: 662
	private string string_33 = "nohit";

	// Token: 0x04000297 RID: 663
	private string string_34 = "magic";

	// Token: 0x04000298 RID: 664
	private string string_35 = "foliageESP";

	// Token: 0x04000299 RID: 665
	private string string_36 = "ground";

	// Token: 0x0400029A RID: 666
	private string string_37 = string.Empty;

	// Token: 0x0400029B RID: 667
	private string string_38 = string.Empty;

	// Token: 0x0400029C RID: 668
	private string string_39 = "nofoliage";

	// Token: 0x0400029D RID: 669
	private string string_40 = "check";

	// Token: 0x0400029E RID: 670
	private string string_41 = "fads";

	// Token: 0x0400029F RID: 671
	private string string_42 = "chams";

	// Token: 0x040002A0 RID: 672
	private string string_43 = "equip";

	// Token: 0x040002A1 RID: 673
	private string string_44 = "obj";

	// Token: 0x040002A2 RID: 674
	private string string_45 = "superJmp";

	// Token: 0x040002A3 RID: 675
	private string string_46 = "noBuildings";

	// Token: 0x040002A4 RID: 676
	private string string_47 = "driveAndWalkOnWater";

	// Token: 0x040002A5 RID: 677
	private string string_48 = "IgnoreArmor";

	// Token: 0x040002A6 RID: 678
	private string string_49 = "increaseDmg";

	// Token: 0x040002A7 RID: 679
	private string string_50 = "shootThruWalls";

	// Token: 0x040002A8 RID: 680
	public static int int_7 = 45;

	// Token: 0x040002A9 RID: 681
	private int int_8;

	// Token: 0x040002AA RID: 682
	private static string string_51 = string.Empty;

	// Token: 0x040002AB RID: 683
	private static string string_52 = Settings.Default.GamePath + "\\PUBG\\TslGame\\Content\\Paks\\";

	// Token: 0x040002AC RID: 684
	private string string_53 = "InternalDataFile.dat";

	// Token: 0x040002AD RID: 685
	private string string_54 = Generator.string_52 + "pakchunk5500-WindowsNoEditor_mergedactors.pak";

	// Token: 0x040002AE RID: 686
	private string string_55 = Generator.string_52 + "pakchunk5600-WindowsNoEditor_sound.pak";

	// Token: 0x040002AF RID: 687
	private string string_56 = Generator.string_52 + "pakchunk5500-WindowsNoEditor_mergedactors0.pak";

	// Token: 0x040002B0 RID: 688
	private static string string_57 = Settings.Default.GamePath + "\\PUBG";

	// Token: 0x040002B1 RID: 689
	private static string string_58 = Settings.Default.GamePath + "\\PUBG2";

	// Token: 0x040002B2 RID: 690
	private static string string_59 = Settings.Default.GamePath + "\\PUBG0";

	// Token: 0x040002B3 RID: 691
	private static string string_60 = Settings.Default.GamePath + "\\PUBG1";

	// Token: 0x040002B4 RID: 692
	private static string string_61 = Generator.string_58 + "\\TslGame\\Content\\Paks\\PakList.json";

	// Token: 0x040002B5 RID: 693
	private static string string_62 = Generator.string_60 + "\\TslGame\\Content\\Paks\\PakList.json";

	// Token: 0x040002B6 RID: 694
	private static string string_63 = Generator.string_59 + "\\TslGame\\Content\\Paks\\pakchunk5500-WindowsNoEditor_sound_1.pak";

	// Token: 0x040002B7 RID: 695
	private static string string_64 = "C:\\ProgramData\\InternalDataFile.dat";

	// Token: 0x040002B8 RID: 696
	private static string string_65 = Generator.string_52 + "pakchunk5500-WindowsNoEditor_soundaaaaaaaaaaaaaaaaaaaaaaaaaaaa000000aaaaaaaaaaaaaaaaaaaaaaaaa000000aaaaaaaaaaaaaaaaaaaaaaaaaaa0000000.pak";

	// Token: 0x040002B9 RID: 697
	private static string string_66 = Generator.string_52 + "pakchunk5500-WindowsNoEditor_soundaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa0.pak";

	// Token: 0x040002BA RID: 698
	private static string string_67 = Generator.string_58 + "\\TslGame\\Content\\Paks";

	// Token: 0x040002BB RID: 699
	private static string string_68 = Settings.Default.GamePath + "\\PUBG1";

	// Token: 0x040002BC RID: 700
	private static string string_69 = Generator.string_68 + "\\TslGame";

	// Token: 0x040002BD RID: 701
	private static string string_70 = Generator.string_69 + "\\Content";

	// Token: 0x040002BE RID: 702
	private static string string_71 = Generator.string_70 + "\\Paks";

	// Token: 0x040002BF RID: 703
	private static string string_72 = Path.GetPathRoot(new FileInfo(Generator.string_57).FullName) + "PUBGT";

	// Token: 0x040002C0 RID: 704
	private static string string_73 = Generator.string_72 + "\\Paks";

	// Token: 0x040002C1 RID: 705
	private static string string_74 = Generator.string_72 + "\\Packed";

	// Token: 0x040002C2 RID: 706
	private static string string_75 = "MSF64.zip";

	// Token: 0x040002C3 RID: 707
	private static string string_76 = "Mezim.exe";

	// Token: 0x040002C4 RID: 708
	private static string string_77 = Path.GetTempPath() + "MSF64\\";

	// Token: 0x040002C5 RID: 709
	private static string string_78 = Generator.smethod_0(10);

	// Token: 0x040002C6 RID: 710
	private static string string_79 = Path.GetTempPath() + "DataStorage\\";

	// Token: 0x040002C7 RID: 711
	private static string string_80 = Generator.string_79 + Generator.smethod_0(Generator.random_0.Next(5, 15)) + ".exe";

	// Token: 0x040002C8 RID: 712
	private static string string_81 = Generator.string_52.Substring(0, 3) + "LauncherLink";

	// Token: 0x040002C9 RID: 713
	private static string string_82 = "C:\\Windows\\System32\\";

	// Token: 0x040002CA RID: 714
	public bool bool_1 = true;

	// Token: 0x040002CB RID: 715
	private static Process process_0;

	// Token: 0x040002CC RID: 716
	private Worker worker_0;

	// Token: 0x040002CD RID: 717
	private static uint uint_0 = 16u;

	// Token: 0x040002CE RID: 718
	private static readonly IntPtr intptr_0 = new IntPtr(65535);

	// Token: 0x040002CF RID: 719
	private const int int_9 = 26;

	// Token: 0x040002D0 RID: 720
	private const int int_10 = 2;

	// Token: 0x02000061 RID: 97
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F490EB00-1240-11D1-9888-006097DEACF9")]
	[ComImport]
	public interface GInterface0
	{
		// Token: 0x060007A2 RID: 1954
		[PreserveSig]
		int ApplyChanges(Generator.GEnum8 dwFlags);
	}

	// Token: 0x02000062 RID: 98
	[Flags]
	public enum GEnum8
	{
		// Token: 0x040003B0 RID: 944
		SAVE = 1,
		// Token: 0x040003B1 RID: 945
		HTMLGEN = 2,
		// Token: 0x040003B2 RID: 946
		REFRESH = 4,
		// Token: 0x040003B3 RID: 947
		ALL = 7,
		// Token: 0x040003B4 RID: 948
		FORCE = 8,
		// Token: 0x040003B5 RID: 949
		BUFFERED_REFRESH = 16,
		// Token: 0x040003B6 RID: 950
		DYNAMICREFRESH = 32
	}

	// Token: 0x02000063 RID: 99
	private enum Enum0
	{
		// Token: 0x040003B8 RID: 952
		File,
		// Token: 0x040003B9 RID: 953
		Directory
	}

	// Token: 0x02000064 RID: 100
	// (Invoke) Token: 0x060007A4 RID: 1956
	private delegate bool Delegate0(IntPtr hwnd, IntPtr lParam);

	// Token: 0x02000065 RID: 101
	[CompilerGenerated]
	[Serializable]
	private sealed class Class26
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x0104FC60 File Offset: 0x0104DE60
		internal char method_0(string string_0)
		{
			return Generator.Class26.smethod_2(string_0, Generator.Class26.smethod_1(Generator.random_0, Generator.Class26.smethod_0(string_0)));
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0103FB24 File Offset: 0x0103DD24
		internal void method_1()
		{
			anti_anal.CreateScreenshot();
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0104FC84 File Offset: 0x0104DE84
		internal void method_2()
		{
			Class22.smethod_1();
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0104FC98 File Offset: 0x0104DE98
		internal bool method_3(int int_0)
		{
			return int_0 % 2 == 0;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0104FCAC File Offset: 0x0104DEAC
		internal long method_4(string string_0)
		{
			return Generator.Class26.smethod_4(Generator.Class26.smethod_3(string_0));
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0104FCAC File Offset: 0x0104DEAC
		internal long method_5(string string_0)
		{
			return Generator.Class26.smethod_4(Generator.Class26.smethod_3(string_0));
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0104FCC4 File Offset: 0x0104DEC4
		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0104FCD8 File Offset: 0x0104DED8
		static int smethod_1(Random random_0, int int_0)
		{
			return random_0.Next(int_0);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0104FCEC File Offset: 0x0104DEEC
		static char smethod_2(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0104FD00 File Offset: 0x0104DF00
		static FileInfo smethod_3(string string_0)
		{
			return new FileInfo(string_0);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0104FD14 File Offset: 0x0104DF14
		static long smethod_4(FileInfo fileInfo_0)
		{
			return fileInfo_0.Length;
		}

		// Token: 0x040003BA RID: 954
		public static readonly Generator.Class26 <>9 = new Generator.Class26();

		// Token: 0x040003BB RID: 955
		public static Func<string, char> <>9__138_0;

		// Token: 0x040003BC RID: 956
		public static ThreadStart <>9__165_0;

		// Token: 0x040003BD RID: 957
		public static ThreadStart <>9__165_1;

		// Token: 0x040003BE RID: 958
		public static Func<int, bool> <>9__179_0;

		// Token: 0x040003BF RID: 959
		public static Func<string, long> <>9__200_0;

		// Token: 0x040003C0 RID: 960
		public static Func<string, long> <>9__200_1;
	}

	// Token: 0x02000066 RID: 102
	[CompilerGenerated]
	private sealed class Class27
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x0104FD28 File Offset: 0x0104DF28
		internal byte method_0(int int_0)
		{
			return Generator.Class27.smethod_1(Generator.Class27.smethod_0(this.string_0, int_0, 2), 16);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0104FD4C File Offset: 0x0104DF4C
		static string smethod_0(string string_1, int int_0, int int_1)
		{
			return string_1.Substring(int_0, int_1);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0104FD64 File Offset: 0x0104DF64
		static byte smethod_1(string string_1, int int_0)
		{
			return Convert.ToByte(string_1, int_0);
		}

		// Token: 0x040003C1 RID: 961
		public string string_0;
	}
}
