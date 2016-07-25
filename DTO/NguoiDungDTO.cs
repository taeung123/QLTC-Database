using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class NguoiDungDTO
    {
        #region Khai Báo

        private int _MaND;   
        private string _TenND;    
        private string _TenDN;   
        private string _MatKhau;    
        private DateTime _NgaySinh; 
        private string _GioiTinh;   
        private string _DiaChi;

        //Properties
        public int MaND
        {
            get { return _MaND; }
            set { _MaND = value; }
        }
        public string TenND
        {
            get { return _TenND; }
            set { _TenND = value; }
        }
        public string TenDN
        {
            get { return _TenDN; }
            set { _TenDN = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public NguoiDungDTO() { }
        public NguoiDungDTO(int MaND, string TenND, string TenDN, string MatKhau, DateTime NgaySinh, string GioiTinh, string DiaChi)
        {
            _MaND = MaND;
            _TenND = TenND;
            _TenDN = TenDN;
            _MatKhau = MatKhau;
            _NgaySinh = NgaySinh;
            _GioiTinh = GioiTinh;
            _DiaChi = DiaChi;
        }


        #endregion

    }
}
