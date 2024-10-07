namespace ABC_Car_Traders_
{
    partial class UpdatePartForm
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
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Car_Part_delete = new System.Windows.Forms.Button();
            this.btn_Car_Part_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.datagridcarparts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.btn_part_clear = new System.Windows.Forms.Button();
            this.txt_Car_Part_ID = new System.Windows.Forms.Label();
            this.btn_image = new System.Windows.Forms.Button();
            this.pic_carpart = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carpart)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(512, 120);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(299, 22);
            this.txt_search.TabIndex = 44;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(197, 345);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(403, 22);
            this.txt_stock.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Stock:";
            // 
            // btn_Car_Part_delete
            // 
            this.btn_Car_Part_delete.BackColor = System.Drawing.Color.Red;
            this.btn_Car_Part_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Car_Part_delete.FlatAppearance.BorderSize = 0;
            this.btn_Car_Part_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Car_Part_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Car_Part_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car_Part_delete.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Car_Part_delete.ForeColor = System.Drawing.Color.White;
            this.btn_Car_Part_delete.Location = new System.Drawing.Point(1403, 657);
            this.btn_Car_Part_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Car_Part_delete.Name = "btn_Car_Part_delete";
            this.btn_Car_Part_delete.Size = new System.Drawing.Size(133, 52);
            this.btn_Car_Part_delete.TabIndex = 41;
            this.btn_Car_Part_delete.Text = "Delete";
            this.btn_Car_Part_delete.UseVisualStyleBackColor = false;
            this.btn_Car_Part_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Car_Part_update
            // 
            this.btn_Car_Part_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Car_Part_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Car_Part_update.FlatAppearance.BorderSize = 0;
            this.btn_Car_Part_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Car_Part_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Car_Part_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car_Part_update.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Car_Part_update.ForeColor = System.Drawing.Color.White;
            this.btn_Car_Part_update.Location = new System.Drawing.Point(971, 657);
            this.btn_Car_Part_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Car_Part_update.Name = "btn_Car_Part_update";
            this.btn_Car_Part_update.Size = new System.Drawing.Size(133, 52);
            this.btn_Car_Part_update.TabIndex = 40;
            this.btn_Car_Part_update.Text = "Update";
            this.btn_Car_Part_update.UseVisualStyleBackColor = false;
            this.btn_Car_Part_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Part Name:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(197, 387);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(403, 92);
            this.txt_desc.TabIndex = 36;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(197, 305);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(403, 22);
            this.txt_price.TabIndex = 35;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(197, 261);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(403, 22);
            this.txt_name.TabIndex = 34;
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
            this.datagridcarparts.Location = new System.Drawing.Point(657, 214);
            this.datagridcarparts.Margin = new System.Windows.Forms.Padding(4);
            this.datagridcarparts.MultiSelect = false;
            this.datagridcarparts.Name = "datagridcarparts";
            this.datagridcarparts.RowHeadersWidth = 51;
            this.datagridcarparts.Size = new System.Drawing.Size(1015, 404);
            this.datagridcarparts.TabIndex = 32;
            this.datagridcarparts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcarparts_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "MANAGE CAR PART DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Car Part ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 499);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Image:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(735, 657);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 52);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(197, 690);
            this.txt_image.Margin = new System.Windows.Forms.Padding(4);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(285, 22);
            this.txt_image.TabIndex = 52;
            // 
            // btn_part_clear
            // 
            this.btn_part_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_part_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_part_clear.FlatAppearance.BorderSize = 0;
            this.btn_part_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_part_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_part_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_part_clear.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_part_clear.ForeColor = System.Drawing.Color.White;
            this.btn_part_clear.Location = new System.Drawing.Point(1176, 657);
            this.btn_part_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_part_clear.Name = "btn_part_clear";
            this.btn_part_clear.Size = new System.Drawing.Size(133, 52);
            this.btn_part_clear.TabIndex = 54;
            this.btn_part_clear.Text = "Clear";
            this.btn_part_clear.UseVisualStyleBackColor = false;
            this.btn_part_clear.Click += new System.EventHandler(this.btn_part_clear_Click);
            // 
            // txt_Car_Part_ID
            // 
            this.txt_Car_Part_ID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Car_Part_ID.Location = new System.Drawing.Point(171, 220);
            this.txt_Car_Part_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Car_Part_ID.Name = "txt_Car_Part_ID";
            this.txt_Car_Part_ID.Size = new System.Drawing.Size(405, 21);
            this.txt_Car_Part_ID.TabIndex = 147;
            this.txt_Car_Part_ID.Click += new System.EventHandler(this.txt_Car_Part_ID_Click);
            // 
            // btn_image
            // 
            this.btn_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.Location = new System.Drawing.Point(490, 682);
            this.btn_image.Margin = new System.Windows.Forms.Padding(4);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(110, 42);
            this.btn_image.TabIndex = 53;
            this.btn_image.Text = "Select";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // pic_carpart
            // 
            this.pic_carpart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_carpart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_carpart.Location = new System.Drawing.Point(197, 505);
            this.pic_carpart.Margin = new System.Windows.Forms.Padding(4);
            this.pic_carpart.Name = "pic_carpart";
            this.pic_carpart.Size = new System.Drawing.Size(403, 158);
            this.pic_carpart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_carpart.TabIndex = 48;
            this.pic_carpart.TabStop = false;
            this.pic_carpart.Click += new System.EventHandler(this.pic_carpart_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(834, 109);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 45);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 148;
            this.label6.Text = "Car Part ID:";
            // 
            // UpdatePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 807);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Car_Part_ID);
            this.Controls.Add(this.btn_part_clear);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pic_carpart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Car_Part_delete);
            this.Controls.Add(this.btn_Car_Part_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.datagridcarparts);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePartForm";
            this.Text = "UpdatePartForm";
            this.Load += new System.EventHandler(this.UpdatePartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carpart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Car_Part_delete;
        private System.Windows.Forms.Button btn_Car_Part_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView datagridcarparts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pic_carpart;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Button btn_part_clear;
        private System.Windows.Forms.Label txt_Car_Part_ID;
        private System.Windows.Forms.Label label6;
    }
}