using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    //Tổng thành tiền giá gốc máy khác
    public class colKTongKhac : ACell
    {
        public colKTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "THM_TongThanhTienGiaGocMayKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có máy khác trong bảng THM</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có máy khác trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(K{args[0]}:K{args[1]})";
        }
    }
}
