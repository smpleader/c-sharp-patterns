using Syncfusion.Windows.Forms.CellGrid.ScrollAxis;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.GraphicCells;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modDisplay;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using BaseInterface;
using Util;
using modDisplay.CustomGrid;

namespace Worksheet.MVC.Views
{
    public partial class SheetSyncfusion : AView
    {
        private SyncfusionP syncfusionP;
        public WorkBook workbook;
        public SheetSyncfusion()
        {
            registerPresenters(true);
            InitializeComponent();

        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("SyncfusionTienLuong", "DemoSyncfusion");
            }
            else
            {
                if (null == syncfusionP) syncfusionP = new SyncfusionP(this);
                Publisher.register("SyncfusionTienLuong", syncfusionP);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //sheet_mask.Open(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
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
                        //sheet_mask.SaveAs(saveFileDialog.FileName);
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

        private void chkbx_KichThuoc_CheckedChanged(object sender, EventArgs e)
        {
            Display.ActiveGrid.Cols.Hidden.SetRange(5, 12, !chkbx_KichThuoc.Checked);
        }

        private void btn_ThemCongViec_Click(object sender, EventArgs e)
        {
            ((modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).updateData();
        }

        private async void SheetSyncfusion_Load(object sender, EventArgs e)
        {
            BaseInterface.IModBL modBLContainer = modDisplay.SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            modBLContainer.Init();
            syncfusionP = (SyncfusionP)Publisher.get("SyncfusionTienLuong");
            syncfusionP.Setup();
            //sheet_mask.WorkbookLoaded += AfterLoad;
            //sheet_mask.PropertyChanged += Spreadsheet_PropertyChanged;
            //Display.setControlDebug(sheet_working);
            sheet_working.WorkbookLoaded += AfterLoad2;
        }

        private void AfterLoad2(object sender, WorkbookLoadedEventArgs args)
        {
            Display.setControlDebug(sheet_working);
        }

        private void Spreadsheet_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            //// when the worksheets in the workbook changed
            //if (e.PropertyName == "ActiveSheet")
            //{
            //    //Implement code
            //    if (sheet_mask.Workbook.Worksheets.Count > 1)
            //    {
            //        Display.setControl(sheet_mask);
            //        Display.ActiveGrid = Display.GridCollection[sheet_mask.ActiveSheet.Name];

            //        Display.SetActiveWorkingSheet(sheet_mask.ActiveSheet.Name);
            //        if (Display.WControlDebug != null)
            //        {
            //            Display.WControlDebug.ActiveSheet = Display.WControlDebug.Workbook.Worksheets[sheet_mask.ActiveSheet.Name];
            //        }

            //        switch (sheet_mask.ActiveSheet.Name)
            //        {
            //            case "Tiên lượng":
            //                pnl_VatLieu.Visible = false;
            //                break;
            //            case "Giá vật liệu":
            //                pnl_VatLieu.Visible = true;
            //                //rdbtn_PPT_NhapTay.Checked = true;
            //                //sheet_VatLieu.CurrentWorksheet = Display.WB["Giá vật liệu"];
            //                switch (Option.PPTGiaVatLieu)
            //                {
            //                    case PPTGiaVatLieu.NhapTay:
            //                        rdbtn_PPT_NhapTay.Checked = true;
            //                        break;
            //                    case PPTGiaVatLieu.CongCuocVanChuyen:
            //                        rdbtn_PPT_CongCuocVC.Checked = true;
            //                        break;
            //                    case PPTGiaVatLieu.NhanHeSo:
            //                        rdbtn_PPT_NhanHeSo.Checked = true;
            //                        break;
            //                    case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
            //                        rdbtn_PPT_NhanHeSoCongCuocVC.Checked = true;
            //                        break;
            //                }
            //                break;
            //        }
            //    }

            //}
        }

        private void AfterLoad(object sender, WorkbookLoadedEventArgs args)
        {
            // sau khi load workbook thì mới tiếp cận được activesheet và activegrid
            //Display.setup(sheet_mask, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
        }

        // Xử lý tab vật liệu
        private void rdbtn_PPT_NhapTay_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            Display.ActiveGrid.Cols.Hidden.SetRange(1, 16, false);
            Display.ActiveGrid.Cols.Hidden.SetRange(7, 12, true);
            Display.ActiveGrid.Cols.Hidden.SetRange(14, 14, true);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhapTay;
            ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void rdbtn_PPT_CongCuocVC_CheckedChanged(object sender, EventArgs e)
        {
            Display.ActiveGrid.Cols.Hidden.SetRange(1, 16, false);
            Display.ActiveGrid.Cols.Hidden.SetRange(7, 8, true);
            Display.ActiveGrid.Cols.Hidden.SetRange(13, 13, true);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.CongCuocVanChuyen;
            ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
            btn_TinhCuocOto.Visible = rdbtn_PPT_CongCuocVC.Checked;
        }

        private void rdbtn_PPT_NhanHeSo_CheckedChanged(object sender, EventArgs e)
        {
            Display.ActiveGrid.Cols.Hidden.SetRange(1, 17, false);
            Display.ActiveGrid.Cols.Hidden.SetRange(8, 14, true);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhanHeSo;
            ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void rdbtn_PPT_NhanHeSoCongCuocVC_CheckedChanged(object sender, EventArgs e)
        {
            Display.ActiveGrid.Cols.Hidden.SetRange(1, 17, false);
            Display.ActiveGrid.Cols.Hidden.SetRange(9, 13, true);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen;
            ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void bbtn_ThemVatLieu_Click(object sender, EventArgs e)
        {
            ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).UpdateData();
        }

        private void btn_TinhCuocOto_Click(object sender, EventArgs e)
        {
            SheetTinhCuocOto sheetTinhCuocOto = new SheetTinhCuocOto();
            sheetTinhCuocOto.ShowDialog();
            //Backbone.Run("CuocOto", "ShowDialog");
        }

        private void btn_SaveWS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Display.WorkingBookDebug.SaveAs(saveFileDialog.FileName);
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
    }
}
