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
    static class Obraz
    {

        public static void PodWers(int wers, int j)
        {
            Color[] tab = new Color[2];
            if (j == 1) { tab[0] = Wizualizacja.PodText; tab[1] = Wizualizacja.PodBack; }
            else { tab[1] = Color.White; tab[0] = Color.Black; }

            for (int i = 0; i <= Wizualizacja.rozalf; i++)
            {
                Wizualizacja.Okno.dataGridView1.Rows[wers].Cells[i].Style.BackColor = tab[1];
                Wizualizacja.Okno.dataGridView1.Rows[wers].Cells[i].Style.ForeColor = tab[0];
            }
        }

        public static void PodKol(int y, int j)
        {
            Color[] tab = new Color[2];
            if (j == 1) { tab[0] = Wizualizacja.PodText; tab[1] = Wizualizacja.PodBack; }
            else { tab[1] = Color.Black; tab[0] = Color.White; }
            Color[] tab2 = new Color[2];
            if (j == 1) { tab2[0] = Wizualizacja.PodText; tab2[1] = Wizualizacja.PodBack; }
            else { tab2[1] = SystemColors.ControlText; tab2[0] = SystemColors.ActiveBorder; }

            for (int i = 0; i < Wizualizacja.f.Stany.Count; i++)
            {
                Wizualizacja.Okno.dataGridView1.Rows[i].Cells[y].Style.BackColor = tab[j % 2];
                Wizualizacja.Okno.dataGridView1.Rows[i].Cells[y].Style.ForeColor = tab[(j + 1) % 2];
            }
            Wizualizacja.Okno.dataGridView1.Columns[y].HeaderCell.Style.BackColor = tab2[j % 2];
            Wizualizacja.Okno.dataGridView1.Columns[y].HeaderCell.Style.ForeColor = tab2[(j + 1) % 2];
            System.Threading.Thread.Sleep(Wizualizacja.czasCzekania);
        }

        public static void MrugajLit()
        {
            Color[] tab = { Color.White, Color.Black };
            for (int j = 1; j <= Wizualizacja.ileMrugniec; j++)
            {
                Wizualizacja.Okno.textBox3.BackColor = tab[j % 2];
                Wizualizacja.Okno.textBox3.ForeColor = tab[(j + 1) % 2];
                Wizualizacja.Okno.textBox3.Update();
                System.Threading.Thread.Sleep(Wizualizacja.czasCzekania);
            }
        }

        public static void Mrugaj(int p)
        {
            Color[] tab = { Color.White, Color.Black };

            for (int j = 1; j <= Wizualizacja.ileMrugniec; j++)
            {
                for (int i = 0; i <= Wizualizacja.rozalf; i++)
                {
                    Wizualizacja.Okno.dataGridView1.Rows[p].Cells[i].Style.BackColor = tab[j % 2];
                    Wizualizacja.Okno.dataGridView1.Rows[p].Cells[i].Style.ForeColor = tab[(j + 1) % 2];
                }
                Wizualizacja.Okno.dataGridView1.Update();
                System.Threading.Thread.Sleep(Wizualizacja.czasCzekania/2);
            }
        }

        public static void Mrugaj(int x, int y)
        {
            Color[] tab = { Color.White, Color.Black };

            for (int j = 1; j <= Wizualizacja.ileMrugniec; j++)
            {

                Wizualizacja.Okno.dataGridView1.Rows[x].Cells[y].Style.BackColor = tab[j % 2];
                Wizualizacja.Okno.dataGridView1.Rows[x].Cells[y].Style.ForeColor = tab[(j + 1) % 2];
                Wizualizacja.Okno.dataGridView1.Update();
                System.Threading.Thread.Sleep(Wizualizacja.czasCzekania);
            }
        }

        public static void Mrugaj(int x, int y, int j)
        {
            Color[] tab = { Color.White, Color.Black };

            Wizualizacja.Okno.dataGridView1.Rows[x].Cells[y].Style.BackColor = tab[j % 2];
            Wizualizacja.Okno.dataGridView1.Rows[x].Cells[y].Style.ForeColor = tab[(j + 1) % 2];

            Wizualizacja.Okno.dataGridView1.Update();
           

        }
    }
}
