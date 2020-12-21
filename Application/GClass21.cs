using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using tcp_moe_client.Classes;
using tcp_moe_client.Properties;
using WK.Libraries.BetterFolderBrowserNS;

// Token: 0x02000069 RID: 105
public static class GClass21
{
	// Token: 0x060007CA RID: 1994 RVA: 0x0104FE70 File Offset: 0x0104E070
	public static bool smethod_0()
	{
		if (MessageBox.Show("Would you like to perform automatic directory search?\nSteam only.", "Game directory", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
		{
			return false;
		}
		Process.Start("steam://run/578080");
		Thread.Sleep(500);
		Process process;
		for (process = null; process == null; process = Process.GetProcessesByName("TslGame_BE").FirstOrDefault<Process>())
		{
			Thread.Sleep(100);
		}
		string text = process.smethod_0(1024);
		GClass21.smethod_1("Taskkill /IM TslGame.exe /F");
		GClass21.smethod_1("Taskkill /IM TslGame_BE.exe /F");
		if (text.Length > 47)
		{
			string text2 = text.Substring(0, text.Length - 43);
			if (text2.Substring(text2.Length - 4) == "PUBG")
			{
				text2 = text.Substring(0, text.Length - 47);
			}
			Settings.Default.GamePath = text2;
			Settings.Default.Save();
			bool result;
			if (!(result = (Directory.Exists(Settings.Default.GamePath + "\\PUBG\\TslGame\\Content\\Paks\\") ? true : false)))
			{
				result = Directory.Exists(Settings.Default.GamePath + "\\PUBG2\\TslGame\\Content\\Paks\\");
			}
			return result;
		}
		UI.MsgBox.Show("Could not find game directory!", "", MessageBoxIcon.Hand);
		return false;
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0104FFA4 File Offset: 0x0104E1A4
	private static void smethod_1(string string_0)
	{
		Process process = Process.Start(new ProcessStartInfo(<Module>.smethod_9<string>(1612034981u), <Module>.smethod_5<string>(2271543304u) + string_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			Verb = <Module>.smethod_7<string>(1218588962u),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		process.StandardOutput.ReadToEnd();
		process.StandardError.ReadToEnd();
		int exitCode = process.ExitCode;
		process.Close();
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0105002C File Offset: 0x0104E22C
	public static void smethod_2(bool bool_0, bool bool_1)
	{
		string gamePath = string.Empty;
		bool flag;
		if (!(flag = (Directory.Exists(Settings.Default.GamePath + "\\PUBG\\TslGame\\Content\\Paks\\") ? true : false)))
		{
			flag = Directory.Exists(Settings.Default.GamePath + "\\PUBG2\\TslGame\\Content\\Paks\\");
		}
		if (bool_0)
		{
			flag = false;
		}
		if (!flag)
		{
			if (!GClass21.smethod_0())
			{
				BetterFolderBrowser betterFolderBrowser = new BetterFolderBrowser();
				do
				{
					if (betterFolderBrowser.ShowDialog() == DialogResult.OK)
					{
						gamePath = betterFolderBrowser.SelectedPath;
						Settings.Default.GamePath = gamePath;
						if (!(flag = (Directory.Exists(Settings.Default.GamePath + "\\PUBG\\TslGame\\Content\\Paks\\") ? true : false)))
						{
							flag = Directory.Exists(Settings.Default.GamePath + "\\PUBG2\\TslGame\\Content\\Paks\\");
						}
					}
					Settings.Default.Save();
					if (!flag)
					{
						UI.MsgBox.Show("Uncommon PUBG location, select 'common' folder!\nExample: 'C:\\Steam\\steamapps\\common'", "Path", MessageBoxIcon.Asterisk);
					}
				}
				while (!flag);
			}
			if (bool_1)
			{
				Application.Restart();
				Environment.Exit(0);
			}
		}
	}
}
