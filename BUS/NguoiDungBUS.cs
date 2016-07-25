using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
using QuanLyTC.DAO;
namespace QuanLyTC.BUS
{
    class NguoiDungBUS
    {
        NguoiDungDAO ndd = new NguoiDungDAO();

        //login
        public DataTable laydsnddangnhap(NguoiDungDTO nd)
        {
            DataTable da = ndd.laydsnddangnhap(nd);
            return da;
        }
        public DataTable laydsndtheomaND(int MaND)
        {
            DataTable da = ndd.laydsndtheomaND(MaND);
            return da;
        }
        public DataTable laydsnd()
        {
            DataTable da = ndd.laydsnd();
            return da;
        }
        public bool themND(NguoiDungDTO nd)
        {
            bool kq = ndd.themND(nd);
            return kq;
        }
        public bool suaND(NguoiDungDTO nd)
        {
            bool kq = ndd.suaND(nd);
            return kq;
        }
        public bool xoaND(NguoiDungDTO nd)
        {
            bool kq = ndd.xoaND(nd);
            return kq;
        }
    }
}
