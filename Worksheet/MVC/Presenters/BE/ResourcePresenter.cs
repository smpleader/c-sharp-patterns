using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid.Events;
using Worksheet.modDisplay;
using Worksheet.MVC.Views;
using Worksheet.MVC.Views.BE;

namespace Worksheet.MVC.Presenters.BE
{
    internal class ResourcePresenter:APresenter<ResourceForm>
    {
        protected ResourceForm _view;
        public ResourcePresenter(ResourceForm view) : base(view)
        {
            _view = view;

            _view.ws.SheetTabNewButtonVisible = false;
            _view.ws.CurrentWorksheet.CellMouseDown += onClick;

            Display.setup(_view.ws, new string[]
            {
                "dg/congviec",
                "dg/vatlieu",
                "dg/nhancong",
                "dg/camay",
                "dg/tonghop"
            }); 

        }

        public void onClick(object sender, CellMouseEventArgs e)
        {
            // unsafe: cell instance may be null
            // var cell = e.Cell;
            // safe: cell instance created from position if not existed 
            modData.Memories.Pointer.Current.Cell = _view.ws.CurrentWorksheet.CreateAndGetCell(e.CellPosition);
            modData.Memories.Pointer.Current.WS = _view.ws.CurrentWorksheet;
            Display.hook("SelectCell");
        } 

    }
}
