using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "VatLieu_GiaHienTruong";
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                    return $"=J{args[0]}+T{args[0]}";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return $"=J{args[0]}+U{args[0]}";
                case PPTGiaVatLieu.NhanHeSo:
                    return $"=J{args[0]}*K{args[0]}";
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=L{args[0]}+U{args[0]}";
            }
            return base.formula(args);
        }
    }
}
