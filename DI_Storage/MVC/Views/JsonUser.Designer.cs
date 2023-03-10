namespace DI_Storage.MVC.Views
{
    partial class JsonUser
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
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 68);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(18, 12);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 1;
            button1.Text = "Back to Starter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(339, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 27);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(339, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(339, 167);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 27);
            txtUserName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 170);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "User name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(339, 223);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // JsonUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "JsonUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Title = "User";
            Load += JsonUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private Button btnSave;
    }
}