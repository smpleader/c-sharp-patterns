using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.dongiatonghop
{
    public class colGH : ACell
    {
        public colGH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "DGTH_ThanhTienNhomCongViec";

        /// <summary>
        /// 2 tham số
        /// <para>Tham số 1 chỉ số dòng bắt đầu công việc trong nhóm</para>
        /// <para>Tham số 2 chỉ số dòng kết thúc công việc trong nhóm</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(H{args[0]}:H{args[1]})"; //Cột H: thành tiền công việc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUM(H{args[0]}:H{args[1]})"; //Cột H: thành tiền công việc
        }
    }
}
