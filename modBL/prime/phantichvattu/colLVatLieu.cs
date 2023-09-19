using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá TB vật liệu
    /// </summary>
    public class colLVatLieu : ACell
    {
        public colLVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "PTVT_ThanhTienGiaThongBaoVatLieu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; K{args[0]})"; // Cột F: Định mức vật liệu, cột G: Hệ số vật liệu, cột K: Giá TB vật liệu
        }
    }
}
