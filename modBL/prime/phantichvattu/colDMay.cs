using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn vị máy
    /// </summary>
    public class colDMay : ACell
    {
        public colDMay(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "PTVT_DonViMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng giá máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!D{args[0]}"; // Cột D: Đơn vị máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!D{args[0]}";
        }
    }
}
