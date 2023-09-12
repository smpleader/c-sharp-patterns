using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Đơn giá HT máy khác theo công việc
    internal class colWMayKhac : ACell
    {
        public colWMayKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "W";
        public override string UName => "THM_GiaHienTruongMayKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng máy khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PTVT!M{args[0]}";
        }
    }
}
