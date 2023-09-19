using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// giá trị trước thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh
    /// </summary>
    public class colDPhatSinh : ACell
    {
        public colDPhatSinh(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiDuPhongCongViecPhatSinh";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chí phí hạng mục chung</para>
        /// <para> Tham số 2 chỉ số dòng chí phí dự phòng công việc phát sinh</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=(D7+D{args[0]})*I{args[1]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, cột I: tỷ lệ chi phí dự phòng yếu tố công việc phát sinh
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=(D7+D{args[0]})*I{args[1]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, cột I: tỷ lệ chi phí dự phòng yếu tố công việc phát sinh
        }
    }
}
