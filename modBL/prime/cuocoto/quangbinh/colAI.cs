using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colAI : ACell
    {
        public colAI(Option opt) : base(opt)
        {
        }
        public override string CName => "AI";
        public override string UName => "CuocOto_QuangBinh_ThanhTienVanChuyenNoiBo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(AG{args[0]}+AH{args[0]})*D4";
        }
    }
}
