using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    public class colY : ACell
    {
        public colY(Option opt) : base(opt)
        {
        }

        public override string CName => "Y";
        public override string UName => "THM_ChenhLechGiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=W{args[0]}-J{args[0]}";
        }
    }
}
