using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		public partial class RemoveDialog : Form {
				AutomatCreator parent;
				public RemoveDialog(List<string> lista, string labelTitle, string title, AutomatCreator p) {
						parent = p;
						Text = title;
						InitializeComponent();
						label1.Text = labelTitle;
						listBox1.DataSource = lista;
				}

				private void button1_Click(object sender, EventArgs e) {
						foreach (string o in listBox1.SelectedItems)
								parent.removeList.Add(o);
						DialogResult = DialogResult.OK;
						SetVisibleCore(false);
				}
		}
}
