using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.dongiatonghop
{
    public class colFH : ACell
    {
        public colFH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "DGTH_TongThanhTienCongViec";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 chỉ số dòng bắt đầu bảng ĐGTH</para>
        /// <para>Tham số 2 chỉ số dòng kết thúc bảng ĐGTH</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(B{args[0]}:B{args[1]};\">0\";H{args[0]}:H{args[1]})"; //Cột H: thành tiền công việc
        }
    }
}
