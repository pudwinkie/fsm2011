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
        public Form1()
        {
            InitializeComponent();
            Wizualizacja.Okno = this;
             
        }

        private void createMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutomatCreator().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wizualizacja.RysujF();
        }
    }
}
