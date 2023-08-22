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

        public unvell.ReoGrid.Worksheet ws;
        bool DangThemVatLieu = false;
        Body body;

        public override void init(string tabName)
        {
            if (Display.WB[tabName] != null)
            {
                ws = Display.WB[tabName];
            }
        }

        public override void loadData()
        {
            body = new Body(ws);
            body.bind();
            body.render();
        }
        public override void cellDataChanged()
        {
            if (!DangThemVatLieu)
            {
                DangThemVatLieu = true;
                body.bind();
                body.render();
                DangThemVatLieu = false;
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
                body.rows[selectedIndexRow] = new Row(ws, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                body.bind();
                body.render();

                DangThemVatLieu = false;
            }
        }
    }
}
