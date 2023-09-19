using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền giá TB các vật liệu
    public class colMTong : ACell
    {
        public colMTong(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "THVL_TongThanhTienGiaThongBao";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";M{args[0]}:M{args[1]})"; // Cột A: chưa có tên cột, cột M: thành tiền giá thông báo vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";M{args[0]}:M{args[1]})"; // Cột A: chưa có tên cột, cột M: thành tiền giá thông báo vật liệu
        }
    }
}
