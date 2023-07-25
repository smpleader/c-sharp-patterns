using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.MVC.Views;
using Worksheet.Util;
using static System.Windows.Forms.Control;

namespace Worksheet.MVC.Models
{
    internal class SheetFormM
    {
        int countSht = 0;
        int leftBtn = 0;//472;
        int topBtn = 0; //13;
        ReoGridControl rg;
        ComboBox cb;
        protected Stack<Button> btnList = new Stack<Button>();
        ControlCollection ctrl;
        string id;
        string path;
        public string logs{ get; set; }

        public SheetFormM( string ID, string xlsFolder, ReoGridControl reoGridControl, ComboBox combobox, ControlCollection control, int left, int top ) 
        {
            id = ID;
            path = xlsFolder;
            rg = reoGridControl;
            cb = combobox;
            ctrl = control;
            leftBtn = left;
            topBtn = top;
        }

        public void loadSheetFromSelect()
        {
            if (cb.SelectedValue != null)
            {
                // load file
                rg.Load(path + cb.SelectedValue);

                while (btnList.TryPop(out var btn))
                {
                    ctrl.Remove(btn);
                    btn.Click -= clickToChoose;
                    btn.Dispose();
                }
                countSht = 0;

                // create new
                List<unvell.ReoGrid.Worksheet> t = rg.Worksheets.ToList();
                foreach (unvell.ReoGrid.Worksheet w in t)
                {
                    createBtn(w.Name);
                    countSht++;
                }
            }
        }
        public void createBtn(string name)
        {
            int start = (95 * countSht) + leftBtn;
            Button newBtn = new Button();
            newBtn.Name = id + "btn" + countSht;// name;
            newBtn.Text = name;
            newBtn.Size = new System.Drawing.Size(94, 30);
            newBtn.Location = new System.Drawing.Point(start, topBtn);
            newBtn.Click += clickToChoose;//new EventHandler();
            ctrl.Add(newBtn);
            btnList.Push(newBtn);
        }

        public void clickToChoose(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn != null)
            {
                chooseSheet(btn.Text);
            }
        }

        public void chooseSheet(string name)
        {
            string find = "";
            List<unvell.ReoGrid.Worksheet> t = rg.Worksheets.ToList();
            foreach (unvell.ReoGrid.Worksheet w in t)
            {
                if (w.Name == name)
                {
                    find = w.Name;
                }
            }

            if (String.IsNullOrEmpty(find))
            {
                MessageBox.Show("Invalid sheet");
            }
            else
            {
                rg.CurrentWorksheet = rg.Worksheets[find];
            }
        }


    }
}
