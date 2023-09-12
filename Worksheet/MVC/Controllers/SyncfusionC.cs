
using modDisplay;
using Util;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Controllers
{
    internal class SyncfusionC : AController
    {
        public override string Name { get { return "DemoSyncfusion"; } }

        protected override IView _view { get; set; } = new SheetSyncfusion();
        public void ReLoad()
        {
            Display.setup(((SheetSyncfusion)_view).sheet_mask, AppConst.templateFolder + "TienLuong");
        }
      
    }
}
