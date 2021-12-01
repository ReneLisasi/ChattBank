
namespace ChattBank
{
    partial class AdminHome
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
            this.nbx_AdminZip = new System.Windows.Forms.NumericUpDown();
            this.nbx_Cid = new System.Windows.Forms.NumericUpDown();
            this.btn_AdminDelete = new System.Windows.Forms.Button();
            this.btn_AdminAdd = new System.Windows.Forms.Button();
            this.tbx_AdminEmail = new System.Windows.Forms.TextBox();
            this.tbx_AdminLname = new System.Windows.Forms.TextBox();
            this.tbx_AdminFname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_AdminState = new System.Windows.Forms.TextBox();
            this.tbx_AdminCity = new System.Windows.Forms.TextBox();
            this.tbx_AdminStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btn_AdminUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_AdminSelect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amenu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ResetPw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_AdminZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Cid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbx_AdminZip
            // 
            this.nbx_AdminZip.Location = new System.Drawing.Point(212, 239);
            this.nbx_AdminZip.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbx_AdminZip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbx_AdminZip.Name = "nbx_AdminZip";
            this.nbx_AdminZip.Size = new System.Drawing.Size(100, 23);
            this.nbx_AdminZip.TabIndex = 81;
            this.nbx_AdminZip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbx_Cid
            // 
            this.nbx_Cid.Location = new System.Drawing.Point(212, 55);
            this.nbx_Cid.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nbx_Cid.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nbx_Cid.Name = "nbx_Cid";
            this.nbx_Cid.Size = new System.Drawing.Size(100, 23);
            this.nbx_Cid.TabIndex = 80;
            this.nbx_Cid.Value = new decimal(new int[] {
            3001,
            0,
            0,
            0});
            // 
            // btn_AdminDelete
            // 
            this.btn_AdminDelete.BackColor = System.Drawing.Color.Black;
            this.btn_AdminDelete.FlatAppearance.BorderSize = 0;
            this.btn_AdminDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AdminDelete.Location = new System.Drawing.Point(671, 401);
            this.btn_AdminDelete.Name = "btn_AdminDelete";
            this.btn_AdminDelete.Size = new System.Drawing.Size(129, 54);
            this.btn_AdminDelete.TabIndex = 79;
            this.btn_AdminDelete.Text = "Delete";
            this.btn_AdminDelete.UseVisualStyleBackColor = false;
            this.btn_AdminDelete.Click += new System.EventHandler(this.btn_AdminDelete_Click);
            // 
            // btn_AdminAdd
            // 
            this.btn_AdminAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AdminAdd.FlatAppearance.BorderSize = 0;
            this.btn_AdminAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminAdd.Location = new System.Drawing.Point(0, 401);
            this.btn_AdminAdd.Name = "btn_AdminAdd";
            this.btn_AdminAdd.Size = new System.Drawing.Size(193, 54);
            this.btn_AdminAdd.TabIndex = 78;
            this.btn_AdminAdd.Text = "Add";
            this.btn_AdminAdd.UseVisualStyleBackColor = false;
            this.btn_AdminAdd.Click += new System.EventHandler(this.btn_AdminAdd_Click);
            // 
            // tbx_AdminEmail
            // 
            this.tbx_AdminEmail.Location = new System.Drawing.Point(212, 268);
            this.tbx_AdminEmail.Name = "tbx_AdminEmail";
            this.tbx_AdminEmail.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminEmail.TabIndex = 77;
            // 
            // tbx_AdminLname
            // 
            this.tbx_AdminLname.Location = new System.Drawing.Point(212, 115);
            this.tbx_AdminLname.Name = "tbx_AdminLname";
            this.tbx_AdminLname.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminLname.TabIndex = 76;
            // 
            // tbx_AdminFname
            // 
            this.tbx_AdminFname.Location = new System.Drawing.Point(212, 83);
            this.tbx_AdminFname.Name = "tbx_AdminFname";
            this.tbx_AdminFname.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminFname.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label11.Location = new System.Drawing.Point(9, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 130);
            this.label11.TabIndex = 73;
            this.label11.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(313, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(498, 101);
            this.label10.TabIndex = 72;
            this.label10.Text = "CUSTOMER";
            // 
            // tbx_AdminState
            // 
            this.tbx_AdminState.Location = new System.Drawing.Point(212, 205);
            this.tbx_AdminState.Name = "tbx_AdminState";
            this.tbx_AdminState.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminState.TabIndex = 71;
            // 
            // tbx_AdminCity
            // 
            this.tbx_AdminCity.Location = new System.Drawing.Point(212, 174);
            this.tbx_AdminCity.Name = "tbx_AdminCity";
            this.tbx_AdminCity.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminCity.TabIndex = 70;
            // 
            // tbx_AdminStreet
            // 
            this.tbx_AdminStreet.Location = new System.Drawing.Point(212, 144);
            this.tbx_AdminStreet.Name = "tbx_AdminStreet";
            this.tbx_AdminStreet.Size = new System.Drawing.Size(100, 23);
            this.tbx_AdminStreet.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(9, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 130);
            this.label9.TabIndex = 68;
            this.label9.Text = "|";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "Zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "First Name";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(84, 55);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(18, 15);
            this.label45.TabIndex = 59;
            this.label45.Text = "ID";
            // 
            // btn_AdminUpdate
            // 
            this.btn_AdminUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_AdminUpdate.FlatAppearance.BorderSize = 0;
            this.btn_AdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AdminUpdate.Location = new System.Drawing.Point(187, 401);
            this.btn_AdminUpdate.Name = "btn_AdminUpdate";
            this.btn_AdminUpdate.Size = new System.Drawing.Size(485, 54);
            this.btn_AdminUpdate.TabIndex = 58;
            this.btn_AdminUpdate.Text = "Update";
            this.btn_AdminUpdate.UseVisualStyleBackColor = false;
            this.btn_AdminUpdate.Click += new System.EventHandler(this.btn_AdminUpdate_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(9, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 130);
            this.label12.TabIndex = 74;
            this.label12.Text = "|";
            // 
            // btn_AdminSelect
            // 
            this.btn_AdminSelect.BackColor = System.Drawing.Color.Gold;
            this.btn_AdminSelect.FlatAppearance.BorderSize = 0;
            this.btn_AdminSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminSelect.Location = new System.Drawing.Point(0, 353);
            this.btn_AdminSelect.Name = "btn_AdminSelect";
            this.btn_AdminSelect.Size = new System.Drawing.Size(800, 54);
            this.btn_AdminSelect.TabIndex = 83;
            this.btn_AdminSelect.Text = "Select";
            this.btn_AdminSelect.UseVisualStyleBackColor = false;
            this.btn_AdminSelect.Click += new System.EventHandler(this.btn_AdminSelect_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(313, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(475, 101);
            this.label13.TabIndex = 84;
            this.label13.Text = "MANAGER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amenu_Logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // amenu_Logout
            // 
            this.amenu_Logout.Name = "amenu_Logout";
            this.amenu_Logout.Size = new System.Drawing.Size(57, 20);
            this.amenu_Logout.Text = "Logout";
            this.amenu_Logout.Click += new System.EventHandler(this.amenu_Logout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 86;
            this.label8.Text = "Customer Password";
            // 
            // btn_ResetPw
            // 
            this.btn_ResetPw.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_ResetPw.FlatAppearance.BorderSize = 0;
            this.btn_ResetPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetPw.Location = new System.Drawing.Point(212, 301);
            this.btn_ResetPw.Name = "btn_ResetPw";
            this.btn_ResetPw.Size = new System.Drawing.Size(100, 31);
            this.btn_ResetPw.TabIndex = 87;
            this.btn_ResetPw.Text = "Reset";
            this.btn_ResetPw.UseVisualStyleBackColor = false;
            this.btn_ResetPw.Click += new System.EventHandler(this.btn_ResetPw_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ResetPw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nbx_AdminZip);
            this.Controls.Add(this.nbx_Cid);
            this.Controls.Add(this.btn_AdminDelete);
            this.Controls.Add(this.btn_AdminAdd);
            this.Controls.Add(this.tbx_AdminEmail);
            this.Controls.Add(this.tbx_AdminLname);
            this.Controls.Add(this.tbx_AdminFname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_AdminState);
            this.Controls.Add(this.tbx_AdminCity);
            this.Controls.Add(this.tbx_AdminStreet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.btn_AdminUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_AdminSelect);
            this.Controls.Add(this.label13);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.nbx_AdminZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Cid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nbx_AdminZip;
        private System.Windows.Forms.NumericUpDown nbx_Cid;
        private System.Windows.Forms.Button btn_AdminDelete;
        private System.Windows.Forms.Button btn_AdminAdd;
        private System.Windows.Forms.TextBox tbx_AdminEmail;
        private System.Windows.Forms.TextBox tbx_AdminLname;
        private System.Windows.Forms.TextBox tbx_AdminFname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_AdminState;
        private System.Windows.Forms.TextBox tbx_AdminCity;
        private System.Windows.Forms.TextBox tbx_AdminStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btn_AdminUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_AdminSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem amenu_Logout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ResetPw;
    }
}