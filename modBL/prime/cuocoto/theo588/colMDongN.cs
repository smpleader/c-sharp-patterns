using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.theo588
{
    // Các dòng tiếp theo tính cước cho vật liệu 
    public class colMDongN : ACell
    {
        public colMDongN(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocOto_Theo588_DinhMucCaMayDongCuocTiepTheo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=M{args[0]}";
        }
    }
}
