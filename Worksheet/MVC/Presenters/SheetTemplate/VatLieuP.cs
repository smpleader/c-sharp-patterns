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
    internal class VatLieuP : APresenter<SheetTienLuong>
    {
        protected SheetTienLuong _view;
        public SheetFormM sheetInput;
        string pathToTemplate = string.Empty;
        public VatLieuP(SheetTienLuong view) : base(view)
        {
            _view = view;

            _view.sheet_VatLieu.SheetTabNewButtonVisible = false;
        }
        public void Setup()
        {
            pathToTemplate = AppConst.templateFolder + "GiaVatLieu.xlsx";
            _view.sheet_VatLieu.Load(pathToTemplate, FileFormat.Excel2007);
            _view.sheet_VatLieu.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);
        }
    }
}
