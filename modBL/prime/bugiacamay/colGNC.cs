using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.bugiacamay
{
    // Tổng định mức nhân công
    public class colGNC : ACell
    {
        public colGNC(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "BuGiaCM_TongDinhMucNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(E{args[0]};F{args[0]})";
        }
    }
}
