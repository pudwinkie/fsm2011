namespace fsm
{
    partial class Form1
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
						this.button1 = new System.Windows.Forms.Button();
						this.dataGridView1 = new System.Windows.Forms.DataGridView();
						this.textBox1 = new System.Windows.Forms.TextBox();
						this.textBox2 = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.textBox3 = new System.Windows.Forms.TextBox();
						this.button2 = new System.Windows.Forms.Button();
						this.button3 = new System.Windows.Forms.Button();
						this.button4 = new System.Windows.Forms.Button();
						this.numerator = new System.Windows.Forms.NumericUpDown();
						this.label4 = new System.Windows.Forms.Label();
						this.button5 = new System.Windows.Forms.Button();
						this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.createMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.loadFSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.menuStrip1 = new System.Windows.Forms.MenuStrip();
						this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
						((System.ComponentModel.ISupportInitialize)(this.numerator)).BeginInit();
						this.menuStrip1.SuspendLayout();
						this.SuspendLayout();
						// 
						// button1
						// 
						this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.button1.Location = new System.Drawing.Point(573, 27);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(77, 21);
						this.button1.TabIndex = 1;
						this.button1.Text = "Start";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.button1_Click);
						// 
						// dataGridView1
						// 
						this.dataGridView1.AllowUserToAddRows = false;
						this.dataGridView1.AllowUserToDeleteRows = false;
						this.dataGridView1.AllowUserToResizeColumns = false;
						this.dataGridView1.AllowUserToResizeRows = false;
						this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
												| System.Windows.Forms.AnchorStyles.Left)
												| System.Windows.Forms.AnchorStyles.Right)));
						this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
						this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
						this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.dataGridView1.CausesValidation = false;
						this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
						this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
						this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
						this.dataGridView1.EnableHeadersVisualStyles = false;
						this.dataGridView1.Location = new System.Drawing.Point(0, 27);
						this.dataGridView1.MultiSelect = false;
						this.dataGridView1.Name = "dataGridView1";
						this.dataGridView1.ReadOnly = true;
						this.dataGridView1.RowHeadersVisible = false;
						this.dataGridView1.ShowEditingIcon = false;
						this.dataGridView1.Size = new System.Drawing.Size(495, 214);
						this.dataGridView1.TabIndex = 2;
						this.dataGridView1.TabStop = false;
						// 
						// textBox1
						// 
						this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.textBox1.Location = new System.Drawing.Point(332, 286);
						this.textBox1.Multiline = true;
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(223, 55);
						this.textBox1.TabIndex = 3;
						this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
						// 
						// textBox2
						// 
						this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.textBox2.Location = new System.Drawing.Point(28, 286);
						this.textBox2.Multiline = true;
						this.textBox2.Name = "textBox2";
						this.textBox2.ReadOnly = true;
						this.textBox2.Size = new System.Drawing.Size(159, 55);
						this.textBox2.TabIndex = 4;
						// 
						// label1
						// 
						this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(467, 270);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(88, 13);
						this.label1.TabIndex = 5;
						this.label1.Text = "Dane Wejściowe";
						// 
						// label2
						// 
						this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(25, 270);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(100, 13);
						this.label2.TabIndex = 6;
						this.label2.Text = "Przetworzone Dane";
						// 
						// label3
						// 
						this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.label3.Location = new System.Drawing.Point(197, 244);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(120, 39);
						this.label3.TabIndex = 7;
						this.label3.Text = "Obecnie Rozpatrywana Litera";
						this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
						// 
						// textBox3
						// 
						this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.textBox3.Location = new System.Drawing.Point(229, 270);
						this.textBox3.Multiline = true;
						this.textBox3.Name = "textBox3";
						this.textBox3.ReadOnly = true;
						this.textBox3.Size = new System.Drawing.Size(55, 55);
						this.textBox3.TabIndex = 8;
						this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
						this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
						// 
						// button2
						// 
						this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.button2.Location = new System.Drawing.Point(572, 188);
						this.button2.Name = "button2";
						this.button2.Size = new System.Drawing.Size(78, 42);
						this.button2.TabIndex = 9;
						this.button2.Text = "Wykonaj";
						this.button2.UseVisualStyleBackColor = true;
						this.button2.Click += new System.EventHandler(this.button2_Click);
						// 
						// button3
						// 
						this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.button3.Location = new System.Drawing.Point(573, 286);
						this.button3.Name = "button3";
						this.button3.Size = new System.Drawing.Size(77, 42);
						this.button3.TabIndex = 10;
						this.button3.Text = "Wykonaj Całość";
						this.button3.UseVisualStyleBackColor = true;
						this.button3.Click += new System.EventHandler(this.button3_Click);
						// 
						// button4
						// 
						this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.button4.Location = new System.Drawing.Point(572, 54);
						this.button4.Name = "button4";
						this.button4.Size = new System.Drawing.Size(77, 24);
						this.button4.TabIndex = 11;
						this.button4.Text = "Reset";
						this.button4.UseVisualStyleBackColor = true;
						this.button4.Click += new System.EventHandler(this.button4_Click);
						// 
						// numerator
						// 
						this.numerator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.numerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
						this.numerator.Location = new System.Drawing.Point(572, 162);
						this.numerator.Name = "numerator";
						this.numerator.Size = new System.Drawing.Size(78, 26);
						this.numerator.TabIndex = 12;
						// 
						// label4
						// 
						this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.label4.Location = new System.Drawing.Point(570, 146);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(80, 13);
						this.label4.TabIndex = 13;
						this.label4.Text = "Ilość Kroków";
						// 
						// button5
						// 
						this.button5.Location = new System.Drawing.Point(573, 84);
						this.button5.Name = "button5";
						this.button5.Size = new System.Drawing.Size(77, 24);
						this.button5.TabIndex = 14;
						this.button5.Text = "Roport";
						this.button5.UseVisualStyleBackColor = true;
						// 
						// fileToolStripMenuItem
						// 
						this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMachineToolStripMenuItem,
            this.loadFSMToolStripMenuItem});
						this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
						this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
						this.fileToolStripMenuItem.Text = "File";
						// 
						// createMachineToolStripMenuItem
						// 
						this.createMachineToolStripMenuItem.Name = "createMachineToolStripMenuItem";
						this.createMachineToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
						this.createMachineToolStripMenuItem.Text = "Create Machine";
						this.createMachineToolStripMenuItem.Click += new System.EventHandler(this.createMachineToolStripMenuItem_Click);
						// 
						// loadFSMToolStripMenuItem
						// 
						this.loadFSMToolStripMenuItem.Name = "loadFSMToolStripMenuItem";
						this.loadFSMToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
						this.loadFSMToolStripMenuItem.Text = "Load FSM";
						this.loadFSMToolStripMenuItem.Click += new System.EventHandler(this.loadFSMToolStripMenuItem_Click);
						// 
						// menuStrip1
						// 
						this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
						this.menuStrip1.Location = new System.Drawing.Point(0, 0);
						this.menuStrip1.Name = "menuStrip1";
						this.menuStrip1.Size = new System.Drawing.Size(662, 24);
						this.menuStrip1.TabIndex = 0;
						this.menuStrip1.Text = "menuStrip1";
						// 
						// openFileDialog
						// 
						this.openFileDialog.DefaultExt = "fsm";
						this.openFileDialog.FileName = "Machine.fsm";
						this.openFileDialog.Title = "Open Finite State Machine";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(662, 353);
						this.Controls.Add(this.button5);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.numerator);
						this.Controls.Add(this.button4);
						this.Controls.Add(this.button3);
						this.Controls.Add(this.button2);
						this.Controls.Add(this.textBox3);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.textBox2);
						this.Controls.Add(this.textBox1);
						this.Controls.Add(this.dataGridView1);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.menuStrip1);
						this.MainMenuStrip = this.menuStrip1;
						this.MinimumSize = new System.Drawing.Size(670, 380);
						this.Name = "Form1";
						this.Text = "Finite State Machine Symulator";
						this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.numerator)).EndInit();
						this.menuStrip1.ResumeLayout(false);
						this.menuStrip1.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion

				public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.NumericUpDown numerator;
        public System.Windows.Forms.Label label4;
				private System.Windows.Forms.Button button5;
				public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
				public System.Windows.Forms.ToolStripMenuItem createMachineToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem loadFSMToolStripMenuItem;
				public System.Windows.Forms.MenuStrip menuStrip1;
				private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

