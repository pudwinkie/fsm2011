using System;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class EnterNameForm : Form {
				private AutomatCreator parent;
				public EnterNameForm(string s, AutomatCreator p, int length) {
						parent = p;
						InitializeComponent();
						setLanguage();
						EnterNameLabel.Text = s;
						nameTextBox.MaxLength = length;
				}
				private void setLanguage() {

						this.EnterNameLabel.Text = Language.lang[33];// "Wpisz nazwę";
						this.OKbutton.Text = Language.lang[29];// "OK";
						this.MyCancelButton.Text = Language.lang[23];// "Anuluj";
				}
				private void OKbutton_Click(object sender, EventArgs e) {
						parent.name = nameTextBox.Text;
				}
		}
}
