using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Tổng định mức nhiên liệu
    public class colGNL : ACell
    {
        public colGNL(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "BuGiaCM_TongDinhMucNhienLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhiên liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(E{args[0]};F{args[0]})";
        }
    }
}
