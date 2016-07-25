using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DAO;
using QuanLyTC.DTO;
namespace QuanLyTC.BUS
{
    class KhoanChiBUS
    {
        KhoanChiDAO kcd = new KhoanChiDAO();

        public DataTable laydskc()
        {
            DataTable da = kcd.laydskc();
            return da;
        }
        public DataTable kttrungten(KhoanChiDTO kc)
        {
            DataTable da = kcd.kttrungten(kc);
            return da;
        }
        public DataTable laydskhoanchitheodinhki(KhoanChiDTO kc)
        {
            DataTable da = kcd.laydschitientheokinhki(kc);
            return da;
        }
        public bool themkhoanchi(KhoanChiDTO kc)
        {
            bool kq = kcd.themkhoanchi(kc);
            return kq;
        }
        public bool suakhoanchi(KhoanChiDTO kc)
        {
            bool kq = kcd.suakhoanchi(kc);
            return kq;
        }
        public bool xoakhoanchi(KhoanChiDTO kc)
        {
            bool kq = kcd.xoakhoanchi(kc);
            return kq;
        }
        public bool xoatoanbo()
        {
            bool kq = kcd.xoatoanbo();
            return kq;
        }
    }
}
