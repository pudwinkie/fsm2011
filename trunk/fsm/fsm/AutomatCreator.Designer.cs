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
						this.fPTable = new System.Windows.Forms.DataGridView();
						this.AddLetterButton = new System.Windows.Forms.Button();
						this.AddStateButton = new System.Windows.Forms.Button();
						this.RemoveStateButton = new System.Windows.Forms.Button();
						this.RemoveLetterButton = new System.Windows.Forms.Button();
						this.DoneButton = new System.Windows.Forms.Button();
						this.MyCancelButton = new System.Windows.Forms.Button();
						this.AcceptingColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
						this.StateNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
						this.Letter1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
						((System.ComponentModel.ISupportInitialize)(this.fPTable)).BeginInit();
						this.SuspendLayout();
						// 
						// fPTable
						// 
						this.fPTable.AllowUserToAddRows = false;
						this.fPTable.AllowUserToDeleteRows = false;
						this.fPTable.AllowUserToOrderColumns = true;
						this.fPTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
												| System.Windows.Forms.AnchorStyles.Left)
												| System.Windows.Forms.AnchorStyles.Right)));
						this.fPTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.fPTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcceptingColumn,
            this.StateNameColumn,
            this.Letter1});
						this.fPTable.Location = new System.Drawing.Point(12, 42);
						this.fPTable.Name = "fPTable";
						this.fPTable.Size = new System.Drawing.Size(550, 232);
						this.fPTable.TabIndex = 0;
						// 
						// AddLetterButton
						// 
						this.AddLetterButton.Location = new System.Drawing.Point(12, 13);
						this.AddLetterButton.Name = "AddLetterButton";
						this.AddLetterButton.Size = new System.Drawing.Size(75, 23);
						this.AddLetterButton.TabIndex = 1;
						this.AddLetterButton.Text = "Add Letter";
						this.AddLetterButton.UseVisualStyleBackColor = true;
						this.AddLetterButton.Click += new System.EventHandler(this.AddLetterButton_Click);
						// 
						// AddStateButton
						// 
						this.AddStateButton.Location = new System.Drawing.Point(93, 13);
						this.AddStateButton.Name = "AddStateButton";
						this.AddStateButton.Size = new System.Drawing.Size(75, 23);
						this.AddStateButton.TabIndex = 2;
						this.AddStateButton.Text = "Add State";
						this.AddStateButton.UseVisualStyleBackColor = true;
						this.AddStateButton.Click += new System.EventHandler(this.AddStateButton_Click);
						// 
						// RemoveStateButton
						// 
						this.RemoveStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.RemoveStateButton.Location = new System.Drawing.Point(476, 13);
						this.RemoveStateButton.Name = "RemoveStateButton";
						this.RemoveStateButton.Size = new System.Drawing.Size(86, 23);
						this.RemoveStateButton.TabIndex = 3;
						this.RemoveStateButton.Text = "Remove State";
						this.RemoveStateButton.UseVisualStyleBackColor = true;
						this.RemoveStateButton.Click += new System.EventHandler(this.RemoveStateButton_Click);
						// 
						// RemoveLetterButton
						// 
						this.RemoveLetterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.RemoveLetterButton.Location = new System.Drawing.Point(384, 13);
						this.RemoveLetterButton.Name = "RemoveLetterButton";
						this.RemoveLetterButton.Size = new System.Drawing.Size(86, 23);
						this.RemoveLetterButton.TabIndex = 4;
						this.RemoveLetterButton.Text = "Remove Letter";
						this.RemoveLetterButton.UseVisualStyleBackColor = true;
						this.RemoveLetterButton.Click += new System.EventHandler(this.RemoveLetterButton_Click);
						// 
						// DoneButton
						// 
						this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.DoneButton.Location = new System.Drawing.Point(476, 280);
						this.DoneButton.Name = "DoneButton";
						this.DoneButton.Size = new System.Drawing.Size(86, 23);
						this.DoneButton.TabIndex = 5;
						this.DoneButton.Text = "Done";
						this.DoneButton.UseVisualStyleBackColor = true;
						// 
						// MyCancelButton
						// 
						this.MyCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
						this.MyCancelButton.Location = new System.Drawing.Point(395, 280);
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
						// StateNameColumn
						// 
						this.StateNameColumn.HeaderText = "State name";
						this.StateNameColumn.Name = "StateNameColumn";
						this.StateNameColumn.Width = 95;
						// 
						// Letter1
						// 
						this.Letter1.HeaderText = "a";
						this.Letter1.Name = "Letter1";
						this.Letter1.Width = 50;
						// 
						// AutomatCreator
						// 
						this.AcceptButton = this.DoneButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(574, 315);
						this.Controls.Add(this.MyCancelButton);
						this.Controls.Add(this.DoneButton);
						this.Controls.Add(this.RemoveLetterButton);
						this.Controls.Add(this.RemoveStateButton);
						this.Controls.Add(this.AddStateButton);
						this.Controls.Add(this.AddLetterButton);
						this.Controls.Add(this.fPTable);
						this.Name = "AutomatCreator";
						this.Text = "AutomatCreator";
						((System.ComponentModel.ISupportInitialize)(this.fPTable)).EndInit();
						this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fPTable;
        private System.Windows.Forms.Button AddLetterButton;
        private System.Windows.Forms.Button AddStateButton;
        private System.Windows.Forms.Button RemoveStateButton;
        private System.Windows.Forms.Button RemoveLetterButton;
				private System.Windows.Forms.Button DoneButton;
				private System.Windows.Forms.Button MyCancelButton;
				private System.Windows.Forms.DataGridViewCheckBoxColumn AcceptingColumn;
				private System.Windows.Forms.DataGridViewTextBoxColumn StateNameColumn;
				private System.Windows.Forms.DataGridViewComboBoxColumn Letter1;
    }
}