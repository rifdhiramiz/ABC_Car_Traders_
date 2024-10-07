namespace ABC_Car_Traders_
{
    partial class CustomerOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.datagridmyorders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_paymentMethod = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_product_ID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.lbl_order_ID = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmyorders)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1368, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 28);
            this.label11.TabIndex = 119;
            this.label11.Text = "Order Details";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // datagridmyorders
            // 
            this.datagridmyorders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridmyorders.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridmyorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridmyorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridmyorders.Location = new System.Drawing.Point(46, 198);
            this.datagridmyorders.Margin = new System.Windows.Forms.Padding(4);
            this.datagridmyorders.MultiSelect = false;
            this.datagridmyorders.Name = "datagridmyorders";
            this.datagridmyorders.ReadOnly = true;
            this.datagridmyorders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridmyorders.RowHeadersWidth = 51;
            this.datagridmyorders.Size = new System.Drawing.Size(1283, 570);
            this.datagridmyorders.TabIndex = 94;
            this.datagridmyorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridmyorders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 93;
            this.label1.Text = "MY ORDERS";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(462, 132);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(336, 22);
            this.txt_search.TabIndex = 130;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1368, 466);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 23);
            this.label17.TabIndex = 144;
            this.label17.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1368, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 143;
            this.label2.Text = "Product ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1368, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 142;
            this.label14.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1368, 715);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 141;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1366, 670);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 140;
            this.label4.Text = "Payment Method:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1366, 630);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 139;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1367, 585);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 138;
            this.label9.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1367, 548);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 137;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1367, 507);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 136;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1367, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 135;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1367, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 134;
            this.label5.Text = "Contact Number:\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1367, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 23);
            this.label13.TabIndex = 133;
            this.label13.Text = "Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1368, 197);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 23);
            this.label16.TabIndex = 132;
            this.label16.Text = "Order ID:";
            // 
            // lbl_paymentMethod
            // 
            this.lbl_paymentMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentMethod.Location = new System.Drawing.Point(1561, 664);
            this.lbl_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paymentMethod.Name = "lbl_paymentMethod";
            this.lbl_paymentMethod.Size = new System.Drawing.Size(208, 21);
            this.lbl_paymentMethod.TabIndex = 156;
            // 
            // lbl_productName
            // 
            this.lbl_productName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(1561, 460);
            this.lbl_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(208, 21);
            this.lbl_productName.TabIndex = 155;
            // 
            // lbl_product_ID
            // 
            this.lbl_product_ID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_ID.Location = new System.Drawing.Point(1561, 415);
            this.lbl_product_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_ID.Name = "lbl_product_ID";
            this.lbl_product_ID.Size = new System.Drawing.Size(208, 21);
            this.lbl_product_ID.TabIndex = 154;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(1560, 267);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(208, 21);
            this.lbl_name.TabIndex = 153;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1560, 624);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(208, 21);
            this.lbl_total.TabIndex = 152;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(1560, 580);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(208, 21);
            this.lbl_quantity.TabIndex = 151;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(1560, 542);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(208, 21);
            this.lbl_price.TabIndex = 150;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(1560, 501);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(208, 21);
            this.lbl_desc.TabIndex = 149;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(1560, 343);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(208, 54);
            this.lbl_address.TabIndex = 148;
            // 
            // lbl_contact
            // 
            this.lbl_contact.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(1560, 300);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(208, 21);
            this.lbl_contact.TabIndex = 147;
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(1560, 229);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(208, 21);
            this.lbl_order_date.TabIndex = 146;
            // 
            // lbl_order_ID
            // 
            this.lbl_order_ID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_ID.Location = new System.Drawing.Point(1558, 194);
            this.lbl_order_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_ID.Name = "lbl_order_ID";
            this.lbl_order_ID.Size = new System.Drawing.Size(208, 21);
            this.lbl_order_ID.TabIndex = 145;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(1560, 711);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(208, 21);
            this.lbl_status.TabIndex = 157;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.FlatAppearance.BorderSize = 0;
            this.btn_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(1373, 787);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(147, 52);
            this.btn_view.TabIndex = 158;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1372, 853);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 52);
            this.btn_clear.TabIndex = 159;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(817, 122);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(164, 42);
            this.btn_search.TabIndex = 131;
            this.btn_search.Text = "Select";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 23);
            this.label12.TabIndex = 160;
            this.label12.Text = "Enter Customer Name:";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 905);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_paymentMethod);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.lbl_product_ID);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.lbl_order_ID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datagridmyorders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridmyorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datagridmyorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_paymentMethod;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_product_ID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Label lbl_order_ID;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label12;
    }
}