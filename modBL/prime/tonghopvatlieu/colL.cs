using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn giá TB vật liệu
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "THVL_GiaThongBao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu trong bảng Giá VL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.VAT_LIEU}'!F{args[0]}"; // Cột F: đơn giá thông báo vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.VAT_LIEU}_{hmId}'!F{args[0]}"; // Cột F: đơn giá thông báo vật liệu
        }
    }
}
