namespace LoginRegistration
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.SidePanel.Controls.Add(this.LogoPic);
            this.SidePanel.Controls.Add(this.btnMenu);
            this.SidePanel.Controls.Add(this.lblLogo);
            this.SidePanel.Controls.Add(this.bunifuFlatButton5);
            this.SidePanel.Controls.Add(this.bunifuFlatButton6);
            this.SidePanel.Controls.Add(this.bunifuFlatButton3);
            this.SidePanel.Controls.Add(this.bunifuFlatButton4);
            this.SidePanel.Controls.Add(this.bunifuFlatButton2);
            this.SidePanel.Controls.Add(this.bunifuFlatButton1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SidePanel.Location = new System.Drawing.Point(0, 38);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(195, 547);
            this.SidePanel.TabIndex = 6;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(3, 13);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(30, 33);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            this.LogoPic.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(172, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 9;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.lblLogo.Location = new System.Drawing.Point(14, 13);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(136, 43);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "JAYTRON";
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Trash";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 35D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 40D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 370);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Text = "Trash";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Junk";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 35D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 40D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(3, 327);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton6.TabIndex = 5;
            this.bunifuFlatButton6.Text = "Junk";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Spam";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 35D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 284);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Spam";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Draft";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 35D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 40D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 241);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton4.TabIndex = 3;
            this.bunifuFlatButton4.Text = "Draft";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Sent";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 35D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 198);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(189, 43);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Sent";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Inbox";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 35D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 154);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Inbox";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(47)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1059, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(23)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.Controls.Add(this.bunifuImageButton1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1090, 38);
            this.TopPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "DashBoard";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(251, -74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 68);
            this.panel3.TabIndex = 8;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(195, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 547);
            this.panel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Label lblLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Panel panel1;
    }
}