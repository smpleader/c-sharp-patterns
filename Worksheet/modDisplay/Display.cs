using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.Events;
using Worksheet.modBL;
using Worksheet.modBL.prime.vatlieu;
using Worksheet.modData.Memories.Pointer;
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
        public static ReoGridControl WControl;
        public static WorksheetCollection WB;
        public static unvell.ReoGrid.Worksheet WS;
        public static unvell.ReoGrid.Cell Cell;
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

        private static void setControl(ReoGridControl control)
        {
            WControl = control;
            WB = control.Worksheets; 
        }

        public static void setup(ReoGridControl control, string filePath)
        {
            setControl(control);
            setTemplate(filePath);
            attachEvent();
        }
        public static void setup(ReoGridControl control)
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
                name = WControl.CurrentWorksheet.Name;
            }
            return currentTemplate.Tabs.ContainsKey(name) ? currentTemplate.Tabs[name] : new AGenerator();
        }

        public Dictionary<String, String> State = new Dictionary<String, String>();
        public string state(string key, string? val = null)
        {
            if (null == val)
            {
                val = null == State[key] ? "- not found -" : State[key];
            }
            return val;
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

                    //var t = tab(); MessageBox.Show(t.Name);
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

            foreach (var sheet in WB)
            {
                sheet.CellMouseDown += onClick;
            }
            foreach (var sheet in WB)
            {
                sheet.AfterCellEdit += AfterCellEdit;
            }

            foreach (var sheet in WB)
            {
                sheet.CellDataChanged += CellDataChanged;
            }

            contextMenu.Opening += contextMenuOpen;
        }

        private static void CellDataChanged(object? sender, CellEventArgs e)
        {
            Display.hook("CellDataChanged");

        }
       
        private static void AfterCellEdit(object? sender, CellAfterEditEventArgs e)
        {
            Display.hook("AfterCellInput");
        }

        public static void contextMenuOpen(object sender, EventArgs e)
        {
            tab().addMenu();
        }

        public static void onClick(object sender, CellMouseEventArgs e)
        {
            // unsafe: cell instance may be null
            // var cell = e.Cell;
            // safe: cell instance created from position if not existed 
            Cell = WControl.CurrentWorksheet.CreateAndGetCell(e.CellPosition);
            WS = WControl.CurrentWorksheet;
            Col = new string(Cell.Address.ToString().Where(chr => Char.IsLetter(chr)).ToArray());
            Row = Int32.Parse(new String(Cell.Address.ToString().Where(chr => Char.IsDigit(chr)).ToArray()));
            Display.hook("SelectCell"); 
        }
    }
}
