using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocsong.mauchung
{
    public class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "CuocSong_MauChung_GiaCuoc";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// <para> Tham số 2 là giá cước cự ly <= 30KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// <para> Tham số 3 là giá cước cự ly > 30KM theo bậc hàng. Giá trị nằm trong file biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //IF(L10<=0;0;IF(L10<=30;43025;43025))+IF(L10>30;(L10-30)*295;0)
            return $"=IF(L{args[0]}<=0;0;IF(L{args[0]}<=30;{args[1]};{args[1]}))+IF(L{args[0]}>30;(L{args[0]}-30)*{args[2]};0)"; // Cột L: cự ly
        }
    }
}
