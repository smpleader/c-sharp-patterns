using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.may
{
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "May_BuGia";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaMay)
            {
                case PPTGiaMay.NhapTay:
                case PPTGiaMay.TinhTrucTiep:
                case PPTGiaMay.NhanHeSo:
                    return "";
                case PPTGiaMay.BuGia:
                case PPTGiaMay.NhanHeSoCongBuGia:
                    return $"=SUM(I{args[0]}:K{args[0]})"; // Cột I->K: Bù NG, bù NC, bù NL
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTGiaMay)
            {
                case PPTGiaMay.NhapTay:
                case PPTGiaMay.TinhTrucTiep:
                case PPTGiaMay.NhanHeSo:
                    return "";
                case PPTGiaMay.BuGia:
                case PPTGiaMay.NhanHeSoCongBuGia:
                    return $"=SUM(I{args[0]}:K{args[0]})"; // Cột I->K: Bù NG, bù NC, bù NL
            }
            return base.formula(hmId, args);
        }
    }
}
