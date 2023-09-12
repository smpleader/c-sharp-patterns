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
        public Body(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet) { }
        public override void bind()
        {
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsRowObject(spreadsheetGrid, worksheet, indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của vật liệu trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(spreadsheetGrid, worksheet, indexRow);
                Row vl = rows[indexRow];
                vl.bind();
            }
        }

        public override void render()
        {
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
                        spreadsheetGrid.SetCellValue(row.colA.Range, beginRow.ToString());
                        beginRow++;
                    }
                }
            }
            worksheet.Calculate();
            spreadsheetGrid.InvalidateCells();
        }

    }
}