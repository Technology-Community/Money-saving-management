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
    public class LaiSuatTietKiemCtrl
    {
        LaiSuatTietKiemData m_LaiSuatTietKiemData = new LaiSuatTietKiemData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_LaiSuatTietKiemData.LayLaiSuatTietKiem();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MucLaiSuat";
            cbx.ValueMember = "MaLoaiTietKiem";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LaiSuatTietKiemData.LayLaiSuatTietKiem();
            cmbColumn.DisplayMember = "Ngay";
            cmbColumn.ValueMember = "MaLoaiTietKiem";
            cmbColumn.DataPropertyName = "MaLoaiTietKiem";
            cmbColumn.HeaderText = "Ngày tính lãi";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_LaiSuatTietKiemData.LayLaiSuatTietKiem();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi (DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMucLaiSuat,
                            DateTimeInput dtNgay, 
                            ComboBoxEx cmbMaLoaiTietKiem)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LaiSuatTietKiemData.LayLaiSuatTietKiem();

            txtMucLaiSuat.DataBindings.Clear();
            txtMucLaiSuat.DataBindings.Add("Text", bS, "MucLaiSuat");

            dtNgay.DataBindings.Clear();
            dtNgay.DataBindings.Add("Value", bS, "Ngay");

            cmbMaLoaiTietKiem.DataBindings.Clear();
            cmbMaLoaiTietKiem.DataBindings.Add("SelectedValue", bS, "MaLoaiTietKiem");


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LaiSuatTietKiemData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_LaiSuatTietKiemData.ThemLaiSuatTietKiem(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuLaiSuatTietKiem()
        {
            return m_LaiSuatTietKiemData.LuuLaiSuatTietKiem();
        }
        #endregion 
    }
}
