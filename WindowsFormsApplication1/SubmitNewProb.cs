using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class SubmitNewProb : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandr\Google Drive\University Work\Advanced Software Engineering\WindowsFormsApplication1\WindowsFormsApplication1\Data server.mdf';Integrated Security=True;Connect Timeout=30");
        public SubmitNewProb()
        {
            InitializeComponent();
        }

        private void currentProbsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // this.Validate();
            // this.currentProbsBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.dataSet1);

            /* con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into CurrentProbs values ('" + submitted_byTextBox.Text + "','" + dateDateTimePicker.Text + "','" + detailsTextBox.Text + "','" + codeTextBox.Text + "')";
                cmd.ExecuteNonQueryAsync();            
                con.Close();
                MessageBox.Show("record has been insearted");*/
            try
            {
                String selcmd = "SELECT name FROM myTable ";
                SqlCommand com = new SqlCommand(selcmd, con);
                con.Open();
                SqlDataReader mySqlDataReader = com.ExecuteReader();


                int i = 0;
                while (mySqlDataReader.Read())
                {
                    Console.WriteLine(mySqlDataReader["name"]); //reads a line of the query result at a time
                    myData[i++] = (String)mySqlDataReader["name"]; //store in an array too for use later

                }

                for (int j = 0; j < i; j++) //now iterate through our good old, bog standard array
                {
                    Console.WriteLine("***" + myData[j] + "***");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to save");

            }


        }

        private void SubmitNewProb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CurrentProbs' table. You can move, or remove it, as needed.
            currentProbsTableAdapter.Fill(this.dataSet1.CurrentProbs);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void currentProbsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
