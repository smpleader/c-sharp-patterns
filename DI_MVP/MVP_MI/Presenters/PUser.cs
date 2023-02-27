using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.MVP_MI.Models;
using DI.MVP_MI.Views;
using DI.MVP_MI.Services;

namespace DI.MVP_MI.Presenters
{
    internal class PUser
    {
        private readonly IView _view;
        private SIUser userService;
        public PUser(IView view)
        {
            _view = view;
            userService = MicrosoftDI.GetService<SIUser>(); // request service object from ServiceProvider

            JustDoIt(); // quick sample for calling method from presenter
        }

        public void JustDoIt()
        {
            _view.JustDoIt("Hello User!");
        }

        public MUser GetUserModel()
        {
            return userService.GetUser(1); // calling method from ui
        }
    }
}
