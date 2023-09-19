using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.dongiatonghop
{
    public class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "DGTH_DonGiaCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng chi phí sau thuế công việc trong bảng chiết tính</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.CHIET_TINH}'!I{args[0]}"; //Cột I: thành tiền chi phí sau thuế của công việc trong bảng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.CHIET_TINH}_{hmId}'!I{args[0]}"; //Cột I: thành tiền chi phí sau thuế của công việc trong bảng
        }
    }
}
