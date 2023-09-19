using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn giá TB vật liệu
    /// </summary>
    public class colKVatLieu : ACell
    {
        public colKVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "PTVT_GiaThongBaoVatLieu";

        // <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!F{args[0]}"; // Cột E: Đơn giá TB vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!F{args[0]}";
        }
    }
}
