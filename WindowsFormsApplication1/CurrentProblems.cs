﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CurrentProblems : Form
    {
        public CurrentProblems()
        {
            InitializeComponent();
        }

        private void currentProblemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currentProblemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CurrentProblems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CurrentProblems' table. You can move, or remove it, as needed.
            this.currentProblemsTableAdapter.Fill(this.dataSet1.CurrentProblems);

        }
    }
}
