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
    //Musiał Mateusz
    public partial class speed : Form
    {
        int s;

        public speed()
        {
            InitializeComponent();
            s = 10 - (Wizualizacja.czasCzekania / 50);
            trackBar1.Value = s;
            label1.Text = s.ToString();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            s = trackBar1.Value;
            label1.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wizualizacja.czasCzekania = (10 - s) * 50;
            SetVisibleCore(false);
        }
    }
}
