using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooterRow = modDisplay.templates.tienluong.row.Footer;

namespace modDisplay.templates.tienluong
{
    internal class Footer : APosition
    {
        FooterRow footer;

        public Footer(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, string hangMucId) : base(spreadsheetGrid, worksheet, workingsheet, hangMucId)
        {
            Id = 16;
        }

        public override void bind(bool maskToWorking = true)
        {
            footer = new FooterRow(spreadsheetGrid, masksheet, workingsheet, Display.HangMucId);
            footer.bind();
            Id = footer.Id;
        }
        public override void render(bool maskToWorking = true)
        {
            footer.render();
        }
    }
}
