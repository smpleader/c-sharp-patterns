using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn vị vật liệu
    public class colEVatLieu : ACell
    {
        public colEVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "THVL_DonVi";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!D{args[0]}"; // Cột D: Đơn vị vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!D{args[0]}"; // Cột D: Đơn vị vật liệu
        }
    }
}
