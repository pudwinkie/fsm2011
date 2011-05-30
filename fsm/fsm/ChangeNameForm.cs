using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		public partial class ChangeNameForm : Form {
				AutomatCreator parent;
				public ChangeNameForm(List<string> lista, string title, string labelTitle, int length, AutomatCreator p) {
						parent = p;
						InitializeComponent();
						staraNazwaLabel.Text = labelTitle;
						Text = title;
						listaStarychNazw.DataSource = lista;
						nowaNazwa.MaxLength = length;
				}

				private void okButton_Click(object sender, EventArgs e) {
						parent.name = nowaNazwa.Text;
						parent.oldName = listaStarychNazw.Text;
						SetVisibleCore(false);
						if (parent.name == parent.oldName) DialogResult = DialogResult.Cancel; 
						else DialogResult = DialogResult.OK;
				}
		}
}
