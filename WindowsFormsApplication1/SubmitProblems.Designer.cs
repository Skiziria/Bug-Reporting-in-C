namespace WindowsFormsApplication1
{
    partial class SubmitProblems
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
            this.CurrentDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.SubBox = new System.Windows.Forms.TextBox();
            this.EntryBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeletBut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentDataGrid
            // 
            this.CurrentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentDataGrid.Location = new System.Drawing.Point(12, 217);
            this.CurrentDataGrid.Name = "CurrentDataGrid";
            this.CurrentDataGrid.ReadOnly = true;
            this.CurrentDataGrid.Size = new System.Drawing.Size(656, 227);
            this.CurrentDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entry ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Submitted By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(283, 6);
            this.CodeBox.Multiline = true;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(234, 184);
            this.CodeBox.TabIndex = 5;
            // 
            // SubBox
            // 
            this.SubBox.Location = new System.Drawing.Point(87, 32);
            this.SubBox.Name = "SubBox";
            this.SubBox.Size = new System.Drawing.Size(152, 20);
            this.SubBox.TabIndex = 6;
            // 
            // EntryBox
            // 
            this.EntryBox.Location = new System.Drawing.Point(63, 6);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Size = new System.Drawing.Size(176, 20);
            this.EntryBox.TabIndex = 7;
            // 
            // DetailsBox
            // 
            this.DetailsBox.Location = new System.Drawing.Point(98, 84);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(141, 106);
            this.DetailsBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Code";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(98, 58);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(141, 20);
            this.DateBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(569, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeletBut
            // 
            this.DeletBut.Location = new System.Drawing.Point(569, 42);
            this.DeletBut.Name = "DeletBut";
            this.DeletBut.Size = new System.Drawing.Size(75, 23);
            this.DeletBut.TabIndex = 12;
            this.DeletBut.Text = "Delete";
            this.DeletBut.UseVisualStyleBackColor = true;
            this.DeletBut.Click += new System.EventHandler(this.DeletBut_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SubmitProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeletBut);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.EntryBox);
            this.Controls.Add(this.SubBox);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentDataGrid);
            this.Name = "SubmitProblems";
            this.Text = "SubmitProblems";
            this.Load += new System.EventHandler(this.SubmitProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CurrentDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.TextBox SubBox;
        private System.Windows.Forms.TextBox EntryBox;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeletBut;
        private System.Windows.Forms.Button button3;
    }
}