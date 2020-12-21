using System;

// Token: 0x02000050 RID: 80
internal class Class10 : Class8
{
	// Token: 0x06000397 RID: 919 RVA: 0x01039CE8 File Offset: 0x01037EE8
	public override IntPtr \u202D\u202D\u206E\u200F\u206F\u206C\u202A\u200D\u200F\u206B\u200F\u200C\u200B\u200F\u206D\u202D\u206D\u206B\u206D\u200F\u202C\u202A\u200C\u206F\u206D\u202D\u206D\u200B\u206D\u206B\u206D\u200B\u200D\u202B\u200F\u206D\u206E\u202A\u200D\u206F\u202E(string string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		IntPtr[] array = this.GClass10.\u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(new string[]
		{
			string_0
		}, intptr_0);
		if (array != null && array[0].smethod_4() && this.vmethod_1() == null)
		{
			this.vmethod_2(new Exception("Module's entry point function reported a failure"));
		}
		if (array != null && array.Length != 0)
		{
			return array[0];
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x01039D44 File Offset: 0x01037F44
	public override IntPtr[] \u200E\u206B\u200D\u202B\u200F\u206A\u206D\u200E\u200E\u206B\u206F\u202E\u200F\u200B\u206E\u202B\u206A\u200E\u206B\u206A\u206C\u202A\u206C\u202B\u206B\u206F\u206A\u200F\u206A\u200E\u202B\u200F\u200F\u200E\u200E\u200B\u200E\u202B\u206D\u202A\u202E(string[] string_0, IntPtr intptr_0)
	{
		/*
An exception occurred when decompiling this method (06000398)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr[] Class10::GClass10.‎⁫‍‫‏⁪⁭‎‎⁫⁯‮‏​⁮‫⁪‎⁫⁪⁬‪⁬‫⁫⁯⁪‏⁪‎‫‏‏‎‎​‎‫⁭‪‮(System.String[],System.IntPtr)
 ---> System.Exception: Inconsistent stack size at IL_278
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x04000236 RID: 566
	private static readonly byte[] byte_2 = new byte[]
	{
		156,
		96,
		232,
		0,
		0,
		0,
		0,
		97,
		157,
		233,
		0,
		0,
		0,
		0
	};
}
