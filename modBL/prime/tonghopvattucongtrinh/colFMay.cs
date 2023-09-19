using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá gốc máy
    /// </summary>
    public class colFMay : ACell
    {
        public colFMay(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "TongHopVTCT_GiaGocMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng Giá máy </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!E{args[0]}"; //Cột E: giá gốc máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!E{args[0]}"; //Cột E: giá gốc máy
        }
    }
}
