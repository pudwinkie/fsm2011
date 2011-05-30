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
    public partial class Form1 : Form
    {
        public List<Control> Elementy = new List<Control>();
        void Inicjalizacja()
        {
            Elementy.Add(button1);
            Elementy.Add(textBox2);
            Elementy.Add(button2);
            Elementy.Add(button3);
            Elementy.Add(button4);
            button5.Enabled = false;
            textBox3.Font = new Font("Times New Roman", 30, FontStyle.Bold);
            Wizualizacja.Test(); // tworzy nową funkcje przejścia
            Wizualizacja.Okno = this;
            numerator.Value = 1;

            Wizualizacja.UspijElementy();
            button1.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            Inicjalizacja();
            
             
        }

        private void createMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutomatCreator().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wizualizacja.RysujF();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0) textBox3.Text = textBox1.Text[0]+"";
            else
                textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wizualizacja.UspijElementy();

            while (numerator.Value > 0)
            {
                Wizualizacja.Krok();
                numerator.Value--;
                numerator.Update();
                
            }
            numerator.Value++;
            Wizualizacja.ObudzElementy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wizualizacja.UspijElementy();
            while (textBox1.Text!="") Wizualizacja.Krok();
            Wizualizacja.ObudzElementy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wizualizacja.UspijElementy();
            Wizualizacja.Reset();
            Wizualizacja.ObudzElementy();
        }



       
    }
}
