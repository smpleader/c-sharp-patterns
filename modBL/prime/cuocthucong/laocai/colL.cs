using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.laocai
{
    public class colL : ACell
    {
        public colL(Option opt) : base(opt)
        {
        }

        public override string CName => "L";
        public override string UName => "CuocTC_LaoCai_Cuoc10MTiep";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là giá cước cự ly > 10m theo nhóm hàng, hình thức vận chuyển. Giá trị nằm trong file biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(I10<=10;0;10352)
            return $"=IF(I{args[0]}<=0;0;{args[1]})";
        }
    }
}
