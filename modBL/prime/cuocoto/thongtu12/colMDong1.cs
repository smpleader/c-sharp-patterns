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
    public class colMDong1 : ACell
    {
        public colMDong1(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocOto_TT12_CuLyNhoHonBang1KMDongCuocDau";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=MIN(L{args[0]};1)";
        }
    }
}
