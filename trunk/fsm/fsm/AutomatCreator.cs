using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
    public partial class AutomatCreator : Form{
				internal string name;
				internal FunkcjaPrzejscia funkcjaPrzejscia = new FunkcjaPrzejscia("TempName", "a");
        public AutomatCreator(){
            InitializeComponent();
						fPTable.RowCount++;
						fPTable.Rows[0].Cells[1].Value = "Start";

        }

				private void AddLetterButton_Click(object sender, EventArgs e) {
						var eNF = new EnterNameForm("Letter: ", this, 1);
						eNF.ShowDialog();
						if (eNF.DialogResult != DialogResult.OK) return;
						if (name.Length != 1) return;
						fPTable.Columns.Add( new DataGridViewComboBoxColumn());
						fPTable.Columns[fPTable.ColumnCount - 1].Name = name;
						fPTable.Columns[fPTable.ColumnCount - 1].Width = 50;
				}

				private void AddStateButton_Click(object sender, EventArgs e) {
						fPTable.RowCount++;
				}

				private void RemoveLetterButton_Click(object sender, EventArgs e) {

				}

				private void RemoveStateButton_Click(object sender, EventArgs e) {

				}
    }
}
