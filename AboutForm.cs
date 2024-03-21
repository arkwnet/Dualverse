using System.Diagnostics;
using System.Windows.Forms;

namespace Dualverse
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo()
			{
				FileName = "https://github.com/arkwnet/Dualverse/",
				UseShellExecute = true,
			};
			Process.Start(processStartInfo);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo()
			{
				FileName = "https://arkw.net/",
				UseShellExecute = true,
			};
			Process.Start(processStartInfo);
		}
	}
}
