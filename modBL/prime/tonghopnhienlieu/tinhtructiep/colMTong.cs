using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhienlieu.tinhtructiep
{
    // Tính thành tiền tổng giá HT các nhiên liệu
    public class colMTong : ACell
    {
        public colMTong(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "TongHopNL_TinhTT_TongThanhTienGiaHienTruongNhienLieu";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THNL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THNL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"NL\";M{args[0]}:M{args[1]})"; // Cột A: State đánh dấu nhiên liệu, cột M: thành tiền giá HT nhiên liệu
        }
    }
}
