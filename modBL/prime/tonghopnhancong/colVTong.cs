using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    //Tổng thành tiền giá HT các nhân công
    public class colVTong : ACell
    {
        public colVTong(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "THNC_TongThanhTienGiaHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THNC</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";V{args[0]}:V{args[1]})";
        }
    }
}
