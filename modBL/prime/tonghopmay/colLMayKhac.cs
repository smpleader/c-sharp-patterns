using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Đơn giá TB vật liệu khác theo công việc
    public class colLMayKhac : ACell
    {
        public colLMayKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "THM_GiaThongBaoMayKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}!K{args[0]}"; // Cột K: giá TB máy khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}_{hmId}!K{args[0]}"; // Cột K: giá TB máy khác
        } 
    }
}
