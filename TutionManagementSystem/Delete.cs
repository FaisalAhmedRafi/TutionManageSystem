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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbStatus.SelectedIndex == 0)
            {
                string id = txtId.Text;
                //try
                //{
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select * from Student";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable datatable = dataset.Tables[0];
                dgvDelete.DataSource = datatable;
                dgvDelete.Refresh();

                con.Close();
                //}catch 
                //{
                //    MessageBox.Show("Somthing went wrong!");
                //}
            }
            if(cbStatus.SelectedIndex == 1)
            {
                string id = txtId.Text;
                //try
                //{
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "select * from Tutor";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable datatable = dataset.Tables[0];
                dgvDelete.DataSource = datatable;
                dgvDelete.Refresh();

                con.Close();
                //}catch 
                //{
                //    MessageBox.Show("Somthing went wrong!");
                //}
            }
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select status!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            if (cbStatus.SelectedIndex == 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "delete from Student where id = '" + id + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable datatable = dataset.Tables[0];
                dgvDelete.DataSource = datatable;
                dgvDelete.Refresh();

                con.Close();
            }catch 
                {
                MessageBox.Show("User Deleted please refresh!");
            }
        }
            if(cbStatus.SelectedIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programming\\AIUB\\C#\\TutionManagementSystem\\DB\\TutionManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                string query = "delete from Tutor where id = '" + id + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable datatable = dataset.Tables[0];
                dgvDelete.DataSource = datatable;
                dgvDelete.Refresh();

                con.Close();
                }
                catch  
                {
                    MessageBox.Show("User Deleted please refresh!");
                }
            }
        }

        private void msBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
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

        
    }
}
