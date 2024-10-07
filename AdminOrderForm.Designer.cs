namespace ABC_Car_Traders_
{
    partial class AdminOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbx_status = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.lbl_order_ID = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datagridorders = new System.Windows.Forms.DataGridView();
            this.lbl_product_ID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_paymentMethod = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridorders)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(246, 130);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(462, 22);
            this.txt_search.TabIndex = 97;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(1531, 266);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(208, 21);
            this.lbl_name.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1331, 266);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 95;
            this.label14.Text = "Name:";
            // 
            // cmbx_status
            // 
            this.cmbx_status.DisplayMember = "Pending";
            this.cmbx_status.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_status.FormattingEnabled = true;
            this.cmbx_status.Items.AddRange(new object[] {
            "Approved",
            "Reject"});
            this.cmbx_status.Location = new System.Drawing.Point(1524, 705);
            this.cmbx_status.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_status.Name = "cmbx_status";
            this.cmbx_status.Size = new System.Drawing.Size(203, 29);
            this.cmbx_status.TabIndex = 94;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1531, 626);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(208, 21);
            this.lbl_total.TabIndex = 92;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(1531, 581);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(208, 21);
            this.lbl_quantity.TabIndex = 91;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(1531, 544);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(208, 21);
            this.lbl_price.TabIndex = 90;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(1531, 503);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(208, 21);
            this.lbl_desc.TabIndex = 89;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(1531, 333);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(208, 54);
            this.lbl_address.TabIndex = 88;
            this.lbl_address.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // lbl_contact
            // 
            this.lbl_contact.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(1531, 299);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(208, 21);
            this.lbl_contact.TabIndex = 87;
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(1531, 226);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(208, 21);
            this.lbl_order_date.TabIndex = 86;
            // 
            // lbl_order_ID
            // 
            this.lbl_order_ID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_ID.Location = new System.Drawing.Point(1529, 182);
            this.lbl_order_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_ID.Name = "lbl_order_ID";
            this.lbl_order_ID.Size = new System.Drawing.Size(208, 21);
            this.lbl_order_ID.TabIndex = 84;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(1334, 784);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 52);
            this.btn_update.TabIndex = 83;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1330, 713);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 82;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1330, 666);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "Payment Method:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1330, 626);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 80;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1331, 581);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1331, 544);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1331, 503);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1331, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 76;
            this.label6.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1331, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Contact Number:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1331, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1332, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Order ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 28);
            this.label5.TabIndex = 71;
            this.label5.Text = "CUSTOMER ORDER DETAILS";
            // 
            // datagridorders
            // 
            this.datagridorders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridorders.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridorders.Location = new System.Drawing.Point(44, 182);
            this.datagridorders.Margin = new System.Windows.Forms.Padding(4);
            this.datagridorders.MultiSelect = false;
            this.datagridorders.Name = "datagridorders";
            this.datagridorders.ReadOnly = true;
            this.datagridorders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridorders.RowHeadersWidth = 51;
            this.datagridorders.Size = new System.Drawing.Size(1223, 532);
            this.datagridorders.TabIndex = 70;
            this.datagridorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridorders_CellContentClick);
            // 
            // lbl_product_ID
            // 
            this.lbl_product_ID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_ID.Location = new System.Drawing.Point(1532, 417);
            this.lbl_product_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_ID.Name = "lbl_product_ID";
            this.lbl_product_ID.Size = new System.Drawing.Size(208, 21);
            this.lbl_product_ID.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1332, 417);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 23);
            this.label15.TabIndex = 99;
            this.label15.Text = "Product ID:";
            // 
            // lbl_productName
            // 
            this.lbl_productName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(1532, 462);
            this.lbl_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(208, 21);
            this.lbl_productName.TabIndex = 102;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1332, 462);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 23);
            this.label17.TabIndex = 101;
            this.label17.Text = "Product Name:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1334, 850);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 52);
            this.btn_clear.TabIndex = 104;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_paymentMethod
            // 
            this.lbl_paymentMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentMethod.Location = new System.Drawing.Point(1532, 666);
            this.lbl_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paymentMethod.Name = "lbl_paymentMethod";
            this.lbl_paymentMethod.Size = new System.Drawing.Size(208, 21);
            this.lbl_paymentMethod.TabIndex = 103;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(727, 120);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 42);
            this.btn_search.TabIndex = 98;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 149;
            this.label4.Text = "Enter Order ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AdminOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 908);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_paymentMethod);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_product_ID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbx_status);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.lbl_order_ID);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagridorders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminOrderForm";
            this.Text = "AdminOrderForm";
            this.Load += new System.EventHandler(this.AdminOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbx_status;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Label lbl_order_ID;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagridorders;
        private System.Windows.Forms.Label lbl_product_ID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_paymentMethod;
        private System.Windows.Forms.Label label4;
    }
}