using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class ColL : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "";
        }

        public string fml(string[] args)
        {
            return $"=G{args[0]}*H{args[0]}*I{args[0]}*J{args[0]}*K{args[0]}";
        }

        // return value of cell
        public decimal val()
        {
            return 0;
        }
    }
}
