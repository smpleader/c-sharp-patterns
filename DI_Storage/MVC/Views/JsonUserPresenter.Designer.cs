namespace DI_Storage.MVC.Views
{
    partial class JsonUserPresenter
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 21);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 0;
            button1.Text = "Back Starter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 98);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(358, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 27);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(358, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 27);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 146);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(358, 202);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(292, 27);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 205);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "User name";
            // 
            // button2
            // 
            button2.Location = new Point(363, 282);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // JsonUserPresenter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "JsonUserPresenter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JsonUserPresenter";
            Title = "JsonUserPresenter";
            Load += JsonUserPresenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Button button2;

        // public properties
        public ComboBox comboBox1;
    }
}