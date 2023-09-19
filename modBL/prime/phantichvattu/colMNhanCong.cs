using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá HT nhân công
    /// </summary>
    public class colMNhanCong : ACell
    {
        public colMNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "PTVT_GiaHienTruongNhanCong";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!I{args[0]}"; // Cột I: Đơn giá HT nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!I{args[0]}";
        }
    }
}
