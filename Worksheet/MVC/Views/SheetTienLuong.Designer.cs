namespace Worksheet.MVC.Views
{
    partial class SheetTienLuong
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
            panel1 = new Panel();
            btn_ThemCongViec = new Button();
            sheet_TienLuong = new unvell.ReoGrid.ReoGridControl();
            btn_BackDemo = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_BackDemo);
            panel1.Controls.Add(btn_ThemCongViec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1283, 62);
            panel1.TabIndex = 0;
            // 
            // btn_ThemCongViec
            // 
            btn_ThemCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ThemCongViec.Location = new Point(1123, 12);
            btn_ThemCongViec.Name = "btn_ThemCongViec";
            btn_ThemCongViec.Size = new Size(148, 29);
            btn_ThemCongViec.TabIndex = 0;
            btn_ThemCongViec.Text = "Thêm công việc";
            btn_ThemCongViec.UseVisualStyleBackColor = true;
            btn_ThemCongViec.Click += btn_ThemCongViec_Click;
            // 
            // sheet_TienLuong
            // 
            sheet_TienLuong.BackColor = Color.FromArgb(255, 255, 255);
            sheet_TienLuong.ColumnHeaderContextMenuStrip = null;
            sheet_TienLuong.Dock = DockStyle.Fill;
            sheet_TienLuong.LeadHeaderContextMenuStrip = null;
            sheet_TienLuong.Location = new Point(0, 62);
            sheet_TienLuong.Name = "sheet_TienLuong";
            sheet_TienLuong.RowHeaderContextMenuStrip = null;
            sheet_TienLuong.Script = null;
            sheet_TienLuong.SheetTabContextMenuStrip = null;
            sheet_TienLuong.SheetTabNewButtonVisible = true;
            sheet_TienLuong.SheetTabVisible = true;
            sheet_TienLuong.SheetTabWidth = 60;
            sheet_TienLuong.ShowScrollEndSpacing = true;
            sheet_TienLuong.Size = new Size(1283, 487);
            sheet_TienLuong.TabIndex = 1;
            sheet_TienLuong.Text = "reoGridControl1";
            // 
            // btn_BackDemo
            // 
            btn_BackDemo.Location = new Point(12, 12);
            btn_BackDemo.Name = "btn_BackDemo";
            btn_BackDemo.Size = new Size(94, 29);
            btn_BackDemo.TabIndex = 1;
            btn_BackDemo.Text = "<<";
            btn_BackDemo.UseVisualStyleBackColor = true;
            btn_BackDemo.Click += btn_BackDemo_Click;
            // 
            // SheetTienLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 549);
            Controls.Add(sheet_TienLuong);
            Controls.Add(panel1);
            Name = "SheetTienLuong";
            Text = "Demo sheet Tiên lượng";
            Title = "Demo sheet Tiên lượng";
            Load += SheetTienLuong_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public unvell.ReoGrid.ReoGridControl sheet_TienLuong;
        private Button btn_ThemCongViec;
        private Button btn_BackDemo;
    }
}