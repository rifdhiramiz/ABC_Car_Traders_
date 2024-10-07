namespace ABC_Car_Traders_
{
    partial class LoginForm
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
            this.linklbl_signup = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.chkbox_customer = new System.Windows.Forms.CheckBox();
            this.chkbox_admin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbl_signup
            // 
            this.linklbl_signup.AutoSize = true;
            this.linklbl_signup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_signup.Location = new System.Drawing.Point(428, 625);
            this.linklbl_signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbl_signup.Name = "linklbl_signup";
            this.linklbl_signup.Size = new System.Drawing.Size(82, 24);
            this.linklbl_signup.TabIndex = 18;
            this.linklbl_signup.TabStop = true;
            this.linklbl_signup.Text = "Sign Up!";
            this.linklbl_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_signup_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 591);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Don\'t have an account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN ACCOUNT";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_pw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Location = new System.Drawing.Point(251, 298);
            this.lbl_pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(101, 24);
            this.lbl_pw.TabIndex = 15;
            this.lbl_pw.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(251, 226);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 24);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "E-mail:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(255, 494);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(435, 52);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(255, 255);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(435, 22);
            this.txt_email.TabIndex = 11;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(255, 325);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(435, 22);
            this.txt_pw.TabIndex = 12;
            this.txt_pw.UseSystemPasswordChar = true;
            // 
            // chkbox_customer
            // 
            this.chkbox_customer.AutoSize = true;
            this.chkbox_customer.BackColor = System.Drawing.Color.AliceBlue;
            this.chkbox_customer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_customer.Location = new System.Drawing.Point(485, 390);
            this.chkbox_customer.Name = "chkbox_customer";
            this.chkbox_customer.Size = new System.Drawing.Size(117, 28);
            this.chkbox_customer.TabIndex = 22;
            this.chkbox_customer.Text = "Customer";
            this.chkbox_customer.UseVisualStyleBackColor = false;
            // 
            // chkbox_admin
            // 
            this.chkbox_admin.AutoSize = true;
            this.chkbox_admin.BackColor = System.Drawing.Color.AliceBlue;
            this.chkbox_admin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_admin.Location = new System.Drawing.Point(307, 390);
            this.chkbox_admin.Name = "chkbox_admin";
            this.chkbox_admin.Size = new System.Drawing.Size(88, 28);
            this.chkbox_admin.TabIndex = 21;
            this.chkbox_admin.Text = "Admin";
            this.chkbox_admin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.chkbox_customer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkbox_admin);
            this.panel1.Controls.Add(this.txt_pw);
            this.panel1.Controls.Add(this.linklbl_signup);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_pw);
            this.panel1.Location = new System.Drawing.Point(624, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 746);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1942, 971);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklbl_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.CheckBox chkbox_customer;
        private System.Windows.Forms.CheckBox chkbox_admin;
        private System.Windows.Forms.Panel panel1;
    }
}