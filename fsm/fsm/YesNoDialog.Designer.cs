﻿namespace fsm {
	partial class YesNoDialog {
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
				this.noButton = new System.Windows.Forms.Button();
				this.textBox = new System.Windows.Forms.Label();
				this.yesButton = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// noButton
				// 
				this.noButton.Location = new System.Drawing.Point(53, 60);
				this.noButton.Name = "noButton";
				this.noButton.Size = new System.Drawing.Size(75, 23);
				this.noButton.TabIndex = 0;
				this.noButton.Text = "Nie";
				this.noButton.UseVisualStyleBackColor = true;
				this.noButton.Click += new System.EventHandler(this.noButton_Click);
				// 
				// textBox
				// 
				this.textBox.AutoSize = true;
				this.textBox.Location = new System.Drawing.Point(50, 26);
				this.textBox.Name = "textBox";
				this.textBox.Size = new System.Drawing.Size(37, 13);
				this.textBox.TabIndex = 2;
				this.textBox.Text = "Tekst ";
				this.textBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				// yesButton
				// 
				this.yesButton.Location = new System.Drawing.Point(134, 61);
				this.yesButton.Name = "yesButton";
				this.yesButton.Size = new System.Drawing.Size(75, 23);
				this.yesButton.TabIndex = 3;
				this.yesButton.Text = "Tak";
				this.yesButton.UseVisualStyleBackColor = true;
				this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
				// 
				// YesNoDialog
				// 
				this.AcceptButton = this.yesButton;
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(260, 96);
				this.Controls.Add(this.yesButton);
				this.Controls.Add(this.textBox);
				this.Controls.Add(this.noButton);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
				this.Name = "YesNoDialog";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "YesNoDialog";
				this.ResumeLayout(false);
				this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button noButton;
		private System.Windows.Forms.Label textBox;
		private System.Windows.Forms.Button yesButton;
	}
}