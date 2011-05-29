using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm {
		public partial class EnterNameForm : Form {
				private AutomatCreator parent;
				public EnterNameForm(string s, AutomatCreator p) {
						parent = p;
						InitializeComponent();
						EnterNameLabel.Text = s;
				}

				private void OKbutton_Click(object sender, EventArgs e) {
						parent.name = nameTextBox.Text;
				}
		}
}
