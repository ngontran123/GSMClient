namespace C3TekClient.C3Tek
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblVersion = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFalure = new System.Windows.Forms.Label();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.ckRemember = new DevExpress.XtraEditors.CheckEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barStaticItem1,
            this.lblVersion});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 260;
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barStaticItem1
            // 
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // lblVersion
            // 
            this.lblVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Id = 20;
            this.lblVersion.Name = "lblVersion";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblVersion);
            resources.ApplyResources(this.ribbonStatusBar1, "ribbonStatusBar1");
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.NullText = resources.GetString("txtPhone.Properties.NullText");
            this.txtPhone.Properties.NullValuePrompt = resources.GetString("txtPhone.Properties.NullValuePrompt");
            this.txtPhone.EditValueChanged += new System.EventHandler(this.txtPhone_EditValueChanged);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = resources.GetString("txtPassword.Properties.NullText");
            this.txtPassword.Properties.NullValuePrompt = resources.GetString("txtPassword.Properties.NullValuePrompt");
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtPassword_EditValueChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnLogin.Appearance.Font")));
            this.btnLogin.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::C3TekClient.Properties.Resources.user_shield_icon_24;
            this.label1.Name = "label1";
            // 
            // lblFalure
            // 
            resources.ApplyResources(this.lblFalure, "lblFalure");
            this.lblFalure.ForeColor = System.Drawing.Color.Red;
            this.lblFalure.Name = "lblFalure";
            // 
            // wait
            // 
            this.wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.wait.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.wait, "wait");
            this.wait.Name = "wait";
            this.wait.ShowCaption = false;
            this.wait.ShowDescription = false;
            // 
            // ckRemember
            // 
            resources.ApplyResources(this.ckRemember, "ckRemember");
            this.ckRemember.Name = "ckRemember";
            this.ckRemember.Properties.AllowFocused = false;
            this.ckRemember.Properties.Caption = resources.GetString("ckRemember.Properties.Caption");
            this.ckRemember.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.ckRemember.Properties.ValueGrayed = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::C3TekClient.Properties.Resources.logo_wobackground;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.ckRemember);
            this.panel1.Controls.Add(this.lblFalure);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.wait);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LoginUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginUI.IconOptions.Icon")));
            this.Name = "LoginUI";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StatusBar = this.ribbonStatusBar1;
            this.Load += new System.EventHandler(this.LoginUI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFalure;
        private DevExpress.XtraWaitForm.ProgressPanel wait;
        private DevExpress.XtraEditors.CheckEdit ckRemember;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

