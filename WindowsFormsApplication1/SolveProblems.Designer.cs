namespace WindowsFormsApplication1
{
    partial class SolveProblems
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.currentProblemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentProblemsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.CurrentProblemsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.solvedProblemsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.SolvedProblemsTableAdapter();
            this.CurrentProblemGrid = new System.Windows.Forms.DataGridView();
            this.solvedProblemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SolvedID = new System.Windows.Forms.TextBox();
            this.SolvedBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.FixedCodeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProblemID = new System.Windows.Forms.TextBox();
            this.SolvedProblemGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmittedBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OldCodeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProblemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvedProblemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolvedProblemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentProblemsBindingSource
            // 
            this.currentProblemsBindingSource.DataMember = "CurrentProblems";
            this.currentProblemsBindingSource.DataSource = this.dataSet1;
            // 
            // currentProblemsTableAdapter
            // 
            this.currentProblemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrentProblemsTableAdapter = this.currentProblemsTableAdapter;
            this.tableAdapterManager.SolvedProblemsTableAdapter = this.solvedProblemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // solvedProblemsTableAdapter
            // 
            this.solvedProblemsTableAdapter.ClearBeforeFill = true;
            // 
            // CurrentProblemGrid
            // 
            this.CurrentProblemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentProblemGrid.Location = new System.Drawing.Point(769, 270);
            this.CurrentProblemGrid.Name = "CurrentProblemGrid";
            this.CurrentProblemGrid.ReadOnly = true;
            this.CurrentProblemGrid.Size = new System.Drawing.Size(546, 220);
            this.CurrentProblemGrid.TabIndex = 1;
            // 
            // solvedProblemsBindingSource
            // 
            this.solvedProblemsBindingSource.DataMember = "SolvedProblems";
            this.solvedProblemsBindingSource.DataSource = this.dataSet1;
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(673, 41);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(75, 23);
            this.SaveBut.TabIndex = 13;
            this.SaveBut.Text = "Solve";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(673, 70);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(75, 23);
            this.DelBut.TabIndex = 14;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Entry ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Solved By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Code solution";
            // 
            // SolvedID
            // 
            this.SolvedID.Location = new System.Drawing.Point(121, 38);
            this.SolvedID.Name = "SolvedID";
            this.SolvedID.Size = new System.Drawing.Size(200, 20);
            this.SolvedID.TabIndex = 21;
            // 
            // SolvedBox
            // 
            this.SolvedBox.Location = new System.Drawing.Point(121, 90);
            this.SolvedBox.Name = "SolvedBox";
            this.SolvedBox.Size = new System.Drawing.Size(200, 20);
            this.SolvedBox.TabIndex = 22;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(121, 116);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 20);
            this.DateBox.TabIndex = 23;
            // 
            // DetailsBox
            // 
            this.DetailsBox.Location = new System.Drawing.Point(121, 142);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(200, 100);
            this.DetailsBox.TabIndex = 24;
            // 
            // FixedCodeBox
            // 
            this.FixedCodeBox.Location = new System.Drawing.Point(769, 9);
            this.FixedCodeBox.Multiline = true;
            this.FixedCodeBox.Name = "FixedCodeBox";
            this.FixedCodeBox.Size = new System.Drawing.Size(546, 233);
            this.FixedCodeBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Entry ID of a Problem";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProblemID
            // 
            this.ProblemID.Location = new System.Drawing.Point(121, 12);
            this.ProblemID.Name = "ProblemID";
            this.ProblemID.Size = new System.Drawing.Size(200, 20);
            this.ProblemID.TabIndex = 27;
            // 
            // SolvedProblemGrid
            // 
            this.SolvedProblemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolvedProblemGrid.Location = new System.Drawing.Point(4, 270);
            this.SolvedProblemGrid.Name = "SolvedProblemGrid";
            this.SolvedProblemGrid.ReadOnly = true;
            this.SolvedProblemGrid.Size = new System.Drawing.Size(759, 220);
            this.SolvedProblemGrid.TabIndex = 28;
            this.SolvedProblemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Submitted by";
            // 
            // SubmittedBox
            // 
            this.SubmittedBox.Location = new System.Drawing.Point(121, 64);
            this.SubmittedBox.Name = "SubmittedBox";
            this.SubmittedBox.Size = new System.Drawing.Size(200, 20);
            this.SubmittedBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Old Code";
            // 
            // OldCodeBox
            // 
            this.OldCodeBox.Location = new System.Drawing.Point(396, 12);
            this.OldCodeBox.Multiline = true;
            this.OldCodeBox.Name = "OldCodeBox";
            this.OldCodeBox.Size = new System.Drawing.Size(245, 230);
            this.OldCodeBox.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "SOLVED PROBLEMS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(765, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "CURRENT PROBLEMS";
            // 
            // SolveProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 521);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OldCodeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubmittedBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SolvedProblemGrid);
            this.Controls.Add(this.ProblemID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FixedCodeBox);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.SolvedBox);
            this.Controls.Add(this.SolvedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.CurrentProblemGrid);
            this.Name = "SolveProblems";
            this.Text = "SolveProblems";
            this.Load += new System.EventHandler(this.SolveProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProblemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvedProblemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolvedProblemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource currentProblemsBindingSource;
        private DataSet1TableAdapters.CurrentProblemsTableAdapter currentProblemsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView CurrentProblemGrid;
        private DataSet1TableAdapters.SolvedProblemsTableAdapter solvedProblemsTableAdapter;
        private System.Windows.Forms.BindingSource solvedProblemsBindingSource;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SolvedID;
        private System.Windows.Forms.TextBox SolvedBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.TextBox FixedCodeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProblemID;
        private System.Windows.Forms.DataGridView SolvedProblemGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SubmittedBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OldCodeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}