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
						this.Accepting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
						this.StateNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
						this.a = new System.Windows.Forms.DataGridViewComboBoxColumn();
						this.AddLetterButton = new System.Windows.Forms.Button();
						this.AddStateButton = new System.Windows.Forms.Button();
						this.RemoveStateButton = new System.Windows.Forms.Button();
						this.RemoveLetterButton = new System.Windows.Forms.Button();
						this.DoneButton = new System.Windows.Forms.Button();
						this.MyCancelButton = new System.Windows.Forms.Button();
						this.changeLetterButton = new System.Windows.Forms.Button();
						this.ChangeStateNameButton = new System.Windows.Forms.Button();
						this.randomButton = new System.Windows.Forms.Button();
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
            this.Accepting,
            this.StateNameColumn,
            this.a});
						this.fPTable.Location = new System.Drawing.Point(12, 71);
						this.fPTable.Name = "fPTable";
						this.fPTable.RowHeadersVisible = false;
						this.fPTable.Size = new System.Drawing.Size(557, 235);
						this.fPTable.TabIndex = 0;
						// 
						// Accepting
						// 
						this.Accepting.HeaderText = "Accepting";
						this.Accepting.Name = "Accepting";
						this.Accepting.Width = 60;
						// 
						// StateNameColumn
						// 
						this.StateNameColumn.HeaderText = "State name";
						this.StateNameColumn.Name = "StateNameColumn";
						this.StateNameColumn.ReadOnly = true;
						this.StateNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
						this.StateNameColumn.Width = 95;
						// 
						// a
						// 
						this.a.HeaderText = "a";
						this.a.Name = "a";
						this.a.Width = 50;
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
						this.AddStateButton.Location = new System.Drawing.Point(12, 42);
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
						this.RemoveStateButton.Location = new System.Drawing.Point(483, 42);
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
						this.RemoveLetterButton.Location = new System.Drawing.Point(483, 13);
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
						this.DoneButton.Location = new System.Drawing.Point(484, 312);
						this.DoneButton.Name = "DoneButton";
						this.DoneButton.Size = new System.Drawing.Size(86, 23);
						this.DoneButton.TabIndex = 5;
						this.DoneButton.Text = "Done";
						this.DoneButton.UseVisualStyleBackColor = true;
						this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
						// 
						// MyCancelButton
						// 
						this.MyCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
						this.MyCancelButton.Location = new System.Drawing.Point(403, 312);
						this.MyCancelButton.Name = "MyCancelButton";
						this.MyCancelButton.Size = new System.Drawing.Size(75, 23);
						this.MyCancelButton.TabIndex = 6;
						this.MyCancelButton.Text = "Cancel";
						this.MyCancelButton.UseVisualStyleBackColor = true;
						// 
						// changeLetterButton
						// 
						this.changeLetterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
						this.changeLetterButton.Location = new System.Drawing.Point(234, 13);
						this.changeLetterButton.Name = "changeLetterButton";
						this.changeLetterButton.Size = new System.Drawing.Size(108, 23);
						this.changeLetterButton.TabIndex = 7;
						this.changeLetterButton.Text = "Change letter";
						this.changeLetterButton.UseVisualStyleBackColor = true;
						this.changeLetterButton.Click += new System.EventHandler(this.changeLetterButton_Click);
						// 
						// ChangeStateNameButton
						// 
						this.ChangeStateNameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
						this.ChangeStateNameButton.Location = new System.Drawing.Point(234, 42);
						this.ChangeStateNameButton.Name = "ChangeStateNameButton";
						this.ChangeStateNameButton.Size = new System.Drawing.Size(108, 23);
						this.ChangeStateNameButton.TabIndex = 8;
						this.ChangeStateNameButton.Text = "Change state name";
						this.ChangeStateNameButton.UseVisualStyleBackColor = true;
						this.ChangeStateNameButton.Click += new System.EventHandler(this.ChangeStateNameButton_Click);
						// 
						// randomButton
						// 
						this.randomButton.Location = new System.Drawing.Point(12, 312);
						this.randomButton.Name = "randomButton";
						this.randomButton.Size = new System.Drawing.Size(75, 23);
						this.randomButton.TabIndex = 9;
						this.randomButton.Text = "Random";
						this.randomButton.UseVisualStyleBackColor = true;
						this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
						// 
						// AutomatCreator
						// 
						this.AcceptButton = this.DoneButton;
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(581, 347);
						this.Controls.Add(this.randomButton);
						this.Controls.Add(this.ChangeStateNameButton);
						this.Controls.Add(this.changeLetterButton);
						this.Controls.Add(this.MyCancelButton);
						this.Controls.Add(this.DoneButton);
						this.Controls.Add(this.RemoveLetterButton);
						this.Controls.Add(this.RemoveStateButton);
						this.Controls.Add(this.AddStateButton);
						this.Controls.Add(this.AddLetterButton);
						this.Controls.Add(this.fPTable);
						this.MinimumSize = new System.Drawing.Size(350, 200);
						this.Name = "AutomatCreator";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
				private System.Windows.Forms.Button changeLetterButton;
				private System.Windows.Forms.Button ChangeStateNameButton;
				private System.Windows.Forms.DataGridViewCheckBoxColumn Accepting;
				private System.Windows.Forms.DataGridViewTextBoxColumn StateNameColumn;
				private System.Windows.Forms.DataGridViewComboBoxColumn a;
				private System.Windows.Forms.Button randomButton;
    }
}