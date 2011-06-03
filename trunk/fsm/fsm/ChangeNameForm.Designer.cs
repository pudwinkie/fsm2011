namespace fsm {
		partial class ChangeNameForm {
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
					this.listaStarychNazw = new System.Windows.Forms.ComboBox();
					this.staraNazwaLabel = new System.Windows.Forms.Label();
					this.nowaNazwa = new System.Windows.Forms.TextBox();
					this.nowaNazwaLabel = new System.Windows.Forms.Label();
					this.okButton = new System.Windows.Forms.Button();
					this.myCancelButton = new System.Windows.Forms.Button();
					this.SuspendLayout();
					// 
					// listaStarychNazw
					// 
					this.listaStarychNazw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.listaStarychNazw.Location = new System.Drawing.Point(35, 53);
					this.listaStarychNazw.MaxLength = 1;
					this.listaStarychNazw.Name = "listaStarychNazw";
					this.listaStarychNazw.Size = new System.Drawing.Size(121, 21);
					this.listaStarychNazw.TabIndex = 0;
					// 
					// staraNazwaLabel
					// 
					this.staraNazwaLabel.AutoSize = true;
					this.staraNazwaLabel.Location = new System.Drawing.Point(32, 24);
					this.staraNazwaLabel.Name = "staraNazwaLabel";
					this.staraNazwaLabel.Size = new System.Drawing.Size(66, 13);
					this.staraNazwaLabel.TabIndex = 1;
					this.staraNazwaLabel.Text = "Stara nazwa";
					// 
					// nowaNazwa
					// 
					this.nowaNazwa.Location = new System.Drawing.Point(194, 53);
					this.nowaNazwa.Name = "nowaNazwa";
					this.nowaNazwa.Size = new System.Drawing.Size(100, 20);
					this.nowaNazwa.TabIndex = 2;
					// 
					// nowaNazwaLabel
					// 
					this.nowaNazwaLabel.AutoSize = true;
					this.nowaNazwaLabel.Location = new System.Drawing.Point(191, 24);
					this.nowaNazwaLabel.Name = "nowaNazwaLabel";
					this.nowaNazwaLabel.Size = new System.Drawing.Size(69, 13);
					this.nowaNazwaLabel.TabIndex = 3;
					this.nowaNazwaLabel.Text = "Nowa nazwa";
					// 
					// okButton
					// 
					this.okButton.Location = new System.Drawing.Point(261, 98);
					this.okButton.Name = "okButton";
					this.okButton.Size = new System.Drawing.Size(75, 23);
					this.okButton.TabIndex = 4;
					this.okButton.Text = "OK";
					this.okButton.UseVisualStyleBackColor = false;
					this.okButton.Click += new System.EventHandler(this.okButton_Click);
					// 
					// myCancelButton
					// 
					this.myCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
					this.myCancelButton.Location = new System.Drawing.Point(180, 98);
					this.myCancelButton.Name = "myCancelButton";
					this.myCancelButton.Size = new System.Drawing.Size(75, 23);
					this.myCancelButton.TabIndex = 5;
					this.myCancelButton.Text = "Anuluj";
					this.myCancelButton.UseVisualStyleBackColor = true;
					// 
					// ChangeNameForm
					// 
					this.AcceptButton = this.okButton;
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.CancelButton = this.myCancelButton;
					this.ClientSize = new System.Drawing.Size(341, 127);
					this.Controls.Add(this.myCancelButton);
					this.Controls.Add(this.okButton);
					this.Controls.Add(this.nowaNazwaLabel);
					this.Controls.Add(this.nowaNazwa);
					this.Controls.Add(this.staraNazwaLabel);
					this.Controls.Add(this.listaStarychNazw);
					this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
					this.Name = "ChangeNameForm";
					this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					this.Text = "ChangeName";
					this.ResumeLayout(false);
					this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.ComboBox listaStarychNazw;
				private System.Windows.Forms.Label staraNazwaLabel;
				private System.Windows.Forms.TextBox nowaNazwa;
				private System.Windows.Forms.Label nowaNazwaLabel;
				private System.Windows.Forms.Button okButton;
				private System.Windows.Forms.Button myCancelButton;
		}
}