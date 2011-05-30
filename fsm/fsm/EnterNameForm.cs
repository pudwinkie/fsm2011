using System;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class EnterNameForm : Form {
				private AutomatCreator parent;
				public EnterNameForm(string s, AutomatCreator p, int length) {
						parent = p;
						InitializeComponent();
						EnterNameLabel.Text = s;
						nameTextBox.MaxLength = length;
				}

				private void OKbutton_Click(object sender, EventArgs e) {
						parent.name = nameTextBox.Text;
				}
		}
}
