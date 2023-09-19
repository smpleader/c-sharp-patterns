using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Đơn giá máy
    /// </summary>
    public class CellQ : ACell
    {
        public override string UniqueName { get { return "CongViec_DonGiaMay"; } }
        public override string Col { get { return "Q"; } }
        public string TongTienVatTu
        {
            get
            {
                string valueAC = ((Row)Row).cellAC.Range.Value;
                if (string.IsNullOrWhiteSpace(valueAC)) return "0";
                return ((Row)Row).cellAC.Range.Value.ToString();
            }
        }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        public CellQ(Row r) : base(r)
        {
        }
    }
}
