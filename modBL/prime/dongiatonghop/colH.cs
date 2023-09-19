using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.dongiatonghop
{
    public class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "DGTH_ThanhTienCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng ĐGTH</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=F{args[0]}*G{args[0]}"; //Cột F: khối lượng, cột G: đơn giá
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=F{args[0]}*G{args[0]}"; //Cột F: khối lượng, cột G: đơn giá
        }
    }
}
