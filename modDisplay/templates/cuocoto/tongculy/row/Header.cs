using modDisplay.templates.cuocoto.tongculy.row.header;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;


namespace modDisplay.templates.cuocoto.tongculy.row
{
    public class Header : ARowObject
    {
        public Header(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id) : base(gridControl, worksheet, workingsheet)
        {
            Id = id;
            cellA = new CellA(this);
            cellX = new CellX(this);
        }
        /// <summary>
        /// <para>A2: Tên công trình</para>
        /// <para>A3: Tên hạng mục</para>
        /// </summary>
        public CellA cellA { get; set; }

        /// <summary>
        /// <para>X4: Lương nhân công bốc dỡ</para>
        /// <para>X5: Thuế VAT</para>
        /// <para>X6: Hệ số điều chỉnh</para>
        /// </summary>
        public CellX cellX { get; set; }

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
