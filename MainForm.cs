using Microsoft.Web.WebView2.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Dualverse
{
	public partial class MainForm : Form
	{
		int[] status = { 0, 0 };
		private const string fileName = "Dualverse.sav";
		Settings settings = new Settings();
		AboutForm aboutForm;
		SettingsForm settingsForm;
		SplashForm splashForm = new SplashForm();

		private static MainForm _mainFormInstance;
		public static MainForm MainFormInstance { get => _mainFormInstance; set => _mainFormInstance = value; }
		public Settings MainFormSettings { get => settings; set => settings = value; }

		public MainForm()
		{
			InitializeComponent();
			_mainFormInstance = this;
			splashForm.Show();
			this.WindowState = FormWindowState.Maximized;
			if (File.Exists(fileName)) {
				System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				StreamReader streamReader = new StreamReader(fileName, new System.Text.UTF8Encoding(false));
				settings = (Settings)serializer.Deserialize(streamReader);
				streamReader.Close();
			}
			ResizeComponent();
			InitializeAsync();
		}

		private async void InitializeAsync()
		{
			await webView2Left.EnsureCoreWebView2Async(null);
			webView2Left.CoreWebView2.Navigate(settings.LeftUri);
			webView2Left.CoreWebView2.NewWindowRequested += NewWindowRequested;
			await webView2Right.EnsureCoreWebView2Async(null);
			webView2Right.CoreWebView2.Navigate(settings.RightUri);
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

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (settingsForm == null || settingsForm.IsDisposed) {
				settingsForm = new SettingsForm(fileName);
				settingsForm.Show();
			}
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
