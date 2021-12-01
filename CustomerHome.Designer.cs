
namespace ChattBank
{
    partial class CustomerHome
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
            this.menu_Profile = new System.Windows.Forms.MenuStrip();
            this.menu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Prof = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_AddAcc = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ConfirmDep = new System.Windows.Forms.Button();
            this.btn_ConfirmDraw = new System.Windows.Forms.Button();
            this.cbx_Type = new System.Windows.Forms.ComboBox();
            this.btn_ConfirmAdd = new System.Windows.Forms.Button();
            this.cbx_Deposit = new System.Windows.Forms.ComboBox();
            this.cbx_Withdraw = new System.Windows.Forms.ComboBox();
            this.nbx_Dep = new System.Windows.Forms.NumericUpDown();
            this.nbx_Draw = new System.Windows.Forms.NumericUpDown();
            this.pnl_mid = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menu_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_Profile
            // 
            this.menu_Profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Home,
            this.menu_Logout,
            this.menu_Prof});
            this.menu_Profile.Location = new System.Drawing.Point(0, 0);
            this.menu_Profile.Name = "menu_Profile";
            this.menu_Profile.Size = new System.Drawing.Size(800, 24);
            this.menu_Profile.TabIndex = 46;
            this.menu_Profile.Text = "menuStrip1";
            // 
            // menu_Home
            // 
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Size = new System.Drawing.Size(52, 20);
            this.menu_Home.Text = "Home";
            this.menu_Home.Click += new System.EventHandler(this.menu_Home_Click);
            // 
            // menu_Logout
            // 
            this.menu_Logout.BackColor = System.Drawing.Color.White;
            this.menu_Logout.Name = "menu_Logout";
            this.menu_Logout.Size = new System.Drawing.Size(57, 20);
            this.menu_Logout.Text = "Logout";
            this.menu_Logout.Click += new System.EventHandler(this.menu_Logout_Click);
            // 
            // menu_Prof
            // 
            this.menu_Prof.Name = "menu_Prof";
            this.menu_Prof.Size = new System.Drawing.Size(53, 20);
            this.menu_Prof.Text = "Profile";
            this.menu_Prof.Click += new System.EventHandler(this.menu_Prof_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(124, 91);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(30, 17);
            this.lbl_Info.TabIndex = 47;
            this.lbl_Info.Text = "Info";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(782, 27);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 340);
            this.vScrollBar1.TabIndex = 48;
            // 
            // btn_AddAcc
            // 
            this.btn_AddAcc.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_AddAcc.FlatAppearance.BorderSize = 0;
            this.btn_AddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAcc.Location = new System.Drawing.Point(43, 364);
            this.btn_AddAcc.Name = "btn_AddAcc";
            this.btn_AddAcc.Size = new System.Drawing.Size(198, 54);
            this.btn_AddAcc.TabIndex = 49;
            this.btn_AddAcc.Text = "New Account Options";
            this.btn_AddAcc.UseVisualStyleBackColor = false;
            this.btn_AddAcc.Click += new System.EventHandler(this.btn_AddAcc_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Deposit.FlatAppearance.BorderSize = 0;
            this.btn_Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposit.ForeColor = System.Drawing.Color.White;
            this.btn_Deposit.Location = new System.Drawing.Point(284, 364);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(198, 54);
            this.btn_Deposit.TabIndex = 50;
            this.btn_Deposit.Text = "Deposit Options";
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Draw
            // 
            this.btn_Draw.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Draw.FlatAppearance.BorderSize = 0;
            this.btn_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw.Location = new System.Drawing.Point(529, 364);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(198, 54);
            this.btn_Draw.TabIndex = 51;
            this.btn_Draw.Text = "Withdraw Options";
            this.btn_Draw.UseVisualStyleBackColor = false;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Amount:";
            // 
            // btn_ConfirmDep
            // 
            this.btn_ConfirmDep.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ConfirmDep.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmDep.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmDep.Location = new System.Drawing.Point(284, 495);
            this.btn_ConfirmDep.Name = "btn_ConfirmDep";
            this.btn_ConfirmDep.Size = new System.Drawing.Size(198, 54);
            this.btn_ConfirmDep.TabIndex = 54;
            this.btn_ConfirmDep.Text = "Confirm Deposit";
            this.btn_ConfirmDep.UseVisualStyleBackColor = false;
            this.btn_ConfirmDep.Click += new System.EventHandler(this.btn_ConfirmDep_Click);
            // 
            // btn_ConfirmDraw
            // 
            this.btn_ConfirmDraw.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ConfirmDraw.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmDraw.Location = new System.Drawing.Point(529, 495);
            this.btn_ConfirmDraw.Name = "btn_ConfirmDraw";
            this.btn_ConfirmDraw.Size = new System.Drawing.Size(198, 54);
            this.btn_ConfirmDraw.TabIndex = 55;
            this.btn_ConfirmDraw.Text = "Confirm WithDrawal";
            this.btn_ConfirmDraw.UseVisualStyleBackColor = false;
            this.btn_ConfirmDraw.Click += new System.EventHandler(this.btn_ConfirmDraw_Click);
            // 
            // cbx_Type
            // 
            this.cbx_Type.FormattingEnabled = true;
            this.cbx_Type.Items.AddRange(new object[] {
            "SAV",
            "CHK",
            "MMA"});
            this.cbx_Type.Location = new System.Drawing.Point(43, 428);
            this.cbx_Type.Name = "cbx_Type";
            this.cbx_Type.Size = new System.Drawing.Size(198, 25);
            this.cbx_Type.TabIndex = 58;
            this.cbx_Type.Text = "Type";
            // 
            // btn_ConfirmAdd
            // 
            this.btn_ConfirmAdd.BackColor = System.Drawing.Color.Gold;
            this.btn_ConfirmAdd.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmAdd.Location = new System.Drawing.Point(43, 495);
            this.btn_ConfirmAdd.Name = "btn_ConfirmAdd";
            this.btn_ConfirmAdd.Size = new System.Drawing.Size(198, 54);
            this.btn_ConfirmAdd.TabIndex = 59;
            this.btn_ConfirmAdd.Text = "Create New Account";
            this.btn_ConfirmAdd.UseVisualStyleBackColor = false;
            this.btn_ConfirmAdd.Click += new System.EventHandler(this.btn_ConfirmAdd_Click);
            // 
            // cbx_Deposit
            // 
            this.cbx_Deposit.FormattingEnabled = true;
            this.cbx_Deposit.Location = new System.Drawing.Point(284, 428);
            this.cbx_Deposit.Name = "cbx_Deposit";
            this.cbx_Deposit.Size = new System.Drawing.Size(198, 25);
            this.cbx_Deposit.TabIndex = 60;
            this.cbx_Deposit.Text = "Select Account";
            // 
            // cbx_Withdraw
            // 
            this.cbx_Withdraw.FormattingEnabled = true;
            this.cbx_Withdraw.Location = new System.Drawing.Point(529, 425);
            this.cbx_Withdraw.Name = "cbx_Withdraw";
            this.cbx_Withdraw.Size = new System.Drawing.Size(198, 25);
            this.cbx_Withdraw.TabIndex = 61;
            this.cbx_Withdraw.Text = "Select Account";
            // 
            // nbx_Dep
            // 
            this.nbx_Dep.DecimalPlaces = 2;
            this.nbx_Dep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbx_Dep.Location = new System.Drawing.Point(344, 461);
            this.nbx_Dep.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nbx_Dep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbx_Dep.Name = "nbx_Dep";
            this.nbx_Dep.Size = new System.Drawing.Size(138, 22);
            this.nbx_Dep.TabIndex = 62;
            this.nbx_Dep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nbx_Draw
            // 
            this.nbx_Draw.DecimalPlaces = 2;
            this.nbx_Draw.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbx_Draw.Location = new System.Drawing.Point(586, 461);
            this.nbx_Draw.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nbx_Draw.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbx_Draw.Name = "nbx_Draw";
            this.nbx_Draw.Size = new System.Drawing.Size(141, 22);
            this.nbx_Draw.TabIndex = 63;
            this.nbx_Draw.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pnl_mid
            // 
            this.pnl_mid.Location = new System.Drawing.Point(272, 425);
            this.pnl_mid.Name = "pnl_mid";
            this.pnl_mid.Size = new System.Drawing.Size(219, 125);
            this.pnl_mid.TabIndex = 64;
            // 
            // pnl_left
            // 
            this.pnl_left.Location = new System.Drawing.Point(29, 428);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(221, 125);
            this.pnl_left.TabIndex = 65;
            // 
            // pnl_right
            // 
            this.pnl_right.Location = new System.Drawing.Point(520, 425);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(219, 125);
            this.pnl_right.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 67;
            this.label3.Text = "ACCOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(272, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 32);
            this.label4.TabIndex = 68;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(411, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 69;
            this.label5.Text = "TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(529, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "BALANCE";
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_mid);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nbx_Draw);
            this.Controls.Add(this.nbx_Dep);
            this.Controls.Add(this.cbx_Withdraw);
            this.Controls.Add(this.cbx_Deposit);
            this.Controls.Add(this.btn_ConfirmAdd);
            this.Controls.Add(this.cbx_Type);
            this.Controls.Add(this.btn_ConfirmDraw);
            this.Controls.Add(this.btn_ConfirmDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_AddAcc);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.menu_Profile);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            this.menu_Profile.ResumeLayout(false);
            this.menu_Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbx_Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Profile;
        private System.Windows.Forms.ToolStripMenuItem menu_Home;
        private System.Windows.Forms.ToolStripMenuItem menu_Logout;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_AddAcc;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ConfirmDep;
        private System.Windows.Forms.Button btn_ConfirmDraw;
        private System.Windows.Forms.ComboBox cbx_Type;
        private System.Windows.Forms.Button btn_ConfirmAdd;
        private System.Windows.Forms.ComboBox cbx_Deposit;
        private System.Windows.Forms.ComboBox cbx_Withdraw;
        private System.Windows.Forms.NumericUpDown nbx_Dep;
        private System.Windows.Forms.NumericUpDown nbx_Draw;
        private System.Windows.Forms.Panel pnl_mid;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.ToolStripMenuItem menu_Prof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}