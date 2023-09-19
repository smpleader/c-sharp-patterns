using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Tổng thành tiền giá HT máy
    /// </summary>
    public class colITongMay : ACell
    {
        public colITongMay(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopVTCT_TongThanhTienGiaHienTruongMay";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng máy đầu tiên trong bảng Tổng hợp vật tư</para>
        /// <para> Tham số 2 chỉ số dòng máy cuối cùng trong bảng Tổng hợp vật tư</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(I{args[0]}:I{args[1]});0)"; //Cột I: Giá hiện trường máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(I{args[0]}:I{args[1]});0)"; //Cột I: Giá hiện trường máy
        }
    }
}
