using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;
using Worksheet.modDisplay.templates.dinhmucnhancong.row;

namespace Worksheet.modDisplay.templates.tienluong.dinhmucnhancong
{
    internal class Body : APosition
    {
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
            List<int> indexRows = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (!Util.CellUtility.IsCellEmptyOrNull(ws, "B" + indexRow))
                {
                    indexRows.Add(indexRow);
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của nhân công trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(ws, indexRow);
                Row nc = rows[indexRow];
                nc.bind();
            }
        }

        public override void render()
        {
            foreach (Row row in rows.Values)
            {
                row.render();
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
