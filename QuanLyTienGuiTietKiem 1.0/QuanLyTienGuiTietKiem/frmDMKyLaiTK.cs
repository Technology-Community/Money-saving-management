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
    public partial class frmDMKyLaiTK : Office2007Form
    {
        DMKyLaiTKCtrl m_DMKyLaiTKCtrl = new DMKyLaiTKCtrl();

        public frmDMKyLaiTK()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDMKyLaiTK_Load(object sender, EventArgs e)
        {
            m_DMKyLaiTKCtrl.HienThi(DGVDMKyLaiTK, BindingNavigatorDMKyLaiTK);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDMKyLaiTK.RowCount == 0)
                BindingNavigatorDMKyLaiTK.Enabled = true;
            DataRow m_Row = m_DMKyLaiTKCtrl.ThemDongMoi();
            m_Row["MaKyTinhLai"] = "";
            m_Row["LoaiKyTinhLai"] = "";
            m_DMKyLaiTKCtrl.ThemMoi(m_Row);
            BindingNavigatorDMKyLaiTK.BindingSource.MoveLast();
        }

        public bool KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDMKyLaiTK.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString().Trim();
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
            
                bool ma = KiemTraTruocKhiLuu("colMaKyTinhLai");
                bool ten = KiemTraTruocKhiLuu("colLoaiKyTinhLai");
                if (ma == true && ten == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_DMKyLaiTKCtrl.LuuDMKyLaiTK();
                }
                else
                {
                    MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDMKyLaiTK.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDMKyLaiTK.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}