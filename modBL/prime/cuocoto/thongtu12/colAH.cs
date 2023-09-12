using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    public class colAH : ACell
    {
        public colAH(Option opt) : base(opt)
        {
        }

        public override string CName => "AH";
        public override string UName => "CuocOto_TT12_ThanhTienBocLen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(AG{args[0]}*AJ3;0)";
        }
    }
}
