namespace QuanLyTienGuiTietKiem.General
{
    partial class frmDangNhap
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
            DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.btnCLose = new DevComponents.DotNetBar.ButtonX();
            this.lbErrorPass = new DevComponents.DotNetBar.LabelX();
            this.lbErrorUserName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonClientPanel3 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            reflectionImage1.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmLogin;
            reflectionImage1.Location = new System.Drawing.Point(18, 47);
            reflectionImage1.Name = "reflectionImage1";
            reflectionImage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            reflectionImage1.Size = new System.Drawing.Size(76, 133);
            reflectionImage1.TabIndex = 0;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Location = new System.Drawing.Point(182, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(100, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Tên đăng nhập:";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Location = new System.Drawing.Point(182, 103);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(184, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(121, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(116, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCLose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(223, 144);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(88, 26);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Text = "Hủy bỏ";
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lbErrorPass
            // 
            this.lbErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPass.Location = new System.Drawing.Point(182, 85);
            this.lbErrorPass.Name = "lbErrorPass";
            this.lbErrorPass.Size = new System.Drawing.Size(184, 19);
            this.lbErrorPass.TabIndex = 4;
            // 
            // lbErrorUserName
            // 
            this.lbErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUserName.Location = new System.Drawing.Point(182, 47);
            this.lbErrorUserName.Name = "lbErrorUserName";
            this.lbErrorUserName.Size = new System.Drawing.Size(184, 15);
            this.lbErrorUserName.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(-6, -1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(391, 37);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "<div align=\"center\">ĐĂNG NHẬP</div>";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(45, 33);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(304, 2);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 5;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // ribbonClientPanel2
            // 
            this.ribbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel2.Location = new System.Drawing.Point(75, 38);
            this.ribbonClientPanel2.Name = "ribbonClientPanel2";
            this.ribbonClientPanel2.Size = new System.Drawing.Size(250, 2);
            // 
            // 
            // 
            this.ribbonClientPanel2.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel2.TabIndex = 5;
            this.ribbonClientPanel2.Text = "ribbonClientPanel1";
            // 
            // ribbonClientPanel3
            // 
            this.ribbonClientPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel3.Location = new System.Drawing.Point(116, 42);
            this.ribbonClientPanel3.Name = "ribbonClientPanel3";
            this.ribbonClientPanel3.Size = new System.Drawing.Size(150, 2);
            // 
            // 
            // 
            this.ribbonClientPanel3.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel3.TabIndex = 5;
            this.ribbonClientPanel3.Text = "ribbonClientPanel1";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 182);
            this.Controls.Add(reflectionImage1);
            this.Controls.Add(this.ribbonClientPanel3);
            this.Controls.Add(this.ribbonClientPanel2);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbErrorUserName);
            this.Controls.Add(this.lbErrorPass);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.ButtonX btnCLose;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        public DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        public DevComponents.DotNetBar.LabelX lbErrorPass;
        public DevComponents.DotNetBar.LabelX lbErrorUserName;
        public DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel3;

    }
}