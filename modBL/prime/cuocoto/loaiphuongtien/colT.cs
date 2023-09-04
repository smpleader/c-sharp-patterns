using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    internal class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }
        public override string CName => "T";
        public override string UName => "CuocOto_LoaiPhuongTien_TongCuoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng lương ngày công bốc dỡ </para>
        /// <para> Tham số 2 là chỉ số dòng vật liệu tính cước </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]} + P{args[0]} + R{args[0]} + S{args[0]}";
        }
    }
}
