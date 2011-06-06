namespace fsm {
		partial class SaveMachineDialog {
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
						this.questionLabel = new System.Windows.Forms.Label();
						this.nieButton = new System.Windows.Forms.Button();
						this.yesButton = new System.Windows.Forms.Button();
						this.anulujButton = new System.Windows.Forms.Button();
						this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
						this.nazwaTextBox = new System.Windows.Forms.TextBox();
						this.opisTextBox = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// questionLabel
						// 
						this.questionLabel.AutoSize = true;
						this.questionLabel.Location = new System.Drawing.Point(32, 240);
						this.questionLabel.Name = "questionLabel";
						this.questionLabel.Size = new System.Drawing.Size(147, 13);
						this.questionLabel.TabIndex = 0;
						this.questionLabel.Text = "Czy chcesz zapisac automat?";
						// 
						// nieButton
						// 
						this.nieButton.Location = new System.Drawing.Point(35, 256);
						this.nieButton.Name = "nieButton";
						this.nieButton.Size = new System.Drawing.Size(75, 23);
						this.nieButton.TabIndex = 1;
						this.nieButton.Text = "Nie";
						this.nieButton.UseVisualStyleBackColor = true;
						this.nieButton.Click += new System.EventHandler(this.noButton_Click);
						// 
						// yesButton
						// 
						this.yesButton.Location = new System.Drawing.Point(197, 256);
						this.yesButton.Name = "yesButton";
						this.yesButton.Size = new System.Drawing.Size(75, 23);
						this.yesButton.TabIndex = 2;
						this.yesButton.Text = "Tak";
						this.yesButton.UseVisualStyleBackColor = true;
						this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
						// 
						// anulujButton
						// 
						this.anulujButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
						this.anulujButton.Location = new System.Drawing.Point(116, 256);
						this.anulujButton.Name = "anulujButton";
						this.anulujButton.Size = new System.Drawing.Size(75, 23);
						this.anulujButton.TabIndex = 3;
						this.anulujButton.Text = "Anuluj";
						this.anulujButton.UseVisualStyleBackColor = true;
						// 
						// saveFileDialog
						// 
						this.saveFileDialog.FileName = "Machine";
						this.saveFileDialog.Filter = "Plik automatu (*.fsm)|*.fsm|Plik tekstowy(*.txt)|*.txt|All Files|*.*";
						// 
						// nazwaTextBox
						// 
						this.nazwaTextBox.Location = new System.Drawing.Point(33, 53);
						this.nazwaTextBox.MaxLength = 100;
						this.nazwaTextBox.Name = "nazwaTextBox";
						this.nazwaTextBox.Size = new System.Drawing.Size(158, 20);
						this.nazwaTextBox.TabIndex = 4;
						// 
						// opisTextBox
						// 
						this.opisTextBox.Location = new System.Drawing.Point(33, 109);
						this.opisTextBox.Multiline = true;
						this.opisTextBox.Name = "opisTextBox";
						this.opisTextBox.Size = new System.Drawing.Size(239, 115);
						this.opisTextBox.TabIndex = 5;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(30, 37);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(87, 13);
						this.label1.TabIndex = 6;
						this.label1.Text = "Nazwa automatu";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(32, 93);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(75, 13);
						this.label2.TabIndex = 7;
						this.label2.Text = "Opis automatu";
						// 
						// SaveMachineDialog
						// 
						this.AcceptButton = this.yesButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.CancelButton = this.anulujButton;
						this.ClientSize = new System.Drawing.Size(315, 297);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.opisTextBox);
						this.Controls.Add(this.nazwaTextBox);
						this.Controls.Add(this.anulujButton);
						this.Controls.Add(this.yesButton);
						this.Controls.Add(this.nieButton);
						this.Controls.Add(this.questionLabel);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
						this.Name = "SaveMachineDialog";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "Zapisz automat";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label questionLabel;
				private System.Windows.Forms.Button nieButton;
				private System.Windows.Forms.Button yesButton;
				private System.Windows.Forms.Button anulujButton;
				private System.Windows.Forms.SaveFileDialog saveFileDialog;
				private System.Windows.Forms.TextBox nazwaTextBox;
				private System.Windows.Forms.TextBox opisTextBox;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
		}
}