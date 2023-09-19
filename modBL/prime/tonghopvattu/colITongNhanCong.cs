using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Tổng thành tiền giá HT nhân công
    /// </summary>
    public class colITongNhanCong : ACell
    {
        public colITongNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopVT_TongThanhTienGiaHienTruongNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng nhân công đầu tiên trong bảng Tổng hợp vật tư</para>
        /// <para> Tham số 2 chỉ số dòng nhân công cuối cùng trong bảng Tổng hợp vật tư</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(I{args[0]}:I{args[1]});0)"; //Cột I: Giá hiện trường nhân công
        }
    }
}
