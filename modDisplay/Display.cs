using modDisplay.CustomGrid;
using Syncfusion.GridExcelConverter;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System.Diagnostics;
using Util;

namespace modDisplay
{
    public class Display
    {
        public static void init()
        {
            // TODO: scan files in folders and index, save them in resources.files
            foreach (var file in Resources.Files)
            {
                if (!string.IsNullOrEmpty(file.Value.Path) && File.Exists(file.Value.Path))
                {
                    file.Value.Exists = true;
                }
            }
        }

        static FileTemplate currentTemplate;
        public static WorkBook WControl;
        public static GridControl ActiveGrid;
        public static IWorksheet ActiveMaskSheet;

        #region [ Mask sheet]
        public static IWorksheets WorkSheets;
        public static List<string> worksheetNames = new List<string>();
        public static ExcelEngine excelEngine;
        public static IApplication application;
        public static IWorkbook workbook;
        public static IWorksheet ActiveSheet;

        public static GridCurrentCell Cell;
        public static string Col;
        public static int Row;

        #endregion

        #region [ Working sheet]
        /// <summary>
        /// Danh sách working sheet 
        /// <para>Sheet phục vụ tính toán<para>
        /// </summary>
        public static IWorksheets Workingsheets;
        /// <summary>
        /// Working sheet đang được hiển thị
        /// </summary>
        public static IWorksheet Workingsheet { get { return Workingsheets[GetNameWorkingSheet()]; } }
        /// <summary>
        /// Tên sheet hiển thị
        /// </summary>
        public static string WorkingSheetName = "Tiên lượng";
        /// <summary>
        /// Id của hạng mục đang sử dụng
        /// </summary>
        public static string HangMucId = "1";

        // Hiển thị giá trị được tính toán từ working sheet
        public static Spreadsheet WControlDebug;
        public static Dictionary<string, SpreadsheetGrid> GridCollectionDebug;
        public static SpreadsheetGrid ActiveGridDebug;
        public static IWorksheet ActiveMaskSheetDebug;
        public static IWorksheets WorkSheetsDebug;
        public static IWorkbook WorkingBookDebug;
        #endregion

        /// <summary>
        /// Sau có thể load từ BaseInterface.SheetName
        /// </summary>
        public static List<string> DefaultSheetNames;
        static string GetNameWorkingSheet()
        {
            return WorkingSheetName + "_" + HangMucId;
        }
        public static void SetUpWorkingWorkbook()
        {
            DefaultSheetNames = new List<string>();

            ExcelEngine excelEngine = new ExcelEngine();
            var application = excelEngine.Excel;
            WorkingBookDebug = application.Workbooks.Open(AppConst.templateFolder + "Default.xlsx");
            Workingsheets = WorkingBookDebug.Worksheets;
            foreach (var worksheet in Workingsheets)
            {
                DefaultSheetNames.Add(worksheet.Name);
                worksheet.Name += "_" + HangMucId;
                worksheet.EnableSheetCalculations();
            }
        }
        /// <summary>
        /// Tạo thêm hạng mục
        /// <para>Tạo các sheet mặc định của một hạng mục</para>
        /// </summary>
        public static void AddSheets(string hangMucId)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            var application = excelEngine.Excel;
            var wb = application.Workbooks.Open(AppConst.templateFolder + "Default.xlsx");
            foreach (var worksheet in wb.Worksheets)
            {
                worksheet.Name += "_"+ hangMucId;
                worksheet.EnableSheetCalculations();
                Workingsheets.AddCopy(worksheet);

            }
        }
        /// <summary>
        /// Xóa hạng mục
        /// <para>Xóa danh sách các sheet của hạng mục</para>
        /// </summary>
        /// <param name="hangMucId"></param>
        public static void RemoveSheets(string hangMucId)
        {
            foreach(var sheetName in DefaultSheetNames)
            {
                Workingsheets.Remove(sheetName + "_" + hangMucId);
            }
            // todo: Tính toán lại các màn hình tổng hợp công trình
        }    

