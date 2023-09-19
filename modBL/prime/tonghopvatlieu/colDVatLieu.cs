using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tên vật liệu
    public class colDVatLieu : ACell
    {
        public colDVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THVL_TenVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!C{args[0]}"; // Cột C: Tên vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!C{args[0]}"; // Cột C: Tên vật liệu
        }
    }
}
