using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace TutionManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbStatus.SelectedIndex == 0)
            {
                StudentSignUp studentSignUp = new StudentSignUp();
                studentSignUp.Show();
                
            }
            if(cbStatus.SelectedIndex == 1)
            {
                TutorSignUp tutorSignUp = new TutorSignUp();
                tutorSignUp.Show();
            }
            if(cbStatus.SelectedIndex == 2)
            {
                MessageBox.Show("Cannot Add Admin");
                
            }
            if(cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Status","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser();
            viewUser.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbStatus.SelectedIndex == 0)
            {
                AdminUpdateStudent adminUpdateStudent = new AdminUpdateStudent();
                adminUpdateStudent.Show();
                this.Hide();
            }
            if(cbStatus.SelectedIndex == 1)
            {
                AdminUpdateTutor adminUpdateTutor = new AdminUpdateTutor();
                adminUpdateTutor.Show();
                this.Hide();
            }
            if(cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Status");

            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            string query = "SELECT * from Report";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            DataTable dataTable = dataset.Tables[0];

            dgvReport.DataSource = dataTable;
            dgvReport.Refresh();
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                    string rdata = (string)dgvReport[6, e.RowIndex].Value.ToString();
                    string adata = (string)dgvReport[7, e.RowIndex].Value.ToString();
                    string sdata = (string)dgvReport[3, e.RowIndex].Value.ToString();
                    if (sdata == "Tutor")
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                        con.Open();
                        string query = "DELETE from Student where id = '" + adata + "'";

                        SqlCommand command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();
                        con.Close();
                        dgvReport.Refresh();
                        MessageBox.Show("Student with id '" + adata + "' has been deleted");

                    
                    }
                    else if (sdata == "Student")
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                        con.Open();
                        string query = "DELETE from Tutor where id = '" + adata + "'";

                        SqlCommand command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();
                        dgvReport.Refresh();
                        MessageBox.Show("Tutor with id '" + adata + "' has been deleted");
                    }

                SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con1.Open();
                string query1 = "DELETE from Report where ReporterId = '" + rdata + "' and AssailantId = '" + adata + "' and ReporterStatus = '" + sdata + "'";

                SqlCommand command1 = new SqlCommand(query1, con1);
                command1.ExecuteNonQuery();
                con1.Close();

            }

            if (e.ColumnIndex == 1) {
                string rdata = (string)dgvReport[6, e.RowIndex].Value.ToString();
                string adata = (string)dgvReport[7, e.RowIndex].Value.ToString();
                string sdata = (string)dgvReport[3, e.RowIndex].Value.ToString();
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "DELETE from Report where ReporterId = '" + rdata + "' and AssailantId = '" + adata + "' and ReporterStatus = '" + sdata + "'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
                dgvReport.Refresh();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection refcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
            refcon.Open();
            string refquery = "SELECT * FROM Report";

            SqlCommand refcmd = new SqlCommand(refquery, refcon);
            refcmd.ExecuteNonQuery();
            SqlDataAdapter refadapter = new SqlDataAdapter(refcmd);
            DataSet refdataset = new DataSet();
            refadapter.Fill(refdataset);
            DataTable refdataTable = refdataset.Tables[0];

            dgvReport.DataSource = refdataTable;
            dgvReport.Refresh();
            refcon.Close();
        }
    }
}
