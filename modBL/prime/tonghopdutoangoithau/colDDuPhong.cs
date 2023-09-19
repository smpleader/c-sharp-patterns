using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị trước thuế chi phí dự phòng
    /// </summary>
    public class colDDuPhong : ACell
    {
        public colDDuPhong(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiDuPhong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chi phí dự phòng yếu tố công việc phát sinh </para>
        /// <para> Tham số 2 chỉ số dòng chi phí dự phòng yếu tố trượt giá </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(SUM(D{args[0]}:D{args[1]});0)"; //Cột D: chi phí dự phòng công việc phát sinh, chi phí dự phòng trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=ROUND(SUM(D{args[0]}:D{args[1]});0)"; //Cột D: chi phí dự phòng công việc phát sinh, chi phí dự phòng trượt giá
        }
    }
}
