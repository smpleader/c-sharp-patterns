﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string Col => "J";
        public override string Name => "VatLieu_GiaThongBao";
    }
}
