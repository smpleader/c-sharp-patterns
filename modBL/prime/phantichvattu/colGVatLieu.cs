using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Hệ số điều chỉnh vật liệu
    /// </summary>
    public class colGVatLieu : ACell
    {
        public colGVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "PTVT_HeSoDieuChinhVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!V{args[0]}"; // Cột V: khối lượng vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}_{hmId}'!V{args[0]}";
        }
    }
}
