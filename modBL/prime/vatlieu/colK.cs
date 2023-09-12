using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    public class colK : ACell
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
            switch (Option.PPTCuocTC)
            {
                case PPTCuocTC.TheoTT12_2021:
                case PPTCuocTC.TheoTT10_2019:
                    return $"='{SheetName.CUOC_THU_CONG}'!Q{args[0]}";
                case PPTCuocTC.TheoDM588_2014:
                    return $"='{SheetName.CUOC_THU_CONG}'!M{args[0]}";
                case PPTCuocTC.MauLaoCai:
                    return $"='{SheetName.CUOC_THU_CONG}'!P{args[0]}";
                case PPTCuocTC.MauDienBien:
                    return $"='{SheetName.CUOC_THU_CONG}'!S{args[0]}";
                case PPTCuocTC.MauCuocTCChung:
                    return $"='{SheetName.CUOC_THU_CONG}'!O{args[0]}";
                case PPTCuocTC.TheoDM1778:
                    return $"='{SheetName.CUOC_THU_CONG}'!R{args[0]}";
            }
            return base.formula(args);
        }
    }
}
