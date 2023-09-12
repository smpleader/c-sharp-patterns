using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền giá TB vật liệu khác
    internal class colMTongKhac : ACell
    {
        public colMTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "THVL_TongThanhTienGiaThongBaoVatLieuKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có vật liệu khác trong bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có vật liệu khác trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(M{args[0]}:M{args[1]})";
        }
    }
}
