using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DI_Storage.MVC.Presenters.SheetUser;

namespace DI_Storage.MVC.Views
{
    public partial class SheetUser : AView
    {
        FileListP filePresenter;
        SheetP sheetPresenter;
        public SheetUser()
        {
            InitializeComponent();
        }

        private void SheetUser_Load(object sender, EventArgs e)
        {
            filePresenter = new FileListP(this);
            filePresenter.SetupCombo();

            sheetPresenter = new SheetP(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sheetPresenter.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("Starter");
        }
        private void SheetUser_Shown(Object sender, EventArgs e)
        {
            sheetPresenter.LoadData();
        }
    }
}
