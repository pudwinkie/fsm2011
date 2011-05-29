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
				private List<string> stany = new List<string>();
				private List<string> alfabet = new List<string>();
				internal List<string> removeList = new List<string>();
				internal FunkcjaPrzejscia funkcjaPrzejscia = new FunkcjaPrzejscia("TempName", "a");
        public AutomatCreator(){
            InitializeComponent();
						fPTable.RowCount++;
						fPTable.Rows[0].Cells[1].Value = "Start";
						stany.Add("");
						stany.Add("Start");
						alfabet.Add("a");
						var col = ((DataGridViewComboBoxColumn)fPTable.Columns[2]);
						col.DataSource = stany;
        }

				private void AddLetterButton_Click(object sender, EventArgs e) {
						var eNF = new EnterNameForm("Letter: ", this, 1);
						eNF.ShowDialog();
						if (eNF.DialogResult != DialogResult.OK) return;
						if (name.Length != 1) return;
						try {
								funkcjaPrzejscia.DodajLitere(name[0]);
								alfabet.Add(name[0]+"");
						} catch (Exception ex) {
								var t = new InfoBox("Warning", ex.Message);
								t.ShowDialog();
								return;
						}
						fPTable.Columns.Add( new DataGridViewComboBoxColumn());
						var column = (DataGridViewComboBoxColumn)fPTable.Columns[fPTable.ColumnCount - 1];
						column.Name = name;
						column.Width = 50;
						column.DataSource = stany;
				}

				private void AddStateButton_Click(object sender, EventArgs e) {
						var eNF = new EnterNameForm("State name: ", this, 20);
						eNF.ShowDialog();
						if (eNF.DialogResult != DialogResult.OK) return;
						try {
								funkcjaPrzejscia.DodajStan(name, false);
						} catch (Exception ex) {
								var t = new InfoBox("Warning", ex.Message);
								t.ShowDialog();
								return;
						}
						stany.Add(name);
						fPTable.RowCount++; 
						fPTable.Rows[fPTable.RowCount - 1].Cells["StateNameColumn"].Value = name;
				}

				private void RemoveLetterButton_Click(object sender, EventArgs e) {
						var rl = new RemoveDialog(alfabet, "Choose letters to remove:", "Remove letters", this);
						rl.ShowDialog();
						if (rl.DialogResult != DialogResult.OK) return;
						foreach(string s in removeList) {
								fPTable.Columns.Remove(s);
								alfabet.Remove(s);
						}
						removeList.Clear();
						fPTable.Invalidate();
				}

				private void RemoveStateButton_Click(object sender, EventArgs e) {
						var rl = new RemoveDialog(stany, "Choose states names to remove:", "Remove states", this);
						rl.ShowDialog();
						if (rl.DialogResult != DialogResult.OK) return;
						var cell = fPTable.Columns["StateNameColumn"].Index;
						string rowName;
						foreach (DataGridViewRow row in fPTable.Rows) {
								rowName = (string)row.Cells[cell].Value;
								if (!removeList.Contains(rowName)) continue;
								fPTable.Rows.Remove(row);
								stany.Remove(rowName);
						}
						removeList.Clear();
						fPTable.Update();
				}

				private void changeLetterButton_Click(object sender, EventArgs e) {

				}

				private void ChangeStateNameButton_Click(object sender, EventArgs e) {

				}
    }
}
