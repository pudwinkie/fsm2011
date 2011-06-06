using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class ChangeNameForm : Form {
				AutomatCreator parent;
				public ChangeNameForm(List<string> lista, string title, string labelTitle, int length, AutomatCreator p) {
						parent = p;
						InitializeComponent(); 
						SetLanguage();
						staraNazwaLabel.Text = labelTitle;
						Text = title;
						listaStarychNazw.DataSource = lista;
						listaStarychNazw.MaxLength = length;
						nowaNazwa.MaxLength = length;
				}
				public void SetLanguage(){

						this.staraNazwaLabel.Text = Language.lang[27];
						this.nowaNazwaLabel.Text = Language.lang[28];
						this.okButton.Text = Language.lang[29];
						this.myCancelButton.Text = Language.lang[23];
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
