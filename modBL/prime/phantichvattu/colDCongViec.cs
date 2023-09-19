using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn vị công việc
    /// </summary>
    public class colDCongViec : ACell
    {
        public colDCongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "PTVT_DonViCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!E{args[0]}"; //Cột E: đơn vị công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!E{args[0]}";
        }
    }
}
