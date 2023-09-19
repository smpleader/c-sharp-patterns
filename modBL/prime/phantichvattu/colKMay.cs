using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá TB máy
    /// </summary>
    public class colKMay : ACell
    {
        public colKMay(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "PTVT_GiaThongBaoMay";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng giá ca máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!F{args[0]}"; // Cột E: Đơn giá TB máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!F{args[0]}";
        }
    }
}
