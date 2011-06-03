namespace fsm {
		partial class EnterNameForm {
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
					this.EnterNameLabel = new System.Windows.Forms.Label();
					this.nameTextBox = new System.Windows.Forms.TextBox();
					this.OKbutton = new System.Windows.Forms.Button();
					this.MyCancelButton = new System.Windows.Forms.Button();
					this.SuspendLayout();
					// 
					// EnterNameLabel
					// 
					this.EnterNameLabel.AutoSize = true;
					this.EnterNameLabel.Location = new System.Drawing.Point(24, 9);
					this.EnterNameLabel.Name = "EnterNameLabel";
					this.EnterNameLabel.Size = new System.Drawing.Size(70, 13);
					this.EnterNameLabel.TabIndex = 0;
					this.EnterNameLabel.Text = "Wpisz nazwę";
					// 
					// nameTextBox
					// 
					this.nameTextBox.Location = new System.Drawing.Point(27, 45);
					this.nameTextBox.MaxLength = 15;
					this.nameTextBox.Name = "nameTextBox";
					this.nameTextBox.Size = new System.Drawing.Size(126, 20);
					this.nameTextBox.TabIndex = 1;
					// 
					// OKbutton
					// 
					this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
					this.OKbutton.Location = new System.Drawing.Point(97, 85);
					this.OKbutton.Name = "OKbutton";
					this.OKbutton.Size = new System.Drawing.Size(75, 23);
					this.OKbutton.TabIndex = 2;
					this.OKbutton.Text = "OK";
					this.OKbutton.UseVisualStyleBackColor = true;
					this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
					// 
					// MyCancelButton
					// 
					this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
					this.MyCancelButton.Location = new System.Drawing.Point(16, 85);
					this.MyCancelButton.Name = "MyCancelButton";
					this.MyCancelButton.Size = new System.Drawing.Size(75, 23);
					this.MyCancelButton.TabIndex = 3;
					this.MyCancelButton.Text = "Anuluj";
					this.MyCancelButton.UseVisualStyleBackColor = true;
					// 
					// EnterNameForm
					// 
					this.AcceptButton = this.OKbutton;
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(184, 111);
					this.Controls.Add(this.MyCancelButton);
					this.Controls.Add(this.OKbutton);
					this.Controls.Add(this.nameTextBox);
					this.Controls.Add(this.EnterNameLabel);
					this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
					this.Name = "EnterNameForm";
					this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					this.Text = "EnterNameForm";
					this.ResumeLayout(false);
					this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label EnterNameLabel;
				private System.Windows.Forms.TextBox nameTextBox;
				private System.Windows.Forms.Button OKbutton;
				private System.Windows.Forms.Button MyCancelButton;
		}
}