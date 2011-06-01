using System;
using System.Windows.Forms;

namespace fsm {
	public partial class YesNoDialog : Form {
		public YesNoDialog(string windowName, string text) {
			InitializeComponent();
			Text = windowName;
			textBox.Text = text;
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
