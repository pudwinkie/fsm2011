using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
    public partial class AutomatCreator : Form{
				internal string name, oldName;
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
						try {
								if (name.Length == 0) throw new Exception("Nie podałeś litery");
								funkcjaPrzejscia.DodajLitere(name[0]);
								alfabet.Add(name);
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
						var eNF = new EnterNameForm("State name: ", this, FunkcjaPrzejscia.MAX_DLUGOSC_NAZWY_STANU);
						eNF.ShowDialog();
						if (eNF.DialogResult != DialogResult.OK) return;
						try {
								if (name.Length == 0) throw new Exception("Stan nie może mieć pustej nazwy");
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
								funkcjaPrzejscia.UsunLitere(s[0]);
								alfabet.Remove(s);
						}
						removeList.Clear();
						fPTable.Invalidate();
				}

				private void RemoveStateButton_Click(object sender, EventArgs e) {
						stany.Remove("");
						stany.Remove((string)fPTable.Rows[0].Cells["StateNameColumn"].Value);
						var rl = new RemoveDialog(stany, "Choose states names to remove:", "Remove states", this);
						stany.Insert(0,(string)fPTable.Rows[0].Cells["StateNameColumn"].Value);
						stany.Insert(0,""); 
						rl.ShowDialog();
						if (rl.DialogResult != DialogResult.OK) return;
						var cell = fPTable.Columns["StateNameColumn"].Index;
						string rowName;
						foreach (DataGridViewRow row in fPTable.Rows) {
								rowName = (string)row.Cells[cell].Value;
								if (!removeList.Contains(rowName)) continue;
								fPTable.Rows.Remove(row);
								funkcjaPrzejscia.UsunStan(rowName);
								stany.Remove(rowName);
						}
						foreach (DataGridViewRow row in fPTable.Rows) {
								foreach (DataGridViewCell col in row.Cells) {
										if (col is DataGridViewComboBoxCell && removeList.Contains((string)col.Value)) col.Value = "";
								}
						}
						removeList.Clear();
						fPTable.Update();
				}

				private void changeLetterButton_Click(object sender, EventArgs e) {
						var cn = new ChangeNameForm(alfabet, "Change letter", "Wybierz literę", 1, this);
						cn.ShowDialog();
						if (cn.DialogResult != DialogResult.OK) return;
						try {
								if (name.Length != 1) throw new Exception("Nie podałeś litery");
								funkcjaPrzejscia.DodajLitere(name[0]);
								funkcjaPrzejscia.UsunLitere(oldName[0]);
								int index = alfabet.IndexOf(oldName);
								alfabet.Remove(oldName);
								alfabet.Insert(index, name);
								fPTable.Columns[oldName].HeaderText = name;
								fPTable.Columns[oldName].Name = name;
								fPTable.Update();
						} catch (Exception ex) {
								var t = new InfoBox("Warning", ex.Message);
								t.ShowDialog();
								return;
						}
				}

				private void ChangeStateNameButton_Click(object sender, EventArgs e) {
						var cn = new ChangeNameForm(stany, "Change state name", "Wybierz stan", FunkcjaPrzejscia.MAX_DLUGOSC_NAZWY_STANU, this);
						cn.ShowDialog();
						if (cn.DialogResult != DialogResult.OK) return;
						try {
								if (name.Length == 0) throw new Exception("Nie podałeś litery");
								funkcjaPrzejscia.DodajStan(name, false);
								funkcjaPrzejscia.UsunStan(oldName);
								int index = stany.IndexOf(oldName);
								stany.Remove(oldName);
								stany.Insert(index, name);
								var cell = fPTable.Columns["StateNameColumn"].Index; 
								string rowName;
								foreach (DataGridViewRow row in fPTable.Rows) {
										rowName = (string)row.Cells[cell].Value;
										if (rowName!=oldName) continue;
										row.Cells[cell].Value = name;
								}
								//fPTable.Columns[oldName].HeaderText = name;
								fPTable.Update();
						} catch (Exception ex) {
								var t = new InfoBox("Warning", ex.Message);
								t.ShowDialog();
								return;
						}
				}
    }
}
