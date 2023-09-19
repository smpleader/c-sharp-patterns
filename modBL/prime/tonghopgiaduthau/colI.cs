using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopgiaduthau
{
    // giá dự thầu một hạng mục
    public class colI : ACell
    {
        public colI(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THDGDT_GiaDuThau";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng đơn tổng thành tiền trong bảng đơn giá tổng hợp</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.DON_GIA_TONG_HOP}'!H{args[0]}"; // Cột H: Tổng thành tiền
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.DON_GIA_TONG_HOP}_{hmId}'!H{args[0]}"; // Cột H: Tổng thành tiền
        }
    }
}
