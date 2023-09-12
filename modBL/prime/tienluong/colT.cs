using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colT : ACell
    {
        public colT(Option opt) : base(opt)
        {
        }

        // Cột T cho row object
        public override string CName => "T";
        public override string UName => "CongViec_ThanhTienNhanCong";

        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=M{args[0]}*P{args[0]}";
        }
    }
}
