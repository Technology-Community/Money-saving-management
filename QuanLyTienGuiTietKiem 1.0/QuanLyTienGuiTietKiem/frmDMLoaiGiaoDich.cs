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
    public partial class frmDMLoaiGiaoDich : Office2007Form
    {
        DMLoaiGiaoDichCtrl m_DMLoaiGiaoDichCtrl = new DMLoaiGiaoDichCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmDMLoaiGiaoDich()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDMLoaiGiaoDich_Load(object sender, EventArgs e)
        {
            m_DMLoaiGiaoDichCtrl.HienThi(DGVDMLoaiGiaoDich, BindingNavigatorDMLoaiGiaoDich);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiGiaoDich.RowCount == 0)
                BindingNavigatorDMLoaiGiaoDich.Enabled = true;
            DataRow m_Row = m_DMLoaiGiaoDichCtrl.ThemDongMoi();
            m_Row["MaLoaiGiaoDich"] = "LGD" + m_QuyDinh.LaySTT(DGVDMLoaiGiaoDich.Rows.Count + 1);
            m_Row["TenGiaoDich"] = "";
            m_DMLoaiGiaoDichCtrl.ThemMoi(m_Row);
            BindingNavigatorDMLoaiGiaoDich.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDMLoaiGiaoDich.Rows)
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
            if (KiemTraTruocKhiLuu("colMaLoaiGiaoDich") == true &&
                KiemTraTruocKhiLuu("colTenGiaoDich") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DMLoaiGiaoDichCtrl.LuuDMLoaiGiaoDich();
            }
            else
            {
                MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiGiaoDich.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDMLoaiGiaoDich.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    
    }
}