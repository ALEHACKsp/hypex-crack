using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000089 RID: 137
	public class Worker
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x010565FC File Offset: 0x010547FC
		public Worker()
		{
			this.running = true;
			Worker.instance = this;
			this.context = new ApplicationContext();
			this.client = new GClass0();
			this.client.Event_0 += Events.Client_ExceptionThrown;
			this.client.Event_2 += Events.Client_ReadPacket;
			this.client.Event_1 += Events.Client_StateChanged;
			this.client.Event_4 += Events.Client_WritePacket;
			this.client.method_6(Config.host, Config.port);
			this.auth = new Authentication(this);
			this.auth.Show();
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x010566D0 File Offset: 0x010548D0
		public void KillAuth()
		{
			this.auth.method_1();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x010566E8 File Offset: 0x010548E8
		public void MakeLoader()
		{
			this.loader = new Loader(this);
			this.auth.Invoke(new MethodInvoker(delegate()
			{
				this.loader.Show();
			}));
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0105671C File Offset: 0x0105491C
		public void KillLoader()
		{
			this.loader.method_8();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x01056734 File Offset: 0x01054934
		public void KillGenerator()
		{
			this.generator.method_7();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0105674C File Offset: 0x0105494C
		public void MakeGenerator()
		{
			this.generator = new Generator(this);
			this.loader.Invoke(new MethodInvoker(delegate()
			{
				this.generator.Show();
			}));
			this.loader.method_8();
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x01056788 File Offset: 0x01054988
		public void MakeRS6()
		{
			this.rs6 = new RS6Menu(this);
			this.loader.Invoke(new MethodInvoker(delegate()
			{
				this.rs6.Show();
			}));
			this.loader.method_8();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x010567C4 File Offset: 0x010549C4
		public void MakeH1Z1()
		{
			GForm1 HZ = new GForm1(this);
			this.loader.Invoke(new MethodInvoker(delegate()
			{
				Worker.<>c__DisplayClass17_0.smethod_0(HZ);
			}));
			this.loader.method_8();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x01056808 File Offset: 0x01054A08
		public bool ClientConnected()
		{
			return this.client.Boolean_1;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x01056820 File Offset: 0x01054A20
		public void Shutdown()
		{
			/*
An exception occurred when decompiling this method (060009DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void tcp_moe_client.Classes.Worker::Shutdown()
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

		// Token: 0x060009DC RID: 2524 RVA: 0x01056850 File Offset: 0x01054A50
		public void Send(byte[] data)
		{
			if (Session.HandshakeDone)
			{
				data = Session.encrypt(data);
			}
			this.client.method_12(data);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x01056878 File Offset: 0x01054A78
		public void DontSend()
		{
			Handlers.GeneratorSpawn();
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0105688C File Offset: 0x01054A8C
		public ApplicationContext Satisfy()
		{
			return this.context;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x010568A0 File Offset: 0x01054AA0
		public void SetString()
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[8];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			Config.finalString = new string(array);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x010568F0 File Offset: 0x01054AF0
		public void UpdateClient()
		{
			string path = "C:\\Users\\Public\\Documents\\LoaderPath.txt";
			if (!File.Exists(path))
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Assembly.GetEntryAssembly().Location);
				File.WriteAllBytes(path, bytes);
			}
			Thread.Sleep(100);
			this.startDownload();
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x01056934 File Offset: 0x01054B34
		private void startDownload()
		{
			this.auth.BeginInvoke(new MethodInvoker(delegate()
			{
				Worker.<>c__DisplayClass25_0.smethod_0(this.auth.metroTile1, false);
				Worker.<>c__DisplayClass25_0.smethod_0(this.auth.status, true);
				Worker.<>c__DisplayClass25_0.smethod_0(this.auth.status1, true);
				Worker.<>c__DisplayClass25_0.smethod_0(this.auth.cProgressBar1, true);
			}));
			string download_exe = Config.downloadloader;
			string website = Config.Urli;
			new Thread(delegate()
			{
				WebClient webClient_ = Worker.<>c__DisplayClass25_0.smethod_1();
				Worker.<>c__DisplayClass25_0.smethod_2(webClient_, new DownloadProgressChangedEventHandler(this.client_DownloadProgressChanged));
				Worker.<>c__DisplayClass25_0.smethod_3(webClient_, new AsyncCompletedEventHandler(this.client_DownloadFileCompleted));
				Worker.<>c__DisplayClass25_0.smethod_8(webClient_, Worker.<>c__DisplayClass25_0.smethod_5(Worker.<>c__DisplayClass25_0.smethod_4(website, download_exe)), Worker.<>c__DisplayClass25_0.smethod_7(Worker.<>c__DisplayClass25_0.smethod_6(), <Module>.smethod_5<string>(2044304897u), Config.finalString, <Module>.smethod_7<string>(3629520322u)));
			}).Start();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x01056994 File Offset: 0x01054B94
		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.auth.BeginInvoke(new MethodInvoker(delegate()
			{
				this.auth.status.Text = <Module>.smethod_5<string>(523283142u);
				this.auth.status1.Text = 100 + <Module>.smethod_9<string>(4079355266u);
			}));
			Process.Start(Directory.GetCurrentDirectory() + <Module>.smethod_5<string>(2044304897u) + Config.finalString + <Module>.smethod_6<string>(3905474902u));
			this.Shutdown();
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x010569E8 File Offset: 0x01054BE8
		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.auth.BeginInvoke(new MethodInvoker(delegate()
			{
				double num = double.Parse(Worker.<>c__DisplayClass27_0.smethod_0(e).ToString());
				double num2 = double.Parse(e.TotalBytesToReceive.ToString());
				double num3 = num / num2 * 100.0;
				this.auth.status.Text = string.Concat(new object[]
				{
					<Module>.smethod_8<string>(3056337912u),
					e.BytesReceived / 1000000L,
					<Module>.smethod_9<string>(2789451689u),
					e.TotalBytesToReceive / 1000000L,
					<Module>.smethod_6<string>(3927010243u)
				});
				this.auth.status1.Text = Convert.ToInt32(num3) + <Module>.smethod_9<string>(4079355266u);
				this.auth.cProgressBar1.Value = int.Parse(Math.Truncate(num3).ToString());
			}));
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x01056A24 File Offset: 0x01054C24
		public void DownloadApplication(string download_exe, string path, string processname)
		{
			this.TempProc = processname;
			this.TempPath = path;
			this.loader.BeginInvoke(new MethodInvoker(delegate()
			{
				Worker.<>c__DisplayClass28_0.smethod_0(this.loader.status, true);
			}));
			new Thread(delegate()
			{
				WebClient webClient_ = Worker.<>c__DisplayClass28_0.smethod_1();
				Worker.<>c__DisplayClass28_0.smethod_2(webClient_, new DownloadProgressChangedEventHandler(this.application_DownloadProgressChanged));
				Worker.<>c__DisplayClass28_0.smethod_3(webClient_, new AsyncCompletedEventHandler(this.application_DownloadFileCompleted));
				Worker.<>c__DisplayClass28_0.smethod_5(webClient_, Worker.<>c__DisplayClass28_0.smethod_4(download_exe), path);
			}).Start();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x01056A90 File Offset: 0x01054C90
		private void application_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.loader.BeginInvoke(new MethodInvoker(delegate()
			{
				this.loader.status.Text = <Module>.smethod_7<string>(584897122u);
			}));
			new Thread(new ThreadStart(new Class18().method_0)).Start();
			Worker.StartApp(this.TempPath, "");
			Thread.Sleep(1000);
			if (Process.GetProcessesByName(this.TempProc).FirstOrDefault<Process>() == null)
			{
				Handlers.LaunchExternalApplication(this.TempPath ?? "");
				Thread.Sleep(1000);
			}
			this.loader.method_1(this.TempPath);
			this.KillLoader();
			Thread.Sleep(3000);
			this.Shutdown();
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x01056B40 File Offset: 0x01054D40
		public static void StartApp(string path, string arg)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
			processStartInfo.FileName = path;
			processStartInfo.Arguments = arg;
			processStartInfo.Verb = "runas";
			try
			{
				Process.Start(processStartInfo);
			}
			catch (Exception arg2)
			{
				MessageBox.Show("error\n" + arg2);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x01056BAC File Offset: 0x01054DAC
		public static void StartAppHidden(string path, string arg)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
			processStartInfo.FileName = path;
			processStartInfo.Arguments = arg;
			processStartInfo.Verb = "runas";
			processStartInfo.CreateNoWindow = true;
			try
			{
				Process.Start(processStartInfo);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x01056C10 File Offset: 0x01054E10
		public static int StartAppHiddenAndWaitExit(string path, string arg)
		{
			int result;
			try
			{
				Process process = Process.Start(new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = path,
					Arguments = arg,
					Verb = "runas",
					CreateNoWindow = true
				});
				process.WaitForExit();
				int exitCode = process.ExitCode;
				process.Close();
				result = exitCode;
			}
			catch (Exception)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x01056C88 File Offset: 0x01054E88
		private void application_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.loader.BeginInvoke(new MethodInvoker(delegate()
			{
				double num = double.Parse(Worker.<>c__DisplayClass33_0.smethod_0(e).ToString());
				double num2 = double.Parse(e.TotalBytesToReceive.ToString());
				double num3 = num / num2 * 100.0;
				this.loader.status.Text = <Module>.smethod_5<string>(559389524u) + Convert.ToInt32(num3) + <Module>.smethod_7<string>(1720420120u);
				this.loader.prgLoad.Value = int.Parse(Math.Truncate(num3).ToString());
			}));
		}

		// Token: 0x0400045B RID: 1115
		private ApplicationContext context;

		// Token: 0x0400045C RID: 1116
		private GClass0 client;

		// Token: 0x0400045D RID: 1117
		public static Worker instance;

		// Token: 0x0400045E RID: 1118
		public Authentication auth;

		// Token: 0x0400045F RID: 1119
		public Loader loader;

		// Token: 0x04000460 RID: 1120
		public Generator generator;

		// Token: 0x04000461 RID: 1121
		public RS6Menu rs6;

		// Token: 0x04000462 RID: 1122
		public bool running;

		// Token: 0x04000463 RID: 1123
		public string TempPath = string.Empty;

		// Token: 0x04000464 RID: 1124
		public string TempProc = string.Empty;
	}
}
