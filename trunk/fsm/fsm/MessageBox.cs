using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class MessageBox : Form {
				public MessageBox(string title, string message) {
						InitializeComponent();
						Text = title;
						textBox1.Text = message;
				}
		}
}
