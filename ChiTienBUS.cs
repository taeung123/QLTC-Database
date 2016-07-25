using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
using QuanLyTC.DAO;
namespace QuanLyTC.BUS
{
    class ChiTienBUS
    {
        ChiTienDAO ctd = new ChiTienDAO();

        public DataTable laydsctkctheomaND()
        {
            DataTable da = ctd.laydsctkctheomaND();
            return da;
        }
        public DataTable laydschitientheoKC(ChiTienDTO ct)
        {
            DataTable da = ctd.laydschitientheoKC(ct);
            return da;
        }
        public DataTable ktthemchitien(ChiTienDTO ct)
        {
            DataTable da = ctd.ktthemchitien(ct);
            return da;
        }
        public DataTable timkiemtheongay(string ngay)
        {
            DataTable da = ctd.timkiemtheongay(ngay);
            return da;
        }
        public DataTable timkiemtheothang(string thang, string nam)
        {
            DataTable da = ctd.timkiemtheothang(thang, nam);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay)
        {
            DataTable da = ctd.timkiemtheokhoangngay(tungay, denngay);
            return da;
        }
        public bool themchitien(ChiTienDTO ct)
        {
            bool kq = ctd.themchitien(ct);
            return kq;
        }
        public bool xoachitien(ChiTienDTO ct)
        {
            bool kq = ctd.xoachitien(ct);
            return kq;
        }
        public bool xoatoanbo()
        {
            bool kq = ctd.xoatoanbo();
            return kq;
        }
    }
}
