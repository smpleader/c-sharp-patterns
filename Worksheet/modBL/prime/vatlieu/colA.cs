﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colA : ICell
    {
        public string option { get { return ""; } }
        public string Col => "A";
        public string Name => "VatLieu_KhongCoTen";
        public string formula(string[] args)
        {
            return "";
        }
    }
}
