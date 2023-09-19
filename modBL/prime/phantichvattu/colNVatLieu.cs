using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Thành tiền đơn giá HT vật liệu
    /// </summary>
    public class colNVatLieu : ACell
    {
        public colNVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "PTVT_ThanhTienGiaHienTruongVatLieu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]}; G{args[0]}; M{args[0]})"; // Cột F: Định mức vật liệu, cột G: Hệ số vật liệu, cột M: Giá HT vật liệu
        }
    }
}
