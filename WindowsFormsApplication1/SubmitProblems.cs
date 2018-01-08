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
    public partial class SubmitProblems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandr\Google Drive\University Work\Advanced Software Engineering\WindowsFormsApplication1\WindowsFormsApplication1\Data server.mdf';Integrated Security=True;Connect Timeout=30");
        public SubmitProblems()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitProblems_Load(object sender, EventArgs e)
        {
            disp_date();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CurrentProblems values('" + EntryBox.Text + "','" + SubBox.Text + "','" + DateBox.Text + "','" + DetailsBox.Text + "','" + CodeBox.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid details");
            }
            con.Close();
            disp_date();
        }

        public void disp_date()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CurrentProblems";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CurrentDataGrid.DataSource = dt;
            con.Close();
        }

        private void DeletBut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CurrentProblems where EntryID ='"+EntryBox.Text+"' ";
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
            disp_date();
            
        }
    }
}
