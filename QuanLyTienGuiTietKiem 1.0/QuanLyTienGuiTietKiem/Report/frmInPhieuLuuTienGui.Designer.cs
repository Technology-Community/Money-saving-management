namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInPhieuLuuTienGui
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnTruyXuat = new DevComponents.DotNetBar.ButtonX();
            this.cmbMaSo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ReportViewerInPhieuLuuTienGui = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InPhieuLuuTienGuiInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuLuuTienGuiInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btnTruyXuat);
            this.groupBox1.Controls.Add(this.cmbMaSo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lưa chọn mã sổ cần in phiếu";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(39, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Chọn mã sổ";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.buttonX2.Location = new System.Drawing.Point(428, 46);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(106, 25);
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnTruyXuat
            // 
            this.btnTruyXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyXuat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Search;
            this.btnTruyXuat.Location = new System.Drawing.Point(299, 46);
            this.btnTruyXuat.Name = "btnTruyXuat";
            this.btnTruyXuat.Size = new System.Drawing.Size(106, 25);
            this.btnTruyXuat.TabIndex = 1;
            this.btnTruyXuat.Text = "Truy xuất ";
            this.btnTruyXuat.Click += new System.EventHandler(this.btnTruyXuat_Click);
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.DisplayMember = "Text";
            this.cmbMaSo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.ItemHeight = 14;
            this.cmbMaSo.Location = new System.Drawing.Point(106, 51);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(153, 20);
            this.cmbMaSo.TabIndex = 0;
            // 
            // ReportViewerInPhieuLuuTienGui
            // 
            this.ReportViewerInPhieuLuuTienGui.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_InPhieuLuuTienGuiInfo";
            reportDataSource1.Value = this.InPhieuLuuTienGuiInfoBindingSource;
            this.ReportViewerInPhieuLuuTienGui.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerInPhieuLuuTienGui.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptInPhieuLuuTienGui.rdlc";
            this.ReportViewerInPhieuLuuTienGui.Location = new System.Drawing.Point(0, 100);
            this.ReportViewerInPhieuLuuTienGui.Name = "ReportViewerInPhieuLuuTienGui";
            this.ReportViewerInPhieuLuuTienGui.Size = new System.Drawing.Size(798, 371);
            this.ReportViewerInPhieuLuuTienGui.TabIndex = 3;
            // 
            // InPhieuLuuTienGuiInfoBindingSource
            // 
            this.InPhieuLuuTienGuiInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.InPhieuLuuTienGuiInfo);
            // 
            // frmInPhieuLuuTienGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 471);
            this.Controls.Add(this.ReportViewerInPhieuLuuTienGui);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInPhieuLuuTienGui";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN PHIẾU LƯU GỬI TIỀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInPhieuLuuTienGui_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuLuuTienGuiInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnTruyXuat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaSo;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInPhieuLuuTienGui;
        private System.Windows.Forms.BindingSource InPhieuLuuTienGuiInfoBindingSource;
    }
}