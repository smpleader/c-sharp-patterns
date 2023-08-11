using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;
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

        public override void selectCell()
        {
            //MessageBox.Show(Display.Col + Display.Row);
            switch (Display.Col)
            {
                //case "C":
                    //Display.Cell.IsReadOnly = true;
                    //obj().C.click();
                    //break;
                case "D":
                    Display.Cell.IsReadOnly = true;
                    //obj().D.click();
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
