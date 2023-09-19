using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền giá HT cho một vật liệu
    public class colX : ACell
    {
        public colX(Option opt) : base(opt)
        {
        }

        public override string CName => "X";
        public override string UName => "THVL_ThanhTienGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá HT trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*W{args[0]}"; // Cột I: hao phí vật liệu, cột W: Giá HT vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*W{args[0]}"; // Cột I: hao phí vật liệu, cột W: Giá HT vật liệu
        }
    }
}
