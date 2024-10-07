namespace ABC_Car_Traders_
{
    partial class DashboardForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Car = new System.Windows.Forms.DataGridView();
            this.dataGridView_CarPart = new System.Windows.Forms.DataGridView();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.lbl_Car_ID = new System.Windows.Forms.Label();
            this.lbl_Car_Part_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Customer_ID = new System.Windows.Forms.TextBox();
            this.txt_Car_ID = new System.Windows.Forms.TextBox();
            this.txt_Car_Part_ID = new System.Windows.Forms.TextBox();
            this.txt_Order_ID = new System.Windows.Forms.TextBox();
            this.btn_cus_view = new System.Windows.Forms.Button();
            this.btn_car_part_view = new System.Windows.Forms.Button();
            this.btn_car_view = new System.Windows.Forms.Button();
            this.btn_order_view = new System.Windows.Forms.Button();
            this.btn_cus_download = new System.Windows.Forms.Button();
            this.btn_car_part_download = new System.Windows.Forms.Button();
            this.btn_car_download = new System.Windows.Forms.Button();
            this.btn_order_download = new System.Windows.Forms.Button();
            this.dataGridView_Customer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 37);
            this.label5.TabIndex = 48;
            this.label5.Text = "REPORT";
            // 
            // dataGridView_Car
            // 
            this.dataGridView_Car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Car.Location = new System.Drawing.Point(900, 161);
            this.dataGridView_Car.Name = "dataGridView_Car";
            this.dataGridView_Car.RowHeadersWidth = 51;
            this.dataGridView_Car.RowTemplate.Height = 24;
            this.dataGridView_Car.Size = new System.Drawing.Size(809, 320);
            this.dataGridView_Car.TabIndex = 50;
            this.dataGridView_Car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Car_CellContentClick);
            // 
            // dataGridView_CarPart
            // 
            this.dataGridView_CarPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CarPart.Location = new System.Drawing.Point(46, 573);
            this.dataGridView_CarPart.Name = "dataGridView_CarPart";
            this.dataGridView_CarPart.RowHeadersWidth = 51;
            this.dataGridView_CarPart.RowTemplate.Height = 24;
            this.dataGridView_CarPart.Size = new System.Drawing.Size(809, 320);
            this.dataGridView_CarPart.TabIndex = 51;
            this.dataGridView_CarPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CarPart_CellContentClick);
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Location = new System.Drawing.Point(900, 573);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(809, 320);
            this.dataGridView_Order.TabIndex = 52;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(42, 112);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(148, 23);
            this.lbl_Customer_ID.TabIndex = 53;
            this.lbl_Customer_ID.Text = "Customer ID:";
            // 
            // lbl_Car_ID
            // 
            this.lbl_Car_ID.AutoSize = true;
            this.lbl_Car_ID.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Car_ID.Location = new System.Drawing.Point(896, 118);
            this.lbl_Car_ID.Name = "lbl_Car_ID";
            this.lbl_Car_ID.Size = new System.Drawing.Size(83, 23);
            this.lbl_Car_ID.TabIndex = 54;
            this.lbl_Car_ID.Text = "Car ID:";
            // 
            // lbl_Car_Part_ID
            // 
            this.lbl_Car_Part_ID.AutoSize = true;
            this.lbl_Car_Part_ID.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Car_Part_ID.Location = new System.Drawing.Point(42, 524);
            this.lbl_Car_Part_ID.Name = "lbl_Car_Part_ID";
            this.lbl_Car_Part_ID.Size = new System.Drawing.Size(131, 23);
            this.lbl_Car_Part_ID.TabIndex = 55;
            this.lbl_Car_Part_ID.Text = "Car Part ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Order ID:";
            // 
            // txt_Customer_ID
            // 
            this.txt_Customer_ID.Location = new System.Drawing.Point(201, 114);
            this.txt_Customer_ID.Name = "txt_Customer_ID";
            this.txt_Customer_ID.Size = new System.Drawing.Size(235, 22);
            this.txt_Customer_ID.TabIndex = 57;
            // 
            // txt_Car_ID
            // 
            this.txt_Car_ID.Location = new System.Drawing.Point(1003, 122);
            this.txt_Car_ID.Name = "txt_Car_ID";
            this.txt_Car_ID.Size = new System.Drawing.Size(235, 22);
            this.txt_Car_ID.TabIndex = 58;
            this.txt_Car_ID.TextChanged += new System.EventHandler(this.txt_Car_ID_TextChanged);
            // 
            // txt_Car_Part_ID
            // 
            this.txt_Car_Part_ID.Location = new System.Drawing.Point(189, 528);
            this.txt_Car_Part_ID.Name = "txt_Car_Part_ID";
            this.txt_Car_Part_ID.Size = new System.Drawing.Size(235, 22);
            this.txt_Car_Part_ID.TabIndex = 59;
            // 
            // txt_Order_ID
            // 
            this.txt_Order_ID.Location = new System.Drawing.Point(1021, 528);
            this.txt_Order_ID.Name = "txt_Order_ID";
            this.txt_Order_ID.Size = new System.Drawing.Size(217, 22);
            this.txt_Order_ID.TabIndex = 60;
            // 
            // btn_cus_view
            // 
            this.btn_cus_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cus_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cus_view.FlatAppearance.BorderSize = 0;
            this.btn_cus_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cus_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cus_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cus_view.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus_view.ForeColor = System.Drawing.Color.White;
            this.btn_cus_view.Location = new System.Drawing.Point(452, 103);
            this.btn_cus_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cus_view.Name = "btn_cus_view";
            this.btn_cus_view.Size = new System.Drawing.Size(133, 45);
            this.btn_cus_view.TabIndex = 61;
            this.btn_cus_view.Text = "View";
            this.btn_cus_view.UseVisualStyleBackColor = false;
            this.btn_cus_view.Click += new System.EventHandler(this.btn_cus_view_Click);
            // 
            // btn_car_part_view
            // 
            this.btn_car_part_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_car_part_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_car_part_view.FlatAppearance.BorderSize = 0;
            this.btn_car_part_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_car_part_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_car_part_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_car_part_view.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_part_view.ForeColor = System.Drawing.Color.White;
            this.btn_car_part_view.Location = new System.Drawing.Point(442, 514);
            this.btn_car_part_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_car_part_view.Name = "btn_car_part_view";
            this.btn_car_part_view.Size = new System.Drawing.Size(133, 45);
            this.btn_car_part_view.TabIndex = 62;
            this.btn_car_part_view.Text = "View";
            this.btn_car_part_view.UseVisualStyleBackColor = false;
            this.btn_car_part_view.Click += new System.EventHandler(this.btn_car_part_view_Click);
            // 
            // btn_car_view
            // 
            this.btn_car_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_car_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_car_view.FlatAppearance.BorderSize = 0;
            this.btn_car_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_car_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_car_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_car_view.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_view.ForeColor = System.Drawing.Color.White;
            this.btn_car_view.Location = new System.Drawing.Point(1264, 104);
            this.btn_car_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_car_view.Name = "btn_car_view";
            this.btn_car_view.Size = new System.Drawing.Size(133, 45);
            this.btn_car_view.TabIndex = 63;
            this.btn_car_view.Text = "View";
            this.btn_car_view.UseVisualStyleBackColor = false;
            this.btn_car_view.Click += new System.EventHandler(this.btn_car_view_Click);
            // 
            // btn_order_view
            // 
            this.btn_order_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_order_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order_view.FlatAppearance.BorderSize = 0;
            this.btn_order_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_order_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_order_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_view.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_view.ForeColor = System.Drawing.Color.White;
            this.btn_order_view.Location = new System.Drawing.Point(1264, 516);
            this.btn_order_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order_view.Name = "btn_order_view";
            this.btn_order_view.Size = new System.Drawing.Size(133, 45);
            this.btn_order_view.TabIndex = 64;
            this.btn_order_view.Text = "View";
            this.btn_order_view.UseVisualStyleBackColor = false;
            this.btn_order_view.Click += new System.EventHandler(this.btn_order_view_Click);
            // 
            // btn_cus_download
            // 
            this.btn_cus_download.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cus_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cus_download.FlatAppearance.BorderSize = 0;
            this.btn_cus_download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cus_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cus_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cus_download.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus_download.ForeColor = System.Drawing.Color.White;
            this.btn_cus_download.Location = new System.Drawing.Point(594, 104);
            this.btn_cus_download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cus_download.Name = "btn_cus_download";
            this.btn_cus_download.Size = new System.Drawing.Size(133, 45);
            this.btn_cus_download.TabIndex = 65;
            this.btn_cus_download.Text = "Download";
            this.btn_cus_download.UseVisualStyleBackColor = false;
            this.btn_cus_download.Click += new System.EventHandler(this.btn_cus_download_Click);
            // 
            // btn_car_part_download
            // 
            this.btn_car_part_download.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_car_part_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_car_part_download.FlatAppearance.BorderSize = 0;
            this.btn_car_part_download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_car_part_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_car_part_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_car_part_download.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_part_download.ForeColor = System.Drawing.Color.White;
            this.btn_car_part_download.Location = new System.Drawing.Point(594, 514);
            this.btn_car_part_download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_car_part_download.Name = "btn_car_part_download";
            this.btn_car_part_download.Size = new System.Drawing.Size(133, 45);
            this.btn_car_part_download.TabIndex = 66;
            this.btn_car_part_download.Text = "Download";
            this.btn_car_part_download.UseVisualStyleBackColor = false;
            this.btn_car_part_download.Click += new System.EventHandler(this.btn_car_part_download_Click);
            // 
            // btn_car_download
            // 
            this.btn_car_download.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_car_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_car_download.FlatAppearance.BorderSize = 0;
            this.btn_car_download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_car_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_car_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_car_download.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_download.ForeColor = System.Drawing.Color.White;
            this.btn_car_download.Location = new System.Drawing.Point(1416, 104);
            this.btn_car_download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_car_download.Name = "btn_car_download";
            this.btn_car_download.Size = new System.Drawing.Size(133, 45);
            this.btn_car_download.TabIndex = 67;
            this.btn_car_download.Text = "Download";
            this.btn_car_download.UseVisualStyleBackColor = false;
            this.btn_car_download.Click += new System.EventHandler(this.btn_car_download_Click);
            // 
            // btn_order_download
            // 
            this.btn_order_download.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_order_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order_download.FlatAppearance.BorderSize = 0;
            this.btn_order_download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_order_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_order_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_download.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_download.ForeColor = System.Drawing.Color.White;
            this.btn_order_download.Location = new System.Drawing.Point(1416, 516);
            this.btn_order_download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order_download.Name = "btn_order_download";
            this.btn_order_download.Size = new System.Drawing.Size(133, 45);
            this.btn_order_download.TabIndex = 68;
            this.btn_order_download.Text = "Download";
            this.btn_order_download.UseVisualStyleBackColor = false;
            this.btn_order_download.Click += new System.EventHandler(this.btn_order_download_Click);
            // 
            // dataGridView_Customer
            // 
            this.dataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer.Location = new System.Drawing.Point(46, 161);
            this.dataGridView_Customer.Name = "dataGridView_Customer";
            this.dataGridView_Customer.RowHeadersWidth = 51;
            this.dataGridView_Customer.RowTemplate.Height = 24;
            this.dataGridView_Customer.Size = new System.Drawing.Size(809, 320);
            this.dataGridView_Customer.TabIndex = 69;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.dataGridView_Customer);
            this.Controls.Add(this.btn_order_download);
            this.Controls.Add(this.btn_car_download);
            this.Controls.Add(this.btn_car_part_download);
            this.Controls.Add(this.btn_cus_download);
            this.Controls.Add(this.btn_order_view);
            this.Controls.Add(this.btn_car_view);
            this.Controls.Add(this.btn_car_part_view);
            this.Controls.Add(this.btn_cus_view);
            this.Controls.Add(this.txt_Order_ID);
            this.Controls.Add(this.txt_Car_Part_ID);
            this.Controls.Add(this.txt_Car_ID);
            this.Controls.Add(this.txt_Customer_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Car_Part_ID);
            this.Controls.Add(this.lbl_Car_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Controls.Add(this.dataGridView_Order);
            this.Controls.Add(this.dataGridView_CarPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_Car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_Car;
        private System.Windows.Forms.DataGridView dataGridView_CarPart;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Label lbl_Car_ID;
        private System.Windows.Forms.Label lbl_Car_Part_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Customer_ID;
        private System.Windows.Forms.TextBox txt_Car_ID;
        private System.Windows.Forms.TextBox txt_Car_Part_ID;
        private System.Windows.Forms.TextBox txt_Order_ID;
        private System.Windows.Forms.Button btn_cus_view;
        private System.Windows.Forms.Button btn_car_part_view;
        private System.Windows.Forms.Button btn_car_view;
        private System.Windows.Forms.Button btn_order_view;
        private System.Windows.Forms.Button btn_cus_download;
        private System.Windows.Forms.Button btn_car_part_download;
        private System.Windows.Forms.Button btn_car_download;
        private System.Windows.Forms.Button btn_order_download;
        private System.Windows.Forms.DataGridView dataGridView_Customer;
    }
}