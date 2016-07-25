using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DAO;
using QuanLyTC.DTO;
namespace QuanLyTC.BUS
{
    class ThuTienBUS
    {
        ThuTienDAO ctd = new ThuTienDAO();

        public DataTable laydsctkttheomaND()
        {
            DataTable da = ctd.laydsctkttheomaND();
            return da;
        }
        public DataTable laydstttheoKT(ThuTienDTO tt)
        {
            DataTable da = ctd.laydsthutientheomaKT(tt);
            return da;
        }
        public DataTable ktthemthutien(ThuTienDTO tt)
        {
            DataTable da = ctd.ktthemthutien(tt);
            return da;
        }
        public DataTable timkiemtheongayTT(string ngay)
        {
            DataTable da = ctd.timkiemtheongayTT(ngay);
            return da;

        }
        public DataTable timkiemtheothangTT(string thang, string nam)
        {
            DataTable da = ctd.timkiemtheothang(thang, nam);
            return da;
        }
        public DataTable timkiemtheokhoangngayTT(string tungay, string denngay)
        {
            DataTable da = ctd.timkiemtheokhoangngay(tungay, denngay);
            return da;
        }
        public bool themthutien(ThuTienDTO ct)
        {
            bool kq = ctd.themthutien(ct);
            return kq;
        }
        public bool xoathutien(ThuTienDTO ct)
        {
            bool kq = ctd.xoathutien(ct);
            return kq;

        }
        public bool xoatoanbo()
        {
            bool kq = ctd.xoatoanbo();
            return kq;

        }
    }
}
