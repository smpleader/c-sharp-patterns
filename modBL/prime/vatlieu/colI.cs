using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colI : ACell
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
                    return $"='Cước ô tô'!X{args[0]}";
                case PPTCuocOto.TheoLoaiPhuongTien:
                    return $"='Cước ô tô'!T{args[0]}";
                case PPTCuocOto.MauTinhCaoBang:
                    return $"='Cước ô tô'!V{args[0]}";
                case PPTCuocOto.MauTinhCaoBangThem:
                    return $"='Cước ô tô'!W{args[0]}";
                case PPTCuocOto.MauTinhQuangBinh:
                    return $"='Cước ô tô'!AK{args[0]}";
            }
            return base.formula(args);
        }
    }
}
