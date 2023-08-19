using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.IO;
using Worksheet.modDisplay;
using Worksheet.MVC.Models;
using Worksheet.MVC.Views;
using Worksheet.Util;

namespace Worksheet.MVC.Presenters.SheetTemplate
{
    internal class DinhMucMayP : APresenter<SheetTienLuong>
    {
        protected SheetTienLuong _view;
        public SheetFormM sheetInput;
        string pathToTemplate = string.Empty;
        public DinhMucMayP(SheetTienLuong view) : base(view)
        {
            _view = view;

            _view.sheet_ChiTietMay.SheetTabNewButtonVisible = false;
        }
        public void Setup()
        {
            pathToTemplate = AppConst.templateFolder + "TienLuong.xlsx";
            _view.sheet_ChiTietMay.Load(pathToTemplate, FileFormat.Excel2007);
            _view.sheet_ChiTietMay.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);
            _view.sheet_ChiTietMay.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, false);
            _view.sheet_ChiTietMay.CurrentWorksheet = _view.sheet_ChiTietMay.Worksheets["Định mức máy"];
        }
    }
}
