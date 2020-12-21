using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using LowLevelInput.Hooks;
using MetroFramework.Controls;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;

// Token: 0x02000020 RID: 32
public partial class RS6Menu : Form
{
	// Token: 0x060001A4 RID: 420
	[DllImport("User32.dll")]
	public static extern int SetForegroundWindow(int int_21);

	// Token: 0x060001A5 RID: 421 RVA: 0x01031E50 File Offset: 0x01030050
	public RS6Menu(Worker worker_1)
	{
		this.worker_0 = worker_1;
		this.InitializeComponent();
		this.timer_0.Interval = 500;
		this.timer_1.Interval = 500;
		RS6Menu.sett6_0 = new sett6(1);
		RS6Menu.sett6_1 = new sett6(2);
		RS6Menu.sett6_2 = new sett6(3);
		RS6Menu.sett6_3 = new sett6(4);
		RS6Menu.sett6_4 = new sett6(5);
		RS6Menu.sett6_5 = new sett6(6);
		RS6Menu.sett6_6 = new sett6(7);
		RS6Menu.sett6_7 = new sett6(8);
		RS6Menu.sett6_8 = new sett6(9);
		RS6Menu.sett6_9 = new sett6(10);
		this.method_2();
		this.EditButton.BackColor = Color.FromArgb(17, 17, 17);
		this.startButton.BackColor = Color.FromArgb(17, 17, 17);
		this.backBtn.Visible = false;
		this.startButton.Visible = false;
		this.bunifuCustomLabel2.Text = "Welcome " + Settings.Default.Username;
		DateTime date = DateTime.UtcNow.Date;
		DateTime today = DateTime.Today;
		this.container.Controls.Add(RS6Menu.sett6_0);
		this.container.Controls.Add(RS6Menu.sett6_1);
		this.container.Controls.Add(RS6Menu.sett6_2);
		this.container.Controls.Add(RS6Menu.sett6_3);
		this.container.Controls.Add(RS6Menu.sett6_4);
		this.container.Controls.Add(RS6Menu.sett6_5);
		this.container.Controls.Add(RS6Menu.sett6_6);
		this.container.Controls.Add(RS6Menu.sett6_7);
		this.container.Controls.Add(RS6Menu.sett6_8);
		this.container.Controls.Add(RS6Menu.sett6_9);
		this.ProfileTab.Controls.Clear();
		this.ProfileTab.Controls.Add(this.PistolsTab);
		this.ProfileTab.Controls.Add(this.metroTabPage1);
		this.ProfileTab.Controls.Add(this.metroTabPage2);
		this.ProfileTab.Controls.Add(this.metroTabPage3);
		this.ProfileTab.Controls.Add(this.metroTabPage4);
		this.ProfileTab.Controls.Add(this.metroTabPage5);
		this.ProfileTab.Controls.Add(this.metroTabPage6);
		this.ProfileTab.Controls.Add(this.metroTabPage7);
		this.ProfileTab.Controls.Add(this.metroTabPage8);
		this.ProfileTab.Controls.Add(this.metroTabPage9);
		this.ProfileTab.Controls.Add(this.metroTabPage10);
		this.method_1();
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x010298D4 File Offset: 0x01027AD4
	public void method_0()
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x01032170 File Offset: 0x01030370
	public void method_1()
	{
		this.PistolsTab.Text = "Settings";
		this.metroTabPage1.Text = "Profile 1";
		this.metroTabPage2.Text = "Profile 2";
		this.metroTabPage3.Text = "Profile 3";
		this.metroTabPage4.Text = "Profile 4";
		this.metroTabPage5.Text = "Profile 5";
		this.metroTabPage6.Text = "Profile 6";
		this.metroTabPage7.Text = "Profile 7";
		this.metroTabPage8.Text = "Profile 8";
		this.metroTabPage9.Text = "Profile 9";
		this.metroTabPage10.Text = "Profile 10";
		this.ProfileTab.SelectedIndex = 0;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0103223C File Offset: 0x0103043C
	public void method_2()
	{
		HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(Config.Url + "status/RS6.txt").GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		string a = string.Empty;
		using (StreamReader streamReader = new StreamReader(responseStream))
		{
			a = streamReader.ReadToEnd();
		}
		httpWebResponse.Close();
		if (a == "0")
		{
			MessageBox.Show("Selected software is unavailable!", "Error");
			this.worker_0.Shutdown();
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x010322CC File Offset: 0x010304CC
	public void method_3()
	{
		if (Application.MessageLoop)
		{
			Application.Exit();
			return;
		}
		Environment.Exit(1);
	}

	// Token: 0x060001AA RID: 426 RVA: 0x010322EC File Offset: 0x010304EC
	public void method_4()
	{
		this.method_6(false);
		this.bunifuTransition_0.ShowSync(this.hotkeys1, false, null);
		this.backBtn.Visible = true;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x01032320 File Offset: 0x01030520
	public void method_5()
	{
		this.method_6(false);
		this.settings1.method_0();
		this.EditButton.Visible = true;
		this.bunifuTransition_0.ShowSync(this.settings1, false, null);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x01032360 File Offset: 0x01030560
	private void EditButton_Click(object sender, EventArgs e)
	{
		this.method_4();
	}

	// Token: 0x060001AD RID: 429 RVA: 0x01032374 File Offset: 0x01030574
	private void backBtn_Click(object sender, EventArgs e)
	{
		this.method_5();
	}

	// Token: 0x060001AE RID: 430 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void RS6Menu_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x01032388 File Offset: 0x01030588
	private void method_6(bool bool_4)
	{
		this.EditButton.Visible = false;
		this.backBtn.Visible = false;
		this.startButton.Visible = false;
		this.hotkeys1.Visible = false;
		this.settings1.Visible = false;
		RS6Menu.sett6_0.Visible = false;
		RS6Menu.sett6_1.Visible = false;
		RS6Menu.sett6_2.Visible = false;
		RS6Menu.sett6_3.Visible = false;
		RS6Menu.sett6_4.Visible = false;
		RS6Menu.sett6_5.Visible = false;
		RS6Menu.sett6_6.Visible = false;
		RS6Menu.sett6_7.Visible = false;
		RS6Menu.sett6_8.Visible = false;
		RS6Menu.sett6_9.Visible = false;
		if (bool_4)
		{
			this.startButton.Visible = true;
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void settings1_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x01032450 File Offset: 0x01030650
	private void ProfileTab_SelectedIndexChanged(object sender, EventArgs e)
	{
		List<Tuple<sett6, string>> list = new List<Tuple<sett6, string>>();
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_0, "1"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_1, "2"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_2, "3"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_3, "4"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_4, "5"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_5, "6"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_6, "7"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_7, "8"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_8, "9"));
		list.Add(new Tuple<sett6, string>(RS6Menu.sett6_9, "10"));
		if (!(this.ProfileTab.SelectedIndex.ToString() == "0"))
		{
			foreach (Tuple<sett6, string> tuple in list)
			{
				if (this.ProfileTab.SelectedIndex.ToString() == tuple.Item2)
				{
					this.method_6(true);
					this.bunifuTransition_0.ShowSync(tuple.Item1, false, null);
				}
			}
			return;
		}
		this.method_5();
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_7(object sender, EventArgs e)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x010325D0 File Offset: 0x010307D0
	private void bunifuImageButton1_Click(object sender, EventArgs e)
	{
		this.worker_0.Shutdown();
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x010325E8 File Offset: 0x010307E8
	private void startButton_Click(object sender, EventArgs e)
	{
		this.int_3 = 0;
		foreach (sett6 sett in new List<sett6>
		{
			RS6Menu.sett6_0,
			RS6Menu.sett6_1,
			RS6Menu.sett6_2,
			RS6Menu.sett6_3,
			RS6Menu.sett6_4,
			RS6Menu.sett6_5,
			RS6Menu.sett6_6,
			RS6Menu.sett6_7,
			RS6Menu.sett6_8,
			RS6Menu.sett6_9
		})
		{
			if (sett.Visible)
			{
				this.int_3 = sett.method_1() - 1;
			}
		}
		if (this.method_8())
		{
			if (!this.bool_0)
			{
				new Thread(new ThreadStart(this.method_11)).Start();
				Thread.Sleep(100);
			}
			if (Settings.Default.autohide)
			{
				base.Hide();
				this.timer_0.Start();
			}
			else
			{
				this.timer_1.Start();
			}
			this.bool_0 = !this.bool_0;
			if (this.bool_0)
			{
				this.startButton.ButtonText = "Stop";
				new Thread(new ThreadStart(this.method_12)).Start();
				return;
			}
			this.startButton.ButtonText = "Start";
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0103276C File Offset: 0x0103096C
	public bool method_8()
	{
		if (this.int_3 >= 0 && this.int_3 <= 9)
		{
			if (Settings.Default.Terminate == "TAB")
			{
				Settings.Default.TerminateKey = (Keys)Enum.Parse(typeof(Keys), "TAB", true);
			}
			Settings.Default.Save();
			return true;
		}
		return false;
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060001B6 RID: 438 RVA: 0x010327D4 File Offset: 0x010309D4
	// (set) Token: 0x060001B7 RID: 439 RVA: 0x010327E8 File Offset: 0x010309E8
	public static bool Boolean_0 { get; set; }

	// Token: 0x060001B8 RID: 440 RVA: 0x010327FC File Offset: 0x010309FC
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (!Settings.Default.autohide && !this.bool_0 && base.Visible)
		{
			if (!this.bool_0)
			{
				this.startButton.ButtonText = "Start";
			}
			else
			{
				this.startButton.ButtonText = "Stop";
			}
			this.timer_1.Stop();
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0103285C File Offset: 0x01030A5C
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Settings.Default.autohide && !this.bool_0 && !base.Visible)
		{
			base.Show();
			if (this.bool_0)
			{
				this.startButton.ButtonText = "Stop";
			}
			else
			{
				this.startButton.ButtonText = "Start";
			}
			this.timer_0.Stop();
			RS6Menu.SetForegroundWindow(this.method_13().ToInt32());
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x010328D4 File Offset: 0x01030AD4
	public static void smethod_0()
	{
		if (RS6Menu.int_9 > 9)
		{
			RS6Menu.int_9 = 0;
		}
		switch (RS6Menu.int_9)
		{
		case 0:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("QUs=")) + " : " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.akrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_1).Play();
				return;
			}
			break;
		case 1:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("TFIzMDA=")) + " : " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.lrrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_2).Play();
				return;
			}
			break;
		case 2:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("VEhPTVNPTg==")) + " : " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.thompsonrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_3).Play();
				return;
			}
			break;
		case 3:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("TTI0OQ==")) + " : " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.m249rapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_5).Play();
				return;
			}
			break;
		case 4:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("UDI1MA==")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.p250rapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_6).Play();
				return;
			}
			break;
		case 5:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("U0VNSVJJRkxF")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.semirapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_7).Play();
				return;
			}
			break;
		case 6:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("QmFyZXR0YQ==")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.barettarapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_8).Play();
				return;
			}
			break;
		case 7:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("UHl0aG9u")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.pythonrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_9).Play();
				return;
			}
			break;
		case 8:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("UmV2b2x2ZXI=")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.revolverrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_10).Play();
				return;
			}
			break;
		case 9:
			RS6Menu.string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("TmFpbGd1bg==")) + ": " + RS6Menu.bool_2.ToString();
			if (Settings.Default.sound)
			{
				RS6Menu.int_8 = Settings.Default.nailgunrapid;
				new SoundPlayer(Class24.UnmanagedMemoryStream_0).Play();
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x01032CAC File Offset: 0x01030EAC
	public static void smethod_1()
	{
		RS6Menu.int_11 = 120;
		RS6Menu.int_12 = 120;
		RS6Menu.int_20 = 120;
		RS6Menu.int_14 = 120;
		RS6Menu.int_16 = 120;
		RS6Menu.int_19 = 120;
		RS6Menu.int_13 = 120;
		RS6Menu.int_17 = 120;
		RS6Menu.int_18 = 120;
		RS6Menu.int_15 = 120;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x01032D00 File Offset: 0x01030F00
	public static int smethod_2()
	{
		int num = new Random().Next(0, 4);
		int result;
		if (num != 0)
		{
			if (num == 1)
			{
				result = 8;
			}
			else
			{
				result = 6;
			}
		}
		else
		{
			result = 4;
		}
		return result;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x01032D30 File Offset: 0x01030F30
	public static int smethod_3(int int_21)
	{
		List<int> list = new List<int>();
		for (int i = 10; i > 0; i--)
		{
			if (int_21 % i == 0 && i % 2 == 0)
			{
				list.Add(i);
			}
		}
		if (list.Count != 0)
		{
			if (list.Count != 1)
			{
				return list[RS6Menu.random_0.Next(0, list.Count - 1)];
			}
		}
		return RS6Menu.random_0.Next(10, 20);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x01032D9C File Offset: 0x01030F9C
	public static int smethod_4(int int_21)
	{
		List<int> list = new List<int>();
		for (int i = 20; i >= 10; i--)
		{
			if (i % int_21 == 0)
			{
				list.Add(i);
			}
		}
		if (list.Count != 0)
		{
			return list[RS6Menu.random_0.Next(0, list.Count - 1)];
		}
		return RS6Menu.random_0.Next(10, 20);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x01032DFC File Offset: 0x01030FFC
	public static void smethod_5(int int_21, int int_22, int int_23, int int_24)
	{
		int num = RS6Menu.smethod_3(int_24);
		int num2 = RS6Menu.smethod_4(num);
		int num3 = 0;
		int num4 = 0;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < num / 2 - 1; i++)
		{
			int num5 = RS6Menu.random_0.Next(-1, 3);
			int num6 = RS6Menu.random_0.Next(-1, 3);
			num3 += num5;
			num4 += num6;
			list.Add(num5);
			list2.Add(num6);
		}
		int num7 = 0;
		while (num7 < num / 2 && Class6.smethod_2(Keys.LButton) && Class6.smethod_2(Keys.RButton))
		{
			if (num7 != num / 2 - 1)
			{
				Class6.smethod_0(int_24 / num + list[num7], int_24 * 3 / num + list2[num7]);
				Thread.Sleep(num2 / num);
			}
			else
			{
				Class6.smethod_0(int_24 / num - num3, int_24 * 3 / num - num4);
				Thread.Sleep(num2 / num);
			}
			num7++;
		}
		int num8 = 0;
		while (num8 < num / 2 && Class6.smethod_2(Keys.LButton) && Class6.smethod_2(Keys.RButton))
		{
			if (num8 == num / 2 - 1)
			{
				Class6.smethod_0(-1 * (int_24 / num + num3), -1 * (int_24 * 3 / num + num4));
				Thread.Sleep(num2 / num);
			}
			else
			{
				Class6.smethod_0(-1 * (int_24 / num - list[num8]), -1 * (int_24 * 3 / num - list2[num8]));
				Thread.Sleep(num2 / num);
			}
			num8++;
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x01032F5C File Offset: 0x0103115C
	public static void smethod_6(int int_21, int int_22, int int_23)
	{
		int num = 0;
		int num2 = 0;
		int num3 = RS6Menu.smethod_2();
		if (Settings.Default.rapidKey.ToString() == Keys.LButton.ToString() && Settings.Default.rapid)
		{
			int_21 -= RS6Menu.int_8 * 2;
		}
		else if (Settings.Default.rapidKey.ToString() != Keys.LButton.ToString() && Settings.Default.rapid)
		{
			RS6Menu.smethod_8(true);
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (int_23 < num3 && int_23 == 0)
		{
			num3 = 1;
		}
		else if (int_23 < num3)
		{
			num3 = int_23;
		}
		Random random = new Random();
		int num4 = Convert.ToInt32(int_22 / num3);
		int num5 = Convert.ToInt32(int_23 / num3);
		for (int i = 0; i < num3 - 1; i++)
		{
			int num6 = random.Next(-2, 2);
			int num7 = random.Next(-2, -2);
			num += num6;
			num2 += num7;
			list.Add(num6);
			list2.Add(num7);
		}
		int num8 = 0;
		while (num8 < num3 && Class6.smethod_2(Keys.LButton))
		{
			if (num8 != num3 - 1)
			{
				Class6.smethod_0((num4 + list[num8]) / num3, (num5 + list2[num8]) / num3);
				Thread.Sleep(int_21 / num3);
			}
			else
			{
				Class6.smethod_0((num4 - num) / num3 + (int_22 - num4 * num3), (num5 - num2) / num3 + (int_23 - num5 * num3));
				Thread.Sleep(int_21 / num3);
			}
			num8++;
		}
		RS6Menu.smethod_7();
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x010330F4 File Offset: 0x010312F4
	private static void smethod_7()
	{
		if (Class6.smethod_2(Keys.LButton) && Settings.Default.rapidKey.ToString() == Keys.LButton.ToString() && Settings.Default.rapid)
		{
			int num = new Random().Next(0, RS6Menu.int_8);
			Class6.smethod_1(4);
			Thread.Sleep(RS6Menu.int_8 + num);
			Class6.smethod_1(2);
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0103316C File Offset: 0x0103136C
	public static void smethod_8(bool bool_4)
	{
		if (bool_4 && !Class6.smethod_2(Keys.LButton))
		{
			return;
		}
		if (Settings.Default.rapid && Class6.smethod_2(Settings.Default.rapidKey))
		{
			Class6.smethod_1(2);
			Thread.Sleep(RS6Menu.int_8);
			if (!bool_4)
			{
				if (Settings.Default.rapidKey != Keys.LButton)
				{
					Class6.smethod_1(4);
					Thread.Sleep(RS6Menu.int_8);
				}
			}
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x010331D4 File Offset: 0x010313D4
	private void method_9(VirtualKeyCode virtualKeyCode_0, KeyState keyState_0)
	{
		if (RS6Menu.Boolean_0)
		{
			if ((keyState_0 == 2 || keyState_0 == 3) && virtualKeyCode_0 == Settings.Default.TerminateKey)
			{
				RS6Menu.bool_2 = !RS6Menu.bool_2;
				this.bool_0 = !this.bool_0;
				RS6Menu.string_1 = RS6Menu.string_1.Split(new char[]
				{
					':'
				})[0].Replace(" ", string.Empty) + " : " + RS6Menu.bool_2.ToString();
				RS6Menu.int_9 = 999;
				return;
			}
			if ((keyState_0 == 2 || keyState_0 == 3) && virtualKeyCode_0 == Settings.Default.suspendKey)
			{
				RS6Menu.bool_2 = !RS6Menu.bool_2;
				return;
			}
			if ((keyState_0 == 2 || keyState_0 == 3) && virtualKeyCode_0 == Settings.Default.NextWeaponKey)
			{
				RS6Menu.int_9++;
				return;
			}
			if ((keyState_0 == 2 || keyState_0 == 3) && virtualKeyCode_0 == Settings.Default.akKey)
			{
				RS6Menu.int_9 = 0;
				return;
			}
			if (keyState_0 != 2)
			{
				if (keyState_0 != 3)
				{
					goto IL_F7;
				}
			}
			if (virtualKeyCode_0 == Settings.Default.lrKey)
			{
				RS6Menu.int_9 = 1;
				return;
			}
			IL_F7:
			if (keyState_0 != 2)
			{
				if (keyState_0 != 3)
				{
					goto IL_117;
				}
			}
			if (virtualKeyCode_0 == Settings.Default.thompsonKey)
			{
				RS6Menu.int_9 = 2;
				return;
			}
			IL_117:
			if (keyState_0 != 2)
			{
				if (keyState_0 != 3)
				{
					goto IL_133;
				}
			}
			if (virtualKeyCode_0 == Settings.Default.m249Key)
			{
				RS6Menu.int_9 = 3;
				return;
			}
			IL_133:
			if (keyState_0 == 2 || keyState_0 == 3)
			{
				if (virtualKeyCode_0 == Settings.Default.p250Key)
				{
					RS6Menu.int_9 = 4;
					return;
				}
			}
			if (keyState_0 == 2 || keyState_0 == 3)
			{
				if (virtualKeyCode_0 == Settings.Default.semiKey)
				{
					RS6Menu.int_9 = 5;
					return;
				}
			}
			if (keyState_0 != 2)
			{
				if (keyState_0 != 3)
				{
					goto IL_18F;
				}
			}
			if (virtualKeyCode_0 == Settings.Default.barettaKey)
			{
				RS6Menu.int_9 = 6;
				return;
			}
			IL_18F:
			if (keyState_0 == 2 || keyState_0 == 3)
			{
				if (virtualKeyCode_0 == Settings.Default.pythonKey)
				{
					RS6Menu.int_9 = 7;
					return;
				}
			}
			if (keyState_0 != 2)
			{
				if (keyState_0 != 3)
				{
					goto IL_1CD;
				}
			}
			if (virtualKeyCode_0 == Settings.Default.revolverKey)
			{
				RS6Menu.int_9 = 8;
				return;
			}
			IL_1CD:
			if (keyState_0 == 2 || keyState_0 == 3)
			{
				if (virtualKeyCode_0 == Settings.Default.nailgunKey)
				{
					RS6Menu.int_9 = 9;
				}
			}
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x010298D4 File Offset: 0x01027AD4
	private static void smethod_9(VirtualKeyCode virtualKeyCode_0, KeyState keyState_0)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x010333EC File Offset: 0x010315EC
	public void method_10(int int_21)
	{
		RS6Menu.Boolean_0 = false;
		RS6Menu.int_8 = Settings.Default.rapidFireValue;
		RS6Menu.int_9 = int_21;
		RS6Menu.int_10 = int_21 - 1;
		RS6Menu.bool_2 = true;
		bool flag = false;
		List<VirtualKeyCode> list = new List<VirtualKeyCode>
		{
			Settings.Default.TerminateKey,
			Settings.Default.suspendKey,
			Settings.Default.NextWeaponKey,
			Settings.Default.CrosshairKey,
			Settings.Default.akKey,
			Settings.Default.lrKey,
			Settings.Default.thompsonKey,
			Settings.Default.m249Key,
			Settings.Default.p250Key,
			Settings.Default.semiKey,
			Settings.Default.barettaKey,
			Settings.Default.pythonKey,
			Settings.Default.revolverKey,
			Settings.Default.nailgunKey
		};
		foreach (VirtualKeyCode virtualKeyCode in list)
		{
			RS6Menu.inputManager_0.UnregisterEvent(virtualKeyCode, new InputManager.KeyStateChangedEventHandler(this.method_9));
		}
		foreach (VirtualKeyCode virtualKeyCode2 in list)
		{
			RS6Menu.inputManager_0.RegisterEvent(virtualKeyCode2, new InputManager.KeyStateChangedEventHandler(this.method_9));
		}
		if (Settings.Default.Modifier == "")
		{
			RS6Menu.Boolean_0 = true;
		}
		else
		{
			RS6Menu.inputManager_0.OnKeyboardEvent += new LowLevelKeyboardHook.KeyboardEventHandler(RS6Menu.Class5.<>9.method_0);
		}
		new Random();
		int num = 142;
		RS6Menu.smethod_1();
		if (RS6Menu.int_9 == 999)
		{
			foreach (VirtualKeyCode virtualKeyCode3 in list)
			{
				RS6Menu.inputManager_0.UnregisterEvent(virtualKeyCode3, new InputManager.KeyStateChangedEventHandler(this.method_9));
			}
			this.bool_0 = false;
			if (num != RS6Menu.int_12)
			{
				num = RS6Menu.int_12;
			}
			RS6Menu.smethod_6(num, 0, 0);
			Thread.Sleep(5);
			return;
		}
		while (this.bool_0)
		{
			if (RS6Menu.int_9 != RS6Menu.int_10)
			{
				goto IL_284;
			}
			if (RS6Menu.int_9 == 999)
			{
				goto IL_284;
			}
			IL_2A4:
			new Random(DateTime.Now.Millisecond).Next(4, 5);
			if (Settings.Default.rapidKey != Keys.LButton && RS6Menu.bool_2)
			{
				RS6Menu.smethod_8(false);
			}
			if (Class6.smethod_2(Keys.LButton) && !flag && RS6Menu.bool_2)
			{
				if (RS6Menu.string_1.StartsWith("AK"))
				{
					if (num != RS6Menu.int_11)
					{
						num = RS6Menu.int_11;
					}
					while (Class6.smethod_2(Keys.LButton))
					{
						if (Settings.Default.rageSwitchAK)
						{
							RS6Menu.smethod_5(num, Settings.Default.aksensX, Settings.Default.aksensY, Settings.Default.akfire);
						}
						else
						{
							RS6Menu.smethod_6(num, 0, Settings.Default.aksensY);
						}
					}
					flag = true;
				}
				else if (!RS6Menu.string_1.StartsWith("LR300"))
				{
					if (!RS6Menu.string_1.StartsWith("THOMSON"))
					{
						if (!RS6Menu.string_1.StartsWith("M249"))
						{
							if (!RS6Menu.string_1.StartsWith("P250"))
							{
								if (RS6Menu.string_1.StartsWith("SEMIRIFLE"))
								{
									if (num != RS6Menu.int_19)
									{
										num = RS6Menu.int_19;
									}
									while (Class6.smethod_2(Keys.LButton))
									{
										if (!Settings.Default.rageSwitchSEMI)
										{
											RS6Menu.smethod_6(num, 0, Settings.Default.semisensY);
										}
										else
										{
											RS6Menu.smethod_5(num, Settings.Default.semisensX, Settings.Default.semisensY, Settings.Default.semifire);
										}
									}
								}
								else if (!RS6Menu.string_1.StartsWith("Baretta"))
								{
									if (!RS6Menu.string_1.StartsWith("Python"))
									{
										if (!RS6Menu.string_1.StartsWith("Revolver"))
										{
											if (RS6Menu.string_1.StartsWith("Nailgun"))
											{
												if (num != RS6Menu.int_15)
												{
													num = RS6Menu.int_15;
												}
												while (Class6.smethod_2(Keys.LButton))
												{
													if (Settings.Default.rageSwitchNAILGUN)
													{
														RS6Menu.smethod_5(num, Settings.Default.nailgunsensX, Settings.Default.nailgunsensY, Settings.Default.nailgunfire);
													}
													else
													{
														RS6Menu.smethod_6(num, 0, Settings.Default.nailgunsensY);
													}
												}
											}
											else
											{
												Application.Exit();
											}
										}
										else
										{
											if (num != RS6Menu.int_18)
											{
												num = RS6Menu.int_18;
											}
											while (Class6.smethod_2(Keys.LButton))
											{
												if (!Settings.Default.rageSwitchREVOLVER)
												{
													RS6Menu.smethod_6(num, 0, Settings.Default.revolversensY);
												}
												else
												{
													RS6Menu.smethod_5(num, Settings.Default.revolversensX, Settings.Default.revolversensY, Settings.Default.revolverfire);
												}
											}
										}
									}
									else
									{
										if (num != RS6Menu.int_17)
										{
											num = RS6Menu.int_17;
										}
										while (Class6.smethod_2(Keys.LButton))
										{
											if (!Settings.Default.rageSwitchPYTHON)
											{
												RS6Menu.smethod_6(num, 0, Settings.Default.pythonsensY);
											}
											else
											{
												RS6Menu.smethod_5(num, Settings.Default.pythonsensX, Settings.Default.pythonsensY, Settings.Default.pythonfire);
											}
										}
									}
								}
								else
								{
									if (num != RS6Menu.int_13)
									{
										num = RS6Menu.int_13;
									}
									while (Class6.smethod_2(Keys.LButton))
									{
										if (Settings.Default.rageSwitchBARETTA)
										{
											RS6Menu.smethod_5(num, Settings.Default.barettasensX, Settings.Default.barettasensY, Settings.Default.barettafire);
										}
										else
										{
											RS6Menu.smethod_6(num, 0, Settings.Default.barettasensY);
										}
									}
								}
							}
							else
							{
								if (num != RS6Menu.int_16)
								{
									num = RS6Menu.int_16;
								}
								while (Class6.smethod_2(Keys.LButton))
								{
									if (Settings.Default.rageSwitchP250)
									{
										RS6Menu.smethod_5(num, Settings.Default.p250sensX, Settings.Default.p250sensY, Settings.Default.p250fire);
									}
									else
									{
										RS6Menu.smethod_6(num, 0, Settings.Default.p250sensY);
									}
								}
							}
						}
						else
						{
							if (num != RS6Menu.int_14)
							{
								num = RS6Menu.int_14;
							}
							while (Class6.smethod_2(Keys.LButton))
							{
								if (Settings.Default.rageSwitchM249)
								{
									RS6Menu.smethod_5(num, Settings.Default.m249sensX, Settings.Default.m249sensY, Settings.Default.m249fire);
								}
								else
								{
									RS6Menu.smethod_6(num, 0, Settings.Default.m249sensY);
								}
							}
						}
					}
					else
					{
						if (num != RS6Menu.int_20)
						{
							num = RS6Menu.int_20;
						}
						while (Class6.smethod_2(Keys.LButton))
						{
							if (Settings.Default.rageSwitchTHOMPSON)
							{
								RS6Menu.smethod_5(num, Settings.Default.thompsonsensX, Settings.Default.thompsonsensY, Settings.Default.thompsonfire);
							}
							else
							{
								RS6Menu.smethod_6(num, 0, Settings.Default.thompsonsensY);
							}
						}
					}
				}
				else
				{
					if (num != RS6Menu.int_12)
					{
						num = RS6Menu.int_12;
					}
					while (Class6.smethod_2(Keys.LButton))
					{
						if (!Settings.Default.rageSwitchLR)
						{
							RS6Menu.smethod_6(num, 0, Settings.Default.lrsensY);
						}
						else
						{
							RS6Menu.smethod_5(num, Settings.Default.lrsensX, Settings.Default.lrsensY, Settings.Default.lrfire);
						}
					}
				}
			}
			if (flag && !Class6.smethod_2(Keys.LButton))
			{
				flag = false;
			}
			Thread.Sleep(5);
			continue;
			IL_284:
			if (RS6Menu.int_9 == 999)
			{
				foreach (VirtualKeyCode virtualKeyCode4 in list)
				{
					RS6Menu.inputManager_0.UnregisterEvent(virtualKeyCode4, new InputManager.KeyStateChangedEventHandler(this.method_9));
				}
				this.bool_0 = false;
				if (num != RS6Menu.int_12)
				{
					num = RS6Menu.int_12;
				}
				RS6Menu.smethod_6(num, 0, 0);
				Thread.Sleep(5);
				return;
			}
			RS6Menu.int_10 = RS6Menu.int_9;
			RS6Menu.smethod_0();
			goto IL_2A4;
		}
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x01033C34 File Offset: 0x01031E34
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x010352C4 File Offset: 0x010334C4
	[CompilerGenerated]
	private void method_11()
	{
		this.method_10(999);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x010352DC File Offset: 0x010334DC
	[CompilerGenerated]
	private void method_12()
	{
		this.method_10(this.int_3);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x010352F8 File Offset: 0x010334F8
	IntPtr method_13()
	{
		return base.Handle;
	}

	// Token: 0x040000E2 RID: 226
	public static sett6 sett6_0;

	// Token: 0x040000E3 RID: 227
	public static sett6 sett6_1;

	// Token: 0x040000E4 RID: 228
	public static sett6 sett6_2;

	// Token: 0x040000E5 RID: 229
	public static sett6 sett6_3;

	// Token: 0x040000E6 RID: 230
	public static sett6 sett6_4;

	// Token: 0x040000E7 RID: 231
	public static sett6 sett6_5;

	// Token: 0x040000E8 RID: 232
	public static sett6 sett6_6;

	// Token: 0x040000E9 RID: 233
	public static sett6 sett6_7;

	// Token: 0x040000EA RID: 234
	public static sett6 sett6_8;

	// Token: 0x040000EB RID: 235
	public static sett6 sett6_9;

	// Token: 0x040000EC RID: 236
	private bool bool_0;

	// Token: 0x040000ED RID: 237
	private static Random random_0 = new Random();

	// Token: 0x040000EE RID: 238
	private Worker worker_0;

	// Token: 0x040000EF RID: 239
	protected int int_0 = 1;

	// Token: 0x040000F0 RID: 240
	protected int int_1 = 2;

	// Token: 0x040000F1 RID: 241
	protected int int_2;

	// Token: 0x040000F2 RID: 242
	protected int int_3;

	// Token: 0x040000F3 RID: 243
	private string string_0 = string.Empty;

	// Token: 0x040000F4 RID: 244
	public static InputManager inputManager_0 = new InputManager(false, true);

	// Token: 0x040000F5 RID: 245
	public static int int_4 = 0;

	// Token: 0x040000F6 RID: 246
	public static int int_5 = 10;

	// Token: 0x040000F7 RID: 247
	public static int int_6 = 0;

	// Token: 0x040000F8 RID: 248
	public static int int_7 = 0;

	// Token: 0x040000F9 RID: 249
	public static int int_8 = 0;

	// Token: 0x040000FA RID: 250
	[CompilerGenerated]
	private static bool bool_1;

	// Token: 0x040000FB RID: 251
	public static string string_1 = Encoding.UTF8.GetString(Convert.FromBase64String("QUs=")) + " : True";

	// Token: 0x040000FC RID: 252
	public static int int_9 = 0;

	// Token: 0x040000FD RID: 253
	public static int int_10 = 0;

	// Token: 0x040000FE RID: 254
	public static bool bool_2 = true;

	// Token: 0x040000FF RID: 255
	public static bool bool_3 = false;

	// Token: 0x04000100 RID: 256
	public static int int_11;

	// Token: 0x04000101 RID: 257
	public static int int_12;

	// Token: 0x04000102 RID: 258
	public static int int_13;

	// Token: 0x04000103 RID: 259
	public static int int_14;

	// Token: 0x04000104 RID: 260
	public static int int_15;

	// Token: 0x04000105 RID: 261
	public static int int_16;

	// Token: 0x04000106 RID: 262
	public static int int_17;

	// Token: 0x04000107 RID: 263
	public static int int_18;

	// Token: 0x04000108 RID: 264
	public static int int_19;

	// Token: 0x04000109 RID: 265
	public static int int_20;

	// Token: 0x02000021 RID: 33
	[Flags]
	public enum GEnum5
	{
		// Token: 0x04000128 RID: 296
		Alt = 1,
		// Token: 0x04000129 RID: 297
		Control = 2,
		// Token: 0x0400012A RID: 298
		Shift = 4,
		// Token: 0x0400012B RID: 299
		Windows = 8,
		// Token: 0x0400012C RID: 300
		NoRepeat = 16384
	}

	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	[Serializable]
	private sealed class Class5
	{
		// Token: 0x06000216 RID: 534 RVA: 0x01035324 File Offset: 0x01033524
		internal void method_0(VirtualKeyCode virtualKeyCode_0, KeyState keyState_0)
		{
			VirtualKeyCode virtualKeyCode = 162;
			if (Settings.Default.ModifierKey == 4)
			{
				virtualKeyCode = 16;
			}
			if (Settings.Default.ModifierKey == 1)
			{
				virtualKeyCode = 18;
			}
			if (RS6Menu.Class5.smethod_0(virtualKeyCode_0.ToString(), virtualKeyCode.ToString()))
			{
				if (keyState_0 != 2)
				{
					if (keyState_0 != 3)
					{
						RS6Menu.Boolean_0 = false;
						return;
					}
				}
				RS6Menu.Boolean_0 = true;
				return;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x01035394 File Offset: 0x01033594
		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		// Token: 0x0400012D RID: 301
		public static readonly RS6Menu.Class5 <>9 = new RS6Menu.Class5();

		// Token: 0x0400012E RID: 302
		public static LowLevelKeyboardHook.KeyboardEventHandler <>9__75_0;
	}
}
