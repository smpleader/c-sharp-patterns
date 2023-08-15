using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.modData.Memories.Models;
using Worksheet.modDisplay;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTienLuong : AView
    {
        private TienLuongP tienLuongP;
        private VatLieuP vatLieuP;

        public SheetTienLuong()
        {
            registerPresenters(true);
            InitializeComponent();
        }

        private void SheetTienLuong_Load(object sender, EventArgs e)
        {
            tienLuongP = (TienLuongP)Publisher.get("SheetTienLuong");
            tienLuongP.Setup();
            vatLieuP = (VatLieuP)Publisher.get("SheetVatLieu");
            vatLieuP.Setup();
            sheet_TienLuong.CurrentWorksheet.SetRows(10000);
            sheet_TienLuong.WorkbookSaved += AfterSave;
            sheet_TienLuong.WorkbookLoaded += AfterLoad;
            sheet_TienLuong.ContextMenuStrip = Display.contextMenu;

            Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
        }

        private void btn_ThemCongViec_Click(object sender, EventArgs e)
        {
            modData.Memories.Record.HangMuc t = new modData.Memories.Record.HangMuc("ten 1", "kieu 1");
            t.txt("test", "oo1");
            HangMuc.them(t);
            t = new modData.Memories.Record.HangMuc("ten 2", "kieu 2");
            t.txt("test", "oo2");
            HangMuc.them(t);

            modData.Memories.Record.CongViec cv = new modData.Memories.Record.CongViec(1);
            CongViec.them(cv);

            cv.ColText["ma"] = "AG.11111";
            cv.ColText["stt"] = "1";
            cv.ColText["ten"] = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
            cv.ColText["donVi"] = "m3";

            cv.ColText["thongTinDonGia"] = "DinhMuc_2021XD_D12";

            cv.ColNum["tongGiaVatLieu"] = 685204;
            cv.ColNum["tongGiaVatLieuPhu"] = 0;
            cv.ColNum["tongGiaNhanCong"] = 288111;
            cv.ColNum["tongGiaMay"] = 70230;
            cv.ColText["startRow"] = "6";
            cv.ColText["EndRow"] = "6";
            cv.Id = 6;

            cv = new modData.Memories.Record.CongViec(1);

            cv.ColText["ma"] = "MA.01005";
            cv.ColText["stt"] = "2";
            cv.ColText["ten"] = "Lắp đặt máy công cụ và máy gia công kim loại - Khối lượng máy ≤20 tấn";
            cv.ColText["donVi"] = "tấn";

            cv.ColText["thongTinDonGia"] = "DinhMuc_2021XD_D12";

            cv.ColNum["tongGiaVatLieu"] = 100103;
            cv.ColNum["tongGiaVatLieuPhu"] = 0;
            cv.ColNum["tongGiaNhanCong"] = 3022200;
            cv.ColNum["tongGiaMay"] = 635528;
            cv.ColText["startRow"] = "7";
            cv.ColText["EndRow"] = "7";
            cv.ColText["EndRow"] = "7";
            cv.Id = 7;
            CongViec.them(cv);

            string debug = "";

            modData.memories.Storage.ForEach(r => debug += "Record ID " + r.Id + " | " + r.Path + " | " + r.txt("test") + r.txt("ma") + "\n");

            MessageBox.Show(debug);
            ((Worksheet.modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).prepareData();
            ((Worksheet.modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).render();
        }
        public void AfterSave(object sender, EventArgs e)
        {
            //Display.hook("AfterSave");
        }
        public async void AfterLoad(object sender, EventArgs e)
        {
            // a little time to be sure file get loaded
            await Task.Delay(500);
            Display.setup(AppConst.templateFolder + "TienLuong");

            Display.hook("LoadData");
        }

        private void btn_BackDemo_Click(object sender, EventArgs e)
        {
            Backbone.Run("SheetDemo");
        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("SheetTienLuong", "TienLuong");
            }
            else
            {
                if (null == tienLuongP) tienLuongP = new TienLuongP(this);
                Publisher.register("SheetTienLuong", tienLuongP);
                if (null == vatLieuP) vatLieuP = new VatLieuP(this);
                Publisher.register("SheetVatLieu", vatLieuP);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Tiên lượng":
                    Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
                    break;
                case "Vật liệu":
                    Display.setup(sheet_VatLieu, AppConst.templateFolder + "GiaVatLieu");
                    break;
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
                        Display.WControl.Save(saveFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
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

        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_TienLuong.Load(openFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }
    }
}
