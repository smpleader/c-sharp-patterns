using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Đơn giá vật liệu phụ
    /// </summary>
    public class CellO : ACell
    {
        public override string UniqueName { get { return "CongViec_DonGiaVatLieuPhu"; } }
        public override string Col { get { return "O"; } }
        public string TongTienVatTu
        {
            get
            {
                string valueAA = ((Row)Row).cellAA.Range.Value;
                if (string.IsNullOrWhiteSpace(valueAA)) return "0";
                return ((Row)Row).cellAA.Range.Value.ToString();
            }
        }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        public CellO(Row r) : base(r)
        {
            HasFormula = true;
        }
    }
}
