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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            panel1 = new Panel();
            chkbx_KichThuoc = new CheckBox();
            btn_LuuFile = new Button();
            btn_MoFile = new Button();
            btn_ThemCongViec = new Button();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            sheet_TienLuong = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            splitter1 = new Splitter();
            panel4 = new Panel();
            tabPage2 = new TabPage();
            gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chkbx_KichThuoc);
            panel1.Controls.Add(btn_LuuFile);
            panel1.Controls.Add(btn_MoFile);
            panel1.Controls.Add(btn_ThemCongViec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1628, 46);
            panel1.TabIndex = 0;
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
            btn_ThemCongViec.Location = new Point(1468, 9);
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
            panel2.Size = new Size(1628, 768);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1628, 768);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1620, 735);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tiên lượng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(sheet_TienLuong);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1614, 729);
            panel3.TabIndex = 4;
            // 
            // sheet_TienLuong
            // 
            sheet_TienLuong.AllowCellContextMenu = true;
            sheet_TienLuong.AllowExtendRowColumnCount = true;
            sheet_TienLuong.AllowFiltering = false;
            sheet_TienLuong.AllowFormulaRangeSelection = true;
            sheet_TienLuong.AllowTabItemContextMenu = true;
            sheet_TienLuong.AllowZooming = true;
            sheet_TienLuong.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            sheet_TienLuong.CopyPaste = spreadsheetCopyPaste1;
            sheet_TienLuong.DefaultColumnCount = 101;
            sheet_TienLuong.DefaultRowCount = 101;
            sheet_TienLuong.DisplayAlerts = true;
            sheet_TienLuong.Dock = DockStyle.Fill;
            sheet_TienLuong.FileName = "Book3";
            sheet_TienLuong.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            sheet_TienLuong.FormulaRangeSelectionController = formulaRangeSelectionController1;
            sheet_TienLuong.IsCustomTabItemContextMenuEnabled = false;
            sheet_TienLuong.Location = new Point(0, 0);
            sheet_TienLuong.Name = "sheet_TienLuong";
            sheet_TienLuong.SelectedTabIndex = 0;
            sheet_TienLuong.SelectedTabItem = null;
            sheet_TienLuong.ShowBusyIndicator = true;
            sheet_TienLuong.Size = new Size(1614, 549);
            sheet_TienLuong.TabIndex = 4;
            sheet_TienLuong.TabItemContextMenu = null;
            sheet_TienLuong.Text = "spreadsheet1";
            sheet_TienLuong.ThemeName = "Default";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 549);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1614, 4);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 553);
            panel4.Name = "panel4";
            panel4.Size = new Size(1614, 176);
            panel4.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gridControl1);
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1620, 735);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vật liệu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(3, 47);
            gridControl1.Name = "gridControl1";
            gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            gridControl1.Size = new Size(1614, 685);
            gridControl1.SmartSizeBox = false;
            gridControl1.TabIndex = 0;
            gridControl1.Text = "gridControl1";
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(255, 255, 255);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(210, 210, 210);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(114, 114, 114);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(94, 94, 94);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(150, 150, 150);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = Color.FromArgb(171, 171, 171);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = Color.FromArgb(255, 255, 255);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(210, 210, 210);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(171, 171, 171);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = Color.FromArgb(197, 197, 197);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(150, 150, 150);
            gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = Color.FromArgb(197, 197, 197);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(255, 255, 255);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(210, 210, 210);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(114, 114, 114);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(94, 94, 94);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(150, 150, 150);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = Color.FromArgb(171, 171, 171);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbColor = Color.FromArgb(255, 255, 255);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(210, 210, 210);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(225, 225, 225);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(171, 171, 171);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = Color.FromArgb(197, 197, 197);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(150, 150, 150);
            gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = Color.FromArgb(197, 197, 197);
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1614, 44);
            panel5.TabIndex = 1;
            // 
            // SheetSyncfusion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 814);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SheetSyncfusion";
            Text = "Sheet Demo Syncfusion";
            Title = "Sheet Demo Syncfusion";
            Load += SheetSyncfusion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel4;
        private TabPage tabPage2;
        private Panel panel3;
        private Splitter splitter1;
        private CheckBox chkbx_KichThuoc;
        private Button btn_LuuFile;
        private Button btn_MoFile;
        private Button btn_ThemCongViec;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Panel panel5;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet sheet_TienLuong;
    }
}