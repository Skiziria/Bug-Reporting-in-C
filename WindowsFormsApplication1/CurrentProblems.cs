using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorCode;
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

        public void ColorCodeCSharp()
        {
           /* string code = codeTextBox.Text;

            string colorizedSourceCode = new CodeColorizer().Colorize(code, Languages.CSharp);*/

            string colorizedSourceCode = new CodeColorizer().Colorize(codeTextBox.Text, Languages.CSharp);

            //txtSourceCode.Text = colourizedSourceCode;

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colorizedSourceCode + "</body></html>");
            
            //System.IO.File.WriteAllText(@"C:\Users\sandr\Google Drive\University Work\Advanced Software Engineering\WindowsFormsApplication1\Code.html", html);

            webBrowser1.DocumentText = html;

            //this.webBrowser1.Url = new Uri(String.Format("file:///C:\Users\sandr\Google Drive\University Work\Advanced Software Engineering\WindowsFormsApplication1\Code.html"));
            //System.IO.File.WriteAllText(@"F:\Source\Repos\ASE\BugTracker\BugTracker\Code.html", html);

            //ColorCode.Text = html;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorCodeCSharp();
        }
    }
}
