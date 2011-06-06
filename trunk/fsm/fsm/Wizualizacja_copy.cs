using System;
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
        public static bool ok = false;
        public static int rozalf;
        public static int zly = 0;
        public static List<int> historia = new List<int>();
        public static List<string> raport = new List<string>();
        //====================================
        public static int czasCzekania = 200;
        public static int ileMrugniec = 4;
        public static Color PodBack = Color.Blue;
        public static Color PodText = Color.Red;
        //====================================


        public static void UspijElementy()
        {
            foreach (Control o in Okno.Elementy) o.Enabled = false;
            Okno.textBox1.ReadOnly = true;
            Okno.numerator.ReadOnly = true;
        }

        public static void ObudzElementy()
        {
            foreach (Control o in Okno.Elementy) o.Enabled = true;
            Okno.textBox1.ReadOnly = false;
            Okno.numerator.ReadOnly = false;
            if (Okno.numerator.Value == 0) Okno.numerator.Value = 1;

        }



        static int stareid, noweid, x;
        public static void Krok()
        {
            int hist = f.Stany.IndexOf(f.obecny);
            bool obraz = Okno.checkBox1.Checked == true ? false : true;
            historia.Add(hist);
            raport.Add(f.obecny.nazwa.ToString()+" - "+Okno.textBox3.Text);

            // InfoBox.Show(hist.ToString(), " ");
            // sprawdzenie czy tekst istnieje
            string s = null;
            stareid = noweid;
            s = Okno.textBox1.Text;
            if (s == null || s == "") { return; } //co zrobić gdy nie ma tekstu
            //podświetlanie aktualnej literki
            char literka = s[0];
            if (obraz) Obraz.MrugajLit();
            if (zly > 0) { zly++; goto aaa; } //jestesmy w nieistniejącym stanie
            x = f.AlfabetIndex(literka);
            if (x == -1) { zly++; goto aaa; } /////////==============nie ma takiej literki w alfabecie
            //podświetla tabelke
            if (obraz)
            {
                Obraz.PodKol(x + 1, 1);
                Okno.dataGridView1.Update();
                Obraz.Mrugaj(f.Stany.IndexOf(f.obecny), x + 1, 1);
            }

            stareid = f.Stany.IndexOf(f.obecny);
            noweid = f.Stany.IndexOf(f.obecny);

            try { f.Przejscie(literka); }
            catch (Exception) { zly++; goto aaa; } //////======== niezaakceptowany stan
            if (obraz) Obraz.Mrugaj(f.Stany.IndexOf(f.obecny), 0);
            noweid = f.Stany.IndexOf(f.obecny);

            //powrót do normalnego wyglądu
        aaa:
            Obraz.PodKol(x + 1, 0);
            Obraz.PodWers(stareid, 0);
            if (obraz) Obraz.Mrugaj(stareid, x + 1, 0);
            string s2 = "";
            for (int i = 1; i < s.Length; i++) s2 += s[i];
            Okno.textBox2.Text += Okno.textBox1.Text[0];
            Okno.textBox1.Text = s2;
            if (zly == 0) Obraz.PodWers(noweid, 1);
            Okno.textBox1.Update();
        }

        public static void Cofnij()
        {
            if (historia.ToArray().Length == 0 && zly == 0) return;
            //InfoBox.Show(zly.ToString(), " ");
            string s = "";
            string h = Okno.textBox2.Text;
            int roz = h.Length;
            for (int i = 0; i < roz - 1; i++)
                s += h[i];
            Okno.textBox1.Text = h[roz - 1] + Okno.textBox1.Text;
            Okno.textBox2.Text = s;
            int c = historia.ToArray()[historia.Count - 1];
            //InfoBox.Show(c.ToString(), " ");
            historia.RemoveAt(historia.Count - 1);
            if (zly > 0) { zly--; if (zly != 0) return; }
            Obraz.PodWers(f.Stany.IndexOf(f.obecny), 0);
            Obraz.PodWers(c, 1);
            f.obecny = f.Stany[c];
        }



        static public void Reset()
        {
            Dialog.Nowa();
            for (int i = 0; i < f.Stany.ToArray().Length; i++)
                Obraz.PodWers(i, 0);
            Obraz.PodWers(0, 1);
            historia.Clear();
            f.Reset();
        }

        public static void RysujF()
        {
            if (f == null) { InfoBox.Show("Nie wybrano funkcji przejścia", ""); return; }
            ObudzElementy();
            f.Reset();
            while (Okno.dataGridView1.Columns.Count > 0) Okno.dataGridView1.Columns.Remove(Okno.dataGridView1.Columns[0]);
            Okno.dataGridView1.Update();

            rozalf = f.alfabet.Length;
            for (int i = 0; i <= rozalf; i++)
                Okno.dataGridView1.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            Okno.dataGridView1.Columns[0].HeaderText = Language.lang[5];
            for (int i = 0; i < rozalf; i++)
                Okno.dataGridView1.Columns[1 + i].HeaderText = " " + f.alfabet[i] + " ";

            foreach (Stan s in f.Stany)
            {
                string[] cell = new string[f.alfabet.Length + 2];
                cell[0] = s.nazwa;
                for (int i = 0; i < rozalf; i++)
                {
                    string n = null;
                    try
                    {
                        if (s.mapa.ContainsKey(f.alfabet[i]))
                            n = s.mapa[f.alfabet[i]].nazwa;
                        else n = null;
                    }
                    catch (Exception) { }
                    if (n == null) cell[i + 1] = "";
                    else cell[i + 1] = n;
                }

                Okno.dataGridView1.Rows.Add(cell);

            }
            Okno.dataGridView1.Rows[0].Cells[0].Selected = false;

            for (int i = 0; i < f.Stany.ToArray().Length; i++)
                if (f.Stany[i].koncowy) Okno.dataGridView1.Rows[i].Cells[0].Style.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            Obraz.PodWers(f.Stany.IndexOf(f.obecny), 1);
            Okno.dataGridView1.Invalidate();
        }

        public static void Test(FunkcjaPrzejscia fp)
        {
            f = fp;

            //	f = new FunkcjaPrzejscia(true);
        }

        public static void Wynik()
        {
            if (f.obecny.koncowy && zly == 0)
            {
                Okno.label5.ForeColor = Color.Green;
                Okno.label5.Text = Language.lang[42];
                ok = true;
            }
            else
            {
                Okno.label5.ForeColor = Color.Red;
                Okno.label5.Text = Language.lang[43];
            }
        }



    }
}
