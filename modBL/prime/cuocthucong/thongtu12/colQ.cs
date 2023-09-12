using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.thongtu12
{
    internal class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        public override string CName => "Q";
        public override string UName => "CuocTC_TT12_TongCuoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //H9*IF(H14>0;((M14+N14+O14+O14*(J14-1)+O14*(L14-1)+IF(H14>10;(H14-10)*P14/10+(H14-10)*P14/10*(J14-1)+(H14-10)*P14/10*(L14-1);0))/F14);0)
            return $"= H9*IF(H{args[0]}>0;((M{args[0]}+N{args[0]}+O{args[0]}+O{args[0]}*(J{args[0]}-1)+O{args[0]}*(L{args[0]}-1)+IF(H{args[0]}>10;(H{args[0]}-10)*P{args[0]}/10+(H{args[0]}-10)*P{args[0]}/10*(J{args[0]}-1)+(H{args[0]}-10)*P{args[0]}/10*(L{args[0]}-1);0))/F{args[0]});0)";
        }
    }
}
