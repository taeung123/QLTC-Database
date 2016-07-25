using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;

namespace QuanLyTC.DAO
{
    
    class ChiTienDAO
    {
        Connect con = new Connect();
        public DataTable laydsctkctheomaND()
        {
            string sql = "select ct.MaCT as 'Mã chi tiền',kc.TenKC as 'Tên KC',ct.NgayChi as 'Ngày chi',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from ChiTien ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND ";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable laydschitientheoKC(ChiTienDTO ct)
        {
            string sql = "select* from ChiTien where MaKC = '" + ct.MaKC + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable ktthemchitien(ChiTienDTO ct)
        {
            string sql = "select* from ChiTien where MaKC = '"+ct.MaKC+"' and NgayChi = '"+ct.NgayChi+"'";
            DataTable da = con.table(sql);
            return da;
        }

        public DataTable timkiemtheongay(string ngay)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from ChiTien ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.NgayChi ='"+ngay+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheothang(string thang,string nam)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from ChiTien ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND  and MONTH(ct.NgayChi)='"+thang+"' and YEAR(ct.NgayChi)='"+nam+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from ChiTien ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.NgayChi >= '"+tungay+"' and ct.NgayChi <= '"+denngay+"'";
            DataTable da = con.table(sql);
            return da;
        }


        public bool themchitien(ChiTienDTO ct)
        {
            ct.MaCT = matutang();
            string sql = "insert into ChiTien values('"+ct.MaCT+"',N'"+ct.MaKC+"',N'"+ct.MaND+"',N'"+ct.NgayChi+"','"+ct.SoTien+"',N'"+ct.MoTa+"')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoachitien(ChiTienDTO ct)
        {
            string sql = "delete from ChiTien where MaCTKC='"+ct.MaCT+"'";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoatoanbo()
        {
            string sql = "delete from ChiTien";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from ChiTien ";
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
