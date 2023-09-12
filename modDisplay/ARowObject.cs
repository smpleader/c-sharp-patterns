﻿using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using Row = modData.Memories.ARecord;

namespace modDisplay
{
    public class ARowObject : Row
    {
        public ARowObject(SpreadsheetGrid spreadsheetGrid, IWorksheet masksheet, IWorksheet workingsheet)
        {
            this.spreadsheetGrid = spreadsheetGrid;
            this.masksheet = masksheet;
            this.workingsheet = workingsheet;
        }
        public SpreadsheetGrid spreadsheetGrid { get; set; }
        public IWorksheet masksheet { get; set; }
        public IWorksheet workingsheet { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public int height { get { return end - start; } }
        public void import(int s, int e)
        {
            // todo : asign column from masksheet
        }
    }
}
