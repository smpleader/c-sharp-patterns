using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhienlieu.bugia
{
    // Tính thành tiền tổng giá gốc các nhiên liệu
    public class colKTong : ACell
    {
        public colKTong(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "TongHopNL_BuGia_TongThanhTienGiaGocNhienLieu";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THNL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THNL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"NL\";K{args[0]}:K{args[1]})"; // Cột A: State đánh dấu nhiên liệu, cột K: thành tiền giá gốc nhiên liệu
        }
    }
}
