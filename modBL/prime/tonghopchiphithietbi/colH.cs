using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    /// <summary>
    /// Thành tiền trước thuế
    /// </summary>
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "THCPTB_ThanhTienTruocThue";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*E{args[0]}"; // Cột D: Số lượng, cột E: Đơn giá trước thuế
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*E{args[0]}"; // Cột D: Số lượng, cột E: Đơn giá trước thuế
        }
    }
}
