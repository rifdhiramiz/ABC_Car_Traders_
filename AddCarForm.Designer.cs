﻿namespace ABC_Car_Traders_
{
    partial class AddCarForm
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
            this.btn_image = new System.Windows.Forms.Button();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_car = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_image
            // 
            this.btn_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.Image = global::ABC_Car_Traders_.Properties.Resources.icons8_select_24;
            this.btn_image.Location = new System.Drawing.Point(1142, 506);
            this.btn_image.Margin = new System.Windows.Forms.Padding(4);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(41, 42);
            this.btn_image.TabIndex = 35;
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(847, 514);
            this.txt_image.Margin = new System.Windows.Forms.Padding(4);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(273, 22);
            this.txt_image.TabIndex = 33;
            this.txt_image.TextChanged += new System.EventHandler(this.txt_image_TextChanged);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(251, 408);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(305, 131);
            this.txt_description.TabIndex = 32;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_desc_TextChanged);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(251, 356);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(305, 22);
            this.txt_stock.TabIndex = 31;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(251, 306);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(305, 22);
            this.txt_price.TabIndex = 30;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(251, 259);
            this.txt_year.Margin = new System.Windows.Forms.Padding(4);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(305, 22);
            this.txt_year.TabIndex = 29;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(251, 209);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(305, 22);
            this.txt_model.TabIndex = 28;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(251, 157);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(305, 22);
            this.txt_Name.TabIndex = 27;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(117)))));
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(581, 662);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(285, 58);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(787, 518);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Car Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Car Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ADD CAR";
            // 
            // pic_car
            // 
            this.pic_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_car.Location = new System.Drawing.Point(705, 154);
            this.pic_car.Margin = new System.Windows.Forms.Padding(4);
            this.pic_car.Name = "pic_car";
            this.pic_car.Size = new System.Drawing.Size(581, 318);
            this.pic_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_car.TabIndex = 34;
            this.pic_car.TabStop = false;
            this.pic_car.Click += new System.EventHandler(this.pic_car_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 807);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.pic_car);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.PictureBox pic_car;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}