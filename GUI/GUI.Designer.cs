﻿using BUI;

namespace UI
{
    partial class GUI
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
            this.UHeader = new System.Windows.Forms.Panel();
            this.linhaHeader = new System.Windows.Forms.Panel();
            this.UStaus = new System.Windows.Forms.Panel();
            this.linhaStatus = new System.Windows.Forms.Panel();
            this.UMenu = new System.Windows.Forms.Panel();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.USection = new System.Windows.Forms.Panel();
            this.u_Header = new BUI.uHeader();
            this.uDocument = new BUI.uSection();
            this.UHeader.SuspendLayout();
            this.UStaus.SuspendLayout();
            this.UMenu.SuspendLayout();
            this.USection.SuspendLayout();
            this.SuspendLayout();
            // 
            // UHeader
            // 
            this.UHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UHeader.Controls.Add(this.u_Header);
            this.UHeader.Controls.Add(this.linhaHeader);
            this.UHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.UHeader.Location = new System.Drawing.Point(0, 0);
            this.UHeader.Name = "UHeader";
            this.UHeader.Size = new System.Drawing.Size(884, 64);
            this.UHeader.TabIndex = 0;
            // 
            // linhaHeader
            // 
            this.linhaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaHeader.Location = new System.Drawing.Point(0, 63);
            this.linhaHeader.Name = "linhaHeader";
            this.linhaHeader.Size = new System.Drawing.Size(884, 1);
            this.linhaHeader.TabIndex = 0;
            // 
            // UStaus
            // 
            this.UStaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UStaus.Controls.Add(this.linhaStatus);
            this.UStaus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UStaus.Location = new System.Drawing.Point(0, 509);
            this.UStaus.Name = "UStaus";
            this.UStaus.Size = new System.Drawing.Size(884, 32);
            this.UStaus.TabIndex = 2;
            // 
            // linhaStatus
            // 
            this.linhaStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.linhaStatus.Location = new System.Drawing.Point(0, 0);
            this.linhaStatus.Name = "linhaStatus";
            this.linhaStatus.Size = new System.Drawing.Size(884, 1);
            this.linhaStatus.TabIndex = 0;
            // 
            // UMenu
            // 
            this.UMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UMenu.Controls.Add(this.linhaMenu);
            this.UMenu.Controls.Add(this.btnMenu);
            this.UMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.UMenu.Location = new System.Drawing.Point(0, 64);
            this.UMenu.Name = "UMenu";
            this.UMenu.Size = new System.Drawing.Size(42, 445);
            this.UMenu.TabIndex = 3;
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.linhaMenu.Location = new System.Drawing.Point(41, 0);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(1, 445);
            this.linhaMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::UI.Properties.Resources.Row_256;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(9, 9);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 24);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // USection
            // 
            this.USection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.USection.Controls.Add(this.uDocument);
            this.USection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USection.Location = new System.Drawing.Point(42, 64);
            this.USection.Name = "USection";
            this.USection.Size = new System.Drawing.Size(842, 445);
            this.USection.TabIndex = 4;
            // 
            // u_Header
            // 
            this.u_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.u_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_Header.Location = new System.Drawing.Point(0, 0);
            this.u_Header.Name = "u_Header";
            this.u_Header.Size = new System.Drawing.Size(884, 63);
            this.u_Header.TabIndex = 1;
            // 
            // uDocument
            // 
            this.uDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uDocument.Location = new System.Drawing.Point(0, 0);
            this.uDocument.Name = "uDocument";
            this.uDocument.Size = new System.Drawing.Size(842, 445);
            this.uDocument.TabIndex = 0;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.USection);
            this.Controls.Add(this.UMenu);
            this.Controls.Add(this.UStaus);
            this.Controls.Add(this.UHeader);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.UHeader.ResumeLayout(false);
            this.UStaus.ResumeLayout(false);
            this.UMenu.ResumeLayout(false);
            this.USection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UHeader;
        private System.Windows.Forms.Panel linhaHeader;
        private System.Windows.Forms.Panel UStaus;
        private System.Windows.Forms.Panel linhaStatus;
        private System.Windows.Forms.Panel UMenu;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Panel USection;
        private uHeader u_Header;
        private System.Windows.Forms.Button btnMenu;
        private uSection uDocument;
    }
}