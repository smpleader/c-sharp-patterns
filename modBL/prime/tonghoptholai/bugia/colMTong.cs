using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    // Tính thành tiền tổng giá HT nhân công
    public class colMTong : ACell
    {
        public colMTong(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "TongHopTL_BuGia_TongThanhTienGiaHienTruongNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THTL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THTL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})"; // Cột M: thành tiền giá HT nhiên liệu
        }
    }
}
