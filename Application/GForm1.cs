using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using tcp_moe_client.Classes;

// Token: 0x0200006D RID: 109
public class GForm1 : MetroForm
{
	// Token: 0x06000800 RID: 2048
	[DllImport("user32.dll")]
	private static extern void mouse_event(uint uint_12, int int_9, int int_10, uint uint_13, uint uint_14);

	// Token: 0x06000801 RID: 2049
	[DllImport("user32.dll")]
	private static extern ushort GetAsyncKeyState(int int_9);

	// Token: 0x06000803 RID: 2051 RVA: 0x01050354 File Offset: 0x0104E554
	private void method_0()
	{
		this.gclass19_0 = new GClass19(Directory.GetCurrentDirectory() + "\\Config.ini");
		this.gclass19_0.method_0("Global", "RCSHotKey", Keys.RButton.ToString());
		this.gclass19_0.method_0("Global", "RFHotKey", Keys.MButton.ToString());
		this.gclass19_0.method_0("AK47", "HotKey", Keys.F1.ToString());
		this.gclass19_0.method_0("AK47", "RCSDelay", 150.ToString());
		this.gclass19_0.method_0("AK47", "RFDelay", 30.ToString());
		this.gclass19_0.method_0("AR15", "HotKey", Keys.F2.ToString());
		this.gclass19_0.method_0("AR15", "RCSDelay", 170.ToString());
		this.gclass19_0.method_0("AR15", "RFDelay", 30.ToString());
		this.gclass19_0.method_0("Pistols", "HotKey", Keys.F3.ToString());
		this.gclass19_0.method_0("Pistols", "RCSDelay", 170.ToString());
		this.gclass19_0.method_0("Pistols", "RFDelay", 30.ToString());
		this.gclass19_0.method_0("Suspend", "HotKey", Keys.F11.ToString());
		this.gclass19_0.method_0("Other", "SoundOnSwitch", true.ToString());
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x01050538 File Offset: 0x0104E738
	private void method_1()
	{
		this.gclass19_0 = new GClass19(Directory.GetCurrentDirectory() + "\\Config.ini");
		this.gclass19_0.method_0("Global", "RCSHotKey", this.keys_0.ToString());
		this.gclass19_0.method_0("Global", "RFHotKey", this.keys_1.ToString());
		this.gclass19_0.method_0("AK47", "HotKey", this.keys_2.ToString());
		this.gclass19_0.method_0("AK47", "RCSDelay", this.int_0.ToString());
		this.gclass19_0.method_0("AK47", "RFDelay", this.int_1.ToString());
		this.gclass19_0.method_0("AR15", "HotKey", this.keys_3.ToString());
		this.gclass19_0.method_0("AR15", "RCSDelay", this.int_2.ToString());
		this.gclass19_0.method_0("AR15", "RFDelay", this.int_3.ToString());
		this.gclass19_0.method_0("Pistols", "HotKey", this.keys_4.ToString());
		this.gclass19_0.method_0("Pistols", "RCSDelay", this.int_4.ToString());
		this.gclass19_0.method_0("Pistols", "RFDelay", this.int_5.ToString());
		this.gclass19_0.method_0("Suspend", "HotKey", this.keys_5.ToString());
		this.gclass19_0.method_0("Other", "SoundOnSwitch", this.bool_2.ToString());
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x01050724 File Offset: 0x0104E924
	private void method_2()
	{
		try
		{
			this.gclass19_0 = new GClass19(Directory.GetCurrentDirectory() + "\\Config.ini");
			Enum.TryParse<Keys>(this.gclass19_0.method_1("Global", "RCSHotKey"), out this.keys_0);
			Enum.TryParse<Keys>(this.gclass19_0.method_1("Global", "RFHotKey"), out this.keys_1);
			Enum.TryParse<Keys>(this.gclass19_0.method_1("AK47", "HotKey"), out this.keys_2);
			this.int_0 = Convert.ToInt32(this.gclass19_0.method_1("AK47", "RCSDelay"));
			this.int_1 = Convert.ToInt32(this.gclass19_0.method_1("AK47", "RFDelay"));
			Enum.TryParse<Keys>(this.gclass19_0.method_1("AR15", "HotKey"), out this.keys_3);
			this.int_2 = Convert.ToInt32(this.gclass19_0.method_1("AR15", "RCSDelay"));
			this.int_3 = Convert.ToInt32(this.gclass19_0.method_1("AR15", "RFDelay"));
			Enum.TryParse<Keys>(this.gclass19_0.method_1("Pistols", "HotKey"), out this.keys_4);
			this.int_4 = Convert.ToInt32(this.gclass19_0.method_1("Pistols", "RCSDelay"));
			this.int_5 = Convert.ToInt32(this.gclass19_0.method_1("Pistols", "RFDelay"));
			Enum.TryParse<Keys>(this.gclass19_0.method_1("Suspend", "HotKey"), out this.keys_5);
			this.bool_2 = Convert.ToBoolean(this.gclass19_0.method_1("Other", "SoundOnSwitch"));
		}
		catch (Exception)
		{
			MetroMessageBox.Show(this, "Config file is broken.\nDeleting config and loading defaults.", "XenosZ1", MessageBoxButtons.OK, MessageBoxIcon.Hand, 150);
			this.method_0();
			this.method_2();
		}
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x01050938 File Offset: 0x0104EB38
	public void method_3()
	{
		this.bool_0 = false;
		base.Invoke(new MethodInvoker(this.method_9));
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x01050960 File Offset: 0x0104EB60
	private void method_4()
	{
		for (;;)
		{
			if (GForm1.GetAsyncKeyState((int)this.keys_2) == 0)
			{
				if (GForm1.GetAsyncKeyState((int)this.keys_3) == 0)
				{
					if (GForm1.GetAsyncKeyState((int)this.keys_4) == 0)
					{
						if (GForm1.GetAsyncKeyState((int)this.keys_5) == 0)
						{
							if (GForm1.GetAsyncKeyState((int)this.keys_0) != 0 && !this.bool_1)
							{
								GForm1.mouse_event(2u, 0, 0, 0u, 0u);
								Thread.Sleep(this.int_7);
								GForm1.mouse_event(4u, 0, 0, 0u, 0u);
								Thread.Sleep(this.int_7);
							}
							else if (GForm1.GetAsyncKeyState((int)this.keys_1) != 0 && !this.bool_1)
							{
								GForm1.mouse_event(2u, 0, 0, 0u, 0u);
								Thread.Sleep(this.int_8);
								GForm1.mouse_event(4u, 0, 0, 0u, 0u);
								Thread.Sleep(this.int_8);
							}
							else
							{
								Thread.Sleep(10);
							}
						}
						else
						{
							while (GForm1.GetAsyncKeyState((int)this.keys_5) != 0)
							{
								Thread.Sleep(10);
							}
							this.bool_1 = !this.bool_1;
						}
					}
					else
					{
						while (GForm1.GetAsyncKeyState((int)this.keys_4) != 0)
						{
							Thread.Sleep(10);
						}
						if (this.bool_2)
						{
							this.soundPlayer_0.Stream = Class24.UnmanagedMemoryStream_14;
							this.soundPlayer_0.PlaySync();
						}
						this.int_6 = 2;
						this.int_7 = this.int_4;
						this.int_8 = this.int_5;
					}
				}
				else
				{
					while (GForm1.GetAsyncKeyState((int)this.keys_3) != 0)
					{
						Thread.Sleep(10);
					}
					if (this.bool_2)
					{
						this.soundPlayer_0.Stream = Class24.UnmanagedMemoryStream_13;
						this.soundPlayer_0.PlaySync();
					}
					this.int_6 = 1;
					this.int_7 = this.int_2;
					this.int_8 = this.int_3;
				}
			}
			else
			{
				while (GForm1.GetAsyncKeyState((int)this.keys_2) != 0)
				{
					Thread.Sleep(10);
				}
				if (this.bool_2)
				{
					this.soundPlayer_0.Stream = Class24.UnmanagedMemoryStream_12;
					this.soundPlayer_0.PlaySync();
				}
				this.int_6 = 0;
				this.int_7 = this.int_0;
				this.int_8 = this.int_1;
			}
		}
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x01050B78 File Offset: 0x0104ED78
	public void method_5()
	{
		HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(Config.Url + "status/H1Z1.txt").GetResponse();
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

	// Token: 0x06000809 RID: 2057 RVA: 0x01050C08 File Offset: 0x0104EE08
	public GForm1(Worker worker_1)
	{
		this.worker_0 = worker_1;
		this.method_5();
		this.method_8();
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x01050CB0 File Offset: 0x0104EEB0
	private void GForm1_Load(object sender, EventArgs e)
	{
		if (!File.Exists("Config.ini"))
		{
			this.method_0();
		}
		this.metroComboBox_0.DataSource = Enum.GetValues(typeof(Keys));
		this.metroComboBox_1.DataSource = Enum.GetValues(typeof(Keys));
		this.metroComboBox_2.DataSource = Enum.GetValues(typeof(Keys));
		this.metroComboBox_3.DataSource = Enum.GetValues(typeof(Keys));
		this.metroComboBox_4.DataSource = Enum.GetValues(typeof(Keys));
		this.metroComboBox_5.DataSource = Enum.GetValues(typeof(Keys));
		this.method_2();
		this.metroComboBox_0.SelectedIndex = this.metroComboBox_0.FindStringExact(this.keys_0.ToString());
		this.metroComboBox_1.SelectedIndex = this.metroComboBox_1.FindStringExact(this.keys_1.ToString());
		this.metroComboBox_2.SelectedIndex = this.metroComboBox_2.FindStringExact(this.keys_2.ToString());
		this.metroLabel_4.Text = "No Recoil Delay: " + this.int_0.ToString();
		this.metroTrackBar_0.Value = this.int_0;
		this.metroLabel_5.Text = "Rapid Fire Delay: " + this.int_1.ToString();
		this.metroTrackBar_1.Value = this.int_1;
		this.metroComboBox_3.SelectedIndex = this.metroComboBox_3.FindStringExact(this.keys_3.ToString());
		this.metroLabel_7.Text = "No Recoil Delay: " + this.int_2.ToString();
		this.metroTrackBar_2.Value = this.int_2;
		this.metroLabel_8.Text = "Rapid Fire Delay: " + this.int_3.ToString();
		this.metroTrackBar_3.Value = this.int_3;
		this.metroComboBox_4.SelectedIndex = this.metroComboBox_4.FindStringExact(this.keys_4.ToString());
		this.metroLabel_10.Text = "No Recoil Delay: " + this.int_4.ToString();
		this.metroTrackBar_4.Value = this.int_4;
		this.metroLabel_11.Text = "Rapid Fire Delay: " + this.int_5.ToString();
		this.metroTrackBar_5.Value = this.int_5;
		this.metroComboBox_5.SelectedIndex = this.metroComboBox_5.FindStringExact(this.keys_5.ToString());
		this.metroToggle_0.Checked = this.bool_2;
		this.int_6 = 0;
		this.int_7 = this.int_0;
		this.int_8 = this.int_1;
		new Thread(new ThreadStart(this.method_4))
		{
			IsBackground = true
		}.Start();
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_6(object sender, EventArgs e)
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_7(object sender, EventArgs e)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void metroTabControl_0_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x01050FD0 File Offset: 0x0104F1D0
	private void metroComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_0.GetItemText(this.metroComboBox_0.SelectedItem), out this.keys_0);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x01051000 File Offset: 0x0104F200
	private void metroComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_1.GetItemText(this.metroComboBox_1.SelectedItem), out this.keys_1);
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x01051030 File Offset: 0x0104F230
	private void metroComboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_2.GetItemText(this.metroComboBox_2.SelectedItem), out this.keys_2);
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x01051060 File Offset: 0x0104F260
	private void metroComboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_3.GetItemText(this.metroComboBox_3.SelectedItem), out this.keys_3);
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x01051090 File Offset: 0x0104F290
	private void metroComboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_4.GetItemText(this.metroComboBox_4.SelectedItem), out this.keys_4);
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x010510C0 File Offset: 0x0104F2C0
	private void metroComboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		Enum.TryParse<Keys>(this.metroComboBox_5.GetItemText(this.metroComboBox_5.SelectedItem), out this.keys_5);
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x010510F0 File Offset: 0x0104F2F0
	private void metroTrackBar_0_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_0.Value = this.metroTrackBar_0.Value / 10 * 10;
		this.int_0 = this.metroTrackBar_0.Value;
		this.metroLabel_4.Text = "No Recoil Delay: " + this.int_0.ToString();
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0105114C File Offset: 0x0104F34C
	private void metroTrackBar_1_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_1.Value = this.metroTrackBar_1.Value / 10 * 10;
		this.int_1 = this.metroTrackBar_1.Value;
		this.metroLabel_5.Text = <Module>.smethod_5<string>(1493601745u) + this.int_1.ToString();
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x010511AC File Offset: 0x0104F3AC
	private void metroTrackBar_2_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_2.Value = this.metroTrackBar_2.Value / 10 * 10;
		this.int_2 = this.metroTrackBar_2.Value;
		this.metroLabel_7.Text = "No Recoil Delay: " + this.int_2.ToString();
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x01051208 File Offset: 0x0104F408
	private void metroTrackBar_3_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_3.Value = this.metroTrackBar_3.Value / 10 * 10;
		this.int_3 = this.metroTrackBar_3.Value;
		this.metroLabel_8.Text = "Rapid Fire Delay: " + this.int_3.ToString();
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x01051264 File Offset: 0x0104F464
	private void metroTrackBar_4_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_4.Value = this.metroTrackBar_4.Value / 10 * 10;
		this.int_4 = this.metroTrackBar_4.Value;
		this.metroLabel_10.Text = <Module>.smethod_7<string>(3841093935u) + this.int_4.ToString();
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x010512C4 File Offset: 0x0104F4C4
	private void metroTrackBar_5_Scroll(object sender, ScrollEventArgs e)
	{
		this.metroTrackBar_5.Value = this.metroTrackBar_5.Value / 10 * 10;
		this.int_5 = this.metroTrackBar_5.Value;
		this.metroLabel_11.Text = "Rapid Fire Delay: " + this.int_5.ToString();
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x01051320 File Offset: 0x0104F520
	private void metroToggle_0_CheckedChanged(object sender, EventArgs e)
	{
		this.bool_2 = this.metroToggle_0.Checked;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x01051340 File Offset: 0x0104F540
	private void metroButton_1_Click(object sender, EventArgs e)
	{
		this.method_1();
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void GForm1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x01051354 File Offset: 0x0104F554
	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.bool_0)
		{
			this.worker_0.Shutdown();
		}
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x01051374 File Offset: 0x0104F574
	protected override void Dispose(bool bool_3)
	{
		if (bool_3 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_3);
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x010513A0 File Offset: 0x0104F5A0
	private void method_8()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		this.metroTabControl_0 = new MetroTabControl();
		this.metroTabPage_0 = new MetroTabPage();
		this.metroButton_0 = new MetroButton();
		this.metroComboBox_1 = new MetroComboBox();
		this.metroComboBox_0 = new MetroComboBox();
		this.metroLabel_1 = new MetroLabel();
		this.metroLabel_0 = new MetroLabel();
		this.metroTabControl_1 = new MetroTabControl();
		this.metroTabPage_2 = new MetroTabPage();
		this.metroComboBox_2 = new MetroComboBox();
		this.metroLabel_3 = new MetroLabel();
		this.metroLabel_4 = new MetroLabel();
		this.metroTrackBar_0 = new MetroTrackBar();
		this.metroLabel_5 = new MetroLabel();
		this.metroTrackBar_1 = new MetroTrackBar();
		this.metroTabPage_3 = new MetroTabPage();
		this.metroComboBox_3 = new MetroComboBox();
		this.metroLabel_6 = new MetroLabel();
		this.metroLabel_7 = new MetroLabel();
		this.metroTrackBar_2 = new MetroTrackBar();
		this.metroLabel_8 = new MetroLabel();
		this.metroTrackBar_3 = new MetroTrackBar();
		this.metroTabPage_4 = new MetroTabPage();
		this.metroComboBox_4 = new MetroComboBox();
		this.metroLabel_9 = new MetroLabel();
		this.metroLabel_10 = new MetroLabel();
		this.metroTrackBar_4 = new MetroTrackBar();
		this.metroLabel_11 = new MetroLabel();
		this.metroTrackBar_5 = new MetroTrackBar();
		this.metroTabPage_1 = new MetroTabPage();
		this.metroComboBox_5 = new MetroComboBox();
		this.metroLabel_12 = new MetroLabel();
		this.metroButton_1 = new MetroButton();
		this.metroLabel_2 = new MetroLabel();
		this.metroToggle_0 = new MetroToggle();
		this.metroTabPage_5 = new MetroTabPage();
		this.textBox_0 = new TextBox();
		this.metroTabControl_0.SuspendLayout();
		this.metroTabPage_0.SuspendLayout();
		this.metroTabControl_1.SuspendLayout();
		this.metroTabPage_2.SuspendLayout();
		this.metroTabPage_3.SuspendLayout();
		this.metroTabPage_4.SuspendLayout();
		this.metroTabPage_1.SuspendLayout();
		this.metroTabPage_5.SuspendLayout();
		base.SuspendLayout();
		this.metroTabControl_0.Controls.Add(this.metroTabPage_0);
		this.metroTabControl_0.Controls.Add(this.metroTabPage_1);
		this.metroTabControl_0.Controls.Add(this.metroTabPage_5);
		this.metroTabControl_0.Location = new Point(23, 63);
		this.metroTabControl_0.Name = "MainTabs";
		this.metroTabControl_0.SelectedIndex = 0;
		this.metroTabControl_0.Size = new Size(254, 312);
		this.metroTabControl_0.Style = 4;
		this.metroTabControl_0.TabIndex = 0;
		this.metroTabControl_0.Theme = 2;
		this.metroTabControl_0.UseSelectable = true;
		this.metroTabControl_0.SelectedIndexChanged += this.metroTabControl_0_SelectedIndexChanged;
		this.metroTabPage_0.Controls.Add(this.metroButton_0);
		this.metroTabPage_0.Controls.Add(this.metroComboBox_1);
		this.metroTabPage_0.Controls.Add(this.metroComboBox_0);
		this.metroTabPage_0.Controls.Add(this.metroLabel_1);
		this.metroTabPage_0.Controls.Add(this.metroLabel_0);
		this.metroTabPage_0.Controls.Add(this.metroTabControl_1);
		this.metroTabPage_0.HorizontalScrollbarBarColor = true;
		this.metroTabPage_0.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_0.HorizontalScrollbarSize = 10;
		this.metroTabPage_0.Location = new Point(4, 38);
		this.metroTabPage_0.Name = "RCSRFTab";
		this.metroTabPage_0.Size = new Size(246, 270);
		this.metroTabPage_0.Style = 14;
		this.metroTabPage_0.TabIndex = 1;
		this.metroTabPage_0.Text = "RCS \\ RF";
		this.metroTabPage_0.Theme = 2;
		this.metroTabPage_0.VerticalScrollbarBarColor = true;
		this.metroTabPage_0.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_0.VerticalScrollbarSize = 10;
		this.metroButton_0.Location = new Point(3, 244);
		this.metroButton_0.Name = "RCSRFSave";
		this.metroButton_0.Size = new Size(240, 23);
		this.metroButton_0.Style = 4;
		this.metroButton_0.TabIndex = 1;
		this.metroButton_0.Text = "Save";
		this.metroButton_0.Theme = 2;
		this.metroButton_0.UseSelectable = true;
		this.metroButton_0.Click += this.metroButton_1_Click;
		this.metroComboBox_1.FontSize = 0;
		this.metroComboBox_1.FormattingEnabled = true;
		this.metroComboBox_1.ItemHeight = 19;
		this.metroComboBox_1.Location = new Point(91, 36);
		this.metroComboBox_1.Name = "RFHotKeyComb";
		this.metroComboBox_1.Size = new Size(152, 25);
		this.metroComboBox_1.Style = 2;
		this.metroComboBox_1.TabIndex = 13;
		this.metroComboBox_1.Theme = 2;
		this.metroComboBox_1.UseSelectable = true;
		this.metroComboBox_1.SelectedIndexChanged += this.metroComboBox_1_SelectedIndexChanged;
		this.metroComboBox_0.FontSize = 0;
		this.metroComboBox_0.FormattingEnabled = true;
		this.metroComboBox_0.ItemHeight = 19;
		this.metroComboBox_0.Location = new Point(91, 9);
		this.metroComboBox_0.Name = "RCSHotKeyComb";
		this.metroComboBox_0.Size = new Size(152, 25);
		this.metroComboBox_0.Style = 2;
		this.metroComboBox_0.TabIndex = 12;
		this.metroComboBox_0.Theme = 2;
		this.metroComboBox_0.UseSelectable = true;
		this.metroComboBox_0.SelectedIndexChanged += this.metroComboBox_0_SelectedIndexChanged;
		this.metroLabel_1.Location = new Point(3, 38);
		this.metroLabel_1.Name = "RFHotKeyLabel";
		this.metroLabel_1.Size = new Size(78, 23);
		this.metroLabel_1.Style = 4;
		this.metroLabel_1.TabIndex = 10;
		this.metroLabel_1.Text = "RF HotKey";
		this.metroLabel_1.Theme = 2;
		this.metroLabel_0.Location = new Point(3, 9);
		this.metroLabel_0.Name = "RCSHotKeyLabel";
		this.metroLabel_0.Size = new Size(78, 23);
		this.metroLabel_0.Style = 4;
		this.metroLabel_0.TabIndex = 9;
		this.metroLabel_0.Text = "RCS HotKey";
		this.metroLabel_0.Theme = 2;
		this.metroTabControl_1.Controls.Add(this.metroTabPage_2);
		this.metroTabControl_1.Controls.Add(this.metroTabPage_3);
		this.metroTabControl_1.Controls.Add(this.metroTabPage_4);
		this.metroTabControl_1.Location = new Point(3, 67);
		this.metroTabControl_1.Name = "RCSRFWeaponTab";
		this.metroTabControl_1.SelectedIndex = 0;
		this.metroTabControl_1.Size = new Size(240, 175);
		this.metroTabControl_1.Style = 4;
		this.metroTabControl_1.TabIndex = 7;
		this.metroTabControl_1.Theme = 2;
		this.metroTabControl_1.UseSelectable = true;
		this.metroTabPage_2.Controls.Add(this.metroComboBox_2);
		this.metroTabPage_2.Controls.Add(this.metroLabel_3);
		this.metroTabPage_2.Controls.Add(this.metroLabel_4);
		this.metroTabPage_2.Controls.Add(this.metroTrackBar_0);
		this.metroTabPage_2.Controls.Add(this.metroLabel_5);
		this.metroTabPage_2.Controls.Add(this.metroTrackBar_1);
		this.metroTabPage_2.HorizontalScrollbarBarColor = true;
		this.metroTabPage_2.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_2.HorizontalScrollbarSize = 10;
		this.metroTabPage_2.Location = new Point(4, 38);
		this.metroTabPage_2.Name = "AK47Tab";
		this.metroTabPage_2.Size = new Size(232, 133);
		this.metroTabPage_2.Style = 4;
		this.metroTabPage_2.TabIndex = 0;
		this.metroTabPage_2.Text = "AK47";
		this.metroTabPage_2.Theme = 2;
		this.metroTabPage_2.VerticalScrollbarBarColor = true;
		this.metroTabPage_2.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_2.VerticalScrollbarSize = 10;
		this.metroComboBox_2.FontSize = 0;
		this.metroComboBox_2.FormattingEnabled = true;
		this.metroComboBox_2.ItemHeight = 19;
		this.metroComboBox_2.Location = new Point(77, 7);
		this.metroComboBox_2.Name = "AK47HotKeyComb";
		this.metroComboBox_2.Size = new Size(152, 25);
		this.metroComboBox_2.Style = 2;
		this.metroComboBox_2.TabIndex = 13;
		this.metroComboBox_2.Theme = 2;
		this.metroComboBox_2.UseSelectable = true;
		this.metroComboBox_2.SelectedIndexChanged += this.metroComboBox_2_SelectedIndexChanged;
		this.metroLabel_3.Location = new Point(3, 9);
		this.metroLabel_3.Name = "AK47HotKeyLabel";
		this.metroLabel_3.Size = new Size(68, 23);
		this.metroLabel_3.Style = 4;
		this.metroLabel_3.TabIndex = 12;
		this.metroLabel_3.Text = "HotKey";
		this.metroLabel_3.Theme = 2;
		this.metroLabel_4.Location = new Point(3, 35);
		this.metroLabel_4.Name = "RCSDelayAK47Label";
		this.metroLabel_4.Size = new Size(226, 20);
		this.metroLabel_4.TabIndex = 10;
		this.metroLabel_4.Text = "NoRecoil Intense: 250";
		this.metroLabel_4.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_4.Theme = 2;
		this.metroTrackBar_0.BackColor = Color.Transparent;
		this.metroTrackBar_0.LargeChange = 10;
		this.metroTrackBar_0.Location = new Point(3, 58);
		this.metroTrackBar_0.Maximum = 500;
		this.metroTrackBar_0.Minimum = 100;
		this.metroTrackBar_0.Name = "RCSDelayAK47Track";
		this.metroTrackBar_0.Size = new Size(226, 23);
		this.metroTrackBar_0.SmallChange = 10;
		this.metroTrackBar_0.Style = 4;
		this.metroTrackBar_0.TabIndex = 9;
		this.metroTrackBar_0.Text = "RFDelay";
		this.metroTrackBar_0.Theme = 2;
		this.metroTrackBar_0.Value = 250;
		this.metroTrackBar_0.Scroll += this.metroTrackBar_0_Scroll;
		this.metroLabel_5.Location = new Point(3, 84);
		this.metroLabel_5.Name = "RFDelayAK47Label";
		this.metroLabel_5.Size = new Size(226, 20);
		this.metroLabel_5.TabIndex = 8;
		this.metroLabel_5.Text = "Rapid Fire: 30";
		this.metroLabel_5.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_5.Theme = 2;
		this.metroTrackBar_1.BackColor = Color.Transparent;
		this.metroTrackBar_1.LargeChange = 1;
		this.metroTrackBar_1.Location = new Point(3, 107);
		this.metroTrackBar_1.Minimum = 10;
		this.metroTrackBar_1.Name = "RFDelayAK47Track";
		this.metroTrackBar_1.Size = new Size(226, 23);
		this.metroTrackBar_1.Style = 4;
		this.metroTrackBar_1.TabIndex = 7;
		this.metroTrackBar_1.Text = "RFDelay";
		this.metroTrackBar_1.Theme = 2;
		this.metroTrackBar_1.Value = 30;
		this.metroTrackBar_1.Scroll += this.metroTrackBar_1_Scroll;
		this.metroTabPage_3.Controls.Add(this.metroComboBox_3);
		this.metroTabPage_3.Controls.Add(this.metroLabel_6);
		this.metroTabPage_3.Controls.Add(this.metroLabel_7);
		this.metroTabPage_3.Controls.Add(this.metroTrackBar_2);
		this.metroTabPage_3.Controls.Add(this.metroLabel_8);
		this.metroTabPage_3.Controls.Add(this.metroTrackBar_3);
		this.metroTabPage_3.HorizontalScrollbarBarColor = true;
		this.metroTabPage_3.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_3.HorizontalScrollbarSize = 10;
		this.metroTabPage_3.Location = new Point(4, 38);
		this.metroTabPage_3.Name = "AR15Tab";
		this.metroTabPage_3.Size = new Size(232, 133);
		this.metroTabPage_3.Style = 4;
		this.metroTabPage_3.TabIndex = 1;
		this.metroTabPage_3.Text = "AR15";
		this.metroTabPage_3.Theme = 2;
		this.metroTabPage_3.VerticalScrollbarBarColor = true;
		this.metroTabPage_3.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_3.VerticalScrollbarSize = 10;
		this.metroComboBox_3.FontSize = 0;
		this.metroComboBox_3.FormattingEnabled = true;
		this.metroComboBox_3.ItemHeight = 19;
		this.metroComboBox_3.Location = new Point(77, 7);
		this.metroComboBox_3.Name = "AR15HotKeyComb";
		this.metroComboBox_3.Size = new Size(152, 25);
		this.metroComboBox_3.Style = 2;
		this.metroComboBox_3.TabIndex = 19;
		this.metroComboBox_3.Theme = 2;
		this.metroComboBox_3.UseSelectable = true;
		this.metroComboBox_3.SelectedIndexChanged += this.metroComboBox_3_SelectedIndexChanged;
		this.metroLabel_6.Location = new Point(3, 9);
		this.metroLabel_6.Name = "AR15HotKeyLabel";
		this.metroLabel_6.Size = new Size(68, 23);
		this.metroLabel_6.Style = 4;
		this.metroLabel_6.TabIndex = 18;
		this.metroLabel_6.Text = "HotKey";
		this.metroLabel_6.Theme = 2;
		this.metroLabel_7.Location = new Point(3, 35);
		this.metroLabel_7.Name = "RCSDelayAR15Label";
		this.metroLabel_7.Size = new Size(226, 20);
		this.metroLabel_7.TabIndex = 16;
		this.metroLabel_7.Text = "No Recoil Delay: 150";
		this.metroLabel_7.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_7.Theme = 2;
		this.metroTrackBar_2.BackColor = Color.Transparent;
		this.metroTrackBar_2.Location = new Point(3, 58);
		this.metroTrackBar_2.Maximum = 500;
		this.metroTrackBar_2.Minimum = 100;
		this.metroTrackBar_2.Name = "RCSDelayAR15Track";
		this.metroTrackBar_2.Size = new Size(226, 23);
		this.metroTrackBar_2.Style = 4;
		this.metroTrackBar_2.TabIndex = 15;
		this.metroTrackBar_2.Text = "RFDelay";
		this.metroTrackBar_2.Theme = 2;
		this.metroTrackBar_2.Value = 150;
		this.metroTrackBar_2.Scroll += this.metroTrackBar_2_Scroll;
		this.metroLabel_8.Location = new Point(3, 84);
		this.metroLabel_8.Name = "RFDelayAR15Label";
		this.metroLabel_8.Size = new Size(226, 20);
		this.metroLabel_8.TabIndex = 14;
		this.metroLabel_8.Text = "Rapid Fire Delay: 30";
		this.metroLabel_8.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_8.Theme = 2;
		this.metroTrackBar_3.BackColor = Color.Transparent;
		this.metroTrackBar_3.Location = new Point(3, 107);
		this.metroTrackBar_3.Minimum = 10;
		this.metroTrackBar_3.Name = "RFDelayAR15Track";
		this.metroTrackBar_3.Size = new Size(226, 23);
		this.metroTrackBar_3.Style = 4;
		this.metroTrackBar_3.TabIndex = 13;
		this.metroTrackBar_3.Text = "RFDelay";
		this.metroTrackBar_3.Theme = 2;
		this.metroTrackBar_3.Value = 30;
		this.metroTrackBar_3.Scroll += this.metroTrackBar_3_Scroll;
		this.metroTabPage_4.Controls.Add(this.metroComboBox_4);
		this.metroTabPage_4.Controls.Add(this.metroLabel_9);
		this.metroTabPage_4.Controls.Add(this.metroLabel_10);
		this.metroTabPage_4.Controls.Add(this.metroTrackBar_4);
		this.metroTabPage_4.Controls.Add(this.metroLabel_11);
		this.metroTabPage_4.Controls.Add(this.metroTrackBar_5);
		this.metroTabPage_4.HorizontalScrollbarBarColor = true;
		this.metroTabPage_4.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_4.HorizontalScrollbarSize = 10;
		this.metroTabPage_4.Location = new Point(4, 38);
		this.metroTabPage_4.Name = "PistolsTab";
		this.metroTabPage_4.Size = new Size(232, 133);
		this.metroTabPage_4.Style = 4;
		this.metroTabPage_4.TabIndex = 1;
		this.metroTabPage_4.Text = "Pistols";
		this.metroTabPage_4.Theme = 2;
		this.metroTabPage_4.VerticalScrollbarBarColor = true;
		this.metroTabPage_4.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_4.VerticalScrollbarSize = 10;
		this.metroComboBox_4.FontSize = 0;
		this.metroComboBox_4.FormattingEnabled = true;
		this.metroComboBox_4.ItemHeight = 19;
		this.metroComboBox_4.Location = new Point(77, 7);
		this.metroComboBox_4.Name = "PistolsHotKeyComb";
		this.metroComboBox_4.Size = new Size(152, 25);
		this.metroComboBox_4.Style = 2;
		this.metroComboBox_4.TabIndex = 19;
		this.metroComboBox_4.Theme = 2;
		this.metroComboBox_4.UseSelectable = true;
		this.metroComboBox_4.SelectedIndexChanged += this.metroComboBox_4_SelectedIndexChanged;
		this.metroLabel_9.Location = new Point(3, 9);
		this.metroLabel_9.Name = "PistolsHotKeyLabel";
		this.metroLabel_9.Size = new Size(68, 23);
		this.metroLabel_9.Style = 4;
		this.metroLabel_9.TabIndex = 18;
		this.metroLabel_9.Text = "HotKey";
		this.metroLabel_9.Theme = 2;
		this.metroLabel_10.Location = new Point(3, 35);
		this.metroLabel_10.Name = "RCSDelayPistolsLabel";
		this.metroLabel_10.Size = new Size(226, 20);
		this.metroLabel_10.TabIndex = 16;
		this.metroLabel_10.Text = "No Recoil Delay: 150";
		this.metroLabel_10.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_10.Theme = 2;
		this.metroTrackBar_4.BackColor = Color.Transparent;
		this.metroTrackBar_4.Location = new Point(3, 58);
		this.metroTrackBar_4.Maximum = 500;
		this.metroTrackBar_4.Minimum = 100;
		this.metroTrackBar_4.Name = "RCSDelayPistolsTrack";
		this.metroTrackBar_4.Size = new Size(226, 23);
		this.metroTrackBar_4.Style = 4;
		this.metroTrackBar_4.TabIndex = 15;
		this.metroTrackBar_4.Text = "RFDelay";
		this.metroTrackBar_4.Theme = 2;
		this.metroTrackBar_4.Value = 150;
		this.metroTrackBar_4.Scroll += this.metroTrackBar_4_Scroll;
		this.metroLabel_11.Location = new Point(3, 84);
		this.metroLabel_11.Name = "RFDelayPistolsLabel";
		this.metroLabel_11.Size = new Size(226, 20);
		this.metroLabel_11.TabIndex = 14;
		this.metroLabel_11.Text = "Rapid Fire Delay: 30";
		this.metroLabel_11.TextAlign = ContentAlignment.MiddleCenter;
		this.metroLabel_11.Theme = 2;
		this.metroTrackBar_5.BackColor = Color.Transparent;
		this.metroTrackBar_5.Location = new Point(3, 107);
		this.metroTrackBar_5.Minimum = 10;
		this.metroTrackBar_5.Name = "RFDelayPistolsTrack";
		this.metroTrackBar_5.Size = new Size(226, 23);
		this.metroTrackBar_5.Style = 4;
		this.metroTrackBar_5.TabIndex = 13;
		this.metroTrackBar_5.Text = "RFDelay";
		this.metroTrackBar_5.Theme = 2;
		this.metroTrackBar_5.Value = 30;
		this.metroTrackBar_5.Scroll += this.metroTrackBar_5_Scroll;
		this.metroTabPage_1.Controls.Add(this.metroComboBox_5);
		this.metroTabPage_1.Controls.Add(this.metroLabel_12);
		this.metroTabPage_1.Controls.Add(this.metroButton_1);
		this.metroTabPage_1.Controls.Add(this.metroLabel_2);
		this.metroTabPage_1.Controls.Add(this.metroToggle_0);
		this.metroTabPage_1.HorizontalScrollbarBarColor = true;
		this.metroTabPage_1.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_1.HorizontalScrollbarSize = 10;
		this.metroTabPage_1.Location = new Point(4, 38);
		this.metroTabPage_1.Name = "OtherTab";
		this.metroTabPage_1.Size = new Size(246, 270);
		this.metroTabPage_1.Style = 4;
		this.metroTabPage_1.TabIndex = 2;
		this.metroTabPage_1.Text = "Misc";
		this.metroTabPage_1.Theme = 2;
		this.metroTabPage_1.VerticalScrollbarBarColor = true;
		this.metroTabPage_1.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_1.VerticalScrollbarSize = 10;
		this.metroComboBox_5.FontSize = 0;
		this.metroComboBox_5.FormattingEnabled = true;
		this.metroComboBox_5.ItemHeight = 19;
		this.metroComboBox_5.Location = new Point(113, 41);
		this.metroComboBox_5.Name = "SuspendHotKeyComb";
		this.metroComboBox_5.Size = new Size(130, 25);
		this.metroComboBox_5.Style = 2;
		this.metroComboBox_5.TabIndex = 14;
		this.metroComboBox_5.Theme = 2;
		this.metroComboBox_5.UseSelectable = true;
		this.metroComboBox_5.SelectedIndexChanged += this.metroComboBox_5_SelectedIndexChanged;
		this.metroLabel_12.Location = new Point(3, 41);
		this.metroLabel_12.Name = "SuspendHotKeyLabel";
		this.metroLabel_12.Size = new Size(104, 23);
		this.metroLabel_12.Style = 4;
		this.metroLabel_12.TabIndex = 13;
		this.metroLabel_12.Text = "Suspend HotKey";
		this.metroLabel_12.Theme = 2;
		this.metroButton_1.Location = new Point(3, 244);
		this.metroButton_1.Name = "OtherSave";
		this.metroButton_1.Size = new Size(240, 23);
		this.metroButton_1.Style = 4;
		this.metroButton_1.TabIndex = 11;
		this.metroButton_1.Text = "Save";
		this.metroButton_1.Theme = 2;
		this.metroButton_1.UseSelectable = true;
		this.metroButton_1.Click += this.metroButton_1_Click;
		this.metroLabel_2.Location = new Point(0, 9);
		this.metroLabel_2.Name = "SoundOnSwitchLabel";
		this.metroLabel_2.Size = new Size(157, 23);
		this.metroLabel_2.Style = 4;
		this.metroLabel_2.TabIndex = 10;
		this.metroLabel_2.Text = "Weapon Switch Sound";
		this.metroLabel_2.Theme = 2;
		this.metroToggle_0.AutoSize = true;
		this.metroToggle_0.Checked = true;
		this.metroToggle_0.CheckState = CheckState.Checked;
		this.metroToggle_0.DisplayStatus = false;
		this.metroToggle_0.Location = new Point(189, 12);
		this.metroToggle_0.Name = "SoundOnSwitchToggle";
		this.metroToggle_0.Size = new Size(50, 17);
		this.metroToggle_0.Style = 4;
		this.metroToggle_0.TabIndex = 2;
		this.metroToggle_0.Text = "On";
		this.metroToggle_0.Theme = 2;
		this.metroToggle_0.UseSelectable = true;
		this.metroToggle_0.CheckedChanged += this.metroToggle_0_CheckedChanged;
		this.metroTabPage_5.BackColor = SystemColors.ActiveCaptionText;
		this.metroTabPage_5.Controls.Add(this.textBox_0);
		this.metroTabPage_5.HorizontalScrollbarBarColor = true;
		this.metroTabPage_5.HorizontalScrollbarHighlightOnWheel = false;
		this.metroTabPage_5.HorizontalScrollbarSize = 10;
		this.metroTabPage_5.Location = new Point(4, 38);
		this.metroTabPage_5.Name = "InfoPage";
		this.metroTabPage_5.Size = new Size(246, 270);
		this.metroTabPage_5.TabIndex = 3;
		this.metroTabPage_5.Text = "Info";
		this.metroTabPage_5.VerticalScrollbarBarColor = true;
		this.metroTabPage_5.VerticalScrollbarHighlightOnWheel = false;
		this.metroTabPage_5.VerticalScrollbarSize = 10;
		this.textBox_0.BackColor = Color.AliceBlue;
		this.textBox_0.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.textBox_0.Location = new Point(0, 0);
		this.textBox_0.Multiline = true;
		this.textBox_0.Name = "InfoText";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(250, 270);
		this.textBox_0.TabIndex = 2;
		this.textBox_0.Text = "Default Settings:\r\nAK-47 = 150 MS\r\nAR-15 = 170 MS\r\nPistols = 200+ MS\r\n\r\n@Xenos - Elitepvpers.com";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(300, 398);
		base.Controls.Add(this.metroTabControl_0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "H1Z1";
		base.Resizable = false;
		this.Text = "HypeX H1Z1";
		base.Theme = 2;
		base.FormClosing += this.GForm1_FormClosing;
		base.FormClosed += this.GForm1_FormClosed;
		base.Load += this.GForm1_Load;
		this.metroTabControl_0.ResumeLayout(false);
		this.metroTabPage_0.ResumeLayout(false);
		this.metroTabControl_1.ResumeLayout(false);
		this.metroTabPage_2.ResumeLayout(false);
		this.metroTabPage_3.ResumeLayout(false);
		this.metroTabPage_4.ResumeLayout(false);
		this.metroTabPage_1.ResumeLayout(false);
		this.metroTabPage_1.PerformLayout();
		this.metroTabPage_5.ResumeLayout(false);
		this.metroTabPage_5.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0103FAE4 File Offset: 0x0103DCE4
	[CompilerGenerated]
	private void method_9()
	{
		base.Close();
	}

	// Token: 0x040003CB RID: 971
	private const uint uint_0 = 32768u;

	// Token: 0x040003CC RID: 972
	private const uint uint_1 = 2u;

	// Token: 0x040003CD RID: 973
	private const uint uint_2 = 4u;

	// Token: 0x040003CE RID: 974
	private const uint uint_3 = 32u;

	// Token: 0x040003CF RID: 975
	private const uint uint_4 = 64u;

	// Token: 0x040003D0 RID: 976
	private const uint uint_5 = 1u;

	// Token: 0x040003D1 RID: 977
	private const uint uint_6 = 8u;

	// Token: 0x040003D2 RID: 978
	private const uint uint_7 = 16u;

	// Token: 0x040003D3 RID: 979
	private const uint uint_8 = 128u;

	// Token: 0x040003D4 RID: 980
	private const uint uint_9 = 256u;

	// Token: 0x040003D5 RID: 981
	private const uint uint_10 = 2048u;

	// Token: 0x040003D6 RID: 982
	private const uint uint_11 = 4096u;

	// Token: 0x040003D7 RID: 983
	public bool bool_0 = true;

	// Token: 0x040003D8 RID: 984
	private SoundPlayer soundPlayer_0 = new SoundPlayer();

	// Token: 0x040003D9 RID: 985
	private GClass19 gclass19_0;

	// Token: 0x040003DA RID: 986
	private Keys keys_0 = Keys.RButton;

	// Token: 0x040003DB RID: 987
	private Keys keys_1 = Keys.MButton;

	// Token: 0x040003DC RID: 988
	private Keys keys_2 = Keys.F1;

	// Token: 0x040003DD RID: 989
	private int int_0 = 150;

	// Token: 0x040003DE RID: 990
	private int int_1 = 30;

	// Token: 0x040003DF RID: 991
	private Keys keys_3 = Keys.F2;

	// Token: 0x040003E0 RID: 992
	private int int_2 = 130;

	// Token: 0x040003E1 RID: 993
	private int int_3 = 30;

	// Token: 0x040003E2 RID: 994
	private Keys keys_4 = Keys.F3;

	// Token: 0x040003E3 RID: 995
	private int int_4 = 170;

	// Token: 0x040003E4 RID: 996
	private int int_5 = 30;

	// Token: 0x040003E5 RID: 997
	private Keys keys_5 = Keys.F11;

	// Token: 0x040003E6 RID: 998
	private bool bool_1;

	// Token: 0x040003E7 RID: 999
	private bool bool_2 = true;

	// Token: 0x040003E8 RID: 1000
	private int int_6;

	// Token: 0x040003E9 RID: 1001
	private int int_7;

	// Token: 0x040003EA RID: 1002
	private int int_8;

	// Token: 0x040003EB RID: 1003
	private Worker worker_0;

	// Token: 0x040003EC RID: 1004
	private IContainer icontainer_0;

	// Token: 0x040003ED RID: 1005
	private MetroTabControl metroTabControl_0;

	// Token: 0x040003EE RID: 1006
	private MetroTabPage metroTabPage_0;

	// Token: 0x040003EF RID: 1007
	private MetroLabel metroLabel_0;

	// Token: 0x040003F0 RID: 1008
	private MetroLabel metroLabel_1;

	// Token: 0x040003F1 RID: 1009
	private MetroComboBox metroComboBox_0;

	// Token: 0x040003F2 RID: 1010
	private MetroComboBox metroComboBox_1;

	// Token: 0x040003F3 RID: 1011
	private MetroButton metroButton_0;

	// Token: 0x040003F4 RID: 1012
	private MetroTabPage metroTabPage_1;

	// Token: 0x040003F5 RID: 1013
	private MetroToggle metroToggle_0;

	// Token: 0x040003F6 RID: 1014
	private MetroLabel metroLabel_2;

	// Token: 0x040003F7 RID: 1015
	private MetroButton metroButton_1;

	// Token: 0x040003F8 RID: 1016
	private MetroTabControl metroTabControl_1;

	// Token: 0x040003F9 RID: 1017
	private MetroTabPage metroTabPage_2;

	// Token: 0x040003FA RID: 1018
	private MetroComboBox metroComboBox_2;

	// Token: 0x040003FB RID: 1019
	private MetroLabel metroLabel_3;

	// Token: 0x040003FC RID: 1020
	private MetroLabel metroLabel_4;

	// Token: 0x040003FD RID: 1021
	private MetroTrackBar metroTrackBar_0;

	// Token: 0x040003FE RID: 1022
	private MetroLabel metroLabel_5;

	// Token: 0x040003FF RID: 1023
	private MetroTrackBar metroTrackBar_1;

	// Token: 0x04000400 RID: 1024
	private MetroTabPage metroTabPage_3;

	// Token: 0x04000401 RID: 1025
	private MetroComboBox metroComboBox_3;

	// Token: 0x04000402 RID: 1026
	private MetroLabel metroLabel_6;

	// Token: 0x04000403 RID: 1027
	private MetroLabel metroLabel_7;

	// Token: 0x04000404 RID: 1028
	private MetroTrackBar metroTrackBar_2;

	// Token: 0x04000405 RID: 1029
	private MetroLabel metroLabel_8;

	// Token: 0x04000406 RID: 1030
	private MetroTrackBar metroTrackBar_3;

	// Token: 0x04000407 RID: 1031
	private MetroTabPage metroTabPage_4;

	// Token: 0x04000408 RID: 1032
	private MetroComboBox metroComboBox_4;

	// Token: 0x04000409 RID: 1033
	private MetroLabel metroLabel_9;

	// Token: 0x0400040A RID: 1034
	private MetroLabel metroLabel_10;

	// Token: 0x0400040B RID: 1035
	private MetroTrackBar metroTrackBar_4;

	// Token: 0x0400040C RID: 1036
	private MetroLabel metroLabel_11;

	// Token: 0x0400040D RID: 1037
	private MetroTrackBar metroTrackBar_5;

	// Token: 0x0400040E RID: 1038
	private MetroComboBox metroComboBox_5;

	// Token: 0x0400040F RID: 1039
	private MetroLabel metroLabel_12;

	// Token: 0x04000410 RID: 1040
	private MetroTabPage metroTabPage_5;

	// Token: 0x04000411 RID: 1041
	private TextBox textBox_0;
}
