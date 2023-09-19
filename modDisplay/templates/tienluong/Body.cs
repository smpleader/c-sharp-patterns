﻿using modDisplay;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;


namespace modDisplay.templates.tienluong
{
    internal class Body : APosition
    {
        public Dictionary<int, AdditionalRow> additionalRows = new Dictionary<int, AdditionalRow>();
        public Dictionary<int, Group> groups = new Dictionary<int, Group>();
        public Dictionary<int, Row> rows = new Dictionary<int, Row>();
        public override string Name { get { return "Body"; } }
        public Body(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet) : base(gridControl, worksheet, workingsheet) 
        {
            start = 6;
        }

        public void bindInWoringsheet()
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();
            List<int> indexGroups = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsGroupObject(masksheet, indexRow))
                {
                    indexGroups.Add(indexRow);
                    continue;
                }
                if (Helper.IsRowObject(masksheet, indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
                if (Helper.IsAdditionalRowObject(masksheet, indexRow))
                {
                    indexAdditionalRows.Add(indexRow);
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < indexGroups.Count; i++)
            {
                groups[indexGroups[i]] = new Group(gridControl, masksheet, workingsheet, indexGroups[i]);
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
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(gridControl, masksheet, workingsheet, indexAdditionalRows[i]);
                additionalRows[indexAdditionalRows[i]].bind();
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(gridControl, masksheet, workingsheet, indexRow);
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
        /// <summary>
        /// Xác định vị trí của row object -> bind data từ masksheet tới workingsheet
        /// </summary>
        /// <param name="row">Dòng mà có dữ liệu thay đổi</param>
        public override void bindInMaskSheet(int row)
        {
        
        }
        public override void bind(bool maskToWorking = true)
        {
            List<int> indexAdditionalRows = new List<int>();
            List<int> indexRows = new List<int>();
            List<int> indexGroups = new List<int>();

            for (int indexRow = start; indexRow <= end; indexRow++)
            {
                if (Helper.IsGroupObject(masksheet, indexRow))
                {
                    indexGroups.Add(indexRow);
                    continue;
                }
                if (Helper.IsRowObject(masksheet, indexRow))
                {
                    indexRows.Add(indexRow);
                    continue;
                }
                if (Helper.IsAdditionalRowObject(masksheet, indexRow))
                {
                    indexAdditionalRows.Add(indexRow);
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < indexGroups.Count; i++)
            {
                groups[indexGroups[i]] = new Group(gridControl, masksheet, workingsheet, indexGroups[i]);
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
                additionalRows[indexAdditionalRows[i]] = new AdditionalRow(gridControl, masksheet, workingsheet, indexAdditionalRows[i]);
                additionalRows[indexAdditionalRows[i]].bind();
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < indexRows.Count; i++)
            {
                int indexRow = indexRows[i];
                rows[indexRow] = new Row(gridControl, masksheet, workingsheet, indexRow);
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
        public void renderInWorkingsheet()
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
                    if (rows.TryGetValue(rowIndex, out Row row))
                    {
                        row.cellB.Range.Value2 = beginRow;
                        beginRow++;
                    }
                }
            }
        }
        public override void render(bool maskToWorking = true)
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
                    if (rows.TryGetValue(rowIndex, out Row row))
                    {
                        row.cellB.Range.Value2 = beginRow;
                        beginRow++;
                    }
                }
            }
        }
    }
}
