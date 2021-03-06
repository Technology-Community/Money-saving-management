using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmMoSoTietKiem : Office2007Form
    {
        private int maso;
                
        public int MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        DMLoaiGiaoDichCtrl m_DMLoaiGiaoDichCtrl = new DMLoaiGiaoDichCtrl();
        DMLoaiTienCtrl m_DMLoaiTienCtrl = new DMLoaiTienCtrl();
        DMTaiKhoanCtrl m_DMTaiKHoanCtrl = new DMTaiKhoanCtrl();

        SoDuTietKiemCtrl m_SoDuTieKiemCtrl = new SoDuTietKiemCtrl();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        PhatSinhTietKiemCtrl m_PhatSinhTietKiemCtrl = new PhatSinhTietKiemCtrl();
       
        NgayGiaoDichCtrl m_NgayGiaoDichCtrl = new NgayGiaoDichCtrl();
        LoaiTietKiemCtrl m_LoaiTietKiemCtrl = new LoaiTietKiemCtrl();
        LaiSuatTietKiemCtrl m_LaiSuatCtrl = new LaiSuatTietKiemCtrl();
        
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        ChiTietPhatSinhGDCtrl m_ChiTietPhatSinhCtrl = new ChiTietPhatSinhGDCtrl();
        MoSoTietKiemCtrl m_MoSoTietKiemCtrl = new MoSoTietKiemCtrl();

        GiaoDichVienCtrl m_GiaoDichVienCtrl = new GiaoDichVienCtrl();

        QuyDinh m_QuyDinh = new QuyDinh();

        public frmMoSoTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        private void frmMoSoTietKiem_Load(object sender, EventArgs e)
        {
            txtMoSo.Text = m_SoTietKiemCtrl.LayMaSoTietKiem();
            txtSoButToan.Text = m_PhatSinhTietKiemCtrl.LayPSTKTheoButToan();

            m_DMLoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_DMLoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);

            m_LoaiTietKiemCtrl.HienThiComboBox(cmbLoaiTietKiem);
            cmbLoaiTietKiem.SelectedValueChanged += new EventHandler(cmbLoaiTietKiem_SelectedValueChanged);

            

            m_DMTaiKHoanCtrl.HienThiComboBox(cmbTaiKhoanNo);
            cmbTaiKhoanNo.SelectedValueChanged += new EventHandler(cmbTaiKhoanNo_SelectedValueChanged);
            m_KhachHangCtrl.HienThiComboBox(cmbMaKH);
            cmbMaKH.SelectedValueChanged += new EventHandler(cmbMaKH_SelectedValueChanged);

            m_GiaoDichVienCtrl.HienThiComboBox(cmbMaNV);
            cmbMaNV.SelectedValueChanged += new EventHandler(cmbMaNV_SelectedValueChanged);
        }

      
        #region SelectedValueChanged

        void cmbMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMaNV.SelectedValue.ToString() != null)
            {
                m_MoSoTietKiemCtrl.LayTheoMaNV(cmbMaNV, txtMaNV, txtQuayGiaoDich, txtPhongGiaoDich);
            }
        }
        void cmbTaiKhoanNo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTaiKhoanCo.Text = cmbTaiKhoanNo.SelectedValue.ToString();
        }

        void cmbLoaiTietKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            m_MoSoTietKiemCtrl.LayLaiSuatTheoMaLoai(cmbLoaiTietKiem, txtMaLoaiTietKiem, txtLaiSuat);
        }

        void cmbMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMaKH.SelectedValue.ToString() != null)
            {
                txtMaKH.Text = cmbMaKH.SelectedValue.ToString();
            }
        }

        #endregion 


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiKhachHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbMaKH.SelectedValue != null && cmbLoaiTietKiem.SelectedValue != null && dtNgayHetHL.Value != null && txtSoTienGui.Text != "" && cmbMaNV.SelectedValue != null && cmbTaiKhoanNo.SelectedValue != null)
            {
                if (m_MoSoTietKiemCtrl.KTNgayGD(dtNgayHieuLuc.Value))
                {
                    m_SoTietKiemCtrl.LuuSoMoTK(cmbLoaiTietKiem.SelectedValue.ToString(), txtMoSo.Text, dtNgayHieuLuc.Value, dtNgayHieuLuc.Value, dtNgayHetHL.Value, DateTime.Now, DateTime.Now, 0, 0, DateTime.Now, false, DateTime.Now, txtMaKH.Text);

                    m_NgayGiaoDichCtrl.LuuNgayGD(dtNgayHieuLuc.Value, false);

                    m_PhatSinhTietKiemCtrl.LuuPSTK(txtSoButToan.Text, dtNgayHieuLuc.Value, false, txtMoSo.Text, cmbLoaiGiaoDich.SelectedValue.ToString(), txtQuayGiaoDich.Text, txtPhongGiaoDich.Text, txtMaNV.Text);
                    m_ChiTietPhatSinhCtrl.LuuChiTietPSGD("GDPS0001", txtSoButToan.Text, dtNgayHieuLuc.Value, cmbTaiKhoanNo.SelectedValue.ToString(), txtTaiKhoanCo.Text, Convert.ToInt64(txtLoadSoTienGui.Text));

                    m_SoDuTieKiemCtrl.LuuSoDuTK(txtMaLoaiTietKiem.Text, txtMoSo.Text, dtNgayHieuLuc.Value, Convert.ToInt64(txtSoTienGui.Text));
                    //MessageBoxEx.Show("ko trung");
                }
                else
                {
                    m_SoTietKiemCtrl.LuuSoMoTK(cmbLoaiTietKiem.SelectedValue.ToString(), txtMoSo.Text, dtNgayHieuLuc.Value, dtNgayHieuLuc.Value, dtNgayHetHL.Value, DateTime.Now, DateTime.Now, 0, 0, DateTime.Now, false, DateTime.Now, txtMaKH.Text);

                    m_PhatSinhTietKiemCtrl.LuuPSTK(txtSoButToan.Text, dtNgayHieuLuc.Value, false, txtMoSo.Text, cmbLoaiGiaoDich.SelectedValue.ToString(), txtQuayGiaoDich.Text, txtPhongGiaoDich.Text, txtMaNV.Text);
                    m_ChiTietPhatSinhCtrl.LuuChiTietPSGD("GDPS0001", txtSoButToan.Text, dtNgayHieuLuc.Value, cmbTaiKhoanNo.SelectedValue.ToString(), txtTaiKhoanCo.Text, Convert.ToInt64(txtLoadSoTienGui.Text));

                    m_SoDuTieKiemCtrl.LuuSoDuTK(txtMaLoaiTietKiem.Text, txtMoSo.Text, dtNgayHieuLuc.Value, Convert.ToInt64(txtSoTienGui.Text));
                    //MessageBoxEx.Show("trung");
                }

                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để mở một sổ tiết kiệm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtLoadSoTienGui.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtMoSo.Text = "";
            txtQuayGiaoDich.Text = "";
            txtSoButToan.Text = "";
            txtSoTienGui.Text = "";
            txtTaiKhoanCo.Text = "";
            txtTaiKhoanCo2.Text = "";
        }

        private void txtSoTienGui_TextChanged(object sender, EventArgs e)
        {
            txtLoadSoTienGui.Text = txtSoTienGui.Text;
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtNgayHetHL_Leave(object sender, EventArgs e)
        {
           m_MoSoTietKiemCtrl.KiemTraNgay(cmbLoaiTietKiem.SelectedValue.ToString(), dtNgayHieuLuc.Value, dtNgayHetHL.Value);
        }

        private void btnInPhieuGui_Click(object sender, EventArgs e)
        {
            //InSoTietKiemCtrl ctrl = new InSoTietKiemCtrl();
            //LoadMain.HienThiInSoCoKH();

            MessageBoxEx.Show("Đang xây dựng có thể đến khung nhìn in phiếu để in", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}