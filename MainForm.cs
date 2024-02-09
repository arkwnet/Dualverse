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
			await webView2Right.EnsureCoreWebView2Async(null);
			webView2Right.CoreWebView2.Navigate("https://misskey.io/");
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			ResizeComponent();
		}

		void ResizeComponent()
		{
			webView2Left.Width = this.Width / 2;
		}
	}
}
