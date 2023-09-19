using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền chênh lệch giá TB vật liệu khác
    public class colOTongKhac : ACell
    {
        public colOTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "THVL_TongThanhTienChenhLechGiaThongBaoVatLieuKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có vật liệu khác trong bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có vật liệu khác trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(O{args[0]}:O{args[1]})"; // Cột O: thành tiền giá thông báo vật liệu khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(O{args[0]}:O{args[1]})"; // Cột O: thành tiền giá thông báo vật liệu khác
        }
    }
}
