
using System.Security.Cryptography;
using Worksheet.modData.Memories;
using Worksheet.modData;
using Worksheet.modData.Memories.Pointer;
using unvell.ReoGrid.Utility;
using System.Configuration;
using System.Collections.Generic;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;

        private int StartRowBody = 5;

        public override string Name { get { return "templates/tienluong"; } }

        private Dictionary<int, Row> objects = new Dictionary<int, Row>();

        public Row obj(int id = 0)
        {
            if (0 == id)
            {
                id = Display.Row;
            }

            Row obj;

            if (!objects.TryGetValue(id, out obj))
            {
                objects[id] = new Row(id);
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
            List<int> startInterpretiveFormulas = new List<int>();
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
                            startInterpretiveFormulas.Add(indexRow);
                        }
                    }
                }
            }

            for (int i = 0; i < startInterpretiveFormulas.Count; i++)
            {
                objects[startInterpretiveFormulas[i]] = obj(startInterpretiveFormulas[i]);
                objects[startInterpretiveFormulas[i]].isInterpretiveFormula = true;
                objects[startInterpretiveFormulas[i]].bind(ws);
            }
            for (int i = 0; i < startGroups.Count; i++)
            {
                objects[startGroups[i]] = obj(startGroups[i]);
                objects[startGroups[i]].bind(ws);
            }

            for (int i = 0; i < startRows.Count; i++)
            {
                objects[startRows[i]] = obj(startRows[i]);
                objects[startRows[i]].bind(ws);
            }



            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < startRows.Count; i++)
            {
                Row congViec = obj(startRows[i]);

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
                Row groupCV = obj(startGroups[i]);

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
                KeyValuePair<int, Row> row = objects.ElementAt(rowIndex);

                bool haveInterpretiveFormula = false;
                if (!row.Value.isGroup && !row.Value.isInterpretiveFormula)
                {
                    for (int i = row.Value.start + 1; i <= row.Value.end; i++)
                    {
                        if (obj(i).isInterpretiveFormula)
                        {
                            haveInterpretiveFormula = true;
                            break;
                        }
                    }
                }
                row.Value.HaveInterpretiveFormula = haveInterpretiveFormula;
                if (haveInterpretiveFormula)
                {
                    ws["M" + row.Key] = string.Format(modBL.Container.Get("CongViec_KhoiLuong").fml(), row.Value.start + 1, row.Value.end);
                }
            }
            var a = objects;
        }
        public void prepareData()
        {
            Current.HM.id(1);
            List<Worksheet.modData.Memories.Record.CongViec> danhSachCongViec = Worksheet.modData.Memories.Models.CongViec.danhSachCongViecHangMuc();
            Worksheet.modData.Memories.Record.CongViec congViec;
            for (int indexCongViec = 0; indexCongViec < danhSachCongViec.Count; indexCongViec++)
            {
                congViec = danhSachCongViec[indexCongViec];
                Row obj;
                int indexRow = congViec.Id;
                if (!objects.TryGetValue(indexRow, out obj))
                {
                    objects[indexRow] = new Row(indexRow);
                }
                if (objects[indexRow].isGroup)
                {
                    objects[indexRow].B = congViec.ColText["stt"];
                }
                else
                {
                    if (objects[indexRow].isInterpretiveFormula)
                    {
                        objects[indexRow].D = congViec.ColText["ten"];
                        objects[indexRow].L = congViec.ColNum["khoiLuongPhu"];
                    }
                    else
                    {
                        //objects[indexRow].A = congViec.ColText()
                        objects[indexRow].B = congViec.ColText["stt"];
                        objects[indexRow].C = congViec.ColText["ma"];
                        objects[indexRow].D = congViec.ColText["ten"];
                        objects[indexRow].E = congViec.ColText["donVi"];
                        objects[indexRow].F = congViec.ColText["tenCauKien"];
                        objects[indexRow].G = congViec.ColNum["soCauKien"];
                        objects[indexRow].H = congViec.ColNum["dai"];
                        objects[indexRow].I = congViec.ColNum["rong"];
                        objects[indexRow].J = congViec.ColNum["cao"];
                        objects[indexRow].K = congViec.ColNum["heSoPhu"];
                        objects[indexRow].L = congViec.ColNum["khoiLuongPhu"];
                        objects[indexRow].M = congViec.ColText["khoiLuong"];
                        objects[indexRow].V = congViec.ColNum["hsdcVatLieu"];
                        objects[indexRow].W = congViec.ColNum["hsdcNhanCong"];
                        objects[indexRow].X = congViec.ColNum["hsdcMay"];
                        objects[indexRow].Y = congViec.ColText["thongTinDonGia"];
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
                if(objects[row].isGroup)
                {
                    ws["B" + row] = objects[row].B;
                }    
                else
                {
                    if(obj(row).isInterpretiveFormula)
                    {
                        ws["D" + row] = objects[row].D;
                        ws["L" + row] = objects[row].L;
                    }
                    else
                    {
                        ws["B" + row] = indexCongViec + 1;
                        ws["C" + row] = objects[row].C;
                        ws["D" + row] = objects[row].D;
                        ws["E" + row] = objects[row].E;

                        //ws["F" + row] = objects[row].F;
                        //ws["G" + row] = objects[row].G;
                        //ws["H" + row] = objects[row].H;
                        //ws["I" + row] = objects[row].I;
                        //ws["J" + row] = objects[row].J;
                        //ws["K" + row] = objects[row].K;
                        //ws["L" + row] = objects[row].L;
                        ws["M" + row] = objects[row].M;

                        ws["N" + row] = objects[row].N;
                        ws["O" + row] = objects[row].O;
                        ws["P" + row] = objects[row].P;
                        ws["Q" + row] = objects[row].Q;

                        ws["R" + row] = objects[row].R;
                        ws["S" + row] = objects[row].S;
                        ws["T" + row] = objects[row].T;
                        ws["U" + row] = objects[row].U;

                        ws["V" + row] = objects[row].V;
                        ws["W" + row] = objects[row].W;
                        ws["X" + row] = objects[row].X;

                        ws["Y" + row] = objects[row].Y;
                        congViec.ColNum["donGiaVatLieu"] = CellUtility.ConvertData<decimal>(ws["N" + row]);
                        congViec.ColNum["donGiaVatLieuPhu"] = CellUtility.ConvertData<decimal>(ws["O" + row]);
                        congViec.ColNum["donGiaNhanCong"] = CellUtility.ConvertData<decimal>(ws["P" + row]);
                        congViec.ColNum["donGiaMay"] = CellUtility.ConvertData<decimal>(ws["Q" + row]);

                        congViec.ColNum["thanhTienVatLieu"] = CellUtility.ConvertData<decimal>(ws["R" + row]);
                        congViec.ColNum["thanhTienVatlieuPhu"] = CellUtility.ConvertData<decimal>(ws["S" + row]);
                        congViec.ColNum["thanhTienNhanCong"] = CellUtility.ConvertData<decimal>(ws["T" + row]);
                        congViec.ColNum["thanhTienMay"] = CellUtility.ConvertData<decimal>(ws["U" + row]);
                    }    
                }
            }
            if(true)
            {
                int beginRow = 1;
                for (int indexRow = 6; indexRow <ws.RowCount; indexRow++)
                {
                    congViec = danhSachCongViec.Find(x => x.Id == indexRow);
                    if (ws["C" + indexRow] != null)
                    {
                        if(!obj(indexRow).isGroup && !obj(indexRow).isInterpretiveFormula)
                        {
                            ws["B" + indexRow] = beginRow;
                            ws.AutoFitRowHeight(indexRow - 1, false);
                            congViec.ColText["STT"] = beginRow.ToString();
                            beginRow++;
                        }    
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
                case "B":
                    if(!obj(Display.Row).isGroup)
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
                Row cv = obj(startRows[i]);

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
                Row groupCV = obj(startGroups[i]);
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
                if (obj(start).isGroup)
                {
                    ws["R" + start] = obj(start).R;
                    ws["S" + start] = obj(start).S;
                    ws["T" + start] = obj(start).T;
                    ws["U" + start] = obj(start).U;
                }
            }

            for (int rowIndex = 0; rowIndex < objects.Count; rowIndex++)
            {
                KeyValuePair<int, Row> row = objects.ElementAt(rowIndex);

                bool haveInterpretiveFormula = false;
                if (!row.Value.isGroup && !row.Value.isInterpretiveFormula)
                {
                    for (int i = row.Value.start + 1; i <= row.Value.end; i++)
                    {
                        if (obj(i).isInterpretiveFormula)
                        {
                            haveInterpretiveFormula = true;
                            break;
                        }
                    }
                }
                row.Value.HaveInterpretiveFormula = haveInterpretiveFormula;
                if (haveInterpretiveFormula)
                {
                    ws["M" + row.Key] = string.Format(modBL.Container.Get("CongViec_KhoiLuong").fml(), row.Value.start + 1, row.Value.end);
                }
            }
        }

        public override void afterCellInput()
        {
            switch (Display.Col)
            {
                case "C":
                case "D":
                case "E":
                case "M":
                    //obj().bind(ws);
                    break;
            }
           
        }
    }
}
