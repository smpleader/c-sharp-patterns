namespace DI_MVC.MVC.Views
{
    public partial class Starter : AView
    {
        public Starter()
        {
            InitializeComponent();
            //this.FormClosing += new FormClosingEventHandler(Starter_FormClosing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("User");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Backbone.Run("User");
        }

        private void Starter_FormClosing(object sender, FormClosingEventArgs e)
        {
            // how we do something before close
            MessageBox.Show(sender.GetType().Name);
        }
    }
}