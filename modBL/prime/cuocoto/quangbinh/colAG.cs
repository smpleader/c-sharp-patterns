using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colAG : ACell
    {
        public colAG(Option opt) : base(opt)
        {
        }
        public override string CName => "AG";
        public override string UName => "CuocOto_QuangBinh_DinhMucVanChuyen10mDau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước cho vật liệu</para>
        /// <para> Tham số 2 là giá trị đầu vào từ biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(AF{args[0]}<=0;0;{args[1]})"; // Cột AF: cự ly chi phí vận chuyển nội bộ
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=IF(AF{args[0]}<=0;0;{args[1]})"; // Cột AF: cự ly chi phí vận chuyển nội bộ
        }
    }
}
