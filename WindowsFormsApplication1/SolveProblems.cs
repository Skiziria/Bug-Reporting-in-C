using System;
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
    public partial class SolveProblems : Form
    {
        public SolveProblems()
        {
            InitializeComponent();
        }

        private void currentProblemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currentProblemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SolveProblems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SolvedProblems' table. You can move, or remove it, as needed.
            this.solvedProblemsTableAdapter.Fill(this.dataSet1.SolvedProblems);
            // TODO: This line of code loads data into the 'dataSet1.CurrentProblems' table. You can move, or remove it, as needed.
            this.currentProblemsTableAdapter.Fill(this.dataSet1.CurrentProblems);

        }

        private void solvedProblemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
