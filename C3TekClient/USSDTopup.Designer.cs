
namespace C3TekClient
{
    partial class USSDTopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USSDTopup));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrepareData = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCommandUSSD = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pbSendProcess = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblNumberCOM = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewGSM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AppPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USSDResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommandUSSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGSM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1319, 182);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnPrepareData);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtCommandUSSD);
            this.groupControl2.Location = new System.Drawing.Point(309, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1008, 177);
            this.groupControl2.TabIndex = 50;
            this.groupControl2.Text = "Cấu hình thanh toán";
            // 
            // btnPrepareData
            // 
            this.btnPrepareData.Location = new System.Drawing.Point(356, 103);
            this.btnPrepareData.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrepareData.Name = "btnPrepareData";
            this.btnPrepareData.Size = new System.Drawing.Size(219, 45);
            this.btnPrepareData.TabIndex = 3;
            this.btnPrepareData.Text = "Chuẩn bị dữ liệu";
            this.btnPrepareData.Click += new System.EventHandler(this.btnPrepareData_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(415, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Thay mã thanh toán bằng {MTT} để tự động thay thế trong excel  ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cú pháp";
            // 
            // txtCommandUSSD
            // 
            this.txtCommandUSSD.EditValue = "*998#|1|{MTT}|3";
            this.txtCommandUSSD.Location = new System.Drawing.Point(91, 46);
            this.txtCommandUSSD.Name = "txtCommandUSSD";
            this.txtCommandUSSD.Size = new System.Drawing.Size(484, 22);
            this.txtCommandUSSD.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pbSendProcess);
            this.groupControl1.Controls.Add(this.lblNumberCOM);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnRun);
            this.groupControl1.Location = new System.Drawing.Point(2, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(303, 177);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thanh toán";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // pbSendProcess
            // 
            this.pbSendProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbSendProcess.Location = new System.Drawing.Point(2, 153);
            this.pbSendProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSendProcess.Name = "pbSendProcess";
            this.pbSendProcess.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.pbSendProcess.Properties.ShowTitle = true;
            this.pbSendProcess.ShowProgressInTaskBar = true;
            this.pbSendProcess.Size = new System.Drawing.Size(299, 22);
            this.pbSendProcess.TabIndex = 49;
            this.pbSendProcess.Visible = false;
            // 
            // lblNumberCOM
            // 
            this.lblNumberCOM.Location = new System.Drawing.Point(146, 116);
            this.lblNumberCOM.Name = "lblNumberCOM";
            this.lblNumberCOM.Size = new System.Drawing.Size(7, 16);
            this.lblNumberCOM.TabIndex = 48;
            this.lblNumberCOM.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 17);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Số cổng đã chọn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::C3TekClient.Properties.Resources.ms_excel_icon_16;
            this.simpleButton2.Location = new System.Drawing.Point(128, 49);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 45);
            this.simpleButton2.TabIndex = 46;
            this.simpleButton2.Text = "Xuất Excel";
            // 
            // btnRun
            // 
            this.btnRun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.ImageOptions.Image")));
            this.btnRun.Location = new System.Drawing.Point(19, 49);
            this.btnRun.Margin = new System.Windows.Forms.Padding(6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(97, 45);
            this.btnRun.TabIndex = 45;
            this.btnRun.Text = "Bắt đầu";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 182);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1319, 331);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Thống kê truy vấn";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.viewGSM;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1315, 301);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGSM});
            // 
            // viewGSM
            // 
            this.viewGSM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AppPort,
            this.PhoneNumber,
            this.MaTT,
            this.USSD,
            this.USSDResult,
            this.Status});
            this.viewGSM.GridControl = this.gridControl1;
            this.viewGSM.Name = "viewGSM";
            this.viewGSM.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.viewGSM.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Update;
            this.viewGSM.OptionsSelection.MultiSelect = true;
            this.viewGSM.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // AppPort
            // 
            this.AppPort.Caption = "Cổng tự đặt";
            this.AppPort.FieldName = "AppPort";
            this.AppPort.MinWidth = 25;
            this.AppPort.Name = "AppPort";
            this.AppPort.Visible = true;
            this.AppPort.VisibleIndex = 0;
            this.AppPort.Width = 94;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Số điện thoại";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 25;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 1;
            this.PhoneNumber.Width = 94;
            // 
            // MaTT
            // 
            this.MaTT.Caption = "Mã thanh toán";
            this.MaTT.FieldName = "MaTT";
            this.MaTT.MinWidth = 25;
            this.MaTT.Name = "MaTT";
            this.MaTT.Visible = true;
            this.MaTT.VisibleIndex = 2;
            this.MaTT.Width = 94;
            // 
            // USSD
            // 
            this.USSD.Caption = "USSD";
            this.USSD.FieldName = "USSD";
            this.USSD.MinWidth = 25;
            this.USSD.Name = "USSD";
            this.USSD.Visible = true;
            this.USSD.VisibleIndex = 3;
            this.USSD.Width = 94;
            // 
            // USSDResult
            // 
            this.USSDResult.Caption = "Kết quả";
            this.USSDResult.FieldName = "USSDResult";
            this.USSDResult.MinWidth = 25;
            this.USSDResult.Name = "USSDResult";
            this.USSDResult.Visible = true;
            this.USSDResult.VisibleIndex = 4;
            this.USSDResult.Width = 94;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 5;
            this.Status.Width = 94;
            // 
            // USSDTopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 513);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "USSDTopup";
            this.Text = "USSDTopup";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommandUSSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGSM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ProgressBarControl pbSendProcess;
        private DevExpress.XtraEditors.LabelControl lblNumberCOM;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnRun;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCommandUSSD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView viewGSM;
        private DevExpress.XtraGrid.Columns.GridColumn AppPort;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn USSD;
        private DevExpress.XtraGrid.Columns.GridColumn USSDResult;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn MaTT;
        private DevExpress.XtraEditors.SimpleButton btnPrepareData;
    }
}