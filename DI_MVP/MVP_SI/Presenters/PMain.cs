using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.MVP_SI.Models;
using DI.MVP_SI.Views;
using DI.MVP_SI.Services;

namespace DI.MVP_SI.Presenters
{
    internal class PMain
    {
        private readonly IView _view;
        private SIUser userService;
        private SPost postService;
        public PMain(IView view)
        {
            _view = view;
            userService = SimpleInjectionDI.container.GetInstance<SIUser>(); 
            postService = SimpleInjectionDI.container.GetInstance<SPost>();

            JustDoIt(); // quick sample for calling method from presenter
        }

        public void JustDoIt()
        {
            _view.JustDoIt("Hello Baby!");
        }

        public MUser GetUserData()
        {
            return userService.GetUser(1); // calling method from ui
        }

        public MPost GetPostData()
        {
            return postService.GetPost(2); // calling method from ui
        }
    }
}
