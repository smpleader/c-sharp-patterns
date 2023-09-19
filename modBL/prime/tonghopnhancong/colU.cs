using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    public class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }

        public override string CName => "U";
        public override string UName => "THNC_GiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu trong bảng Giá NC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!I{args[0]}"; // Cột I: giá hiện trường
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!I{args[0]}"; // Cột I: giá hiện trường
        }
    }
}
