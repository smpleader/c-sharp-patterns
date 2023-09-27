using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;
using HeaderRow = modDisplay.templates.tienluong.row.Header;
namespace modDisplay.templates.tienluong
{
    internal class Header : APosition
    {
        public override string Name { get { return "Header"; } }
        public Header(GridControl gridControl, IWorksheet workingsheet) : base(gridControl, workingsheet) 
        {
            start = 1;
            end = 3;
        }

        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();

        public override void bindInWoringsheet()
        {
            // todo: Lưu giá trị của header tới global state
            headers[2] = new HeaderRow(gridControl, workingsheet, 2);
            headers[3] = new HeaderRow(gridControl, workingsheet, 3);
            foreach (var item in headers)
            {
                item.Value.bind();
            }
        }
        public override void renderInWorkingsheet()
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
            foreach (var item in headers)
            {
                item.Value.render();
            }
        }
        public override string GetFormula(int row, int col)
        {
            if (headers.Keys.Contains(row))
            {
                return headers[row].GetFormula(col);
            }
            return workingsheet.Range[row, col].Value;
        }
    }
}
