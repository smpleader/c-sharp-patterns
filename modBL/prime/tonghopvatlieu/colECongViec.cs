using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn vị công việc
    public class colECongViec : ACell
    {
        public colECongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "E";
        public override string UName => "THVL_DonViCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc chứa vật liệu trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!E{args[0]}"; // Cột E: Đơn vị công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!E{args[0]}"; // Cột E: Đơn vị công việc
        }
    }
}
