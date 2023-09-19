using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Thuế giá trị gia tăng hạng mục
    /// </summary>
    public class colD : ACell
    {
        public colD(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THCPXD_ThueGiaTriGiaTang";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 chỉ số dòng tính thuế giá trị gia tăng hạng mục</para>
        /// <para>Tham số 2 chỉ số dòng giá trị thuế giá trị gia tăng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=C{args[0]}*'{SheetName.THONG_TIN}'!E{args[1]}"; // Cột C: chi phí xây dựng trước thuế, cột E: Thuế giá trị gia tăng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=C{args[0]}*'{SheetName.THONG_TIN}_{hmId}'!E{args[1]}"; // Cột C: chi phí xây dựng trước thuế, cột E: Thuế giá trị gia tăng
        }
    }
}
