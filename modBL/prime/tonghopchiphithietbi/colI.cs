using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphithietbi
{
    /// <summary>
    /// Thành tiền thuế giá trị gia tăng
    /// </summary>
    public class colI : ACell
    {
        public colI(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THCPTB_ThanhTienThueGiaTriGiaTang";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chi phí thiết bị</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*F{args[0]}"; // Cột D: Số lượng, cột F: Đơn giá thuế VAT
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*F{args[0]}"; // Cột D: Số lượng, cột F: Đơn giá thuế VAT
        }
    }
}
