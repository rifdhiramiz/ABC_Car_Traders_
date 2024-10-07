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
using System.IO;

namespace ABC_Car_Traders_
{
    public partial class CustomerCarForm : Form
    {
        public CustomerCarForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void CustomerCarForm_Load(object sender, EventArgs e)
        {
            LoadCarData();
        }

        private void LoadCarData()
        {
            string query = "SELECT * FROM add_Car";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridcar.DataSource = dataTable;
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

        private void datagridcar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM add_Car";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridcar.DataSource = dataTable;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sqlsearch = "select * from add_Car where car_ID ='" + txt_search.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("@car_ID", txt_search.Text);


            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_customer_car_ID.Text = dr["car_ID"].ToString();
                txt_customer_car_name.Text = dr["car_Name"].ToString();
                txt_customer_car_model.Text = dr["model"].ToString();
                txt_customer_car_year.Text = dr["year"].ToString();
                txt_customer_car_price.Text = dr["price"].ToString();
                txt_customer_car_desc.Text = dr["description"].ToString();

                
                if (dr["image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dr["image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic_car.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic_car.Image = null; 
                }
            }
            else
            {
                MessageBox.Show("Invalid Car ID", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            string carName = txt_customer_car_name.Text;
            string carID = txt_customer_car_ID.Text;
            string carDescription = txt_customer_car_desc.Text;
            string carPrice = txt_customer_car_price.Text;

            if (string.IsNullOrEmpty(carName) || string.IsNullOrEmpty(carID) || string.IsNullOrEmpty(carPrice))
            {
                MessageBox.Show("Please fill in all required fields before placing the order.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderForm orderForm = new OrderForm(carName, carID, carDescription, carPrice);
            orderForm.StartPosition = FormStartPosition.Manual;
            orderForm.Location = new Point(227, 37);
            orderForm.Show();

            this.Hide();

        }


        private void txt_customer_car_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_customer_car_ID.Text = "";
            txt_customer_car_name.Text = "";
            txt_customer_car_model.Text = "";
            txt_customer_car_year.Text = "";
            txt_customer_car_price.Text = "";
            txt_customer_car_desc.Text = "";
            //txt_search.Text = "";
            
            pic_car.Image = null;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
