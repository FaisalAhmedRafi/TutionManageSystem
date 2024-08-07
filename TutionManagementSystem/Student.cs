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
using System.Xml;

namespace TutionManagementSystem
{
    public partial class Student : Form
    {
        public static string id,tid;
        string phn, tname, gender, location, medium, university, department, experience, numberofdays, expectedsalary;

        

        public Student()
        {
            InitializeComponent();
            id = Login.id;
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

        private void msSearch_Click(object sender, EventArgs e)
        {
            TutorSearch tutorsearch = new TutorSearch();
            tutorsearch.Show();
            this.Hide();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select Name, Location, Medium, Class, NumberOfDays, OfferedSalary from Student where id = '" + id + "'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                SqlDataReader reader;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = reader["Name"].ToString();
                    lblLocation.Text = reader["Location"].ToString();
                    lblMedium.Text = reader["Medium"].ToString();
                    lblClass.Text = reader["Class"].ToString();
                    lblNod.Text = reader["NumberOfDays"].ToString();
                    lblOs.Text = reader["OfferedSalary"].ToString();

                }

                con.Close();

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

            try
            {


                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "SELECT * from Request where StudentId = '" + id + "' and Status = 'Tutor'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd);
                DataSet dataset3 = new DataSet();
                adapter3.Fill(dataset3);
                DataTable dataTable3 = dataset3.Tables[0];
                for (int i = 0; i < dataTable3.Rows.Count ; i++)
                {
                tid = dataTable3.Rows[i]["TutorId"].ToString();
                
                    SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                        con1.Open();
                        string query1 = "select id, Name, Gender, Location, Medium, University, Department, Experience, NumberOfDays, ExpectedSalary, PhoneNumber from Tutor where id = '" + tid + "'";

                        SqlCommand cmd1 = new SqlCommand(query1, con1);
                        SqlDataReader reader;
                        reader = cmd1.ExecuteReader();
                    
                        if(reader.Read())
                        {
                             tid = reader["id"].ToString();
                             tname = reader["Name"].ToString();
                             gender = reader["Gender"].ToString();
                             location = reader["Location"].ToString();
                             medium = reader["Medium"].ToString();
                             university = reader["University"].ToString() ;
                             department = reader["Department"].ToString();
                             experience = reader["Experience"].ToString();
                             numberofdays = reader["NumberOfDays"].ToString();
                             expectedsalary = reader["ExpectedSalary"].ToString();
                             phn = reader["PhoneNumber"].ToString();
                        }
                        

                string[] row = { "","","", tid, tname, gender, location, medium, university, department, numberofdays, expectedsalary };



                    dgvRequest.Rows.Add(row);
                    dgvRequest.Refresh();




                        con1.Close();
                

                }

                con.Close();

        }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
}

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                MessageBox.Show("Please call at the given number '"+phn+"' to contact with the Tutor, Pleasee make sure that all the contract you make is completely your responsibility. Tution media will not be liable for any kind of unexpected thing. Altough we will assist if any kind of help you require from us.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == 1)
            {
                Report report = new Report();
                report.Show();
                this.Hide();
            }
            if(e.ColumnIndex == 2)
            {
                string data = (string)dgvRequest[3, e.RowIndex].Value;
                MessageBox.Show(data);
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "DELETE from Request where StudentId = '" + id + "' and TutorId = '" + data + "' and Status = 'Tutor'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                dgvRequest.Refresh();
            }
            
        }
    }
}
