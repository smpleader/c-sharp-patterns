using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Đơn giá gốc máy khác theo công việc
    public class colJMayKhac : ACell
    {
        public colJMayKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "THM_GiaGocMayKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}!I{args[0]}"; // Cột I: giá gốc máy khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}_{hmId}!I{args[0]}"; // Cột I: giá gốc máy khác
        }
    }
}
