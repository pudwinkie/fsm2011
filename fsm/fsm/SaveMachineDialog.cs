using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace fsm {
	public partial class SaveMachineDialog : Form {
		FunkcjaPrzejscia fP;
		public SaveMachineDialog(FunkcjaPrzejscia f) {
			fP = f;
			InitializeComponent();
			setLanguage();
			nazwaTextBox.Text = fP.nazwa;
			opisTextBox.Text = fP.info;
		}
		private void setLanguage() {

				this.questionLabel.Text = Language.lang[36]; //"Czy chcesz zapisac automat?";
				this.nieButton.Text = Language.lang[37]; //"Nie";
				this.yesButton.Text = Language.lang[38]; //"Tak";
				this.anulujButton.Text = Language.lang[23]; //"Anuluj";
				this.saveFileDialog.Filter = Language.lang[80]; //"Plik automatu (*.fsm)|*.fsm|Plik tekstowy(*.txt)|*.txt|All Files|*.*";
				this.label1.Text = Language.lang[39]; //"Nazwa automatu";
				this.label2.Text = Language.lang[40]; //"Opis automatu";
				this.Text = Language.lang[41]; //"Zapisz automat";
						
		}
		private void noButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}

		private void anulujButton_Click(object sender, EventArgs e) {
				DialogResult = DialogResult.Cancel;
		}
		private void yesButton_Click(object sender, EventArgs e) {
			if (nazwaTextBox.Text != null) fP.nazwa = nazwaTextBox.Text;
			if (opisTextBox.Text != null) fP.info = opisTextBox.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
						StreamWriter mR; 
						Encoding enc = Encoding.GetEncoding("Windows-1250");
					if ((mR = new StreamWriter(saveFileDialog.OpenFile(),enc)) != null) {
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
