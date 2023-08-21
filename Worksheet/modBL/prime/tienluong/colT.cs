using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colT : ICell
    {
        // Cột T cho row object
        public string Col { get { return "T"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_ThanhTienNhanCong";
      
        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string formula(string[] args)
        {
            return $"=M{args[0]}*P{args[0]}";
        }
    }
}
