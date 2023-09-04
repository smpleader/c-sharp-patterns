using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    internal class colGL : ACell
    {
        public colGL(Option opt) : base(opt)
        {
        }

        // Cột L cho row object
        public override string CName => "L";
        public override string UName => "CuocOto_LoaiPhuongTien_ThanhTienChiPhiVanChuyen";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng phạm vi <= 1000m </para>
        /// <para> Tham số 2 là chỉ số dòng phạm vi > 7km </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(L{args[0]}:L{args[1]})";
        }
    }
}
