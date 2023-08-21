using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colO : ICell
    {
        // Cột O cho row object
        public string Col { get { return "O"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_DonGiaVatLieuPhu";
        public string formula(string[] args)
        {
            return $"=V{args[0]}*{args[1]}";
        }
    }
}
