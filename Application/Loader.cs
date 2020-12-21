using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using tcp_moe_client.Classes;
using WK.Libraries.BetterFolderBrowserNS;

// Token: 0x0200006F RID: 111
public partial class Loader : Form
{
	// Token: 0x0600085A RID: 2138 RVA: 0x010531BC File Offset: 0x010513BC
	public Loader(Worker worker_1)
	{
		this.worker_0 = worker_1;
		this.InitializeComponent();
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x010531F0 File Offset: 0x010513F0
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (this.prgLoad.Value < 100)
		{
			CProgressBar cprogressBar = this.prgLoad;
			int value = cprogressBar.Value;
			cprogressBar.Value = value + 1;
			return;
		}
		this.timer_0.Stop();
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x01053230 File Offset: 0x01051430
	private void method_0(string string_0)
	{
		try
		{
			File.Delete(string_0);
		}
		catch
		{
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x01053258 File Offset: 0x01051458
	public void method_1(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.SetAttributes(string_0, File.GetAttributes(string_0) | (FileAttributes.Hidden | FileAttributes.System));
		}
		if (Directory.Exists(string_0))
		{
			File.SetAttributes(string_0, File.GetAttributes(string_0) | (FileAttributes.Hidden | FileAttributes.System));
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x01053294 File Offset: 0x01051494
	public static string smethod_0(int int_0)
	{
		return new string(Enumerable.Repeat<string>(<Module>.smethod_5<string>(50192546u), int_0).Select(new Func<string, char>(Loader.Class32.<>9.method_0)).ToArray<char>());
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x010532E0 File Offset: 0x010514E0
	public void method_2(string string_0)
	{
		try
		{
			Directory.Delete(string_0, true);
		}
		catch
		{
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0105330C File Offset: 0x0105150C
	public List<string> method_3(string string_0)
	{
		List<string> list = new List<string>();
		foreach (FileInfo fileInfo in new DirectoryInfo(string_0).GetFiles("*.exe"))
		{
			list.Add(fileInfo.Name);
		}
		return list;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x01053350 File Offset: 0x01051550
	private void method_4(string string_0)
	{
		Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_5<string>(3184156357u), <Module>.smethod_5<string>(2271543304u) + string_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_5<string>(1663134602u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		process.Close();
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x010533B8 File Offset: 0x010515B8
	private void method_5(string string_0)
	{
		List<string> list = new List<string>
		{
			"servicemonitor",
			"servicehelper",
			"protectedmonitor",
			"datadotcom",
			"managedmonitors",
			"serviceindicators",
			"systemmetadata"
		};
		foreach (string str in list)
		{
			if (Directory.Exists(Path.GetTempPath() + str))
			{
				foreach (string str2 in this.method_3(Path.GetTempPath() + str))
				{
					this.method_4("taskkill /F /IM " + str2 + " /T");
				}
				this.method_2(Path.GetTempPath() + str);
			}
			Thread.Sleep(100);
		}
		string text = list[Loader.random_0.Next(0, list.Count)];
		if (!Directory.Exists(Path.GetTempPath() + text))
		{
			Directory.CreateDirectory(Path.GetTempPath() + text);
			this.method_1(Path.GetTempPath() + text);
		}
		string text2 = Loader.smethod_0(Loader.random_0.Next(8, 15));
		string str3 = text + "\\" + text2 + ".exe";
		this.method_0(Path.GetTempPath() + str3);
		Handlers.DownloadFile(Config.Url + string_0, Path.GetTempPath() + str3, text2);
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x01053588 File Offset: 0x01051788
	private void Loader_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 174, 219), 16f), 0, 0, this.method_12().Right, 0);
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x010535CC File Offset: 0x010517CC
	private void Loader_Load(object sender, EventArgs e)
	{
		this.lblUser.Text = this.lblUser.Text.Replace("{{ USERNAME }}", Session.Username);
		this.lblRank.Text = this.lblRank.Text.Replace("{{ RANK }}", Session.Rank);
		Senders.Products();
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x01053628 File Offset: 0x01051828
	private void lstCheatList_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.lstCheatList.SelectedIndex >= 0)
		{
			Product product = this.list_0[this.lstCheatList.SelectedIndex];
			this.lblInfo.Text = product.description + Environment.NewLine + "Expiry: " + product.expiry;
			this.loadBtn.Enabled = true;
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0105368C File Offset: 0x0105188C
	public void method_6()
	{
		base.Invoke(new MethodInvoker(this.method_10));
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x010536AC File Offset: 0x010518AC
	public void method_7(Product product_1)
	{
		Loader.Class33 @class = new Loader.Class33();
		@class.loader_0 = this;
		@class.product_0 = product_1;
		base.Invoke(new MethodInvoker(@class.method_0));
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x010536E0 File Offset: 0x010518E0
	private void Loader_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.bool_0)
		{
			this.worker_0.Shutdown();
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x01053700 File Offset: 0x01051900
	public void method_8()
	{
		this.bool_0 = false;
		base.Invoke(new MethodInvoker(this.method_11));
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x01053728 File Offset: 0x01051928
	private void loadBtn_Click(object sender, EventArgs e)
	{
		this.lstCheatList.Enabled = false;
		this.loadBtn.Enabled = false;
		this.product_0 = this.list_0[this.lstCheatList.SelectedIndex];
		if (this.product_0.name == "Rust Script")
		{
			List<string> list = new List<string>
			{
				"Abaddon",
				"EmberSpirit",
				"Invoker",
				"Pheonix",
				"StormSpirit",
				"nword",
				"gword",
				"ShadowFiend",
				"BristleBack",
				"Weaver"
			};
			this.prgLoad.Visible = true;
			this.method_5(list[Loader.random_0.Next(0, list.Count)] + ".exe");
			return;
		}
		if (this.product_0.name == "RS6 Script")
		{
			base.Hide();
			Handlers.RS6Spawn();
			return;
		}
		if (this.product_0.name == "H1Z1 Script")
		{
			base.Hide();
			Handlers.H1Z1Spawn();
			return;
		}
		if (!(this.product_0.name == "PUBG Script"))
		{
			if (this.product_0.name == "PUBG Mod")
			{
				GClass21.smethod_2(false, false);
				base.Hide();
				Handlers.GeneratorSpawn();
			}
			return;
		}
		this.prgLoad.Visible = true;
		this.method_5("PUBGScript.exe");
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void method_9(object sender, EventArgs e)
	{
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x010298D4 File Offset: 0x01027AD4
	private void prgLoad_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x010538CC File Offset: 0x01051ACC
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x01054394 File Offset: 0x01052594
	[CompilerGenerated]
	private void method_10()
	{
		UI.MsgBox.Show(<Module>.smethod_5<string>(3974142519u) + this.lstCheatList.SelectedItem.ToString() + <Module>.smethod_7<string>(2423142713u), <Module>.smethod_7<string>(1358226771u), MessageBoxIcon.Asterisk);
		Worker.instance.Shutdown();
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0103FAE4 File Offset: 0x0103DCE4
	[CompilerGenerated]
	private void method_11()
	{
		base.Close();
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0103FAF8 File Offset: 0x0103DCF8
	Rectangle method_12()
	{
		return base.Bounds;
	}

	// Token: 0x04000415 RID: 1045
	public bool bool_0 = true;

	// Token: 0x04000416 RID: 1046
	private Worker worker_0;

	// Token: 0x04000417 RID: 1047
	private List<Product> list_0 = new List<Product>();

	// Token: 0x04000418 RID: 1048
	public Product product_0;

	// Token: 0x04000419 RID: 1049
	private static Random random_0 = new Random();

	// Token: 0x02000070 RID: 112
	[CompilerGenerated]
	[Serializable]
	private sealed class Class32
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x01054400 File Offset: 0x01052600
		internal char method_0(string string_0)
		{
			return Loader.Class32.smethod_2(string_0, Loader.Class32.smethod_1(Loader.random_0, Loader.Class32.smethod_0(string_0)));
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0104FCC4 File Offset: 0x0104DEC4
		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0104FCD8 File Offset: 0x0104DED8
		static int smethod_1(Random random_0, int int_0)
		{
			return random_0.Next(int_0);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0104FCEC File Offset: 0x0104DEEC
		static char smethod_2(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		// Token: 0x0400042C RID: 1068
		public static readonly Loader.Class32 <>9 = new Loader.Class32();

		// Token: 0x0400042D RID: 1069
		public static Func<string, char> <>9__9_0;
	}

	// Token: 0x02000071 RID: 113
	[CompilerGenerated]
	private sealed class Class33
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x01054424 File Offset: 0x01052624
		internal void method_0()
		{
			this.loader_0.list_0.Add(this.product_0);
			Loader.Class33.smethod_1(Loader.Class33.smethod_0(this.loader_0.lstCheatList), this.product_0.name);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x01054468 File Offset: 0x01052668
		static ListBox.ObjectCollection smethod_0(ListBox listBox_0)
		{
			return listBox_0.Items;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0105447C File Offset: 0x0105267C
		static int smethod_1(ListBox.ObjectCollection objectCollection_0, object object_0)
		{
			return objectCollection_0.Add(object_0);
		}

		// Token: 0x0400042E RID: 1070
		public Loader loader_0;

		// Token: 0x0400042F RID: 1071
		public Product product_0;
	}
}
