using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Pointer;
using Worksheet.modData.Memories.Record;

namespace Worksheet.modDisplay.dongia.congviec
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws; 
        public override string Name { get { return "Công việc"; } } 

        private Dictionary<int, Row> objects = new Dictionary<int, Row>();

        public Row obj(int id = 0)
        {
            if(0 == id)
            {
                id = Current.Row;
            }

            Row obj;

            if (!objects.TryGetValue(id, out obj))
            {
                objects[id] = new Row(id);
            }
                
            return objects[id];
        }

        public override void init()
        {
            if (Current.WB[Name] != null)
            {
                ws = Current.WB[Name];

                ws.SetCols(5);
                ws.ColumnHeaders[0].Text = "Mã";
                ws.ColumnHeaders[1].Text = "Tên";
                ws.ColumnHeaders[2].Text = "VL";
                ws.ColumnHeaders[3].Text = "NC";
                ws.ColumnHeaders[4].Text = "CM";
            }
        }

        public override void selectCell()
        {
            switch(Current.Col)
            {
                case "C":
                    Current.Cell.IsReadOnly = true;
                    obj().C.click(); break; 
                case "D":
                    Current.Cell.IsReadOnly = true;
                    obj().D.click(); break;  
                case "E":
                    Current.Cell.IsReadOnly = true;
                    obj().E.click(); break;
            }
        }
        public override void afterCellInput()
        {
            switch (Current.Col)
            {
                case "A": 
                    //DonGiaCongViec 
                    obj().A = Current.Cell.Data.ToString(); break;
                case "B": //obj().C.click();
                case "C": //obj().C.click();

                    break;
                case "D": obj().D.click(); break;
                case "E": obj().E.click(); break;
            }
        }
    }
}
