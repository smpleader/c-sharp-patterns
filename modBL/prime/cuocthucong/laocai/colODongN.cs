using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocthucong.laocai
{
    // Các dòng tiếp theo tính cước cho vật liệu 
    public class colODongN : ACell
    {
        public colODongN(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocTC_LaoCai_ThanhTienDongCuocTiepTheo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            //N11*(J11+L11*ROUNDUP(I11/10;0))
            return $"=N{args[0]}*(J{args[0]}+L{args[0]}*ROUNDUP(I{args[0]}/10;0))";
        }
    }
}
