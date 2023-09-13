using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    public class colI : ACell
    {
        public colI(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "VatLieu_CuocOto";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tổng cước trong bảng cước ô tô </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTCuocOto)
            {
                case PPTCuocOto.TheoTongCuLy:
                    return $"='{SheetName.CUOC_OTO}'!X{args[0]}";
                case PPTCuocOto.TheoLoaiPhuongTien:
                    return $"='{SheetName.CUOC_OTO}'!T{args[0]}";
                case PPTCuocOto.MauTinhCaoBang:
                    return $"='{SheetName.CUOC_OTO}'!V{args[0]}";
                case PPTCuocOto.MauTinhCaoBangThem:
                    return $"='{SheetName.CUOC_OTO}'!W{args[0]}";
                case PPTCuocOto.MauTinhQuangBinh:
                    return $"='{SheetName.CUOC_OTO}'!AK{args[0]}";
                case PPTCuocOto.TT12:
                    return $"='{SheetName.CUOC_OTO}'!AO{args[0]}";
                case PPTCuocOto.TT10:
                    return $"='{SheetName.CUOC_OTO}'!AL{args[0]}";
                case PPTCuocOto.Theo588:
                    return $"='{SheetName.CUOC_OTO}'!S{args[0]}";
                case PPTCuocOto.QuangNam38_2021:
                    return $"='{SheetName.CUOC_OTO}'!T{args[0]}";
                case PPTCuocOto.QuangNam24_22022:
                    return $"='{SheetName.CUOC_OTO}'!T{args[0]}";
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTCuocOto)
            {
                case PPTCuocOto.TheoTongCuLy:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!X{args[0]}";
                case PPTCuocOto.TheoLoaiPhuongTien:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!T{args[0]}";
                case PPTCuocOto.MauTinhCaoBang:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!V{args[0]}";
                case PPTCuocOto.MauTinhCaoBangThem:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!W{args[0]}";
                case PPTCuocOto.MauTinhQuangBinh:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!AK{args[0]}";
                case PPTCuocOto.TT12:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!AO{args[0]}";
                case PPTCuocOto.TT10:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!AL{args[0]}";
                case PPTCuocOto.Theo588:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!S{args[0]}";
                case PPTCuocOto.QuangNam38_2021:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!T{args[0]}";
                case PPTCuocOto.QuangNam24_22022:
                    return $"='{SheetName.CUOC_OTO}_{hmId}'!T{args[0]}";
            }
            return base.formula(args);
        }
    }
}
