using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    //Tổng thành tiền chênh lệch giá TBxHS máy khác
    internal class colTTongKhac : ACell
    {
        public colTTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "T";
        public override string UName => "THM_TongThanhTienChenhLechGiaThongBaoxHeSoMayKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có máy khác trong bảng THM</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có máy khác trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(T{args[0]}:T{args[1]})"; // Cột T: thành tiền chênh lệch giá TBxHS máy khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(T{args[0]}:T{args[1]})"; // Cột T: thành tiền chênh lệch giá TBxHS máy khác
        }
    }
}
