
using Worksheet.modData.Memories.Pointer;

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
            if (ws.UsedRange.Rows > 0)
            {
                for (int i = 1; i < ws.UsedRange.Rows; i++)
                {
                    objects[i] = new Row(i);
                    objects[i].bind(ws);
                }
            }

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

        public void render()
        {
            ws["B2"] = "CÔNG TRÌNH: " + "Công trình 1";//applicationData.Content.CongTrinh.Ten;
            Worksheet.modData.Memories.Record.CongViec congViec;
            Current.HM.id(1);
            List<Worksheet.modData.Memories.Record.CongViec> danhSachCongViec = Worksheet.modData.Memories.Models.CongViec.danhSachCongViecHangMuc();
            for (int indexCongViec = 0; indexCongViec < danhSachCongViec.Count; indexCongViec++)
            {
                congViec = danhSachCongViec[indexCongViec];
                string row = congViec.ColText["startRow"];
                ws["B" + row] = indexCongViec + 1;
                ws["C" + row] = objects[indexCongViec].C;
                ws["D" + row] = objects[indexCongViec].D;
                ws["E" + row] = objects[indexCongViec].E;

                ws["F" + row] = objects[indexCongViec].F;
                ws["G" + row] = objects[indexCongViec].G;
                ws["H" + row] = objects[indexCongViec].H;
                ws["I" + row] = objects[indexCongViec].I;
                ws["J" + row] = objects[indexCongViec].J;
                ws["K" + row] = objects[indexCongViec].K;
                ws["L" + row] = objects[indexCongViec].L;
                ws["M" + row] = objects[indexCongViec].M;

                ws["N" + row] = objects[indexCongViec].N;
                ws["O" + row] = objects[indexCongViec].O;
                ws["P" + row] = objects[indexCongViec].P;
                ws["Q" + row] = objects[indexCongViec].Q;

                ws["R" + row] = objects[indexCongViec].R;
                ws["S" + row] = objects[indexCongViec].S;
                ws["T" + row] = objects[indexCongViec].T;
                ws["U" + row] = objects[indexCongViec].U;

                ws["V" + row] = objects[indexCongViec].V;
                ws["W" + row] = objects[indexCongViec].W;
                ws["X" + row] = objects[indexCongViec].X;

                ws["Y" + row] = objects[indexCongViec].Y;
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
        public override void afterCellInput()
        {
            switch (Display.Col)
            {
                case "A":
                case "B":
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
