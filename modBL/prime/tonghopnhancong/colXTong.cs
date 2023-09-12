using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    //Tổng thành tiền chênh lệch giá HT các nhân công
    public class colXTong : ACell
    {
        public colXTong(Option opt) : base(opt)
        {
        }

        public override string CName => "X";
        public override string UName => "THNC_TongThanhTienChenhLechGiaHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THNC</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";X{args[0]}:X{args[1]})";
        }
    }
}
