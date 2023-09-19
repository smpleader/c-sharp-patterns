using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị trước thuế hạng mục chung
    /// </summary>
    public class colDHMC : ACell
    {
        public colDHMC(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiHangMucChung";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 Chỉ số dòng chi phí xây dựng lán trại nhà tạm </para>
        /// <para>Tham số 2 Chỉ số dòng chi phí hạng mục chung còn lại </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(D{args[0]}:D{args[1]});0)"; //Cột D: Giá trị trước thuế lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(D{args[0]}:D{args[1]});0)"; //Cột D: Giá trị trước thuế lán trại nhà tạm, công tác không xác định, hạng mục chung còn lại
        }
    }
}
