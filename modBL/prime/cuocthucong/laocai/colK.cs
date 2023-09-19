using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.laocai
{
    public class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "CuocTC_LaoCai_Cuoc10MDau";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là giá cước cự ly <= 10m theo nhóm hàng, hình thức vận chuyển. Giá trị nằm trong file biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(I10<=0;0;19023)
            return $"=IF(I{args[0]}<=0;0;{args[1]})";
        }
    }
}
