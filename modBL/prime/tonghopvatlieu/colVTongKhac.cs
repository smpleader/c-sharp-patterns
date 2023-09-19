using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền cước vận chuyển vật liệu khác
    public class colVTongKhac : ACell
    {
        public colVTongKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "V";
        public override string UName => "THVL_TongThanhTienCuocVanChuyenVatLieuKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc đầu tiên có vật liệu khác trong bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng công việc cuối cùng có vật liệu khác trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(V{args[0]}:V{args[1]})"; // Cột V: thành tiền cước VC vật liệu khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(V{args[0]}:V{args[1]})"; // Cột V: thành tiền cước VC vật liệu khác
        }
    }
}
