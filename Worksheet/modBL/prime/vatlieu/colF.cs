﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colF : ACell
    {
        public colF(Option opt) : base(opt)
        {
        }
        public override string CName => "F";
        public override string UName => "VatLieu_DonVi";
    }
}
