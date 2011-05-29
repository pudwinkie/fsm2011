namespace fsm
{
    partial class AutomatCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
						this.FunkcjaPrzejsciaTable = new System.Windows.Forms.DataGridView();
						this.AddLetterButton = new System.Windows.Forms.Button();
						this.AddStateButton = new System.Windows.Forms.Button();
						this.RemoveStateButton = new System.Windows.Forms.Button();
						this.RemoveLetterButton = new System.Windows.Forms.Button();
						this.DoneButton = new System.Windows.Forms.Button();
						this.MyCancelButton = new System.Windows.Forms.Button();
						this.AcceptingColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
						this.Letter1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
						((System.ComponentModel.ISupportInitialize)(this.FunkcjaPrzejsciaTable)).BeginInit();
						this.SuspendLayout();
						// 
						// FunkcjaPrzejsciaTable
						// 
						this.FunkcjaPrzejsciaTable.AllowUserToAddRows = false;
						this.FunkcjaPrzejsciaTable.AllowUserToDeleteRows = false;
						this.FunkcjaPrzejsciaTable.AllowUserToOrderColumns = true;
						this.FunkcjaPrzejsciaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.FunkcjaPrzejsciaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcceptingColumn,
            this.Letter1});
						this.FunkcjaPrzejsciaTable.Location = new System.Drawing.Point(12, 65);
						this.FunkcjaPrzejsciaTable.Name = "FunkcjaPrzejsciaTable";
						this.FunkcjaPrzejsciaTable.Size = new System.Drawing.Size(435, 215);
						this.FunkcjaPrzejsciaTable.TabIndex = 0;
						// 
						// AddLetterButton
						// 
						this.AddLetterButton.Location = new System.Drawing.Point(5, 7);
						this.AddLetterButton.Name = "AddLetterButton";
						this.AddLetterButton.Size = new System.Drawing.Size(75, 23);
						this.AddLetterButton.TabIndex = 1;
						this.AddLetterButton.Text = "Add Letter";
						this.AddLetterButton.UseVisualStyleBackColor = true;
						this.AddLetterButton.Click += new System.EventHandler(this.AddLetterButton_Click);
						// 
						// AddStateButton
						// 
						this.AddStateButton.Location = new System.Drawing.Point(5, 36);
						this.AddStateButton.Name = "AddStateButton";
						this.AddStateButton.Size = new System.Drawing.Size(75, 23);
						this.AddStateButton.TabIndex = 2;
						this.AddStateButton.Text = "Add State";
						this.AddStateButton.UseVisualStyleBackColor = true;
						this.AddStateButton.Click += new System.EventHandler(this.AddStateButton_Click);
						// 
						// RemoveStateButton
						// 
						this.RemoveStateButton.Location = new System.Drawing.Point(456, 36);
						this.RemoveStateButton.Name = "RemoveStateButton";
						this.RemoveStateButton.Size = new System.Drawing.Size(86, 23);
						this.RemoveStateButton.TabIndex = 3;
						this.RemoveStateButton.Text = "Remove State";
						this.RemoveStateButton.UseVisualStyleBackColor = true;
						this.RemoveStateButton.Click += new System.EventHandler(this.RemoveStateButton_Click);
						// 
						// RemoveLetterButton
						// 
						this.RemoveLetterButton.Location = new System.Drawing.Point(456, 7);
						this.RemoveLetterButton.Name = "RemoveLetterButton";
						this.RemoveLetterButton.Size = new System.Drawing.Size(86, 23);
						this.RemoveLetterButton.TabIndex = 4;
						this.RemoveLetterButton.Text = "Remove Letter";
						this.RemoveLetterButton.UseVisualStyleBackColor = true;
						this.RemoveLetterButton.Click += new System.EventHandler(this.RemoveLetterButton_Click);
						// 
						// DoneButton
						// 
						this.DoneButton.Location = new System.Drawing.Point(456, 381);
						this.DoneButton.Name = "DoneButton";
						this.DoneButton.Size = new System.Drawing.Size(86, 23);
						this.DoneButton.TabIndex = 5;
						this.DoneButton.Text = "Done";
						this.DoneButton.UseVisualStyleBackColor = true;
						// 
						// MyCancelButton
						// 
						this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
						this.MyCancelButton.Location = new System.Drawing.Point(375, 381);
						this.MyCancelButton.Name = "MyCancelButton";
						this.MyCancelButton.Size = new System.Drawing.Size(75, 23);
						this.MyCancelButton.TabIndex = 6;
						this.MyCancelButton.Text = "Cancel";
						this.MyCancelButton.UseVisualStyleBackColor = true;
						// 
						// AcceptingColumn
						// 
						this.AcceptingColumn.HeaderText = "Accepting";
						this.AcceptingColumn.Name = "AcceptingColumn";
						this.AcceptingColumn.Width = 60;
						// 
						// Letter1
						// 
						this.Letter1.HeaderText = "a";
						this.Letter1.Name = "Letter1";
						// 
						// AutomatCreator
						// 
						this.AcceptButton = this.DoneButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(554, 416);
						this.Controls.Add(this.MyCancelButton);
						this.Controls.Add(this.DoneButton);
						this.Controls.Add(this.RemoveLetterButton);
						this.Controls.Add(this.RemoveStateButton);
						this.Controls.Add(this.AddStateButton);
						this.Controls.Add(this.AddLetterButton);
						this.Controls.Add(this.FunkcjaPrzejsciaTable);
						this.Name = "AutomatCreator";
						this.Text = "AutomatCreator";
						((System.ComponentModel.ISupportInitialize)(this.FunkcjaPrzejsciaTable)).EndInit();
						this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FunkcjaPrzejsciaTable;
        private System.Windows.Forms.Button AddLetterButton;
        private System.Windows.Forms.Button AddStateButton;
        private System.Windows.Forms.Button RemoveStateButton;
        private System.Windows.Forms.Button RemoveLetterButton;
				private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button MyCancelButton;
				private System.Windows.Forms.DataGridViewCheckBoxColumn AcceptingColumn;
				private System.Windows.Forms.DataGridViewComboBoxColumn Letter1;
    }
}