using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_Car_Traders_
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void chart_car_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cus_view_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM customer WHERE customer_ID = @customer_ID";

            using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlsearch, con))
                {
                    cmd.Parameters.AddWithValue("@customer_ID", txt_Customer_ID.Text);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_Customer.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Data Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_car_part_view_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM [add_Car_Part] WHERE car_Part_ID = @car_Part_ID";

            using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlsearch, con))
                {
                    cmd.Parameters.AddWithValue("@car_Part_ID", txt_Car_Part_ID.Text);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_CarPart.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Data Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }

        }

        private void btn_car_view_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM add_Car WHERE car_ID = @car_ID";

            using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlsearch, con))
                {
                    cmd.Parameters.AddWithValue("@car_ID", txt_Car_ID.Text);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_Car.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Data Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void btn_order_view_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM [order] WHERE order_ID = @order_ID";

            using (SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlsearch, con))
                {
                    cmd.Parameters.AddWithValue("@order_ID", txt_Order_ID.Text);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_Order.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Data Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void btn_cus_download_Click(object sender, EventArgs e)
        {
            if (dataGridView_Customer.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "customer.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView_Customer.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pTable.DefaultCell.BorderWidth = 1;

                            // Adding a heading to the PDF
                            PdfPCell headerCell = new PdfPCell(new Phrase("Customer Details Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)));
                            headerCell.Colspan = dataGridView_Customer.Columns.Count;
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            headerCell.BackgroundColor = new BaseColor(0, 120, 215); // Example background color
                            headerCell.Padding = 10;
                            pTable.AddCell(headerCell);

                            // Adding the headers
                            foreach (DataGridViewColumn column in dataGridView_Customer.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new BaseColor(240, 240, 240);
                                pTable.AddCell(cell);
                            }

                            // Adding the rows
                            foreach (DataGridViewRow row in dataGridView_Customer.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        if (cell.ColumnIndex == 10) // Assuming column 8 is the image column
                                        {
                                            byte[] imageBytes = (byte[])cell.Value;
                                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                                            img.ScaleAbsolute(50f, 50f); // Adjust the size of the image
                                            PdfPCell imgCell = new PdfPCell(img);
                                            pTable.AddCell(imgCell);
                                        }
                                        else
                                        {
                                            pTable.AddCell(cell.Value.ToString());
                                        }
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data exported successfully.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }

        }

        private void btn_car_download_Click(object sender, EventArgs e)
        {
            if (dataGridView_Car.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "add_Car.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView_Car.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pTable.DefaultCell.BorderWidth = 1;

                            // Adding a heading to the PDF
                            PdfPCell headerCell = new PdfPCell(new Phrase("Car Details Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)));
                            headerCell.Colspan = dataGridView_Car.Columns.Count;
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            headerCell.BackgroundColor = new BaseColor(0, 120, 215); // Example background color
                            headerCell.Padding = 10;
                            pTable.AddCell(headerCell);

                            // Adding the headers
                            foreach (DataGridViewColumn column in dataGridView_Car.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new BaseColor(240, 240, 240);
                                pTable.AddCell(cell);
                            }

                            // Adding the rows
                            foreach (DataGridViewRow row in dataGridView_Car.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        if (cell.ColumnIndex == 10) // Assuming column 8 is the image column
                                        {
                                            byte[] imageBytes = (byte[])cell.Value;
                                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                                            img.ScaleAbsolute(50f, 50f); // Adjust the size of the image
                                            PdfPCell imgCell = new PdfPCell(img);
                                            pTable.AddCell(imgCell);
                                        }
                                        else
                                        {
                                            pTable.AddCell(cell.Value.ToString());
                                        }
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data exported successfully.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }

        private void btn_car_part_download_Click(object sender, EventArgs e)
        {
            if (dataGridView_CarPart.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "add_Car_Part.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView_CarPart.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pTable.DefaultCell.BorderWidth = 1;

                            // Adding a heading to the PDF
                            PdfPCell headerCell = new PdfPCell(new Phrase("Car Part Details Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)));
                            headerCell.Colspan = dataGridView_CarPart.Columns.Count;
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            headerCell.BackgroundColor = new BaseColor(0, 120, 215); // Example background color
                            headerCell.Padding = 10;
                            pTable.AddCell(headerCell);

                            // Adding the headers
                            foreach (DataGridViewColumn column in dataGridView_CarPart.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new BaseColor(240, 240, 240);
                                pTable.AddCell(cell);
                            }

                            // Adding the rows
                            foreach (DataGridViewRow row in dataGridView_CarPart.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        if (cell.ColumnIndex == 8) // Assuming column 8 is the image column
                                        {
                                            byte[] imageBytes = (byte[])cell.Value;
                                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                                            img.ScaleAbsolute(50f, 50f); // Adjust the size of the image
                                            PdfPCell imgCell = new PdfPCell(img);
                                            pTable.AddCell(imgCell);
                                        }
                                        else
                                        {
                                            pTable.AddCell(cell.Value.ToString());
                                        }
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data exported successfully.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }

        private void btn_order_download_Click(object sender, EventArgs e)
        {
            if (dataGridView_Order.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "order.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView_Order.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pTable.DefaultCell.BorderWidth = 1;

                            // Adding a heading to the PDF
                            PdfPCell headerCell = new PdfPCell(new Phrase("Order Details Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)));
                            headerCell.Colspan = dataGridView_Order.Columns.Count;
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            headerCell.BackgroundColor = new BaseColor(0, 120, 215); // Example background color
                            headerCell.Padding = 10;
                            pTable.AddCell(headerCell);

                            // Adding the headers
                            foreach (DataGridViewColumn column in dataGridView_Order.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new BaseColor(240, 240, 240);
                                pTable.AddCell(cell);
                            }

                            // Adding the rows
                            foreach (DataGridViewRow row in dataGridView_Order.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        //if (cell.ColumnIndex == 8) // Assuming column 8 is the image column
                                        //{
                                        //    int someIntVariable = 12345678; // This is your integer variable
                                        //    byte[] data = BitConverter.GetBytes(someIntVariable);
                                        //    //byte[] imageBytes = (byte[])cell.Value;
                                        //    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                                        //    img.ScaleAbsolute(50f, 50f); // Adjust the size of the image
                                        //    PdfPCell imgCell = new PdfPCell(img);
                                        //    pTable.AddCell(imgCell);
                                        //}
                                        //else
                                        //{
                                        //    pTable.AddCell(cell.Value.ToString());
                                        //}

                                        if (cell.ColumnIndex == 8) // Assuming column 8 is the image column
                                        {
                                            // Ensure cell.Value is a byte array
                                            if (cell.Value is byte[] imageBytes)
                                            {
                                                // Create an image instance from the byte array
                                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                                                img.ScaleAbsolute(50f, 50f); // Adjust the size of the image
                                                PdfPCell imgCell = new PdfPCell(img);
                                                pTable.AddCell(imgCell);
                                            }
                                            else
                                            {
                                                // Handle the case where the cell value is not a byte array
                                                pTable.AddCell("Invalid image data");
                                            }
                                        }
                                        else
                                        {
                                            pTable.AddCell(cell.Value.ToString());
                                        }
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data exported successfully.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }



        private void dataGridView_Car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CarPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_CarPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CarPart_CellContentClick);
        
        }

        private void txt_Car_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
