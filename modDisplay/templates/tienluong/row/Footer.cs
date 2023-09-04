using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.tienluong.row
{
    internal class Footer : ARowObject
    {
        Dictionary<string, string> aliasUniqueName = new Dictionary<string, string>() {
            { "R", "CongViec_TongThanhTienVatLieu" },
            { "S", "CongViec_TongThanhTienVatLieuPhu" },
            { "T", "CongViec_TongThanhTienNhanCong" },
            { "U", "CongViec_TongThanhTienMay" },
        };
        public Footer(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet)
        {
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
            Id = this.FindIndexRowFooter(spreadsheetGrid, worksheet, start);
            end = Id - 1;
        }

        public void render()
        {
            // todo: render lại khi thêm hoặc xóa dòng
            string[] parameters = new string[2] { start.ToString(), end.ToString() };
            foreach (string colName in aliasUniqueName.Keys)
            {
                var range = worksheet.Range[colName + Id];
                BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
                spreadsheetGrid.SetCellValue(range, string.Format(modBLContainer.Get(aliasUniqueName[colName]).formula(parameters)));
                spreadsheetGrid.InvalidateCell(range.Row, range.Column);
            }
        }
    }
}
