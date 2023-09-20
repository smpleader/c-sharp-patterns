using modDisplay.templates.tienluong.row.header;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.tienluong.row
{
    public class Header : ARowObject
    {
        public Header(GridControl gridControl, IWorksheet workingsheet, int id) : base(gridControl, workingsheet)
        {
            Id = id;
            cellB = new CellB(this);
        }
        /// <summary>
        /// Tên công trình hoặc tên hạng mục
        /// </summary>
        public CellB cellB { get; set; }
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
