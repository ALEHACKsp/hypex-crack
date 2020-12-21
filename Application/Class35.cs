using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000099 RID: 153
[CompilerGenerated]
internal static class Class35
{
	// Token: 0x06000A7C RID: 2684 RVA: 0x0105793C File Offset: 0x01055B3C
	private static Assembly smethod_0(AssemblyName assemblyName_0)
	{
		foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(name.CultureInfo.Name, assemblyName_0.CultureInfo.Name, StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x010579A4 File Offset: 0x01055BA4
	private static void smethod_1(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x010579D8 File Offset: 0x01055BD8
	private static Stream smethod_2(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(".compressed"))
		{
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(string_0))
			{
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					Class35.smethod_1(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
			}
			return result;
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x01057A64 File Offset: 0x01055C64
	private static byte[] smethod_3(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x01057A8C File Offset: 0x01055C8C
	private static Assembly smethod_4(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		/*
An exception occurred when decompiling this method (06000A81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Assembly Class35::smethod_4(System.Collections.Generic.Dictionary`2<System.String,System.String>,System.Collections.Generic.Dictionary`2<System.String,System.String>,System.Reflection.AssemblyName)
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

	// Token: 0x06000A82 RID: 2690 RVA: 0x01057B4C File Offset: 0x01055D4C
	public static Assembly smethod_5(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object obj = Class35.object_0;
		lock (obj)
		{
			if (Class35.dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = Class35.smethod_0(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Class35.smethod_4(Class35.dictionary_1, Class35.dictionary_2, assemblyName);
		if (assembly == null)
		{
			obj = Class35.object_0;
			lock (obj)
			{
				Class35.dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x01057C2C File Offset: 0x01055E2C
	// Note: this type is marked as 'beforefieldinit'.
	static Class35()
	{
		Class35.dictionary_1.Add("betterfolderbrowser", "costura.betterfolderbrowser.dll.compressed");
		Class35.dictionary_1.Add("bunifu_ui_v1.5.3", "costura.bunifu_ui_v1.5.3.dll.compressed");
		Class35.dictionary_1.Add("costura", "costura.costura.dll.compressed");
		Class35.dictionary_1.Add("lowlevelinput", "costura.lowlevelinput.dll.compressed");
		Class35.dictionary_1.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
		Class35.dictionary_1.Add("metroframework", "costura.metroframework.dll.compressed");
		Class35.dictionary_1.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
		Class35.dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		Class35.dictionary_1.Add("nextra", "costura.nextra.dll.compressed");
		Class35.dictionary_1.Add("nextra.winforms", "costura.nextra.winforms.dll.compressed");
		Class35.dictionary_1.Add("system.io.compression", "costura.system.io.compression.dll.compressed");
		Class35.dictionary_1.Add("themecolorpicker", "costura.themecolorpicker.dll.compressed");
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x01057D54 File Offset: 0x01055F54
	public static void smethod_6()
	{
		if (Interlocked.Exchange(ref Class35.int_0, 1) == 1)
		{
			return;
		}
		AppDomain.CurrentDomain.AssemblyResolve += Class35.smethod_5;
	}

	// Token: 0x04000484 RID: 1156
	private static object object_0 = new object();

	// Token: 0x04000485 RID: 1157
	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	// Token: 0x04000486 RID: 1158
	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x04000487 RID: 1159
	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x04000488 RID: 1160
	private static int int_0;
}
