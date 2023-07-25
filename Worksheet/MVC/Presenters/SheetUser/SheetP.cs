using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UserView = Worksheet.MVC.Views.SheetDemo;
using User = Worksheet.Data.Entities.User.WinForm;
using UserCore = Worksheet.Data.Entities.User.Schema;
using Worksheet.MVC.Models;
using Worksheet.Util;
using unvell.ReoGrid;
using Worksheet.Util.Drivers;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Worksheet.MVC.Presenters.SheetUser
{
    internal class SheetP : APresenter<UserView>
    {
        protected UserView _view;
        private DemoM model;
        public SheetFormM sheetInput;
        public SheetFormM sheetOutput;

        public SheetP(UserView view) : base(view)
        {
            _view = view;
            model = SimpleInjectionDI.container.GetInstance<DemoM>();
            sheetInput = new SheetFormM("input", AppConst.templateFolder + "/input/", view.reoGridControl1, view.cbData, view.Controls,  5, 44);
            sheetOutput = new SheetFormM("output", AppConst.templateFolder + "/output/", view.reoGridControl2, view.cbReport, view.Controls,  5, 534);
        }
        public void Setup()
        {
            _view.cbData.DataSource = model.ComboboxTemplateList("input");
            _view.cbReport.DataSource = model.ComboboxTemplateList("output");
            sheetInputReload();
            sheetOutputReload();
        }
         
        public void sheetInputReload()
        {
            sheetInput.loadSheetFromSelect();
        }
        public void sheetOutputReload()
        {
            sheetOutput.loadSheetFromSelect();
        }
    }
}
