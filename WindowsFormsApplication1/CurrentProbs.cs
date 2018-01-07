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
    public partial class CurrentProbs : Form
    {
        public CurrentProbs()
        {
            InitializeComponent();
        }

        private void currentProbsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currentProbsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CurrentProbs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CurrentProbs' table. You can move, or remove it, as needed.
            this.currentProbsTableAdapter.Fill(this.dataSet1.CurrentProbs);

        }
    }
}
