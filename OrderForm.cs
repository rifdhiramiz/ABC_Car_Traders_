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
    public partial class OrderForm : Form
    {
        
        private string carName;
        private string carNameID;
        private string carModel;
        private string carDescription;
        private string carPrice;

        public OrderForm(string productName, string productID, string description, string price)
        {
            InitializeComponent();

            txt_product_name.Text = productName;
            txt_product_ID.Text = productID;
            txt_desc.Text = description;
            txt_price.Text = price;

            CalculateTotal();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");
        private void OrderForm_Load(object sender, EventArgs e)
        {
           CalculateTotal();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txt_product_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_product_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_quantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(txt_price.Text, out decimal price) && num_quantity.Value > 0)
            {
                txt_total.Text = (price * num_quantity.Value).ToString();
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetime_order_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbx_paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_order_Click_1(object sender, EventArgs e)
        {
               try
                {
                    string sqlinsert = "INSERT INTO [order] (product_name, product_ID, description, price, quantity, total_Price, customer_name, contact_number, address, date_time, paymentMethod) " +
                                       "VALUES (@product_name, @product_ID, @description, @price, @quantity, @total_price, @customer_name, @contact_number, @address, @date_time, @paymentMethod)";

                    using (SqlCommand cmd = new SqlCommand(sqlinsert, con))
                    {
                        cmd.Parameters.AddWithValue("@product_name", txt_product_name.Text);
                        cmd.Parameters.AddWithValue("@product_ID", txt_product_ID.Text);
                        cmd.Parameters.AddWithValue("@description", txt_desc.Text);

                        decimal price = decimal.Parse(txt_price.Text, System.Globalization.NumberStyles.Currency);
                        cmd.Parameters.AddWithValue("@price", price);

                        int quantity = (int)num_quantity.Value;
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        decimal totalPrice = decimal.Parse(txt_total.Text, System.Globalization.NumberStyles.Currency);
                        cmd.Parameters.AddWithValue("@total_price", totalPrice);

                        cmd.Parameters.AddWithValue("@customer_name", txt_cus_name.Text);
                        cmd.Parameters.AddWithValue("@contact_number", txt_contact.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);

                        DateTime orderDateTime = DateTime.Parse(datetime_order.Text);
                        cmd.Parameters.AddWithValue("@date_time", orderDateTime);

                        cmd.Parameters.AddWithValue("@paymentMethod", cmbx_paymentMethod.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Your Order is Pending!!");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    con.Close(); 
                }

            }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
