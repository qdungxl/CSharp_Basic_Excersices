﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonBanXe
{
    public class KhachHang
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return Ten;
        }
    }
}
