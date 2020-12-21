using System;
using System.Runtime.CompilerServices;
using System.Threading;
using tcp_moe_client.Classes;

// Token: 0x02000057 RID: 87
internal class Class20
{
	// Token: 0x060003FB RID: 1019 RVA: 0x0103AB64 File Offset: 0x01038D64
	public void method_0()
	{
		Debug.Log("Helper server started.", Array.Empty<object>());
		Thread[] array = new Thread[Class20.int_0];
		Debug.Log("\n*** Named pipe server stream with impersonation example ***\n", Array.Empty<object>());
		Debug.Log("Waiting for client connect...\n", Array.Empty<object>());
		int i;
		for (i = 0; i < Class20.int_0; i++)
		{
			array[i] = new Thread(new ParameterizedThreadStart(Class20.smethod_0));
			array[i].Start(1000);
		}
		Thread.Sleep(250);
		while (i > 0)
		{
			for (int j = 0; j < Class20.int_0; j++)
			{
				if (array[j] != null && array[j].Join(250))
				{
					Debug.Log("Server thread[{0}] finished.", new object[]
					{
						array[j].ManagedThreadId
					});
					array[j] = null;
					i--;
				}
			}
		}
		Debug.Log("\nServer threads exhausted, exiting.", Array.Empty<object>());
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x0103AC4C File Offset: 0x01038E4C
	private static void smethod_0(object object_0)
	{
		/*
An exception occurred when decompiling this method (060003FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Class20::smethod_0(System.Object)
 ---> System.Exception: Inconsistent stack size at IL_ED
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 279
   à ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:ligne 269
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 112
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 88
   --- Fin de la trace de la pile d'exception interne ---
   à ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:ligne 92
   à ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) dans C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:ligne 1545
*/;
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0103AD94 File Offset: 0x01038F94
	public bool method_1()
	{
		return Class20.bool_0;
	}

	// Token: 0x04000244 RID: 580
	private static bool bool_0 = false;

	// Token: 0x04000245 RID: 581
	private static int int_0 = 1;

	// Token: 0x02000058 RID: 88
	[CompilerGenerated]
	private sealed class Class21
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0103ADC4 File Offset: 0x01038FC4
		internal void method_0()
		{
			anti_anal.found(this.string_0);
		}

		// Token: 0x04000246 RID: 582
		public string string_0;
	}
}
