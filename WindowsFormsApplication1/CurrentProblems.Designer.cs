namespace WindowsFormsApplication1
{
    partial class CurrentProblems
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
            System.Windows.Forms.Label entryIDLabel;
            System.Windows.Forms.Label submittedByLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label detailsLabel;
            System.Windows.Forms.Label codeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentProblems));
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.currentProblemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentProblemsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.CurrentProblemsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.currentProblemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.currentProblemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryIDTextBox = new System.Windows.Forms.TextBox();
            this.submittedByTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            entryIDLabel = new System.Windows.Forms.Label();
            submittedByLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            detailsLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingNavigator)).BeginInit();
            this.currentProblemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // entryIDLabel
            // 
            entryIDLabel.AutoSize = true;
            entryIDLabel.Location = new System.Drawing.Point(9, 35);
            entryIDLabel.Name = "entryIDLabel";
            entryIDLabel.Size = new System.Drawing.Size(48, 13);
            entryIDLabel.TabIndex = 2;
            entryIDLabel.Text = "Entry ID:";
            // 
            // submittedByLabel
            // 
            submittedByLabel.AutoSize = true;
            submittedByLabel.Location = new System.Drawing.Point(9, 61);
            submittedByLabel.Name = "submittedByLabel";
            submittedByLabel.Size = new System.Drawing.Size(72, 13);
            submittedByLabel.TabIndex = 4;
            submittedByLabel.Text = "Submitted By:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(9, 88);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(9, 113);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(42, 13);
            detailsLabel.TabIndex = 8;
            detailsLabel.Text = "Details:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(315, 35);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 10;
            codeLabel.Text = "Code:";
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // currentProblemsBindingNavigator
            // 
            this.currentProblemsBindingNavigator.AddNewItem = null;
            this.currentProblemsBindingNavigator.BindingSource = this.currentProblemsBindingSource;
            this.currentProblemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.currentProblemsBindingNavigator.DeleteItem = null;
            this.currentProblemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.currentProblemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.currentProblemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.currentProblemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.currentProblemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.currentProblemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.currentProblemsBindingNavigator.Name = "currentProblemsBindingNavigator";
            this.currentProblemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.currentProblemsBindingNavigator.Size = new System.Drawing.Size(711, 25);
            this.currentProblemsBindingNavigator.TabIndex = 0;
            this.currentProblemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // currentProblemsDataGridView
            // 
            this.currentProblemsDataGridView.AutoGenerateColumns = false;
            this.currentProblemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentProblemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.currentProblemsDataGridView.DataSource = this.currentProblemsBindingSource;
            this.currentProblemsDataGridView.Location = new System.Drawing.Point(12, 175);
            this.currentProblemsDataGridView.Name = "currentProblemsDataGridView";
            this.currentProblemsDataGridView.ReadOnly = true;
            this.currentProblemsDataGridView.Size = new System.Drawing.Size(549, 220);
            this.currentProblemsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EntryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EntryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubmittedBy";
            this.dataGridViewTextBoxColumn2.HeaderText = "SubmittedBy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Details";
            this.dataGridViewTextBoxColumn4.HeaderText = "Details";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn5.HeaderText = "Code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // entryIDTextBox
            // 
            this.entryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProblemsBindingSource, "EntryID", true));
            this.entryIDTextBox.Location = new System.Drawing.Point(87, 32);
            this.entryIDTextBox.Name = "entryIDTextBox";
            this.entryIDTextBox.ReadOnly = true;
            this.entryIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.entryIDTextBox.TabIndex = 3;
            // 
            // submittedByTextBox
            // 
            this.submittedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProblemsBindingSource, "SubmittedBy", true));
            this.submittedByTextBox.Location = new System.Drawing.Point(87, 58);
            this.submittedByTextBox.Name = "submittedByTextBox";
            this.submittedByTextBox.ReadOnly = true;
            this.submittedByTextBox.Size = new System.Drawing.Size(200, 20);
            this.submittedByTextBox.TabIndex = 5;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.currentProblemsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(87, 84);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 7;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProblemsBindingSource, "Details", true));
            this.detailsTextBox.Location = new System.Drawing.Point(87, 110);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(200, 59);
            this.detailsTextBox.TabIndex = 9;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProblemsBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(356, 32);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(200, 137);
            this.codeTextBox.TabIndex = 11;
            // 
            // CurrentProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 423);
            this.Controls.Add(entryIDLabel);
            this.Controls.Add(this.entryIDTextBox);
            this.Controls.Add(submittedByLabel);
            this.Controls.Add(this.submittedByTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.currentProblemsDataGridView);
            this.Controls.Add(this.currentProblemsBindingNavigator);
            this.Name = "CurrentProblems";
            this.Text = "CurrentProblems";
            this.Load += new System.EventHandler(this.CurrentProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsBindingNavigator)).EndInit();
            this.currentProblemsBindingNavigator.ResumeLayout(false);
            this.currentProblemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentProblemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource currentProblemsBindingSource;
        private DataSet1TableAdapters.CurrentProblemsTableAdapter currentProblemsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator currentProblemsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView currentProblemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox entryIDTextBox;
        private System.Windows.Forms.TextBox submittedByTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}