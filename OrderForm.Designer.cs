namespace ABC_Car_Traders_
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_ID = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.datetime_order = new System.Windows.Forms.DateTimePicker();
            this.lbl_paymentMethod = new System.Windows.Forms.Label();
            this.cmbx_paymentMethod = new System.Windows.Forms.ComboBox();
            this.btn_confirm_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // num_quantity
            // 
            this.num_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.num_quantity, "num_quantity");
            this.num_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.ReadOnly = true;
            this.num_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_quantity.ValueChanged += new System.EventHandler(this.num_quantity_ValueChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_address
            // 
            resources.ApplyResources(this.txt_address, "txt_address");
            this.txt_address.Name = "txt_address";
            this.txt_address.TextChanged += new System.EventHandler(this.txt_add_TextChanged);
            // 
            // txt_cus_name
            // 
            resources.ApplyResources(this.txt_cus_name, "txt_cus_name");
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbl_order_date
            // 
            resources.ApplyResources(this.lbl_order_date, "lbl_order_date");
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_contact
            // 
            resources.ApplyResources(this.txt_contact, "txt_contact");
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_tp_TextChanged);
            // 
            // txt_product_name
            // 
            resources.ApplyResources(this.txt_product_name, "txt_product_name");
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.TextChanged += new System.EventHandler(this.txt_product_name_TextChanged);
            // 
            // txt_product_ID
            // 
            resources.ApplyResources(this.txt_product_ID, "txt_product_ID");
            this.txt_product_ID.Name = "txt_product_ID";
            this.txt_product_ID.TextChanged += new System.EventHandler(this.txt_product_ID_TextChanged);
            // 
            // txt_desc
            // 
            resources.ApplyResources(this.txt_desc, "txt_desc");
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.TextChanged += new System.EventHandler(this.txt_desc_TextChanged);
            // 
            // txt_price
            // 
            resources.ApplyResources(this.txt_price, "txt_price");
            this.txt_price.Name = "txt_price";
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // txt_total
            // 
            resources.ApplyResources(this.txt_total, "txt_total");
            this.txt_total.Name = "txt_total";
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // datetime_order
            // 
            resources.ApplyResources(this.datetime_order, "datetime_order");
            this.datetime_order.Name = "datetime_order";
            this.datetime_order.ValueChanged += new System.EventHandler(this.datetime_order_ValueChanged);
            // 
            // lbl_paymentMethod
            // 
            resources.ApplyResources(this.lbl_paymentMethod, "lbl_paymentMethod");
            this.lbl_paymentMethod.Name = "lbl_paymentMethod";
            // 
            // cmbx_paymentMethod
            // 
            this.cmbx_paymentMethod.DisplayMember = "Method";
            this.cmbx_paymentMethod.FormattingEnabled = true;
            this.cmbx_paymentMethod.Items.AddRange(new object[] {
            resources.GetString("cmbx_paymentMethod.Items"),
            resources.GetString("cmbx_paymentMethod.Items1")});
            resources.ApplyResources(this.cmbx_paymentMethod, "cmbx_paymentMethod");
            this.cmbx_paymentMethod.Name = "cmbx_paymentMethod";
            this.cmbx_paymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbx_paymentMethod_SelectedIndexChanged);
            // 
            // btn_confirm_order
            // 
            this.btn_confirm_order.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirm_order.FlatAppearance.BorderSize = 0;
            this.btn_confirm_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_confirm_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btn_confirm_order, "btn_confirm_order");
            this.btn_confirm_order.ForeColor = System.Drawing.Color.White;
            this.btn_confirm_order.Name = "btn_confirm_order";
            this.btn_confirm_order.UseVisualStyleBackColor = false;
            this.btn_confirm_order.Click += new System.EventHandler(this.btn_confirm_order_Click_1);
            // 
            // OrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_confirm_order);
            this.Controls.Add(this.cmbx_paymentMethod);
            this.Controls.Add(this.lbl_paymentMethod);
            this.Controls.Add(this.datetime_order);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_product_ID);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.num_quantity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_cus_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_ID;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DateTimePicker datetime_order;
        private System.Windows.Forms.Label lbl_paymentMethod;
        private System.Windows.Forms.ComboBox cmbx_paymentMethod;
        private System.Windows.Forms.Button btn_confirm_order;
    }
}