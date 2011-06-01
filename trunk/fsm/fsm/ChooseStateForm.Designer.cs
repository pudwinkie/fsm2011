namespace fsm {
		partial class ChooseStateForm {
				/// <summary>
				/// Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing) {
						if (disposing && (components != null)) {
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				/// Required method for Designer support - do not modify
				/// the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent() {
						this.stateComboBox = new System.Windows.Forms.ComboBox();
						this.label1 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// stateComboBox
						// 
						this.stateComboBox.FormattingEnabled = true;
						this.stateComboBox.Location = new System.Drawing.Point(36, 41);
						this.stateComboBox.Name = "stateComboBox";
						this.stateComboBox.Size = new System.Drawing.Size(156, 21);
						this.stateComboBox.TabIndex = 0;
						this.stateComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(35, 19);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(68, 13);
						this.label1.TabIndex = 1;
						this.label1.Text = "Wybierz stan";
						// 
						// ChooseStateForm
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(260, 96);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.stateComboBox);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
						this.Name = "ChooseStateForm";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "Choose State";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.ComboBox stateComboBox;
				private System.Windows.Forms.Label label1;
		}
}