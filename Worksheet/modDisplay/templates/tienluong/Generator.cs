
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
            int lastRow = 0;
            List<int> startAdditionalRows = new List<int>();
            List<int> startRows = new List<int>();
            List<int> startGroups = new List<int>();

            for (int indexRow = 6; indexRow <= ws.RowCount; indexRow++)
            {
                // Tìm dòng cuối của template
                if (ws["A" + indexRow] != null && ws["A" + indexRow] != "")
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        lastRow = indexRow;
                    }
                }

                //Tìm dòng bắt đầu group có tính tổng tiền các công việc trong group đó
                if (ws["B" + indexRow] == null || ws["B" + indexRow] == "") continue;
                if (ws.IsMergedCell("B" + indexRow))
                {
                    startGroups.Add(indexRow);
                }
                else
                {
                    if (int.TryParse(ws["B" + indexRow].ToString(), out int row))
                    {
                        bool laBatDauCongViec = row >= 1;
                        if (laBatDauCongViec)
                        {
                            startRows.Add(indexRow);
                        }
                    }
                    string C = CellUtility.ConvertData<string>(ws["C" + indexRow]);
                    if (C == null)
                    {
                        // check công thức diễn giải khi nhập vào
                        if (ws["D" + indexRow] != null && ws["D" + indexRow] != "")
                        {
                            startAdditionalRows.Add(indexRow);
                        }
                    }
                }
            }

            for (int i = 0; i < startAdditionalRows.Count; i++)
            {
                objects[startAdditionalRows[i]] = obj(startAdditionalRows[i]);
                ((AdditionalRow)objects[startAdditionalRows[i]]).IsInterpretiveFormula = true;
                ((AdditionalRow)objects[startAdditionalRows[i]]).bind(ws);
            }
            for (int i = 0; i < startGroups.Count; i++)
            {
                objects[startGroups[i]] = obj(startGroups[i]);
                ((Group)objects[startGroups[i]]).bind(ws);
            }

            for (int i = 0; i < startRows.Count; i++)
            {
                objects[startRows[i]] = obj(startRows[i]);
                ((Row)objects[startRows[i]]).bind(ws);
            }



            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < startRows.Count; i++)
            {
                Row congViec = (Row)obj(startRows[i]);

                if (i == startRows.Count - 1)
                {
                    congViec.start = startRows[i];
                    congViec.end = lastRow - 1;
                }
                else
                {
                    if (startRows[i] == (lastRow - 1))
                    {
                        congViec.start = startRows[i];
                        congViec.end = startRows[i];
                    }
                    else
                    {
                        congViec.start = startRows[i];
                        congViec.end = startRows[i + 1] - 1;
                    }
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < startGroups.Count; i++)
            {
                Group groupCV = (Group)obj(startGroups[i]);

                if (i == startGroups.Count - 1)
                {
                    groupCV.start = startGroups[i];
                    groupCV.end = lastRow - 1;
                }
                else
                {
                    if (startGroups[i] == (lastRow - 1))
                    {
                        groupCV.start = startGroups[i];
                        groupCV.end = startGroups[i];
                    }
                    else
                    {
                        groupCV.start = startGroups[i];
                        groupCV.end = startGroups[i + 1] - 1;
                    }
                }
            }
            for (int rowIndex = 0; rowIndex < objects.Count; rowIndex++)
            {
                KeyValuePair<int, ARow> row = objects.ElementAt(rowIndex);

                bool haveInterpretiveFormula = false;
                if (!(row.Value is Group) && !(row.Value is AdditionalRow))
                {
                    for (int i = row.Value.start + 1; i <= row.Value.end; i++)
                    {
                        if (obj(i) is AdditionalRow)
                        {
                            haveInterpretiveFormula = true;
                            break;
                        }
                    }
                }
                ((Row)row.Value).HaveInterpretiveFormula = haveInterpretiveFormula;
                if (haveInterpretiveFormula)
                {
                    ws["M" + row.Key] = string.Format(modBL.Container.Get("CongViec_KhoiLuong").fml(), row.Value.start + 1, row.Value.end);
                }
            }
            var a = objects;
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow > StartIndexRowBody && selectedIndexRow < EndIndexRowBody)
            {
                // bắt đầu thêm công việc
                DangThemCongViec = true;
                if (!objects.TryGetValue(selectedIndexRow, out ARow rObject))
                {
                    objects[selectedIndexRow] = new Row(selectedIndexRow);
                }
                
                Row selectedRow = (Row)objects[selectedIndexRow];
                // mã công việc
                ws[selectedRow.Address("C")] = "AG.11111";
                // tên công việc
                ws[selectedRow.Address("D")] = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
                // đơn vị
                ws[selectedRow.Address("E")] = "m3";
                // thông tin đơn giá
                ws[selectedRow.Address("Y")] = "m3";

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
            DangThemCongViec = true;
            return;
            for (int rowIndex = 0; rowIndex < objects.Count; rowIndex++)
            {
                KeyValuePair<int, ARow> row = objects.ElementAt(rowIndex);
                int indexRow = row.Key;
                if (obj(indexRow) is Row)
                {
                    objects[indexRow] = new Row(indexRow);
                }
                if (objects[indexRow] is Group)
                {

                }
                else
                {
                    if (objects[indexRow] is AdditionalRow)
                    {
                        if (!((AdditionalRow)obj(indexRow)).IsInterpretiveFormula)
                        {
                            ws["L" + indexRow] = ((AdditionalRow)obj(indexRow)).GetFormula("L");
                        }
                    }
                }
            }
        }

        public void render()
        {
            DangThemCongViec = true;
            ws["B2"] = "CÔNG TRÌNH: " + "Công trình 1";
            Worksheet.modData.Memories.Record.CongViec congViec;
            Current.HM.id(1);
            List<Worksheet.modData.Memories.Record.CongViec> danhSachCongViec = Worksheet.modData.Memories.Models.CongViec.danhSachCongViecHangMuc();
            for (int indexCongViec = 0; indexCongViec < danhSachCongViec.Count; indexCongViec++)
            {
                congViec = danhSachCongViec[indexCongViec];
                int row = congViec.Id;
                if(obj(row) is Group)
                {
                    ws["R" + row] = ((Group)obj(row)).GetFormula("R");
                    ws["S" + row] = ((Group)obj(row)).GetFormula("S");
                    ws["T" + row] = ((Group)obj(row)).GetFormula("T");
                    ws["U" + row] = ((Group)obj(row)).GetFormula("U");
                }    
                else
                {
                    if(obj(row) is AdditionalRow)
                    {
                        if(!((AdditionalRow)obj(row)).IsInterpretiveFormula)
                        {
                            ws["L" + row] = ((AdditionalRow)obj(row)).GetFormula("L");
                        }
                    }
                    else
                    {
                        ws["B" + row] = indexCongViec + 1;
                    }    
                }
            }
            
            renderFormula();
            DangThemCongViec = false;
            return;
        }

        public override void selectCell()
        {
            switch (Display.Col)
            {
                //case "B":
                //    if(!(obj(Display.Row) is Group))
                //    {
                //        Display.Cell.IsReadOnly = true;
                //    }
                //    break;
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
                obj().bind(ws);
                renderFormula();

                string debug = "";
                
                ARecord? find = Current.CV.load(Display.Row);
                if (find != null)
                {
                    debug += "MSCV: " + find?.txt("ma") + " | " + find?.Path +" | Khối lượng: " + find?.num("khoiLuong") + "\n";
                    //MessageBox.Show(debug);
                }
                DangThemCongViec = false;
            }
        }

        private void renderFormula()
        {
            int beginRow = 1;
            for (int indexRow = 6; indexRow < EndIndexRowBody; indexRow++)
            {
                if (ws["C" + indexRow] != null)
                {
                    if (obj(indexRow) is Row)
                    {
                        ws["B" + indexRow] = beginRow;
                        ws.AutoFitRowHeight(indexRow - 1, false);
                        ws[((Row)obj(indexRow)).Address("B")] = beginRow.ToString();
                        beginRow++;
                    }
                }
            }
            int lastRow = 0;
            List<int> startRows = new List<int>();
            List<int> startGroups = new List<int>();

            for (int indexRow = 6; indexRow <= ws.RowCount; indexRow++)
            {
                // Tìm dòng cuối của template
                if (ws["A" + indexRow] != null && ws["A" + indexRow] != "")
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        lastRow = indexRow;
                    }
                }

                //Tìm dòng bắt đầu group có tính tổng tiền các công việc trong group đó
                if (ws["B" + indexRow] == null || ws["B" + indexRow] == "") continue;
                if (ws.IsMergedCell("B" + indexRow))
                {
                    startGroups.Add(indexRow);
                }
                else
                {
                    if (int.TryParse(ws["B" + indexRow].ToString(), out int row))
                    {
                        bool laBatDauCongViec = row >= 1;
                        if (laBatDauCongViec)
                        {
                            startRows.Add(indexRow);
                        }
                    }
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < startRows.Count; i++)
            {
                Row cv = (Row)obj(startRows[i]);

                if (i == startRows.Count - 1)
                {
                    cv.start = startRows[i];
                    cv.end = lastRow - 1;
                }
                else
                {
                    if (startRows[i] == (lastRow - 1))
                    {
                        cv.start = startRows[i];
                        cv.end = startRows[i];
                    }
                    else
                    {
                        cv.start = startRows[i];
                        cv.end = startRows[i + 1] - 1;
                    }
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của group trên sheet
            for (int i = 0; i < startGroups.Count; i++)
            {
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
                if (obj(start) is Group)
                {
                    ws["R" + start] = ((Group)obj(start)).GetFormula("R");
                    ws["S" + start] = ((Group)obj(start)).GetFormula("S");
                    ws["T" + start] = ((Group)obj(start)).GetFormula("T");
                    ws["U" + start] = ((Group)obj(start)).GetFormula("U");
                }
            }

            for (int rowIndex = 0; rowIndex < objects.Count; rowIndex++)
            {
                KeyValuePair<int, ARow> row = objects.ElementAt(rowIndex);

                bool haveInterpretiveFormula = false;
                if (!(row.Value is Group) && !(row.Value is AdditionalRow))
                {
                    for (int i = row.Value.start + 1; i <= row.Value.end; i++)
                    {
                        if (obj(i) is AdditionalRow)
                        {
                            haveInterpretiveFormula = true;
                            break;
                        }
                    }
                }
                ((Row)row.Value).HaveInterpretiveFormula = haveInterpretiveFormula;
                if (haveInterpretiveFormula)
                {
                    ws["M" + row.Key] = string.Format(modBL.Container.Get("CongViec_KhoiLuong").fml(), row.Value.start + 1, row.Value.end);
                }
            }
        }
        
    }
}
