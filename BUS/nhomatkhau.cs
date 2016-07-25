using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DAO;
namespace QuanLyTC.BUS
{
    class nhomatkhau
    {
        taikhoan tk = new taikhoan();
        public DataTable dstk()
        {
            DataTable da = tk.dstk();
            return da;
        }
        public bool sua(int maTK, string tenTK, string matkhau)
        {
            bool kq = tk.sua(maTK, tenTK, matkhau);
            return kq;
        }
        public bool xoa(int maTK)
        {
            bool kq = tk.xoa(maTK) ;
            return kq ;
        }
        public bool xoatoanbo()
        {
            bool kq = tk.xoatoanbo();
            return kq;
        }
             
    }
}
