using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT chi phí dự phòng yếu tố khối lượng công việc phát sinh
    /// </summary>
    public class colEPhatSinh : ACell
    {
        public colEPhatSinh(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangPhiDuPhongCongViecPhatSinh";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí dự phòng cho yếu tố khối lượng công việc phát sinh</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế chi phí dự phòng yếu tố khối lượng công việc phát sinh
        }
    }
}
