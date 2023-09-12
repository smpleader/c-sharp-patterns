using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.theo588
{
    public class colPDong1 : ACell
    {
        // Dòng đầu tiên tính cước vật liệu 
        public colPDong1(Option opt) : base(opt)
        {
        }

        public override string CName => "P";
        public override string UName => "CuocOto_Theo588_ThanhTienDongCuocDau";

        /// <summary>
        /// n tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2->n là chỉ số các dòng cước tiếp theo</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            string formula = $"=J{args[0]}*O{args[0]}";
            for (var i = 0; i < args.Length-1; i++)
            {
                formula += $"+P{args[i+1]}";
            }
            return formula;
        }
    }
}
