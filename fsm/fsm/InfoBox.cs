using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class InfoBox : Form {
				public InfoBox(string title, string message) {
						InitializeComponent();
						this.Text = title;
						textBox1.Text = message;
				}
		}
}
