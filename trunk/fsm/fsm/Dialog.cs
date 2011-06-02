using System;
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
                case 0: MessageBox.Show("Brak załadowanej Funkcji Przejścia","Błąd"); break;
								case 1: MessageBox.Show("Brak danych wejściowych", "Błąd"); break;
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
            s += "Maszyna: " + f.nazwa + Environment.NewLine;
            if (Wizualizacja.ok) s += "zaakceptowała słowo: "; else s+="odrzuciła słowo: ";
            s += Environment.NewLine;
            s += Wizualizacja.Okno.textBox2.Text;
            s += Environment.NewLine;
            MessageBox.Show(s,"Raport");
        }
    }


}
