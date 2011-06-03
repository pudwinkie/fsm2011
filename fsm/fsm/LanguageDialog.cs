using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm {
		public partial class LanguageDialog : Form {
				List<RadioButton> listaJezykow = new List<RadioButton>();
				public LanguageDialog() {
						InitializeComponent();
						listaJezykow.Add(polishButton);
						listaJezykow.Add(englishButton);
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
						if (englishButton.Checked) Language.SetEnglish();
						if (polishButton.Checked) Language.SetPolish();
						SetVisibleCore(false);
				}
		}
}
