using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colAD : ACell
    {
        public colAD(Option opt) : base(opt)
        {
        }
        public override string CName => "AD";
        public override string UName => "CuocOto_QuangBinh_ThanhTienHaoHutHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Z{args[0]}*AC{args[0]}";
        }
    }
}
