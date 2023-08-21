using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.vatlieu
{
    internal class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }

        public override string Col => "U";
        public override string Name => "VatLieu_TongCuoc";
        public override string formula(string[] args)
        {
            switch(Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                    return "";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return $"=SUM(M{args[0]}:S{args[0]})";
            }
            return base.formula(args);
        }
    }
}
