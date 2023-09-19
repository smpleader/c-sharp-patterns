using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    //Tổng thành tiền giá TBxHS các nhân công
    public class colRTong : ACell
    {
        public colRTong(Option opt) : base(opt)
        {
        }

        public override string CName => "R";
        public override string UName => "THNC_TongThanhTienGiaThongBaoxHeSo";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THNC</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THNC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";R{args[0]}:R{args[1]})"; // Cột A: chưa có tên cột, cột R: thành tiền giá TBxHS
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";R{args[0]}:R{args[1]})"; // Cột A: chưa có tên cột, cột R: thành tiền giá TBxHS
        }
    }
}
