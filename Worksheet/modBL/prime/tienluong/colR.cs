using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colR : ACell
    {
        public colR(Option opt) : base(opt)
        {
        }

        // Cột R cho row object
        public override string CName => "R";
        public override string UName => "CongViec_ThanhTienVatLieu";
        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=M{args[0]}*N{args[0]}";
        }
    }
}
