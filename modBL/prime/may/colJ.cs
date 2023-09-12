using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.may
{
    public class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "May_BuNC";

        /// <summary>
        /// n tham số
        /// <para> Tham số là số lượng dòng tính cước cho một vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            string tmp = "";
            string formula = "";
            switch (Option.PPTGiaMay)
            {
                case PPTGiaMay.NhapTay:
                case PPTGiaMay.TinhTrucTiep:
                case PPTGiaMay.NhanHeSo:
                    return "";
                case PPTGiaMay.BuGia:
                case PPTGiaMay.NhanHeSoCongBuGia:
                    tmp = $"=";
                    for (var i = 0; i < args.Length; i++)
                    {
                        tmp += $"'{SheetName.BU_GIA_CA_MAY}'!L{args[i]}+";
                    }
                    formula = tmp.TrimEnd('+');
                    return formula;
                
            }
            return base.formula(args);
        }
    }
}
