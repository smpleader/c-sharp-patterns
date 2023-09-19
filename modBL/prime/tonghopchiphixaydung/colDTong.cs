using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Tổng thuế giá trị gia tăng 
    /// </summary>
    public class colDTong : ACell
    {
        public colDTong(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THCPXD_TongThueGiaTriGiaTang";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng hạng mục đầu tiên trong bảng</para>
        /// <para> Tham số 2 chỉ số dòng hạng mục cuối cùng trong bảng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(D{args[0]}:D{args[1]})"; // Cột D: thuế giá trị gia tăng hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(D{args[0]}:D{args[1]})"; // Cột D: thuế giá trị gia tăng hạng mục
        }
    }
}
