using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAIDong1 : ACell
    {
        // Dòng đầu tiên tính cước vật liệu 
        public colAIDong1(Option opt) : base(opt)
        {
        }

        public override string CName => "AI";
        public override string UName => "CuocOto_TT10_ThanhTienCuocVanChuyenDongCuocDau";

        /// <summary>
        /// n tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2->n là chỉ số các dòng cước tiếp theo</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            string formula = $"=(M{args[0]}*AA{args[0]})+(N{args[0]}*AB{args[0]})+(O{args[0]}*AC{args[0]})+AH{args[0]}";
            for (var i = 0; i < args.Length-1; i++)
            {
                formula += $"+AI{args[i+1]}";
            }
            return formula;
        }
    }
}
