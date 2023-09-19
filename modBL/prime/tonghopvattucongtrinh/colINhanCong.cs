using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Thành tiền giá HT nhân công
    /// </summary>
    public class colINhanCong : ACell
    {
        public colINhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopVTCT_ThanhTienGiaHienTruongNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng Tổng hợp vật tư</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*H{args[0]}"; //Cột E: khối lượng nhân công, cột H: giá HT nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=E{args[0]}*H{args[0]}"; //Cột E: khối lượng nhân công, cột H: giá HT nhân công
        }
    }
}
