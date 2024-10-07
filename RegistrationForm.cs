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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
             
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.Show();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert;
                sqlinsert = "insert into customer (customer_name, customer_email, customer_nic, customer_address,customer_contact, customer_password, customer_confirm_password ) values ('" + txt_customer_name.Text + "','" + txt_customer_email.Text + "','" + txt_customer_nic.Text + "','" + txt_customer_add.Text + "','" + txt_customer_contact.Text + "','" + txt_customer_pw.Text + "','" + txt_confirm_pw.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlinsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered sucsessfully!!");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_confirm_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_customer_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
