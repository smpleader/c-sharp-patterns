using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá TB máy
    /// </summary>
    public class colLMay : ACell
    {
        public colLMay(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "PTVT_ThanhTienGiaThongBaoMay";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; K{args[0]})"; // Cột F: Định mức máy, cột G: Hệ số máy, cột K: Giá TB máy
        }
    }
}
