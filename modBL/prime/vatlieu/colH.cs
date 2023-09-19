using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "VatLieu_GiaTBxHS";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tính đơn giá vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return "";
                case PPTGiaVatLieu.NhanHeSo:
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá TB, cột G: hệ số
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTGiaVatLieu)
            {
                case PPTGiaVatLieu.NhapTay:
                case PPTGiaVatLieu.CongCuocVanChuyen:
                    return "";
                case PPTGiaVatLieu.NhanHeSo:
                case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá TB, cột G: hệ số
            }
            return base.formula(hmId, args);
        }
    }
}
