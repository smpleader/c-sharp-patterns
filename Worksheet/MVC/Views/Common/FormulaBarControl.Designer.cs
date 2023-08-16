﻿/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * https://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGridEditor is released under MIT license.
 *
 * Copyright (c) 2012-2021 Jing Lu <jingwood at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

namespace EtaDt.MVCP.Views.Common
{
	partial class FormulaBarControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressField = new EtaDt.MVCP.Views.Common.AddressFieldControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitterDown = new System.Windows.Forms.Splitter();
            this.splitterUp = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.Control;
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 2);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(335, 294);
            this.leftPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.addressField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel1.Size = new System.Drawing.Size(335, 35);
            this.panel1.TabIndex = 5;
            // 
            // addressField
            // 
            this.addressField.BackColor = System.Drawing.SystemColors.Window;
            this.addressField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressField.GridControl = null;
            this.addressField.Location = new System.Drawing.Point(0, 0);
            this.addressField.Name = "addressField";
            this.addressField.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.addressField.Size = new System.Drawing.Size(180, 21);
            this.addressField.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 35);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            //this.pictureBox1.Image = global::EtaDt.Properties.Resources.FunctionHS;
            this.pictureBox1.Location = new System.Drawing.Point(295, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitterDown
            // 
            this.splitterDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterDown.Location = new System.Drawing.Point(0, 296);
            this.splitterDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterDown.Name = "splitterDown";
            this.splitterDown.Size = new System.Drawing.Size(1041, 7);
            this.splitterDown.TabIndex = 9;
            this.splitterDown.TabStop = false;
            // 
            // splitterUp
            // 
            this.splitterUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterUp.Location = new System.Drawing.Point(0, 0);
            this.splitterUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterUp.Name = "splitterUp";
            this.splitterUp.Size = new System.Drawing.Size(1041, 2);
            this.splitterUp.TabIndex = 10;
            this.splitterUp.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFormula);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(335, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4, 2, 1, 2);
            this.panel3.Size = new System.Drawing.Size(706, 294);
            this.panel3.TabIndex = 11;
            // 
            // txtFormula
            // 
            this.txtFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFormula.Location = new System.Drawing.Point(4, 2);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(701, 290);
            this.txtFormula.TabIndex = 9;
            // 
            // FormulaBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.splitterDown);
            this.Controls.Add(this.splitterUp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormulaBarControl";
            this.Size = new System.Drawing.Size(1041, 303);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);


        }
       

		#endregion

		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private AddressFieldControl addressField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitterDown;
		private System.Windows.Forms.Splitter splitterUp;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtFormula;
        //private AddressFieldControl addressFieldControl1;
    }
}
