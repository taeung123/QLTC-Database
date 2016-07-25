using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class taikhoanDTO
    {
        int _maTK;
        string _tenTK;
        string _matkhau;
        public int MaTK
        {
            get { return _maTK; }
            set { _maTK = value; }
        }


        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }


        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public taikhoanDTO() { }
        public taikhoanDTO(int maTK, string tenTK, string matkhau)
        {
            _maTK = maTK;
            _tenTK = tenTK;
            _matkhau = matkhau;
        }
             
    }
}
