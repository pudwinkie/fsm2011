using System.Windows.Forms;

namespace fsm {
		public partial class InfoBox : Form {
				private InfoBox() {
						InitializeComponent();
				}
				static public void Show(string message, string title) {
						InfoBox ib = new InfoBox();
						ib.Text = title;
						ib.textBox1.Text = message;
						ib.ShowDialog();
				}
				static public void Show(string message) {
						InfoBox ib = new InfoBox();
						ib.Text = " ";
						ib.textBox1.Text = message;
						ib.ShowDialog();
				}
		}
}
