using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Thành tiền giá HT vật liệu
    /// </summary>
    public class colIVatLieu : ACell
    {
        public colIVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TongHopVT_ThanhTienGiaHienTruongVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng Tổng hợp vật tư</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*H{args[0]}"; //Cột E: khối lượng vật liệu, cột H: giá HT vật liệu
        }
    }
}
