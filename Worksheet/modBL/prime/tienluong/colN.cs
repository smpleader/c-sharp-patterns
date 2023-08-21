using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colN : ICell
    {
        // Cột N cho row object
        public string Col { get { return "N"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_DonGiaVatLieu";
        public string formula(string[] args)
        {
            return $"=V{args[0]}*{args[1]}";
        }
    }
}
