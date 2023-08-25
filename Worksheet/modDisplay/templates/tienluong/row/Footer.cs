using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.Utility;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Footer : ARowObject
    {
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "CongViec_ThanhTienVatLieu" },
            { "S", "CongViec_ThanhTienVatLieuPhu" },
            { "T", "CongViec_ThanhTienNhanCong" },
            { "U", "CongViec_ThanhTienMay" },
        };
        public Footer(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet)
        {
            ws = spreadsheetGrid;
            this.worksheet = worksheet;
            Id = 16;
            start = 6;
        }
        /// <summary>
        /// Tổng hạng mục
        /// </summary>
       public IRange A { get { return this.Cell("A"); } }
       
       public IRange R { get { return this.Cell("R"); } }
       
       public IRange S { get { return this.Cell("S"); } }
        
       public IRange T { get { return this.Cell("T"); } }
        
       public IRange U { get { return this.Cell("U"); } }

        /// <summary>
        /// Tổng thành tiền vật liệu
        /// </summary>
        public decimal TongThanhTienVatLieu
        {
            get
            {
                return (decimal)R.Value2;
            }
        }

        /// <summary>
        /// Tổng thành tiền vật liệu phụ
        /// </summary>
        public decimal TongThanhTienVatLieuPhu
        {
            get
            {
                return (decimal)S.Value2;
            }
        }

        /// <summary>
        /// Tổng thành tiền nhân công
        /// </summary>
        public decimal TongThanhTienNhanCong
        {
            get
            {
                return (decimal)T.Value2;
            }
        }

        /// <summary>
        /// Tổng thành tiền máy
        /// </summary>
        public decimal TongThanhTienMay
        {
            get
            {
                return (decimal)U.Value2;
            }
        }
        
        public void bind()
        {
            Id = this.FindIndexRowFooter(ws,worksheet, start);
            end = Id - 1;
        }

        public void render()
        {
            // todo: render lại khi thêm hoặc xóa dòng
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                var range = worksheet.Range[colName + Id];
                ws.SetCellValue(range, string.Format(modBL.Container.Get(aliasUniqueName[colName]).formula(parameters)));
                ws.InvalidateCell(range.Row, range.Column);
            }
        }
    }
}
