namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInSoCoKyHan
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
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnTruyXuat = new DevComponents.DotNetBar.ButtonX();
            this.cmbMaSoTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ReportViewerInSoCoKyHan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTruyXuat);
            this.groupBox1.Controls.Add(this.cmbMaSoTK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sổ xuất có kỳ hạn";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(450, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTruyXuat
            // 
            this.btnTruyXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyXuat.Location = new System.Drawing.Point(326, 35);
            this.btnTruyXuat.Name = "btnTruyXuat";
            this.btnTruyXuat.Size = new System.Drawing.Size(102, 23);
            this.btnTruyXuat.TabIndex = 1;
            this.btnTruyXuat.Text = "Truy xuất";
            this.btnTruyXuat.Click += new System.EventHandler(this.btnTruyXuat_Click);
            // 
            // cmbMaSoTK
            // 
            this.cmbMaSoTK.DisplayMember = "Text";
            this.cmbMaSoTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaSoTK.FormattingEnabled = true;
            this.cmbMaSoTK.ItemHeight = 14;
            this.cmbMaSoTK.Location = new System.Drawing.Point(150, 38);
            this.cmbMaSoTK.Name = "cmbMaSoTK";
            this.cmbMaSoTK.Size = new System.Drawing.Size(157, 20);
            this.cmbMaSoTK.TabIndex = 0;
            // 
            // ReportViewerInSoCoKyHan
            // 
            this.ReportViewerInSoCoKyHan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "QuanLyTienGuiTietKiem_Bussiness_SoTietKiemInfo";
            reportDataSource2.Value = this.SoTietKiemInfoBindingSource;
            this.ReportViewerInSoCoKyHan.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerInSoCoKyHan.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptInSoCoKyHan.rdlc";
            this.ReportViewerInSoCoKyHan.Location = new System.Drawing.Point(0, 100);
            this.ReportViewerInSoCoKyHan.Name = "ReportViewerInSoCoKyHan";
            this.ReportViewerInSoCoKyHan.Size = new System.Drawing.Size(693, 458);
            this.ReportViewerInSoCoKyHan.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(29, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(115, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Chọn mã sổ tiết kiệm";
            // 
            // frmInSoCoKyHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 558);
            this.Controls.Add(this.ReportViewerInSoCoKyHan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInSoCoKyHan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN SỔ CÓ KỲ HẠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InSoCoKyHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoTietKiemInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInSoCoKyHan;
        private System.Windows.Forms.BindingSource SoTietKiemInfoBindingSource;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnTruyXuat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaSoTK;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}