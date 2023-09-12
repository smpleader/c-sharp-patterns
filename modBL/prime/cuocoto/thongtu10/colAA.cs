using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAA : ACell
    {
        public colAA(Option opt) : base(opt)
        {
        }

        public override string CName => "AA";
        public override string UName => "CuocOto_TT10_GiaCuocCuLyNhoHonBang1KM";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng hiện tại tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}*W{args[1]}*Z{args[0]}";
        }
    }
}
