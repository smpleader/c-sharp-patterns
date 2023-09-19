using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.may
{
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "May_GiaTBxHS";

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
                case PPTGiaMay.BuGia:
                case PPTGiaMay.TinhTrucTiep:
                case PPTGiaMay.NhanHeSo:
                    return "";
                case PPTGiaMay.NhanHeSoCongBuGia:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá thông báo, cột G: hệ số
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTGiaMay)
            {
                case PPTGiaMay.NhapTay:
                case PPTGiaMay.BuGia:
                case PPTGiaMay.TinhTrucTiep:
                case PPTGiaMay.NhanHeSo:
                    return "";
                case PPTGiaMay.NhanHeSoCongBuGia:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá thông báo, cột G: hệ số
            }
            return base.formula(hmId, args);
        }
    }
}
