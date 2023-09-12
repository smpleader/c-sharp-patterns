using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền giá HT cho một máy
    public class colX : ACell
    {
        public colX(Option opt) : base(opt)
        {
        }

        public override string CName => "X";
        public override string UName => "THM_ThanhTienGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá HT trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*W{args[0]}";
        }
    }
}
