﻿namespace UserInterface
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDormitory = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.lbMaPB = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panelSidebar.Controls.Add(this.btnDormitory);
            this.panelSidebar.Controls.Add(this.btnLuong);
            this.panelSidebar.Controls.Add(this.btnChamCong);
            this.panelSidebar.Controls.Add(this.lbMaPB);
            this.panelSidebar.Controls.Add(this.panelSide);
            this.panelSidebar.Controls.Add(this.btnNhanVien);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(251, 700);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDormitory
            // 
            this.btnDormitory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnDormitory.FlatAppearance.BorderSize = 0;
            this.btnDormitory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormitory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDormitory.ForeColor = System.Drawing.Color.White;
            this.btnDormitory.Image = global::UserInterface.Properties.Resources.Dormitory;
            this.btnDormitory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDormitory.Location = new System.Drawing.Point(24, 423);
            this.btnDormitory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDormitory.Name = "btnDormitory";
            this.btnDormitory.Size = new System.Drawing.Size(224, 66);
            this.btnDormitory.TabIndex = 10;
            this.btnDormitory.Text = " Ký Túc Xá";
            this.btnDormitory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDormitory.UseVisualStyleBackColor = false;
            this.btnDormitory.Click += new System.EventHandler(this.btnDormitory_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Image = global::UserInterface.Properties.Resources.salary;
            this.btnLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.Location = new System.Drawing.Point(24, 325);
            this.btnLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(224, 66);
            this.btnLuong.TabIndex = 8;
            this.btnLuong.Text = " Lương";
            this.btnLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = global::UserInterface.Properties.Resources.Chamcong;
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(24, 227);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(224, 66);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.Text = " Chấm Công";
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // lbMaPB
            // 
            this.lbMaPB.AutoSize = true;
            this.lbMaPB.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPB.ForeColor = System.Drawing.Color.White;
            this.lbMaPB.Location = new System.Drawing.Point(73, 39);
            this.lbMaPB.Name = "lbMaPB";
            this.lbMaPB.Size = new System.Drawing.Size(105, 34);
            this.lbMaPB.TabIndex = 4;
            this.lbMaPB.Text = "Admin";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(5, 129);
            this.panelSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(15, 66);
            this.panelSide.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::UserInterface.Properties.Resources.employee;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(24, 129);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(224, 66);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "  Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 39);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1100, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelChinh
            // 
            this.panelChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.panelChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChinh.Location = new System.Drawing.Point(251, 39);
            this.panelChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1136, 661);
            this.panelChinh.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 700);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label lbMaPB;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnDormitory;
    }
}