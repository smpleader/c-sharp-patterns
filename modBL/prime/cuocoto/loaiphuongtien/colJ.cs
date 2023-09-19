using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    internal class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }
        public override string CName => "J";
        public override string UName => "CuocOto_LoaiPhuongTien_TongCuLy";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng bắt đầu trong phạm vi </para>
        /// <para> Tham số 2 là chỉ số dòng kết thúc trong phạm vi </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(J{args[0]}:J{args[1]})"; // Cột J: Cự ly theo các phạm vi
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(J{args[0]}:J{args[1]})"; // Cột J: Cự ly theo các phạm vi
        }
    }
}
