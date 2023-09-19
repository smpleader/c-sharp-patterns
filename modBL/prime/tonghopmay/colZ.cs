using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền chênh lệch giá HT cho một máy
    public class colZ : ACell
    {
        public colZ(Option opt) : base(opt)
        {
        }

        public override string CName => "Z";
        public override string UName => "THM_ThanhTienChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá HT trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*Y{args[0]}"; // Cột I: hao phí máy, cột Y: chênh lệch giá HT máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*Y{args[0]}"; // Cột I: hao phí máy, cột Y: chênh lệch giá HT máy
        }
    }
}
