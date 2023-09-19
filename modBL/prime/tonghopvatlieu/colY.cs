using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    public class colY : ACell
    {
        public colY(Option opt) : base(opt)
        {
        }

        public override string CName => "Y";
        public override string UName => "THVL_ChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=W{args[0]}-J{args[0]}"; // Cột W: Giá HT vật liệu, cột J: giá gốc vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=W{args[0]}-J{args[0]}"; // Cột W: Giá HT vật liệu, cột J: giá gốc vật liệu
        }
    }
}
