using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.IO.OpenXML.Schema;

namespace Worksheet.Data.Sheet
{
    class SheetRange
    {
        protected IWorkbook grid { get; set; }
        protected int sheetIndex { get; set; }
        protected string colStart { get; set; }
        protected string colEnd { get; set; }
        protected Int32 rowStart { get; set; }
        protected Int32 rowEnd { get; set; }
        public string id { get { return colStart + rowStart + colEnd + rowEnd; } }
        private string rangId { get { return colStart + rowStart + ":" + colEnd + rowEnd; } }

        private List<string> value = new List<string>();
       /* public virtual T getValue()
        {
            if(string.IsNullOrEmpty(id))
            {
                throw new Exception("Invalid Range in Sheet Range");
            }

            var data =  grid[sheetIndex].Ranges[rangId]

            var range = new RangePosition(colStart + rowStart + colEnd + rowEnd);

            return value;
        }*/

        private void setRange(string cols, string cole, Int32 rows, Int32 rowe)
        {
            colStart = cols;
            colEnd = cole;
            rowStart = rows;
            rowEnd = rowe;
        }

        private (string, Int32) parseCell(string cell)
        {
            var match = Regex.Match(cell, "(w+)(d+)");
            var col = match.Groups[0].Value;
            var row = Int32.Parse(match.Groups[1].Value);

            if (string.IsNullOrEmpty(col))
            {
                throw new Exception("Invalid Column in Sheet Range");
            }

            if (row < 1)
            {
                throw new Exception("Invalid Row in Sheet Range");
            }

            return (col, row);
        }
        
        public SheetRange(string start, string end)
        {
            (string colStart, Int32 rowStart) = parseCell(start);
            (string colEnd, Int32 rowEnd) = parseCell(end);
            setRange(colStart, colEnd, rowStart, rowEnd);
        }
        public SheetRange(string cell)
        {
            (string col , Int32 row) = parseCell(cell); 
            setRange(col, col, row, row);
        }
        public SheetRange(string colStart, string colEnd, Int32 rowStart, Int32 rowEnd)
        {
            setRange(colStart, colEnd, rowStart, rowEnd);
        }
        public SheetRange(string colStart, string colEnd, Int32 row)
        {
            setRange(colStart, colEnd, row, row);
        }
        public SheetRange(string col, Int32 row) 
        {
            setRange(col, col, row, row);
        }
        public SheetRange(string col, Int32 rowStart, Int32 rowEnd)
        {
            setRange(col, col, rowStart, rowEnd);
        }

        public bool isSingleRow()
        {
            return rowStart == rowEnd;
        }
        public bool isSingleCol()
        {
            return colStart == colEnd;
        }

    }
}
