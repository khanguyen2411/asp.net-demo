using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Nhanvien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        
        public float luong { get; set; }

        public float thuong { get; set; }

        public float thucnhan { get; set; }


        public Nhanvien(string _manv, string _hoten, float _luong, float _thuong)
        {
            this.manv = _manv;
            this.hoten = _hoten;
            this.luong = _luong;
            this.thuong = _thuong;
            this.thucnhan = _luong + _thuong;
        }
    }
}