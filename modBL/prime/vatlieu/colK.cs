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
                    return $"='{SheetName.CUOC_THU_CONG}'!Q{args[0]}"; // Cột Q: Tổng cước
                case PPTCuocTC.TheoDM588_2014:
                    return $"='{SheetName.CUOC_THU_CONG}'!M{args[0]}"; // Cột M: Tổng cước
                case PPTCuocTC.MauLaoCai:
                    return $"='{SheetName.CUOC_THU_CONG}'!P{args[0]}"; // Cột P: Tổng cước
                case PPTCuocTC.MauDienBien:
                    return $"='{SheetName.CUOC_THU_CONG}'!S{args[0]}"; // Cột S: Tổng cước
                case PPTCuocTC.MauCuocTCChung:
                    return $"='{SheetName.CUOC_THU_CONG}'!O{args[0]}"; // Cột O: Tổng cước
                case PPTCuocTC.TheoDM1778:
                    return $"='{SheetName.CUOC_THU_CONG}'!R{args[0]}"; // Cột R: Tổng cước
            }
            return base.formula(args);
        }
        public override string formula(string hmId, string[] args)
        {
            switch (Option.PPTCuocTC)
            {
                case PPTCuocTC.TheoTT12_2021:
                case PPTCuocTC.TheoTT10_2019:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!Q{args[0]}"; // Cột Q: Tổng cước
                case PPTCuocTC.TheoDM588_2014:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!M{args[0]}"; // Cột M: Tổng cước
                case PPTCuocTC.MauLaoCai:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!P{args[0]}"; // Cột P: Tổng cước
                case PPTCuocTC.MauDienBien:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!S{args[0]}"; // Cột S: Tổng cước
                case PPTCuocTC.MauCuocTCChung:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!O{args[0]}"; // Cột O: Tổng cước
                case PPTCuocTC.TheoDM1778:
                    return $"='{SheetName.CUOC_THU_CONG}_{hmId}'!R{args[0]}"; // Cột R: Tổng cước
            }
            return base.formula(hmId, args);
        }
    }
}
