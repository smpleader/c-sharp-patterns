using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Đơn giá TB vật liệu khác theo công việc
    internal class colLVatLieuKhac : ACell
    {
        public colLVatLieuKhac(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "THVL_GiaThongBaoVatLieuKhac";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng vật liệu khác theo công việc trong bảng PTVT</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PTVT!K{args[0]}";
        }
    }
}
