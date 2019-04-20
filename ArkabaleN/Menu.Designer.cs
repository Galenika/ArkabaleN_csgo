namespace ArkabaleN
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblNameProgramm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenuSlider = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAimbot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSkinchanger = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGlow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.pnlControl.Controls.Add(this.lblNameProgramm);
            this.pnlControl.Controls.Add(this.panel1);
            this.pnlControl.Controls.Add(this.btnMenuSlider);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(714, 61);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseMove);
            // 
            // lblNameProgramm
            // 
            this.lblNameProgramm.AutoSize = true;
            this.lblNameProgramm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblNameProgramm.ForeColor = System.Drawing.Color.White;
            this.lblNameProgramm.Location = new System.Drawing.Point(68, 15);
            this.lblNameProgramm.Name = "lblNameProgramm";
            this.lblNameProgramm.Size = new System.Drawing.Size(104, 28);
            this.lblNameProgramm.TabIndex = 4;
            this.lblNameProgramm.Text = "ArkabaleN";
            this.lblNameProgramm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNameProgramm_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(621, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 61);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(56, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(22, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 38);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 0;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMenuSlider
            // 
            this.btnMenuSlider.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSlider.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSlider.Image")));
            this.btnMenuSlider.ImageActive = null;
            this.btnMenuSlider.Location = new System.Drawing.Point(12, 8);
            this.btnMenuSlider.Name = "btnMenuSlider";
            this.btnMenuSlider.Size = new System.Drawing.Size(50, 50);
            this.btnMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuSlider.TabIndex = 2;
            this.btnMenuSlider.TabStop = false;
            this.btnMenuSlider.Zoom = 10;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnAimbot);
            this.pnlLeft.Controls.Add(this.btnSkinchanger);
            this.pnlLeft.Controls.Add(this.btnGlow);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 61);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(203, 323);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "     Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 75D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(2, 219);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(203, 48);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAimbot
            // 
            this.btnAimbot.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnAimbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnAimbot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAimbot.BorderRadius = 0;
            this.btnAimbot.ButtonText = "     Aimbot";
            this.btnAimbot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAimbot.DisabledColor = System.Drawing.Color.Gray;
            this.btnAimbot.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAimbot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAimbot.Iconimage")));
            this.btnAimbot.Iconimage_right = null;
            this.btnAimbot.Iconimage_right_Selected = null;
            this.btnAimbot.Iconimage_Selected = null;
            this.btnAimbot.IconMarginLeft = 0;
            this.btnAimbot.IconMarginRight = 0;
            this.btnAimbot.IconRightVisible = true;
            this.btnAimbot.IconRightZoom = 0D;
            this.btnAimbot.IconVisible = true;
            this.btnAimbot.IconZoom = 75D;
            this.btnAimbot.IsTab = false;
            this.btnAimbot.Location = new System.Drawing.Point(2, 165);
            this.btnAimbot.Name = "btnAimbot";
            this.btnAimbot.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnAimbot.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnAimbot.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnAimbot.selected = false;
            this.btnAimbot.Size = new System.Drawing.Size(203, 48);
            this.btnAimbot.TabIndex = 0;
            this.btnAimbot.Text = "     Aimbot";
            this.btnAimbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAimbot.Textcolor = System.Drawing.Color.White;
            this.btnAimbot.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSkinchanger
            // 
            this.btnSkinchanger.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnSkinchanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnSkinchanger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkinchanger.BorderRadius = 0;
            this.btnSkinchanger.ButtonText = "     SkinChanger";
            this.btnSkinchanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkinchanger.DisabledColor = System.Drawing.Color.Gray;
            this.btnSkinchanger.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSkinchanger.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSkinchanger.Iconimage")));
            this.btnSkinchanger.Iconimage_right = null;
            this.btnSkinchanger.Iconimage_right_Selected = null;
            this.btnSkinchanger.Iconimage_Selected = null;
            this.btnSkinchanger.IconMarginLeft = 0;
            this.btnSkinchanger.IconMarginRight = 0;
            this.btnSkinchanger.IconRightVisible = true;
            this.btnSkinchanger.IconRightZoom = 0D;
            this.btnSkinchanger.IconVisible = true;
            this.btnSkinchanger.IconZoom = 75D;
            this.btnSkinchanger.IsTab = false;
            this.btnSkinchanger.Location = new System.Drawing.Point(2, 111);
            this.btnSkinchanger.Name = "btnSkinchanger";
            this.btnSkinchanger.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnSkinchanger.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnSkinchanger.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSkinchanger.selected = false;
            this.btnSkinchanger.Size = new System.Drawing.Size(203, 48);
            this.btnSkinchanger.TabIndex = 0;
            this.btnSkinchanger.Text = "     SkinChanger";
            this.btnSkinchanger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkinchanger.Textcolor = System.Drawing.Color.White;
            this.btnSkinchanger.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGlow
            // 
            this.btnGlow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnGlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnGlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGlow.BorderRadius = 0;
            this.btnGlow.ButtonText = "     Visuals";
            this.btnGlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlow.DisabledColor = System.Drawing.Color.Gray;
            this.btnGlow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGlow.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGlow.Iconimage")));
            this.btnGlow.Iconimage_right = null;
            this.btnGlow.Iconimage_right_Selected = null;
            this.btnGlow.Iconimage_Selected = null;
            this.btnGlow.IconMarginLeft = 0;
            this.btnGlow.IconMarginRight = 0;
            this.btnGlow.IconRightVisible = true;
            this.btnGlow.IconRightZoom = 0D;
            this.btnGlow.IconVisible = true;
            this.btnGlow.IconZoom = 75D;
            this.btnGlow.IsTab = false;
            this.btnGlow.Location = new System.Drawing.Point(2, 57);
            this.btnGlow.Name = "btnGlow";
            this.btnGlow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnGlow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnGlow.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnGlow.selected = false;
            this.btnGlow.Size = new System.Drawing.Size(203, 48);
            this.btnGlow.TabIndex = 0;
            this.btnGlow.Text = "     Visuals";
            this.btnGlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlow.Textcolor = System.Drawing.Color.White;
            this.btnGlow.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.pnlBottom.Controls.Add(this.lblUpdate);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 384);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(714, 19);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdate.Location = new System.Drawing.Point(12, 3);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(74, 13);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "Last Update: ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(714, 403);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "ArkabaleN - Menu";
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlLeft;
        private Bunifu.Framework.UI.BunifuFlatButton btnGlow;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameProgramm;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnMenuSlider;
        private Bunifu.Framework.UI.BunifuFlatButton btnSkinchanger;
        private Bunifu.Framework.UI.BunifuFlatButton btnAimbot;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblUpdate;
    }
}

