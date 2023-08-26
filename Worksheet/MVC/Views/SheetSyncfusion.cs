using Syncfusion.Windows.Forms.CellGrid.ScrollAxis;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.GraphicCells;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.modDisplay;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetSyncfusion : AView
    {
        private SyncfusionP syncfusionP;

        public SheetSyncfusion()
        {
            registerPresenters(true);
            InitializeComponent();
            Worksheet.modBL.Container.init();
        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("SyncfusionTienLuong", "DemoSyncfusion");
            }
            else
            {
                if (null == syncfusionP) syncfusionP = new SyncfusionP(this);
                Publisher.register("SyncfusionTienLuong", syncfusionP);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_BackDemo_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_TienLuong.Open(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }

        private void btn_LuuFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_TienLuong.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Lưu thành công! " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lưu lỗi. {ex}");
                        MessageBox.Show("Lưu thất bại! " + ex);

                    }
                }
            }
        }

        private void chkbx_KichThuoc_CheckedChanged(object sender, EventArgs e)
        {
            sheet_TienLuong.ActiveGrid.ColumnWidths.SetHidden(5, 12, !chkbx_KichThuoc.Checked);
        }

        private void btn_ThemCongViec_Click(object sender, EventArgs e)
        {
            ((Worksheet.modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).updateData();
        }

        private void SheetSyncfusion_Load(object sender, EventArgs e)
        {
            syncfusionP = (SyncfusionP)Publisher.get("SyncfusionTienLuong");
            syncfusionP.Setup();

            sheet_TienLuong.WorkbookLoaded += AfterLoad;
        }

        private void AfterLoad(object sender, WorkbookLoadedEventArgs args)
        {
            // sau khi load workbook thì mới tiếp cận được activesheet và activegrid
            Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
        }
    }
}
