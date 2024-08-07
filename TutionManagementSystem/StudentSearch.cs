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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutionManagementSystem
{
    
    public partial class StudentSearch : Form
    {
        string id;
        public StudentSearch()
        {
            InitializeComponent();
            id = Login.id;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string numberOfDays = cbNod.SelectedItem.ToString();
            string cls = cbClass.SelectedItem.ToString();
            string location = cbLocation.SelectedItem.ToString();
            string medium = cbMedium.SelectedItem.ToString();
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select id, Name, Gender, Location, Medium, Class, NumberOfDays, OfferedSalary from Student where NumberOfDays = '"+numberOfDays+"' and Class = '"+cls+"' and Location = '"+location+"' and Medium = '"+medium+"' and Gender = '"+gender+"'";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable datatable = dataset.Tables[0];
                dgvStudent.DataSource = datatable;
                dgvStudent.Refresh();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Somthing went wrong!");
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string val = dgvStudent[e.ColumnIndex+1, e.RowIndex].Value.ToString();
                //try
                //{
                    string status = "Tutor";
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                    con.Open();
                    string query = "insert into Request (Status, StudentId, TutorId) values('"+status+"', '"+val+"', '"+id+"')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Request Sent!");
                //}
                //catch
                //{
                //    MessageBox.Show("Something Went Wrong!");
                //}
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbNod.SelectedIndex = -1;
            cbClass.SelectedIndex = -1;
            cbLocation.SelectedIndex = -1;
            cbMedium.SelectedIndex = -1;
            if (rbMale.Checked)
            {
                rbMale.Checked = false;
            }
            if (rbFemale.Checked)
            {
                rbFemale.Checked = false;
            }
        }

        

        private void msLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.Show();
            this.Hide();
        }
    }
}
