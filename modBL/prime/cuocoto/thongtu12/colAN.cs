using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu12
{
    public class colAN : ACell
    {
        public colAN(Option opt) : base(opt)
        {
        }

        public override string CName => "AN";
        public override string UName => "CuocOto_TT12_GiaVanChuyenSauKhiDieuChinh";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=AL{args[0]}*AM{args[0]}";
        }
    }
}