        public static ContextMenuStrip contextMenu = new ContextMenuStrip();
        public static ToolStripItemCollection menuItems
        {
            get
            {
                return contextMenu.Items;
            }
            set
            {
                contextMenu.Items.Clear();
                ToolStripItemCollection tsc = value;
                foreach (ToolStripItem tsi in tsc)
                {
                    contextMenu.Items.Add(tsi);
                }
            }
        }

        
        private static void setTemplate(string filePath)
        {
            string systemName = filePath.Replace(AppConst.contentFolder, "");
            string[] slugs = systemName.Split("/");
            currentTemplate = Resources.Files[""];

            switch (slugs[0])
            {
                case "Dongia":
                    currentTemplate = Resources.Files["Dongia"];
                    break;
                case "Baogia":
                    currentTemplate = Resources.Files["Baogia"];
                    break;
                default:
                    if (Resources.Files.ContainsKey(systemName))
                    {
                        currentTemplate = Resources.Files[systemName];
                    }
                    break;
            }
        }
        public static void setControlDebug(Spreadsheet control)
        {
            WControlDebug = control;
            GridCollectionDebug = control.GridCollection;
            ActiveGridDebug = control.ActiveGrid;
            ActiveMaskSheetDebug = control.ActiveSheet;
            WorkSheetsDebug = control.Workbook.Worksheets;
        }

        public static void SetActiveWorkingSheet(string name)
        {
            WorkingSheetName = name;
        }
        public static void SetHangMuc(string hmId)
        {
            HangMucId = hmId;
        }

        /// <summary>
        /// Hiển thị dữ liệu từ workingsheet ra masksheet
        /// </summary>
        public static void showData()
        {

            Workingsheet.EnableSheetCalculations(); // bắt buộc khi chuyển sheet để tính toán dữ liệu

            //// Duyệt qua các ô trên tờ và lấy giá trị của từng ô
            for (int row = 1; row <= Workingsheet.Rows.Length; row++)
            {
                for (int col = 1; col <= Workingsheet.Columns.Length; col++)
                {
                    IRange cell = Workingsheet[row, col];
                    var cellValue = cell.Value; // giá trị dạng text nếu có formula thì hiển thị formula

                    if (!string.IsNullOrEmpty(cell.Value))
                    {
                        //Debug.WriteLine($"Giá trị của ô [{row},{col}]: {cellValue}");

                        GridStyleInfo cellUI = ActiveGrid[row, col];
                        cellUI.Text = cell.HasFormula ? cell.CalculatedValue : cell.Value; // hiển thị dạng text
                    }
                }
            }
        }

        /// <summary>
        /// Hiển thị dữ liệu ra sheet debug
        /// </summary>
        public static void showDataDebug()
        {
            Workingsheet.EnableSheetCalculations(); // bắt buộc khi chuyển sheet để tính toán dữ liệu
            // Duyệt qua các ô trên tờ và lấy giá trị của từng ô
            for (int row = 1; row <= Workingsheet.Rows.Length; row++)
            {
                for (int col = 1; col <= Workingsheet.Columns.Length; col++)
                {
                    IRange cell = Workingsheet[row, col];
                    var cellValue = cell.Value; // giá trị dạng text nếu có formula thì hiển thị formula

                    if(!string.IsNullOrEmpty(cell.Value))
                    {
                        Debug.WriteLine($"Giá trị của ô [{row},{col}]: {cellValue}");

                        IRange cellUI = ActiveMaskSheetDebug[row, col];
                        //cellUI.Text = cell.HasFormula ? cell.CalculatedValue : cell.Value; // hiển thị dạng text
                        WControlDebug.ActiveGrid.SetCellValue(cellUI, cellValue); // hiển thị giá trị công thức ref sẽ bị invalid do đang lấy ref theo working sheet

                    }
                }
            }
            WControlDebug.ActiveGrid.InvalidateCells(); // hiển thị lên spreadsheet
        }

