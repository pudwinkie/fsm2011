using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm{
    public partial class AutomatCreator : Form{
				public string name;
        public AutomatCreator(){
            InitializeComponent();
						FunkcjaPrzejsciaTable.RowCount++;
						FunkcjaPrzejsciaTable.Rows[0].Tag = "Start";
        }

				private void AddLetterButton_Click(object sender, EventArgs e) {
						var eNF = new EnterNameForm("Letter: ", this);
						eNF.ShowDialog();
						if (eNF.DialogResult != DialogResult.OK) return;
						Console.WriteLine(name.Length +" "+ name);
						
						FunkcjaPrzejsciaTable.Columns[FunkcjaPrzejsciaTable.ColumnCount - 2].HeaderText = (name.Length +" "+ name);
						if (name.Length != 1) return;
						//FunkcjaPrzejsciaTable.Columns[FunkcjaPrzejsciaTable.ColumnCount - 1].HeaderText = name;
						FunkcjaPrzejsciaTable.ColumnCount++;
				}

				private void AddStateButton_Click(object sender, EventArgs e) {
						FunkcjaPrzejsciaTable.RowCount++;
				}

				private void RemoveLetterButton_Click(object sender, EventArgs e) {

				}

				private void RemoveStateButton_Click(object sender, EventArgs e) {

				}
    }
}
