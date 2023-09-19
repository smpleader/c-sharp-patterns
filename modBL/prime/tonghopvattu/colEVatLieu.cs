using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Khối lượng vật liệu
    /// </summary>
    public class colEVatLieu : ACell
    {
        public colEVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVT_KhoiLuongVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng THVL </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TONG_HOP_VAT_LIEU}'!I{args[0]}"; //Cột I: hao phí vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TONG_HOP_VAT_LIEU}_{hmId}'!I{args[0]}";
        }
    }
}
