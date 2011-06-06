using System;
using System.Windows.Forms;

namespace fsm {
	public partial class YesNoDialog : Form {
		public YesNoDialog(string windowName, string text) {
			InitializeComponent();
			setLanguage();
			Text = windowName;
			textBox.Text = text;
		}

		private void setLanguage() {

				this.noButton.Text = Language.lang[37]; //"Nie";
				this.yesButton.Text = Language.lang[38]; //"Tak";
		}
		private void yesButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Yes;
			SetVisibleCore(false);
		}

		private void noButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.No;
			SetVisibleCore(false);
		}
	}
}
