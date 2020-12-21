using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace tcp_moe_client.Classes
{
	// Token: 0x02000082 RID: 130
	internal class Local
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x010561EC File Offset: 0x010543EC
		private static string getProperty(string component, string property)
		{
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", string.Format("SELECT {0} FROM {1}", property, component)).Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return ((ManagementObject)enumerator.Current)[property].ToString();
					}
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x01056270 File Offset: 0x01054470
		public static string HWID
		{
			get
			{
				return Convert.ToBase64String(Encoding.UTF8.GetBytes(Local.Profile()));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x01056294 File Offset: 0x01054494
		public static string MD5HWID
		{
			get
			{
				return Local.CreateMD5(Convert.ToBase64String(Encoding.UTF8.GetBytes(Local.Profile())).Replace('=', '~'));
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x010562C4 File Offset: 0x010544C4
		public static string GetModelFromDrive(string driveLetter, string property)
		{
			if (driveLetter.Length != 2)
			{
				return "";
			}
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("ASSOCIATORS OF {Win32_LogicalDisk.DeviceID='" + driveLetter + "'} WHERE ResultClass=Win32_DiskPartition"))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						using (ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + managementBaseObject["DeviceID"] + "'} WHERE ResultClass=Win32_DiskDrive"))
						{
							using (ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = managementObjectSearcher2.Get().GetEnumerator())
							{
								if (enumerator2.MoveNext())
								{
									return (string)enumerator2.Current[property];
								}
							}
						}
					}
				}
			}
			catch
			{
				return "<unknown>";
			}
			return "<unknown>";
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x010563E8 File Offset: 0x010545E8
		public static string CreateMD5(string input)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(input);
				byte[] array = md.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x01056468 File Offset: 0x01054668
		public static string Profile()
		{
			/*
An exception occurred when decompiling this method (060009A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String tcp_moe_client.Classes.Local::Profile()
 ---> System.ArgumentOutOfRangeException: Nombre non négatif requis.
Nom du paramètre : length
   à System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   à System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 49
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 387
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
		}
	}
}
