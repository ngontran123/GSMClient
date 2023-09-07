
namespace C3TekClient
{
    partial class ListImeiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListImeiForm));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.imeiList = new System.Windows.Forms.RichTextBox();
            this.btnSaveImei = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Danh sách Imei:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.Location = new System.Drawing.Point(12, 105);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(439, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Chú ý:Lưu mỗi dòng là một imei khác nhau ";
            // 
            // imeiList
            // 
            this.imeiList.Location = new System.Drawing.Point(12, 161);
            this.imeiList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeiList.Name = "imeiList";
            this.imeiList.Size = new System.Drawing.Size(464, 380);
            this.imeiList.TabIndex = 11;
            this.imeiList.Text = "";
            // 
            // btnSaveImei
            // 
            this.btnSaveImei.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveImei.ImageOptions.Image")));
            this.btnSaveImei.Location = new System.Drawing.Point(12, 579);
            this.btnSaveImei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveImei.Name = "btnSaveImei";
            this.btnSaveImei.Size = new System.Drawing.Size(118, 38);
            this.btnSaveImei.TabIndex = 12;
            this.btnSaveImei.Text = "Lưu danh sách";
            this.btnSaveImei.Click += new System.EventHandler(this.btnSaveImei_Click);
            // 
            // ListImeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 672);
            this.Controls.Add(this.btnSaveImei);
            this.Controls.Add(this.imeiList);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Name = "ListImeiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListImeiForm";
            this.Load += new System.EventHandler(this.ListImeiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox imeiList;
        private DevExpress.XtraEditors.SimpleButton btnSaveImei;
    }
}