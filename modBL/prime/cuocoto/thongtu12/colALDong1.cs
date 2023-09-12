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
    public class colALDong1 : ACell
    {
        public colALDong1(Option opt) : base(opt)
        {
        }

        public override string CName => "AL";
        public override string UName => "CuocOto_TT12_ThanhTienCuocVanChuyenDongCuocDau";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            string formula = $"=(M{args[0]}*AC{args[0]})+(N{args[0]}*AD{args[0]})+(O{args[0]}*AE{args[0]})+(P{args[0]}*AF{args[0]})+AK{args[0]}";
            for (var i = 0; i < args.Length-1; i++)
            {
                formula += $"+AL{args[i+1]}";
            }
            return formula;
        }
    }
}
