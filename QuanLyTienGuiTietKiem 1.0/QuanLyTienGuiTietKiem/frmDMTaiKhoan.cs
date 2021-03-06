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
    public partial class frmDMTaiKhoan : Office2007Form
    {
        DMTaiKhoanCtrl m_DMTaiKhoanCtrl = new DMTaiKhoanCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmDMTaiKhoan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDMTaiKhoan_Load(object sender, EventArgs e)
        {
            m_DMTaiKhoanCtrl.HienThi(DGVDMTaiKhoan, BindingNavigatorDMTaiKhoan);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDMTaiKhoan.RowCount == 0)
                BindingNavigatorDMTaiKhoan.Enabled = true;
            DataRow m_Row = m_DMTaiKhoanCtrl.ThemDongMoi();
            m_Row["SoHieuTaiKhoan"] = "";
            m_Row["TenTaiKhoan"] = "";
            m_Row["TinhChatSoDu"] = "";
            m_DMTaiKhoanCtrl.ThemMoi(m_Row);
            BindingNavigatorDMTaiKhoan.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDMTaiKhoan.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colSoHieuTaiKhoan") == true &&
                KiemTraTruocKhiLuu("colTenTaiKhoan") == true &&
                KiemTraTruocKhiLuu("colTinhChatSoDu") == true)
            bindingNavigatorPositionItem.Focus();
            m_DMTaiKhoanCtrl.LuuDMTaiKhoan();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDMTaiKhoan.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDMTaiKhoan.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    
    }
}