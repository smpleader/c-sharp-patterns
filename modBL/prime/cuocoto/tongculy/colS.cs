using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.tongculy
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }
        public override string CName => "S";
        public override string UName => "CuocOto_TongCuLy_ThanhTienChiPhiBocDo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước của vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(X4*Q{args[0]}+R{args[0]})*E{args[0]}";
        }
    }
}
