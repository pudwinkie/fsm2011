using System;
using System.IO;
using System.Windows.Forms;

namespace fsm {
	public partial class SaveMachineDialog : Form {
		FunkcjaPrzejscia fP;
		public SaveMachineDialog(FunkcjaPrzejscia f) {
			fP = f;
			InitializeComponent();
			nazwaTextBox.Text = fP.nazwa;
			opisTextBox.Text = fP.info;
		}

		private void nieButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}

		private void yesButton_Click(object sender, EventArgs e) {
			if (nazwaTextBox.Text != null) fP.nazwa = nazwaTextBox.Text;
			if (opisTextBox.Text != null) fP.info = opisTextBox.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					StreamWriter mR;
					if ((mR = new StreamWriter(saveFileDialog.OpenFile())) != null) {
						using (mR) {
							mR.Write(IOMachine.SaveMachine(fP));
						}
					}
				} catch (Exception ex) {
					InfoBox.Show(ex.Message);
				}
			}
			DialogResult = DialogResult.OK;
		}
	}
}
