namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInSoKhongKyHan
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SoTietKiemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiTK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnTruySuat = new DevComponents.DotNetBar.ButtonX();
            this.cmbMaSoTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ReportViewerInSoKhongKyHan = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SoTietKiemInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoTietKiemInfoBindingSource
            // 
            this.SoTietKiemInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.SoTietKiemInfo);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLoaiTK);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTruySuat);
            this.groupBox1.Controls.Add(this.cmbMaSoTK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sổ xuất có kỳ hạn";
            // 
            // txtMaLoaiTK
            // 
            // 
            // 
            // 
            this.txtMaLoaiTK.Border.Class = "TextBoxBorder";
            this.txtMaLoaiTK.Enabled = false;
            this.txtMaLoaiTK.Location = new System.Drawing.Point(0, 35);
            this.txtMaLoaiTK.Name = "txtMaLoaiTK";
            this.txtMaLoaiTK.Size = new System.Drawing.Size(83, 20);
            this.txtMaLoaiTK.TabIndex = 4;
            this.txtMaLoaiTK.Text = "TK423100";
            this.txtMaLoaiTK.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(90, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 20);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Chọn mã sổ không kỳ hạn";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(541, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 24);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTruySuat
            // 
            this.btnTruySuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruySuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruySuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruySuat.Location = new System.Drawing.Point(413, 31);
            this.btnTruySuat.Name = "btnTruySuat";
            this.btnTruySuat.Size = new System.Drawing.Size(104, 24);
            this.btnTruySuat.TabIndex = 1;
            this.btnTruySuat.Text = "Truy Suất";
            this.btnTruySuat.Click += new System.EventHandler(this.btnTruySuat_Click);
            // 
            // cmbMaSoTK
            // 
            this.cmbMaSoTK.DisplayMember = "Text";
            this.cmbMaSoTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaSoTK.FormattingEnabled = true;
            this.cmbMaSoTK.ItemHeight = 14;
            this.cmbMaSoTK.Location = new System.Drawing.Point(233, 35);
            this.cmbMaSoTK.Name = "cmbMaSoTK";
            this.cmbMaSoTK.Size = new System.Drawing.Size(156, 20);
            this.cmbMaSoTK.TabIndex = 0;
            // 
            // ReportViewerInSoKhongKyHan
            // 
            this.ReportViewerInSoKhongKyHan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "QuanLyTienGuiTietKiem_Bussiness_SoTietKiemInfo";
            reportDataSource2.Value = this.SoTietKiemInfoBindingSource;
            this.ReportViewerInSoKhongKyHan.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerInSoKhongKyHan.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptSoTietKiem.rdlc";
            this.ReportViewerInSoKhongKyHan.Location = new System.Drawing.Point(0, 100);
            this.ReportViewerInSoKhongKyHan.Name = "ReportViewerInSoKhongKyHan";
            this.ReportViewerInSoKhongKyHan.Size = new System.Drawing.Size(808, 523);
            this.ReportViewerInSoKhongKyHan.TabIndex = 1;
            // 
            // frmInSoKhongKyHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.ReportViewerInSoKhongKyHan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInSoKhongKyHan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN SỔ KHÔNG KỲ HẠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InSoKhongKyHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoTietKiemInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnTruySuat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaSoTK;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInSoKhongKyHan;
        private System.Windows.Forms.BindingSource SoTietKiemInfoBindingSource;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiTK;
    }
}