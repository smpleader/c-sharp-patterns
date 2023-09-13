using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "VatLieu_GiaHienTruong";
        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                    return $"=F{args[0]}+M{args[0]}";
                case PPTGiaVatLieu.NhanHeSo:
                    return $"=H{args[0]}";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return $"=F{args[0]}+N{args[0]}";
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=H{args[0]}+N{args[0]}";
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                    return $"=F{args[0]}+M{args[0]}";
                case PPTGiaVatLieu.NhanHeSo:
                    return $"=H{args[0]}";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return $"=F{args[0]}+N{args[0]}";
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=H{args[0]}+N{args[0]}";
            }
            return base.formula(args);
        }
    }
}
