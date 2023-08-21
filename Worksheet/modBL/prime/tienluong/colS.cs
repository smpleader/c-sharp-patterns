using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colS : ICell
    {
        // Cột S cho row object
        public string Col { get { return "S"; } }
        public string option { get { return ""; } }
        string ICell.Name => "CongViec_ThanhTienVatLieuPhu";

        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string formula(string[] args)
        {
            return $"=M{args[0]}*O{args[0]}";
        }
    }
}
