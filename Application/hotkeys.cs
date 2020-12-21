using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using MetroFramework.Components;
using tcp_moe_client.Properties;

// Token: 0x0200001E RID: 30
public class hotkeys : UserControl
{
	// Token: 0x06000107 RID: 263 RVA: 0x0102980C File Offset: 0x01027A0C
	public hotkeys()
	{
		this.InitializeComponent();
		this.metroToolTip_0.SetToolTip(this.bunifuCustomLabel4, <Module>.smethod_6<string>(2575605331u));
		this.metroToolTip_0.SetToolTip(this.modifierBtn, <Module>.smethod_6<string>(2575605331u));
		this.metroToolTip_0.SetToolTip(this.modSwitch, <Module>.smethod_9<string>(93916059u));
		this.modifierLabel.Text = Settings.Default.Modifier;
		this.method_1();
		if (Settings.Default.Modifier == "")
		{
			this.modSwitch.Value = false;
		}
		else
		{
			this.modSwitch.Value = true;
		}
		this.method_6();
	}

	// Token: 0x06000108 RID: 264 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_0(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void hotkeys_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x010298E4 File Offset: 0x01027AE4
	public void method_1()
	{
		Settings.Default.Save();
		this.method_5();
	}

	// Token: 0x0600010B RID: 267 RVA: 0x01029904 File Offset: 0x01027B04
	public void method_2()
	{
		Settings.Default.Save();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0102991C File Offset: 0x01027B1C
	private bool method_3(BunifuThinButton2 bunifuThinButton2_0)
	{
		if (!this.bool_0)
		{
			bunifuThinButton2_0.ButtonText = "Press key";
			this.timer_0.Start();
			this.bool_0 = false;
		}
		else
		{
			bunifuThinButton2_0.ButtonText = "Assign";
		}
		return !(Settings.Default.textKey == "");
	}

	// Token: 0x0600010D RID: 269
	[DllImport("User32.dll")]
	private static extern short GetAsyncKeyState(Keys keys_0);

	// Token: 0x0600010E RID: 270
	[DllImport("User32.dll", EntryPoint = "GetAsyncKeyState")]
	private static extern short GetAsyncKeyState_1(int int_0);

	// Token: 0x0600010F RID: 271 RVA: 0x01029974 File Offset: 0x01027B74
	private void method_4(object sender, EventArgs e)
	{
		this.method_2();
	}

	// Token: 0x06000110 RID: 272 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_5()
	{
	}

	// Token: 0x06000111 RID: 273 RVA: 0x01029988 File Offset: 0x01027B88
	private void modifierBtn_Click(object sender, EventArgs e)
	{
		if (this.modSwitch.Value)
		{
			Settings.Default.textKey = "";
			bool flag;
			do
			{
				if (!this.bool_0)
				{
					this.bool_1 = true;
					this.modifierBtn.ButtonText = "Press key";
					this.timer_0.Start();
					this.bool_1 = false;
				}
				else
				{
					this.modifierBtn.ButtonText = "Assign";
				}
				flag = !(Settings.Default.textKey == "");
				Settings.Default.Modifier = Settings.Default.textKey;
				Settings.Default.Save();
			}
			while (!flag && this.modSwitch.Value);
			this.modifierBtn.ButtonText = "Assign";
			this.bool_1 = false;
			this.method_6();
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x01029A6C File Offset: 0x01027C6C
	private void method_6()
	{
		this.modifierLabel.Text = Settings.Default.Modifier;
		this.terminateModifier.Text = Settings.Default.Modifier;
		this.terminateLabel.Text = Settings.Default.Terminate;
		this.akLabel.Text = Settings.Default.ak;
		this.lrlabel.Text = Settings.Default.lr;
		this.thomlabel.Text = Settings.Default.thompson;
		this.m249label.Text = Settings.Default.m249;
		this.p250label.Text = Settings.Default.p250;
		this.semilabel.Text = Settings.Default.semi;
		this.barettalabel.Text = Settings.Default.baretta;
		this.pythonlabel.Text = Settings.Default.python;
		this.revolverlabel.Text = Settings.Default.revolver;
		this.naillabel.Text = Settings.Default.nailgun;
		this.akmodifierLabel.Text = Settings.Default.Modifier;
		this.lrmodifier.Text = Settings.Default.Modifier;
		this.thommodifier.Text = Settings.Default.Modifier;
		this.m249modifier.Text = Settings.Default.Modifier;
		this.p250modifier.Text = Settings.Default.Modifier;
		this.semimodifier.Text = Settings.Default.Modifier;
		this.barettamodifier.Text = Settings.Default.Modifier;
		this.pythonmodifier.Text = Settings.Default.Modifier;
		this.revolvermodifier.Text = Settings.Default.Modifier;
		this.nailmodifier.Text = Settings.Default.Modifier;
		this.suspendLabel.Text = Settings.Default.suspendtext;
		this.suspendModifier.Text = Settings.Default.Modifier;
		this.rapidLabel.Text = Settings.Default.rapidtext;
		Settings.Default.Save();
	}

	// Token: 0x06000113 RID: 275 RVA: 0x01029CA8 File Offset: 0x01027EA8
	private void terminateBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.terminateBtn);
			Settings.Default.Terminate = Settings.Default.textKey;
			Settings.Default.TerminateKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.terminateBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000114 RID: 276 RVA: 0x01029D20 File Offset: 0x01027F20
	private void akButton_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.akButton);
			Settings.Default.ak = Settings.Default.textKey;
			Settings.Default.akKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.akButton.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000115 RID: 277 RVA: 0x01029D98 File Offset: 0x01027F98
	private void lrbutton_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.lrbutton);
			Settings.Default.lr = Settings.Default.textKey;
			Settings.Default.lrKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.lrbutton.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x01029E10 File Offset: 0x01028010
	private void thomBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.thomBtn);
			Settings.Default.thompson = Settings.Default.textKey;
			Settings.Default.thompsonKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.thomBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x01029E88 File Offset: 0x01028088
	private void m249Btn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.m249Btn);
			Settings.Default.m249 = Settings.Default.textKey;
			Settings.Default.m249Key = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.m249Btn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000118 RID: 280 RVA: 0x01029F00 File Offset: 0x01028100
	private void revolverBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.revolverBtn);
			Settings.Default.revolver = Settings.Default.textKey;
			Settings.Default.revolverKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.revolverBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x01029F78 File Offset: 0x01028178
	private void p250Btn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.p250Btn);
			Settings.Default.p250 = Settings.Default.textKey;
			Settings.Default.p250Key = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.p250Btn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x0600011A RID: 282 RVA: 0x01029FF0 File Offset: 0x010281F0
	private void semiBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.semiBtn);
			Settings.Default.semi = Settings.Default.textKey;
			Settings.Default.semiKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.semiBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0102A068 File Offset: 0x01028268
	private void barettaBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.barettaBtn);
			Settings.Default.baretta = Settings.Default.textKey;
			Settings.Default.barettaKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.barettaBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0102A0E0 File Offset: 0x010282E0
	private void pythonBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.pythonBtn);
			Settings.Default.python = Settings.Default.textKey;
			Settings.Default.pythonKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.pythonBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0102A158 File Offset: 0x01028358
	private void nailBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.nailBtn);
			Settings.Default.nailgun = Settings.Default.textKey;
			Settings.Default.nailgunKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.nailBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0102A1D0 File Offset: 0x010283D0
	private void bunifuThinButton21_Click(object sender, EventArgs e)
	{
		Settings.Default.Reset();
		this.method_6();
	}

	// Token: 0x0600011F RID: 287 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel35_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel20_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel13_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel8_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroToolTip_0_Popup(object sender, PopupEventArgs e)
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void modifierLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void terminateLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void terminateModifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void akmodifierLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void akLabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void lrmodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012A RID: 298 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void lrlabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void thomlabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void thommodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void m249label_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void m249modifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void p250label_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel37_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void p250modifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel7_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void semimodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel34_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void semilabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel27_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void barettalabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void barettamodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel23_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void pythonlabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void pythonmodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel16_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void revolverlabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void revolvermodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel11_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void naillabel_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void nailmodifier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0102A1F0 File Offset: 0x010283F0
	private void modSwitch_Click(object sender, EventArgs e)
	{
		if (!this.modSwitch.Value)
		{
			Settings.Default.Modifier = "";
			Settings.Default.ModifierKey = 0;
			Settings.Default.Save();
		}
		else
		{
			Settings.Default.Modifier = "Ctrl";
			Settings.Default.ModifierKey = 2;
			Settings.Default.Save();
			this.modifierBtn.ButtonText = "Assign";
		}
		this.method_6();
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0102A26C File Offset: 0x0102846C
	private void rapidBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.rapidBtn);
			Settings.Default.rapidtext = Settings.Default.textKey;
			Settings.Default.rapidKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.rapidBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000144 RID: 324 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel6_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void bunifuCustomLabel14_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0102A2E4 File Offset: 0x010284E4
	private void suspendBtn_Click(object sender, EventArgs e)
	{
		Settings.Default.textKey = "";
		bool flag;
		do
		{
			flag = this.method_3(this.suspendBtn);
			Settings.Default.suspendtext = Settings.Default.textKey;
			Settings.Default.suspendKey = Settings.Default.currentKey;
			Settings.Default.Save();
		}
		while (!flag);
		this.suspendBtn.ButtonText = "Assign";
		this.method_6();
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0102A35C File Offset: 0x0102855C
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.bool_2 = Console.CapsLock;
		this.bool_3 = Console.NumberLock;
		foreach (object obj in Enum.GetValues(typeof(Keys)))
		{
			int num = (int)obj;
			if (hotkeys.GetAsyncKeyState_1(num) == -32767)
			{
				this.string_0 = Enum.GetName(typeof(Keys), num).ToString();
				Settings.Default.currentKey = (Keys)Enum.Parse(typeof(Keys), this.string_0, true);
				Settings.Default.Save();
				this.string_0 = this.string_0.ToUpper();
				if (!this.bool_1)
				{
					int num2 = num;
					if (num2 >= 48 && num2 <= 57)
					{
						this.string_0 = (num - 48).ToString();
					}
					else if (num2 >= 96 && num2 <= 105)
					{
						this.string_0 = (num - 96).ToString();
					}
					else
					{
						string a = this.string_0.ToUpper();
						uint num3 = Class34.smethod_0(a);
						if (num3 <= 2227221264u)
						{
							if (num3 > 571887343u)
							{
								if (num3 > 1815054380u)
								{
									if (num3 == 1843272541u)
									{
										if (a == "OEMPERIOD")
										{
											this.string_0 = ".";
											goto IL_6CE;
										}
									}
									else if (num3 != 2215296789u)
									{
										if (num3 == 2227221264u)
										{
											if (a == "LSHIFTKEY")
											{
												this.string_0 = "Shift";
												goto IL_6CE;
											}
										}
									}
									else if (a == "RCONTROLKEY")
									{
										this.string_0 = "Ctrl";
										goto IL_6CE;
									}
								}
								else if (num3 != 665638876u)
								{
									if (num3 != 1532775863u)
									{
										if (num3 == 1815054380u)
										{
											if (a == "OEMMINUS")
											{
												this.string_0 = "-";
												goto IL_6CE;
											}
										}
									}
									else if (a == "OEUMPLUS")
									{
										this.string_0 = "+";
										goto IL_6CE;
									}
								}
								else if (a == "LMENU")
								{
									this.string_0 = "Alt";
									goto IL_6CE;
								}
							}
							else if (num3 <= 504776867u)
							{
								if (num3 != 487999248u)
								{
									if (num3 == 504776867u && a == "OEM5")
									{
										this.string_0 = "\\";
										goto IL_6CE;
									}
								}
								else if (a == "OEM4")
								{
									this.string_0 = "[";
									goto IL_6CE;
								}
							}
							else if (num3 == 521554486u)
							{
								if (a == "OEM6")
								{
									this.string_0 = "]";
									goto IL_6CE;
								}
							}
							else if (num3 != 538332105u)
							{
								if (num3 == 571887343u)
								{
									if (a == "OEM1")
									{
										this.string_0 = ";";
										goto IL_6CE;
									}
								}
							}
							else if (a == "OEM7")
							{
								this.string_0 = "'";
								goto IL_6CE;
							}
						}
						else if (num3 <= 3264564162u)
						{
							if (num3 > 2476218067u)
							{
								if (num3 == 2890017605u)
								{
									if (a == "MULTIPLY")
									{
										this.string_0 = "*";
										goto IL_6CE;
									}
								}
								else if (num3 == 3035865080u)
								{
									if (a == "OEMPIPE")
									{
										this.string_0 = "|";
										goto IL_6CE;
									}
								}
								else if (num3 == 3264564162u)
								{
									if (a == "Back")
									{
										this.string_0 = "Back";
										goto IL_6CE;
									}
								}
							}
							else if (num3 == 2296532151u)
							{
								if (a == "OEMCOMMA")
								{
									this.string_0 = ",";
									goto IL_6CE;
								}
							}
							else if (num3 == 2476218067u && a == "LBUTTON")
							{
								this.string_0 = "";
								goto IL_6CE;
							}
						}
						else if (num3 > 3411823211u)
						{
							if (num3 == 3597778857u)
							{
								if (a == "OEMSEMICOLON")
								{
									this.string_0 = ";";
									goto IL_6CE;
								}
							}
							else if (num3 != 3881774817u)
							{
								if (num3 == 4168191690u)
								{
									if (a == "DELETE")
									{
										this.string_0 = "Del";
										goto IL_6CE;
									}
								}
							}
							else if (a == "SUBTRACT")
							{
								this.string_0 = "-";
								goto IL_6CE;
							}
						}
						else if (num3 == 3375119886u)
						{
							if (a == "RSHIFTKEY")
							{
								this.string_0 = "Shift";
								goto IL_6CE;
							}
						}
						else if (num3 != 3393444824u)
						{
							if (num3 == 3411823211u)
							{
								if (a == "LCONTROLKEY")
								{
									this.string_0 = "Ctrl";
									goto IL_6CE;
								}
							}
						}
						else if (a == "OEMQUSETION")
						{
							this.string_0 = "?";
							goto IL_6CE;
						}
						Keys keys = (Keys)num;
						this.string_0 = keys.ToString();
					}
				}
				else
				{
					string a = this.string_0;
					uint num3 = Class34.smethod_0(a);
					if (num3 > 2227221264u)
					{
						if (num3 <= 2948815116u)
						{
							if (num3 == 2721569867u)
							{
								if (!(a == "lcontrolkey"))
								{
									goto IL_6C3;
								}
							}
							else if (num3 == 2765249532u)
							{
								if (a == "LMenu")
								{
									goto IL_62C;
								}
								goto IL_6C3;
							}
							else
							{
								if (num3 == 2948815116u && a == "lemnu")
								{
									goto IL_62C;
								}
								goto IL_6C3;
							}
						}
						else if (num3 <= 3411823211u)
						{
							if (num3 != 3375119886u)
							{
								if (num3 != 3411823211u || !(a == "LCONTROLKEY"))
								{
									goto IL_6C3;
								}
							}
							else
							{
								if (!(a == "RSHIFTKEY"))
								{
									goto IL_6C3;
								}
								goto IL_6B6;
							}
						}
						else if (num3 == 3792199248u)
						{
							if (a == "Lshiftkey")
							{
								goto IL_692;
							}
							goto IL_6C3;
						}
						else
						{
							if (num3 != 3822460366u)
							{
								goto IL_6C3;
							}
							if (a == "RShiftKey")
							{
								goto IL_6B6;
							}
							goto IL_6C3;
						}
						this.string_0 = "Ctrl";
						goto IL_6CE;
					}
					if (num3 > 1705120176u)
					{
						if (num3 == 1882987381u)
						{
							if (!(a == "rcontrolkey"))
							{
								goto IL_6C3;
							}
						}
						else if (num3 != 2215296789u)
						{
							if (num3 != 2227221264u)
							{
								goto IL_6C3;
							}
							if (!(a == "LSHIFTKEY"))
							{
								goto IL_6C3;
							}
							goto IL_692;
						}
						else if (!(a == "RCONTROLKEY"))
						{
							goto IL_6C3;
						}
						this.string_0 = "Ctrl";
						goto IL_6CE;
					}
					if (num3 == 505356526u)
					{
						if (a == "rshiftkey")
						{
							goto IL_6B6;
						}
						goto IL_6C3;
					}
					else if (num3 != 665638876u)
					{
						if (num3 == 1705120176u && a == "lshiftkey")
						{
							goto IL_692;
						}
						goto IL_6C3;
					}
					else if (!(a == "LMENU"))
					{
						goto IL_6C3;
					}
					IL_62C:
					this.string_0 = "Alt";
					goto IL_6CE;
					IL_692:
					this.string_0 = "Shift";
					goto IL_6CE;
					IL_6B6:
					this.string_0 = "Shift";
					goto IL_6CE;
					IL_6C3:
					this.string_0 = "";
				}
				IL_6CE:
				if (this.bool_1)
				{
					if (!(this.string_0 == "Ctrl"))
					{
						if (!(this.string_0 == "Shift"))
						{
							if (this.string_0 == "Alt")
							{
								Settings.Default.ModifierKey = 1;
							}
						}
						else
						{
							Settings.Default.ModifierKey = 4;
						}
					}
					else
					{
						Settings.Default.ModifierKey = 2;
					}
				}
				Settings.Default.textKey = this.string_0;
				Settings.Default.Save();
				if (Settings.Default.textKey != "")
				{
					this.timer_0.Stop();
				}
			}
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0102AB14 File Offset: 0x01028D14
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0102AB40 File Offset: 0x01028D40
	private void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		Animation animation = new Animation();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(hotkeys));
		this.bunifuCustomLabel6 = new BunifuCustomLabel();
		this.bunifuCustomLabel4 = new BunifuCustomLabel();
		this.bunifuTransition_0 = new BunifuTransition(this.icontainer_0);
		this.modifierLabel = new BunifuCustomLabel();
		this.modifierBtn = new BunifuThinButton2();
		this.terminateModifier = new BunifuCustomLabel();
		this.terminateBtn = new BunifuThinButton2();
		this.terminateLabel = new BunifuCustomLabel();
		this.bunifuCustomLabel7 = new BunifuCustomLabel();
		this.Weapons = new BunifuCustomLabel();
		this.bunifuCustomLabel1 = new BunifuCustomLabel();
		this.m249modifier = new BunifuCustomLabel();
		this.m249Btn = new BunifuThinButton2();
		this.m249label = new BunifuCustomLabel();
		this.bunifuCustomLabel8 = new BunifuCustomLabel();
		this.bunifuCustomLabel9 = new BunifuCustomLabel();
		this.thommodifier = new BunifuCustomLabel();
		this.thomBtn = new BunifuThinButton2();
		this.thomlabel = new BunifuCustomLabel();
		this.bunifuCustomLabel13 = new BunifuCustomLabel();
		this.akButton = new BunifuThinButton2();
		this.lrmodifier = new BunifuCustomLabel();
		this.akmodifierLabel = new BunifuCustomLabel();
		this.lrbutton = new BunifuThinButton2();
		this.lrlabel = new BunifuCustomLabel();
		this.bunifuCustomLabel17 = new BunifuCustomLabel();
		this.bunifuCustomLabel18 = new BunifuCustomLabel();
		this.bunifuCustomLabel19 = new BunifuCustomLabel();
		this.bunifuCustomLabel20 = new BunifuCustomLabel();
		this.pythonmodifier = new BunifuCustomLabel();
		this.pythonBtn = new BunifuThinButton2();
		this.pythonlabel = new BunifuCustomLabel();
		this.bunifuCustomLabel23 = new BunifuCustomLabel();
		this.bunifuCustomLabel24 = new BunifuCustomLabel();
		this.barettamodifier = new BunifuCustomLabel();
		this.barettaBtn = new BunifuThinButton2();
		this.barettalabel = new BunifuCustomLabel();
		this.bunifuCustomLabel27 = new BunifuCustomLabel();
		this.p250Btn = new BunifuThinButton2();
		this.semimodifier = new BunifuCustomLabel();
		this.p250modifier = new BunifuCustomLabel();
		this.semiBtn = new BunifuThinButton2();
		this.semilabel = new BunifuCustomLabel();
		this.bunifuCustomLabel31 = new BunifuCustomLabel();
		this.RandomShitBaretta = new BunifuCustomLabel();
		this.bunifuCustomLabel33 = new BunifuCustomLabel();
		this.bunifuCustomLabel34 = new BunifuCustomLabel();
		this.akLabel = new BunifuCustomLabel();
		this.bunifuCustomLabel35 = new BunifuCustomLabel();
		this.p250label = new BunifuCustomLabel();
		this.bunifuCustomLabel37 = new BunifuCustomLabel();
		this.nailmodifier = new BunifuCustomLabel();
		this.nailBtn = new BunifuThinButton2();
		this.naillabel = new BunifuCustomLabel();
		this.bunifuCustomLabel11 = new BunifuCustomLabel();
		this.bunifuCustomLabel12 = new BunifuCustomLabel();
		this.revolvermodifier = new BunifuCustomLabel();
		this.revolverBtn = new BunifuThinButton2();
		this.revolverlabel = new BunifuCustomLabel();
		this.bunifuCustomLabel16 = new BunifuCustomLabel();
		this.bunifuCustomLabel21 = new BunifuCustomLabel();
		this.bunifuThinButton21 = new BunifuThinButton2();
		this.bunifuCustomLabel15 = new BunifuCustomLabel();
		this.bunifuCustomLabel2 = new BunifuCustomLabel();
		this.modSwitch = new BunifuSwitch();
		this.rapidBtn = new BunifuThinButton2();
		this.rapidLabel = new BunifuCustomLabel();
		this.suspendModifier = new BunifuCustomLabel();
		this.suspendBtn = new BunifuThinButton2();
		this.suspendLabel = new BunifuCustomLabel();
		this.bunifuCustomLabel10 = new BunifuCustomLabel();
		this.bunifuCustomLabel14 = new BunifuCustomLabel();
		this.timer_0 = new Timer(this.icontainer_0);
		this.timer_1 = new Timer(this.icontainer_0);
		this.timer_2 = new Timer(this.icontainer_0);
		this.metroToolTip_0 = new MetroToolTip();
		base.SuspendLayout();
		this.bunifuCustomLabel6.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel6, 0);
		this.bunifuCustomLabel6.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel6.ForeColor = Color.Gray;
		this.bunifuCustomLabel6.Location = new Point(7, 60);
		this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
		this.bunifuCustomLabel6.Size = new Size(69, 16);
		this.bunifuCustomLabel6.TabIndex = 12;
		this.bunifuCustomLabel6.Text = "Terminate";
		this.bunifuCustomLabel6.Click += this.bunifuCustomLabel6_Click;
		this.bunifuCustomLabel4.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel4, 0);
		this.bunifuCustomLabel4.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel4.ForeColor = Color.Gray;
		this.bunifuCustomLabel4.Location = new Point(8, 36);
		this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		this.bunifuCustomLabel4.Size = new Size(74, 16);
		this.bunifuCustomLabel4.TabIndex = 16;
		this.bunifuCustomLabel4.Text = "Modifier (?)";
		this.bunifuTransition_0.AnimationType = 3;
		this.bunifuTransition_0.Cursor = null;
		animation.AnimateOnlyDifferences = true;
		animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
		animation.LeafCoeff = 0f;
		animation.MaxTime = 1f;
		animation.MinTime = 0f;
		animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
		animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation2.MosaicShift");
		animation.MosaicSize = 0;
		animation.Padding = new Padding(0);
		animation.RotateCoeff = 0f;
		animation.RotateLimit = 0f;
		animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
		animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
		animation.TimeCoeff = 0f;
		animation.TransparencyCoeff = 0f;
		this.bunifuTransition_0.DefaultAnimation = animation;
		this.modifierLabel.AutoSize = true;
		this.modifierLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.modifierLabel, 0);
		this.modifierLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.modifierLabel.ForeColor = Color.Gray;
		this.modifierLabel.Location = new Point(138, 35);
		this.modifierLabel.Name = "modifierLabel";
		this.modifierLabel.Size = new Size(25, 15);
		this.modifierLabel.TabIndex = 29;
		this.modifierLabel.Text = "Ctrl";
		this.modifierLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.modifierLabel.Click += this.modifierLabel_Click;
		this.modifierBtn.ActiveBorderThickness = 1;
		this.modifierBtn.ActiveCornerRadius = 20;
		this.modifierBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.modifierBtn.ActiveForecolor = Color.Black;
		this.modifierBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.modifierBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.modifierBtn.BackgroundImage = (Image)componentResourceManager.GetObject("modifierBtn.BackgroundImage");
		this.modifierBtn.ButtonText = "Assign";
		this.modifierBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.modifierBtn, 0);
		this.modifierBtn.Font = new Font("Century Gothic", 7f);
		this.modifierBtn.ForeColor = Color.DeepSkyBlue;
		this.modifierBtn.IdleBorderThickness = 1;
		this.modifierBtn.IdleCornerRadius = 20;
		this.modifierBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.modifierBtn.IdleForecolor = Color.DeepSkyBlue;
		this.modifierBtn.IdleLineColor = Color.DeepSkyBlue;
		this.modifierBtn.Location = new Point(176, 27);
		this.modifierBtn.Margin = new Padding(3, 4, 3, 4);
		this.modifierBtn.Name = "modifierBtn";
		this.modifierBtn.Size = new Size(61, 31);
		this.modifierBtn.TabIndex = 56;
		this.modifierBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.modifierBtn.Click += this.modifierBtn_Click;
		this.terminateModifier.AutoSize = true;
		this.terminateModifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.terminateModifier, 0);
		this.terminateModifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.terminateModifier.ForeColor = Color.Gray;
		this.terminateModifier.Location = new Point(91, 60);
		this.terminateModifier.Name = "terminateModifier";
		this.terminateModifier.Size = new Size(25, 15);
		this.terminateModifier.TabIndex = 60;
		this.terminateModifier.Text = "Ctrl";
		this.terminateModifier.TextAlign = ContentAlignment.MiddleCenter;
		this.terminateModifier.Click += this.terminateModifier_Click;
		this.terminateBtn.ActiveBorderThickness = 1;
		this.terminateBtn.ActiveCornerRadius = 20;
		this.terminateBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.terminateBtn.ActiveForecolor = Color.Black;
		this.terminateBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.terminateBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.terminateBtn.BackgroundImage = (Image)componentResourceManager.GetObject("terminateBtn.BackgroundImage");
		this.terminateBtn.ButtonText = "Assign";
		this.terminateBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.terminateBtn, 0);
		this.terminateBtn.Font = new Font("Century Gothic", 7f);
		this.terminateBtn.ForeColor = Color.DeepSkyBlue;
		this.terminateBtn.IdleBorderThickness = 1;
		this.terminateBtn.IdleCornerRadius = 20;
		this.terminateBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.terminateBtn.IdleForecolor = Color.DeepSkyBlue;
		this.terminateBtn.IdleLineColor = Color.DeepSkyBlue;
		this.terminateBtn.Location = new Point(176, 53);
		this.terminateBtn.Margin = new Padding(3, 4, 3, 4);
		this.terminateBtn.Name = "terminateBtn";
		this.terminateBtn.Size = new Size(61, 31);
		this.terminateBtn.TabIndex = 57;
		this.terminateBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.terminateBtn.Click += this.terminateBtn_Click;
		this.terminateLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.terminateLabel, 0);
		this.terminateLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.terminateLabel.ForeColor = Color.Gray;
		this.terminateLabel.Location = new Point(129, 58);
		this.terminateLabel.Name = "terminateLabel";
		this.terminateLabel.Size = new Size(46, 20);
		this.terminateLabel.TabIndex = 58;
		this.terminateLabel.Text = "TAB";
		this.terminateLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.terminateLabel.Click += this.terminateLabel_Click;
		this.bunifuCustomLabel7.AutoSize = true;
		this.bunifuCustomLabel7.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel7, 0);
		this.bunifuCustomLabel7.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel7.ForeColor = Color.Gray;
		this.bunifuCustomLabel7.Location = new Point(119, 60);
		this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
		this.bunifuCustomLabel7.Size = new Size(14, 15);
		this.bunifuCustomLabel7.TabIndex = 59;
		this.bunifuCustomLabel7.Text = "+";
		this.bunifuCustomLabel7.Visible = false;
		this.bunifuCustomLabel7.Click += this.bunifuCustomLabel7_Click;
		this.Weapons.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.Weapons, 0);
		this.Weapons.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Weapons.ForeColor = Color.DeepSkyBlue;
		this.Weapons.Location = new Point(411, 1);
		this.Weapons.Name = "Weapons";
		this.Weapons.Size = new Size(124, 18);
		this.Weapons.TabIndex = 66;
		this.Weapons.Text = "Profile Hotkeys";
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel1, 0);
		this.bunifuCustomLabel1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
		this.bunifuCustomLabel1.ForeColor = Color.DeepSkyBlue;
		this.bunifuCustomLabel1.Location = new Point(91, 4);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new Size(73, 18);
		this.bunifuCustomLabel1.TabIndex = 67;
		this.bunifuCustomLabel1.Text = "Controls";
		this.m249modifier.AutoSize = true;
		this.m249modifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.m249modifier, 0);
		this.m249modifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.m249modifier.ForeColor = Color.Gray;
		this.m249modifier.Location = new Point(330, 111);
		this.m249modifier.Name = "m249modifier";
		this.m249modifier.Size = new Size(25, 15);
		this.m249modifier.TabIndex = 85;
		this.m249modifier.Text = "Ctrl";
		this.m249modifier.TextAlign = ContentAlignment.MiddleCenter;
		this.m249modifier.Click += this.m249modifier_Click;
		this.m249Btn.ActiveBorderThickness = 1;
		this.m249Btn.ActiveCornerRadius = 20;
		this.m249Btn.ActiveFillColor = Color.DeepSkyBlue;
		this.m249Btn.ActiveForecolor = Color.Black;
		this.m249Btn.ActiveLineColor = Color.DeepSkyBlue;
		this.m249Btn.BackColor = Color.FromArgb(17, 17, 17);
		this.m249Btn.BackgroundImage = (Image)componentResourceManager.GetObject("m249Btn.BackgroundImage");
		this.m249Btn.ButtonText = "Assign";
		this.m249Btn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.m249Btn, 0);
		this.m249Btn.Font = new Font("Century Gothic", 7f);
		this.m249Btn.ForeColor = Color.DeepSkyBlue;
		this.m249Btn.IdleBorderThickness = 1;
		this.m249Btn.IdleCornerRadius = 20;
		this.m249Btn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.m249Btn.IdleForecolor = Color.DeepSkyBlue;
		this.m249Btn.IdleLineColor = Color.DeepSkyBlue;
		this.m249Btn.Location = new Point(415, 104);
		this.m249Btn.Margin = new Padding(3, 4, 3, 4);
		this.m249Btn.Name = "m249Btn";
		this.m249Btn.Size = new Size(61, 31);
		this.m249Btn.TabIndex = 82;
		this.m249Btn.TextAlign = ContentAlignment.MiddleCenter;
		this.m249Btn.Click += this.m249Btn_Click;
		this.m249label.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.m249label, 0);
		this.m249label.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.m249label.ForeColor = Color.Gray;
		this.m249label.Location = new Point(368, 109);
		this.m249label.Name = "m249label";
		this.m249label.Size = new Size(46, 20);
		this.m249label.TabIndex = 83;
		this.m249label.Text = "TAB";
		this.m249label.TextAlign = ContentAlignment.MiddleCenter;
		this.m249label.Click += this.m249label_Click;
		this.bunifuCustomLabel8.AutoSize = true;
		this.bunifuCustomLabel8.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel8, 0);
		this.bunifuCustomLabel8.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel8.ForeColor = Color.Gray;
		this.bunifuCustomLabel8.Location = new Point(358, 111);
		this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
		this.bunifuCustomLabel8.Size = new Size(14, 15);
		this.bunifuCustomLabel8.TabIndex = 84;
		this.bunifuCustomLabel8.Text = "+";
		this.bunifuCustomLabel8.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel8.Visible = false;
		this.bunifuCustomLabel8.Click += this.bunifuCustomLabel8_Click;
		this.bunifuCustomLabel9.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel9, 0);
		this.bunifuCustomLabel9.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel9.ForeColor = Color.Gray;
		this.bunifuCustomLabel9.Location = new Point(247, 113);
		this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
		this.bunifuCustomLabel9.Size = new Size(56, 16);
		this.bunifuCustomLabel9.TabIndex = 81;
		this.bunifuCustomLabel9.Text = "Profile 4";
		this.bunifuCustomLabel9.TextAlign = ContentAlignment.MiddleCenter;
		this.thommodifier.AutoSize = true;
		this.thommodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.thommodifier, 0);
		this.thommodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.thommodifier.ForeColor = Color.Gray;
		this.thommodifier.Location = new Point(330, 85);
		this.thommodifier.Name = "thommodifier";
		this.thommodifier.Size = new Size(25, 15);
		this.thommodifier.TabIndex = 80;
		this.thommodifier.Text = "Ctrl";
		this.thommodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.thommodifier.Click += this.thommodifier_Click;
		this.thomBtn.ActiveBorderThickness = 1;
		this.thomBtn.ActiveCornerRadius = 20;
		this.thomBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.thomBtn.ActiveForecolor = Color.Black;
		this.thomBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.thomBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.thomBtn.BackgroundImage = (Image)componentResourceManager.GetObject("thomBtn.BackgroundImage");
		this.thomBtn.ButtonText = "Assign";
		this.thomBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.thomBtn, 0);
		this.thomBtn.Font = new Font("Century Gothic", 7f);
		this.thomBtn.ForeColor = Color.DeepSkyBlue;
		this.thomBtn.IdleBorderThickness = 1;
		this.thomBtn.IdleCornerRadius = 20;
		this.thomBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.thomBtn.IdleForecolor = Color.DeepSkyBlue;
		this.thomBtn.IdleLineColor = Color.DeepSkyBlue;
		this.thomBtn.Location = new Point(415, 76);
		this.thomBtn.Margin = new Padding(3, 4, 3, 4);
		this.thomBtn.Name = "thomBtn";
		this.thomBtn.Size = new Size(61, 31);
		this.thomBtn.TabIndex = 77;
		this.thomBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.thomBtn.Click += this.thomBtn_Click;
		this.thomlabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.thomlabel, 0);
		this.thomlabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.thomlabel.ForeColor = Color.Gray;
		this.thomlabel.Location = new Point(368, 83);
		this.thomlabel.Name = "thomlabel";
		this.thomlabel.Size = new Size(46, 20);
		this.thomlabel.TabIndex = 78;
		this.thomlabel.Text = "TAB";
		this.thomlabel.TextAlign = ContentAlignment.MiddleCenter;
		this.thomlabel.Click += this.thomlabel_Click;
		this.bunifuCustomLabel13.AutoSize = true;
		this.bunifuCustomLabel13.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel13, 0);
		this.bunifuCustomLabel13.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel13.ForeColor = Color.Gray;
		this.bunifuCustomLabel13.Location = new Point(358, 85);
		this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
		this.bunifuCustomLabel13.Size = new Size(14, 15);
		this.bunifuCustomLabel13.TabIndex = 79;
		this.bunifuCustomLabel13.Text = "+";
		this.bunifuCustomLabel13.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel13.Visible = false;
		this.bunifuCustomLabel13.Click += this.bunifuCustomLabel13_Click;
		this.akButton.ActiveBorderThickness = 1;
		this.akButton.ActiveCornerRadius = 20;
		this.akButton.ActiveFillColor = Color.DeepSkyBlue;
		this.akButton.ActiveForecolor = Color.Black;
		this.akButton.ActiveLineColor = Color.DeepSkyBlue;
		this.akButton.BackColor = Color.FromArgb(17, 17, 17);
		this.akButton.BackgroundImage = (Image)componentResourceManager.GetObject("akButton.BackgroundImage");
		this.akButton.ButtonText = "Assign";
		this.akButton.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.akButton, 0);
		this.akButton.Font = new Font("Century Gothic", 7f);
		this.akButton.ForeColor = Color.DeepSkyBlue;
		this.akButton.IdleBorderThickness = 1;
		this.akButton.IdleCornerRadius = 20;
		this.akButton.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.akButton.IdleForecolor = Color.DeepSkyBlue;
		this.akButton.IdleLineColor = Color.DeepSkyBlue;
		this.akButton.Location = new Point(415, 21);
		this.akButton.Margin = new Padding(3, 4, 3, 4);
		this.akButton.Name = "akButton";
		this.akButton.Size = new Size(61, 31);
		this.akButton.TabIndex = 76;
		this.akButton.TextAlign = ContentAlignment.MiddleCenter;
		this.akButton.Click += this.akButton_Click;
		this.lrmodifier.AutoSize = true;
		this.lrmodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.lrmodifier, 0);
		this.lrmodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.lrmodifier.ForeColor = Color.Gray;
		this.lrmodifier.Location = new Point(330, 57);
		this.lrmodifier.Name = "lrmodifier";
		this.lrmodifier.Size = new Size(25, 15);
		this.lrmodifier.TabIndex = 75;
		this.lrmodifier.Text = "Ctrl";
		this.lrmodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.lrmodifier.Click += this.lrmodifier_Click;
		this.akmodifierLabel.AutoSize = true;
		this.akmodifierLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.akmodifierLabel, 0);
		this.akmodifierLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.akmodifierLabel.ForeColor = Color.Gray;
		this.akmodifierLabel.Location = new Point(330, 30);
		this.akmodifierLabel.Name = "akmodifierLabel";
		this.akmodifierLabel.Size = new Size(25, 15);
		this.akmodifierLabel.TabIndex = 72;
		this.akmodifierLabel.Text = "Ctrl";
		this.akmodifierLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.akmodifierLabel.Click += this.akmodifierLabel_Click;
		this.lrbutton.ActiveBorderThickness = 1;
		this.lrbutton.ActiveCornerRadius = 20;
		this.lrbutton.ActiveFillColor = Color.DeepSkyBlue;
		this.lrbutton.ActiveForecolor = Color.Black;
		this.lrbutton.ActiveLineColor = Color.DeepSkyBlue;
		this.lrbutton.BackColor = Color.FromArgb(17, 17, 17);
		this.lrbutton.BackgroundImage = (Image)componentResourceManager.GetObject("lrbutton.BackgroundImage");
		this.lrbutton.ButtonText = "Assign";
		this.lrbutton.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.lrbutton, 0);
		this.lrbutton.Font = new Font("Century Gothic", 7f);
		this.lrbutton.ForeColor = Color.DeepSkyBlue;
		this.lrbutton.IdleBorderThickness = 1;
		this.lrbutton.IdleCornerRadius = 20;
		this.lrbutton.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.lrbutton.IdleForecolor = Color.DeepSkyBlue;
		this.lrbutton.IdleLineColor = Color.DeepSkyBlue;
		this.lrbutton.Location = new Point(415, 48);
		this.lrbutton.Margin = new Padding(3, 4, 3, 4);
		this.lrbutton.Name = "lrbutton";
		this.lrbutton.Size = new Size(61, 31);
		this.lrbutton.TabIndex = 71;
		this.lrbutton.TextAlign = ContentAlignment.MiddleCenter;
		this.lrbutton.Click += this.lrbutton_Click;
		this.lrlabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.lrlabel, 0);
		this.lrlabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.lrlabel.ForeColor = Color.Gray;
		this.lrlabel.Location = new Point(368, 55);
		this.lrlabel.Name = "lrlabel";
		this.lrlabel.Size = new Size(46, 20);
		this.lrlabel.TabIndex = 73;
		this.lrlabel.Text = "TAB";
		this.lrlabel.TextAlign = ContentAlignment.MiddleCenter;
		this.lrlabel.Click += this.lrlabel_Click;
		this.bunifuCustomLabel17.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel17, 0);
		this.bunifuCustomLabel17.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel17.ForeColor = Color.Gray;
		this.bunifuCustomLabel17.Location = new Point(247, 31);
		this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
		this.bunifuCustomLabel17.Size = new Size(56, 16);
		this.bunifuCustomLabel17.TabIndex = 70;
		this.bunifuCustomLabel17.Text = "Profile 1";
		this.bunifuCustomLabel17.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel18.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel18, 0);
		this.bunifuCustomLabel18.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel18.ForeColor = Color.Gray;
		this.bunifuCustomLabel18.Location = new Point(247, 86);
		this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
		this.bunifuCustomLabel18.Size = new Size(56, 16);
		this.bunifuCustomLabel18.TabIndex = 69;
		this.bunifuCustomLabel18.Text = "Profile 3";
		this.bunifuCustomLabel18.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel19.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel19, 0);
		this.bunifuCustomLabel19.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel19.ForeColor = Color.Gray;
		this.bunifuCustomLabel19.Location = new Point(247, 58);
		this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
		this.bunifuCustomLabel19.Size = new Size(56, 16);
		this.bunifuCustomLabel19.TabIndex = 68;
		this.bunifuCustomLabel19.Text = "Profile 2";
		this.bunifuCustomLabel19.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel20.AutoSize = true;
		this.bunifuCustomLabel20.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel20, 0);
		this.bunifuCustomLabel20.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel20.ForeColor = Color.Gray;
		this.bunifuCustomLabel20.Location = new Point(358, 57);
		this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
		this.bunifuCustomLabel20.Size = new Size(14, 15);
		this.bunifuCustomLabel20.TabIndex = 74;
		this.bunifuCustomLabel20.Text = "+";
		this.bunifuCustomLabel20.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel20.Visible = false;
		this.bunifuCustomLabel20.Click += this.bunifuCustomLabel20_Click;
		this.pythonmodifier.AutoSize = true;
		this.pythonmodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.pythonmodifier, 0);
		this.pythonmodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.pythonmodifier.ForeColor = Color.Gray;
		this.pythonmodifier.Location = new Point(565, 83);
		this.pythonmodifier.Name = "pythonmodifier";
		this.pythonmodifier.Size = new Size(25, 15);
		this.pythonmodifier.TabIndex = 103;
		this.pythonmodifier.Text = "Ctrl";
		this.pythonmodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.pythonmodifier.Click += this.pythonmodifier_Click;
		this.pythonBtn.ActiveBorderThickness = 1;
		this.pythonBtn.ActiveCornerRadius = 20;
		this.pythonBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.pythonBtn.ActiveForecolor = Color.Black;
		this.pythonBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.pythonBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.pythonBtn.BackgroundImage = (Image)componentResourceManager.GetObject("pythonBtn.BackgroundImage");
		this.pythonBtn.ButtonText = "Assign";
		this.pythonBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.pythonBtn, 0);
		this.pythonBtn.Font = new Font("Century Gothic", 7f);
		this.pythonBtn.ForeColor = Color.DeepSkyBlue;
		this.pythonBtn.IdleBorderThickness = 1;
		this.pythonBtn.IdleCornerRadius = 20;
		this.pythonBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.pythonBtn.IdleForecolor = Color.DeepSkyBlue;
		this.pythonBtn.IdleLineColor = Color.DeepSkyBlue;
		this.pythonBtn.Location = new Point(650, 76);
		this.pythonBtn.Margin = new Padding(3, 4, 3, 4);
		this.pythonBtn.Name = "pythonBtn";
		this.pythonBtn.Size = new Size(61, 31);
		this.pythonBtn.TabIndex = 100;
		this.pythonBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.pythonBtn.Click += this.pythonBtn_Click;
		this.pythonlabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.pythonlabel, 0);
		this.pythonlabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.pythonlabel.ForeColor = Color.Gray;
		this.pythonlabel.Location = new Point(603, 81);
		this.pythonlabel.Name = "pythonlabel";
		this.pythonlabel.Size = new Size(46, 20);
		this.pythonlabel.TabIndex = 101;
		this.pythonlabel.Text = "TAB";
		this.pythonlabel.TextAlign = ContentAlignment.MiddleCenter;
		this.pythonlabel.Click += this.pythonlabel_Click;
		this.bunifuCustomLabel23.AutoSize = true;
		this.bunifuCustomLabel23.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel23, 0);
		this.bunifuCustomLabel23.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel23.ForeColor = Color.Gray;
		this.bunifuCustomLabel23.Location = new Point(593, 83);
		this.bunifuCustomLabel23.Name = "bunifuCustomLabel23";
		this.bunifuCustomLabel23.Size = new Size(14, 15);
		this.bunifuCustomLabel23.TabIndex = 102;
		this.bunifuCustomLabel23.Text = "+";
		this.bunifuCustomLabel23.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel23.Visible = false;
		this.bunifuCustomLabel23.Click += this.bunifuCustomLabel23_Click;
		this.bunifuCustomLabel24.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel24, 0);
		this.bunifuCustomLabel24.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel24.ForeColor = Color.Gray;
		this.bunifuCustomLabel24.Location = new Point(482, 83);
		this.bunifuCustomLabel24.Name = "bunifuCustomLabel24";
		this.bunifuCustomLabel24.Size = new Size(56, 16);
		this.bunifuCustomLabel24.TabIndex = 99;
		this.bunifuCustomLabel24.Text = "Profile 8";
		this.bunifuCustomLabel24.TextAlign = ContentAlignment.MiddleCenter;
		this.barettamodifier.AutoSize = true;
		this.barettamodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.barettamodifier, 0);
		this.barettamodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.barettamodifier.ForeColor = Color.Gray;
		this.barettamodifier.Location = new Point(565, 56);
		this.barettamodifier.Name = "barettamodifier";
		this.barettamodifier.Size = new Size(25, 15);
		this.barettamodifier.TabIndex = 98;
		this.barettamodifier.Text = "Ctrl";
		this.barettamodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.barettamodifier.Click += this.barettamodifier_Click;
		this.barettaBtn.ActiveBorderThickness = 1;
		this.barettaBtn.ActiveCornerRadius = 20;
		this.barettaBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.barettaBtn.ActiveForecolor = Color.Black;
		this.barettaBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.barettaBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.barettaBtn.BackgroundImage = (Image)componentResourceManager.GetObject("barettaBtn.BackgroundImage");
		this.barettaBtn.ButtonText = "Assign";
		this.barettaBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.barettaBtn, 0);
		this.barettaBtn.Font = new Font("Century Gothic", 7f);
		this.barettaBtn.ForeColor = Color.DeepSkyBlue;
		this.barettaBtn.IdleBorderThickness = 1;
		this.barettaBtn.IdleCornerRadius = 20;
		this.barettaBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.barettaBtn.IdleForecolor = Color.DeepSkyBlue;
		this.barettaBtn.IdleLineColor = Color.DeepSkyBlue;
		this.barettaBtn.Location = new Point(650, 49);
		this.barettaBtn.Margin = new Padding(3, 4, 3, 4);
		this.barettaBtn.Name = "barettaBtn";
		this.barettaBtn.Size = new Size(61, 31);
		this.barettaBtn.TabIndex = 95;
		this.barettaBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.barettaBtn.Click += this.barettaBtn_Click;
		this.barettalabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.barettalabel, 0);
		this.barettalabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.barettalabel.ForeColor = Color.Gray;
		this.barettalabel.Location = new Point(603, 54);
		this.barettalabel.Name = "barettalabel";
		this.barettalabel.Size = new Size(46, 20);
		this.barettalabel.TabIndex = 96;
		this.barettalabel.Text = "TAB";
		this.barettalabel.TextAlign = ContentAlignment.MiddleCenter;
		this.barettalabel.Click += this.barettalabel_Click;
		this.bunifuCustomLabel27.AutoSize = true;
		this.bunifuCustomLabel27.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel27, 0);
		this.bunifuCustomLabel27.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel27.ForeColor = Color.Gray;
		this.bunifuCustomLabel27.Location = new Point(593, 56);
		this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
		this.bunifuCustomLabel27.Size = new Size(14, 15);
		this.bunifuCustomLabel27.TabIndex = 97;
		this.bunifuCustomLabel27.Text = "+";
		this.bunifuCustomLabel27.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel27.Visible = false;
		this.bunifuCustomLabel27.Click += this.bunifuCustomLabel27_Click;
		this.p250Btn.ActiveBorderThickness = 1;
		this.p250Btn.ActiveCornerRadius = 20;
		this.p250Btn.ActiveFillColor = Color.DeepSkyBlue;
		this.p250Btn.ActiveForecolor = Color.Black;
		this.p250Btn.ActiveLineColor = Color.DeepSkyBlue;
		this.p250Btn.BackColor = Color.FromArgb(17, 17, 17);
		this.p250Btn.BackgroundImage = (Image)componentResourceManager.GetObject("p250Btn.BackgroundImage");
		this.p250Btn.ButtonText = "Assign";
		this.p250Btn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.p250Btn, 0);
		this.p250Btn.Font = new Font("Century Gothic", 7f);
		this.p250Btn.ForeColor = Color.DeepSkyBlue;
		this.p250Btn.IdleBorderThickness = 1;
		this.p250Btn.IdleCornerRadius = 20;
		this.p250Btn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.p250Btn.IdleForecolor = Color.DeepSkyBlue;
		this.p250Btn.IdleLineColor = Color.DeepSkyBlue;
		this.p250Btn.Location = new Point(415, 132);
		this.p250Btn.Margin = new Padding(3, 4, 3, 4);
		this.p250Btn.Name = "p250Btn";
		this.p250Btn.Size = new Size(61, 31);
		this.p250Btn.TabIndex = 94;
		this.p250Btn.TextAlign = ContentAlignment.MiddleCenter;
		this.p250Btn.Click += this.p250Btn_Click;
		this.semimodifier.AutoSize = true;
		this.semimodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.semimodifier, 0);
		this.semimodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.semimodifier.ForeColor = Color.Gray;
		this.semimodifier.Location = new Point(565, 28);
		this.semimodifier.Name = "semimodifier";
		this.semimodifier.Size = new Size(25, 15);
		this.semimodifier.TabIndex = 93;
		this.semimodifier.Text = "Ctrl";
		this.semimodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.semimodifier.Click += this.semimodifier_Click;
		this.p250modifier.AutoSize = true;
		this.p250modifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.p250modifier, 0);
		this.p250modifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.p250modifier.ForeColor = Color.Gray;
		this.p250modifier.Location = new Point(330, 140);
		this.p250modifier.Name = "p250modifier";
		this.p250modifier.Size = new Size(25, 15);
		this.p250modifier.TabIndex = 90;
		this.p250modifier.Text = "Ctrl";
		this.p250modifier.TextAlign = ContentAlignment.MiddleCenter;
		this.p250modifier.Click += this.p250modifier_Click;
		this.semiBtn.ActiveBorderThickness = 1;
		this.semiBtn.ActiveCornerRadius = 20;
		this.semiBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.semiBtn.ActiveForecolor = Color.Black;
		this.semiBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.semiBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.semiBtn.BackgroundImage = (Image)componentResourceManager.GetObject("semiBtn.BackgroundImage");
		this.semiBtn.ButtonText = "Assign";
		this.semiBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.semiBtn, 0);
		this.semiBtn.Font = new Font("Century Gothic", 7f);
		this.semiBtn.ForeColor = Color.DeepSkyBlue;
		this.semiBtn.IdleBorderThickness = 1;
		this.semiBtn.IdleCornerRadius = 20;
		this.semiBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.semiBtn.IdleForecolor = Color.DeepSkyBlue;
		this.semiBtn.IdleLineColor = Color.DeepSkyBlue;
		this.semiBtn.Location = new Point(650, 21);
		this.semiBtn.Margin = new Padding(3, 4, 3, 4);
		this.semiBtn.Name = "semiBtn";
		this.semiBtn.Size = new Size(61, 31);
		this.semiBtn.TabIndex = 89;
		this.semiBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.semiBtn.Click += this.semiBtn_Click;
		this.semilabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.semilabel, 0);
		this.semilabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.semilabel.ForeColor = Color.Gray;
		this.semilabel.Location = new Point(603, 26);
		this.semilabel.Name = "semilabel";
		this.semilabel.Size = new Size(46, 20);
		this.semilabel.TabIndex = 91;
		this.semilabel.Text = "TAB";
		this.semilabel.TextAlign = ContentAlignment.MiddleCenter;
		this.semilabel.Click += this.semilabel_Click;
		this.bunifuCustomLabel31.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel31, 0);
		this.bunifuCustomLabel31.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel31.ForeColor = Color.Gray;
		this.bunifuCustomLabel31.Location = new Point(247, 141);
		this.bunifuCustomLabel31.Name = "bunifuCustomLabel31";
		this.bunifuCustomLabel31.Size = new Size(56, 16);
		this.bunifuCustomLabel31.TabIndex = 88;
		this.bunifuCustomLabel31.Text = "Profile 5";
		this.bunifuCustomLabel31.TextAlign = ContentAlignment.MiddleCenter;
		this.RandomShitBaretta.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.RandomShitBaretta, 0);
		this.RandomShitBaretta.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.RandomShitBaretta.ForeColor = Color.Gray;
		this.RandomShitBaretta.Location = new Point(482, 56);
		this.RandomShitBaretta.Name = "RandomShitBaretta";
		this.RandomShitBaretta.Size = new Size(56, 16);
		this.RandomShitBaretta.TabIndex = 87;
		this.RandomShitBaretta.Text = "Profile 7";
		this.RandomShitBaretta.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel33.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel33, 0);
		this.bunifuCustomLabel33.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel33.ForeColor = Color.Gray;
		this.bunifuCustomLabel33.Location = new Point(482, 28);
		this.bunifuCustomLabel33.Name = "bunifuCustomLabel33";
		this.bunifuCustomLabel33.Size = new Size(56, 16);
		this.bunifuCustomLabel33.TabIndex = 86;
		this.bunifuCustomLabel33.Text = "Profile 6";
		this.bunifuCustomLabel33.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel34.AutoSize = true;
		this.bunifuCustomLabel34.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel34, 0);
		this.bunifuCustomLabel34.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel34.ForeColor = Color.Gray;
		this.bunifuCustomLabel34.Location = new Point(593, 28);
		this.bunifuCustomLabel34.Name = "bunifuCustomLabel34";
		this.bunifuCustomLabel34.Size = new Size(14, 15);
		this.bunifuCustomLabel34.TabIndex = 92;
		this.bunifuCustomLabel34.Text = "+";
		this.bunifuCustomLabel34.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel34.Visible = false;
		this.bunifuCustomLabel34.Click += this.bunifuCustomLabel34_Click;
		this.akLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.akLabel, 0);
		this.akLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.akLabel.ForeColor = Color.Gray;
		this.akLabel.Location = new Point(368, 27);
		this.akLabel.Name = "akLabel";
		this.akLabel.Size = new Size(46, 20);
		this.akLabel.TabIndex = 104;
		this.akLabel.Text = "TAB";
		this.akLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.akLabel.Click += this.akLabel_Click;
		this.bunifuCustomLabel35.AutoSize = true;
		this.bunifuCustomLabel35.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel35, 0);
		this.bunifuCustomLabel35.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel35.ForeColor = Color.Gray;
		this.bunifuCustomLabel35.Location = new Point(358, 30);
		this.bunifuCustomLabel35.Name = "bunifuCustomLabel35";
		this.bunifuCustomLabel35.Size = new Size(14, 15);
		this.bunifuCustomLabel35.TabIndex = 105;
		this.bunifuCustomLabel35.Text = "+";
		this.bunifuCustomLabel35.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel35.Visible = false;
		this.bunifuCustomLabel35.Click += this.bunifuCustomLabel35_Click;
		this.p250label.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.p250label, 0);
		this.p250label.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.p250label.ForeColor = Color.Gray;
		this.p250label.Location = new Point(368, 138);
		this.p250label.Name = "p250label";
		this.p250label.Size = new Size(46, 20);
		this.p250label.TabIndex = 106;
		this.p250label.Text = "TAB";
		this.p250label.TextAlign = ContentAlignment.MiddleCenter;
		this.p250label.Click += this.p250label_Click;
		this.bunifuCustomLabel37.AutoSize = true;
		this.bunifuCustomLabel37.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel37, 0);
		this.bunifuCustomLabel37.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel37.ForeColor = Color.Gray;
		this.bunifuCustomLabel37.Location = new Point(358, 141);
		this.bunifuCustomLabel37.Name = "bunifuCustomLabel37";
		this.bunifuCustomLabel37.Size = new Size(14, 15);
		this.bunifuCustomLabel37.TabIndex = 107;
		this.bunifuCustomLabel37.Text = "+";
		this.bunifuCustomLabel37.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel37.Visible = false;
		this.bunifuCustomLabel37.Click += this.bunifuCustomLabel37_Click;
		this.nailmodifier.AutoSize = true;
		this.nailmodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.nailmodifier, 0);
		this.nailmodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.nailmodifier.ForeColor = Color.Gray;
		this.nailmodifier.Location = new Point(565, 139);
		this.nailmodifier.Name = "nailmodifier";
		this.nailmodifier.Size = new Size(25, 15);
		this.nailmodifier.TabIndex = 117;
		this.nailmodifier.Text = "Ctrl";
		this.nailmodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.nailmodifier.Click += this.nailmodifier_Click;
		this.nailBtn.ActiveBorderThickness = 1;
		this.nailBtn.ActiveCornerRadius = 20;
		this.nailBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.nailBtn.ActiveForecolor = Color.Black;
		this.nailBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.nailBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.nailBtn.BackgroundImage = (Image)componentResourceManager.GetObject("nailBtn.BackgroundImage");
		this.nailBtn.ButtonText = "Assign";
		this.nailBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.nailBtn, 0);
		this.nailBtn.Font = new Font("Century Gothic", 7f);
		this.nailBtn.ForeColor = Color.DeepSkyBlue;
		this.nailBtn.IdleBorderThickness = 1;
		this.nailBtn.IdleCornerRadius = 20;
		this.nailBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.nailBtn.IdleForecolor = Color.DeepSkyBlue;
		this.nailBtn.IdleLineColor = Color.DeepSkyBlue;
		this.nailBtn.Location = new Point(650, 132);
		this.nailBtn.Margin = new Padding(3, 4, 3, 4);
		this.nailBtn.Name = "nailBtn";
		this.nailBtn.Size = new Size(61, 31);
		this.nailBtn.TabIndex = 114;
		this.nailBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.nailBtn.Click += this.nailBtn_Click;
		this.naillabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.naillabel, 0);
		this.naillabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.naillabel.ForeColor = Color.Gray;
		this.naillabel.Location = new Point(603, 137);
		this.naillabel.Name = "naillabel";
		this.naillabel.Size = new Size(46, 20);
		this.naillabel.TabIndex = 115;
		this.naillabel.Text = "TAB";
		this.naillabel.TextAlign = ContentAlignment.MiddleCenter;
		this.naillabel.Click += this.naillabel_Click;
		this.bunifuCustomLabel11.AutoSize = true;
		this.bunifuCustomLabel11.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel11, 0);
		this.bunifuCustomLabel11.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel11.ForeColor = Color.Gray;
		this.bunifuCustomLabel11.Location = new Point(593, 139);
		this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
		this.bunifuCustomLabel11.Size = new Size(14, 15);
		this.bunifuCustomLabel11.TabIndex = 116;
		this.bunifuCustomLabel11.Text = "+";
		this.bunifuCustomLabel11.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel11.Visible = false;
		this.bunifuCustomLabel11.Click += this.bunifuCustomLabel11_Click;
		this.bunifuCustomLabel12.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel12, 0);
		this.bunifuCustomLabel12.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel12.ForeColor = Color.Gray;
		this.bunifuCustomLabel12.Location = new Point(482, 139);
		this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
		this.bunifuCustomLabel12.Size = new Size(63, 16);
		this.bunifuCustomLabel12.TabIndex = 113;
		this.bunifuCustomLabel12.Text = "Profile 10";
		this.bunifuCustomLabel12.TextAlign = ContentAlignment.MiddleCenter;
		this.revolvermodifier.AutoSize = true;
		this.revolvermodifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.revolvermodifier, 0);
		this.revolvermodifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.revolvermodifier.ForeColor = Color.Gray;
		this.revolvermodifier.Location = new Point(565, 112);
		this.revolvermodifier.Name = "revolvermodifier";
		this.revolvermodifier.Size = new Size(25, 15);
		this.revolvermodifier.TabIndex = 112;
		this.revolvermodifier.Text = "Ctrl";
		this.revolvermodifier.TextAlign = ContentAlignment.MiddleCenter;
		this.revolvermodifier.Click += this.revolvermodifier_Click;
		this.revolverBtn.ActiveBorderThickness = 1;
		this.revolverBtn.ActiveCornerRadius = 20;
		this.revolverBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.revolverBtn.ActiveForecolor = Color.Black;
		this.revolverBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.revolverBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.revolverBtn.BackgroundImage = (Image)componentResourceManager.GetObject("revolverBtn.BackgroundImage");
		this.revolverBtn.ButtonText = "Assign";
		this.revolverBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.revolverBtn, 0);
		this.revolverBtn.Font = new Font("Century Gothic", 7f);
		this.revolverBtn.ForeColor = Color.DeepSkyBlue;
		this.revolverBtn.IdleBorderThickness = 1;
		this.revolverBtn.IdleCornerRadius = 20;
		this.revolverBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.revolverBtn.IdleForecolor = Color.DeepSkyBlue;
		this.revolverBtn.IdleLineColor = Color.DeepSkyBlue;
		this.revolverBtn.Location = new Point(650, 105);
		this.revolverBtn.Margin = new Padding(3, 4, 3, 4);
		this.revolverBtn.Name = "revolverBtn";
		this.revolverBtn.Size = new Size(61, 31);
		this.revolverBtn.TabIndex = 109;
		this.revolverBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.revolverBtn.Click += this.revolverBtn_Click;
		this.revolverlabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.revolverlabel, 0);
		this.revolverlabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.revolverlabel.ForeColor = Color.Gray;
		this.revolverlabel.Location = new Point(603, 110);
		this.revolverlabel.Name = "revolverlabel";
		this.revolverlabel.Size = new Size(46, 20);
		this.revolverlabel.TabIndex = 110;
		this.revolverlabel.Text = "TAB";
		this.revolverlabel.TextAlign = ContentAlignment.MiddleCenter;
		this.revolverlabel.Click += this.revolverlabel_Click;
		this.bunifuCustomLabel16.AutoSize = true;
		this.bunifuCustomLabel16.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel16, 0);
		this.bunifuCustomLabel16.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel16.ForeColor = Color.Gray;
		this.bunifuCustomLabel16.Location = new Point(593, 112);
		this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
		this.bunifuCustomLabel16.Size = new Size(14, 15);
		this.bunifuCustomLabel16.TabIndex = 111;
		this.bunifuCustomLabel16.Text = "+";
		this.bunifuCustomLabel16.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel16.Visible = false;
		this.bunifuCustomLabel16.Click += this.bunifuCustomLabel16_Click;
		this.bunifuCustomLabel21.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel21, 0);
		this.bunifuCustomLabel21.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel21.ForeColor = Color.Gray;
		this.bunifuCustomLabel21.Location = new Point(482, 112);
		this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
		this.bunifuCustomLabel21.Size = new Size(56, 16);
		this.bunifuCustomLabel21.TabIndex = 108;
		this.bunifuCustomLabel21.Text = "Profile 9";
		this.bunifuCustomLabel21.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton21.ActiveBorderThickness = 1;
		this.bunifuThinButton21.ActiveCornerRadius = 20;
		this.bunifuThinButton21.ActiveFillColor = Color.DeepSkyBlue;
		this.bunifuThinButton21.ActiveForecolor = Color.Black;
		this.bunifuThinButton21.ActiveLineColor = Color.DeepSkyBlue;
		this.bunifuThinButton21.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuThinButton21.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton21.BackgroundImage");
		this.bunifuThinButton21.ButtonText = "Reset";
		this.bunifuThinButton21.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.bunifuThinButton21, 0);
		this.bunifuThinButton21.Font = new Font("Century Gothic", 7f);
		this.bunifuThinButton21.ForeColor = Color.DeepSkyBlue;
		this.bunifuThinButton21.IdleBorderThickness = 1;
		this.bunifuThinButton21.IdleCornerRadius = 20;
		this.bunifuThinButton21.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.bunifuThinButton21.IdleForecolor = Color.DeepSkyBlue;
		this.bunifuThinButton21.IdleLineColor = Color.DeepSkyBlue;
		this.bunifuThinButton21.Location = new Point(176, 135);
		this.bunifuThinButton21.Margin = new Padding(3, 4, 3, 4);
		this.bunifuThinButton21.Name = "bunifuThinButton21";
		this.bunifuThinButton21.Size = new Size(61, 31);
		this.bunifuThinButton21.TabIndex = 119;
		this.bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton21.Click += this.bunifuThinButton21_Click;
		this.bunifuCustomLabel15.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel15, 0);
		this.bunifuCustomLabel15.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel15.ForeColor = Color.Gray;
		this.bunifuCustomLabel15.Location = new Point(88, 143);
		this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
		this.bunifuCustomLabel15.Size = new Size(86, 15);
		this.bunifuCustomLabel15.TabIndex = 118;
		this.bunifuCustomLabel15.Text = "Reset Settings";
		this.bunifuCustomLabel2.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel2, 0);
		this.bunifuCustomLabel2.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel2.ForeColor = Color.Gray;
		this.bunifuCustomLabel2.Location = new Point(8, 110);
		this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		this.bunifuCustomLabel2.Size = new Size(67, 16);
		this.bunifuCustomLabel2.TabIndex = 122;
		this.bunifuCustomLabel2.Text = "Rapid-fire";
		this.modSwitch.BackColor = Color.FromArgb(64, 64, 64);
		this.modSwitch.BorderRadius = 0;
		this.modSwitch.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.modSwitch, 0);
		this.modSwitch.ForeColor = Color.FromArgb(224, 224, 224);
		this.modSwitch.Location = new Point(81, 36);
		this.modSwitch.Name = "modSwitch";
		this.modSwitch.Oncolor = Color.DeepSkyBlue;
		this.modSwitch.Onoffcolor = Color.DarkGray;
		this.modSwitch.Size = new Size(51, 19);
		this.modSwitch.TabIndex = 123;
		this.modSwitch.Textcolor = Color.Transparent;
		this.modSwitch.Value = true;
		this.modSwitch.Click += this.modSwitch_Click;
		this.rapidBtn.ActiveBorderThickness = 1;
		this.rapidBtn.ActiveCornerRadius = 20;
		this.rapidBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.rapidBtn.ActiveForecolor = Color.Black;
		this.rapidBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.rapidBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.rapidBtn.BackgroundImage = (Image)componentResourceManager.GetObject("rapidBtn.BackgroundImage");
		this.rapidBtn.ButtonText = "Assign";
		this.rapidBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.rapidBtn, 0);
		this.rapidBtn.Font = new Font("Century Gothic", 7f);
		this.rapidBtn.ForeColor = Color.DeepSkyBlue;
		this.rapidBtn.IdleBorderThickness = 1;
		this.rapidBtn.IdleCornerRadius = 20;
		this.rapidBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.rapidBtn.IdleForecolor = Color.DeepSkyBlue;
		this.rapidBtn.IdleLineColor = Color.DeepSkyBlue;
		this.rapidBtn.Location = new Point(176, 105);
		this.rapidBtn.Margin = new Padding(3, 4, 3, 4);
		this.rapidBtn.Name = "rapidBtn";
		this.rapidBtn.Size = new Size(61, 31);
		this.rapidBtn.TabIndex = 124;
		this.rapidBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.rapidBtn.Click += this.rapidBtn_Click;
		this.rapidLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.rapidLabel, 0);
		this.rapidLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.rapidLabel.ForeColor = Color.Gray;
		this.rapidLabel.Location = new Point(129, 110);
		this.rapidLabel.Name = "rapidLabel";
		this.rapidLabel.Size = new Size(46, 20);
		this.rapidLabel.TabIndex = 125;
		this.rapidLabel.Text = "TAB";
		this.rapidLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.suspendModifier.AutoSize = true;
		this.suspendModifier.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.suspendModifier, 0);
		this.suspendModifier.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.suspendModifier.ForeColor = Color.Gray;
		this.suspendModifier.Location = new Point(91, 85);
		this.suspendModifier.Name = "suspendModifier";
		this.suspendModifier.Size = new Size(25, 15);
		this.suspendModifier.TabIndex = 130;
		this.suspendModifier.Text = "Ctrl";
		this.suspendModifier.TextAlign = ContentAlignment.MiddleCenter;
		this.suspendBtn.ActiveBorderThickness = 1;
		this.suspendBtn.ActiveCornerRadius = 20;
		this.suspendBtn.ActiveFillColor = Color.DeepSkyBlue;
		this.suspendBtn.ActiveForecolor = Color.Black;
		this.suspendBtn.ActiveLineColor = Color.DeepSkyBlue;
		this.suspendBtn.BackColor = Color.FromArgb(17, 17, 17);
		this.suspendBtn.BackgroundImage = (Image)componentResourceManager.GetObject("suspendBtn.BackgroundImage");
		this.suspendBtn.ButtonText = "Assign";
		this.suspendBtn.Cursor = Cursors.Hand;
		this.bunifuTransition_0.SetDecoration(this.suspendBtn, 0);
		this.suspendBtn.Font = new Font("Century Gothic", 7f);
		this.suspendBtn.ForeColor = Color.DeepSkyBlue;
		this.suspendBtn.IdleBorderThickness = 1;
		this.suspendBtn.IdleCornerRadius = 20;
		this.suspendBtn.IdleFillColor = Color.FromArgb(17, 17, 17);
		this.suspendBtn.IdleForecolor = Color.DeepSkyBlue;
		this.suspendBtn.IdleLineColor = Color.DeepSkyBlue;
		this.suspendBtn.Location = new Point(176, 79);
		this.suspendBtn.Margin = new Padding(3, 4, 3, 4);
		this.suspendBtn.Name = "suspendBtn";
		this.suspendBtn.Size = new Size(61, 31);
		this.suspendBtn.TabIndex = 127;
		this.suspendBtn.TextAlign = ContentAlignment.MiddleCenter;
		this.suspendBtn.Click += this.suspendBtn_Click;
		this.suspendLabel.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.suspendLabel, 0);
		this.suspendLabel.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.suspendLabel.ForeColor = Color.Gray;
		this.suspendLabel.Location = new Point(129, 83);
		this.suspendLabel.Name = "suspendLabel";
		this.suspendLabel.Size = new Size(46, 20);
		this.suspendLabel.TabIndex = 128;
		this.suspendLabel.Text = "TAB";
		this.suspendLabel.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel10.AutoSize = true;
		this.bunifuCustomLabel10.BackColor = Color.FromArgb(17, 17, 17);
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel10, 0);
		this.bunifuCustomLabel10.Font = new Font("Microsoft Sans Serif", 8.75f);
		this.bunifuCustomLabel10.ForeColor = Color.Gray;
		this.bunifuCustomLabel10.Location = new Point(119, 85);
		this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
		this.bunifuCustomLabel10.Size = new Size(14, 15);
		this.bunifuCustomLabel10.TabIndex = 129;
		this.bunifuCustomLabel10.Text = "+";
		this.bunifuCustomLabel10.Visible = false;
		this.bunifuCustomLabel14.AutoSize = true;
		this.bunifuTransition_0.SetDecoration(this.bunifuCustomLabel14, 0);
		this.bunifuCustomLabel14.Font = new Font("Microsoft Sans Serif", 9.75f);
		this.bunifuCustomLabel14.ForeColor = Color.Gray;
		this.bunifuCustomLabel14.Location = new Point(8, 85);
		this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
		this.bunifuCustomLabel14.Size = new Size(62, 16);
		this.bunifuCustomLabel14.TabIndex = 126;
		this.bunifuCustomLabel14.Text = "Suspend";
		this.bunifuCustomLabel14.Click += this.bunifuCustomLabel14_Click;
		this.timer_0.Interval = 1;
		this.timer_0.Tick += this.timer_0_Tick;
		this.metroToolTip_0.Style = 4;
		this.metroToolTip_0.StyleManager = null;
		this.metroToolTip_0.Theme = 1;
		this.metroToolTip_0.Popup += this.metroToolTip_0_Popup;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(17, 17, 17);
		base.Controls.Add(this.suspendModifier);
		base.Controls.Add(this.suspendBtn);
		base.Controls.Add(this.suspendLabel);
		base.Controls.Add(this.bunifuCustomLabel10);
		base.Controls.Add(this.bunifuCustomLabel14);
		base.Controls.Add(this.rapidBtn);
		base.Controls.Add(this.rapidLabel);
		base.Controls.Add(this.modSwitch);
		base.Controls.Add(this.bunifuCustomLabel2);
		base.Controls.Add(this.bunifuThinButton21);
		base.Controls.Add(this.bunifuCustomLabel15);
		base.Controls.Add(this.nailmodifier);
		base.Controls.Add(this.nailBtn);
		base.Controls.Add(this.naillabel);
		base.Controls.Add(this.bunifuCustomLabel11);
		base.Controls.Add(this.bunifuCustomLabel12);
		base.Controls.Add(this.revolvermodifier);
		base.Controls.Add(this.revolverBtn);
		base.Controls.Add(this.revolverlabel);
		base.Controls.Add(this.bunifuCustomLabel16);
		base.Controls.Add(this.bunifuCustomLabel21);
		base.Controls.Add(this.p250label);
		base.Controls.Add(this.bunifuCustomLabel37);
		base.Controls.Add(this.akLabel);
		base.Controls.Add(this.bunifuCustomLabel35);
		base.Controls.Add(this.pythonmodifier);
		base.Controls.Add(this.pythonBtn);
		base.Controls.Add(this.pythonlabel);
		base.Controls.Add(this.bunifuCustomLabel23);
		base.Controls.Add(this.bunifuCustomLabel24);
		base.Controls.Add(this.barettamodifier);
		base.Controls.Add(this.barettaBtn);
		base.Controls.Add(this.barettalabel);
		base.Controls.Add(this.bunifuCustomLabel27);
		base.Controls.Add(this.p250Btn);
		base.Controls.Add(this.semimodifier);
		base.Controls.Add(this.p250modifier);
		base.Controls.Add(this.semiBtn);
		base.Controls.Add(this.semilabel);
		base.Controls.Add(this.bunifuCustomLabel31);
		base.Controls.Add(this.RandomShitBaretta);
		base.Controls.Add(this.bunifuCustomLabel33);
		base.Controls.Add(this.bunifuCustomLabel34);
		base.Controls.Add(this.m249modifier);
		base.Controls.Add(this.m249Btn);
		base.Controls.Add(this.m249label);
		base.Controls.Add(this.bunifuCustomLabel8);
		base.Controls.Add(this.bunifuCustomLabel9);
		base.Controls.Add(this.thommodifier);
		base.Controls.Add(this.thomBtn);
		base.Controls.Add(this.thomlabel);
		base.Controls.Add(this.bunifuCustomLabel13);
		base.Controls.Add(this.akButton);
		base.Controls.Add(this.lrmodifier);
		base.Controls.Add(this.akmodifierLabel);
		base.Controls.Add(this.lrbutton);
		base.Controls.Add(this.lrlabel);
		base.Controls.Add(this.bunifuCustomLabel17);
		base.Controls.Add(this.bunifuCustomLabel18);
		base.Controls.Add(this.bunifuCustomLabel19);
		base.Controls.Add(this.bunifuCustomLabel20);
		base.Controls.Add(this.bunifuCustomLabel1);
		base.Controls.Add(this.Weapons);
		base.Controls.Add(this.terminateModifier);
		base.Controls.Add(this.terminateBtn);
		base.Controls.Add(this.terminateLabel);
		base.Controls.Add(this.bunifuCustomLabel7);
		base.Controls.Add(this.modifierBtn);
		base.Controls.Add(this.modifierLabel);
		base.Controls.Add(this.bunifuCustomLabel4);
		base.Controls.Add(this.bunifuCustomLabel6);
		this.bunifuTransition_0.SetDecoration(this, 0);
		base.Name = "hotkeys";
		base.Size = new Size(724, 170);
		base.Load += this.hotkeys_Load;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000077 RID: 119
	private bool bool_0;

	// Token: 0x04000078 RID: 120
	public bool bool_1;

	// Token: 0x04000079 RID: 121
	private string string_0 = "";

	// Token: 0x0400007A RID: 122
	private bool bool_2;

	// Token: 0x0400007B RID: 123
	private bool bool_3;

	// Token: 0x0400007C RID: 124
	private IContainer icontainer_0;

	// Token: 0x0400007D RID: 125
	private BunifuCustomLabel bunifuCustomLabel6;

	// Token: 0x0400007E RID: 126
	private BunifuCustomLabel bunifuCustomLabel4;

	// Token: 0x0400007F RID: 127
	private BunifuTransition bunifuTransition_0;

	// Token: 0x04000080 RID: 128
	private BunifuCustomLabel modifierLabel;

	// Token: 0x04000081 RID: 129
	private Timer timer_0;

	// Token: 0x04000082 RID: 130
	private Timer timer_1;

	// Token: 0x04000083 RID: 131
	private BunifuThinButton2 modifierBtn;

	// Token: 0x04000084 RID: 132
	private BunifuCustomLabel terminateModifier;

	// Token: 0x04000085 RID: 133
	private BunifuThinButton2 terminateBtn;

	// Token: 0x04000086 RID: 134
	private BunifuCustomLabel terminateLabel;

	// Token: 0x04000087 RID: 135
	private BunifuCustomLabel bunifuCustomLabel7;

	// Token: 0x04000088 RID: 136
	private BunifuCustomLabel Weapons;

	// Token: 0x04000089 RID: 137
	private BunifuCustomLabel bunifuCustomLabel1;

	// Token: 0x0400008A RID: 138
	private BunifuCustomLabel m249modifier;

	// Token: 0x0400008B RID: 139
	private BunifuThinButton2 m249Btn;

	// Token: 0x0400008C RID: 140
	private BunifuCustomLabel m249label;

	// Token: 0x0400008D RID: 141
	private BunifuCustomLabel bunifuCustomLabel8;

	// Token: 0x0400008E RID: 142
	private BunifuCustomLabel bunifuCustomLabel9;

	// Token: 0x0400008F RID: 143
	private BunifuCustomLabel thommodifier;

	// Token: 0x04000090 RID: 144
	private BunifuThinButton2 thomBtn;

	// Token: 0x04000091 RID: 145
	private BunifuCustomLabel thomlabel;

	// Token: 0x04000092 RID: 146
	private BunifuCustomLabel bunifuCustomLabel13;

	// Token: 0x04000093 RID: 147
	private BunifuThinButton2 akButton;

	// Token: 0x04000094 RID: 148
	private BunifuCustomLabel lrmodifier;

	// Token: 0x04000095 RID: 149
	private BunifuCustomLabel akmodifierLabel;

	// Token: 0x04000096 RID: 150
	private BunifuThinButton2 lrbutton;

	// Token: 0x04000097 RID: 151
	private BunifuCustomLabel lrlabel;

	// Token: 0x04000098 RID: 152
	private BunifuCustomLabel bunifuCustomLabel17;

	// Token: 0x04000099 RID: 153
	private BunifuCustomLabel bunifuCustomLabel18;

	// Token: 0x0400009A RID: 154
	private BunifuCustomLabel bunifuCustomLabel19;

	// Token: 0x0400009B RID: 155
	private BunifuCustomLabel bunifuCustomLabel20;

	// Token: 0x0400009C RID: 156
	private BunifuCustomLabel pythonmodifier;

	// Token: 0x0400009D RID: 157
	private BunifuThinButton2 pythonBtn;

	// Token: 0x0400009E RID: 158
	private BunifuCustomLabel pythonlabel;

	// Token: 0x0400009F RID: 159
	private BunifuCustomLabel bunifuCustomLabel23;

	// Token: 0x040000A0 RID: 160
	private BunifuCustomLabel bunifuCustomLabel24;

	// Token: 0x040000A1 RID: 161
	private BunifuCustomLabel barettamodifier;

	// Token: 0x040000A2 RID: 162
	private BunifuThinButton2 barettaBtn;

	// Token: 0x040000A3 RID: 163
	private BunifuCustomLabel barettalabel;

	// Token: 0x040000A4 RID: 164
	private BunifuCustomLabel bunifuCustomLabel27;

	// Token: 0x040000A5 RID: 165
	private BunifuThinButton2 p250Btn;

	// Token: 0x040000A6 RID: 166
	private BunifuCustomLabel semimodifier;

	// Token: 0x040000A7 RID: 167
	private BunifuCustomLabel p250modifier;

	// Token: 0x040000A8 RID: 168
	private BunifuThinButton2 semiBtn;

	// Token: 0x040000A9 RID: 169
	private BunifuCustomLabel semilabel;

	// Token: 0x040000AA RID: 170
	private BunifuCustomLabel bunifuCustomLabel31;

	// Token: 0x040000AB RID: 171
	private BunifuCustomLabel RandomShitBaretta;

	// Token: 0x040000AC RID: 172
	private BunifuCustomLabel bunifuCustomLabel33;

	// Token: 0x040000AD RID: 173
	private BunifuCustomLabel bunifuCustomLabel34;

	// Token: 0x040000AE RID: 174
	private BunifuCustomLabel akLabel;

	// Token: 0x040000AF RID: 175
	private BunifuCustomLabel bunifuCustomLabel35;

	// Token: 0x040000B0 RID: 176
	private BunifuCustomLabel p250label;

	// Token: 0x040000B1 RID: 177
	private BunifuCustomLabel bunifuCustomLabel37;

	// Token: 0x040000B2 RID: 178
	private BunifuCustomLabel nailmodifier;

	// Token: 0x040000B3 RID: 179
	private BunifuThinButton2 nailBtn;

	// Token: 0x040000B4 RID: 180
	private BunifuCustomLabel naillabel;

	// Token: 0x040000B5 RID: 181
	private BunifuCustomLabel bunifuCustomLabel11;

	// Token: 0x040000B6 RID: 182
	private BunifuCustomLabel bunifuCustomLabel12;

	// Token: 0x040000B7 RID: 183
	private BunifuCustomLabel revolvermodifier;

	// Token: 0x040000B8 RID: 184
	private BunifuThinButton2 revolverBtn;

	// Token: 0x040000B9 RID: 185
	private BunifuCustomLabel revolverlabel;

	// Token: 0x040000BA RID: 186
	private BunifuCustomLabel bunifuCustomLabel16;

	// Token: 0x040000BB RID: 187
	private BunifuCustomLabel bunifuCustomLabel21;

	// Token: 0x040000BC RID: 188
	private BunifuThinButton2 bunifuThinButton21;

	// Token: 0x040000BD RID: 189
	private BunifuCustomLabel bunifuCustomLabel15;

	// Token: 0x040000BE RID: 190
	private Timer timer_2;

	// Token: 0x040000BF RID: 191
	private BunifuCustomLabel bunifuCustomLabel2;

	// Token: 0x040000C0 RID: 192
	private MetroToolTip metroToolTip_0;

	// Token: 0x040000C1 RID: 193
	private BunifuSwitch modSwitch;

	// Token: 0x040000C2 RID: 194
	private BunifuThinButton2 rapidBtn;

	// Token: 0x040000C3 RID: 195
	private BunifuCustomLabel rapidLabel;

	// Token: 0x040000C4 RID: 196
	private BunifuCustomLabel suspendModifier;

	// Token: 0x040000C5 RID: 197
	private BunifuThinButton2 suspendBtn;

	// Token: 0x040000C6 RID: 198
	private BunifuCustomLabel suspendLabel;

	// Token: 0x040000C7 RID: 199
	private BunifuCustomLabel bunifuCustomLabel10;

	// Token: 0x040000C8 RID: 200
	private BunifuCustomLabel bunifuCustomLabel14;
}
