using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    // Tính thành tiền giá HT cho một nhân công
    public class colV : ACell
    {
        public colV(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "THNC_ThanhTienGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá HT trong bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí nhân công, cột U: giá HT
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*U{args[0]}"; // Cột I: hao phí nhân công, cột U: giá HT
        }
    }
}
