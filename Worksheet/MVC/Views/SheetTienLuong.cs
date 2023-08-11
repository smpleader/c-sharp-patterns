using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.modDisplay;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTienLuong : AView
    {
        private TienLuongP tienLuongP;
        private VatLieuP vatLieuP;

        public SheetTienLuong()
        {
            registerPresenters(true);
            InitializeComponent();
        }

        private void SheetTienLuong_Load(object sender, EventArgs e)
        {
            tienLuongP = (TienLuongP)Publisher.get("SheetTienLuong");
            tienLuongP.Setup();
            vatLieuP = (VatLieuP)Publisher.get("SheetVatLieu");
            vatLieuP.Setup();
            sheet_TienLuong.CurrentWorksheet.SetRows(10000);
            sheet_TienLuong.WorkbookSaved += AfterSave;
            sheet_TienLuong.WorkbookLoaded += AfterLoad;
            sheet_TienLuong.ContextMenuStrip = Display.contextMenu;

            Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
        }

        private void btn_ThemCongViec_Click(object sender, EventArgs e)
        {

        }
        public void AfterSave(object sender, EventArgs e)
        {
            //Display.hook("AfterSave");
        }
        public async void AfterLoad(object sender, EventArgs e)
        {
            // a little time to be sure file get loaded
            await Task.Delay(500);
            Display.setup(AppConst.templateFolder + "TienLuong");

            //Display.hook("LoadData");
        }

        private void btn_BackDemo_Click(object sender, EventArgs e)
        {
            Backbone.Run("SheetDemo");
        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("SheetTienLuong", "TienLuong");
            }
            else
            {
                if (null == tienLuongP) tienLuongP = new TienLuongP(this);
                Publisher.register("SheetTienLuong", tienLuongP);
                if (null == vatLieuP) vatLieuP = new VatLieuP(this);
                Publisher.register("SheetVatLieu", vatLieuP);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedTab.Text)
            {
                case "Tiên lượng":
                    Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
                    break;
                case "Vật liệu":
                    Display.setup(sheet_VatLieu, AppConst.templateFolder + "GiaVatLieu");
                    break;
            }    
        }
    }
}
