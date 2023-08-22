﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string Col => "L";
        public override string Name => "VatLieu_GiaTBxHS";
        public override string formula(string[] args)
        {
            return $"=J{args[0]}*K{args[0]}";
        }
    }
}
