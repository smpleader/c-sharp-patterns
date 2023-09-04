using modDisplay;
using Worksheet.MVC.Views;

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
