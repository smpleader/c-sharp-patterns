﻿namespace Worksheet.MVC.Views
{
    partial class Starter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(117, 89);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 0;
            button1.Text = "Test Json";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 142);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 1;
            button2.Text = "Test SQLite";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(117, 194);
            button4.Name = "button4";
            button4.Size = new Size(211, 29);
            button4.TabIndex = 3;
            button4.Text = "Test Worksheet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Starter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Starter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Title = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
    }
}