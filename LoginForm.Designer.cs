
namespace ChattBank
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LoginAdmin = new System.Windows.Forms.Button();
            this.tbx_AdminPw = new System.Windows.Forms.TextBox();
            this.tbx_Admin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbx_Customer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbx_Pw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(170, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 115);
            this.label5.TabIndex = 19;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(427, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 115);
            this.label4.TabIndex = 18;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Admin Password:";
            // 
            // btn_LoginAdmin
            // 
            this.btn_LoginAdmin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_LoginAdmin.FlatAppearance.BorderSize = 0;
            this.btn_LoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LoginAdmin.Location = new System.Drawing.Point(614, 455);
            this.btn_LoginAdmin.Name = "btn_LoginAdmin";
            this.btn_LoginAdmin.Size = new System.Drawing.Size(188, 56);
            this.btn_LoginAdmin.TabIndex = 16;
            this.btn_LoginAdmin.Text = "Admin Login";
            this.btn_LoginAdmin.UseVisualStyleBackColor = false;
            this.btn_LoginAdmin.Click += new System.EventHandler(this.btn_LoginAdmin_Click);
            // 
            // tbx_AdminPw
            // 
            this.tbx_AdminPw.Location = new System.Drawing.Point(547, 249);
            this.tbx_AdminPw.Name = "tbx_AdminPw";
            this.tbx_AdminPw.Size = new System.Drawing.Size(100, 22);
            this.tbx_AdminPw.TabIndex = 15;
            // 
            // tbx_Admin
            // 
            this.tbx_Admin.Location = new System.Drawing.Point(548, 193);
            this.tbx_Admin.Name = "tbx_Admin";
            this.tbx_Admin.Size = new System.Drawing.Size(100, 22);
            this.tbx_Admin.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Admin:";
            // 
            // nbx_Customer
            // 
            this.nbx_Customer.Location = new System.Drawing.Point(290, 194);
            this.nbx_Customer.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbx_Customer.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nbx_Customer.Name = "nbx_Customer";
            this.nbx_Customer.Size = new System.Drawing.Size(120, 22);
            this.nbx_Customer.TabIndex = 12;
            this.nbx_Customer.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type in your ID: ";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(-1, 455);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(618, 59);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Student Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tbx_Pw
            // 
            this.tbx_Pw.Location = new System.Drawing.Point(290, 249);
            this.tbx_Pw.Name = "tbx_Pw";
            this.tbx_Pw.Size = new System.Drawing.Size(120, 22);
            this.tbx_Pw.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChattBank.Properties.Resources.logo_thrive;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_Pw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_LoginAdmin);
            this.Controls.Add(this.tbx_AdminPw);
            this.Controls.Add(this.tbx_Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbx_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LoginAdmin;
        private System.Windows.Forms.TextBox tbx_AdminPw;
        private System.Windows.Forms.TextBox tbx_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbx_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tbx_Pw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}