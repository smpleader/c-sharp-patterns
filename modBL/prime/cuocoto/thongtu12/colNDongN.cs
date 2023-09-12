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
    public class colNDongN : ACell
    {
        public colNDongN(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "CuocOto_TT12_CuLyNhoHonBang10KMDongCuocTiepTheo";

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
            return $"=IF(SUM(L{args[0]}:L{args[1]})<=10;L{args[1]}-M{args[1]};9-SUM(N{args[0]}:N{args[2]}))";
        }
    }
}
