using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị sau thuế chi phí dự phòng yếu tố trượt giá
    /// </summary>
    public class colFTruotGia : ACell
    {
        public colFTruotGia(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_GiaTriSauThueChiPhiDuPhongYeuToTruotGia";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chí phí dự phòng cho yếu tố trượt giá</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế yếu tố trượt giá, cột E: thuế GTGT yếu tố trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+E{args[0]}"; //Cột D: Giá trị trước thuế yếu tố trượt giá, cột E: thuế GTGT yếu tố trượt giá
        }
    }
}
