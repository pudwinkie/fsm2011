namespace fsm {
		partial class About {
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
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.label4 = new System.Windows.Forms.Label();
						this.label5 = new System.Windows.Forms.Label();
						this.label6 = new System.Windows.Forms.Label();
						this.label7 = new System.Windows.Forms.Label();
						this.okButton = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
						this.label1.Location = new System.Drawing.Point(18, 20);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(243, 16);
						this.label1.TabIndex = 0;
						this.label1.Text = "Symulacja automatu skończonego";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
						this.label2.Location = new System.Drawing.Point(18, 61);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(55, 16);
						this.label2.TabIndex = 1;
						this.label2.Text = "Autorzy:";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
						this.label3.Location = new System.Drawing.Point(29, 86);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(108, 13);
						this.label3.TabIndex = 2;
						this.label3.Text = "Tomasz Bińczycki";
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
						this.label4.Location = new System.Drawing.Point(29, 99);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(96, 13);
						this.label4.TabIndex = 3;
						this.label4.Text = "Mateusz Musiał";
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Location = new System.Drawing.Point(29, 141);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(119, 13);
						this.label5.TabIndex = 4;
						this.label5.Text = "Uniwersytet Jagielloński";
						// 
						// label6
						// 
						this.label6.AutoSize = true;
						this.label6.Location = new System.Drawing.Point(29, 154);
						this.label6.Name = "label6";
						this.label6.Size = new System.Drawing.Size(162, 13);
						this.label6.TabIndex = 5;
						this.label6.Text = "Wydział Matematyki i Informatyki";
						// 
						// label7
						// 
						this.label7.AutoSize = true;
						this.label7.Location = new System.Drawing.Point(29, 167);
						this.label7.Name = "label7";
						this.label7.Size = new System.Drawing.Size(28, 13);
						this.label7.TabIndex = 6;
						this.label7.Text = "TCS";
						// 
						// okButton
						// 
						this.okButton.Location = new System.Drawing.Point(100, 191);
						this.okButton.Name = "okButton";
						this.okButton.Size = new System.Drawing.Size(75, 23);
						this.okButton.TabIndex = 7;
						this.okButton.Text = "OK";
						this.okButton.UseVisualStyleBackColor = true;
						this.okButton.Click += new System.EventHandler(this.okButton_Click);
						// 
						// About
						// 
						this.AcceptButton = this.okButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(278, 224);
						this.Controls.Add(this.okButton);
						this.Controls.Add(this.label7);
						this.Controls.Add(this.label6);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
						this.Name = "About";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "About";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Label label6;
				private System.Windows.Forms.Label label7;
				private System.Windows.Forms.Button okButton;
		}
}