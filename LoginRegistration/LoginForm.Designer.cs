namespace LoginRegistration
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUp2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPassword2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSignUp2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 461);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "JAYTRON";
            // 
            // btnSignUp2
            // 
            this.btnSignUp2.ActiveBorderThickness = 1;
            this.btnSignUp2.ActiveCornerRadius = 30;
            this.btnSignUp2.ActiveFillColor = System.Drawing.Color.White;
            this.btnSignUp2.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignUp2.ActiveLineColor = System.Drawing.Color.White;
            this.btnSignUp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignUp2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp2.BackgroundImage")));
            this.btnSignUp2.ButtonText = "GET STARTED";
            this.btnSignUp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp2.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSignUp2.IdleBorderThickness = 1;
            this.btnSignUp2.IdleCornerRadius = 30;
            this.btnSignUp2.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSignUp2.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btnSignUp2.IdleLineColor = System.Drawing.Color.White;
            this.btnSignUp2.Location = new System.Drawing.Point(37, 230);
            this.btnSignUp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp2.Name = "btnSignUp2";
            this.btnSignUp2.Size = new System.Drawing.Size(139, 36);
            this.btnSignUp2.TabIndex = 6;
            this.btnSignUp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp2.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 30;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 30;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btnLogin.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Location = new System.Drawing.Point(276, 323);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(331, 41);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(611, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword2.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword2.HintText = "";
            this.txtPassword2.isPassword = true;
            this.txtPassword2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtPassword2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtPassword2.LineThickness = 3;
            this.txtPassword2.Location = new System.Drawing.Point(270, 211);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(342, 33);
            this.txtPassword2.TabIndex = 8;
            this.txtPassword2.Text = "Password";
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword2.OnValueChanged += new System.EventHandler(this.txtPassword2_OnValueChanged);
            this.txtPassword2.Enter += new System.EventHandler(this.txtPasswordEnter);
            this.txtPassword2.Leave += new System.EventHandler(this.txtPasswordLeave);
            // 
            // txtUsername2
            // 
            this.txtUsername2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername2.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername2.HintText = "";
            this.txtUsername2.isPassword = false;
            this.txtUsername2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtUsername2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtUsername2.LineThickness = 3;
            this.txtUsername2.Location = new System.Drawing.Point(270, 144);
            this.txtUsername2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(342, 33);
            this.txtUsername2.TabIndex = 7;
            this.txtUsername2.Text = "Username/ Email";
            this.txtUsername2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername2.OnValueChanged += new System.EventHandler(this.txtUsername2_OnValueChanged);
            this.txtUsername2.Enter += new System.EventHandler(this.txtUsernameEnter);
            this.txtUsername2.Leave += new System.EventHandler(this.txtUsernameLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(243, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(276, 275);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(302, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remember me";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtUsername2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignUp2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}