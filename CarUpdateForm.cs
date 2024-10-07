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
    public partial class CarUpdateForm : Form
    {
        public CarUpdateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                
                MessageBox.Show("Please enter a Car ID in the search field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string sqlsearch;
            sqlsearch = "select * from add_Car where car_ID ='" + txt_search.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_Car_ID.Text = dr["car_ID"].ToString();
                txt_Car_Name.Text = dr["car_Name"].ToString();
                txt_model.Text = dr["model"].ToString();
                txt_year.Text = dr["year"].ToString();
                txt_price.Text = dr["price"].ToString();
                txt_stock.Text = dr["stock"].ToString();
                txt_description.Text = dr["description"].ToString();

                if (dr["image"] != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])dr["image"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
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
                MessageBox.Show("Invalid Car ID ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_Car_Name.Text) ||
                string.IsNullOrEmpty(txt_model.Text) ||
                string.IsNullOrEmpty(txt_year.Text) ||
                string.IsNullOrEmpty(txt_price.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) ||
                string.IsNullOrEmpty(txt_description.Text))
            {
               
                MessageBox.Show("Please load the car details before attempting to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                if (MessageBox.Show("Do you want to delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string sqldelete = "DELETE FROM add_Car WHERE car_ID = @car_ID"; ;
                    sqldelete = " delete from add_Car where car_ID='" + txt_search.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.Parameters.AddWithValue("car_ID", txt_search.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Details Deleted sucsessfully!!");
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
            
            if (string.IsNullOrEmpty(txt_Car_Name.Text) ||
                string.IsNullOrEmpty(txt_model.Text) ||
                string.IsNullOrEmpty(txt_year.Text) ||
                string.IsNullOrEmpty(txt_price.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) ||
                string.IsNullOrEmpty(txt_description.Text))
            {
                
                MessageBox.Show("Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            string originalCarName = txt_Car_Name.Tag as string;
            string originalModel = txt_model.Tag as string;
            string originalYear = txt_year.Tag as string;
            string originalPrice = txt_price.Tag as string;
            string originalStock = txt_stock.Tag as string;
            string originalDescription = txt_description.Tag as string;

            if (txt_Car_Name.Text == originalCarName &&
                txt_model.Text == originalModel &&
                txt_year.Text == originalYear &&
                txt_price.Text == originalPrice &&
                txt_stock.Text == originalStock &&
                txt_description.Text == originalDescription &&
                string.IsNullOrEmpty(txt_image.Text))
            {
                MessageBox.Show("No changes detected. Please update the relevant fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            try
            {
                string sqlUpdate = "UPDATE add_Car SET car_Name = @car_Name, model = @model, year = @year, price = @price, stock = @stock, " +
                               "description = @description";
                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    sqlUpdate += ", image = @image";
                }

                sqlUpdate += " WHERE car_ID = @car_ID";  


                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("car_Name", txt_Car_Name.Text);
                cmd.Parameters.AddWithValue("model", txt_model.Text);
                cmd.Parameters.AddWithValue("year", txt_year.Text);
                cmd.Parameters.AddWithValue("price", txt_price.Text);
                cmd.Parameters.AddWithValue("stock", txt_stock.Text);
                cmd.Parameters.AddWithValue("description", txt_description.Text);
                cmd.Parameters.AddWithValue("car_ID", txt_Car_ID.Text);

                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    byte[] imgBytes = File.ReadAllBytes(txt_image.Text);
                    cmd.Parameters.AddWithValue("@image", imgBytes);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@image", DBNull.Value);
                }


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesfully", "Update Car Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
            finally
            {

                con.Close();
            }
        }
        private void datagridcars_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    datagridcars.DataSource = dataTable;
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

        private void CarUpdateForm_Load(object sender, EventArgs e)
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
                    datagridcars.DataSource = dataTable; 
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

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file|*jpg;*jpeg;*png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_car.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txt_Car_Name.Text) ||
                string.IsNullOrEmpty(txt_model.Text) ||
                string.IsNullOrEmpty(txt_year.Text) ||
                string.IsNullOrEmpty(txt_price.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) ||
                string.IsNullOrEmpty(txt_description.Text) ||
                string.IsNullOrEmpty(txt_image.Text))
            {
                
                MessageBox.Show("Please fill in all the details, including uploading an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                string sqlinsert = "INSERT INTO add_Car (car_Name, model, year, price, stock, description, image) " +
                                   "VALUES (@car_Name, @model, @year, @price, @stock, @description, @image)";
                SqlCommand cmd = new SqlCommand(sqlinsert, con);

                cmd.Parameters.AddWithValue("car_Name", txt_Car_Name.Text);
                cmd.Parameters.AddWithValue("model", txt_model.Text);
                cmd.Parameters.AddWithValue("year", txt_year.Text);
                cmd.Parameters.AddWithValue("price", txt_price.Text);
                cmd.Parameters.AddWithValue("stock", txt_stock.Text);
                cmd.Parameters.AddWithValue("description", txt_description.Text);

                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    byte[] imgBytes = File.ReadAllBytes(txt_image.Text);
                    cmd.Parameters.AddWithValue("@image", imgBytes);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@image", DBNull.Value);
                }

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added sucsessfully!!");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        private void StoreOriginalValues()
        {
            txt_Car_Name.Tag = txt_Car_Name.Text;
            txt_model.Tag = txt_model.Text;
            txt_year.Tag = txt_year.Text;
            txt_price.Tag = txt_price.Text;
            txt_stock.Tag = txt_stock.Text;
            txt_description.Tag = txt_description.Text;
        }
        private void pic_car_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Car_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_image_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_car_claer_Click(object sender, EventArgs e)
        {

        }

        private void btn_car_clear_Click(object sender, EventArgs e)
        {
            txt_Car_ID.Text = string.Empty;
            txt_Car_Name.Clear();
            txt_model.Clear();
            txt_year.Clear();
            txt_price.Clear();
            txt_stock.Clear();
            txt_description.Clear();
            txt_image.Clear();
            txt_search.Clear();

            pic_car.Image = null;
        }

        private void btn_car_clear_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_Car_ID.Text) &&
                string.IsNullOrEmpty(txt_Car_Name.Text) &&
                string.IsNullOrEmpty(txt_model.Text) &&
                string.IsNullOrEmpty(txt_year.Text) &&
                string.IsNullOrEmpty(txt_price.Text) &&
                string.IsNullOrEmpty(txt_stock.Text) &&
                string.IsNullOrEmpty(txt_description.Text) &&
                string.IsNullOrEmpty(txt_image.Text) &&
                string.IsNullOrEmpty(txt_search.Text) &&
                pic_car.Image == null)
            {
                
                MessageBox.Show("The fields are already empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            txt_Car_ID.Text = string.Empty;
            txt_Car_Name.Clear();
            txt_model.Clear();
            txt_year.Clear();
            txt_price.Clear();
            txt_stock.Clear();
            txt_description.Clear();
            txt_image.Clear();
            //txt_search.Clear();
            pic_car.Image = null;
        }

        private void txt_Car_ID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
