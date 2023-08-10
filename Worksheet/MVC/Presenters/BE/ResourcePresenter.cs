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
    internal class ResourcePresenter:APresenter<Resource>
    {
        protected Resource _view;
        public ResourcePresenter(Resource view) : base(view)
        {
            // This should be put at Screen Startup
            Display.init();

            _view = view;


            //MessageBox.Show(_view.ws.CurrentWorksheet.Name);

        }

        public void test(string s1, string s2)
        {
            MessageBox.Show("Got " + s1 + " and " + s2);
        }
    }
}
