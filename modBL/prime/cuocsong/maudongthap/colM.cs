using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocsong.maudongthap
{
    internal class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocSong_MauDongThap_GiaCuoc";

        /// <summary>
        /// 5 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là giá cước cự ly <= 10KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// <para> Tham số 3 là giá cước cự ly <= 20KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// <para> Tham số 4 là giá cước cự ly <= 30KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// <para> Tham số 5 là giá cước cự ly > 30KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(L12<=0;0;IF(L12<=10;48182;IF(L12<=20;59091;IF(L12<=30;66364;66364))))+IF(L12>30;(L12-30)*899;0)
            return $"=IF(L{args[0]}<=0;0;IF(L{args[0]}<=10;{args[1]};IF(L{args[0]}<=20;{args[2]};IF(L12<=30;{args[3]};{args[3]}))))+IF(L12>30;(L12-30)*{args[3]};0)";
        }
    }
}
