using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn vị vật liệu
    /// </summary>
    public class colDVatLieu : ACell
    {
        public colDVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "PTVT_DonViVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!D{args[0]}"; // Cột D: Đơn vị vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!D{args[0]}";
        }
    }
}
