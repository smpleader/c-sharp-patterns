using modDisplay;
using Syncfusion.Windows.Forms.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.IO;
using Util;
using Worksheet.MVC.Models;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Presenters.SheetTemplate
{
    internal class SyncfusionP : APresenter<SheetSyncfusion>
    {
        protected SheetSyncfusion _view;
        string pathToTemplate = string.Empty;
        public SyncfusionP(SheetSyncfusion view) : base(view)
        {
            // This should be put at Screen Startup
            Display.init();
            Display.SetUpWorkingWorkbook();
            Display.AddSheets("2");
            Display.RemoveSheets("2");
            _view = view;
        }
        public void Setup()
        {
            pathToTemplate = AppConst.templateFolder + "TienLuong.xlsx";
            //_view.workbook._grid.Open(pathToTemplate);
            _view.LoadMaskSheet(AppConst.templateFolder + "Default.xlsx");
            _view.sheet_working.Open(pathToTemplate);
            _view.sheet_working.ActiveSheet = _view.sheet_working.Workbook.Worksheets["Giá vật liệu"];
        }
    }
}
