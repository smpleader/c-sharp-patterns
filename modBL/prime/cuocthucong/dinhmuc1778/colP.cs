using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.dinhmuc1778
{
    public class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }

        public override string CName => "P";
        public override string UName => "CuocTC_DM1778_TongDinhMuc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(O12>0;L12+M12;0)+IF(O12>10;(O12-10)*N12/10;0)
            return $"=IF(O{args[0]}>0;L{args[0]}+M{args[0]};0)+IF(O{args[0]}>10;(O{args[0]}-10)*N{args[0]}/10;0)";
        }
    }
}
