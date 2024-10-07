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

namespace ABC_Car_Traders_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email, password;

            email = txt_email.Text;
            password = txt_pw.Text;
            

            string userType = "";

            
            if (chkbox_admin.Checked && chkbox_customer.Checked)
            {
                MessageBox.Show("Please select only one user type (Admin or Customer).", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            else if (chkbox_admin.Checked)
            {
                userType = "admin";
            }
            else if (chkbox_customer.Checked)
            {
                userType = "customer";
            }
            else
            {
                MessageBox.Show("Please select a user type (Admin or Customer).", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string query = "";
            SqlCommand cmd;
            if (userType == "admin")
            {
                query = "SELECT * FROM admin WHERE email = @Email AND password = @Password";
                cmd = new SqlCommand(query, con);
            }
            else if (userType == "customer")
            {
                query = "SELECT * FROM customer WHERE customer_email = @Email AND customer_password = @Password";
                cmd = new SqlCommand(query, con);
            }
            else
            {
                return; 
            }

            //SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successfully");

                    if (userType == "admin")
                    {
                        string adminName = dr["admin_name"].ToString(); 
                        AdminDashForm adminDashboard = new AdminDashForm(adminName);
                        this.Hide();
                        adminDashboard.Show();
                    }
                    else if (userType == "customer")
                    {
                        string customerName = dr["customer_name"].ToString(); 
                        CustomerDashForm cd = new CustomerDashForm(customerName);
                        
                        this.Hide();
                        cd.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            this.Hide();
            reg.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
