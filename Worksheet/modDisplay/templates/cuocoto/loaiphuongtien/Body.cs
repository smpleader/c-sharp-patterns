using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using Worksheet.modDisplay.templates.cuocoto.loaiphuongtien.row;
using Worksheet.modDisplay.templates.cuocoto.tongculy.row;
using AdditionalRow = Worksheet.modDisplay.templates.cuocoto.loaiphuongtien.row.AdditionalRow;
using Row = Worksheet.modDisplay.templates.cuocoto.loaiphuongtien.row.Row;

namespace Worksheet.modDisplay.templates.cuocoto.loaiphuongtien
{
    internal class Body : APosition
    {
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();

        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public readonly int start = 5;
        public int end = 15;
        public override string Name { get { return "Body"; } }
        public Body(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet) { }
        public override void bind()
        {
            for (int indexRow = start; indexRow <= worksheet.Rows.Length; indexRow++)
            {
                if (Helper.IsRowObject(spreadsheetGrid, worksheet, indexRow))
                {
                    int parentId = indexRow;
                    rows[indexRow] = new Row(spreadsheetGrid, worksheet, indexRow);
                    Row vl = rows[indexRow];
                    vl.start = indexRow + 1;
                    vl.end = indexRow + 3;
                    vl.bind();

                    // dòng cước phạm vi <= 1000m
                    indexRow++;
                    additionalRows[indexRow] = new AdditionalRow(spreadsheetGrid, worksheet, indexRow, parentId);
                    additionalRows[indexRow].bind();

                    // dòng cước phạm vi <= 7km
                    indexRow++;
                    additionalRows[indexRow] = new AdditionalRow(spreadsheetGrid, worksheet, indexRow, parentId);
                    additionalRows[indexRow].bind();

                    // dòng cước phạm vi > 7km
                    indexRow++;
                    additionalRows[indexRow] = new AdditionalRow(spreadsheetGrid, worksheet, indexRow, parentId);
                    additionalRows[indexRow].bind();
                }
            }
        }

        public override void render()
        {
            foreach (Row row in rows.Values)
            {
                row.render();
            }
            foreach (AdditionalRow additionalRow in additionalRows.Values)
            {
                additionalRow.render();
            }

            // Đánh lại số  thứ tự cho các vật liệu
            int beginRow = 1;
            for (int rowIndex = start; rowIndex <= worksheet.Rows.Length; rowIndex++)
            {
                if (rows.ContainsKey(rowIndex))
                {
                    if (rows.TryGetValue(rowIndex, out Row row))
                    {
                        spreadsheetGrid.SetCellValue(row.A, beginRow.ToString());
                        beginRow++;
                    }
                }
            }
            worksheet.Calculate();
            spreadsheetGrid.InvalidateCells();
        }

    }
}