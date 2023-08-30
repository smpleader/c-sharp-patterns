using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.CellGrid.Helpers;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.Windows.Input;
using Worksheet.Util;

namespace Worksheet.modDisplay
{
    internal class Display
    {
        public static void init()
        {
            // TODO: scan files in folders and index, save them in resources.files
            foreach (var file in Resources.Files)
            {
                if (!String.IsNullOrEmpty(file.Value.Path) && File.Exists(file.Value.Path))
                {
                    file.Value.Exists = true;
                }
            }
        }

        static FileTemplate currentTemplate;
        public static Spreadsheet WControl;
        public static Dictionary<string, SpreadsheetGrid> GridCollection;
        public static SpreadsheetGrid ActiveGrid;
        public static IWorksheet ActiveWorkSheet;
        public static IWorksheets WorkSheets;

        public static IRange SelectedCell;
        public static GridCurrentCell Cell;
        public static string Col;
        public static int Row;

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
                ToolStripItemCollection tsc = (ToolStripItemCollection)value;
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

        public static void setControl(Spreadsheet control)
        {
            WControl = control;
            GridCollection = control.GridCollection;
            ActiveGrid = control.ActiveGrid;
            ActiveWorkSheet = control.ActiveSheet;
            WorkSheets = control.Workbook.Worksheets;
        }

        public static void setActiveSheet(Spreadsheet control)
        {
            WControl = control;
            GridCollection = control.GridCollection;
            ActiveGrid = control.ActiveGrid;
            ActiveWorkSheet = control.ActiveSheet;
            WorkSheets = control.Workbook.Worksheets;
        }

        public static void changeTab(Spreadsheet control)
        {
            if (WControl != null)
            {
                control.GridCollection.Clear();
                for (int x = GridCollection.Keys.Count - 1; x > -1; x--)
                {
                    string key = GridCollection.Keys.ElementAt(x);
                    GridCollection.Remove(key, out SpreadsheetGrid value);
                    control.GridCollection[key] = value;
                }
                // trick để xử lý việc chuyển đổi các sheets giữa 2 ReogridControl
                //WControl.AddSheet();
            }
            setControl(control);
        }
        public static void changeTab(Spreadsheet src, Spreadsheet des)
        {
            if (src != null && des != null)
            {
                List<string> sheetNames = src.Workbook.Worksheets.Select(item => item.Name).ToList();
                foreach (string sheetName in sheetNames)
                {
                    var cloneSheet = src.Workbook.Worksheets[sheetName];
                    //des.Workbook.Worksheets.Remove(sheetName);
                    des.Workbook.Worksheets.AddCopy(cloneSheet,
                        ExcelWorksheetCopyFlags.CopyMerges
                        //| ExcelWorksheetCopyFlags.CopyAll
                        //| ExcelWorksheetCopyFlags.CopyCells
                        //| ExcelWorksheetCopyFlags.CopyColumnHeight
                        //| ExcelWorksheetCopyFlags.CopyAutoFilters
                        //| ExcelWorksheetCopyFlags.CopyOptions
                        //| ExcelWorksheetCopyFlags.CopyConditionlFormats
                        //| ExcelWorksheetCopyFlags.CopyShapes
                        //| ExcelWorksheetCopyFlags.CopyDataValidations
                        //| ExcelWorksheetCopyFlags.CopyPalette
                        );
                    //src.GridCollection.Remove(sheetName, out SpreadsheetGrid value);
                    des.GridCollection[sheetName] = src.GridCollection[sheetName];
                    foreach(var gridRange in des.GridCollection[sheetName].CoveredCells.Ranges)
                    {
                        var excelRange = gridRange.ConvertGridRangeToExcelRange(des.GridCollection[sheetName]);
                        des.Workbook.Worksheets[sheetName].Range[excelRange.ToString()].Merge();
                        des.GridCollection[sheetName].InvalidateCell(gridRange.Right, gridRange.Top);
                    }
                    //des.Workbook.Worksheets[sheetName].Calculate();
                    //des.GridCollection[sheetName].Refresh();
                }    
            }
            else
            {
                // todo: handle error
            }    
        }
        public static void setup(Spreadsheet control, string filePath)
        {
            setControl(control);
            setTemplate(filePath);
            attachEvent();
        }
        public static void setup(Spreadsheet control)
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
                name = WControl.ActiveSheet.Name;
            }
            return currentTemplate.Tabs.ContainsKey(name) ? currentTemplate.Tabs[name] : new AGenerator();
        }

        public static void hook(string name)
        {
            switch (name)
            {
                case "loadData":
                case "LoadData":
                    if (GridCollection != null)
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

            foreach (var sheet in GridCollection.Values)
            {
                sheet.CellClick += onClick;
            }
            foreach (var sheet in GridCollection.Values)
            {
                sheet.CurrentCellEndEdit += AfterCellEdit;
            }
         
            foreach (var sheet in WorkSheets)
            {
                sheet.CellValueChanged += CellDataChanged;
            }
            contextMenu.Opening += contextMenuOpen;
        }

        private static void CellDataChanged(object sender, Syncfusion.XlsIO.Implementation.CellValueChangedEventArgs e)
        {
            hook("CellDataChanged");
        }
        private static void AfterCellEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            hook("AfterCellInput");
        }

        private static void onClick(object sender, GridCellClickEventArgs e)
        {
            Cell = ActiveGrid.SelectionController.CurrentCell;
            Col = e.ColumnIndex > 0 ? Util.CellUtility.GetExcelColumnLetter(e.ColumnIndex) :"A";
            Row = e.RowIndex > 0 ? e.RowIndex: 1;
            SelectedCell = ActiveWorkSheet.Range[Col + Row];
            hook("SelectCell");
        }
        
        public static void contextMenuOpen(object sender, EventArgs e)
        {
            tab().addMenu();
        }

    }
}
