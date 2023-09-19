using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    public class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }

        public override string CName => "Q";
        public override string UName => "THVL_GiaTBxHS";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính đơn giá TBxHS trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}*P{args[0]}"; //Cột L: Giá thông báo vật liệu, cột P: hệ số vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=L{args[0]}*P{args[0]}"; //Cột L: Giá thông báo vật liệu, cột P: hệ số vật liệu
        }
    }
}
