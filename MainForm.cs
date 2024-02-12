using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dualverse
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ResizeComponent();
			InitializeAsync();
		}

		async void InitializeAsync()
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

		void ResizeComponent()
		{
			webView2Left.Width = this.Width / 2;
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
	}
}
