using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Thành tiền giá HT máy
    /// </summary>
    public class colIMay : ACell
    {
        public colIMay(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopVT_ThanhTienGiaHienTruongMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng Tổng hợp vật tư</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*H{args[0]}"; //Cột E: khối lượng máy, cột H: giá HT máy
        }
    }
}
