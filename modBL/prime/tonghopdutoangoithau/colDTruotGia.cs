using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// giá trị trước thuế chi phí dự phòng yếu tố trượt giá
    /// </summary>
    public class colDTruotGia : ACell
    {
        public colDTruotGia(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiDuPhongYeuToTruotGia";

        /// <summary>
        /// 3 tham số
        /// <para>Tham số 1 chỉ số dòng chí phí xây dựng của gói thầu</para>
        /// <para>Tham số 2 chỉ số dòng chí phí hạng mục chung</para>
        /// <para>Tham số 3 chỉ số dòng chí phí dự phòng yếu tố trượt giá</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(D{args[0]}+D{args[1]})*I{args[2]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, cột I: tỷ lệ chi phí dự phòng yếu tố trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=(D{args[0]}+D{args[1]})*I{args[2]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, cột I: tỷ lệ chi phí dự phòng yếu tố trượt giá
        }
    }
}
