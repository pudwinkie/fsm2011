using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fsm {
		public partial class ChooseStateForm : Form {
				DataGridViewTextBoxCell cell;
				public ChooseStateForm(List<string> source, DataGridViewTextBoxCell c) {
						InitializeComponent();
						stateComboBox.DataSource = source;
						cell = c;
				}

				private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
						cell.Value = stateComboBox.Text;
						SetVisibleCore(false);
				}
		}
}
