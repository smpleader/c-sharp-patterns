using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.CellGrid.Helpers;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
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
        public static Dictionary<string, SpreadsheetGrid> WB;
        public static SpreadsheetGrid WS;
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

        private static void setControl(Spreadsheet control)
        {
            WControl = control;
            WB = control.GridCollection;
            WS = control.ActiveGrid;
            ActiveWorkSheet = control.ActiveSheet;
            WorkSheets = control.Workbook.Worksheets;
        }

        public static void changeTab(Spreadsheet control)
        {
            if (WControl != null)
            {
                control.GridCollection.Clear();
                for (int x = WB.Keys.Count - 1; x > -1; x--)
                {
                    string key = WB.Keys.ElementAt(x);
                    WB.Remove(key, out SpreadsheetGrid value);
                    control.GridCollection[key] = value;
                }
                // trick để xử lý việc chuyển đổi các sheets giữa 2 ReogridControl
                //WControl.AddSheet();
            }
            setControl(control);
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
                name = WControl.ActiveGrid.Name;
            }
            return currentTemplate.Tabs.ContainsKey(name) ? currentTemplate.Tabs[name] : new AGenerator();
        }

        public static void hook(string name)
        {
            switch (name)
            {
                case "loadData":
                case "LoadData":
                    if (WB != null)
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

            foreach (var sheet in WB.Values)
            {
                sheet.CellClick += onClick;
            }
            foreach (var sheet in WB.Values)
            {
                sheet.CurrentCellEndEdit += AfterCellEdit;
            }

            foreach (var sheet in WB.Values)
            {
                sheet.CurrentCellValueChanged += CellDataChanged;
            }

            contextMenu.Opening += contextMenuOpen;
        }

        private static void CellDataChanged(object sender, CurrentCellValueChangedEventArgs e)
        {
            hook("CellDataChanged");
        }

        private static void CellDataChanged(object sender, ValueChangedEventArgs e)
        {
            hook("CellDataChanged");
        }

        private static void AfterCellEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            hook("AfterCellInput");
        }

        private static void onClick(object sender, GridCellClickEventArgs e)
        {
            Cell = WS.SelectionController.CurrentCell;
            Col = Util.CellUtility.GetExcelColumnLetter(e.ColumnIndex);
            Row = e.RowIndex;
            SelectedCell =  ActiveWorkSheet.Range[Col + Row];
            hook("SelectCell");
        }
        
        public static void contextMenuOpen(object sender, EventArgs e)
        {
            tab().addMenu();
        }

    }
}
