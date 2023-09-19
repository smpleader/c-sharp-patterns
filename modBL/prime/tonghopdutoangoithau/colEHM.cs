using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Thuế GTGT hạng mục
    /// </summary>
    public class colEHM : ACell
    {
        public colEHM(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "GGTXD_ThueGiaTriGiaTangHangMuc";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng hạng mục tương ứng trong bảng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*I{args[0]}"; //Cột D: Giá trị trước thuế, cột I: Tỷ lệ hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*I{args[0]}"; //Cột D: Giá trị trước thuế, cột I: Tỷ lệ hạng mục
        }
    }
}
