using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Đơn giá vật liệu
    /// </summary>
    public class CellN : ACell
    {
        public override string UniqueName { get { return "CongViec_DonGiaVatLieu"; } }
        public override string Col { get { return "N"; } }
        public string TongTienVatTu
        {
            get
            {
                string valueZ = ((Row)Row).cellZ.Range.Value;
                if (string.IsNullOrWhiteSpace(valueZ)) return "0";
                return ((Row)Row).cellZ.Range.Value.ToString();
            }
        }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        public CellN(Row r) : base(r)
        {
        }
    }
}
