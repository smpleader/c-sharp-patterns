using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Models;
using Worksheet.modData.Memories.Pointer;
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
            sheet_ChiTietNhanCong.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);
            sheet_ChiTietVatLieu.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);
            sheet_ChiTietMay.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);

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
            ((Worksheet.modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).updateData();
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

            Display.hook("LoadData");
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
            switch (tabControl1.SelectedTab.Text)
            {
                case "Tiên lượng":
                    Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
                    break;
                case "Vật liệu":
                    Display.setup(sheet_VatLieu, AppConst.templateFolder + "GiaVatLieu");
                    break;
            }
        }

        private void btn_LuuFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Display.WControl.Save(saveFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                        MessageBox.Show("Lưu thành công! " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lưu lỗi. {ex}");
                        MessageBox.Show("Lưu thất bại! " + ex);

                    }
                }
            }
        }

        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_TienLuong.Load(openFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                        modData.Memories.Record.HangMuc t = new modData.Memories.Record.HangMuc("ten 1", "kieu 1");
                        t.txt("test", "oo1");
                        Worksheet.modData.Memories.Models.HangMuc.them(t);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }

        private void chkbx_KichThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_KichThuoc.Checked)
            {
                sheet_TienLuong.CurrentWorksheet.ShowColumns(5, 7);
            }
            else
            {
                sheet_TienLuong.CurrentWorksheet.HideColumns(5, 7);
            }
        }
    }
}
