using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tên máy
    public class colDMay : ACell
    {
        public colDMay(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "THM_TenMay";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!C{args[0]}";
        }
    }
}
