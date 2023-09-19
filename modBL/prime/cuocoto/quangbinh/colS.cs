using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }
        public override string CName => "S";
        public override string UName => "CuocOto_QuangBinh_TongChiPhiVanChuyen";

        /// <summary>
        /// n tham số
        /// <para> Tham số là số lượng dòng tính cước cho một vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            var tmp = $"=";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"R{args[i]}+"; // Cột R: thành tiền chi phí vận chuyển
            }
            var formula = tmp.TrimEnd('+');
            return formula;
        }
        public override string formula(string hmId, string[] args)
        {
            var tmp = $"=";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"R{args[i]}+"; // Cột R: thành tiền chi phí vận chuyển
            }
            var formula = tmp.TrimEnd('+');
            return formula;
        }
    }
}