        public static void setControl(WorkBook control)
        {
            WControl = control;
            ActiveGrid = control._grid;
        }
   
        public static void setup(WorkBook control, string filePath)
        {
            setControl(control);
            setTemplate(filePath);
            attachEvent();
        }
        public static void setup(WorkBook control)
        {
            if (currentTemplate == null)
            {
                throw new Exception("Template file not set");
            }

            setControl(control);
            attachEvent();
        }
        public static void setup(string filePath)
        {
            if (null == WControl)
            {
                throw new Exception("Workbook control not set");
            }

            setTemplate(filePath);
            attachEvent();
        }

        public static ISheet tab(string name = "")
        {
            if (name == "")
            {
                name = WorkingSheetName;
            }
            return currentTemplate.Tabs.ContainsKey(name) ? currentTemplate.Tabs[name] : new AGenerator();
        }

        public static void hook(string name)
        {
            switch (name)
            {
                case "loadData":
                case "LoadData":
                    if (WorkSheets != null)
                    {
                        foreach (var tab in currentTemplate.Tabs)
                        {
                            tab.Value.loadData();
                        };
                    }
                    break;
                case "beforeSave":
                case "BeforeSave":
                    foreach (var tab in currentTemplate.Tabs)
                    {
                        tab.Value.beforeSave();
                    };
                    break;
                case "afterSave":
                case "AfterSave":
                    foreach (var tab in currentTemplate.Tabs)
                    {
                        tab.Value.afterSave();
                    };
                    break;
                case "selectCell":
                case "SelectCell":
                    tab().selectCell();
                    break;
                case "afterCellInput":
                case "AfterCellInput":
                    tab().afterCellInput();
                    break;
                case "CellDataChanged":
                case "cellDataChanged":
                    tab().cellDataChanged();
                    break;
            }
        }

        private static void attachEvent()
        {
            foreach (var tab in currentTemplate.Tabs)
            {
                tab.Value.init(tab.Key);
            };

            WControl.OnCurrentCellChanged += WControl_OnCurrentCellChanged;
            WControl._grid.CurrentCellEditingComplete += new EventHandler(_grid_CurrentCellEditingComplete);
            WControl._grid.Model.ColWidthsChanged += Model_ColWidthsChanged;
            WControl._grid.Model.RowHeightsChanged += Model_RowHeightsChanged; ;


            contextMenu.Opening += contextMenuOpen;
        }

        // Lưu lại sự thay đổi của Row từ masksheet vào workingsheet
        private static void Model_RowHeightsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            if(e.Success)
            {
                int to = e.To;
                int start = e.From;
                while (start <= to)
                {
                    double value = Workingsheet.PixelsToColumnWidth(ActiveGrid.RowHeights[start]);
                    Workingsheet.SetRowHeight(start, value);
                    start++;
                }
            }    
        }

        // Lưu lại sự thay đổi của Col từ masksheet vào workingsheet
        private static void Model_ColWidthsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            if (e.Success)
            {
                int to = e.To;
                int start = e.From;
                while(start <= to)
                {
                    double value = Workingsheet.PixelsToColumnWidth(ActiveGrid.ColWidths[start]);
                    Workingsheet.SetColumnWidth(start, value);
                    start++;
                }    
            }
        }

        private static void _grid_CurrentCellEditingComplete(object? sender, EventArgs e)
        {
            // hook để lấy sự kiện cell value changed
            hook("CellDataChanged");
            hook("AfterCellInput");
        }

        private static void WControl_OnCurrentCellChanged(Syncfusion.Windows.Forms.Grid.GridCurrentCell currentCell)
        {
            Cell = currentCell;
            Col = Cell.ColIndex > 0 ? Util.CellUtility.GetExcelColumnLetter(Cell.ColIndex) : "A";
            Row = Cell.RowIndex > 0 ? Cell.RowIndex : 1;
            hook("SelectCell");
        }
        public static void contextMenuOpen(object sender, EventArgs e)
        {
            tab().addMenu();
        }

    }
}
