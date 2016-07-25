using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
namespace QuanLyTC.DAO
{
    class NguoiDungDAO
    {
       // NguoiDungDTO ndd = new NguoiDungDTO();
        Connect con = new Connect();
        public DataTable laydsnddangnhap(NguoiDungDTO nd)
        {
            string sql = "select *from NguoiDung where TenDN='"+nd.TenDN+"' and MatKhau='"+nd.MatKhau+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable laydsndtheomaND(int MaND)
        {
            string sql = "select MaND as'Mã ND',TenND as 'Tên ND',TenDN as 'Tên ĐN',MatKhau as 'Mật Khẩu',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DiaChi as 'Địa Chỉ' from NguoiDung where MaND='"+MaND+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable laydsnd()
        {
            string sql = "select MaND as'Mã ND',TenND as 'Tên ND',TenDN as 'Tên ĐN',MatKhau as 'Mật Khẩu',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DiaChi as 'Địa Chỉ' from NguoiDung";
            DataTable da = con.table(sql);
            return da;
        }
        public bool themND(NguoiDungDTO nd)
        {
            nd.MaND = matutang();
            string sql = "insert into NguoiDung values('"+nd.MaND+"',N'"+nd.TenND+"',N'"+nd.TenDN+"',N'"+nd.MatKhau+"','"+nd.NgaySinh+"',N'"+nd.GioiTinh+"',N'"+nd.DiaChi+"')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool suaND(NguoiDungDTO nd)
        {
            string sql = "update NguoiDung set TenND = N'"+nd.TenND+"',TenDN = N'"+nd.TenDN+"',MatKhau = N'"+nd.MatKhau+"',NgaySinh='"+nd.NgaySinh+"',GioiTinh = N'"+nd.GioiTinh+"',DiaChi = N'"+nd.DiaChi+"'where MaND = '"+nd.MaND+"'";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoaND(NguoiDungDTO nd)
        {
            string sql = "delete from NguoiDung where MaND='"+nd.MaND+"'";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            int ma = 1;
            string sql = "select*from NguoiDung ";
            DataTable da = con.table(sql);
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
