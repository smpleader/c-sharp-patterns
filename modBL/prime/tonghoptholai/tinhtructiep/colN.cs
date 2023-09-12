using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghoptholai.tinhtructiep
{
    public class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "TongHopTL_TinhTT_ChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhân công trong bảng phụ</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}-J{args[0]}"; // Cột L: Giá HT, cột J: Giá gốc
        }
    }
}
