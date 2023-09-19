using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tienluong
{
    public class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }

        // Cột N cho row object
        public override string CName => "N";
        public override string UName => "CongViec_DonGiaVatLieu";
        public override string formula(string[] args)
        {
            return $"={args[1]}*V{args[0]}"; //Cột V: hệ số điều chỉnh vật liệu
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={args[1]}*V{args[0]}"; //Cột V: hệ số điều chỉnh vật liệu
        }
    }
}
