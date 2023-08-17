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
    internal class Body
    {
        public readonly int start = 6;
        public int end;
        public unvell.ReoGrid.Worksheet ws;
        public Dictionary<int, Group> groups = new Dictionary<int, Group>();
        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();

        public Body(unvell.ReoGrid.Worksheet worksheet)
        {
            ws = worksheet;
        }

        /// <summary>
        /// Kiểm tra cell có null hoặc empty không
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="cellAddress"></param>
        /// <returns></returns>
        static bool IsCellEmptyOrNull(unvell.ReoGrid.Worksheet worksheet, string cellAddress)
        {
            var cell = CellUtility.ConvertData<string>(worksheet[cellAddress]);
            if (cell == null || cell == "")
            {
                return true;
            }

            return string.IsNullOrEmpty(cell);
        }
        public void bind()
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();
            List<int> indexGroups = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (ws.IsMergedCell("B" + indexRow))
                {
                    indexGroups.Add(indexRow);
                }
                else
                {
                    if (IsCellEmptyOrNull(ws, "B" + indexRow) && IsCellEmptyOrNull(ws, "C" + indexRow))
                    {
                        // check công thức diễn giải khi nhập vào
                        if (!IsCellEmptyOrNull(ws, "D" + indexRow) || !IsCellEmptyOrNull(ws, "L" + indexRow))
                        {
                            indexAdditionalRows.Add(indexRow);
                        }
                    }
                    if (!IsCellEmptyOrNull(ws, "C" + indexRow))
                    {
                        string C = CellUtility.ConvertData<string>(ws["C" + indexRow]);
                        if (C != null && C.StartsWith("*"))
                        {
                            indexGroups.Add(indexRow);
                        }
                        else
                        {
                            indexRows.Add(indexRow);
                        }
                    }
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < indexGroups.Count; i++)
            {
                groups[indexGroups[i]] = new Group(indexGroups[i]);
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
                groupCV.bind(ws);
            }

            for (int i = 0; i < indexAdditionalRows.Count; i++)
            {
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(indexAdditionalRows[i]);
                additionalRows[indexAdditionalRows[i]].bind(ws);
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(indexRow);
                int endRowGroup = InGroup(indexRow) != -1 ? InGroup(indexRow) : end;
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
                cv.bind(ws);
            }
        }

        private int InGroup(int index)
        {
            foreach (Group group in groups.Values)
            {
                if (index >= group.start && index <= group.end)
                {
                    return group.Id;
                }
            }
            return -1;
        }

        public void render()
        {
            foreach (Group group in groups.Values)
            {
                group.render(ws);
            }
            foreach (Row row in rows.Values)
            {
                row.render(ws);
            }
            foreach (AdditionalRow additionalRow in additionalRows.Values)
            {
                additionalRow.render(ws);
            }

            // Đánh lại số  thứ tự cho các công việc
            int beginRow = 1;
            for (int rowIndex = start; rowIndex <= end; rowIndex++)
            {
                if (rows.ContainsKey(rowIndex))
                {
                    rows.TryGetValue(rowIndex, out Row row);
                    Row rowObject = row;
                    ws[rowObject.Address("B")] = beginRow.ToString();
                    ws.AutoFitRowHeight(rowIndex - 1, false);
                    beginRow++;
                }
            }
        }
    }
}
