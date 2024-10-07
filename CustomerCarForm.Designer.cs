namespace ABC_Car_Traders_
{
    partial class CustomerCarForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.datagridcar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customer_car_name = new System.Windows.Forms.TextBox();
            this.txt_customer_car_desc = new System.Windows.Forms.TextBox();
            this.txt_customer_car_year = new System.Windows.Forms.TextBox();
            this.txt_customer_car_price = new System.Windows.Forms.TextBox();
            this.txt_customer_car_model = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pic_car = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_customer_car_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(658, 108);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(296, 22);
            this.txt_search.TabIndex = 32;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Price:";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(1189, 600);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(133, 52);
            this.btn_order.TabIndex = 24;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Model:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(83, 207);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 23);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Name:";
            // 
            // datagridcar
            // 
            this.datagridcar.AllowUserToAddRows = false;
            this.datagridcar.AllowUserToDeleteRows = false;
            this.datagridcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcar.GridColor = System.Drawing.Color.White;
            this.datagridcar.Location = new System.Drawing.Point(608, 162);
            this.datagridcar.Margin = new System.Windows.Forms.Padding(4);
            this.datagridcar.MultiSelect = false;
            this.datagridcar.Name = "datagridcar";
            this.datagridcar.ReadOnly = true;
            this.datagridcar.RowHeadersWidth = 51;
            this.datagridcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridcar.Size = new System.Drawing.Size(944, 389);
            this.datagridcar.TabIndex = 18;
            this.datagridcar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "CAR DETAILS";
            // 
            // txt_customer_car_name
            // 
            this.txt_customer_car_name.Location = new System.Drawing.Point(215, 202);
            this.txt_customer_car_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_name.Name = "txt_customer_car_name";
            this.txt_customer_car_name.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_name.TabIndex = 34;
            // 
            // txt_customer_car_desc
            // 
            this.txt_customer_car_desc.Location = new System.Drawing.Point(215, 362);
            this.txt_customer_car_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_desc.Name = "txt_customer_car_desc";
            this.txt_customer_car_desc.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_desc.TabIndex = 35;
            this.txt_customer_car_desc.TextChanged += new System.EventHandler(this.txt_customer_car_desc_TextChanged);
            // 
            // txt_customer_car_year
            // 
            this.txt_customer_car_year.Location = new System.Drawing.Point(215, 280);
            this.txt_customer_car_year.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_year.Name = "txt_customer_car_year";
            this.txt_customer_car_year.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_year.TabIndex = 36;
            // 
            // txt_customer_car_price
            // 
            this.txt_customer_car_price.Location = new System.Drawing.Point(215, 321);
            this.txt_customer_car_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_price.Name = "txt_customer_car_price";
            this.txt_customer_car_price.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_price.TabIndex = 37;
            this.txt_customer_car_price.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_customer_car_model
            // 
            this.txt_customer_car_model.Location = new System.Drawing.Point(215, 239);
            this.txt_customer_car_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_model.Name = "txt_customer_car_model";
            this.txt_customer_car_model.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_model.TabIndex = 38;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(988, 600);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 52);
            this.btn_clear.TabIndex = 39;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(973, 97);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(148, 45);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pic_car
            // 
            this.pic_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_car.Location = new System.Drawing.Point(87, 435);
            this.pic_car.Margin = new System.Windows.Forms.Padding(4);
            this.pic_car.Name = "pic_car";
            this.pic_car.Size = new System.Drawing.Size(466, 263);
            this.pic_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_car.TabIndex = 23;
            this.pic_car.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(514, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 21);
            this.label12.TabIndex = 161;
            this.label12.Text = "Enter Car ID:";
            // 
            // txt_customer_car_ID
            // 
            this.txt_customer_car_ID.Location = new System.Drawing.Point(215, 163);
            this.txt_customer_car_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_car_ID.Name = "txt_customer_car_ID";
            this.txt_customer_car_ID.Size = new System.Drawing.Size(338, 22);
            this.txt_customer_car_ID.TabIndex = 163;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 162;
            this.label6.Text = "Car ID:";
            // 
            // CustomerCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 711);
            this.Controls.Add(this.txt_customer_car_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_customer_car_model);
            this.Controls.Add(this.txt_customer_car_price);
            this.Controls.Add(this.txt_customer_car_year);
            this.Controls.Add(this.txt_customer_car_desc);
            this.Controls.Add(this.txt_customer_car_name);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.pic_car);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.datagridcar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerCarForm";
            this.Text = "CustomerCarForm";
            this.Load += new System.EventHandler(this.CustomerCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.PictureBox pic_car;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView datagridcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer_car_name;
        private System.Windows.Forms.TextBox txt_customer_car_desc;
        private System.Windows.Forms.TextBox txt_customer_car_year;
        private System.Windows.Forms.TextBox txt_customer_car_price;
        private System.Windows.Forms.TextBox txt_customer_car_model;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_customer_car_ID;
        private System.Windows.Forms.Label label6;
    }
}