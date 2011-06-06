using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace fsm
{
    public partial class RaportInfo : Form
    {
        public RaportInfo()
        {
            InitializeComponent();
        }


        public RaportInfo(string s)
        {
           InitializeComponent();
           if (s!=null) textBox1.Text = s;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
						StreamWriter mR; 
						Encoding enc = Encoding.GetEncoding("Windows-1250");
					if ((mR = new StreamWriter(saveFileDialog.OpenFile(),enc)) != null) {
						using (mR) {
							mR.Write(Dialog.raportString);
						}
					}
				} catch (Exception ex) {
					InfoBox.Show(ex.Message);
				}
			}
			DialogResult = DialogResult.OK;
		
        }
    }
}
