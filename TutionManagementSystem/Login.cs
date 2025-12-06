using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutionManagementSystem
{

    public partial class Login : Form
    {
        public static string id,status;
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string name = txtUsername.Text;
            string password = txtPassword.Text;

            if (cbStatus.SelectedIndex == 0)
                {
                status = "Student";
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select id from Student where Name = '" + name + "' and Password = '" + password + "'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                SqlDataReader reader;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = reader["id"].ToString();

                    Student student = new Student();
                    student.Show();
                    this.Hide();

                }else{
                    MessageBox.Show("Username or Password do not match!","User Not Found!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

                con.Close();
            }

            if (cbStatus.SelectedIndex == 1)
            {
                status = "Tutor";
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                string query = "select id from Tutor where Name = '" + name + "' and Password = '" + password + "'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                SqlDataReader reader;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                     id = reader["id"].ToString();
                    
                        Tutor tutor = new Tutor();
                        tutor.Show();
                        this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Username or Password do not match!", "User Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            if(cbStatus.SelectedIndex == 2)
            {

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select id from Admin where Name = '" + name + "' and Password = '" + password + "'";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                SqlDataReader reader;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = reader["id"].ToString();

                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or Password do not match!", "User Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();

            }
            if(cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your status","Error!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

            

        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(cbStatus.SelectedIndex == 0) 
            {
                StudentSignUp studentSignUp = new StudentSignUp();
                studentSignUp.Show();
                this.Hide();
            }
            if (cbStatus.SelectedIndex == 1)
            {
                TutorSignUp tutorSignUp = new TutorSignUp();
                tutorSignUp.Show();
                this.Hide();
            }
            if(cbStatus.SelectedIndex == 2)
            {
                MessageBox.Show("Invalid Input","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Status", "Empty Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbStatus.SelectedIndex = -1;
        }

        
    }
}
