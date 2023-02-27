using DI.MVP_SI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DI.MVP_SI.Views
{
    public partial class StarterView : Form, IView
    {
        private Presenters.PStart _presenter;
        private SApplication App;
        public StarterView()
        {
            InitializeComponent();
            _presenter = new Presenters.PStart(this);
            App = SimpleInjectionDI.container.GetInstance<SApplication>();
            
            label1.Text = @"Switch screen: " + App.State.SwitchScreen.ToString();
        }
        public void JustDoIt(string message)
        {
            //label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(App.State.SwitchScreen)
            {
                App.OpenScreen(this, new UserView());
            }
            else
            {
                App.OpenScreen(new UserView());
            }
        }
    }
}
