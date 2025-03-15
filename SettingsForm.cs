using System.IO;
using System.Windows.Forms;

namespace Dualverse
{
	public partial class SettingsForm : Form
	{
		string fileName;
		Settings settings;
		ServiceList serviceList = new ServiceList();
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
			this.fileName = fileName;
			serviceLeftText.Text = settings.LeftUri;
			serviceRightText.Text = settings.RightUri;
			UpdateCombo();
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
	}
}
