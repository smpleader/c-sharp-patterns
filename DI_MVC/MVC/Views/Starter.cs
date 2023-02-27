namespace DI_MVC.MVC.Views
{
    public partial class Starter : Form, IView
    {
        public Starter()
        {
            InitializeComponent();
        }

        public string Title { get { return Text; } set { Text = value; } }

        public Form Form { get { return this; } }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("User");
        }
    }
}