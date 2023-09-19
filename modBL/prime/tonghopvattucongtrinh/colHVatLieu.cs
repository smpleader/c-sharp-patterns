using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvattucongtrinh
{
    /// <summary>
    /// Giá HT vật liệu
    /// </summary>
    public class colHVatLieu : ACell
    {
        public colHVatLieu(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "TongHopVTCT_GiaHTVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng vật liệu trong bảng giá VL </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!O{args[0]}"; //Cột O: giá HT vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!O{args[0]}"; //Cột O: giá HT vật liệu
        }
    }
}
