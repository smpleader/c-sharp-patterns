
using System.Security.Cryptography;
using Worksheet.modData.Memories;
using Worksheet.modData;
using Worksheet.modData.Memories.Pointer;
using unvell.ReoGrid.Utility;

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

                //ws.SetCols(5);
                //ws.ColumnHeaders[0].Text = "Mã";
                //ws.ColumnHeaders[1].Text = "Tên";
                //ws.ColumnHeaders[2].Text = "VL";
                //ws.ColumnHeaders[3].Text = "NC";
                //ws.ColumnHeaders[4].Text = "CM";
            }
        }

        public void click1(object sender, EventArgs e)
        {
            // sjpw form 
            //  MainAppActions/
        }

        public override void addMenu()
        {

            Display.menuItems = new ToolStripItemCollection(Display.contextMenu,
                    new ToolStripItem[]{
                        new ToolStripMenuItem("Congviec 1", null, click1),
                        new ToolStripMenuItem("Congviec 2"),

                    });
        }

        public override void loadData()
        {
            //if (ws.UsedRange.Rows > 0)
            //{
            //    for (int i = 1; i < ws.UsedRange.Rows; i++)
            //    {
            //        objects[i] = new Row(i);
            //        objects[i].bind(ws);
            //    }
            //}

            /* ws.GetRo("");

                MessageBox.Show(ws.Name + " total row " + ws.MaxContentCol + 
                " total cols " + ws.MaxContentRow + 
                " row count " + ws.RowCount +
                " rows " + ws.Rows +
                " \n range used col " + ws.UsedRange.Cols +
                " range used row " + ws.UsedRange.Rows +
                " data cell " + ws["1" + ws.UsedRange.Rows]

                );*/

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
                if (int.TryParse(congViec.ColText["startRow"], out int indexRow))
                {
                    if (!objects.TryGetValue(indexRow, out obj))
                    {
                        objects[indexRow] = new Row(indexRow);
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
                        objects[indexRow].M = congViec.ColNum["khoiLuong"];
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
            ws.HideColumns(5, 7);
            ws["B2"] = "CÔNG TRÌNH: " + "Công trình 1";//applicationData.Content.CongTrinh.Ten;
            Worksheet.modData.Memories.Record.CongViec congViec;
            Current.HM.id(1);
            List<Worksheet.modData.Memories.Record.CongViec> danhSachCongViec = Worksheet.modData.Memories.Models.CongViec.danhSachCongViecHangMuc();
            for (int indexCongViec = 0; indexCongViec < danhSachCongViec.Count; indexCongViec++)
            {
                congViec = danhSachCongViec[indexCongViec];
                int row = int.Parse(congViec.ColText["startRow"]);
                ws["B" + row] = indexCongViec + 1 ;
                ws["C" + row] = objects[row].C;
                ws["D" + row] = objects[row].D;
                ws["E" + row] = objects[row].E;

                ws["F" + row] = objects[row].F;
                ws["G" + row] = objects[row].G;
                ws["H" + row] = objects[row].H;
                ws["I" + row] = objects[row].I;
                ws["J" + row] = objects[row].J;
                ws["K" + row] = objects[row].K;
                ws["L" + row] = objects[row].L;
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
            if (true)
            {
                int beginRow = 1;
                for (int indexRow = 6; indexRow <ws.RowCount; indexRow++)
                {
                    congViec = danhSachCongViec.Find(x => x.ColText["startRow"] == indexRow.ToString());
                    if (ws["C" + indexRow] != null)
                    {
                       ws["B" + indexRow] = beginRow;
                       ws.AutoFitRowHeight(indexRow - 1, false);
                        congViec.ColText["STT"] = beginRow.ToString();
                        beginRow++;
                    }
                }
            }

            List<int> startRows = new List<int>();
            for (int indexRow = 6; indexRow <= ws.RowCount; indexRow++)
            {
                if (ws["B" + indexRow] == null || ws["B" + indexRow] == "") continue;
                int.TryParse(ws["B" + indexRow].ToString(), out int row);
                bool laBatDauCongViec = row >= 1;
                if (laBatDauCongViec)
                {
                    startRows.Add(indexRow);
                }
            }

            // đặt lại chỉ số hàng bắt đầu và hàng kết thúc của công việc trên sheet
            for (int i = 0; i < startRows.Count; i++)
            {
                congViec = danhSachCongViec.Find(x => x.ColText["startRow"] == startRows[i].ToString());

                if (i == startRows.Count - 1)
                {
                    congViec.ColText["startRow"] = startRows[i].ToString();
                    congViec.ColText["EndRow"] = (ws.RowCount - 1).ToString();
                }
                else
                {
                    if (startRows[i] == (ws.RowCount - 1))
                    {
                        congViec.ColText["startRow"] = startRows[i].ToString();
                        congViec.ColText["EndRow"] = startRows[i].ToString();
                    }
                    else
                    {
                        congViec.ColText["startRow"] = startRows[i].ToString();
                        congViec.ColText["EndRow"] = (startRows[i + 1] - 1).ToString();
                    }
                }
            }
            DangThemCongViec = false;
        }

        public override void selectCell()
        {
            //MessageBox.Show(Display.Col + Display.Row);
            switch (Display.Col)
            {
                //case "C":
                    //Display.Cell.IsReadOnly = true;
                    //obj().C.click();
                    //break;
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
                obj().bind(ws);
                string debug = "";
                ARecord? find = Current.CV.load(Display.Row);// memories.Storage.Find(r=>r.Path == Current.CV.path(row.Id));
                if (find != null)
                {
                    debug += "MSCV " + find.ColText["ma"] + " | " + find.Path + " | " + find.txt("ten") + find.txt("khoiLuong") + "\n";
                }
                MessageBox.Show(debug);
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
                    obj().bind(ws);
                    break;
                //case "C": obj().C.click(); break;
                //case "D": obj().D.click(); break;
            }
           
        }

        public override void beforeSave()
        {
            //ws["A1"] = "xxx11x"; test

            // attach to control to save into file
            Display.WControl.AddWorksheet(ws);
        }
        public override void afterSave()
        {
            // detach from control
            Display.WControl.RemoveWorksheet(ws);
        }
    }
}
