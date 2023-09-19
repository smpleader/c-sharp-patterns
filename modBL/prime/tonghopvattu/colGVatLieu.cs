using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattu
{
    /// <summary>
    /// Giá TB vật liệu
    /// </summary>
    public class colGVatLieu : ACell
    {
        public colGVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "TongHopVT_GiaTBVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá VL </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!F{args[0]}"; //Cột F: giá TB vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!F{args[0]}";
        }
    }
}
