namespace ABC_Car_Traders_
{
    partial class CustomerDashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.btn_orders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cars = new System.Windows.Forms.Button();
            this.btnparts = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 89);
            this.panel2.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(110)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(1950, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 89);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_customerName);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_cars);
            this.panel1.Controls.Add(this.btnparts);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 926);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::ABC_Car_Traders_.Properties.Resources.icons8_shutdown_30;
            this.pictureBox2.Image = global::ABC_Car_Traders_.Properties.Resources.icons8_power_48;
            this.pictureBox2.Location = new System.Drawing.Point(21, 865);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.ForeColor = System.Drawing.Color.Black;
            this.lbl_customerName.Location = new System.Drawing.Point(17, 235);
            this.lbl_customerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(263, 28);
            this.lbl_customerName.TabIndex = 6;
            this.lbl_customerName.Tag = "";
            this.lbl_customerName.Text = "CUSTOMER";
            this.lbl_customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_customerName.Click += new System.EventHandler(this.lbl_customerName_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orders.FlatAppearance.BorderSize = 2;
            this.btn_orders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.Location = new System.Drawing.Point(11, 499);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(278, 49);
            this.btn_orders.TabIndex = 5;
            this.btn_orders.Text = "My Orders";
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cars.FlatAppearance.BorderSize = 2;
            this.btn_cars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cars.Location = new System.Drawing.Point(11, 365);
            this.btn_cars.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(278, 49);
            this.btn_cars.TabIndex = 0;
            this.btn_cars.Text = "Cars";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btnparts
            // 
            this.btnparts.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnparts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparts.FlatAppearance.BorderSize = 2;
            this.btnparts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnparts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnparts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparts.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparts.ForeColor = System.Drawing.Color.Transparent;
            this.btnparts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnparts.Location = new System.Drawing.Point(12, 432);
            this.btnparts.Margin = new System.Windows.Forms.Padding(4);
            this.btnparts.Name = "btnparts";
            this.btnparts.Size = new System.Drawing.Size(278, 49);
            this.btnparts.TabIndex = 1;
            this.btnparts.Text = "Car Parts";
            this.btnparts.UseVisualStyleBackColor = false;
            this.btnparts.Click += new System.EventHandler(this.btnparts_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(297, 89);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1645, 926);
            this.mainpanel.TabIndex = 4;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // CustomerDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1015);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashForm";
            this.Text = "CustomerDashForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btnparts;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}