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
    public partial class frmRutLaiSuatTienTietKiem : Office2007Form
    {
        RutTietKiemCtrl m_RutTietKiemCtrl = new RutTietKiemCtrl();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        DMTaiKhoanCtrl m_DMTaiKHoanCtrl = new DMTaiKhoanCtrl();
        public frmRutLaiSuatTienTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmRutTienTietKiem_Load(object sender, EventArgs e)
        {
            cmbMaSoTietKiem.Enabled = false;
            txtSoTienRut.Enabled = false;
            btnTinh.Enabled = false;

            btnPhieu.Enabled = false;
            btnThucHien.Enabled = false;
            btnNhapLai.Enabled = false;
            m_DMTaiKHoanCtrl.HienThiComboBox(cmbTaiKhoanNo);
            cmbTaiKhoanNo.SelectedValueChanged += new EventHandler(cmbTaiKhoanNo_SelectedValueChanged);

            m_SoTietKiemCtrl.HienThiComboBox(cmbMaSoTietKiem);
            cmbMaSoTietKiem.SelectedValueChanged += new EventHandler(cmbMaSoTietKiem_SelectedValueChanged);
        }

        #region SelectedValueChanged
        void cmbTaiKhoanNo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTaiKhoanCo.Text = cmbTaiKhoanNo.SelectedValue.ToString();
        }

        void cmbMaSoTietKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRutLaiSoKhongKyHan.Checked == true && KiemTraSoKKH(cmbMaSoTietKiem.SelectedValue.ToString()))
            {
                MessageBoxEx.Show("Bạn đang giao dich với chức năng rút lãi không kỳ hạn!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m_RutTietKiemCtrl.LayRutTietKiem(cmbMaSoTietKiem, txtMaKH, txtTenKhachHang, txtSoDu, txtLoaiTienGui, txtLoaiTietKiem, txtLaiSuat, txtNgayDenHan, txtNgayHieuLuc, txtSoButToan);
                m_RutTietKiemCtrl.KiemTraSo(cmbMaSoTietKiem.SelectedValue.ToString());
                TinhLai();
            }


        }
        #endregion
        
        private void txSoTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public Boolean KiemTraSoKKH(String MaSo)
        {
            if (m_RutTietKiemCtrl.KiemTraKhongKH(cmbMaSoTietKiem.SelectedValue.ToString()))
            {
                m_RutTietKiemCtrl.KiemTraKhongKH(MaSo);
                return false;
            }
            else
            {
                return true;
            }
        }

        void TinhLai()
        {
            if (cbRutLaiSoCoKyHan.Checked == true)
            {
                double tong = m_RutTietKiemCtrl.RutLaiSoCoKyHan(cmbMaSoTietKiem.SelectedValue.ToString());
                txtLaiPhaiTra.Text = Convert.ToString(tong);
                txtTienThanhToan.Text = Convert.ToString(tong);
            }
            else if (cbRutLaiSoKhongKyHan.Checked == true )
            {
                txtLaiPhaiTra.Text = "";

                double tong = m_RutTietKiemCtrl.RutLaiKhongKyHan(cmbMaSoTietKiem.SelectedValue.ToString());// *TinhNgay();
                txtLaiPhaiTra.Text = Convert.ToString(tong);
                txtTienThanhToan.Text = Convert.ToString(tong);
            }
            else if (cbRutVonSoKhongKyHan.Checked == true)
            {
                //MessageBox.Show(Convert.ToString(m_RutTietKiemCtrl.RutVonTruocHan(cmbMaSoTietKiem.SelectedValue.ToString())));
            }
            else
            {
                double tong = m_RutTietKiemCtrl.TatToan(cmbMaSoTietKiem.SelectedValue.ToString());
                txtLaiPhaiTra.Text = Convert.ToString(tong);
                txtTienThanhToan.Text = Convert.ToString(tong);
            }

        }

        #region CheckedChanged
        private void cbRutLaiSoCoKyHan_CheckedChanged(object sender, EventArgs e)
        {
            btnPhieu.Enabled = true;
            btnThucHien.Enabled = true;
            btnNhapLai.Enabled = true;

            cmbMaSoTietKiem.Enabled = true;
            txtSoTienRut.Enabled = false;
            btnTinh.Enabled = false;
        }

        private void cbRutVonSoKhongKyHan_CheckedChanged(object sender, EventArgs e)
        {
            btnPhieu.Enabled = true;
            btnThucHien.Enabled = true;
            btnNhapLai.Enabled = true;
            
            cmbMaSoTietKiem.Enabled = true;
            txtSoTienRut.Enabled = true;
            btnTinh.Enabled = true;
        }

        private void cbRutLaiSoKhongKyHan_CheckedChanged(object sender, EventArgs e)
        {
            btnPhieu.Enabled = true;
            btnThucHien.Enabled = true;
            btnNhapLai.Enabled = true;

            cmbMaSoTietKiem.Enabled = true;
            txtSoTienRut.Enabled = false;
            btnTinh.Enabled = false;
        }

        private void cbTatToan_CheckedChanged(object sender, EventArgs e)
        {
            btnPhieu.Enabled = true;
            btnThucHien.Enabled = true;
            btnNhapLai.Enabled = true;

            cmbMaSoTietKiem.Enabled = true;
            txtSoTienRut.Enabled = false;
            btnTinh.Enabled = false;
        }
        #endregion

        #region Bien co lick

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double SoDu = Convert.ToDouble(txtSoDu.Text);
            double TienRut = Convert.ToDouble(txtSoTienRut.Text);
            if (txtSoTienRut.Text == "")
            {
                MessageBoxEx.Show("Giá trị ô tiền rút rỗng không thê thực hiện phép tính!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TienRut > SoDu)
            {
                MessageBoxEx.Show("Giá trị ô tiền rút lớn hơn số tiền tài khoản mà bạn có!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double tonglai = m_RutTietKiemCtrl.RutVonTruocHan(cmbMaSoTietKiem.SelectedValue.ToString(), txtSoTienRut.Text);
                double tongtien = tonglai + Convert.ToDouble(txtSoTienRut.Text);
                txtLaiPhaiTra.Text = Convert.ToString(tonglai);
                txtTienThanhToan.Text = Convert.ToString(tongtien);
            }
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            //InPhieuRut();
            MessageBoxEx.Show("Đang xây dựng có thể đến khung nhìn in phiếu để in", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
                
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (cbRutLaiSoCoKyHan.Checked == true)
            {
                if (cmbMaSoTietKiem.SelectedValue != null && txtLaiPhaiTra.Text != "" && txtTienThanhToan.Text != "")
                {
                    m_RutTietKiemCtrl.LuuThayDoiSTK_RutLai(cmbMaSoTietKiem.SelectedValue.ToString(), DateTime.Today, txtLaiPhaiTra.Text);
                }
                else
                {
                    MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu thực hiện giao dịch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbRutVonSoKhongKyHan.Checked == true)
            {
                if (cmbMaSoTietKiem.SelectedValue != null && txtLaiPhaiTra.Text != "" && txtTienThanhToan.Text != "" && txtSoTienRut.Text != "")
                {
                    m_RutTietKiemCtrl.LuuSoDu(cmbMaSoTietKiem.SelectedValue.ToString(), txtSoTienRut.Text);
                }
                else
                {
                    MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu thực hiện giao dịch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbRutLaiSoKhongKyHan.Checked == true)
            {
                if (cmbMaSoTietKiem.SelectedValue != null && txtLaiPhaiTra.Text != "" && txtTienThanhToan.Text != "")
                {
                    m_RutTietKiemCtrl.LuuThayDoiSTK_RutLaiKhongKH(cmbMaSoTietKiem.SelectedValue.ToString(), DateTime.Today, txtLaiPhaiTra.Text);
                }
                else
                {
                    MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu thực hiện giao dịch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbTatToan.Checked == true)
            {
                if (cmbMaSoTietKiem.SelectedValue != null && txtLaiPhaiTra.Text != "" && txtTienThanhToan.Text != "")
                {
                    m_RutTietKiemCtrl.LuuTatToan(cmbMaSoTietKiem.SelectedValue.ToString(), txtSoDu.Text, DateTime.Today);
                }

                else
                {
                    MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu thực hiện giao dịch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        void InPhieuRut()
        {

        }

        private void txtSoTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}