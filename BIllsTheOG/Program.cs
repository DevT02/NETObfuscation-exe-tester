using System;
using System.Windows.Forms;

namespace BIllsTheOG
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000238A File Offset: 0x0000058A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
