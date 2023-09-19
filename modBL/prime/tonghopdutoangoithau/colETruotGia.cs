using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT chi phí dự phòng yếu tố trượt giá
    /// </summary>
    public class colETruotGia : ACell
    {
        public colETruotGia(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangPhiDuPhongYeuToTruotGia";

        /// <summary>
        /// 1 tham số
        /// <para>Chỉ số dòng chí phí dự phòng cho yếu tố trượt giá</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế yếu tố trượt giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*10%"; //Cột D: Giá trị trước thuế yếu tố trượt giá
        }
    }
}
