using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm {
		public partial class About : Form {
				public About() {
						InitializeComponent();
						setLanguage();
				}
				private void setLanguage() {
						this.label1.Text = Language.lang[79]; //"Symulacja automatu skończonego";
						this.label2.Text = Language.lang[76];// "Autorzy:";
						this.label5.Text = Language.lang[77];// "Uniwersytet Jagielloński";
						this.label6.Text = Language.lang[78]; //"Wydział Matematyki i Informatyki";
						this.okButton.Text = Language.lang[29];
				}
				private void okButton_Click(object sender, EventArgs e) {
						Dispose();
				}
		}
}
