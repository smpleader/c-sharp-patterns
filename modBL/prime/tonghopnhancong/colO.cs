using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    // Tính thành tiền chênh lệch giá TB cho một nhân công
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "THNC_ThanhTienChenhLechGiaThongBao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền chênh lệch giá TB trong bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*N{args[0]}"; // Cột I: Hao phí nhân công, cột N: chênh lệch giá TB
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*N{args[0]}"; // Cột I: Hao phí nhân công, cột N: chênh lệch giá TB
        }
    }
}
