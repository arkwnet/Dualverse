using Microsoft.Web.WebView2.Core;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Dualverse
{
	public partial class MainForm : Form
	{
		AboutForm aboutForm = null;
		SplashForm splashForm = new SplashForm();
		int[] status = { 0, 0 };

		public MainForm()
		{
			InitializeComponent();
			splashForm.Show();
			this.WindowState = FormWindowState.Maximized;
			ResizeComponent();
			InitializeAsync();
		}

		private async void InitializeAsync()
		{
			await webView2Left.EnsureCoreWebView2Async(null);
			webView2Left.CoreWebView2.Navigate("https://twitter.com/");
			webView2Left.CoreWebView2.NewWindowRequested += NewWindowRequested;
			await webView2Right.EnsureCoreWebView2Async(null);
			webView2Right.CoreWebView2.Navigate("https://misskey.io/");
			webView2Right.CoreWebView2.NewWindowRequested += NewWindowRequested;
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			ResizeComponent();
		}

		private void ResizeComponent()
		{
			panelLeft.Width = this.Width / 2;
		}

		private void NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
		{
			e.Handled = true;
			ProcessStartInfo processStartInfo = new ProcessStartInfo()
			{
				FileName = e.Uri,
				UseShellExecute = true,
			};
			Process.Start(processStartInfo);
		}

		private void webView2Left_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			status[0] = 1;
			CloseSplashForm();
		}

		private void webView2Right_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			status[1] = 1;
			CloseSplashForm();
		}

		private void CloseSplashForm()
		{
			if (status[0] == 1 && status[1] == 1) {
				DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
				timer.Start();
				timer.Tick += (s, args) => {
					timer.Stop();
					splashForm.Close();
				};
			}
		}

		private void reloadButtonLeft_Click(object sender, EventArgs e)
		{
			webView2Left.Reload();
		}

		private void reloadButtonRight_Click(object sender, EventArgs e)
		{
			webView2Right.Reload();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (aboutForm == null || aboutForm.IsDisposed) {
				aboutForm = new AboutForm();
				aboutForm.Show();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
