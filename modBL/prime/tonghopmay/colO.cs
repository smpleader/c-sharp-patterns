using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền chênh lệch giá TB cho một máy
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "THM_ThanhTienChenhLechGiaThongBao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền chênh lệch giá TB trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*N{args[0]}"; // Cột I: hao phí máy, cột N: chênh lệch giá TB
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*N{args[0]}"; // Cột I: hao phí máy, cột N: chênh lệch giá TB
        }
    }
}
