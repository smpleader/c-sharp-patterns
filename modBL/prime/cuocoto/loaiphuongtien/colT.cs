using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }
        public override string CName => "T";
        public override string UName => "CuocOto_LoaiPhuongTien_TongCuoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}+P{args[0]}+R{args[0]}+S{args[0]}"; // Cột L: tổng thành tiền, cột P: thành tiền chi phí bốc dỡ, cột R: thành tiền định mức hao hụt, cột S: cước khác
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=L{args[0]}+P{args[0]}+R{args[0]}+S{args[0]}"; // Cột L: tổng thành tiền, cột P: thành tiền chi phí bốc dỡ, cột R: thành tiền định mức hao hụt, cột S: cước khác
        }
    }
}
