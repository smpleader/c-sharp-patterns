using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.vatlieu
{
    internal class Generator : AGenerator
    {
        public override string Name { get { return "templates/giavatlieu"; } }

        public SpreadsheetGrid spreadsheetGrid;
        public IWorksheet worksheet;
        bool DangThemVatLieu = false;
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
                    body.bind();
                    body.render();
                    DangThemVatLieu = false;
                }
            }
            
        }
        internal void ThayDoiPPT()
        {
            if (body == null) return;
            DangThemVatLieu = true;
            body.bind();
            body.render();
            DangThemVatLieu = false;
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
