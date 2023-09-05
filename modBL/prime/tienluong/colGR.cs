﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    internal class colGR : ACell
    {
        public colGR(Option opt) : base(opt)
        {
        }

        // Cột R cho group object
        public override string CName => "R";
        public override string UName => "NhomCongViec_ThanhTienVatLieu";
        // return forumalation of cell
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]}, \">0\", R{args[0]}:R{args[1]})";
        }
    }
}