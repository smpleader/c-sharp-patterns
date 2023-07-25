using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.MVC.Presenters.SheetUser;

namespace Worksheet.MVC.Views
{
    public partial class SheetDemo : AView
    {
        SheetP sheetPresenter;
        TestP testPresenter;
        public SheetDemo()
        {
            InitializeComponent();
        }

        private void SheetUser_Load(object sender, EventArgs e)
        {
            sheetPresenter = new SheetP(this);

            testPresenter = new TestP(this);

            reoGridControl1.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);
            reoGridControl2.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // Insert sample data
            MessageBox.Show("Add more records..");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("Starter");
        }
        private async void SheetUser_Shown(Object sender, EventArgs e)
        {
            await Task.Delay(50);
            sheetPresenter.Setup();
        }

        private void reoGridControl1_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show("clci");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            testPresenter.test();
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            sheetPresenter.sheetInput.loadSheetFromSelect();
            //MessageBox.Show(cbData.Text);
        }
        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            sheetPresenter.sheetOutput.loadSheetFromSelect();
            //MessageBox.Show(cbReport.Text);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        // button was removed, kept this function for future test
        private void button8_Click(object sender, EventArgs e)
        {

            // test Excel
            //testPresenter.myTest(textBox1.Text);
            GC.Collect();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Input:"+ sheetPresenter.sheetInput.logs + "\nOuput:" + sheetPresenter.sheetOutput.logs
                );
        }
        
    }
}
