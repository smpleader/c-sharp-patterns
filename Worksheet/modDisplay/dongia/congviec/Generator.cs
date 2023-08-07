using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Pointer;
using Worksheet.modData.Memories.Record;

namespace Worksheet.modDisplay.dongia.congviec
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws; 
        public override string Name { get { return "dongia/congviec"; } } 

        private Dictionary<int, Row> objects = new Dictionary<int, Row>();

        public Row obj(int id = 0)
        {
            if(0 == id)
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

                ws.SetCols(5);
                ws.ColumnHeaders[0].Text = "Mã";
                ws.ColumnHeaders[1].Text = "Tên";
                ws.ColumnHeaders[2].Text = "VL";
                ws.ColumnHeaders[3].Text = "NC";
                ws.ColumnHeaders[4].Text = "CM";
            }
        }

        public override void loadData()
        { 

            MessageBox.Show(ws.Name + " total row " + ws.MaxContentCol + 
                " total cols " + ws.MaxContentRow + 
                " row count " + ws.RowCount +
                " rows " + ws.Rows +
                " \n range used col " + ws.UsedRange.Cols +
                " range used row " + ws.UsedRange.Rows +
                " data cell " + ws["A" + ws.UsedRange.Rows]


                );

        }

        public override void selectCell()
        {
            //MessageBox.Show(Display.Col + Display.Row);
            switch(Display.Col)
            {
                case "C":
                    Display.Cell.IsReadOnly = true;
                    obj().C.click(); break; 
                case "D":
                    Display.Cell.IsReadOnly = true;
                    obj().D.click(); break;  
                case "E":
                    Display.Cell.IsReadOnly = true;
                    obj().E.click(); break;
            }
        }
        public override void afterCellInput()
        {
            switch (Display.Col)
            {
                case "A": 
                    //DonGiaCongViec 
                    obj().A = Display.Cell.Data.ToString(); break;
                case "B": //obj().C.click();
                case "C": //obj().C.click();

                    break;
                case "D": obj().D.click(); break;
                case "E": obj().E.click(); break;
            }
        }
    }
}
