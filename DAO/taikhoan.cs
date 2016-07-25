using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyTC.DAO
{
    class taikhoan
    {
        Connect con = new Connect();
        public DataTable dstk()
        {
            string sql = "select*from nhomk";
            DataTable da = con.table(sql);
            return da;
        }
        public bool sua(int maTK, string tenTK, string matkhau)
        {
            string sql = "insert into nhomk values('"+maTK+"','"+tenTK+"','"+matkhau+"')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoa(int maTK)
        {
            string sql = "delete from nhomk where MaTK='"+maTK+"' ";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoatoanbo()
        {
            string sql = "delete from nhomk ";
            bool kq = con.query(sql);
            return kq;
        }
    }
}
