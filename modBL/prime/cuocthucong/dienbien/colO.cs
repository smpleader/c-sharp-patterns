using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dienbien
{
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocTC_DienBien_CuLyQuyDoi";

        /// <summary>
        /// n tham số
        /// <para> Tham số là số lượng dòng tính cước cho một vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //K10*M10*N10+K11*M11*N11+K12*M12*N12
            var tmp = $"=";
            for (var i = 0; i < args.Length; i++)
            {
                tmp += $"K{args[i]}*M{args[i]}*N{args[i]}+";
            }
            var formula = tmp.TrimEnd('+');
            return formula;
        }
    }
}
