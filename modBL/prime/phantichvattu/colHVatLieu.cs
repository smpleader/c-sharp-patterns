using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Hao phí vật liệu theo công việc
    /// </summary>
    public class colHVatLieu : ACell
    {
        public colHVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "PTVT_HaoPhiCongViecVatLieu";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng công việc trong bảng PTVT </para>
        /// <para> Tham số 2 chỉ số dòng tính hao phí vật liệu trong bảng PTVT </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(E{args[1]}; F{args[0]}; G{args[0]})"; // Cột E: khối lượng thi công, cột F: Định mức vật liệu, cột G: hệ số diều chỉnh vật liệu
        }
    }
}
