using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using HeaderRow = modDisplay.templates.cuocoto.tongculy.row.Header;
namespace modDisplay.templates.cuocoto.tongculy
{
    internal class Header : APosition
    {
        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();
        public override string Name { get { return "Header"; } }
        public Header(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet) : base(gridControl, worksheet, workingsheet) { }
        public override void bind(bool maskToWorking = true)
        {
            // todo: Lưu giá trị của header tới global state
            // Tên công trình và hạng mục
            headers[2] = new HeaderRow(gridControl, masksheet, workingsheet, 2);
            headers[3] = new HeaderRow(gridControl, masksheet, workingsheet, 3);

            // Lương nhân công bốc dỡ
            headers[4] = new HeaderRow(gridControl, masksheet, workingsheet, 4);
            // Thuế VAT
            headers[5] = new HeaderRow(gridControl, masksheet, workingsheet, 5);
            // Hệ số điều chỉnh
            headers[6] = new HeaderRow(gridControl, masksheet, workingsheet, 6);

            foreach (var item in headers)
            {
                item.Value.bind();
            }
        }

        public override void render(bool maskToWorking = true)
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
            foreach (var item in headers)
            {
                item.Value.render();
            }
        }
    }
}
