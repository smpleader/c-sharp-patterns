using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    /// <summary>
    /// Thành tiền giá trị sau thuế
    /// </summary>
    public class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "THCPTB_ThanhTienSauThue";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*G{args[0]}"; // Cột D: Số lượng, cột G: Đơn giá sau thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*G{args[0]}"; // Cột D: Số lượng, cột G: Đơn giá sau thuế
        }
    }
}
