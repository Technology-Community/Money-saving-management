using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmChiTietPhatSinhGD : Office2007Form
    {
        ChiTietPhatSinhGDCtrl m_ChiTietPhatSinhGDCtrl = new ChiTietPhatSinhGDCtrl();
        DMTaiKhoanCtrl m_DMTaIKhoaCtrl = new DMTaiKhoanCtrl();
        NgayGiaoDichCtrl m_NgayGiaoDichCtrl = new NgayGiaoDichCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();

        public frmChiTietPhatSinhGD()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmChiTietPhatSinhGD_Load(object sender, EventArgs e)
        {
            m_DMTaIKhoaCtrl.HienThiComboBox(cmbSoHieuCo);
            m_DMTaIKhoaCtrl.HienThiComboBox(cmbSoHieuNo);
            m_NgayGiaoDichCtrl.HienThiComboBox(cmbNgayGiaoDich);

            m_ChiTietPhatSinhGDCtrl.HienThi(DGVChiTietPhatSinhGD, BindingNavigatorChiTietPhatSinhGD, txtSoGiaoDich, txtSoButToan, cmbSoHieuCo, cmbSoHieuNo,txtSoTien);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_DMTaIKhoaCtrl.HienThiComboBox(cmbSoHieuCo);
            m_DMTaIKhoaCtrl.HienThiComboBox(cmbSoHieuNo);

            m_ChiTietPhatSinhGDCtrl.HienThi(DGVChiTietPhatSinhGD, BindingNavigatorChiTietPhatSinhGD, txtSoGiaoDich, txtSoButToan, cmbSoHieuCo, cmbSoHieuNo, txtSoTien);
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //MaTK, NgayGiaoDich, MaPhongGD, MaNV, MaLoaiGD
            if (DGVChiTietPhatSinhGD.RowCount == 0)
                BindingNavigatorChiTietPhatSinhGD.Enabled = true;
            DataRow m_Row = m_ChiTietPhatSinhGDCtrl.ThemDongMoi();
            m_Row["SoGiaoDich"] = "";
            m_Row["SoButToan"] = "BT" + m_QuyDinh.LaySTT(DGVChiTietPhatSinhGD.Rows.Count + 1);
            m_Row["SoHieuTaiKhoanNo"] = "";
            m_Row["SoHieuTaiKhoanCo"] = "";
            m_Row["SoTien"] = 0;
            m_ChiTietPhatSinhGDCtrl.ThemMoi(m_Row);
            BindingNavigatorChiTietPhatSinhGD.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVChiTietPhatSinhGD.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (KiemTraTruocKhiLuu("colSoGiaoDich") == true &&
                KiemTraTruocKhiLuu("colSoHieuTaiKhoanCo") == true &&
                KiemTraTruocKhiLuu("colSoHieuTaiKhoanNo") == true &&
                KiemTraTruocKhiLuu("colSoTien") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_ChiTietPhatSinhGDCtrl.LuuChiTietPhatSinhGD();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVChiTietPhatSinhGD.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorChiTietPhatSinhGD.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Tim kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemSoTietKiem();
            }
        }
        
        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSoTietKiem();
            }
        }

        void TimKiemSoTietKiem()
        {
            try
            {
                if (cbSoButToan.Checked == true)
                {
                    m_ChiTietPhatSinhGDCtrl.TimSoButToan(txtSoButToan.Text);
                }
                else
                {
                    m_ChiTietPhatSinhGDCtrl.TimSoGiaoDich(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void btnSHCo_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMTaiKhoan();
        }

        private void btnSHNo_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMTaiKhoan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            m_ChiTietPhatSinhGDCtrl.LuuChiTietPSGD(txtSoGiaoDich.Text, txtSoButToan.Text, Convert.ToDateTime(cmbNgayGiaoDich.SelectedValue.ToString()), cmbSoHieuNo.SelectedValue.ToString(), cmbSoHieuCo.SelectedValue.ToString(), Convert.ToInt32(txtSoTien.Text));
        }

    }
}