using System.Diagnostics;
using System.Windows.Forms;

namespace Dualverse
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
			versionLabel.Text = "Version " + fileVersionInfo.FileMajorPart + "." + fileVersionInfo.FileMinorPart + "." + fileVersionInfo.FilePrivatePart;
			copyrightLabel1.Text = fileVersionInfo.LegalCopyright + ".";
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

		private void logoPictureBox_Click(object sender, System.EventArgs e)
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
