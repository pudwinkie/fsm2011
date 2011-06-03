namespace fsm {
		partial class LanguageDialog {
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
						this.englishButton = new System.Windows.Forms.RadioButton();
						this.polishButton = new System.Windows.Forms.RadioButton();
						this.okButton = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// englishButton
						// 
						this.englishButton.AutoSize = true;
						this.englishButton.Location = new System.Drawing.Point(32, 31);
						this.englishButton.Name = "englishButton";
						this.englishButton.Size = new System.Drawing.Size(59, 17);
						this.englishButton.TabIndex = 0;
						this.englishButton.TabStop = true;
						this.englishButton.Text = "English";
						this.englishButton.UseVisualStyleBackColor = true;
						this.englishButton.CheckedChanged += new System.EventHandler(this.englishButton_CheckedChanged);
						// 
						// polishButton
						// 
						this.polishButton.AutoSize = true;
						this.polishButton.Location = new System.Drawing.Point(32, 54);
						this.polishButton.Name = "polishButton";
						this.polishButton.Size = new System.Drawing.Size(53, 17);
						this.polishButton.TabIndex = 1;
						this.polishButton.TabStop = true;
						this.polishButton.Text = "Polski";
						this.polishButton.UseVisualStyleBackColor = true;
						this.polishButton.CheckedChanged += new System.EventHandler(this.polishButton_CheckedChanged);
						// 
						// okButton
						// 
						this.okButton.Location = new System.Drawing.Point(133, 68);
						this.okButton.Name = "okButton";
						this.okButton.Size = new System.Drawing.Size(75, 23);
						this.okButton.TabIndex = 2;
						this.okButton.Text = "OK";
						this.okButton.UseVisualStyleBackColor = true;
						this.okButton.Click += new System.EventHandler(this.okButton_Click);
						// 
						// LanguageDialog
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(222, 103);
						this.Controls.Add(this.okButton);
						this.Controls.Add(this.polishButton);
						this.Controls.Add(this.englishButton);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
						this.Name = "LanguageDialog";
						this.Text = "LanguageDialog";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.RadioButton englishButton;
				private System.Windows.Forms.RadioButton polishButton;
				private System.Windows.Forms.Button okButton;
		}
}