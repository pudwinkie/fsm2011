namespace fsm {
		partial class RemoveDialog {
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
						this.listBox1 = new System.Windows.Forms.ListBox();
						this.removeButton = new System.Windows.Forms.Button();
						this.MyCancelButton = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(54, 9);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(108, 13);
						this.label1.TabIndex = 0;
						this.label1.Text = "Wybierz do usuniecia";
						// 
						// listBox1
						// 
						this.listBox1.FormattingEnabled = true;
						this.listBox1.Location = new System.Drawing.Point(57, 25);
						this.listBox1.Name = "listBox1";
						this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
						this.listBox1.Size = new System.Drawing.Size(162, 134);
						this.listBox1.TabIndex = 1;
						// 
						// removeButton
						// 
						this.removeButton.Location = new System.Drawing.Point(144, 170);
						this.removeButton.Name = "removeButton";
						this.removeButton.Size = new System.Drawing.Size(75, 23);
						this.removeButton.TabIndex = 2;
						this.removeButton.Text = "Remove";
						this.removeButton.UseVisualStyleBackColor = true;
						this.removeButton.Click += new System.EventHandler(this.button1_Click);
						// 
						// MyCancelButton
						// 
						this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
						this.MyCancelButton.Location = new System.Drawing.Point(57, 170);
						this.MyCancelButton.Name = "MyCancelButton";
						this.MyCancelButton.Size = new System.Drawing.Size(75, 23);
						this.MyCancelButton.TabIndex = 3;
						this.MyCancelButton.Text = "Cancel";
						this.MyCancelButton.UseVisualStyleBackColor = true;
						// 
						// RemoveDialog
						// 
						this.AcceptButton = this.removeButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.CancelButton = this.MyCancelButton;
						this.ClientSize = new System.Drawing.Size(284, 205);
						this.Controls.Add(this.MyCancelButton);
						this.Controls.Add(this.removeButton);
						this.Controls.Add(this.listBox1);
						this.Controls.Add(this.label1);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
						this.Name = "RemoveDialog";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.ListBox listBox1;
				private System.Windows.Forms.Button removeButton;
				private System.Windows.Forms.Button MyCancelButton;
		}
}