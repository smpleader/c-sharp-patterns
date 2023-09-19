using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Khối lượng nhân công
    /// </summary>
    public class colENhanCong : ACell
    {
        public colENhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVTCT_KhoiLuongNhanCong";

        /// <summary>
        /// #1/ tham số
        /// <para> Chỉ số dòng nhân công trong bảng THNC </para>
        /// #2/ n tham số
        /// <para> số lượng hạng mục công trình</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            if (args.Length == 1)
            {
                return $"='{SheetName.TONG_HOP_NHAN_CONG}'!I{args[0]}"; //Cột I: hao phí nhân công
            }
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_NHAN_CONG}'!I{args[i]}+"; //Cột I: hao phí nhân công
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
                return $"='{SheetName.TONG_HOP_NHAN_CONG}_{hmId}'!I{args[0]}"; //Cột I: hao phí nhân công
            }
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_NHAN_CONG}_{hmId}'!I{args[i]}+"; //Cột I: hao phí nhân công
                }
                string formula = tmp.TrimEnd('+');
                formula += ")";
                return formula;
            }
        }
    }
}
