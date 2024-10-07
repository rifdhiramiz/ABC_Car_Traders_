﻿using System;
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
    public partial class CustomerDashForm : Form
    {
        public CustomerDashForm(string customerName)
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

        private void btn_cars_Click(object sender, EventArgs e)
        {
            loadform(new CustomerCarForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void btnparts_Click(object sender, EventArgs e)
        {
            loadform(new CustomerPartForm());
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            loadform(new CustomerOrderForm());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_un_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customerName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
