using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colU : ICell
    {
        // Cột U cho row object
        public string Col { get {return "U"; } }
        public string option { get { return ""; } }
        public string Name => "CongViec_ThanhTienMay";
      
        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string formula(string[] args)
        {
            return $"=M{args[0]}*Q{args[0]}";
        }
    }
}
