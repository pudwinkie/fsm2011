using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class RemoveDialog : Form {
				AutomatCreator parent;
				public RemoveDialog(List<string> lista, string labelTitle, string title, AutomatCreator p) {
						parent = p;
						Text = title;
						InitializeComponent();
						setLanguage();
						label1.Text = labelTitle;
						listBox1.DataSource = lista;
				}
				private void setLanguage() {

						this.removeButton.Text = Language.lang[35];// "Usuń";
						this.MyCancelButton.Text = Language.lang[23];// "Anuluj";
				}
				private void button1_Click(object sender, EventArgs e) {
						foreach (string o in listBox1.SelectedItems)
								parent.removeList.Add(o);
						DialogResult = DialogResult.OK;
						SetVisibleCore(false);
				}
		}
}
