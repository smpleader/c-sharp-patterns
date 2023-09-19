using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá HT máy
    /// </summary>
    public class colMMay : ACell
    {
        public colMMay(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "PTVT_GiaHienTruongMay";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng giá ca máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!M{args[0]}"; // Cột M: Giá HT máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.MAY}_{hmId}'!M{args[0]}";
        }
    }
}
