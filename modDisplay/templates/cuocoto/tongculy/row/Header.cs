using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.cuocoto.tongculy.row
{
    internal class Header : ARowObject
    {
        public Header(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, string hangMucId, int id) : base(spreadsheetGrid, worksheet, workingsheet, hangMucId)
        {
            Id = id;
        }
        /// <summary>
        /// <para>A2: Tên công trình</para>
        /// <para>A3: Tên hạng mục</para>
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }

        /// <summary>
        /// <para>X4: Lương nhân công bốc dỡ</para>
        /// <para>X5: Thuế VAT</para>
        /// <para>X6: Hệ số điều chỉnh</para>
        /// </summary>
        public IRange X { get { return this.Cell("X"); } }
        public void bind()
        {
            // todo: Lưu giá trị của header tới global state
        }

        public void render()
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
        }
    }
}
