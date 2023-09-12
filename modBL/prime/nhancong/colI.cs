using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.nhancong
{
    public class colI : ACell
    {
        public colI(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "NhanCong_GiaHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng thành tiền lương ngày công trong Bảng tính giá NC </para>
        /// <para> Tham số 2 chỉ số dòng tính đơn giá nhân công </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            switch (Option.PPTGiaNhanCong)
            {
                case PPTGiaNhanCong.NhapTay:
                    return $"=F{args[0]}";
                case PPTGiaNhanCong.TinhTrucTiep:
                    return $"='{SheetName.TINH_GIA_NHAN_CONG}'!Q{args[0]}";
                case PPTGiaNhanCong.NhanHeSo:
                    return $"=F{args[0]}*G{args[0]}";
            }
            return base.formula(args);
        }
    }
}
