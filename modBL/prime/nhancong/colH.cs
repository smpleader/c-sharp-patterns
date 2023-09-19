using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.nhancong
{
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "NhanCong_GiaTBxHS";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng tính đơn giá nhân công </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaNhanCong)
            {
                case PPTGiaNhanCong.NhapTay:
                case PPTGiaNhanCong.TinhTrucTiep:
                    return "";
                case PPTGiaNhanCong.NhanHeSo:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá TB, cột G: hệ số
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTGiaNhanCong)
            {
                case PPTGiaNhanCong.NhapTay:
                case PPTGiaNhanCong.TinhTrucTiep:
                    return "";
                case PPTGiaNhanCong.NhanHeSo:
                    return $"=F{args[0]}*G{args[0]}"; // Cột F: giá TB, cột G: hệ số
            }
            return base.formula(hmId, args);
        }
    }
}
