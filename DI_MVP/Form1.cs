using DI.MVP_MI;
using DI.MVP_SI;
using DI.MVP_SI.Application;
using DI.MVP_SI.Services;

namespace DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form Form
        {
            get{  return this;}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MicrosoftDI.ConfigureServices();
            new MVP_MI.Views.UserView().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkBox1.Checked.ToString());
            
            SimpleInjectionDI.ConfigureServices();

            var App = SimpleInjectionDI.container.GetInstance<SApplication>();
            App.State.SwitchScreen = checkBox1.Checked;

            new MVP_SI.Views.StarterView().Show();

            /*if(App.State.SwitchScreen)
            {
                Dispose(); --> DO NOT MAKE THIS BECAUSE WE NEED TO KEEP FORM1 ( MAIN FORM )
            }*/ 

        }
    }
}