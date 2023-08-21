using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colQ : ICell
    {
        // Cột Q cho row object
        public string Col { get { return "Q"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_DonGiaMay";
        public string formula(string[] args)
        {
            return $"=X{args[0]}*{args[1]}";
        }
    }
}
