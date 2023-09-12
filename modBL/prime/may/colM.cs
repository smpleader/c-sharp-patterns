using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.may
{
    public class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "May_GiaHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng máy </para>
        /// <para> Tham số 2 chỉ số dòng tính giá ca máy trong bảng tính giá CM </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaMay)
            {
                case PPTGiaMay.NhapTay:
                    return $"=F{args[0]}";
                case PPTGiaMay.BuGia:
                    return $"=F{args[0]}+L{args[0]}";
                case PPTGiaMay.TinhTrucTiep:
                    return $"='{SheetName.TINH_GIA_CA_MAY}'!I{args[0]}";
                case PPTGiaMay.NhanHeSo:
                    return $"=F{args[0]}*G{args[0]}"; ;
                case PPTGiaMay.NhanHeSoCongBuGia:
                    return $"=H{args[0]}+L{args[0]}";
            }
            return base.formula(args);
        }
    }
}
