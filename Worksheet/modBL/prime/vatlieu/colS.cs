﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colS : ICell
    {
        public string option { get { return ""; } }
        public string Col => "S";
        public string Name => "VatLieu_CuocBien";
        public string formula(string[] args)
        {
            return "";
        }
    }
}