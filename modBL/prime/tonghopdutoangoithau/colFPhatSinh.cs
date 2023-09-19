using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh
    /// </summary>
    public class colFPhatSinh : ACell
    {
        public colFPhatSinh(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiDuPhongCongViecPhatSinh";

        /// <summary>
        /// 1 tham số
        /// <para> chỉ số dòng chi phí dự phòng cho yếu tố khối lượng công việc phát sinh</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh, cột E: thuế GTGT công việc phát sinh
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh, cột E: thuế GTGT công việc phát sinh
        }
    }
}
