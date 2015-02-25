﻿namespace Cinteros.Xrm.FetchXmlBuilder.Forms
{
    partial class ResultGrid
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvGrid = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.panCancel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 430);
            this.panel2.TabIndex = 2;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.SystemColors.Control;
            this.panBottom.Controls.Add(this.label1);
            this.panBottom.Controls.Add(this.panCancel);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 430);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(731, 38);
            this.panBottom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-click a row to open the record";
            // 
            // panCancel
            // 
            this.panCancel.Controls.Add(this.btnCancel);
            this.panCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panCancel.Location = new System.Drawing.Point(640, 0);
            this.panCancel.Name = "panCancel";
            this.panCancel.Size = new System.Drawing.Size(91, 38);
            this.panCancel.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 430);
            this.panel1.TabIndex = 2;
            // 
            // lvGrid
            // 
            this.lvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGrid.FullRowSelect = true;
            this.lvGrid.GridLines = true;
            this.lvGrid.Location = new System.Drawing.Point(0, 0);
            this.lvGrid.Name = "lvGrid";
            this.lvGrid.Size = new System.Drawing.Size(731, 430);
            this.lvGrid.TabIndex = 2;
            this.lvGrid.UseCompatibleStateImageBehavior = false;
            this.lvGrid.View = System.Windows.Forms.View.Details;
            // 
            // ResultGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(731, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panBottom);
            this.Name = "ResultGrid";
            this.Text = "ResultGrid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultGrid_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.panCancel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvGrid;
    }
}