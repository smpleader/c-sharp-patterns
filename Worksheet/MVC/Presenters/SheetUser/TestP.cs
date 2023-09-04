using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.MVC.Models;
using UserView = Worksheet.MVC.Views.SheetDemo;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using unvell.ReoGrid.IO.OpenXML.Schema;
using Microsoft.Office.Interop.Excel;
using Worksheet.modData.Memories.Models;
using Util;

namespace Worksheet.MVC.Presenters.SheetUser
{
    internal class TestP : APresenter<UserView>
    {
        protected UserView _view;
        private DemoM model;

        public TestP(UserView view) : base(view)
        {
            _view = view;
            model = SimpleInjectionDI.container.GetInstance<DemoM>();
        }

        public void test()
        {
            modData.Memories.Record.HangMuc t = new modData.Memories.Record.HangMuc("ten 1", "kieu 1");
            t.txt("test", "oo1");
            HangMuc.them(t);
            t = new modData.Memories.Record.HangMuc("ten 2", "kieu 2");
            t.txt("test", "oo2");
            HangMuc.them(t);

            string debug = "";

            modData.memories.Storage.ForEach(r => debug += "Record ID "+ r.Id + " | " + r.Path + " | " + r.txt("test") + "\n");

            MessageBox.Show(debug);
        }

        public void myTest(string shtName)
        {
            string find = "";
            _view.label1.Text = "";
            List<unvell.ReoGrid.Worksheet> t = _view.reoGridControl1.Worksheets.ToList();
            foreach(unvell.ReoGrid.Worksheet w in t)
            {
                if (w.Name == shtName)
                {
                    find = w.Name;
                }
                _view.label1.Text += w.Name + " | ";
            }

            if(String.IsNullOrEmpty(find))
            {
                MessageBox.Show("Invalid sheet");
            }
            else
            {
                _view.reoGridControl1.CurrentWorksheet = _view.reoGridControl1.Worksheets[find];
            }
        }

        // show un licensed product when close ( OMG )
        public void myTestInterop() // 
        {

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            string _filename = AppConst.autosaveFolder + "test02.xlsx";
            //MessageBox.Show(_filename); return;

            oXL = new Excel.Application();
            oXL.Visible = false;

            //Open an existing workbook at the first sheet.
            oWB = oXL.Workbooks.Open(_filename);
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;



            MessageBox.Show(oSheet.Cells[2,3].ToString());


            oWB.Close();
            oXL.Quit();

           // Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oWB);
            Marshal.ReleaseComObject(oXL);

        }

        private string filename;
        public void setupWB()
        {
            IWorkbook wb = ReoGridControl.CreateMemoryWorkbook();
            wb.Load(AppConst.templateFolder + "\\input\\" + _view.cbData.SelectedValue);
            filename = DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xlsx";

            var sheet0 = wb.Worksheets[0];

            var sheet1 = wb.CreateWorksheet("new sheet");

            // set data into cell A1 
            sheet1["A1"] = "Hello World";

            // set data into cell A2, B2, C2, D2 and E2
            sheet1["A2"] = new object[] {
                10, // A2
                20, // B2
                5,//"=B2+C2", // C2
                6 //"=SUM(B2:D2)", // D2
              };
            //sheet1["C2"] = "=A2+B2";
            //sheet1["D2"] = "=SUM(A2:B2)";
            sheet1["A3"] = "=A2+B2";
            sheet1["A4"] = "=A2*B2";
            sheet1["A5"] = "=A2/B2";

            //sheet1.

            wb.AddWorksheet(sheet1);


            var news = sheet1.Clone();


            // MessageBox.Show( news.Workbook.GetType().ToString());
            //_view.reoGridControl1.InsertWorksheet(0,sheet1);

            // wb.MoveWorksheet(sheet0, 1);

            if (!Directory.Exists(AppConst.autosaveFolder))
            {
                Directory.CreateDirectory(AppConst.autosaveFolder);
            }

            wb.WorkbookSaved += AfterSave;
            wb.Save(AppConst.autosaveFolder + '\\' + filename, unvell.ReoGrid.IO.FileFormat.Excel2007);
        }

        public void AfterSave(object sender, EventArgs e)
        {
            MessageBox.Show("done " + filename);
        }

    }
}
