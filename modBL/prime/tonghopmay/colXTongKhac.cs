using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    //Tổng thành tiền giá HT máy khác
    public class colXTongKhac : ACell
    {
        public colXTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "X";
        public override string UName => "THM_TongThanhTienGiaHienTruongMayKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có máy khác trong bảng THM</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có máy khác trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(X{args[0]}:X{args[1]})"; // Cột X: thành tiền giá HT máy khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(X{args[0]}:X{args[1]})"; // Cột X: thành tiền giá HT máy khác
        }
    }
}
