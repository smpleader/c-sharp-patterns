using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền bù giá cho một máy
    public class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "THM_ThanhTienBuGia";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền bù giá trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí máy, cột U: bù giá CM
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí máy, cột U: bù giá CM
        }
    }
}
