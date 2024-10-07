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
    public partial class CustomerUpdateForm : Form
    {
        public CustomerUpdateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string query = "SELECT * FROM customer";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {

                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridcustomers.DataSource = dataTable;
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
        }

            private void btn_search_Click(object sender, EventArgs e)
         {
            
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                MessageBox.Show("Please enter a customer name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            string sqlsearch = "select * from customer where customer_name ='" + txt_search.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("@customer_name", txt_search.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_customer_id.Text = dr["customer_ID"].ToString();
                txt_customer_name.Text = dr["customer_name"].ToString();
                txt_customer_email.Text = dr["customer_email"].ToString();
                txt_customer_password.Text = dr["customer_password"].ToString();
                txt_customer_nic.Text = dr["customer_nic"].ToString();
                txt_customer_contact.Text = dr["customer_contact"].ToString();
                txt_customer_add.Text = dr["customer_address"].ToString();
            }

            else
            {
                MessageBox.Show("Invalid Customer Name", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txt_customer_id.Text) ||
                string.IsNullOrEmpty(txt_customer_name.Text) ||
                string.IsNullOrEmpty(txt_customer_email.Text) ||
                string.IsNullOrEmpty(txt_customer_password.Text) ||
                string.IsNullOrEmpty(txt_customer_contact.Text) ||
                string.IsNullOrEmpty(txt_customer_nic.Text) ||
                string.IsNullOrEmpty(txt_customer_add.Text))
            {
                MessageBox.Show("Please load customer data into the fields before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                if (MessageBox.Show("Do you want to delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string sqldelete = " delete from customer where customer_name='" + txt_search.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.Parameters.AddWithValue("@customer_name", txt_search.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Details Deleted sucsessfully!!");
                    LoadCustomerData();  
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txt_customer_name.Text) ||
                string.IsNullOrEmpty(txt_customer_email.Text) ||
                string.IsNullOrEmpty(txt_customer_password.Text) ||
                string.IsNullOrEmpty(txt_customer_contact.Text) ||
                string.IsNullOrEmpty(txt_customer_nic.Text) ||
                string.IsNullOrEmpty(txt_customer_add.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            string sqlCheck = "SELECT customer_name, customer_email, customer_password, customer_contact, customer_nic, customer_address FROM customer WHERE customer_name = @search_name";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
            cmdCheck.Parameters.AddWithValue("@search_name", txt_search.Text);

            try
            {
                con.Open();
                SqlDataReader dr = cmdCheck.ExecuteReader();
                if (dr.Read())
                {
                    bool isModified = false;

                    if (dr["customer_name"].ToString() != txt_customer_name.Text)
                        isModified = true;
                    if (dr["customer_email"].ToString() != txt_customer_email.Text)
                        isModified = true;
                    if (dr["customer_password"].ToString() != txt_customer_password.Text)
                        isModified = true;
                    if (dr["customer_contact"].ToString() != txt_customer_contact.Text)
                        isModified = true;
                    if (dr["customer_nic"].ToString() != txt_customer_nic.Text)
                        isModified = true;
                    if (dr["customer_address"].ToString() != txt_customer_add.Text)
                        isModified = true;

                    dr.Close();

                    if (!isModified)
                    {
                        MessageBox.Show("No changes detected. Please modify the details before updating.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; 
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found. Please check the search criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }

            string sqlUpdate = "UPDATE customer SET customer_name = @customer_name, customer_email = @customer_email, " +
                               "customer_password = @customer_password, customer_contact = @customer_contact, " +
                               "customer_nic = @customer_nic, customer_address = @customer_address " +
                               "WHERE customer_name = @search_name";

            SqlCommand cmd = new SqlCommand(sqlUpdate, con);
            cmd.Parameters.AddWithValue("@customer_name", txt_customer_name.Text);
            cmd.Parameters.AddWithValue("@customer_email", txt_customer_email.Text);
            cmd.Parameters.AddWithValue("@customer_password", txt_customer_password.Text);
            cmd.Parameters.AddWithValue("@customer_contact", txt_customer_contact.Text);
            cmd.Parameters.AddWithValue("@customer_nic", txt_customer_nic.Text);
            cmd.Parameters.AddWithValue("@customer_address", txt_customer_add.Text);
            cmd.Parameters.AddWithValue("@search_name", txt_search.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully", "Update Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadCustomerData(); 

        }

        private void datagridcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM customer";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridcustomers.DataSource = dataTable;
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
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_customer_id.Text) &&
                string.IsNullOrEmpty(txt_customer_name.Text) &&
                string.IsNullOrEmpty(txt_customer_email.Text) &&
                string.IsNullOrEmpty(txt_customer_password.Text) &&
                string.IsNullOrEmpty(txt_customer_contact.Text) &&
                string.IsNullOrEmpty(txt_customer_nic.Text) &&
                string.IsNullOrEmpty(txt_customer_add.Text) &&
                string.IsNullOrEmpty(txt_search.Text))
            {
                MessageBox.Show("All fields are already empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            txt_customer_id.Clear();
            txt_customer_name.Clear();
            txt_customer_email.Clear();
            txt_customer_password.Clear();
            txt_customer_nic.Clear();
            txt_customer_contact.Clear();
            txt_customer_add.Clear();
            //txt_search.Clear();
        }
    }
}
