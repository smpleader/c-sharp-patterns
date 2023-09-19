using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Khối lượng máy
    /// </summary>
    public class colEMay : ACell
    {
        public colEMay(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVTCT_KhoiLuongMay";

        /// <summary>
        /// #1/ tham số
        /// <para> Chỉ số dòng máy trong bảng THM </para>
        /// #2/ n tham số
        /// <para> số lượng hạng mục công trình</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            if(args.Length == 1)
            {
                return $"='{SheetName.TONG_HOP_MAY}'!I{args[0]}"; //Cột I: hao phí máy
            } 
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_MAY}'!I{args[i]}+"; //Cột I: hao phí máy
                }
                string formula = tmp.TrimEnd('+');
                formula += ")";
                return formula;
            }
        }
        public override string formula(string hmId, string[] args)
        {
            if (args.Length == 1)
            {
                return $"='{SheetName.TONG_HOP_MAY}_{hmId}'!I{args[0]}"; //Cột I: hao phí máy
            }
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_MAY}_{hmId}'!I{args[i]}+"; //Cột I: hao phí máy
                }
                string formula = tmp.TrimEnd('+');
                formula += ")";
                return formula;
            }
        }
    }
}
