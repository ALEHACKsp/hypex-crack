using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000091 RID: 145
	public class Handlers : Enums
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x010572F8 File Offset: 0x010554F8
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0105730C File Offset: 0x0105550C
		public static string HtmlIncoming { get; set; }

		// Token: 0x06000A3F RID: 2623 RVA: 0x01057320 File Offset: 0x01055520
		public static void Incoming(byte[] data)
		{
			/*
An exception occurred when decompiling this method (06000A3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void tcp_moe_client.Classes.Handlers::Incoming(System.Byte[])
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

		// Token: 0x06000A40 RID: 2624 RVA: 0x01057420 File Offset: 0x01055620
		public static void DownloadFile(string url, string path, string procname)
		{
			Worker.instance.DownloadApplication(url, path, procname);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0105743C File Offset: 0x0105563C
		public static void LaunchExternalApplication(string command)
		{
			Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_6<string>(1892424173u), <Module>.smethod_5<string>(2271543304u) + command)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				Verb = <Module>.smethod_9<string>(881277806u),
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			Thread.Sleep(100);
			process.Close();
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x010574A8 File Offset: 0x010556A8
		public static void Handshake(byte[] publicKey, int version)
		{
			if (Config.finalString == string.Empty)
			{
				Worker.instance.SetString();
			}
			string path = "C:\\Users\\Public\\Documents\\LoaderPath.txt";
			string text = string.Empty;
			if (File.Exists(path))
			{
				using (StreamReader streamReader = File.OpenText(path))
				{
					string text2;
					while ((text2 = streamReader.ReadLine()) != null)
					{
						text = text2;
					}
					streamReader.Close();
				}
				if (Assembly.GetEntryAssembly().Location != text && File.Exists(text))
				{
					File.Delete(text);
				}
				File.Delete(path);
			}
			if (version != Config.version)
			{
				Worker.instance.UpdateClient();
				return;
			}
			RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rsacryptoServiceProvider.ImportCspBlob(publicKey);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			Session.encryptor = rijndaelManaged.CreateEncryptor();
			Session.decryptor = rijndaelManaged.CreateDecryptor();
			Senders.Handshake(rsacryptoServiceProvider.Encrypt(Handlers.pack.method_0(new object[]
			{
				rijndaelManaged.Key,
				rijndaelManaged.IV
			}), true));
			Session.HandshakeDone = true;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x010575C0 File Offset: 0x010557C0
		public static void Authentication(Enums.AuthResponse response, string username, string rank)
		{
			switch (response)
			{
			case Enums.AuthResponse.Success:
				Session.Username = username;
				Session.Rank = rank;
				Worker.instance.MakeLoader();
				Worker.instance.KillAuth();
				break;
			case Enums.AuthResponse.UnknownUser:
				UI.MsgBox.Show("The user specified does not exist.", "Authentication error.", MessageBoxIcon.Hand);
				break;
			case Enums.AuthResponse.InvalidPassword:
				UI.MsgBox.Show("The entered password is incorrect.", "Authentication error.", MessageBoxIcon.Hand);
				break;
			case Enums.AuthResponse.InvalidHwid:
				UI.MsgBox.Show("Your hardware changed since the last login.", "Authentication error.", MessageBoxIcon.Hand);
				break;
			case Enums.AuthResponse.Banned:
				anti_anal.DeleteRegeditData();
				UI.MsgBox.Show("You have been banned from using " + Config.loader, "Authentication error.", MessageBoxIcon.Hand);
				break;
			case Enums.AuthResponse.Unverified:
				anti_anal.DeleteRegeditData();
				UI.MsgBox.Show("Your account isn't verified yet.", "Authentication error.", MessageBoxIcon.Hand);
				break;
			case Enums.AuthResponse.ServerError:
				anti_anal.DeleteRegeditData();
				UI.MsgBox.Show("The server retuned an error.", "Authentication error.", MessageBoxIcon.Hand);
				break;
			}
			if (response != Enums.AuthResponse.Success)
			{
				Worker.instance.auth.method_0();
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x010576B4 File Offset: 0x010558B4
		public static void Products(string json)
		{
			foreach (JToken jtoken in JArray.Parse(json))
			{
				Worker.instance.loader.method_7(JsonConvert.DeserializeObject<Product>(jtoken.ToString()));
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x010298D4 File Offset: 0x01027AD4
		public static void FileUpload(byte[] product)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x01057718 File Offset: 0x01055918
		public static void GeneratorSpawn()
		{
			Worker.instance.MakeGenerator();
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x01057730 File Offset: 0x01055930
		public static void RS6Spawn()
		{
			Worker.instance.MakeRS6();
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x01057748 File Offset: 0x01055948
		public static void H1Z1Spawn()
		{
			Worker.instance.MakeH1Z1();
		}

		// Token: 0x0400047A RID: 1146
		private static GClass3 pack = new GClass3();

		// Token: 0x0400047B RID: 1147
		public Loader loader;

		// Token: 0x0400047C RID: 1148
		public Authentication auth;
	}
}
