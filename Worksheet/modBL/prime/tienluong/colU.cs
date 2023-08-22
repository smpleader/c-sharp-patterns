using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }

        // Cột U cho row object
        public override string Col { get {return "U"; } }
        public override string Name => "CongViec_ThanhTienMay";
      
        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=M{args[0]}*Q{args[0]}";
        }
    }
}
