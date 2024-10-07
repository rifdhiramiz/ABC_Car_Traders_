namespace ABC_Car_Traders_
{
    partial class CustomerUpdateForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_customer_delete = new System.Windows.Forms.Button();
            this.btn_customer_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customer_add = new System.Windows.Forms.TextBox();
            this.txt_customer_nic = new System.Windows.Forms.TextBox();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.datagridcustomers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_customer_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_customer_contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_customer_password = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(652, 96);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(359, 22);
            this.txt_search.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Customer ID:";
            // 
            // btn_customer_delete
            // 
            this.btn_customer_delete.BackColor = System.Drawing.Color.Red;
            this.btn_customer_delete.FlatAppearance.BorderSize = 0;
            this.btn_customer_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_customer_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_customer_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_delete.ForeColor = System.Drawing.Color.White;
            this.btn_customer_delete.Location = new System.Drawing.Point(1225, 644);
            this.btn_customer_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customer_delete.Name = "btn_customer_delete";
            this.btn_customer_delete.Size = new System.Drawing.Size(133, 52);
            this.btn_customer_delete.TabIndex = 55;
            this.btn_customer_delete.Text = "Delete";
            this.btn_customer_delete.UseVisualStyleBackColor = false;
            this.btn_customer_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_customer_update
            // 
            this.btn_customer_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_customer_update.FlatAppearance.BorderSize = 0;
            this.btn_customer_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_customer_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_customer_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_update.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_update.ForeColor = System.Drawing.Color.White;
            this.btn_customer_update.Location = new System.Drawing.Point(830, 644);
            this.btn_customer_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customer_update.Name = "btn_customer_update";
            this.btn_customer_update.Size = new System.Drawing.Size(133, 52);
            this.btn_customer_update.TabIndex = 54;
            this.btn_customer_update.Text = "Update";
            this.btn_customer_update.UseVisualStyleBackColor = false;
            this.btn_customer_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "NIC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name:";
            // 
            // txt_customer_add
            // 
            this.txt_customer_add.Location = new System.Drawing.Point(225, 433);
            this.txt_customer_add.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_add.Multiline = true;
            this.txt_customer_add.Name = "txt_customer_add";
            this.txt_customer_add.Size = new System.Drawing.Size(252, 126);
            this.txt_customer_add.TabIndex = 50;
            // 
            // txt_customer_nic
            // 
            this.txt_customer_nic.Location = new System.Drawing.Point(225, 356);
            this.txt_customer_nic.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_nic.Name = "txt_customer_nic";
            this.txt_customer_nic.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_nic.TabIndex = 49;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Location = new System.Drawing.Point(225, 239);
            this.txt_customer_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_name.TabIndex = 48;
            // 
            // datagridcustomers
            // 
            this.datagridcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcustomers.Location = new System.Drawing.Point(508, 195);
            this.datagridcustomers.Margin = new System.Windows.Forms.Padding(4);
            this.datagridcustomers.MultiSelect = false;
            this.datagridcustomers.Name = "datagridcustomers";
            this.datagridcustomers.RowHeadersWidth = 51;
            this.datagridcustomers.Size = new System.Drawing.Size(1195, 404);
            this.datagridcustomers.TabIndex = 46;
            this.datagridcustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcustomers_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "CUSTOMER DETAILS";
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.Location = new System.Drawing.Point(225, 200);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_id.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Email Address:";
            // 
            // txt_customer_email
            // 
            this.txt_customer_email.Location = new System.Drawing.Point(225, 278);
            this.txt_customer_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_email.Name = "txt_customer_email";
            this.txt_customer_email.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_email.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Contact No. :";
            // 
            // txt_customer_contact
            // 
            this.txt_customer_contact.Location = new System.Drawing.Point(226, 393);
            this.txt_customer_contact.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_contact.Name = "txt_customer_contact";
            this.txt_customer_contact.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_contact.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 70;
            this.label6.Text = "Password:";
            // 
            // txt_customer_password
            // 
            this.txt_customer_password.Location = new System.Drawing.Point(225, 318);
            this.txt_customer_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_password.Name = "txt_customer_password";
            this.txt_customer_password.Size = new System.Drawing.Size(252, 22);
            this.txt_customer_password.TabIndex = 69;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1027, 644);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 52);
            this.btn_clear.TabIndex = 71;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1035, 90);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(139, 36);
            this.btn_search.TabIndex = 61;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 23);
            this.label7.TabIndex = 149;
            this.label7.Text = "Enter Customer Name:";
            // 
            // CustomerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 807);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_customer_password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_customer_contact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_customer_email);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_customer_delete);
            this.Controls.Add(this.btn_customer_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_customer_add);
            this.Controls.Add(this.txt_customer_nic);
            this.Controls.Add(this.txt_customer_name);
            this.Controls.Add(this.datagridcustomers);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUpdateForm";
            this.Text = "CustomerUpdateForm";
            this.Load += new System.EventHandler(this.CustomerUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_customer_delete;
        private System.Windows.Forms.Button btn_customer_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer_add;
        private System.Windows.Forms.TextBox txt_customer_nic;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.DataGridView datagridcustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_customer_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_customer_contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_customer_password;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
    }
}