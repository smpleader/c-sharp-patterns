using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colAA : ACell
    {
        public colAA(Option opt) : base(opt)
        {
        }
        public override string CName => "AA";
        public override string UName => "CuocOto_QuangBinh_DinhMucChiPhiBocDoHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước cho vật liệu</para>
        /// <para> Tham số 2 là giá trị đầu vào từ biểu cước</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=IF(AF{args[0]}<=0;0;{args[1]})";
        }
    }
}
