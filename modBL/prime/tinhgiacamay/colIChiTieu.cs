using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tinhgiacamay
{
    // Tính thành tiền chỉ tiêu sử dụng
    public class colIChiTieu : ACell
    {
        public colIChiTieu(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TinhGiaCM_TongThanhTienChiTieuSuDung";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng định mức khấu hao</para>
        /// <para> Tham số 2 chỉ số dòng định mức chi phí khác</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})";
        }
    }
}
