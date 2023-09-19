using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá HT vật liệu
    /// </summary>
    public class colMVatLieu : ACell
    {
        public colMVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "PTVT_GiaHienTruongVatLieu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!O{args[0]}"; // Cột E: Đơn giá HT vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!O{args[0]}";
        }
    }
}
