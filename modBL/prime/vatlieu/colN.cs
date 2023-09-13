using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    public class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "VatLieu_TongCuoc";

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
                case PPTGiaVatLieu.NhanHeSo:
                    return "";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=SUM(I{args[0]}:L{args[0]})";
            }
            return base.formula(args);
        }
        public override string formula( string hmId,string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                case PPTGiaVatLieu.NhanHeSo:
                    return "";
                case PPTGiaVatLieu.CongCuocVanChuyen:
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=SUM(I{args[0]}:L{args[0]})";
            }
            return base.formula(args);
        }
    }
}
