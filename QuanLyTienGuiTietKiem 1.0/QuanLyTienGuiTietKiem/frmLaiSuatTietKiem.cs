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
    public partial class frmLaiSuatTietKiem : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        LaiSuatTietKiemCtrl m_LaiSuatTietKiemCtrl = new LaiSuatTietKiemCtrl();
        LoaiTietKiemCtrl m_LoaiTietKiemCtrl = new LoaiTietKiemCtrl();
        public frmLaiSuatTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLaiSuatTietKiem_Load(object sender, EventArgs e)
        {
            m_LoaiTietKiemCtrl.HienThiDataGridViewComboBoxColumn(colMaLoaiTietKiem);

            m_LaiSuatTietKiemCtrl.HienThi(DGVLaiSuatTietKiem, BindingNavigatorLaiSuatTietKiem);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVLaiSuatTietKiem.RowCount == 0)
                BindingNavigatorLaiSuatTietKiem.Enabled = true;
            DataRow m_Row = m_LaiSuatTietKiemCtrl.ThemDongMoi();
            m_Row["MaLoaiTietKiem"] = "";
            m_Row["Ngay"] = DateTime.Today;
            m_Row["MucLaiSuat"] = 0;

            m_LaiSuatTietKiemCtrl.ThemMoi(m_Row);
            BindingNavigatorLaiSuatTietKiem.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVLaiSuatTietKiem.Rows)
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

            if (KiemTraTruocKhiLuu("colMaLoaiTietKiem") == true &&
                KiemTraTruocKhiLuu("colNgay") == true &&
                KiemTraTruocKhiLuu("colMucLaiSuat") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LaiSuatTietKiemCtrl.LuuLaiSuatTietKiem();
            }

            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVLaiSuatTietKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorLaiSuatTietKiem.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}