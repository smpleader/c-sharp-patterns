using DI.MVP_SI;
using DI.MVP_SI.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DI.MVP_SI.Services
{
    internal class SApplication : Application.IApp
    {
        public Application.State State { get; set; } = new State();

        public void OpenScreen( Form form1, Form form2)
        {
            form1.Dispose();
            form2.Show();
        }
        public void OpenScreen( Form form)
        {
            form.Show();
        }
    }
}
