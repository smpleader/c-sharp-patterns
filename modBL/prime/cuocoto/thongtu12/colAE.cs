using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    public class colAE : ACell
    {
        public colAE(Option opt) : base(opt)
        {
        }

        public override string CName => "AE";
        public override string UName => "CuocOto_TT12_GiaCuocCuLyNhoHonBang60KM";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng hiện tại tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=R{args[0]}*Z{args[1]}*AB{args[0]}";
        }
    }
}
