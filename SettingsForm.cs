using Dualverse.Properties;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Dualverse
{
	public partial class SettingsForm : Form
	{
		string fileName;
		Settings settings;
		ServiceList serviceList = new ServiceList();
		LanguageList languageList = new LanguageList();
		private MainForm mainFormInstance;

		public SettingsForm(string fileName)
		{
			InitializeComponent();
			mainFormInstance = MainForm.MainFormInstance;
			for (int i = 0; i < serviceList.Count(); i++) {
				serviceLeftCombo.Items.Add(serviceList.Get(i).Name);
				serviceRightCombo.Items.Add(serviceList.Get(i).Name);
			}
			settings = mainFormInstance.MainFormSettings;
			for (int i = 0; i < languageList.Count(); i++) {
				languageCombo.Items.Add(languageList.Get(i).Name);
			}
			this.fileName = fileName;
			serviceLeftText.Text = settings.LeftUri;
			serviceRightText.Text = settings.RightUri;
			UpdateCombo();
			LocalizeComponent();
		}

		private void LocalizeComponent()
		{
			Text = Resources.SettingsLabel;
			settingsLabel.Text = Resources.SettingsLabel;
			serviceLabel.Text = Resources.ServiceLabel;
			serviceLeftLabel.Text = Resources.ServiceLeftLabel;
			serviceRightLabel.Text = Resources.ServiceRightLabel;
			serviceLeftButton.Text = Resources.ServiceButton;
			serviceRightButton.Text = Resources.ServiceButton;
			languageLabel.Text = Resources.LanguageLabel;
			languageDescriptionLabel.Text = Resources.LanguageDescriptionLabel;
			string font = languageList.Get(languageCombo.SelectedIndex).Font;
			settingsLabel.Font = new Font(font, settingsLabel.Font.Size, FontStyle.Bold);
			serviceLabel.Font = new Font(font, serviceLabel.Font.Size, FontStyle.Bold);
			languageLabel.Font = new Font(font, languageLabel.Font.Size, FontStyle.Bold);
			languageDescriptionLabel.Font = new Font(font, languageDescriptionLabel.Font.Size);
		}

		private void UpdateCombo() {
			bool hitLeft = false;
			bool hitRight = false;
			for (int i = 0; i < serviceList.Count(); i++) {
				if (serviceList.Get(i).Uri == serviceLeftText.Text) {
					serviceLeftCombo.SelectedIndex = i;
					hitLeft = true;
				}
				if (serviceList.Get(i).Uri == serviceRightText.Text) {
					serviceRightCombo.SelectedIndex = i;
					hitRight = true;
				}
			}
			if (hitLeft == false) {
				serviceLeftCombo.SelectedIndex = serviceLeftCombo.Items.Count - 1;
			}
			if (hitRight == false) {
				serviceRightCombo.SelectedIndex = serviceRightCombo.Items.Count - 1;
			}
			for (int i = 0; i < languageList.Count(); i++) {
				if (languageList.Get(i).Code == settings.Language) {
					languageCombo.SelectedIndex = i;
					break;
				}
			}
		}

		private void serviceLeftButton_Click(object sender, System.EventArgs e)
		{
			mainFormInstance.MainFormSettings.LeftUri = serviceLeftText.Text;
			mainFormInstance.MainFormSettings.Save(fileName);
			mainFormInstance.reloadButtonLeft_Click(sender, e);
		}

		private void serviceRightButton_Click(object sender, System.EventArgs e)
		{
			mainFormInstance.MainFormSettings.RightUri = serviceRightText.Text;
			mainFormInstance.MainFormSettings.Save(fileName);
			mainFormInstance.reloadButtonRight_Click(sender, e);
		}

		private void serviceLeftCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (serviceList.Get(serviceLeftCombo.SelectedIndex).Uri != "") {
				serviceLeftText.Text = serviceList.Get(serviceLeftCombo.SelectedIndex).Uri;
			}
		}

		private void serviceRightCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (serviceList.Get(serviceRightCombo.SelectedIndex).Uri != "") {
				serviceRightText.Text = serviceList.Get(serviceRightCombo.SelectedIndex).Uri;
			}
		}

		private void serviceLeftText_TextChanged(object sender, System.EventArgs e)
		{
			UpdateCombo();
		}

		private void serviceRightText_TextChanged(object sender, System.EventArgs e)
		{
			UpdateCombo();
		}

		private void languageCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			mainFormInstance.MainFormSettings.Language = languageList.Get(languageCombo.SelectedIndex).Code;
			mainFormInstance.MainFormSettings.Save(fileName);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(mainFormInstance.MainFormSettings.Language);
			LocalizeComponent();
			mainFormInstance.LocalizeComponent();
			if (mainFormInstance.aboutForm != null) {
				mainFormInstance.aboutForm.LocalizeComponent();
			}
		}
	}
}
