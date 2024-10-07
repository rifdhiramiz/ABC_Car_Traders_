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
using System.Runtime.ConstrainedExecution;

namespace ABC_Car_Traders_
{
    public partial class UpdatePartForm : Form
    {
        public UpdatePartForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void UpdatePartForm_Load(object sender, EventArgs e)
        {
            LoadCarPartsData();  
        }

        private void LoadCarPartsData()
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

        private void btn_search_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_search.Text))
            {
                MessageBox.Show("Please enter a Car Part ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlsearch = "SELECT * FROM add_Car_Part WHERE car_Part_ID = @car_Part_ID";
            using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand(sqlsearch, con))
            {
                cmd.Parameters.AddWithValue("@car_Part_ID", txt_search.Text);
                try
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_Car_Part_ID.Text = dr["car_Part_ID"].ToString();
                            txt_name.Text = dr["car_Part_Name"].ToString();
                            txt_price.Text = dr["car_Part_Price"].ToString();
                            txt_stock.Text = dr["car_Part_Stock"].ToString();
                            txt_desc.Text = dr["car_Part_Description"].ToString();

                            if (dr["car_Part_Image"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])dr["car_Part_Image"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    try
                                    {
                                        Bitmap bitmap = new Bitmap(ms);
                                        pic_carpart.Image = bitmap;
                                    }
                                    catch (ArgumentException ex)
                                    {
                                        MessageBox.Show("Invalid image data: " + ex.Message);
                                        pic_carpart.Image = null;
                                    }
                                }
                            }
                            else
                            {
                                pic_carpart.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Car Part ID", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_Car_Part_ID.Text) ||
        string.IsNullOrEmpty(txt_name.Text) ||
        string.IsNullOrEmpty(txt_price.Text) ||
        string.IsNullOrEmpty(txt_stock.Text) ||
        string.IsNullOrEmpty(txt_desc.Text))
            {
                MessageBox.Show("Please search for and select a car part before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (MessageBox.Show("Do you want to delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string sqldelete = "DELETE FROM add_Car_Part WHERE car_Part_ID = @car_Part_ID";
                    using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
                    using (SqlCommand cmd = new SqlCommand(sqldelete, con))
                    {
                        cmd.Parameters.AddWithValue("@car_Part_ID", txt_search.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Part Details Deleted successfully!");
                        LoadCarPartsData();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

         if (string.IsNullOrEmpty(txt_name.Text) ||
            string.IsNullOrEmpty(txt_price.Text) ||
            string.IsNullOrEmpty(txt_stock.Text) ||
            string.IsNullOrEmpty(txt_desc.Text) ||
            pic_carpart.Image == null)
                {
                    MessageBox.Show("Please fill in all details and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sqlCheck = "SELECT car_Part_Name, car_Part_Price, car_Part_Stock, car_Part_Description FROM add_Car_Part WHERE car_Part_ID = @car_Part_ID";
                using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
                using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@car_Part_ID", txt_Car_Part_ID.Text);
                    try
                    {
                        con.Open();
                        using (SqlDataReader dr = cmdCheck.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                bool isModified = false;

                                if (dr["car_Part_Name"].ToString() != txt_name.Text)
                                    isModified = true;
                                if (dr["car_Part_Price"].ToString() != txt_price.Text)
                                    isModified = true;
                                if (dr["car_Part_Stock"].ToString() != txt_stock.Text)
                                    isModified = true;
                                if (dr["car_Part_Description"].ToString() != txt_desc.Text)
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
                                MessageBox.Show("Car Part not found. Please check the Part ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                }

                try
                {
                    string sqlUpdate = "UPDATE add_Car_Part SET car_Part_Name = @car_Part_Name, car_Part_Price = @car_Part_Price, " +
                                       "car_Part_Stock = @car_Part_Stock, car_Part_Description = @car_Part_Description";

                    if (!string.IsNullOrEmpty(txt_image.Text))
                    {
                        sqlUpdate += ", car_Part_Image = @car_Part_Image";
                    }

                    sqlUpdate += " WHERE car_Part_ID = @car_Part_ID";

                    using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@car_Part_Name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@car_Part_Price", txt_price.Text);
                        cmd.Parameters.AddWithValue("@car_Part_Stock", txt_stock.Text);
                        cmd.Parameters.AddWithValue("@car_Part_Description", txt_desc.Text);
                        cmd.Parameters.AddWithValue("@car_Part_ID", txt_Car_Part_ID.Text);

                        if (!string.IsNullOrEmpty(txt_image.Text))
                        {
                            byte[] imgBytes = File.ReadAllBytes(txt_image.Text);
                            cmd.Parameters.AddWithValue("@car_Part_Image", imgBytes);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@car_Part_Image", DBNull.Value);
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully", "Update Car Part Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCarPartsData();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er.Message);
                }
            }

            private void datagridcarparts_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
          
            }

            private void pic_carpart_Click(object sender, EventArgs e)
            {
            
                if (pic_carpart.Image != null)
                {
                    try
                    {
                   
                        using (MemoryStream ms = new MemoryStream())
                        {
                        
                            pic_carpart.Image.Save(ms, pic_carpart.Image.RawFormat);
                            byte[] pictureData = ms.ToArray(); 

                        
                        }

                        MessageBox.Show("Image data processed successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No image selected.");
                }

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_carpart.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_name.Text) || 
                string.IsNullOrEmpty(txt_price.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) || 
                string.IsNullOrEmpty(txt_desc.Text) ||
                pic_carpart.Image == null)
            {
                MessageBox.Show("Please fill in all details and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            try
            {
                string sqlinsert = "INSERT INTO add_Car_Part (car_Part_Name, car_Part_Price, car_Part_Stock, car_Part_Description, car_Part_Image) " +
                                   "VALUES (@car_Part_Name, @car_Part_Price, @car_Part_Stock, @car_Part_Description, @car_Part_Image)";
                SqlCommand cmd = new SqlCommand(sqlinsert, con);
                cmd.Parameters.AddWithValue("@car_Part_Name", txt_name.Text);
                cmd.Parameters.AddWithValue("@car_Part_Price", txt_price.Text);
                cmd.Parameters.AddWithValue("@car_Part_Stock", txt_stock.Text);
                cmd.Parameters.AddWithValue("@car_Part_Description", txt_desc.Text);

                
                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    byte[] imgBytes = File.ReadAllBytes(txt_image.Text);
                    cmd.Parameters.AddWithValue("@car_Part_Image", imgBytes);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@car_Part_Image", DBNull.Value);
                }

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!!");
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

        private void btn_part_clear_Click(object sender, EventArgs e)
        {
            
            bool isEmpty = string.IsNullOrEmpty(txt_Car_Part_ID.Text) &&
                           string.IsNullOrEmpty(txt_name.Text) &&
                           string.IsNullOrEmpty(txt_price.Text) &&
                           string.IsNullOrEmpty(txt_stock.Text) &&
                           string.IsNullOrEmpty(txt_desc.Text) &&
                           string.IsNullOrEmpty(txt_image.Text) &&
                           string.IsNullOrEmpty(txt_search.Text) &&
                           pic_carpart.Image == null;

            if (isEmpty)
            {
                MessageBox.Show("All fields are already empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            txt_Car_Part_ID.Text = string.Empty;
            txt_name.Clear();
            txt_price.Clear();
            txt_stock.Clear();
            txt_desc.Clear();
            txt_image.Clear();
            txt_search.Clear();

            pic_carpart.Image = null;

        }

        private void txt_Car_Part_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
