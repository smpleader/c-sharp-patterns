using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Khối lượng vật liệu
    /// </summary>
    public class colEVatLieu : ACell
    {
        public colEVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "TongHopVTCT_KhoiLuongVatLieu";

        /// <summary>
        /// #1/ tham số
        /// <para> Chỉ số dòng máy trong bảng THVL </para>
        /// #2/ n tham số
        /// <para> số lượng hạng mục công trình</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            if (args.Length == 1)
            {
                return $"='{SheetName.TONG_HOP_VAT_LIEU}'!I{args[0]}"; //Cột I: hao phí vật liệu
            }
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_VAT_LIEU}'!I{args[i]}+"; //Cột I: hao phí vật liệu
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
                return $"='{SheetName.TONG_HOP_VAT_LIEU}_{hmId}'!I{args[0]}"; //Cột I: hao phí vật liệu
            }
            else
            {
                string tmp = $"=SUM(";
                for (var i = 0; i < args.Length; i++)
                {
                    tmp += $"'{SheetName.TONG_HOP_VAT_LIEU}_{hmId}'!I{args[i]}+"; //Cột I: hao phí vật liệu
                }
                string formula = tmp.TrimEnd('+');
                formula += ")";
                return formula;
            }
        }
    }
}
