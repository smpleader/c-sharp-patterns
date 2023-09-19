using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá HT nhân công
    /// </summary>
    public class colNNhanCong : ACell
    {
        public colNNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "PTVT_ThanhTienGiaHienTruongNhanCong";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; M{args[0]})"; // Cột F: Định mức nhân công, cột G: Hệ số nhân công, cột M: Giá HT nhân công
        }
    }
}
