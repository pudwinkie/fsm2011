﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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
        static Color PodBack = Color.Blue;
        static Color PodText = Color.Red;
        //====================================

        public static void PodWers(int wers, int j)
        {
            Color[] tab=new Color[2];
            if (j == 1) { tab[0] = PodText; tab[1] = PodBack; }
            else { tab[1] = Color.White; tab[0] = Color.Black;}

            for (int i = 0; i <= rozalf; i++)
            {
                Okno.dataGridView1.Rows[wers].Cells[i].Style.BackColor = tab[1];
                Okno.dataGridView1.Rows[wers].Cells[i].Style.ForeColor = tab[0];
            }
        }

        public static void PodKol(int y, int j)
        {
            Color[] tab = new Color[2];
            if (j == 1) { tab[0] = PodText; tab[1] = PodBack; }
            else { tab[1] = Color.Black; tab[0] = Color.White; }
            Color[] tab2 = new Color[2];
            if (j == 1) { tab2[0] = PodText; tab2[1] = PodBack; }
            else { tab2[1] = SystemColors.ControlText; tab2[0] = SystemColors.ActiveBorder; }

            for (int i = 0; i < f.Stany.ToArray().Length; i++)
            {
                Okno.dataGridView1.Rows[i].Cells[y].Style.BackColor = tab[j % 2];
                Okno.dataGridView1.Rows[i].Cells[y].Style.ForeColor = tab[(j + 1) % 2];
            }
            Okno.dataGridView1.Columns[y].HeaderCell.Style.BackColor = tab2[j % 2];
            Okno.dataGridView1.Columns[y].HeaderCell.Style.ForeColor = tab2[(j + 1) % 2];
            System.Threading.Thread.Sleep(czasCzekania);
        }

        public static void MrugajLit() {
            Color[] tab = { Color.White, Color.Black };
            for (int j = 1; j <= ileMrugniec; j++)
            {
                Okno.textBox3.BackColor = tab[j % 2];
                Okno.textBox3.ForeColor = tab[(j + 1) % 2];
                Okno.textBox3.Update();
                System.Threading.Thread.Sleep(czasCzekania);
            }
        }

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

        public static void UspijElementy(){
        foreach (Control o in Okno.Elementy) o.Enabled = false;
        Okno.textBox1.ReadOnly = true;
        Okno.numerator.ReadOnly = true;
        }

        public static void ObudzElementy() {
            foreach (Control o in Okno.Elementy) o.Enabled = true;
            Okno.textBox1.ReadOnly = false;
            Okno.numerator.ReadOnly = false;
            if (Okno.numerator.Value == 0) Okno.numerator.Value = 1;

        }

       

        static int stareid, noweid, x;
        public static void Krok() {
            
            // sprawdzenie czy tekst istnieje
            string s = null;
            s = Okno.textBox1.Text;
            if (s == null || s == "") goto aaa; /////////////======== co zrobić gdy nie ma tekstu
            //podświetlanie aktualnej literki
            char literka=s[0];
            MrugajLit();
            x = f.AlfabetIndex(literka);
            if (x == -1) goto aaa; /////////==============nie ma takiej literki w alfabecie
            //podświetla tabelke
            PodKol(x + 1, 1);
            Okno.dataGridView1.Update();
            Mrugaj(f.Stany.IndexOf(f.obecny), x + 1,1);
            
            stareid = f.Stany.IndexOf(f.obecny);
            try { f.Przejscie(literka); }
            catch (Exception) { goto aaa; } //////======== niezaakceptowany stan
            Mrugaj(f.Stany.IndexOf(f.obecny),0);
            noweid = f.Stany.IndexOf(f.obecny);
            
            //powrót do normalnego wyglądu
            aaa:
            PodKol(x + 1, 0);
            PodWers(noweid, 1);
            PodWers(stareid, 0);
            Mrugaj(stareid, x + 1, 0);
            string s2 = "";
            for (int i = 1; i < s.Length; i++) s2 += s[i];
            Okno.textBox2.Text += Okno.textBox1.Text[0];
            Okno.textBox1.Text = s2;
            Okno.textBox1.Update();
            
                
        }

        static public void Reset() {
            for (int i = 0; i < f.Stany.ToArray().Length; i++)
                PodWers(i, 0);
            f.obecny = f.Stany[0];
            PodWers(0, 1);
            Okno.textBox1.Text = "";
            Okno.textBox2.Text = "";
            f.Reset();
        }

        public static void RysujF() {
            ObudzElementy();
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
            
            for (int i = 0; i < f.Stany.ToArray().Length; i++)
                if (f.Stany[i].koncowy)Okno.dataGridView1.Rows[i].Cells[0].Style.Font = new Font("Times New Roman", 9, FontStyle.Bold);
           // Okno.dataGridView1.Rows[f.Stany.IndexOf(f.obecny)].Cells[0].Value = "-> " + f.obecny.nazwa + " <-";
            PodWers(f.Stany.IndexOf(f.obecny),1);
                Okno.dataGridView1.Invalidate();
        }

        public static void Test(){
            f = new FunkcjaPrzejscia("name", "");
            f.Test();
        }




        public static bool CzyFIstnieje() {
            if (f == null)
            {
                new InfoBox("Błąd", "Brak załadowanej Funkcji Przejścia").ShowDialog();
                return false;
            }
            return true;
        }
    }
}