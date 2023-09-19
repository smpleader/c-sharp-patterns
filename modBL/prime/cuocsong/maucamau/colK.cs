using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocsong.maucamau
{
    public class colK : ACell
    {
        public colK(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "CuocSong_MauCaMau_QuyDoiCuLy";

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
            //IF(J10<=0;0;IF(J10<=30;J10*932;30*932))+IF(J10>30;(J10-30)*330;0)  
            return $"=IF(J{args[0]}<=0;0;IF(J{args[0]}<=30;J{args[0]}*{args[1]};30*{args[1]}))+IF(J{args[0]}>30;(J{args[0]}-30)*{args[2]};0)"; //Cột J: Cự ly
        }
    }
}
