﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm
{
    class Dialog
    {


        public static void Error(int i)
        {
            switch (i)
            {
                case 0: InfoBox.Show("Brak załadowanej Funkcji Przejścia","Błąd"); break;
								case 1: InfoBox.Show("Brak danych wejściowych", "Błąd"); break;
            }
        }

        static public void Nowa()
        {
            Wizualizacja.Okno.textBox1.Text = "";
            Wizualizacja.Okno.textBox2.Text = "";
            Wizualizacja.Okno.label5.Text = "";
            Wizualizacja.zly = 0;
            Wizualizacja.ok = false;
        }

        public static bool CzyFIstnieje()
        {
            if (Wizualizacja.f == null)
            {
               Error(0);
                return false;
            }
            return true;
        }




        public static void Raport()
        {
            string s = "";
            FunkcjaPrzejscia f = Wizualizacja.f;
            s += Language.lang[0] + f.nazwa + Environment.NewLine;
						if (Wizualizacja.ok) s += Language.lang[30]; else s += Language.lang[31];
            s += Environment.NewLine;
            s += Wizualizacja.Okno.textBox2.Text;
            s += Environment.NewLine;
            InfoBox.Show(s,Language.lang[32]);
        }
    }


}