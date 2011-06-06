using System.Windows.Forms;

namespace fsm {
		//Tomasz Binczycki
		public partial class InfoBox : Form {
				InfoBox() {
						InitializeComponent();
						setLanguage();
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
				private void
						setLanguage() {
						this.OKButton.Text = Language.lang[29];// "OK";
						
				}
		}
}
