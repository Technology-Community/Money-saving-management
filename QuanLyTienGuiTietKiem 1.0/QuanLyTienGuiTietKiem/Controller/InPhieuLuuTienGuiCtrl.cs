using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.Editors;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class InPhieuLuuTienGuiCtrl
    {
        public static IList<InPhieuLuuTienGuiInfo> LayPhieuLuuTietKiemTheoMaSo(String MaSoTK)
        {
            InPhieuLuuTienGuiData data = new InPhieuLuuTienGuiData();
            DataTable tbl = data.LaySoTheoMa(MaSoTK);

            IList<InPhieuLuuTienGuiInfo> PhieuLuu = new List<InPhieuLuuTienGuiInfo>();

            foreach (DataRow row in tbl.Rows)
            {

                InPhieuLuuTienGuiInfo PL = new InPhieuLuuTienGuiInfo();

                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.HoTen = Convert.ToString(row["HoTen"]);
                m_KH.CMND = Convert.ToString(row["CMND"]);
                m_KH.DiaChi = Convert.ToString(row["DiaChi"]);
                m_KH.NgayCap = Convert.ToDateTime(row["NgayCap"]);

                ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);

                LaiSuatTietKiemInfo m_LS = new LaiSuatTietKiemInfo();
                m_LS.MucLaiSuat = Convert.ToInt32(row["MucLaiSuat"]);

                SoDuTietKiemInfo m_SoDuInfo = new SoDuTietKiemInfo();
                m_SoDuInfo.SoDu = Convert.ToInt64(row["SoDu"]);

                SoTietKiemInfo m_STK = new SoTietKiemInfo();
                m_STK.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);
                m_STK.NgayHieuLuc = Convert.ToDateTime(row["NgayHieuLuc"]);

                LoaiTietKiemInfo m_LTK = new LoaiTietKiemInfo();
                m_LTK.TenLoaiTietKiem = Convert.ToString(row["TenLoaiTietKiem"]);

                PL.ChiTietPhatSinhGD = m_PSGD;
                PL.KhachHang = m_KH;
                PL.LaiSuatTietKiem = m_LS;
                PL.LoaiTietKiem = m_LTK;
                PL.SoDuTietKiem = m_SoDuInfo;
                PL.SoTietKiem = m_STK;

                PhieuLuu.Add(PL);                
            }
            return PhieuLuu;
        }
    }
}
