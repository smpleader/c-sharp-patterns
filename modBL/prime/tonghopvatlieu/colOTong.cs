using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền chênh lệch giá TB các vật liệu
    public class colOTong : ACell
    {
        public colOTong(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "THVL_TongThanhTienChenhLechGiaThongBao";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";O{args[0]}:O{args[1]})"; // Cột A: chưa có tên cột, cột O: thành tiền chênh lệch giá TB
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";O{args[0]}:O{args[1]})"; // Cột A: chưa có tên cột, cột O: thành tiền chênh lệch giá TB
        }
    }
}
