using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colP : ICell
    {
        // Cột P cho row object
        public string Col { get { return "P"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_DonGiaNhanCong";
        public string formula(string[] args)
        {
            return $"=W{args[0]}*{args[1]}";
        }
    }
}
