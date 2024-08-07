using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutionManagementSystem
{
    public partial class Report : Form
    {
        public static string rid, aid, status;

        private void msBack_Click(object sender, EventArgs e)
        {
            if(status == "Student")
            {
                Student student = new Student();
                student.Show();
                this.Hide();
            }
            if(status == "Tutor")
            {
                Tutor tutor = new Tutor();
                tutor.Show();
                this.Hide();
            }
        }

        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Report()
        {
            InitializeComponent();
            status = Login.status;
            if (status == "Student")
            {
                rid = Login.id;
                aid = Student.tid;
            }
            if(status == "Tutor")
            {
                rid = Login.id;
                aid = Tutor.sid;
            }
                

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbReason.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Reason", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string reason = cbReason.SelectedItem.ToString();
            string issue = txtIssue.Text;
            if(issue == null)
            {
                issue = "Nothing Written";
            }

            //try
            //{
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            string query = "insert into Report (ReporterStatus, Reason, Description, ReporterID, AssailantID) values('" + status + "', '" + reason + "', '"+issue+"', '" + rid + "', '"+aid+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Report has been received by admin, soon it will be reviewed.","Report sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MessageBox.Show("Something Went Wrong!");
            //}
        }
    }
}
