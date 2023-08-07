namespace Worksheet.MVC.Views.BE
{
    partial class Resource
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
            ws = new unvell.ReoGrid.ReoGridControl();
            btnDG = new Button();
            cbFile = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            btnBG = new Button();
            SuspendLayout();
            // 
            // ws
            // 
            ws.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ws.BackColor = Color.FromArgb(255, 255, 255);
            ws.ColumnHeaderContextMenuStrip = null;
            ws.LeadHeaderContextMenuStrip = null;
            ws.Location = new Point(12, 48);
            ws.Name = "ws";
            ws.RowHeaderContextMenuStrip = null;
            ws.Script = null;
            ws.SheetTabContextMenuStrip = null;
            ws.SheetTabNewButtonVisible = true;
            ws.SheetTabVisible = true;
            ws.SheetTabWidth = 500;
            ws.ShowScrollEndSpacing = true;
            ws.Size = new Size(1103, 498);
            ws.TabIndex = 0;
            ws.Text = "reoGridControl1";
            // 
            // btnDG
            // 
            btnDG.Location = new Point(12, 12);
            btnDG.Name = "btnDG";
            btnDG.Size = new Size(94, 29);
            btnDG.TabIndex = 1;
            btnDG.Text = "DG mới";
            btnDG.UseVisualStyleBackColor = true;
            btnDG.Click += btnDG_Click;
            // 
            // cbFile
            // 
            cbFile.FormattingEnabled = true;
            cbFile.Location = new Point(254, 13);
            cbFile.Name = "cbFile";
            cbFile.Size = new Size(307, 28);
            cbFile.TabIndex = 2;
            cbFile.SelectedIndexChanged += cbFile_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(567, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Location = new Point(1021, 13);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = ">>";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnBG
            // 
            btnBG.Location = new Point(112, 12);
            btnBG.Name = "btnBG";
            btnBG.Size = new Size(94, 29);
            btnBG.TabIndex = 5;
            btnBG.Text = "BG mới";
            btnBG.UseVisualStyleBackColor = true;
            btnBG.Click += btnBG_Click;
            // 
            // ResourceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 558);
            Controls.Add(btnBG);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(cbFile);
            Controls.Add(btnDG);
            Controls.Add(ws);
            Name = "ResourceForm";
            Text = "Form1";
            Title = "Form1";
            Load += ResourceForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public unvell.ReoGrid.ReoGridControl ws;
        private Button btnDG;
        private ComboBox cbFile;
        private Button btnSave;
        private Button btnBack;
        private Button btnBG;
    }
}