using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAIDongN : ACell
    {
        // Các dòng tiếp theo tính cước vật liệu 
        public colAIDongN(Option opt) : base(opt)
        {
        }

        public override string CName => "AI";
        public override string UName => "CuocOto_TT10_ThanhTienCuocVanChuyenDongCuocTiepTheo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(M{args[0]}*AA{args[0]})+(N{args[0]}*AB{args[0]})+(O{args[0]}*AC{args[0]})+AH{args[0]}";
        }
    }
}
