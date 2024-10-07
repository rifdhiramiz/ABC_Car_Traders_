namespace ABC_Car_Traders_
{
    partial class CustomerPartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridcarparts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cus_car_part_name = new System.Windows.Forms.TextBox();
            this.txt_cus_part_quantity = new System.Windows.Forms.TextBox();
            this.txt_cus_car_part_price = new System.Windows.Forms.TextBox();
            this.txt_cus_part_desc = new System.Windows.Forms.TextBox();
            this.btn_order_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pic_part = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cus_car_part_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_part)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(711, 104);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(318, 22);
            this.txt_search.TabIndex = 37;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(1154, 640);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(133, 52);
            this.btn_order.TabIndex = 31;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Available Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Car Part Name:";
            // 
            // datagridcarparts
            // 
            this.datagridcarparts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcarparts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcarparts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridcarparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcarparts.GridColor = System.Drawing.Color.White;
            this.datagridcarparts.Location = new System.Drawing.Point(608, 201);
            this.datagridcarparts.Margin = new System.Windows.Forms.Padding(4);
            this.datagridcarparts.Name = "datagridcarparts";
            this.datagridcarparts.RowHeadersWidth = 51;
            this.datagridcarparts.Size = new System.Drawing.Size(1052, 389);
            this.datagridcarparts.TabIndex = 25;
            this.datagridcarparts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcarparts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "CAR PART DETAILS";
            // 
            // txt_cus_car_part_name
            // 
            this.txt_cus_car_part_name.Location = new System.Drawing.Point(250, 239);
            this.txt_cus_car_part_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cus_car_part_name.Name = "txt_cus_car_part_name";
            this.txt_cus_car_part_name.Size = new System.Drawing.Size(302, 22);
            this.txt_cus_car_part_name.TabIndex = 46;
            // 
            // txt_cus_part_quantity
            // 
            this.txt_cus_part_quantity.Location = new System.Drawing.Point(250, 326);
            this.txt_cus_part_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cus_part_quantity.Name = "txt_cus_part_quantity";
            this.txt_cus_part_quantity.Size = new System.Drawing.Size(302, 22);
            this.txt_cus_part_quantity.TabIndex = 45;
            // 
            // txt_cus_car_part_price
            // 
            this.txt_cus_car_part_price.Location = new System.Drawing.Point(250, 283);
            this.txt_cus_car_part_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cus_car_part_price.Name = "txt_cus_car_part_price";
            this.txt_cus_car_part_price.Size = new System.Drawing.Size(302, 22);
            this.txt_cus_car_part_price.TabIndex = 44;
            // 
            // txt_cus_part_desc
            // 
            this.txt_cus_part_desc.Location = new System.Drawing.Point(250, 366);
            this.txt_cus_part_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cus_part_desc.Name = "txt_cus_part_desc";
            this.txt_cus_part_desc.Size = new System.Drawing.Size(302, 22);
            this.txt_cus_part_desc.TabIndex = 43;
            // 
            // btn_order_clear
            // 
            this.btn_order_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_order_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order_clear.FlatAppearance.BorderSize = 0;
            this.btn_order_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_order_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_order_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_clear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_clear.ForeColor = System.Drawing.Color.White;
            this.btn_order_clear.Location = new System.Drawing.Point(943, 640);
            this.btn_order_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order_clear.Name = "btn_order_clear";
            this.btn_order_clear.Size = new System.Drawing.Size(133, 52);
            this.btn_order_clear.TabIndex = 47;
            this.btn_order_clear.Text = "Clear";
            this.btn_order_clear.UseVisualStyleBackColor = false;
            this.btn_order_clear.Click += new System.EventHandler(this.btn_order_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1057, 93);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(193, 45);
            this.btn_search.TabIndex = 38;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pic_part
            // 
            this.pic_part.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_part.Location = new System.Drawing.Point(54, 429);
            this.pic_part.Margin = new System.Windows.Forms.Padding(4);
            this.pic_part.Name = "pic_part";
            this.pic_part.Size = new System.Drawing.Size(498, 263);
            this.pic_part.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_part.TabIndex = 30;
            this.pic_part.TabStop = false;
            this.pic_part.Click += new System.EventHandler(this.pic_part_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(488, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 23);
            this.label12.TabIndex = 162;
            this.label12.Text = "Enter Car Part ID:";
            // 
            // txt_cus_car_part_ID
            // 
            this.txt_cus_car_part_ID.Location = new System.Drawing.Point(250, 200);
            this.txt_cus_car_part_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cus_car_part_ID.Name = "txt_cus_car_part_ID";
            this.txt_cus_car_part_ID.Size = new System.Drawing.Size(302, 22);
            this.txt_cus_car_part_ID.TabIndex = 164;
            this.txt_cus_car_part_ID.TextChanged += new System.EventHandler(this.txt_cus_car_part_ID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 163;
            this.label6.Text = "Car Part ID";
            // 
            // CustomerPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 798);
            this.Controls.Add(this.txt_cus_car_part_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_order_clear);
            this.Controls.Add(this.txt_cus_car_part_name);
            this.Controls.Add(this.txt_cus_part_quantity);
            this.Controls.Add(this.txt_cus_car_part_price);
            this.Controls.Add(this.txt_cus_part_desc);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.pic_part);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridcarparts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPartForm";
            this.Text = "CustomerPartForm";
            this.Load += new System.EventHandler(this.CustomerPartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.PictureBox pic_part;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridcarparts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cus_car_part_name;
        private System.Windows.Forms.TextBox txt_cus_part_quantity;
        private System.Windows.Forms.TextBox txt_cus_car_part_price;
        private System.Windows.Forms.TextBox txt_cus_part_desc;
        private System.Windows.Forms.Button btn_order_clear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cus_car_part_ID;
        private System.Windows.Forms.Label label6;
    }
}