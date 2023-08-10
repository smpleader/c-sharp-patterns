using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Worksheet.modDisplay;
using Worksheet.MVC.Models;
using Worksheet.Util;

namespace Worksheet.MVC.Views.BE
{
    public partial class Resource : AView
    {
        Presenters.BE.ResourcePresenter rp;
        DemoM model;
        bool loaded = false;
        public Resource()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Backbone.Run("SheetDemo");
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            ResourceNameForm dialog = new ResourceNameForm();
            dialog.Text = "Tạo Báo Giá";

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(dialog.filename.Text))
                {
                    MessageBox.Show("Invalid file name");
                }
                else
                {
                    if (!Directory.Exists(AppConst.BaoGiaFolder))
                    {
                        Directory.CreateDirectory(AppConst.BaoGiaFolder);
                    }
                    string newFile = AppConst.BaoGiaFolder + "/" + dialog.filename.Text;

                    if (File.Exists(newFile))
                    {
                        MessageBox.Show("File đã tồn tại!");
                    }
                    else
                    {
                        File.Copy(AppConst.templateFolder + "/baogia.xlsx", newFile);
                    }

                    loadCombobox("Báo giá: " + dialog.filename.Text.Replace(".xlsx", ""));

                    ws.Load(newFile);
                }
            }

            dialog.Dispose();
        }

        private void btnDG_Click(object sender, EventArgs e)
        {
            ResourceNameForm dialog = new ResourceNameForm();
            dialog.Text = "Tạo Đơn Giá";

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(dialog.filename.Text))
                {
                    MessageBox.Show("Invalid file name");
                }
                else
                {
                    if (!Directory.Exists(AppConst.DonGiaFolder))
                    {
                        Directory.CreateDirectory(AppConst.DonGiaFolder);
                    }
                    string newFile = AppConst.DonGiaFolder + "/" + dialog.filename.Text;
                    if (File.Exists(newFile))
                    {
                        MessageBox.Show("File đã tồn tại!");
                    }
                    else
                    {
                        File.Copy(AppConst.templateFolder + "/dongia.xlsx", newFile);
                    }

                    loadCombobox("Đơn giá: " + dialog.filename.Text.Replace(".xlsx", ""));
                    ws.Load(newFile);
                }
            }

            dialog.Dispose();
        }

        private void cbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFile.SelectedValue != null && !String.IsNullOrEmpty(cbFile.SelectedValue.ToString()))
            {
                ws.Load(cbFile.SelectedValue.ToString());
            }
        }

        private void ResourceForm_Load(object sender, EventArgs e)
        {
            model = new DemoM();
            rp = new Presenters.BE.ResourcePresenter(this);

            loadCombobox();
            ws.CurrentWorksheet.SetRows(10000);
            ws.WorkbookSaved += AfterSave;
            ws.WorkbookLoaded += AfterLoad;
            ws.ContextMenuStrip = Display.contextMenu;

            Display.setup(ws, cbFile.SelectedValue.ToString());
            Display.hook("LoadData");

        }

        private void loadCombobox(string item = "")
        {
            List<string> ls1 = model.ComboboxTemplateList(AppConst.DonGiaFolder);
            List<string> ls2 = model.ComboboxTemplateList(AppConst.BaoGiaFolder);
            var ls = new Dictionary<string, string>();
            foreach (string s in ls1)
            {
                string k = "Đơn giá: " + s.Replace(".xlsx", "");
                ls[k] = AppConst.DonGiaFolder + s;
            }

            ls["--"] = "";

            foreach (string s in ls2)
            {
                string k = "Báo giá: " + s.Replace(".xlsx", "");
                ls[k] = AppConst.BaoGiaFolder + s;
            }

            cbFile.DisplayMember = "Key";
            cbFile.ValueMember = "Value";
            cbFile.DataSource = new BindingSource(ls, null);

            if (item == "")
            {
                cbFile.SelectedIndex = 0;
            }
            else
            {
                cbFile.SelectedIndex = cbFile.FindStringExact(item);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbFile.SelectedValue != null && !String.IsNullOrEmpty(cbFile.SelectedValue.ToString()))
            {
                Display.hook("BeforeSave");
                ws.Save(cbFile.SelectedValue.ToString(), unvell.ReoGrid.IO.FileFormat.Excel2007);
                //GC.Collect();
            }
        }
        public void AfterSave(object sender, EventArgs e)
        {
            Display.hook("AfterSave");
            MessageBox.Show("Saved " + cbFile.SelectedValue.ToString());
        }
        public async void AfterLoad(object sender, EventArgs e)
        {
            //MessageBox.Show("load file: " + cbFile.SelectedValue.ToString());

            // a little time to be sure file get loaded
            await Task.Delay(500);
            Display.setup(cbFile.SelectedValue.ToString());

            Display.hook("LoadData");
        }
    }
}
