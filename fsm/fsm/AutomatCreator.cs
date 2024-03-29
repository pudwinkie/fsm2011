﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fsm {
	//Tomasz Binczycki
	public partial class AutomatCreator : Form {
		internal string name, oldName;
		private List<string> stany = new List<string>();
		private List<string> alfabet = new List<string>();
		internal List<string> removeList = new List<string>();
		internal FunkcjaPrzejscia funkcjaPrzejscia = new FunkcjaPrzejscia(Language.lang[0], "");
		internal Main parent;
		public AutomatCreator(Main p) {
			parent = p;
			InitializeComponent();
			setLanguage();
			fPTable.RowCount++;
			fPTable.Rows[0].Cells[1].Value = Language.lang[1];
			funkcjaPrzejscia.DodajStan(Language.lang[1], false);
			stany.Add("");
			stany.Add(Language.lang[1]);
			funkcjaPrzejscia.DodajLitere('a');
			alfabet.Add("a");
			dodajLitereDoTabeli('a');
			fPTable.Update();
		}

		public AutomatCreator(FunkcjaPrzejscia fp, Main form1) {
			funkcjaPrzejscia = fp;
			parent = form1;
			InitializeComponent();
			setLanguage();
			stany.Add("");
			foreach (Stan s in funkcjaPrzejscia.Stany) {
				stany.Add(s.nazwa);
				fPTable.RowCount++;
			}
			foreach(char c in funkcjaPrzejscia.alfabet){
				alfabet.Add(c+"");
				dodajLitereDoTabeli(c);
			}
			int i = 0;
			foreach (Stan s in funkcjaPrzejscia.Stany) {
				var row = fPTable.Rows[i++];
				row.Cells[0].Value = s.koncowy;
				row.Cells[1].Value = s.nazwa;
				foreach (var pair in s.mapa) {
					row.Cells[pair.Key+""].Value = pair.Value.nazwa;
				}
			}
			fPTable.Update();
		}
		private void setLanguage() {
				this.Accepting.HeaderText = Language.lang[17];//"Akceptujacy";
				this.StateNameColumn.HeaderText = Language.lang[5];//"Nazwa stanu";
				this.AddLetterButton.Text = Language.lang[18];//"Dodaj literę";
				this.AddStateButton.Text = Language.lang[19];//"Dodaj stan";
				this.RemoveStateButton.Text = Language.lang[20];//"Usun stan";
				this.RemoveLetterButton.Text = Language.lang[21];//"Usun literę";
				this.DoneButton.Text = Language.lang[22];//"Zakończ";
				this.MyCancelButton.Text = Language.lang[23];//"Anuluj";
				this.changeLetterButton.Text = Language.lang[11];//"Zmień literę";
				this.ChangeStateNameButton.Text = Language.lang[14];//"Zmień nazwę stanu";
				this.randomButton.Text = Language.lang[24];//"Losowo";
				this.infoButton.Text = Language.lang[25];//"Info";
				this.Text = Language.lang[26];//"Utworz Automat";
				
		}
		private void AddLetterButton_Click(object sender, EventArgs e) {
			var eNF = new EnterNameForm(Language.lang[2], this, 1);
			eNF.ShowDialog();
			if (eNF.DialogResult != DialogResult.OK) return;
			try {
				if (name.Length == 0) throw new ExceptionInFunkcjaPrzejscia(Language.lang[3]);
				funkcjaPrzejscia.DodajLitere(name[0]);
				alfabet.Add(name);
			} catch (ExceptionInFunkcjaPrzejscia ex) {
					InfoBox.Show(ex.Message, Language.lang[4]);
				return;
			}
			dodajLitereDoTabeli(name[0]);
		}

		private void dodajLitereDoTabeli(char p) {
			fPTable.Columns.Add(new DataGridViewTextBoxColumn());
			var column = (DataGridViewTextBoxColumn)fPTable.Columns[fPTable.ColumnCount - 1];
			column.Name = p+"";
			column.Width = 50;
			column.ReadOnly = true;
		}

		private void AddStateButton_Click(object sender, EventArgs e) {
			var eNF = new EnterNameForm(Language.lang[5], this, FunkcjaPrzejscia.MAX_DLUGOSC_NAZWY_STANU);
			eNF.ShowDialog();
			if (eNF.DialogResult != DialogResult.OK) return;
			try {
				if (name.Length == 0) throw new ExceptionInFunkcjaPrzejscia(Language.lang[6]);
				funkcjaPrzejscia.DodajStan(name, false);
			} catch (ExceptionInFunkcjaPrzejscia ex) {
					InfoBox.Show(ex.Message, Language.lang[4]);
				return;
			}
			stany.Add(name);
			fPTable.RowCount++;
			fPTable.Rows[fPTable.RowCount - 1].Cells["StateNameColumn"].Value = name;
		}

		private void RemoveLetterButton_Click(object sender, EventArgs e) {
			var rl = new RemoveDialog(alfabet, Language.lang[7], Language.lang[8], this);
			rl.ShowDialog();
			if (rl.DialogResult != DialogResult.OK) return;
			foreach (string s in removeList) {
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
			var rl = new RemoveDialog(stany, Language.lang[9], Language.lang[10], this);
			stany.Insert(0, (string)fPTable.Rows[0].Cells["StateNameColumn"].Value);
			stany.Insert(0, "");
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
			var cn = new ChangeNameForm(alfabet, Language.lang[11], Language.lang[12], 1, this);
			cn.ShowDialog();
			if (cn.DialogResult != DialogResult.OK) return;
			try {
				if (name.Length != 1) throw new ExceptionInFunkcjaPrzejscia(Language.lang[3]);
				funkcjaPrzejscia.DodajLitere(name[0]);
				funkcjaPrzejscia.UsunLitere(oldName[0]);
				int index = alfabet.IndexOf(oldName);
				//if (index < 0) throw new Exception("Nie ma takiej litery w alfabecie automatu");
				alfabet.Insert(index, name);
				alfabet.Remove(oldName);
				fPTable.Columns[oldName].HeaderText = name;
				fPTable.Columns[oldName].Name = name;
				fPTable.Update();
			} catch (Exception ex) {
					InfoBox.Show(ex.Message, Language.lang[4]);
				return;
			}
		}

		private void ChangeStateNameButton_Click(object sender, EventArgs e) {
			stany.Remove("");
			var cn = new ChangeNameForm(stany, Language.lang[14], Language.lang[15], FunkcjaPrzejscia.MAX_DLUGOSC_NAZWY_STANU, this);
			cn.ShowDialog();
			stany.Insert(0, "");
			if (cn.DialogResult != DialogResult.OK) return;
			try {
				if (name.Length == 0) throw new ExceptionInFunkcjaPrzejscia(Language.lang[3]);
				funkcjaPrzejscia.DodajStan(name, false);
				funkcjaPrzejscia.UsunStan(oldName);
				int index = stany.IndexOf(oldName);
				//if (index < 0) throw new Exception("Nie ma takiego stanu");
				stany.Insert(index, name);
				stany.Remove(oldName);
				index = fPTable.Columns["StateNameColumn"].Index;
				foreach (DataGridViewRow row in fPTable.Rows) {
					foreach (DataGridViewCell col in row.Cells) {
						if (col is DataGridViewTextBoxCell && ((string)col.Value) == oldName)
							col.Value = name;
					}
				}
				fPTable.Update();
			} catch (Exception ex) {
					InfoBox.Show(ex.Message, Language.lang[4]);
				return;
			}
		}

		private void DoneButton_Click(object sender, EventArgs e) {
				funkcjaPrzejscia.UsunWszystkiePrzejscia();
			var accColInd = fPTable.Columns["Accepting"].Index;
			int koncowych = 0;
			bool koncowy;
			foreach (DataGridViewRow row in fPTable.Rows) {
				var o = ((DataGridViewCheckBoxCell)row.Cells[accColInd]).Value;
				if (o != null && (bool)o) { koncowy = true; koncowych++; } else koncowy = false;
				funkcjaPrzejscia.UstawKoncowy((string)row.Cells["StateNameColumn"].Value, koncowy);
			}
			if (koncowych == 0) {
				InfoBox.Show(Language.lang[16], Language.lang[4]);
				return;
			}
			string rowName;
			foreach (DataGridViewRow row in fPTable.Rows) {
				rowName = (string)row.Cells["StateNameColumn"].Value;
				foreach (string s in alfabet) {
					string stanDocelowy = (string)row.Cells[s].Value;
					if (stanDocelowy != "" && stanDocelowy != null) {
						try {
							funkcjaPrzejscia.DodajPrzejscie(rowName, s[0], stanDocelowy);
						} catch (ExceptionInFunkcjaPrzejscia ex) {
								InfoBox.Show(ex.Message, Language.lang[4]);
							return;
						}
					}
				}
			}
			SaveMachineDialog sm = new SaveMachineDialog(funkcjaPrzejscia);
			sm.ShowDialog();
			switch (sm.DialogResult) {
				case DialogResult.Cancel:
					break;
				case DialogResult.OK:
					parent.Inicjalizacja(funkcjaPrzejscia);
					Wizualizacja.RysujF();
					SetVisibleCore(false);
					break;

			}
		}

		private void randomButton_Click(object sender, EventArgs e) {
			Random r = new Random();
			foreach (DataGridViewRow row in fPTable.Rows) {
				row.Cells["Accepting"].Value = r.Next(2) == 0 ? false : true;
				foreach (string s in alfabet) {
					row.Cells[s].Value = stany[r.Next(stany.Count)];
				}
			}
		}

		private void fPTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			DataGridViewCell cell = ((DataGridView)sender).SelectedCells[0];
			if (cell.ColumnIndex != fPTable.Columns["StateNameColumn"].Index && cell is DataGridViewTextBoxCell)
				new ChooseStateForm(stany, (DataGridViewTextBoxCell)cell).ShowDialog();
		}

		private void infoButton_Click(object sender, EventArgs e) {
			InfoBox.Show( funkcjaPrzejscia.info, Language.lang[0]+": " + funkcjaPrzejscia.nazwa);
		}
	}
}
