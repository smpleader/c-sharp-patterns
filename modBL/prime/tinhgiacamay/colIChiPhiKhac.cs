using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tinhgiacamay
{
    // Tính thành tiền chi phí khác
    public class colIChiPhiKhac : ACell
    {
        public colIChiPhiKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TinhGiaCM_ThanhTienDinhMucChiPhiKhac";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng máy</para>
        /// <para> Tham số 2 chỉ số dòng tính định mức khấu hao</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=F{args[0]}*E{args[1]}/G{args[0]}/100";
        }
    }
}
