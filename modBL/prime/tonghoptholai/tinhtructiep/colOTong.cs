using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.tinhtructiep
{
    // Tính thành tiền tổng chênh lệch giá HT các nhiên liệu
    public class colOTong : ACell
    {
        public colOTong(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "TongHopTL_TinhTT_TongThanhTienChenhLechGiaHienTruongNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THTL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THTL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(O{args[0]}:O{args[1]})"; // Cột O: thành tiền chênh lệch giá HT nhiên liệu
        }
    }
}
