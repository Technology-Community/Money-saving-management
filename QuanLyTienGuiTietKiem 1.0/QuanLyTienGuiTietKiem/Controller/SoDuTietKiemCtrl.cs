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
    public class SoDuTietKiemCtrl
    {
        SoDuTietKiemData m_SoDuTietKiemData = new SoDuTietKiemData();
        RutTietKiemData m_RutTietKiemData = new RutTietKiemData();

        #region Hien thi
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_SoDuTietKiemData.LaySoDuTietKiem();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "SoDu";
            cbx.DisplayMember = "MaSoTietKiem";
        }
                
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_SoDuTietKiemData.LaySoDuTietKiem();
            cmbColumn.DisplayMember = "SoDu";
            cmbColumn.DisplayMember = "MaSoTietKiem";
            cmbColumn.DataPropertyName = "MaSoTietKiem";
            cmbColumn.HeaderText = "Số dư";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_SoDuTietKiemData.LaySoDuTietKiem();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        //public void HienThi(DataGridViewX dGV,
        //                    BindingNavigator bN,
        //                    DateTimeInput dtNgayCapNhat,
        //                    TextBoxX txtSoDuDauNgay,
        //                    TextBoxX txtSoPhatSinhNo,
        //                    TextBoxX txtSoPhatSinhCo,
        //                    ComboBoxEx cmbSoHieuSoDuTietKiem)
        //{
        //    BindingSource bS = new BindingSource();
        //    bS.DataSource = m_SoDuTietKiemData.LaySoDuTietKiem();

        //    txtSoDuDauNgay.DataBindings.Clear();
        //    txtSoDuDauNgay.DataBindings.Add("Text", bS, "SoDuDauNgay");

        //    txtSoPhatSinhNo.DataBindings.Clear();
        //    txtSoPhatSinhNo.DataBindings.Add("Text", bS, "SoPhatSinhNo");

        //    txtSoPhatSinhCo.DataBindings.Clear();
        //    txtSoPhatSinhCo.DataBindings.Add("Text", bS, "SoPhatSinhCo");

        //    dtNgayCapNhat.DataBindings.Clear();
        //    dtNgayCapNhat.DataBindings.Add("Value", bS, "NgayCapNhat");

        //    cmbSoHieuSoDuTietKiem.DataBindings.Clear();
        //    cmbSoHieuSoDuTietKiem.DataBindings.Add("SelectedValue", bS, "SoHieuSoDuTietKiem");


        //    bN.BindingSource = bS;
        //    dGV.DataSource = bS;
        //}
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_SoDuTietKiemData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_SoDuTietKiemData.ThemSoDuTietKiem(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuSoDuTietKiem()
        {
            return m_SoDuTietKiemData.LuuSoDuTietKiem();
        }

        public void LuuSoDuTK(String MaLoaiTK, String MaSoTK, DateTime NgayCapNhat, float SoDu)
        {
            m_SoDuTietKiemData.LuuSoDuTK(MaLoaiTK, MaSoTK, NgayCapNhat, SoDu);
        }
        #endregion 

        #region Xoa
        public void XoaSoDuTK(String MaLoaiTK, String MaSoTK, DateTime NgayCapNhat, float SoDu)
        {
            m_SoDuTietKiemData.XoaSoDuTK(MaLoaiTK, MaSoTK, NgayCapNhat, SoDu);
        }
        #endregion 

        public void ThemVonSo(String MaSo, float SoDu, float SoTienThem)
        {
            float tong = SoDu + SoTienThem;
            m_RutTietKiemData.LuuSoDu(MaSo, tong);

        }
    }
}
