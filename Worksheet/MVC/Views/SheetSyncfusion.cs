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
using Microsoft.Office.Interop.Excel;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridExcelConverter;

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
     
        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Files(*.xlsx)|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LoadMaskSheet(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }
        public void LoadMaskSheet(string path)
        {
            Display.excelEngine = new ExcelEngine();

            Display.application = Display.excelEngine.Excel;
            Display.application.DefaultVersion = ExcelVersion.Xlsx;

            Display.workbook = Display.application.Workbooks.Open(path);
            Display.WorkSheets = Display.workbook.Worksheets;
            cbb_SheetActive.Items.Clear();
            foreach (var worksheet in Display.WorkSheets)
            {
                Display.worksheetNames.Add(worksheet.Name);
                cbb_SheetActive.Items.Add(worksheet.Name);
            }
            cbb_SheetActive.Text = Display.worksheetNames[0];

            // sau khi load workbook thì mới tiếp cận được activesheet và activegrid
            Display.setup(workbook, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
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
            #region [WorkBook]
            WorkBook workBook = new WorkBook();
            workBook.OnButtonClick += MainForm_OnButtonClick;

            this.workbook = workBook;

            // load workbook vào 1 panel chỉ định
            workBook.LoadWorkbook(pnl_Body);

            //workBook._grid.CurrentCellControlKeyMessage += _grid_CurrentCellControlKeyMessage;

            #endregion
            BaseInterface.IModBL modBLContainer = modDisplay.SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            modBLContainer.Init();
            syncfusionP = (SyncfusionP)Publisher.get("SyncfusionTienLuong");
            syncfusionP.Setup();
            sheet_working.WorkbookLoaded += AfterLoad2;

            
        }
        private void MainForm_OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Event click is triggered ");
        }

        private void AfterLoad2(object sender, WorkbookLoadedEventArgs args)
        {
            Display.setControlDebug(sheet_working);
        }

        // Xử lý tab vật liệu
        private void rdbtn_PPT_NhapTay_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            Display.ActiveGrid.Cols.Hidden.SetRange(1, 16, false);
            Display.ActiveGrid.Cols.Hidden.SetRange(7, 12, true);
            Display.ActiveGrid.Cols.Hidden.SetRange(14, 14, true);
            if(rdbtn_PPT_NhapTay.Checked)
            {
                Option.PPTGiaVatLieu = PPTGiaVatLieu.NhapTay;
                ((modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
            }
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

        // Hàm để chuyển đổi style từ GridControl sang IWorksheet
        public static void CopyStyles(IWorksheet source, IWorksheet dest, bool clearData = true)
        {
            GridControl gridControlTemp = new GridControl();
            GridExcelConverterControl gecc = new GridExcelConverterControl();

            // step 1: Chuyển iworksheet source to grid
            gecc.ExcelToGrid(source, gridControlTemp.Model);

            // step 2: Xóa data của gridcontrol nhưng vẫn giữ lại style
            if (clearData)
            {
                for (int rowIndex = 1; rowIndex <= gridControlTemp.RowCount; rowIndex++)
                {
                    for (int colIndex = 1; colIndex <= gridControlTemp.ColCount; colIndex++)
                    {
                        gridControlTemp[rowIndex, colIndex].CellValue = null;
                    }
                }
            }

            // step 3: copy data from iworksheet dest to grid
            // Read data from the worksheet and set it to the GridControl
            for (int rowIndex = 1; rowIndex <= dest.UsedRange.LastRow; rowIndex++)
            {
                for (int colIndex = 1; colIndex <= dest.UsedRange.LastColumn; colIndex++)
                {
                    object cellValue = dest[rowIndex, colIndex].Value2;
                    gridControlTemp[rowIndex, colIndex].CellValue = cellValue;
                }
            }

            // step 4: Chuyển đổi từ GridControl sang IWorksheet dest
            gecc.GridToExcel(gridControlTemp.Model, dest);
        }

        // Hàm để chuyển đổi từ GridControl sang IWorksheet
        public void ConvertGridToWorksheet(GridControl gridControl, IWorksheet worksheet, bool clearData = true)
        {
            // Xóa data của gridcontrol nhưng vẫn giữ lại style
            if (clearData)
            {
                for (int rowIndex = 1; rowIndex <= gridControl.RowCount; rowIndex++)
                {
                    for (int colIndex = 1; colIndex <= gridControl.ColCount; colIndex++)
                    {
                        gridControl[rowIndex, colIndex].CellValue = null;
                    }
                }
            }    
           
            // Chuyển đổi từ GridControl sang IWorksheet
            GridExcelConverterControl gecc = new GridExcelConverterControl();
            gecc.GridToExcel(gridControl.Model, worksheet);
        }
        private void cbb_SheetActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Display.ActiveSheet != null)
            {
                ConvertGridToWorksheet(this.workbook._grid, Display.ActiveSheet);
                // Get the row and column indexes from the IRange
                int startRow = Display.ActiveSheet.UsedRange.Row;
                int endRow = Display.ActiveSheet.UsedRange.Row + Display.ActiveSheet.UsedRange.Rows.Length - 1;
                endRow = endRow > 0 ? endRow : 0;
                int startColumn = Display.ActiveSheet.UsedRange.Column;
                int endColumn = Display.ActiveSheet.UsedRange.Column + Display.ActiveSheet.UsedRange.Columns.Length - 1;
                endColumn = endColumn > 0 ? endColumn : 0;
                GridRangeInfo gridRangeInfo = GridRangeInfo.Cells(startRow, startColumn, endRow, endColumn);
                this.workbook._grid.Model.ClearCells(gridRangeInfo, true);
            }
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();
            Display.ActiveSheet = Display.WorkSheets[cbb_SheetActive.Text];

            gecc.ExcelToGrid(Display.ActiveSheet, this.workbook._grid.Model);
            this.workbook._grid.Refresh();

            Display.setControl(this.workbook);

            if (cbb_SheetActive.Text == "") return;
            Display.SetActiveWorkingSheet(cbb_SheetActive.Text);
            if (Display.WControlDebug != null)
            {
                Display.WControlDebug.ActiveSheet = Display.WControlDebug.Workbook.Worksheets[cbb_SheetActive.Text];
            }
            switch (cbb_SheetActive.Text)
            {
                case "Tiên lượng":
                    pnl_VatLieu.Visible = false;
                    Display.ActiveGrid.Cols.Hidden.SetRange(5, 12, !chkbx_KichThuoc.Checked);
                    btn_ThemCongViec.Enabled = true;
                    chkbx_KichThuoc.Enabled = true;
                    break;
                case "Giá vật liệu":
                    pnl_VatLieu.Visible = true;
                    btn_ThemCongViec.Enabled = false;
                    chkbx_KichThuoc.Enabled = false;
                    switch (Option.PPTGiaVatLieu)
                    {
                        case PPTGiaVatLieu.NhapTay:
                            rdbtn_PPT_NhapTay.Checked = true;
                            Display.ActiveGrid.Cols.Hidden.SetRange(1, 16, false);
                            Display.ActiveGrid.Cols.Hidden.SetRange(7, 12, true);
                            Display.ActiveGrid.Cols.Hidden.SetRange(14, 14, true);
                            break;
                        case PPTGiaVatLieu.CongCuocVanChuyen:
                            rdbtn_PPT_CongCuocVC.Checked = true;
                            break;
                        case PPTGiaVatLieu.NhanHeSo:
                            rdbtn_PPT_NhanHeSo.Checked = true;
                            break;
                        case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                            rdbtn_PPT_NhanHeSoCongCuocVC.Checked = true;
                            break;
                    }
                    break;
            }
            Display.showData();
        }
        bool isShowBottom = true;
        private void btn_ShowDebug_Click(object sender, EventArgs e)
        {
            isShowBottom = !isShowBottom;
            pnl_Bottom.Visible = isShowBottom;
        }
    }
}
