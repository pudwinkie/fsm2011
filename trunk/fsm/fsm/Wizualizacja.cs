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
        static int czasCzekania = 250;
        static int ileMrugniec = 4;
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

        public static void Mrugaj(int x, int y)
        {
            Color[] tab = { Color.White, Color.Black };

            for (int j = 1; j <= ileMrugniec; j++)
            {
                
                    Okno.dataGridView1.Rows[x].Cells[y].Style.BackColor = tab[j % 2];
                    Okno.dataGridView1.Rows[x].Cells[y].Style.ForeColor = tab[(j + 1) % 2];
                Okno.dataGridView1.Update();
                System.Threading.Thread.Sleep(czasCzekania);
            }
        }

        public static void Mrugaj(int x, int y, int j)
        {
            Color[] tab = { Color.White, Color.Black };

            

                Okno.dataGridView1.Rows[x].Cells[y].Style.BackColor = tab[j % 2];
                Okno.dataGridView1.Rows[x].Cells[y].Style.ForeColor = tab[(j + 1) % 2];
                Okno.dataGridView1.Update();
                System.Threading.Thread.Sleep(czasCzekania);
            
        }


        public static void Krok() {
            foreach (Control o in Okno.Elementy) o.Enabled = false;
           
            // zabawa tekstem pod tabelką
            string s = null;
            s = Okno.textBox1.Text;
            
            if (s == null || s == "") goto aaa; /////////////======== co zrobić gdy nie ma tekstu
            char literka=s[0];
            Okno.textBox3.Text = literka+"";
            string s2="";
            for (int i = 1; i < s.Length; i++) s2 += s[i];
            Okno.textBox1.Text = s2;
            Okno.textBox1.Update();
            Color[] tab = { Color.White, Color.Black };
            for (int j = 1; j <= ileMrugniec; j++) {
                Okno.textBox3.BackColor = tab[j % 2];
                Okno.textBox3.ForeColor = tab[(j + 1) % 2];
                Okno.textBox3.Update();
                System.Threading.Thread.Sleep(czasCzekania);
            }

            
            int x = f.AlfabetIndex(literka);
            if (x == -1) goto aaa; /////////==============nie ma takiej literki w alfabecie
            Mrugaj(f.Stany.IndexOf(f.obecny));

            Mrugaj(f.Stany.IndexOf(f.obecny), x + 1,1);
            
            int stareid = f.Stany.IndexOf(f.obecny);
            try { f.Przejscie(literka); }
            catch (Exception) { goto aaa; } //////======== niezaakceptowany stan
            Mrugaj(f.Stany.IndexOf(f.obecny),0);

            
            Okno.dataGridView1.Rows[stareid].Cells[0].Value = f.Stany[stareid].nazwa;
            int noweid = f.Stany.IndexOf(f.obecny);
            Okno.dataGridView1.Rows[noweid].Cells[0].Value = "-> "+ f.obecny.nazwa+" <-";
            Mrugaj(stareid, x + 1, 0);
           
            aaa:
                Okno.textBox2.Text += Okno.textBox3.Text;
                Okno.textBox3.Text = "";
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
            Okno.textBox3.Font = new Font("Times New Roman", 30, FontStyle.Bold);
            for (int i = 0; i < f.Stany.ToArray().Length; i++)
                if (f.Stany[i].koncowy)Okno.dataGridView1.Rows[i].Cells[0].Style.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            Okno.dataGridView1.Rows[f.Stany.IndexOf(f.obecny)].Cells[0].Value = "-> " + f.obecny.nazwa + " <-";

                Okno.dataGridView1.Invalidate();
        }

        public static void Test(){
            f = new FunkcjaPrzejscia("name", "");
            f.Test();
        }

    }
}
