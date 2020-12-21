using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using tcp_moe_client.Classes;

// Token: 0x0200006E RID: 110
public partial class Debug_1 : Form
{
	// Token: 0x0600084D RID: 2125 RVA: 0x01052FF0 File Offset: 0x010511F0
	public Debug_1()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0105300C File Offset: 0x0105120C
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.lstLog.DataSource = null;
		this.lstLog.Items.Clear();
		this.lstLog.DataSource = Debug.GetLog();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x01053048 File Offset: 0x01051248
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
