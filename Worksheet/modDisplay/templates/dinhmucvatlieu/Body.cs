using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;
using Worksheet.modDisplay.templates.dinhmucvatlieu.row;

namespace Worksheet.modDisplay.templates.tienluong.dinhmucvatlieu
{
    internal class Body : APosition
    {
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();

        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public readonly int start = 1;
        public int end = 30;
        public override string Name { get { return "Body"; } }

        public Body(unvell.ReoGrid.Worksheet worksheet)
        {
            ws = worksheet;
        }
        
        public override void bind()
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (!Util.CellUtility.IsCellEmptyOrNull(ws, "B" + indexRow))
                {
                    if (!Util.CellUtility.IsCellEmptyOrNull(ws, "A" + indexRow))
                    {
                        indexRows.Add(indexRow);
                    }
                    else
                    {
                        indexAdditionalRows.Add(indexRow);
                    }
                }
            }

            for (int i = 0; i < indexAdditionalRows.Count; i++)
            {
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(ws, indexAdditionalRows[i]);
                additionalRows[indexAdditionalRows[i]].bind();
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(ws, indexRow);
                Row vl = rows[indexRow];
                int startRow, endRow;
                // tính toán dòng bắt đầu kết thúc
                if (i == indexRows.Count - 1)
                {
                    startRow = indexRow + 1;
                    endRow = end;
                }
                else
                {
                    if (indexRow == end)
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

                // kiểm tra xem có dòng dữ liệu thêm ( Công thức diễn giải, Diễn giải khối lượng) hay không
                bool haveSubRow = false;
                for (int index = startRow; index <= endRow; index++)
                {
                    if (additionalRows.ContainsKey(index))
                    {
                        haveSubRow = true;
                        break;
                    }
                }
                vl.HaveSubRow = haveSubRow;
                vl.bind();
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

            // Đánh lại số  thứ tự cho các công việc
            int beginRow = 1;
            for (int rowIndex = start; rowIndex <= end; rowIndex++)
            {
                if (rows.ContainsKey(rowIndex))
                {
                    if(rows.TryGetValue(rowIndex, out Row row))
                    {
                        row.B.Data = beginRow;
                        ws.AutoFitRowHeight(rowIndex - 1, false);
                        beginRow++;
                    }
                }
            }
        }
    }
}
