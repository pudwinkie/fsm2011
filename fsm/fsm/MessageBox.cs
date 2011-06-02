using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class InfoBox : Form {
				InfoBox() {
						InitializeComponent();
				}
				public static void Show(string message, string title) {
						InfoBox ib = new InfoBox();
						ib.Text = title;
						ib.textBox1.Text = message;
						ib.ShowDialog();
				}
				public static void Show(string message) {
						InfoBox ib = new InfoBox();
						ib.textBox1.Text = message;
						ib.ShowDialog();
				}
		}
}
