using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.laocai
{
    // Dòng đầu tiên tính cước vật liệu 
    public class colODong1 : ACell
    {
        public colODong1(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocTC_LaoCai_ThanhTienDongCuocDau";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //N10*(J10+(K10+IF(I10<=10;0;L10*ROUNDUP((I10-10)/10;0)))*M10)
            return $"=N{args[0]}*(J{args[0]}+(K{args[0]}+IF(I{args[0]}<=10;0;L{args[0]}*ROUNDUP((I{args[0]}-10)/10;0)))*M{args[0]})";
        }
    }
}
