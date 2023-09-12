using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAB : ACell
    {
        public colAB(Option opt) : base(opt)
        {
        }

        public override string CName => "AB";
        public override string UName => "CuocOto_TT10_GiaCuocCuLyNhoHonBang10KM";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng hiện tại tính cước vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng bắt đầu tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}*X{args[1]}*Z{args[0]}";
        }
    }
}
