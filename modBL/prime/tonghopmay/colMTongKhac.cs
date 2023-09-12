using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    //Tổng thành tiền giá TB máy khác
    public class colMTongKhac : ACell
    {
        public colMTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "THM_TongThanhTienGiaThongBaoMayKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có máy khác trong bảng THM</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có máy khác trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})";
        }
    }
}
