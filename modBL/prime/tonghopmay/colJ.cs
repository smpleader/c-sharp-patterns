using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Đơn giá gốc máy
    internal class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "THM_GiaGoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy trong bảng Giá máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!E{args[0]}";
        }
    }
}
