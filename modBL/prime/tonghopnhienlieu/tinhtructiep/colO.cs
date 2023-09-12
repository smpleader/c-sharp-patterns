using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhienlieu.tinhtructiep
{
    // Tính thành tiền chênh lệch giá HT cho một nhiên liệu
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "TongHopNL_TinhTT_ThanhTienChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhiên liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*N{args[0]}"; // Cột I: Hao phí nhiên liệu, cột N: chênh lệch giá HT nhiên liệu
        }
    }
}
