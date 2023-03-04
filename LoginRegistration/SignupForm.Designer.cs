namespace LoginRegistration
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetStarted = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConfirmPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGetStarted);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(444, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 444);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Already have an account?";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.ActiveBorderThickness = 1;
            this.btnGetStarted.ActiveCornerRadius = 30;
            this.btnGetStarted.ActiveFillColor = System.Drawing.Color.White;
            this.btnGetStarted.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnGetStarted.ActiveLineColor = System.Drawing.Color.White;
            this.btnGetStarted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnGetStarted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetStarted.BackgroundImage")));
            this.btnGetStarted.ButtonText = "SIGN IN";
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGetStarted.IdleBorderThickness = 1;
            this.btnGetStarted.IdleCornerRadius = 30;
            this.btnGetStarted.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnGetStarted.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btnGetStarted.IdleLineColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(53, 249);
            this.btnGetStarted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(126, 33);
            this.btnGetStarted.TabIndex = 5;
            this.btnGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetStarted.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(195, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.ActiveBorderThickness = 1;
            this.btnSignUp.ActiveCornerRadius = 30;
            this.btnSignUp.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSignUp.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignUp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.IdleBorderThickness = 1;
            this.btnSignUp.IdleCornerRadius = 30;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignUp.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btnSignUp.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.Location = new System.Drawing.Point(66, 357);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(330, 39);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 30F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "JAYTRON";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(56, 183);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(351, 33);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Enter Username/ Email";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Enter += new System.EventHandler(this.txtUserEnter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(56, 239);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(351, 33);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFullName.HintText = "";
            this.txtFullName.isPassword = false;
            this.txtFullName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtFullName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFullName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtFullName.LineThickness = 3;
            this.txtFullName.Location = new System.Drawing.Point(56, 123);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(351, 33);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.Text = "Enter Full name";
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.OnValueChanged += new System.EventHandler(this.txtFirstName_OnValueChanged);
            this.txtFullName.Enter += new System.EventHandler(this.txtFullNameEnter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullNameLeave);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPass.HintText = "";
            this.txtConfirmPass.isPassword = true;
            this.txtConfirmPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtConfirmPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtConfirmPass.LineThickness = 3;
            this.txtConfirmPass.Location = new System.Drawing.Point(56, 294);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(351, 33);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.Text = "Password";
            this.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPass.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.txtConfirmPass.Enter += new System.EventHandler(this.txtConfirmEnter);
            this.txtConfirmPass.Leave += new System.EventHandler(this.txtConfirmLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGetStarted;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFullName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPass;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}