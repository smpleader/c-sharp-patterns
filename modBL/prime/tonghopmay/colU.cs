using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    public class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }

        public override string CName => "U";
        public override string UName => "THM_BuGia";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng bù giá máy trong bảng giá máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!L{args[0]}";
        }
    }
}
