using Syncfusion.Windows.Forms.Spreadsheet;
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
    internal class CuocOtoP : APresenter<SheetTinhCuocOto>
    {
        protected SheetTinhCuocOto _view;
        string pathToTemplate = string.Empty;
        public CuocOtoP(SheetTinhCuocOto view) : base(view)
        {
            _view = view;
        }
        public void Setup()
        {
            //pathToTemplate = AppConst.templateFolder + "TienLuong.xlsx";
            //_view.sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/cuocoto.xlsx");
            //_view.sheet_CuocOto.Open(pathToTemplate);
        }
    }
}
