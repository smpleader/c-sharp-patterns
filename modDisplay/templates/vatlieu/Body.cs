using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay.templates.vatlieu
{
    internal class Body : APosition
    {
        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public readonly int start = 5;
        public int end = 15;
        public override string Name { get { return "Body"; } }
        public Body(SpreadsheetGrid spreadsheetGrid, IWorksheet masksheet, IWorksheet workingsheet) : base(spreadsheetGrid, masksheet, workingsheet) { }
        public void bindInWoringsheet()
        {
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsRowObject(workingsheet, indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của vật liệu trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                if(!rows.Keys.Contains(indexRow))
                {
                    rows[indexRow] = new Row(spreadsheetGrid, masksheet, workingsheet, indexRow);
                }
            }
        }

        /// <summary>
        /// Xác định vị trí của row object -> bind data từ masksheet tới workingsheet
        /// </summary>
        /// <param name="row">Dòng mà có dữ liệu thay đổi</param>
        public void bindInMaskSheet(int row)
        {
            // nếu không có thì tạo mới 1 row object
            if (!rows.Keys.Contains(row))
            {
                rows[row] = new Row(spreadsheetGrid, masksheet, workingsheet, row);
            }
            rows[row].bind();
        }
        public void bindInMaskSheet()
        {
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsRowObject(masksheet , indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của vật liệu trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                if (!rows.Keys.Contains(indexRow))
                {
                    rows[indexRow] = new Row(spreadsheetGrid, masksheet, workingsheet, indexRow);
                }
                Row vl = rows[indexRow];
                vl.bind();
            }
        }

        public void renderInWorkingsheet()
        {
            // render dữ liệu và công thức ở working sheet
            foreach (Row row in rows.Values)
            {
                row.render();
            }

            // Đánh lại số  thứ tự cho các vật liệu
            int beginRow = 1;
            for (int rowIndex = start; rowIndex <= end; rowIndex++)
            {
                if (rows.ContainsKey(rowIndex))
                {
                    if (rows.TryGetValue(rowIndex, out Row row))
                    {
                        row.cellA.Range.Text = beginRow.ToString();
                        beginRow++;
                    }
                }
            }
            masksheet.Calculate();
            spreadsheetGrid.InvalidateCells();
        }

    }
}