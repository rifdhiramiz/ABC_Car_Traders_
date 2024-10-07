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

namespace ABC_Car_Traders_
{
    public partial class CustomerOrderForm : Form
    {
        public CustomerOrderForm()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {

        }


        private void lbl_cus_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lbl_payment_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_name_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_quantity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_desc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_add_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_contact_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_orderdate_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_custome_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txt_order_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_totalAmount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_quantity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_description_Click(object sender, EventArgs e)
        {

        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void lbl_contact_Click(object sender, EventArgs e)
        {

        }

        private void lbl_order_date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_order_ID_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customer_ID_Click(object sender, EventArgs e)
        {

        }

        private void datagridmyorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string customerName = txt_search.Text;

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter a customer name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM [order] WHERE customer_Name = @customer_Name";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@customer_Name", customerName);

                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridmyorders.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (datagridmyorders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to view details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = datagridmyorders.SelectedRows[0];

            lbl_order_ID.Text = selectedRow.Cells["order_ID"].Value.ToString();
            lbl_name.Text = selectedRow.Cells["customer_Name"].Value.ToString();
            lbl_contact.Text = selectedRow.Cells["contact_number"].Value.ToString();
            lbl_address.Text = selectedRow.Cells["address"].Value.ToString();
            lbl_product_ID.Text = selectedRow.Cells["product_ID"].Value.ToString();
            lbl_productName.Text = selectedRow.Cells["product_name"].Value.ToString();
            lbl_order_date.Text = Convert.ToDateTime(selectedRow.Cells["date_time"].Value).ToString("yyyy-MM-dd");
            lbl_desc.Text = selectedRow.Cells["description"].Value.ToString();
            lbl_price.Text = selectedRow.Cells["price"].Value.ToString();
            lbl_quantity.Text = selectedRow.Cells["quantity"].Value.ToString();
            lbl_total.Text = selectedRow.Cells["total_Price"].Value.ToString();
            lbl_paymentMethod.Text = selectedRow.Cells["paymentMethod"].Value.ToString();
            lbl_status.Text = selectedRow.Cells["order_status"].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
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
            lbl_status.Text = string.Empty;
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
