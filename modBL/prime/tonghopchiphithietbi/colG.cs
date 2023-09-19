using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    public class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "THCPTB_DonGiaSauThue";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}+F{args[0]}"; // Cột E: Đơn giá trước thuế, cột F: Đơn giá thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=E{args[0]}+F{args[0]}"; // Cột E: Đơn giá trước thuế, cột F: Đơn giá thuế VAT
        }
    }
}
