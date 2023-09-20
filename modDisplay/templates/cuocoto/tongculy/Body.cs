using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using AdditionalRow = modDisplay.templates.cuocoto.tongculy.row.AdditionalRow;
using Helper = modDisplay.templates.cuocoto.tongculy.row.Helper;
using Row = modDisplay.templates.cuocoto.tongculy.row.Row;

namespace modDisplay.templates.cuocoto.tongculy
{
    internal class Body : APosition
    {
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();
        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public override string Name { get { return "Body"; } }
        public Body(GridControl gridControl, IWorksheet workingsheet) : base(gridControl, workingsheet) 
        {
            start = 9;
            end = 15;
        }
        public override void bind(bool maskToWorking = true)
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= workingsheet.Rows.Length; indexRow++)
            {
                if (Helper.IsRowObject(gridControl, workingsheet, indexRow))
                {
                    indexRows.Add(indexRow);
                }
                else
                {
                    indexAdditionalRows.Add(indexRow);
                }
            }
            for (int i = 0; i < indexAdditionalRows.Count; i++)
            {
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(gridControl, workingsheet, indexAdditionalRows[i], 9);
                additionalRows[indexAdditionalRows[i]].bind();
            }
            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của vật liệu trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(gridControl, workingsheet, indexRow);
                Row vl = rows[indexRow];
                int startRow, endRow;
                int endTemplate = indexRows[indexRows.Count - 1];
                // tính toán dòng bắt đầu kết thúc
                if (i == indexRows.Count - 1)
                {
                    startRow = indexRow + 1;
                    endRow = endTemplate;
                }
                else
                {
                    if (indexRow == endTemplate)
                    {
                        startRow = indexRow;
                        endRow = indexRow;
                    }
                    else
                    {
                        startRow = indexRow + 1;
                        endRow = indexRows[i + 1] - 1;
                    }
                }
                vl.start = startRow;
                vl.end = endRow;

                // kiểm tra xem có dòng thêm dòng cước
                bool haveAdditionalLines = false;
                for (int index = startRow; index <= endRow; index++)
                {
                    if (additionalRows.ContainsKey(index))
                    {
                        haveAdditionalLines = true;
                        additionalRows[indexAdditionalRows[i]].ParentId = vl.Id;
                    }
                }
                vl.HaveAdditionalLines = haveAdditionalLines;
                vl.bind();
            }
        }

        public override void render(bool maskToWorking = true)
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
            for (int rowIndex = start; rowIndex <= end; rowIndex++)
            {
                if (rows.ContainsKey(rowIndex))
                {
                    if (rows.TryGetValue(rowIndex, out Row row))
                    {
                        row.cellA.Range.Value2 = beginRow;
                        beginRow++;
                    }
                }
            }
        }
    }
}