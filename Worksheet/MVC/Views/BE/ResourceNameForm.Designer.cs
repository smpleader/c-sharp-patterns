namespace Worksheet.MVC.Views.BE
{
    partial class ResourceNameForm
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
            txtName = new TextBox();
            label1 = new Label();
            btnOk = new Button();
            btnBack = new Button();
            filename = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 27);
            txtName.TabIndex = 0;
            txtName.KeyUp += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "File name";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(323, 90);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "Create";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 90);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = ">>";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // filename
            // 
            filename.AutoSize = true;
            filename.Location = new Point(100, 51);
            filename.Name = "filename";
            filename.Size = new Size(0, 20);
            filename.TabIndex = 4;
            // 
            // ResourceNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 131);
            ControlBox = false;
            Controls.Add(filename);
            Controls.Add(btnBack);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "ResourceNameForm";
            Text = "Resource Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtName;
        private Label label1;
        private Button btnOk;
        private Button btnBack;
        public Label filename;
    }
}