using modBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.vatlieu
{
    internal class colJ : ACell
    {
        public colJ(Option opt) : base(opt)
        {
        }

        public override string CName => "J";
        public override string UName => "VatLieu_GiaThongBao";
    }
}
