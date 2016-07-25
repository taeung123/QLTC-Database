using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class ChiTienDTO
    {
        private int _MaCT;
        private int _MaKC;      
        private int _MaND;    
        private DateTime _NgayChi;    
        private float _SoTien;     
        private string _MoTa;
        public int MaCT
        {
            get { return _MaCT; }
            set { _MaCT = value; }
        }
        public int MaKC
        {
            get { return _MaKC; }
            set { _MaKC = value; }
        }
        public int MaND
        {
            get { return _MaND; }
            set { _MaND = value; }
        }
        public DateTime NgayChi
        {
            get { return _NgayChi; }
            set { _NgayChi = value; }
        }
        public float SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public ChiTienDTO() { }
        public ChiTienDTO(int MaCT,int MaKC,int MaND,DateTime NgayChi,float SoTien,string MoTa) 
        {
            _MaCT = MaCT;
            _MaKC = MaKC;
            _MaND = MaND;
            _NgayChi = NgayChi;
            _SoTien = SoTien;
            _MoTa = MoTa;
        }

    }
}
