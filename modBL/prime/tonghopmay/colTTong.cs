using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    //Tổng thành tiền chênh lệch giá TBxHS các máy
    public class colTTong : ACell
    {
        public colTTong(Option opt) : base(opt)
        {
        }

        public override string CName => "T";
        public override string UName => "THM_TongThanhTienChenhLechGiaThongBaoxHeSo";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THM</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";T{args[0]}:T{args[1]})";
        }
    }
}
