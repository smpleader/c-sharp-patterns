using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá HT nhân công
    /// </summary>
    public class colHNhanCong : ACell
    {
        public colHNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "TongHopVTCT_GiaHTNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá NC </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!I{args[0]}"; //Cột I: giá HT nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!I{args[0]}"; //Cột I: giá HT nhân công
        }
    }
}
