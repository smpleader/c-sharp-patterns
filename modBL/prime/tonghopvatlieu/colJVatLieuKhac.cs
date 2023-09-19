using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn giá gốc vật liệu khác theo công việc
    public class colJVatLieuKhac : ACell
    {
        public colJVatLieuKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "THVL_GiaGocVatLieuKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}!I{args[0]}"; // Cột I: giá gốc vật liệu khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}_{hmId}!I{args[0]}"; // Cột I: giá gốc vật liệu khác
        }
    }
}
