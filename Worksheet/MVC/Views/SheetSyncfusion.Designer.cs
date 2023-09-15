namespace Worksheet.MVC.Views
{
    partial class SheetSyncfusion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste2 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController2 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            panel1 = new Panel();
            pnl_VatLieu = new Panel();
            btn_SaveWS = new Button();
            btn_TinhCuocOto = new Button();
            bbtn_ThemVatLieu = new Button();
            rdbtn_PPT_NhanHeSoCongCuocVC = new RadioButton();
            rdbtn_PPT_NhanHeSo = new RadioButton();
            rdbtn_PPT_CongCuocVC = new RadioButton();
            rdbtn_PPT_NhapTay = new RadioButton();
            label1 = new Label();
            chkbx_KichThuoc = new CheckBox();
            btn_LuuFile = new Button();
            btn_MoFile = new Button();
            btn_ThemCongViec = new Button();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pnl_body = new Panel();
            splitter1 = new Splitter();
            panel4 = new Panel();
            sheet_working = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            panel1.SuspendLayout();
            pnl_VatLieu.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnl_body.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnl_VatLieu);
            panel1.Controls.Add(chkbx_KichThuoc);
            panel1.Controls.Add(btn_LuuFile);
            panel1.Controls.Add(btn_MoFile);
            panel1.Controls.Add(btn_ThemCongViec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1683, 46);
            panel1.TabIndex = 0;
            // 
            // pnl_VatLieu
            // 
            pnl_VatLieu.Controls.Add(btn_SaveWS);
            pnl_VatLieu.Controls.Add(btn_TinhCuocOto);
            pnl_VatLieu.Controls.Add(bbtn_ThemVatLieu);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhanHeSoCongCuocVC);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhanHeSo);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_CongCuocVC);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhapTay);
            pnl_VatLieu.Controls.Add(label1);
            pnl_VatLieu.Dock = DockStyle.Top;
            pnl_VatLieu.Location = new Point(0, 0);
            pnl_VatLieu.Name = "pnl_VatLieu";
            pnl_VatLieu.Size = new Size(1683, 46);
            pnl_VatLieu.TabIndex = 10;
            pnl_VatLieu.Visible = false;
            // 
            // btn_SaveWS
            // 
            btn_SaveWS.Location = new Point(835, 7);
            btn_SaveWS.Name = "btn_SaveWS";
            btn_SaveWS.Size = new Size(158, 29);
            btn_SaveWS.TabIndex = 13;
            btn_SaveWS.Text = "Save workingsheet";
            btn_SaveWS.UseVisualStyleBackColor = true;
            btn_SaveWS.Click += btn_SaveWS_Click;
            // 
            // btn_TinhCuocOto
            // 
            btn_TinhCuocOto.Location = new Point(714, 7);
            btn_TinhCuocOto.Name = "btn_TinhCuocOto";
            btn_TinhCuocOto.Size = new Size(94, 29);
            btn_TinhCuocOto.TabIndex = 12;
            btn_TinhCuocOto.Text = "Tính cước ô tô";
            btn_TinhCuocOto.UseVisualStyleBackColor = true;
            btn_TinhCuocOto.Visible = false;
            btn_TinhCuocOto.Click += btn_TinhCuocOto_Click;
            // 
            // bbtn_ThemVatLieu
            // 
            bbtn_ThemVatLieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bbtn_ThemVatLieu.Location = new Point(1559, 9);
            bbtn_ThemVatLieu.Name = "bbtn_ThemVatLieu";
            bbtn_ThemVatLieu.Size = new Size(112, 29);
            bbtn_ThemVatLieu.TabIndex = 11;
            bbtn_ThemVatLieu.Text = "Thêm vật liệu";
            bbtn_ThemVatLieu.UseVisualStyleBackColor = true;
            bbtn_ThemVatLieu.Click += bbtn_ThemVatLieu_Click;
            // 
            // rdbtn_PPT_NhanHeSoCongCuocVC
            // 
            rdbtn_PPT_NhanHeSoCongCuocVC.AutoSize = true;
            rdbtn_PPT_NhanHeSoCongCuocVC.Location = new Point(496, 9);
            rdbtn_PPT_NhanHeSoCongCuocVC.Name = "rdbtn_PPT_NhanHeSoCongCuocVC";
            rdbtn_PPT_NhanHeSoCongCuocVC.Size = new Size(178, 24);
            rdbtn_PPT_NhanHeSoCongCuocVC.TabIndex = 9;
            rdbtn_PPT_NhanHeSoCongCuocVC.Text = "Nhân hệ số + Cước VC";
            rdbtn_PPT_NhanHeSoCongCuocVC.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhanHeSoCongCuocVC.CheckedChanged += rdbtn_PPT_NhanHeSoCongCuocVC_CheckedChanged;
            // 
            // rdbtn_PPT_NhanHeSo
            // 
            rdbtn_PPT_NhanHeSo.AutoSize = true;
            rdbtn_PPT_NhanHeSo.Location = new Point(376, 10);
            rdbtn_PPT_NhanHeSo.Name = "rdbtn_PPT_NhanHeSo";
            rdbtn_PPT_NhanHeSo.Size = new Size(104, 24);
            rdbtn_PPT_NhanHeSo.TabIndex = 8;
            rdbtn_PPT_NhanHeSo.Text = "Nhân hệ số";
            rdbtn_PPT_NhanHeSo.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhanHeSo.CheckedChanged += rdbtn_PPT_NhanHeSo_CheckedChanged;
            // 
            // rdbtn_PPT_CongCuocVC
            // 
            rdbtn_PPT_CongCuocVC.AutoSize = true;
            rdbtn_PPT_CongCuocVC.Location = new Point(247, 10);
            rdbtn_PPT_CongCuocVC.Name = "rdbtn_PPT_CongCuocVC";
            rdbtn_PPT_CongCuocVC.Size = new Size(123, 24);
            rdbtn_PPT_CongCuocVC.TabIndex = 7;
            rdbtn_PPT_CongCuocVC.Text = "Cộng cước VC";
            rdbtn_PPT_CongCuocVC.UseVisualStyleBackColor = true;
            rdbtn_PPT_CongCuocVC.CheckedChanged += rdbtn_PPT_CongCuocVC_CheckedChanged;
            // 
            // rdbtn_PPT_NhapTay
            // 
            rdbtn_PPT_NhapTay.AutoSize = true;
            rdbtn_PPT_NhapTay.Location = new Point(151, 9);
            rdbtn_PPT_NhapTay.Name = "rdbtn_PPT_NhapTay";
            rdbtn_PPT_NhapTay.Size = new Size(90, 24);
            rdbtn_PPT_NhapTay.TabIndex = 6;
            rdbtn_PPT_NhapTay.Text = "Nhập tay";
            rdbtn_PPT_NhapTay.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhapTay.CheckedChanged += rdbtn_PPT_NhapTay_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Phương pháp tính";
            // 
            // chkbx_KichThuoc
            // 
            chkbx_KichThuoc.AutoSize = true;
            chkbx_KichThuoc.Location = new Point(227, 12);
            chkbx_KichThuoc.Name = "chkbx_KichThuoc";
            chkbx_KichThuoc.Size = new Size(101, 24);
            chkbx_KichThuoc.TabIndex = 9;
            chkbx_KichThuoc.Text = "Kích thước";
            chkbx_KichThuoc.UseVisualStyleBackColor = true;
            chkbx_KichThuoc.CheckedChanged += chkbx_KichThuoc_CheckedChanged;
            // 
            // btn_LuuFile
            // 
            btn_LuuFile.Location = new Point(109, 9);
            btn_LuuFile.Name = "btn_LuuFile";
            btn_LuuFile.Size = new Size(94, 29);
            btn_LuuFile.TabIndex = 8;
            btn_LuuFile.Text = "Lưu file";
            btn_LuuFile.UseVisualStyleBackColor = true;
            btn_LuuFile.Click += btn_LuuFile_Click;
            // 
            // btn_MoFile
            // 
            btn_MoFile.Location = new Point(9, 9);
            btn_MoFile.Name = "btn_MoFile";
            btn_MoFile.Size = new Size(94, 29);
            btn_MoFile.TabIndex = 7;
            btn_MoFile.Text = "Mở file";
            btn_MoFile.UseVisualStyleBackColor = true;
            btn_MoFile.Click += btn_MoFile_Click;
            // 
            // btn_ThemCongViec
            // 
            btn_ThemCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ThemCongViec.Location = new Point(1523, 9);
            btn_ThemCongViec.Name = "btn_ThemCongViec";
            btn_ThemCongViec.Size = new Size(148, 29);
            btn_ThemCongViec.TabIndex = 5;
            btn_ThemCongViec.Text = "Thêm công việc";
            btn_ThemCongViec.UseVisualStyleBackColor = true;
            btn_ThemCongViec.Click += btn_ThemCongViec_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(1683, 730);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1683, 730);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnl_body);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1675, 697);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tiên lượng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_body
            // 
            pnl_body.Controls.Add(splitter1);
            pnl_body.Controls.Add(panel4);
            pnl_body.Dock = DockStyle.Fill;
            pnl_body.Location = new Point(3, 3);
            pnl_body.Name = "pnl_body";
            pnl_body.Size = new Size(1669, 691);
            pnl_body.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 348);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1669, 4);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(sheet_working);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 352);
            panel4.Name = "panel4";
            panel4.Size = new Size(1669, 339);
            panel4.TabIndex = 2;
            // 
            // sheet_working
            // 
            sheet_working.AllowCellContextMenu = true;
            sheet_working.AllowExtendRowColumnCount = true;
            sheet_working.AllowFiltering = false;
            sheet_working.AllowFormulaRangeSelection = true;
            sheet_working.AllowTabItemContextMenu = true;
            sheet_working.AllowZooming = true;
            sheet_working.BaseThemeName = "";
            spreadsheetCopyPaste2.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste2.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            sheet_working.CopyPaste = spreadsheetCopyPaste2;
            sheet_working.DefaultColumnCount = 101;
            sheet_working.DefaultRowCount = 101;
            sheet_working.DisplayAlerts = true;
            sheet_working.Dock = DockStyle.Fill;
            sheet_working.FileName = "Book2";
            sheet_working.FormulaBarVisibility = true;
            formulaRangeSelectionController2.AllowMouseSelection = true;
            formulaRangeSelectionController2.AllowSelectionOnEditing = true;
            sheet_working.FormulaRangeSelectionController = formulaRangeSelectionController2;
            sheet_working.IsCustomTabItemContextMenuEnabled = false;
            sheet_working.Location = new Point(0, 0);
            sheet_working.Name = "sheet_working";
            sheet_working.SelectedTabIndex = 0;
            sheet_working.SelectedTabItem = null;
            sheet_working.ShowBusyIndicator = true;
            sheet_working.Size = new Size(1669, 339);
            sheet_working.TabIndex = 0;
            sheet_working.TabItemContextMenu = null;
            sheet_working.Text = "spreadsheet1";
            sheet_working.ThemeName = "Default";
            // 
            // SheetSyncfusion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 776);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SheetSyncfusion";
            Text = "Sheet Demo Syncfusion";
            Title = "Sheet Demo Syncfusion";
            WindowState = FormWindowState.Maximized;
            Load += SheetSyncfusion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_VatLieu.ResumeLayout(false);
            pnl_VatLieu.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnl_body.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel4;
        private Panel pnl_body;
        private Splitter splitter1;
        private CheckBox chkbx_KichThuoc;
        private Button btn_LuuFile;
        private Button btn_MoFile;
        private Button btn_ThemCongViec;
        private Panel pnl_VatLieu;
        private RadioButton rdbtn_PPT_NhanHeSoCongCuocVC;
        private RadioButton rdbtn_PPT_NhanHeSo;
        private RadioButton rdbtn_PPT_CongCuocVC;
        private RadioButton rdbtn_PPT_NhapTay;
        private Label label1;
        private Button bbtn_ThemVatLieu;
        private Button btn_TinhCuocOto;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet sheet_working;
        private Button btn_SaveWS;
    }
}