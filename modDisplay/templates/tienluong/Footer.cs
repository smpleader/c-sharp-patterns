using Syncfusion.Windows.Forms.Grid;
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
        public Footer(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet) : base(gridControl, worksheet, workingsheet)
        {
            Id = 16;
            start = Id;
            end = Id;
        }
        public override void bindInWoringsheet()
        {
            footer = new FooterRow(gridControl, masksheet, workingsheet);
            footer.bind();
            Id = footer.Id;
            start = footer.Id;
            end = footer.Id;
        }
        public override void renderInWorkingsheet()
        {
            footer.render();
        }

        public override void bind(bool maskToWorking = true)
        {
            footer = new FooterRow(gridControl, masksheet, workingsheet);
            footer.bind();
            Id = footer.Id;
            start = footer.Id;
            end = footer.Id;

        }
        public override void render(bool maskToWorking = true)
        {
            footer.render();
        }
    }
}
