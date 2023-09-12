using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.bugia
{
    // Tính thành tiền tổng giá gốc nhân công
    public class colKTong : ACell
    {
        public colKTong(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "TongHopTL_BuGia_TongThanhTienGiaGocNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THTL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THTL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(K{args[0]}:K{args[1]})"; // Cột K: thành tiền giá gốc nhân công
        }
    }
}
