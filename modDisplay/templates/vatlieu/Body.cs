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
        public override void bind(bool maskToWorking = true)
        {
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsRowObject( maskToWorking ? masksheet:workingsheet, indexRow))
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
                Row vl = rows[indexRow];
                vl.bind(maskToWorking);
            }
        }

        public override void render(bool maskToWorking = true)
        {
            // render
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
                        row.colA.Range.Text = beginRow.ToString();
                        beginRow++;
                    }
                }
            }
            masksheet.Calculate();
            spreadsheetGrid.InvalidateCells();
        }

    }
}