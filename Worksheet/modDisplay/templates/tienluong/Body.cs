using Microsoft.Office.Interop.Excel;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;
using Worksheet.modDisplay.templates.tienluong.row;


namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Body : APosition
    {
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();
        public Dictionary<int, Group> groups = new Dictionary<int, Group>();
        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public readonly int start = 6;
        public int end;
        public override string Name { get { return "Body"; } }
        public Body(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid,  worksheet) { }
        
        public override void bind()
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();
            List<int> indexGroups = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsGroupObject(ws,worksheet,indexRow))
                {
                    indexGroups.Add(indexRow);
                    continue;
                }
                if (Helper.IsRowObject(ws, worksheet, indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
                if (Helper.IsAdditionalRowObject(ws, worksheet, indexRow))
                {
                    indexAdditionalRows.Add(indexRow);
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < indexGroups.Count; i++)
            {
                groups[indexGroups[i]] = new Group(ws, worksheet, indexGroups[i]);
                Group groupCV = groups[indexGroups[i]];
                int startGroup, endGroup;
                if (i == indexGroups.Count - 1)
                {
                    startGroup = indexGroups[i] + 1;
                    endGroup = end;
                }
                else
                {
                    if (indexGroups[i] == end)
                    {
                        startGroup = indexGroups[i];
                        endGroup = indexGroups[i];
                    }
                    else
                    {
                        startGroup = indexGroups[i] + 1;
                        endGroup = indexGroups[i + 1] - 1;
                    }
                }
                groupCV.start = startGroup;
                groupCV.end = endGroup;
                groupCV.bind();
            }

            for (int i = 0; i < indexAdditionalRows.Count; i++)
            {
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(ws, worksheet, indexAdditionalRows[i]);
                additionalRows[indexAdditionalRows[i]].bind();
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(ws, worksheet, indexRow);
                int endRowGroup = LastIndexInGroup(indexRow) != -1 ? LastIndexInGroup(indexRow) : end;
                Row cv = rows[indexRow];
                int startRow, endRow;
                // tính toán dòng bắt đầu kết thúc
                if (i == indexRows.Count - 1)
                {
                    startRow = indexRow + 1;
                    endRow = endRowGroup;
                }
                else
                {
                    if (indexRow == endRowGroup)
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
                cv.start = startRow;
                cv.end = endRow;

                // kiểm tra xem có dòng dữ liệu thêm ( Công thức diễn giải, Diễn giải khối lượng) hay không
                bool haveInterpretiveFormula = false;
                for (int index = startRow; index <= endRow; index++)
                {
                    if (additionalRows.ContainsKey(index))
                    {
                        haveInterpretiveFormula = true;
                        break;
                    }
                }
                cv.HaveInterpretiveFormula = haveInterpretiveFormula;
                cv.bind();
            }
        }

        private int LastIndexInGroup(int index)
        {
            foreach (Group group in groups.Values)
            {
                if (index >= group.start && index <= group.end)
                {
                    return group.end;
                }
            }
            return -1;
        }

        public override void render()
        {
            foreach (Group group in groups.Values)
            {
                group.render();
            }
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
                        ws.SetCellValue(row.B, beginRow.ToString());
                        ws.InvalidateCell(row.B.Row, row.B.Column);
                        beginRow++;
                    }
                }
            }
        }
    }
}
