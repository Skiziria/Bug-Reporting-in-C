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
    public partial class SolveProblems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandr\Google Drive\University Work\Advanced Software Engineering\WindowsFormsApplication1\WindowsFormsApplication1\Data server.mdf';Integrated Security=True;Connect Timeout=30");
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
            disp_date1();
            disp_date2();

        }

        private void solvedProblemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void disp_date1()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CurrentProblems";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CurrentProblemGrid.DataSource = dt;
            con.Close();
        }

        public void disp_date2()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SolvedProblems";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SolvedProblemGrid.DataSource = dt;
            con.Close();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into SolvedProblems values('" + SolvedID.Text + "','" + SubmittedBox.Text + "','" + SolvedBox.Text + "','" + DateBox.Text + "','" + DetailsBox.Text + "','" + OldCodeBox.Text + "','" + FixedCodeBox.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid details");
            }

            cmd.CommandText = "delete from CurrentProblems where EntryID ='" + ProblemID.Text + "' ";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid details");
            }


            con.Close();
            disp_date1();
            disp_date2();
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SolvedProblems where EntryID ='" + SolvedID.Text + "' ";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid details"); 
                
            }
            con.Close();
            disp_date2();
        }
    }
}
