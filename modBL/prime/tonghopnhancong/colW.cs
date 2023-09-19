using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopnhancong
{
    public class colW : ACell
    {
        public colW(Option opt) : base(opt)
        {
        }

        public override string CName => "W";
        public override string UName => "THNC_ChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng nhân công trong bảng Giá NC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=U{args[0]}-J{args[0]}"; // Cột U: giá HT, cột J: giá gốc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=U{args[0]}-J{args[0]}"; // Cột U: giá HT, cột J: giá gốc
        }
    }
}
