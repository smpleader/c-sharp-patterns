using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.may
{
    public class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "May_BuNL";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tính bù giá nhiên liệu </para>
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
                    string tmp = $"=";
                    for (var i = 0; i < args.Length; i++)
                    {
                        tmp += $"'{SheetName.BU_GIA_CA_MAY}'!L{args[i]}+";
                    }
                    string formula = tmp.TrimEnd('+');
                    return formula;
            }
            return base.formula(args);
        }
    }
}
