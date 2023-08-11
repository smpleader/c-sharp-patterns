namespace Worksheet.MVC.Views.BE
{
    partial class ResourceForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // ws
            // 
            ws.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ws.BackColor = Color.FromArgb(255, 255, 255);
            ws.ColumnHeaderContextMenuStrip = null;
            ws.LeadHeaderContextMenuStrip = null;
            ws.Location = new Point(12, 46);
            ws.Name = "ws";
            ws.RowHeaderContextMenuStrip = null;
            ws.Script = null;
            ws.SheetTabContextMenuStrip = null;
            ws.SheetTabNewButtonVisible = true;
            ws.SheetTabVisible = true;
            ws.SheetTabWidth = 60;
            ws.ShowScrollEndSpacing = true;
            ws.Size = new Size(358, 295);
            ws.TabIndex = 0;
            ws.Text = "ws";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ResourceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(label1);
            Controls.Add(ws);
            MaximumSize = new Size(400, 1000);
            MinimumSize = new Size(400, 400);
            Name = "ResourceForm";
            Text = "Resource Form";
            Title = "Resource Form";
            Load += ResourceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public unvell.ReoGrid.ReoGridControl ws;
        private Label label1;
    }
}