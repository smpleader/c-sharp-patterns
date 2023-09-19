using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá TB máy
    /// </summary>
    public class colGMay : ACell
    {
        public colGMay(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "TongHopVTCT_GiaTBMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng Giá máy </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!F{args[0]}"; //Cột F: giá TB máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!F{args[0]}"; //Cột F: giá TB máy
        }
    }
}
