using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Khối lượng máy
    /// </summary>
    public class colEMay : ACell
    {
        public colEMay(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVT_KhoiLuongMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng THM </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TONG_HOP_MAY}'!I{args[0]}"; //Cột I: hao phí máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TONG_HOP_MAY}_{hmId}'!I{args[0]}";
        }
    }
}
