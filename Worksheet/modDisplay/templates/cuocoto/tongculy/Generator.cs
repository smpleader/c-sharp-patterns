﻿using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modDisplay.templates.cuocoto.tongculy.row;
using HeaderGroup = Worksheet.modDisplay.templates.cuocoto.tongculy.Header;

namespace Worksheet.modDisplay.templates.cuocoto.tongculy
{
    internal class Generator : AGenerator
    {
        public override string Name { get { return "templates/cuocoto/tongculy"; } }

        public SpreadsheetGrid spreadsheetGrid;
        public IWorksheet worksheet;
        bool DangThemVatLieu = false;
        HeaderGroup header;
        Body body;

        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                worksheet = Display.WorkSheets[tabName];
                spreadsheetGrid = Display.GridCollection[tabName];
                worksheet.UseRangesCache = false;
            }
        }

        public override void loadData()
        {
            // header
            header = new HeaderGroup(spreadsheetGrid, worksheet);
            header.bind();
            header.render();

            body = new Body(spreadsheetGrid,worksheet);
            body.bind();
            body.render();
        }
        public override void afterCellInput()
        {
            if(body != null)
            {
                if (!DangThemVatLieu)
                {
                    DangThemVatLieu = true;
                    header.bind();
                    header.render();

                    body.bind();
                    body.render();
                    DangThemVatLieu = false;
                }
            }
            
        }

        internal void updateData()
        {
            // thêm vật liệu vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm vật liệu
                DangThemVatLieu = true;
                body.rows[selectedIndexRow] = new Row(spreadsheetGrid, worksheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                spreadsheetGrid.BeginUpdate();
                selectedRow.AddSimpleData();
                body.bind();
                body.render();
                spreadsheetGrid.EndUpdate();
                DangThemVatLieu = false;
            }
        }
    }
}
