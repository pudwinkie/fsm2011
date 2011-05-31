using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace fsm {
		public partial class SaveMachineDialog : Form {
				FunkcjaPrzejscia fP;
				public SaveMachineDialog(FunkcjaPrzejscia f) {
						fP = f;
						InitializeComponent();
				}

				private void nieButton_Click(object sender, EventArgs e) {
						DialogResult = DialogResult.OK;
				}

				private void yesButton_Click(object sender, EventArgs e) {
						fP.nazwa = nazwaTextBox.Text;
						fP.info = opisTextBox.Text;
						if (saveFileDialog.ShowDialog() == DialogResult.OK) {
								try {
										StreamWriter mR;
										if ((mR = new StreamWriter(saveFileDialog.OpenFile())) != null) {
												using (mR) {
														mR.Write(IOMachine.SaveMachine(fP));
												}
										}
								} catch (Exception ex) {
										MessageBox.Show(ex.Message);
								}
						}
						DialogResult = DialogResult.OK;
				}
		}
}
