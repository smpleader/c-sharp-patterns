using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Giá HT máy
    /// </summary>
    public class colHMay : ACell
    {
        public colHMay(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "TongHopVT_GiaHTMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng Giá máy </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!M{args[0]}"; //Cột M: giá HT máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!M{args[0]}";
        }
    }
}
