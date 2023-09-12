using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAK : ACell
    {
        public colAK(Option opt) : base(opt)
        {
        }

        public override string CName => "AK";
        public override string UName => "CuocOto_TT10_GiaVanChuyenSauKhiDieuChinh";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=AI{args[0]}*AJ{args[0]}";
        }
    }
}
