using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace fsm
{
    class Wizualizacja
        //autor Musiał Mateusz
    {
        public static Form1 Okno;
        public static FunkcjaPrzejscia f;
        public static int rozalf;
        //====================================
        static int czasCzekania = 500;
        static int ileMrugniec = 6;
        //====================================

        public static void Mrugaj(int p){
            Color[]tab={Color.White, Color.Black};

            for (int j = 1; j <= ileMrugniec; j++)
            {
            for (int i=0; i<=rozalf; i++){
                 Okno.dataGridView1.Rows[p].Cells[i].Style.BackColor= tab[j%2];
                 Okno.dataGridView1.Rows[p].Cells[i].Style.ForeColor = tab[(j+1) % 2];
              }
            Okno.dataGridView1.Update();
            System.Threading.Thread.Sleep(czasCzekania);
            }
        }

        public static void Krok() {
            foreach (Control o in Okno.Elementy) o.Enabled = false;
            int p = f.Stany.IndexOf(f.obecny);
            Mrugaj(p);


            foreach (Control o in Okno.Elementy) o.Enabled = true;
        }

        public static void RysujF() {

            rozalf = f.alfabet.Length;
            for (int i = 0; i <= rozalf; i++)
               Okno.dataGridView1.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            Okno.dataGridView1.Columns[0].HeaderText = "State Name";
            for (int i = 0; i < rozalf; i++)
                Okno.dataGridView1.Columns[1 + i].HeaderText = " " + f.alfabet[i] + " ";

            foreach (Stan s in f.Stany)
            {
                string[] cell = new string[f.alfabet.Length + 2];
                cell[0] = s.nazwa;
                for (int i = 0; i <= rozalf; i++)
                {
                    string n = null;
                    try
                    {
                        n = s.mapa[f.alfabet[i]].nazwa;
                    }
                    catch (Exception) { }
                    if (n == null) cell[i + 1] = "";
                    else cell[i + 1] = n;
                }

                Okno.dataGridView1.Rows.Add(cell);

            }

         
            Okno.dataGridView1.Rows[0].Cells[0].Selected = false;
                Okno.dataGridView1.Invalidate();
        }

        public static void Test(){
            f = new FunkcjaPrzejscia("name", "");
            f.Test();
        }

    }
}
