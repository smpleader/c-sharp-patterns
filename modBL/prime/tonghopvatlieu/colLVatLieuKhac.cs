using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn giá TB vật liệu khác theo công việc
    public class colLVatLieuKhac : ACell
    {
        public colLVatLieuKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "THVL_GiaThongBaoVatLieuKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}!K{args[0]}"; // Cột K: đơn giá thông báo vật liệu khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}_{hmId}!K{args[0]}"; // Cột K: đơn giá thông báo vật liệu khác
        }
    }
}
