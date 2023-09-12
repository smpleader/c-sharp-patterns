using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    /// <summary>
    /// Dòng đầu tiên tính cước vật liệu 
    /// </summary>
    public class colNDong1 : ACell
    {
        public colNDong1(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "CuocOto_TT12_CuLyNhoHonBang10KMDongCuocDau";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(L{args[0]}<10;L{args[0]}-M{args[0]};9)";
        }
    }
}
