﻿using System;
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
    internal class TienLuongP : APresenter<SheetTienLuong>
    {
        protected SheetTienLuong _view;
        public SheetFormM sheetInput;
        string pathToTemplate = string.Empty;
        public TienLuongP(SheetTienLuong view) : base(view)
        {
            // This should be put at Screen Startup
            Display.init();

            _view = view;

            _view.sheet_TienLuong.SheetTabNewButtonVisible = false;
        }
        public void Setup()
        {
            pathToTemplate = AppConst.templateFolder + "TienLuong.xlsx";
            _view.sheet_TienLuong.Load(pathToTemplate, FileFormat.Excel2007);
        }

    }

}
