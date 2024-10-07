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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders_
{
    public partial class AdminOrderForm : Form
    {
        public AdminOrderForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void AdminOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string sqlsearch = "select * from [order] where order_ID = @order_ID";
                    SqlCommand cmd = new SqlCommand(sqlsearch, con);
                    cmd.Parameters.AddWithValue("@order_ID", txt_search.Text);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                    
                    lbl_order_ID.Text = dr["order_ID"].ToString();
                    lbl_name.Text = dr["customer_Name"].ToString();
                    lbl_contact.Text = dr["contact_number"].ToString();
                    lbl_address.Text = dr["address"].ToString();
                    
                    lbl_product_ID.Text = dr["product_ID"].ToString();
                    lbl_productName.Text = dr["product_name"].ToString();
                    lbl_order_date.Text = dr["date_time"].ToString();
                    lbl_desc.Text = dr["description"].ToString();
                    lbl_price.Text = dr["price"].ToString();
                    lbl_quantity.Text = dr["quantity"].ToString();
                    lbl_total.Text = dr["total_Price"].ToString();
                 
                    lbl_paymentMethod.Text = dr["paymentMethod"] != DBNull.Value ? dr["paymentMethod"].ToString() : "N/A";
                    cmbx_status.Text = dr["order_status"] != DBNull.Value ? dr["order_Status"].ToString() : "Pending";
                }

                else
                    {
                        MessageBox.Show("Invalid Car", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                   
                    con.Close();
                }
            
        }
       

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM [order]"; 

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridorders.DataSource = dataTable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (cmbx_status.SelectedItem == null || cmbx_status.SelectedItem.ToString() == "Pending")
            {
                MessageBox.Show("Order status must be updated from 'Pending' before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                string sqlUpdate = "UPDATE [order] SET customer_Name = @customer_Name, contact_number = @contact_number, address = @address, " +
                                   "product_ID = @product_ID, product_name = @product_name, date_time = @date_time, description = @description, " +
                                   "price = @price, quantity = @quantity, total_Price = @total_Price, paymentMethod = @paymentMethod, " +
                                   "order_Status = @order_Status WHERE order_ID = @order_ID";

                SqlCommand cmd = new SqlCommand(sqlUpdate, con);

                cmd.Parameters.AddWithValue("@customer_Name", lbl_name.Text);
                cmd.Parameters.AddWithValue("@contact_number", lbl_contact.Text);
                cmd.Parameters.AddWithValue("@address", lbl_address.Text);
                cmd.Parameters.AddWithValue("@product_ID", lbl_product_ID.Text);
                cmd.Parameters.AddWithValue("@product_name", lbl_productName.Text);
                cmd.Parameters.AddWithValue("@date_time", lbl_order_date.Text);  // Ensure this matches your datetime format in the database
                cmd.Parameters.AddWithValue("@description", lbl_desc.Text);
                cmd.Parameters.AddWithValue("@price", lbl_price.Text);
                cmd.Parameters.AddWithValue("@quantity", lbl_quantity.Text);
                cmd.Parameters.AddWithValue("@total_Price", lbl_total.Text);
                cmd.Parameters.AddWithValue("@paymentMethod", lbl_paymentMethod.Text);
                cmd.Parameters.AddWithValue("@order_Status", cmbx_status.Text);
                cmd.Parameters.AddWithValue("@order_ID", lbl_order_ID.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were updated. Please check the order details.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            bool allFieldsEmpty = string.IsNullOrEmpty(lbl_order_ID.Text) &&
                                  string.IsNullOrEmpty(lbl_name.Text) &&
                                  string.IsNullOrEmpty(lbl_contact.Text) &&
                                  string.IsNullOrEmpty(lbl_address.Text) &&
                                  string.IsNullOrEmpty(lbl_product_ID.Text) &&
                                  string.IsNullOrEmpty(lbl_productName.Text) &&
                                  string.IsNullOrEmpty(lbl_order_date.Text) &&
                                  string.IsNullOrEmpty(lbl_desc.Text) &&
                                  string.IsNullOrEmpty(lbl_price.Text) &&
                                  string.IsNullOrEmpty(lbl_quantity.Text) &&
                                  string.IsNullOrEmpty(lbl_total.Text) &&
                                  string.IsNullOrEmpty(lbl_paymentMethod.Text);

            
            bool isStatusPending = cmbx_status.SelectedItem != null && cmbx_status.SelectedItem.ToString() == "Pending";

            Console.WriteLine($"All Fields Empty: {allFieldsEmpty}");
            Console.WriteLine($"Is Status Pending: {isStatusPending}");

            if (allFieldsEmpty && isStatusPending)
            {
                MessageBox.Show("Fields are already empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbl_order_ID.Text = string.Empty;
                lbl_name.Text = string.Empty;
                lbl_contact.Text = string.Empty;
                lbl_address.Text = string.Empty;
                lbl_product_ID.Text = string.Empty;
                lbl_productName.Text = string.Empty;
                lbl_order_date.Text = string.Empty;
                lbl_desc.Text = string.Empty;
                lbl_price.Text = string.Empty;
                lbl_quantity.Text = string.Empty;
                lbl_total.Text = string.Empty;
                lbl_paymentMethod.Text = string.Empty;

                cmbx_status.SelectedIndex = cmbx_status.Items.IndexOf("Pending");

                txt_search.Text = string.Empty;
            }
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
