using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopchiphixaydung
{
    /// <summary>
    /// Chi phí xây dựng sau thuế hạng mục
    /// </summary>
    public class colE : ACell
    {
        public colE(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "THCPXD_ChiPhiXayDungSauThue";

        /// <summary>
        /// 1 tham số
        /// <para>Tham số 1 chỉ số dòng tính thuế giá trị gia tăng hạng mục</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=C{args[0]}+D{args[0]}"; // Cột C: chi phí xây dựng trước thuế, cột D: Thuế giá trị gia tăng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=C{args[0]}+D{args[0]}"; // Cột C: chi phí xây dựng trước thuế, cột D: Thuế giá trị gia tăng
        }
    }
}
