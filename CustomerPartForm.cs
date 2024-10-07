using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders_
{
    public partial class CustomerPartForm : Form
    {
        public CustomerPartForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");
        private void datagridcarparts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    datagridcarparts.DataSource = dataTable;
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

        private void CustomerPartForm_Load(object sender, EventArgs e)
        {
            LoadCarPartData();
        }

        private void LoadCarPartData()
        {
            string query = "SELECT * FROM add_Car_Part";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datagridcarparts.DataSource = dataTable;
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

        private void txt_customer_car_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_customer_car_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
           
            string partName = txt_cus_car_part_name.Text;
            string partID = txt_cus_car_part_ID.Text;
            string partquantity = txt_cus_part_quantity.Text;
            string partDescription = txt_cus_part_desc.Text;
            string partPrice = txt_cus_car_part_price.Text;

            
            OrderForm orderForm = new OrderForm(partName, partID, partDescription, partPrice);
            orderForm.StartPosition = FormStartPosition.Manual;
            orderForm.Location = new Point(227, 37);
            orderForm.Show();

            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            string sqlsearch = "SELECT car_Part_ID, car_Part_Name, car_Part_Stock, car_Part_Price, car_Part_description, car_Part_Image FROM add_Car_Part WHERE car_Part_ID = @car_Part_ID";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("@car_Part_ID", txt_search.Text);

           
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_cus_car_part_ID.Text = dr["car_Part_ID"].ToString();
                    txt_cus_car_part_name.Text = dr["car_Part_Name"].ToString();
                    txt_cus_part_quantity.Text = dr["car_Part_Stock"].ToString();
                    txt_cus_car_part_price.Text = dr["car_Part_Price"].ToString();
                    txt_cus_part_desc.Text = dr["car_Part_description"].ToString();

                    
                    if (dr["car_Part_Image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])dr["car_Part_Image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pic_part.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pic_part.Image = null; 
                    }
                }
                else
                {
                    MessageBox.Show("Car part ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields(); 
                }
        }
            
        
        private void ClearFields()
        {
            txt_cus_car_part_ID.Text = "";
            txt_cus_car_part_name.Text = "";
            txt_cus_part_quantity.Text = "";
            txt_cus_car_part_price.Text = "";
            txt_cus_part_desc.Text = "";
            
            pic_part.Image = null; 
        }

        private void pic_part_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txt_cus_car_part_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
