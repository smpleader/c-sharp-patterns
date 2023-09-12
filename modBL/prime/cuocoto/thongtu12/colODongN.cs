using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    /// <summary>
    /// Các dòng tiếp theo tính cước cho vật liệu 
    /// </summary>
    public class colODongN : ACell
    {
        public colODongN(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocOto_TT12_CuLyNhoHonBang60KMDongCuocTiepTheo";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc tính cước vật liệu </para>
        /// <para> Tham số 3 là bằng chỉ số dòng tham số 2 trừ đi 1 </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(SUM(L{args[0]}:L{args[1]})<=60;L{args[1]}-M{args[1]}-N{args[1]};50-SUM(O{args[0]}:O{args[2]}))";
        }
    }
}
