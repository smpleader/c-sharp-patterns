namespace Worksheet.MVC.Views
{
    partial class SheetTinhCuocOto
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
            btn_SaveFile = new Button();
            btn_OpenFile = new Button();
            btn_Close = new Button();
            btn = new Button();
            label1 = new Label();
            cbb_CachTinh = new ComboBox();
            sheet_CuocOto = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_SaveFile);
            panel1.Controls.Add(btn_OpenFile);
            panel1.Controls.Add(btn_Close);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbb_CachTinh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1617, 47);
            panel1.TabIndex = 0;
            // 
            // btn_SaveFile
            // 
            btn_SaveFile.Location = new Point(618, 7);
            btn_SaveFile.Name = "btn_SaveFile";
            btn_SaveFile.Size = new Size(94, 29);
            btn_SaveFile.TabIndex = 5;
            btn_SaveFile.Text = "Lưu file";
            btn_SaveFile.UseVisualStyleBackColor = true;
            // 
            // btn_OpenFile
            // 
            btn_OpenFile.Location = new Point(492, 7);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(94, 29);
            btn_OpenFile.TabIndex = 4;
            btn_OpenFile.Text = "Mở file";
            btn_OpenFile.UseVisualStyleBackColor = true;
            btn_OpenFile.Click += btn_OpenFile_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(1500, 7);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Thoát";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn
            // 
            btn.Location = new Point(1400, 7);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 2;
            btn.Text = "Áp dụng";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Cách tính cước";
            // 
            // cbb_CachTinh
            // 
            cbb_CachTinh.FormattingEnabled = true;
            cbb_CachTinh.Location = new Point(124, 8);
            cbb_CachTinh.Name = "cbb_CachTinh";
            cbb_CachTinh.Size = new Size(346, 28);
            cbb_CachTinh.TabIndex = 0;
            cbb_CachTinh.SelectedIndexChanged += cbb_CachTinh_SelectedIndexChanged;
            // 
            // sheet_CuocOto
            // 
            sheet_CuocOto.AllowCellContextMenu = true;
            sheet_CuocOto.AllowExtendRowColumnCount = true;
            sheet_CuocOto.AllowFiltering = false;
            sheet_CuocOto.AllowFormulaRangeSelection = true;
            sheet_CuocOto.AllowTabItemContextMenu = true;
            sheet_CuocOto.AllowZooming = true;
            sheet_CuocOto.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            sheet_CuocOto.CopyPaste = spreadsheetCopyPaste1;
            sheet_CuocOto.DefaultColumnCount = 101;
            sheet_CuocOto.DefaultRowCount = 101;
            sheet_CuocOto.DisplayAlerts = true;
            sheet_CuocOto.Dock = DockStyle.Fill;
            sheet_CuocOto.FileName = "Book1";
            sheet_CuocOto.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            sheet_CuocOto.FormulaRangeSelectionController = formulaRangeSelectionController1;
            sheet_CuocOto.IsCustomTabItemContextMenuEnabled = false;
            sheet_CuocOto.Location = new Point(0, 47);
            sheet_CuocOto.Name = "sheet_CuocOto";
            sheet_CuocOto.SelectedTabIndex = 0;
            sheet_CuocOto.SelectedTabItem = null;
            sheet_CuocOto.ShowBusyIndicator = true;
            sheet_CuocOto.Size = new Size(1617, 711);
            sheet_CuocOto.TabIndex = 1;
            sheet_CuocOto.TabItemContextMenu = null;
            sheet_CuocOto.Text = "spreadsheet1";
            sheet_CuocOto.ThemeName = "Default";
            // 
            // SheetTinhCuocOto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 758);
            Controls.Add(sheet_CuocOto);
            Controls.Add(panel1);
            Name = "SheetTinhCuocOto";
            Text = "Cước ô tô";
            Title = "Cước ô tô";
            Load += CuocOto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Button btn;
        private Label label1;
        private ComboBox cbb_CachTinh;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet sheet_CuocOto;
        private Button btn_SaveFile;
        private Button btn_OpenFile;
    }
}