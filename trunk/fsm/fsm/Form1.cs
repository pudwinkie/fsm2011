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
    public partial class Form1 : Form
    {
        public List<Control> Elementy = new List<Control>();
				void zbierzElementy() {
						Elementy.Add(button1);
						Elementy.Add(textBox2);
						Elementy.Add(button2);
						Elementy.Add(button3);
						Elementy.Add(button4);
						Elementy.Add(button6);
						Elementy.Add(button7);
                        Elementy.Add(checkBox1);
						
				}
        internal void Inicjalizacja(FunkcjaPrzejscia fp)
        {
            button5.Enabled = false;
            textBox3.Font = new Font("Times New Roman", 30, FontStyle.Bold);
            Wizualizacja.Test(fp); // tworzy nową funkcje przejścia
            Wizualizacja.Okno = this;
            numerator.Value = 1;
            Dialog.Nowa();
            Wizualizacja.UspijElementy();
            button1.Enabled = true;
            label5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        public Form1()
        {
            InitializeComponent();
						zbierzElementy();
            Inicjalizacja(null);
        }

        private void createMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutomatCreator(this).ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Wizualizacja.UspijElementy();
            button4.Enabled = true;
            button5.Enabled = true;
            Wizualizacja.Wynik();
        }

        private void button8_Click(object sender, EventArgs e)
        {
					if (Wizualizacja.f == null) InfoBox.Show("Nie wybrano funkcji przejścia", "Error");
					else
					InfoBox.Show(Wizualizacja.f.info, Language.lang[0]+": "+Wizualizacja.f.nazwa);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dialog.Raport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while (numerator.Value > 0)
            {
                Wizualizacja.Cofnij();
                numerator.Value--;
                numerator.Update();

            }
            numerator.Value++;
            Wizualizacja.ObudzElementy();
        }
				private void loadFSMToolStripMenuItem_Click(object sender, EventArgs e) {
					if (openFileDialog.ShowDialog() == DialogResult.OK) {
						try {
								TextReader mR; 
								Encoding enc = Encoding.GetEncoding("Windows-1250");
							if ((mR = new StreamReader(openFileDialog.OpenFile(),enc)) != null) {
								FunkcjaPrzejscia fp = IOMachine.LoadMachine(mR);
								YesNoDialog yn = new YesNoDialog(" ", Language.lang[51]);
								yn.ShowDialog();
                                if (yn.DialogResult == DialogResult.No)
                                {
                                    Inicjalizacja(fp);
                                    Wizualizacja.RysujF();
                                }
								if (yn.DialogResult == DialogResult.Yes)
									new AutomatCreator(fp, this).ShowDialog();
                                    Inicjalizacja(fp);
                                    Wizualizacja.RysujF();
							}
						} catch (Exception ex) {
							InfoBox.Show(ex.Message);
						}
					}
				}

				private void languageToolStripMenuItem_Click(object sender, EventArgs e) {
						if(new LanguageDialog(this).ShowDialog()!=DialogResult.Abort)
								Dispose(true);
				}

                private void machineSpeedToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    new speed().ShowDialog();
                }
		}
}
