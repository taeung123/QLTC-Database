using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
using QuanLyTC.DAO;
namespace QuanLyTC.BUS
{
    class KhoanThuBUS
    {
        KhoanThuDAO ktd = new KhoanThuDAO();
        public DataTable laydskt()
        {
            DataTable da = ktd.laydskt();
            return da;
        }
        public DataTable kttenkhoanthu(KhoanThuDTO kt)
        {
            DataTable da = ktd.kttenkhoanthu(kt);
            return da;
        }
        public DataTable laydskttheodinhki(KhoanThuDTO kt)
        {
            DataTable da = ktd.laydskttheodinhki(kt);
            return da;
        }
        public bool themkhoanthu(KhoanThuDTO kt)
        {
            bool kq = ktd.themkhoanthu(kt);
            return kq;
        }
        public bool suakhoanthu(KhoanThuDTO kt)
        {
            bool kq = ktd.suakhoanthu(kt);
            return kq;
        }
        public bool xoakhoanthu(KhoanThuDTO kt)
        {
            bool kq = ktd.xoakhoanthu(kt);
            return kq;
        }
        public bool xoatoanbo()
        {
            bool kq = ktd.xoatoanbo();
            return kq;
        }
    }
}
