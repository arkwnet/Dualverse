using Dualverse.Properties;
using Microsoft.Web.WebView2.Core;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Dualverse
{
	public partial class MainForm : Form
	{
		int[] status = { 0, 0 };
		private const string fileName = "Dualverse.sav";
		Settings settings = new Settings();
		LanguageList languageList = new LanguageList();
		AboutForm aboutForm;
		SettingsForm settingsForm;
		SplashForm splashForm = new SplashForm();

		private static MainForm _mainFormInstance;
		public static MainForm MainFormInstance { get => _mainFormInstance; set => _mainFormInstance = value; }
		public Settings MainFormSettings { get => settings; set => settings = value; }

		public MainForm()
		{
			bool isResetSettings = true;
			if (File.Exists(fileName)) {
				System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				StreamReader streamReader = new StreamReader(fileName, new System.Text.UTF8Encoding(false));
				settings = (Settings)serializer.Deserialize(streamReader);
				streamReader.Close();
				if (settings.Language != "") {
					isResetSettings = false;
				}
			}
			if (isResetSettings == true) {
				settings.LeftUri = "https://twitter.com/";
				settings.RightUri = "https://misskey.io/";
				settings.Language = "en-US";
				CultureInfo cultureInfo = CultureInfo.CurrentCulture;
				for (int i = 0; i < languageList.Count(); i++) {
					if (languageList.Get(i).Code == cultureInfo.Name) {
						settings.Language = cultureInfo.Name;
						break;
					}
				}
				settings.Save(fileName);
			}
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(settings.Language);
			InitializeComponent();
			LocalizeComponent();
			_mainFormInstance = this;
			splashForm.Show();
			DispatcherTimer dispatcherTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(7) };
			dispatcherTimer.Start();
			dispatcherTimer.Tick += (s, args) => {
				CloseSplashForm();
			};
			this.WindowState = FormWindowState.Maximized;
			ResizeComponent();
			InitializeAsync();
		}

		public void LocalizeComponent()
		{
			fileToolStripMenuItem.Text = Resources.FileToolStripMenuItem;
			settingsToolStripMenuItem.Text = Resources.SettingsToolStripMenuItem;
			aboutToolStripMenuItem.Text = Resources.AboutToolStripMenuItem;
			exitToolStripMenuItem.Text = Resources.ExitToolStripMenuItem;
			reloadButtonLeft.Text = Resources.ReloadButton;
			reloadButtonRight.Text = Resources.ReloadButton;
		}

		private async void InitializeAsync()
		{
			await webView2Left.EnsureCoreWebView2Async(null);
			ReloadLeft();
			webView2Left.CoreWebView2.NewWindowRequested += NewWindowRequested;
			await webView2Right.EnsureCoreWebView2Async(null);
			ReloadRight();
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
			DispatcherTimer dispatcherTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
			dispatcherTimer.Start();
			dispatcherTimer.Tick += (s, args) =>
			{
				dispatcherTimer.Stop();
				if (splashForm != null && splashForm.IsDisposed == false) {
					splashForm.Dispose();
				}
			};
		}

		public void reloadButtonLeft_Click(object sender, EventArgs e)
		{
			ReloadLeft();
		}

		public void reloadButtonRight_Click(object sender, EventArgs e)
		{
			ReloadRight();
		}

		private void ReloadLeft() {
			if (settings.LeftUri != "") {
				webView2Left.CoreWebView2.Navigate(settings.LeftUri);
			} else {
				webView2Left.CoreWebView2.Navigate("about:blank");
			}
		}

		private void ReloadRight() {
			if (settings.RightUri != "") {
				webView2Right.CoreWebView2.Navigate(settings.RightUri);
			} else {
				webView2Right.CoreWebView2.Navigate("about:blank");
			}
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
