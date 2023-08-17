
using System.Security.Cryptography;
using Worksheet.modData.Memories;
using Worksheet.modData;
using Worksheet.modData.Memories.Pointer;
using unvell.ReoGrid.Utility;
using System.Configuration;
using System.Collections.Generic;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;

        private const int StartIndexRowBody = 5;
        private int EndIndexRowBody = 16;

        public override string Name { get { return "templates/tienluong"; } }

        private Dictionary<int, ARow> objects = new Dictionary<int, ARow>();

        public ARow obj(int id = 0)
        {
            if (0 == id)
            {
                id = Display.Row;
            }

            ARow obj;

            if (!objects.TryGetValue(id, out obj))
            {
                objects[id] = new ARow(id);
            }

            return objects[id];
        }

        public override void init(string tabName)
        {
            if (Display.WB[tabName] != null)
            {
                ws = Display.WB[tabName];
            }
        }

        public override void addMenu()
        {
            Display.menuItems = new ToolStripItemCollection(Display.contextMenu,
                new ToolStripItem[]{
                    new ToolStripMenuItem("Congviec 2"),
                });
        }
        public override void loadData()
        {
            ws.HideColumns(5, 7);
            renderFormula();
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow > StartIndexRowBody && selectedIndexRow < EndIndexRowBody)
            {
                // bắt đầu thêm công việc
                DangThemCongViec = true;

                objects[selectedIndexRow] = new Row(selectedIndexRow);

                Row selectedRow = (Row)objects[selectedIndexRow];
                // mã công việc
                ws[selectedRow.Address("C")] = "AG.11111";
                // tên công việc
                ws[selectedRow.Address("D")] = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
                // đơn vị
                ws[selectedRow.Address("E")] = "m3";

                // HSDC vật liệu
                ws[selectedRow.Address("V")] = 1;
                // HSDC nhân công
                ws[selectedRow.Address("W")] = 1;
                // HSDC máy
                ws[selectedRow.Address("X")] = 1;

                // thông tin đơn giá
                ws[selectedRow.Address("Y")] = "DinhMuc_2021XD_D12";

                // tổng giá tất cả vật liệu của công việc 
                ws[selectedRow.Address("Z")] = 685204;
                // tổng giá tất cả vật liệu phụ của công việc 
                ws[selectedRow.Address("AA")] = 0;
                // tổng giá tất cả nhân công của công việc 
                ws[selectedRow.Address("AB")] = 288111;
                // tổng giá tất cả máy của công việc 
                ws[selectedRow.Address("AC")] = 70230;

                // set màu chữ thành không màu
                ws.SetRangeStyles(selectedRow.Address("Z") + ":" + selectedRow.Address("AC"), new WorksheetRangeStyle()
                {
                    Flag = PlainStyleFlag.TextColor,
                    TextColor = Color.Transparent,
                });
            }
            renderFormula();
            DangThemCongViec = false;
        }
       
        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!(obj(Display.Row) is Group))
                    {
                        Display.Cell.IsReadOnly = true;
                    }
                    break;
                case "R":
                case "S":
                case "T":
                case "U":
                    Display.Cell.IsReadOnly = true;
                    break;
            }
        }
        bool DangThemCongViec = false;
        public override void cellDataChanged()
        {
            if (!DangThemCongViec)
            {
                DangThemCongViec = true;

                renderFormula();

                DangThemCongViec = false;
            }
        }

        /// <summary>
        /// Kiểm tra cell có null hoặc empty không
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="cellAddress"></param>
        /// <returns></returns>
        static bool IsCellEmptyOrNull(unvell.ReoGrid.Worksheet worksheet, string cellAddress)
        {
            var cell = CellUtility.ConvertData<string>(worksheet[cellAddress]) ;
            if (cell == null || cell == "")
            {
                return true;
            }

            return string.IsNullOrEmpty(cell);
        }

        private void renderFormula()
        {
            // Đánh lại số  thứ tự cho các công việc
            int beginRow = 1;
            for (int rowIndex = 0; rowIndex < objects.Count; rowIndex++)
            {
                KeyValuePair<int, ARow> row = objects.ElementAt(rowIndex);
                int indexRow = row.Key;
                ARow rowObject = row.Value;
                if (rowObject is Row)
                {
                    ws[((Row)rowObject).Address("B")] = beginRow.ToString();
                    ws.AutoFitRowHeight(indexRow - 1, false);
                    beginRow++;
                }
            }

            int lastRow = 0;
            List<int> startAdditionalRows = new List<int>();
            List<int> startRows = new List<int>();
            List<int> startGroups = new List<int>();

            for (int indexRow = 6; indexRow <= ws.RowCount; indexRow++)
            {
                // Tìm dòng cuối của template
                if (!IsCellEmptyOrNull(ws, "A" + indexRow))
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        lastRow = indexRow;
                    }
                }
            }

            for (int indexRow = 6; indexRow <= lastRow; indexRow++)
            {
                if (ws.IsMergedCell("B" + indexRow))
                {
                    startGroups.Add(indexRow);
                }
                else
                {
                    if (IsCellEmptyOrNull(ws, "B" + indexRow) && IsCellEmptyOrNull(ws, "C" + indexRow))
                    {
                        // check công thức diễn giải khi nhập vào
                        if (!IsCellEmptyOrNull(ws, "D" + indexRow) || !IsCellEmptyOrNull(ws, "L" + indexRow))
                        {
                            startAdditionalRows.Add(indexRow);
                        }
                    }
                    if ( !IsCellEmptyOrNull(ws, "C" + indexRow))
                    {
                        string C = CellUtility.ConvertData<string>(ws["C" + indexRow]);
                        if (C != null && C.StartsWith("*"))
                        {
                            startGroups.Add(indexRow);
                            continue;
                        }
                        else
                        {
                            //startRows.Add(indexRow);
                            //continue;
                        }
                    }    
                    
                    if ( !IsCellEmptyOrNull(ws, "B" + indexRow) && int.TryParse(ws["B" + indexRow]?.ToString(), out int row))
                    {
                        bool laBatDauCongViec = row >= 1;
                        if (laBatDauCongViec)
                        {
                            startRows.Add(indexRow);
                            continue;
                        }
                    }
                }
            }

            for (int i = 0; i < startAdditionalRows.Count; i++)
            {
                objects[startAdditionalRows[i]] = new AdditionalRow(startAdditionalRows[i]);
                ((AdditionalRow)objects[startAdditionalRows[i]]).bind(ws);
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < startRows.Count; i++)
            {
                objects[startRows[i]] = new Row(startRows[i]);
                Row cv = (Row)objects[startRows[i]];
                int start, end;
                // tính toán dòng bắt đầu kết thúc
                if (i == startRows.Count - 1)
                {
                    start = startRows[i];
                    end = lastRow - 1;
                }
                else
                {
                    if (startRows[i] == (lastRow - 1))
                    {
                        start = startRows[i];
                        end = startRows[i];
                    }
                    else
                    {
                        start = startRows[i];
                        end = startRows[i + 1] - 1;
                    }
                }
                cv.start = start;
                cv.end = end;

                // kiểm tra xem có dòng dữ liệu thêm ( Công thức diễn giải, Diễn giải khối lượng) hay không
                bool haveInterpretiveFormula = false;
                for (int index = start + 1; index <= end; index++)
                {
                    if (obj(index) is AdditionalRow)
                    {
                        haveInterpretiveFormula = true;
                        break;
                    }
                }
                cv.HaveInterpretiveFormula = haveInterpretiveFormula;
                cv.bind(ws);
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < startGroups.Count; i++)
            {
                objects[startGroups[i]] = new Group(startGroups[i]);
                Group groupCV = (Group)obj(startGroups[i]);
                int start, end;
                if (i == startGroups.Count - 1)
                {
                    start = startGroups[i];
                    end = lastRow - 1;
                }
                else
                {
                    if (startGroups[i] == (lastRow - 1))
                    {
                        start = startGroups[i];
                        end = startGroups[i];
                    }
                    else
                    {
                        start = startGroups[i];
                        end = startGroups[i + 1] - 1;
                    }
                }
                groupCV.start = start;
                groupCV.end = end;
                groupCV.bind(ws);
            }
        }
    }
}
