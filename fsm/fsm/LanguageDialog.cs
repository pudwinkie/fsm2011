using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		public partial class LanguageDialog : Form {
				Main parent;
				List<RadioButton> listaJezykow = new List<RadioButton>();
				public LanguageDialog(Main p) {
						parent = p;
						InitializeComponent();
						setLanguage();
						listaJezykow.Add(polishButton);
						listaJezykow.Add(englishButton);
				}
				private void setLanguage() {

						this.englishButton.Text = "English";
						this.polishButton.Text = "Polski";
						this.okButton.Text = Language.lang[29];// "OK";
						this.Text = Language.lang[66];//"Language";
				}
				private void englishButton_CheckedChanged(object sender, EventArgs e) {
						if(englishButton.Checked == false) return;
						foreach (RadioButton r in listaJezykow) {
								if (r != englishButton) r.Checked = false;
						}
				}

				private void polishButton_CheckedChanged(object sender, EventArgs e) {
						if (polishButton.Checked == false) return;
						foreach (RadioButton r in listaJezykow) {
								if (r != polishButton) r.Checked = false;
						}
				}

				private void okButton_Click(object sender, EventArgs e) {
						string s = Language.lang[0];
						if (englishButton.Checked) Language.SetEnglish();
						if (polishButton.Checked) Language.SetPolish();
						if (s == Language.lang[0]) {
								DialogResult = DialogResult.Abort;
								Dispose();
								return;
						}
						parent.Update();
						Dispose();
				}
		}
}
