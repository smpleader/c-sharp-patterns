﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colP : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "=W{0}*{1}";
        }
        // return value of cell
        public string fml(string[] args)
        {
            throw new NotImplementedException();
        }
        public decimal val()
        {
            return 0;
        }
    }
}
