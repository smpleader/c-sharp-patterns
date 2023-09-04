using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "VatLieu_CuocThuCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tổng cước trong bảng cước thủ công </para>
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
                    return $"='Cước TC'!Q{args[0]}";
            }
            return base.formula(args);
        }
    }
}
