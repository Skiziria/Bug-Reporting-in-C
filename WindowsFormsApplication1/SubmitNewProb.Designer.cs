namespace WindowsFormsApplication1
{
    partial class SubmitNewProb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitNewProb));
            System.Windows.Forms.Label submitted_byLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label detailsLabel;
            System.Windows.Forms.Label codeLabel;
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.currentProbsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentProbsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.CurrentProbsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.currentProbsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.currentProbsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.currentProbsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitted_byTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            submitted_byLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            detailsLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsBindingNavigator)).BeginInit();
            this.currentProbsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentProbsBindingSource
            // 
            this.currentProbsBindingSource.DataMember = "CurrentProbs";
            this.currentProbsBindingSource.DataSource = this.dataSet1;
            // 
            // currentProbsTableAdapter
            // 
            this.currentProbsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrentProbsTableAdapter = this.currentProbsTableAdapter;
            this.tableAdapterManager.SolvedProbsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // currentProbsBindingNavigator
            // 
            this.currentProbsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.currentProbsBindingNavigator.BindingSource = this.currentProbsBindingSource;
            this.currentProbsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.currentProbsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.currentProbsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.currentProbsBindingNavigatorSaveItem});
            this.currentProbsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.currentProbsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.currentProbsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.currentProbsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.currentProbsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.currentProbsBindingNavigator.Name = "currentProbsBindingNavigator";
            this.currentProbsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.currentProbsBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.currentProbsBindingNavigator.TabIndex = 0;
            this.currentProbsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // currentProbsBindingNavigatorSaveItem
            // 
            this.currentProbsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.currentProbsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("currentProbsBindingNavigatorSaveItem.Image")));
            this.currentProbsBindingNavigatorSaveItem.Name = "currentProbsBindingNavigatorSaveItem";
            this.currentProbsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.currentProbsBindingNavigatorSaveItem.Text = "Save Data";
            this.currentProbsBindingNavigatorSaveItem.Click += new System.EventHandler(this.currentProbsBindingNavigatorSaveItem_Click);
            // 
            // currentProbsDataGridView
            // 
            this.currentProbsDataGridView.AutoGenerateColumns = false;
            this.currentProbsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentProbsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.currentProbsDataGridView.DataSource = this.currentProbsBindingSource;
            this.currentProbsDataGridView.Location = new System.Drawing.Point(15, 244);
            this.currentProbsDataGridView.Name = "currentProbsDataGridView";
            this.currentProbsDataGridView.Size = new System.Drawing.Size(452, 220);
            this.currentProbsDataGridView.TabIndex = 1;
            this.currentProbsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentProbsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Submitted by";
            this.dataGridViewTextBoxColumn1.HeaderText = "Submitted by";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Details";
            this.dataGridViewTextBoxColumn3.HeaderText = "Details";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // submitted_byLabel
            // 
            submitted_byLabel.AutoSize = true;
            submitted_byLabel.Location = new System.Drawing.Point(12, 37);
            submitted_byLabel.Name = "submitted_byLabel";
            submitted_byLabel.Size = new System.Drawing.Size(71, 13);
            submitted_byLabel.TabIndex = 2;
            submitted_byLabel.Text = "Submitted by:";
            // 
            // submitted_byTextBox
            // 
            this.submitted_byTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProbsBindingSource, "Submitted by", true));
            this.submitted_byTextBox.Location = new System.Drawing.Point(89, 34);
            this.submitted_byTextBox.Name = "submitted_byTextBox";
            this.submitted_byTextBox.Size = new System.Drawing.Size(200, 20);
            this.submitted_byTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 64);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.currentProbsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(89, 60);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 5;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(12, 89);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(42, 13);
            detailsLabel.TabIndex = 6;
            detailsLabel.Text = "Details:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProbsBindingSource, "Details", true));
            this.detailsTextBox.Location = new System.Drawing.Point(89, 86);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(200, 140);
            this.detailsTextBox.TabIndex = 7;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(295, 34);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 8;
            codeLabel.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentProbsBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(350, 34);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 192);
            this.codeTextBox.TabIndex = 9;
            // 
            // SubmitNewProb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 489);
            this.Controls.Add(submitted_byLabel);
            this.Controls.Add(this.submitted_byTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.currentProbsDataGridView);
            this.Controls.Add(this.currentProbsBindingNavigator);
            this.Name = "SubmitNewProb";
            this.Text = "SubmitNewProb";
            this.Load += new System.EventHandler(this.SubmitNewProb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsBindingNavigator)).EndInit();
            this.currentProbsBindingNavigator.ResumeLayout(false);
            this.currentProbsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentProbsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource currentProbsBindingSource;
        private DataSet1TableAdapters.CurrentProbsTableAdapter currentProbsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator currentProbsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton currentProbsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView currentProbsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox submitted_byTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}