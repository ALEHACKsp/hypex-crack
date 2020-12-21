using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000067 RID: 103
public static class GClass20
{
	// Token: 0x060007B8 RID: 1976
	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern uint QueryDosDevice([In] string string_0, [Out] StringBuilder stringBuilder_0, [In] int int_0);

	// Token: 0x060007B9 RID: 1977 RVA: 0x0104FD78 File Offset: 0x0104DF78
	public static string smethod_0(string string_0)
	{
		/*
An exception occurred when decompiling this method (060007B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GClass20::smethod_0(System.String)
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

	// Token: 0x060007BA RID: 1978 RVA: 0x0104FDC8 File Offset: 0x0104DFC8
	private static string smethod_1(this DriveInfo driveInfo_0)
	{
		/*
An exception occurred when decompiling this method (060007BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GClass20::smethod_1(System.IO.DriveInfo)
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

	// Token: 0x060007BC RID: 1980 RVA: 0x0104FE00 File Offset: 0x0104E000
	private static string smethod_2(this string string_0, string string_1, string string_2)
	{
		int num = string_0.IndexOf(string_1);
		if (num >= 0)
		{
			return string_0.Substring(0, num) + string_2 + string_0.Substring(num + string_1.Length);
		}
		return string_0;
	}

	// Token: 0x02000068 RID: 104
	[CompilerGenerated]
	private sealed class Class28
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x0104FE38 File Offset: 0x0104E038
		internal bool method_0(DriveInfo driveInfo_0)
		{
			return GClass20.Class28.smethod_0(this.string_0, driveInfo_0.smethod_1(), StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0104FE58 File Offset: 0x0104E058
		static bool smethod_0(string string_1, string string_2, StringComparison stringComparison_0)
		{
			return string_1.StartsWith(string_2, stringComparison_0);
		}

		// Token: 0x040003C2 RID: 962
		public string string_0;
	}
}
