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

namespace TutionManagementSystem
{
    public partial class TutorSignUp : Form
    {
        public TutorSignUp()
        {
            InitializeComponent();
        }

        private void msBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Password = txtPassword.Text;
            string confirmPassword = txtCp.Text;

            if(confirmPassword != Password)
            {
                MessageBox.Show("Password and Confirm Password Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            

            string gender = "";

            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
            if (cbLocation.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string location = cbLocation.SelectedItem.ToString();


            if (cbMedium.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string medium = cbMedium.SelectedItem.ToString();


            if (cbUniversity.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string university = cbUniversity.SelectedItem.ToString();

            if (cbDept.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string department = cbDept.SelectedItem.ToString();

            if (cbExp.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string experience = cbExp.SelectedItem.ToString();


            if (cbNod.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all input", "Error");
                return;
            }
            string numberOfDays = cbNod.SelectedItem.ToString();



            string expectedSalary = txtEs.Text;
            String phn = txtPhn.Text;

            if (name == null || Password == null || confirmPassword == null || gender == null || expectedSalary == null || phn == null )
            {
                MessageBox.Show("Please Select all the feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                    con.Open();

                    string query = "insert into Tutor (Name, Password, Gender, Location, Medium, University, Department, Experience, NumberOfDays, ExpectedSalary, PhoneNumber) values('" + name + "', '" + Password + "', '" + gender + "', '" + location + "', '" + medium + "', '" + university + "','" + department + "', '" + experience + "', '" + numberOfDays + "', '" + expectedSalary + "', '"+phn+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Welcome, your sign up is succesful", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                catch  
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
