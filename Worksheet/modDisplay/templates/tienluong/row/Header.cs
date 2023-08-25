﻿using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Header : ARowObject
    {
        public Header(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            ws = spreadsheetGrid;
            this.worksheet = worksheet;
            Id = id;
        }
        /// <summary>
        /// Tên công trình hoặc tên hạng mục
        /// </summary>
        public IRange B { get { return this.Cell("B"); } }
        public void bind()
        {
            // todo: Lưu giá trị của header tới global state
        }

        public void render()
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
        }
    }
}
