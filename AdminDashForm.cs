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
    public partial class AdminDashForm : Form
    {
        public AdminDashForm(string adminName)
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RIFDHIRAMIZ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders_;Integrated Security=True");
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            loadform(new DashboardForm());
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {

        }

        private void btn_partmenu_Click(object sender, EventArgs e)
        {
            loadform(new AddCarForm());
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            loadform(new CarUpdateForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new AddPartForm());
        }

        private void AdminDashForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new UpdatePartForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new CustomerUpdateForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new AdminOrderForm());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_carmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {

        }

        private void btn_manage_cus_Click(object sender, EventArgs e)
        {
             loadform(new CustomerUpdateForm());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_admin_name_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_admin_name_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
