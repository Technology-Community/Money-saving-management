using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class DMKyLaiTKCtrl
    {
        DMKyLaiTKData m_DMKyLaiTKData = new DMKyLaiTKData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_DMKyLaiTKData.LayDMKyLaiTK();
            cbx.DisplayMember = "LoaiKyTinhLai";
            cbx.ValueMember = "MaKyTinhLai";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DMKyLaiTKData.LayDMKyLaiTK();
            cmbColumn.DisplayMember = "LoaiKyTinhLai";
            cmbColumn.ValueMember = "MaKyTinhLai";
            cmbColumn.DataPropertyName = "MaKyTinhLai";
            cmbColumn.HeaderText = "Loại kỳ tính lãi";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_DMKyLaiTKData.LayDMKyLaiTK();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi (DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaKyTinhLai,
                            TextBoxX txtLoaiKyTinhLai
                            
                           )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DMKyLaiTKData.LayDMKyLaiTK();

            txtMaKyTinhLai.DataBindings.Clear();
            txtMaKyTinhLai.DataBindings.Add("Text", bS, "MaKyTinhLai");

            txtLoaiKyTinhLai.DataBindings.Clear();
            txtLoaiKyTinhLai.DataBindings.Add("Text", bS, "LoaiKyTinhLai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DMKyLaiTKData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DMKyLaiTKData.ThemDMKyLaiTK(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDMKyLaiTK()
        {
            return m_DMKyLaiTKData.LuuDMKyLaiTK();
        }
        #endregion 
    }
}
