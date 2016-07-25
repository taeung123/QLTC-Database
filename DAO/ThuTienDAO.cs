using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
namespace QuanLyTC.DAO
{
    class ThuTienDAO
    {
        Connect con = new Connect();
        public DataTable laydsctkttheomaND()
        {
            string sql = "select ct.MaTT as 'Mã thu tiền',kt.TenKT as 'Tên KT',ct.NgayThu as 'Ngày thu',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from ThuTien ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND ";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable laydsthutientheomaKT(ThuTienDTO tt)
        {
            string sql = "select* from ThuTien where MaKT = '"+tt.MaKT+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable ktthemthutien(ThuTienDTO tt)
        {
            string sql = "select * from ThuTien where MaKT = '"+tt.MaKT+"' and NgayThu = '"+tt.NgayThu+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheongayTT(string ngay)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from ThuTien ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and ct.NgayThu = '" + ngay + "' ";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheothang(string thang,string nam)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from ThuTien ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and MONTH(ct.NgayThu) = '" + thang + "'and YEAR(ct.NgayThu) = '" + nam + "' ";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from ThuTien ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and ct.NgayThu >= '" + tungay + "' and ct.NgayThu <= '" + denngay + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public bool themthutien(ThuTienDTO ct)
        {
            ct.MaTT = matutang();
            string sql = "insert into ThuTien values('" + ct.MaTT + "',N'" + ct.MaKT + "',N'" + ct.MaND + "',N'" + ct.NgayThu + "','" + ct.SoTien + "',N'" + ct.MoTa + "')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoathutien(ThuTienDTO ct)
        {
            string sql = "delete from ThuTien where MaTT='" + ct.MaTT + "'";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoatoanbo()
        {
            string sql = "delete from ThuTien";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from ThuTien ";
            DataTable da = con.table(sql);
            int ma = 1;
            for (int i = 0; i < da.Rows.Count; i++)
            {
                if (int.Parse(da.Rows[i][0].ToString()) != ma)
                {
                    return ma;
                }
                ma++;
            }
            return ma;
        }
    }
}
