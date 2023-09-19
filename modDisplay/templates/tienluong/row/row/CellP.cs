using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Đơn giá nhân công
    /// </summary>
    public class CellP : ACell
    {
        public override string UniqueName { get { return "CongViec_DonGiaNhanCong"; } }
        public override string Col { get { return "P"; } }
        public string TongTienVatTu
        {
            get
            {
                string valueAB = ((Row)Row).cellAB.Range.Value;
                if (string.IsNullOrWhiteSpace(valueAB)) return "0";
                return ((Row)Row).cellAB.Range.Value.ToString();
            }
        }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        public CellP(Row r) : base(r)
        {
        }
    }
}
