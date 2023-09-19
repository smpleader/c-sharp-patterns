using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    public class colF : ACell
    {
        public colF(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "THCPTB_DonGiaThueGiaTriGiaTang";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*10%"; // Cột E: Đơn giá trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=E{args[0]}*10%"; // Cột E: Đơn giá trước thuế
        }
    }
}
