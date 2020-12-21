using System;
using System.Windows.Forms;
using LowLevelInput.Hooks;

// Token: 0x02000023 RID: 35
internal class Class6
{
	// Token: 0x06000218 RID: 536 RVA: 0x010353A8 File Offset: 0x010335A8
	public static void smethod_0(int int_0, int int_1)
	{
		Class6.inputManager_0.ClearInjectedFlag = true;
		Class6.inputManager_0.EmulateMouseEvent(1, int_0, int_1);
		Class6.inputManager_0.ClearInjectedFlag = true;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x010353D8 File Offset: 0x010335D8
	public static void smethod_1(int int_0)
	{
		Class6.inputManager_0.ClearInjectedFlag = true;
		Class6.inputManager_0.EmulateMouseEvent(int_0, 0, 0);
		Class6.inputManager_0.ClearInjectedFlag = true;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x01035408 File Offset: 0x01033608
	public static bool smethod_2(Keys keys_0)
	{
		Class6.inputManager_0.ClearInjectedFlag = true;
		return Class6.inputManager_0.IsPressed(keys_0);
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0103542C File Offset: 0x0103362C
	public static bool smethod_3(VirtualKeyCode virtualKeyCode_0)
	{
		Class6.inputManager_0.ClearInjectedFlag = true;
		bool result = Class6.inputManager_0.IsPressed(virtualKeyCode_0);
		Class6.inputManager_0.ClearInjectedFlag = true;
		return result;
	}

	// Token: 0x0400012F RID: 303
	public static InputManager inputManager_0 = new InputManager(false, true);
}
