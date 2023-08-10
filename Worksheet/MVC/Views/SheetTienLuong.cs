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
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTienLuong : AView
    {
        private TienLuongP tienLuongP;
        public SheetTienLuong()
        {
            InitializeComponent();
        }

        private void SheetTienLuong_Load(object sender, EventArgs e)
        {
            tienLuongP = new TienLuongP(this);
            tienLuongP.Setup();
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
            Display.hook("AfterSave");
            //MessageBox.Show("Saved " + cbFile.SelectedValue.ToString());
        }
        public async void AfterLoad(object sender, EventArgs e)
        {
            //MessageBox.Show("load file: " + cbFile.SelectedValue.ToString());

            // a little time to be sure file get loaded
            await Task.Delay(500);
            Display.setup(AppConst.templateFolder + "TienLuong");

            Display.hook("LoadData");
        }

        private void btn_BackDemo_Click(object sender, EventArgs e)
        {
            Backbone.Run("SheetDemo");
        }
    }
}
