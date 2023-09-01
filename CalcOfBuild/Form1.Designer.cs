
using CalcOfBuild.CustomControls;

namespace CalcOfBuild
{
    partial class CoB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoB));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.skirtingBoard = new System.Windows.Forms.Button();
            this.Paint = new System.Windows.Forms.Button();
            this.Wallpaper = new System.Windows.Forms.Button();
            this.Plits = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.SoftLabel = new System.Windows.Forms.Label();
            this.panelTitel = new System.Windows.Forms.Panel();
            this.btnToHomePanel = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.OpenPanelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitel.SuspendLayout();
            this.OpenPanelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Settings);
            this.panelMenu.Controls.Add(this.skirtingBoard);
            this.panelMenu.Controls.Add(this.Paint);
            this.panelMenu.Controls.Add(this.Wallpaper);
            this.panelMenu.Controls.Add(this.Plits);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(157, 506);
            this.panelMenu.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 296);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(157, 59);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Настройки";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // skirtingBoard
            // 
            this.skirtingBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skirtingBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.skirtingBoard.FlatAppearance.BorderSize = 0;
            this.skirtingBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skirtingBoard.ForeColor = System.Drawing.Color.Gainsboro;
            this.skirtingBoard.Image = ((System.Drawing.Image)(resources.GetObject("skirtingBoard.Image")));
            this.skirtingBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skirtingBoard.Location = new System.Drawing.Point(0, 237);
            this.skirtingBoard.Name = "skirtingBoard";
            this.skirtingBoard.Size = new System.Drawing.Size(157, 59);
            this.skirtingBoard.TabIndex = 4;
            this.skirtingBoard.Text = "Плинтус";
            this.skirtingBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skirtingBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skirtingBoard.UseVisualStyleBackColor = true;
            this.skirtingBoard.Click += new System.EventHandler(this.skirtingBoard_Click);
            // 
            // Paint
            // 
            this.Paint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paint.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paint.FlatAppearance.BorderSize = 0;
            this.Paint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paint.ForeColor = System.Drawing.Color.Gainsboro;
            this.Paint.Image = ((System.Drawing.Image)(resources.GetObject("Paint.Image")));
            this.Paint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paint.Location = new System.Drawing.Point(0, 178);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(157, 59);
            this.Paint.TabIndex = 3;
            this.Paint.Text = "Краска";
            this.Paint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // Wallpaper
            // 
            this.Wallpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wallpaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Wallpaper.FlatAppearance.BorderSize = 0;
            this.Wallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wallpaper.ForeColor = System.Drawing.Color.Gainsboro;
            this.Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("Wallpaper.Image")));
            this.Wallpaper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wallpaper.Location = new System.Drawing.Point(0, 119);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(157, 59);
            this.Wallpaper.TabIndex = 2;
            this.Wallpaper.Text = "Обои";
            this.Wallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wallpaper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wallpaper.UseVisualStyleBackColor = true;
            this.Wallpaper.Click += new System.EventHandler(this.Wallpaper_Click);
            // 
            // Plits
            // 
            this.Plits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plits.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plits.FlatAppearance.BorderSize = 0;
            this.Plits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plits.ForeColor = System.Drawing.Color.Gainsboro;
            this.Plits.Image = ((System.Drawing.Image)(resources.GetObject("Plits.Image")));
            this.Plits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plits.Location = new System.Drawing.Point(0, 60);
            this.Plits.Name = "Plits";
            this.Plits.Size = new System.Drawing.Size(157, 59);
            this.Plits.TabIndex = 1;
            this.Plits.Text = "Плитка";
            this.Plits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Plits.UseVisualStyleBackColor = true;
            this.Plits.Click += new System.EventHandler(this.Plits_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.SoftLabel);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(157, 60);
            this.panelLogo.TabIndex = 1;
            // 
            // SoftLabel
            // 
            this.SoftLabel.AutoSize = true;
            this.SoftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoftLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SoftLabel.Location = new System.Drawing.Point(22, 20);
            this.SoftLabel.Name = "SoftLabel";
            this.SoftLabel.Size = new System.Drawing.Size(108, 21);
            this.SoftLabel.TabIndex = 2;
            this.SoftLabel.Text = "Calc Of Build";
            // 
            // panelTitel
            // 
            this.panelTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitel.Controls.Add(this.btnToHomePanel);
            this.panelTitel.Controls.Add(this.HomeTitle);
            this.panelTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitel.Location = new System.Drawing.Point(157, 0);
            this.panelTitel.Name = "panelTitel";
            this.panelTitel.Size = new System.Drawing.Size(692, 60);
            this.panelTitel.TabIndex = 1;
            // 
            // btnToHomePanel
            // 
            this.btnToHomePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToHomePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToHomePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnToHomePanel.Image = global::CalcOfBuild.Properties.Resources.BackHomeBtn;
            this.btnToHomePanel.Location = new System.Drawing.Point(0, 0);
            this.btnToHomePanel.Name = "btnToHomePanel";
            this.btnToHomePanel.Size = new System.Drawing.Size(75, 60);
            this.btnToHomePanel.TabIndex = 0;
            this.btnToHomePanel.UseVisualStyleBackColor = true;
            this.btnToHomePanel.Click += new System.EventHandler(this.btnToHonePanel_Click);
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeTitle.Location = new System.Drawing.Point(81, 20);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(172, 21);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "Домашняя страница";
            // 
            // OpenPanelForms
            // 
            this.OpenPanelForms.Controls.Add(this.pictureBox1);
            this.OpenPanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenPanelForms.Location = new System.Drawing.Point(157, 60);
            this.OpenPanelForms.Name = "OpenPanelForms";
            this.OpenPanelForms.Size = new System.Drawing.Size(692, 446);
            this.OpenPanelForms.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcOfBuild.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(185, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(849, 506);
            this.Controls.Add(this.OpenPanelForms);
            this.Controls.Add(this.panelTitel);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(865, 545);
            this.MinimumSize = new System.Drawing.Size(865, 545);
            this.Name = "CoB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoB";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitel.ResumeLayout(false);
            this.panelTitel.PerformLayout();
            this.OpenPanelForms.ResumeLayout(false);
            this.OpenPanelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button skirtingBoard;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Button Wallpaper;
        private System.Windows.Forms.Button Plits;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitel;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Label SoftLabel;
        private CustomControls.ToggleButton toggleButton1;
        private System.Windows.Forms.Panel OpenPanelForms;
        private System.Windows.Forms.Button btnToHomePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


