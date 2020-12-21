using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace tcp_moe_client.Properties
{
	// Token: 0x0200005B RID: 91
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x010298D4 File Offset: 0x01027AD4
		private void method_0(object sender, SettingChangingEventArgs e)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x010298D4 File Offset: 0x01027AD4
		private void method_1(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0103CF4C File Offset: 0x0103B14C
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0103CF70 File Offset: 0x0103B170
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public Keys rapidfireNewKey
		{
			get
			{
				return (Keys)this[<Module>.smethod_9<string>(145851735u)];
			}
			set
			{
				this[<Module>.smethod_6<string>(1651873103u)] = value;
			}
		}
	}
}
