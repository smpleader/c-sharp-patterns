using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tên máy
    /// </summary>
    public class colCMay : ACell
    {
        public colCMay(Option opt) : base(opt)
        {
        }

        public override string CName => "C";
        public override string UName => "PTVT_TenMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng giá máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!C{args[0]}"; // Cột C: Tên máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!C{args[0]}";
        }
    }
}
