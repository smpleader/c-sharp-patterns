using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Đơn giá HT máy
    internal class colW : ACell
    {
        public colW(Option opt) : base(opt)
        {
        }

        public override string CName => "W";
        public override string UName => "THM_GiaHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy trong bảng Giá Máy</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.MAY}'!M{args[0]}";
        }
    }
}
