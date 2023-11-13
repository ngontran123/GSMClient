﻿
namespace C3TekClient.GSM
{
    partial class WSMessageSMSUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSMessageSMSUI));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression5 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression6 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression7 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression8 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Body = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewSMS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RealPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AppPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSMS = new DevExpress.XtraGrid.GridControl();
            this.btnRetry = new DevExpress.XtraEditors.SimpleButton();
            this.lblCompleReport = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSendProcess = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtPhoneTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenLastSession = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveSession = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberWaitNetwork = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnExcelSample = new DevExpress.XtraEditors.SimpleButton();
            this.txtDelaySecond = new System.Windows.Forms.NumericUpDown();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrepareData = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessageBody = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rgCallMode = new DevExpress.XtraEditors.RadioGroup();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSMS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneTo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberWaitNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelaySecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCallMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 24;
            this.Status.Name = "Status";
            this.Status.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Body
            // 
            resources.ApplyResources(this.Body, "Body");
            this.Body.FieldName = "Body";
            this.Body.MinWidth = 24;
            this.Body.Name = "Body";
            this.Body.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // viewSMS
            // 
            resources.ApplyResources(this.viewSMS, "viewSMS");
            this.viewSMS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RealPort,
            this.AppPort,
            this.PhoneNumber,
            this.PhoneTo,
            this.Body,
            this.Status});
            gridFormatRule5.Column = this.Status;
            gridFormatRule5.ColumnApplyTo = this.Status;
            gridFormatRule5.Name = "Format0";
            formatConditionRuleExpression5.Appearance.BackColor = System.Drawing.Color.Green;
            formatConditionRuleExpression5.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleExpression5.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression5.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression5.Expression = "[Status] = \'Thành công\' Or [Status] = \'Success\'";
            gridFormatRule5.Rule = formatConditionRuleExpression5;
            gridFormatRule6.Column = this.Status;
            gridFormatRule6.ColumnApplyTo = this.Status;
            gridFormatRule6.Name = "Format1";
            formatConditionRuleExpression6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression6.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleExpression6.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression6.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression6.Expression = "Contains([Status], \'Lỗi\') Or Contains([Status], \'Error\')";
            gridFormatRule6.Rule = formatConditionRuleExpression6;
            gridFormatRule7.Column = this.Status;
            gridFormatRule7.ColumnApplyTo = this.Status;
            gridFormatRule7.Name = "Format2";
            formatConditionRuleExpression7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression7.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleExpression7.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression7.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression7.Expression = "[Status] = \'Trong hàng đợi\' Or [Status] = \'In queue\'";
            gridFormatRule7.Rule = formatConditionRuleExpression7;
            gridFormatRule8.Column = this.Status;
            gridFormatRule8.ColumnApplyTo = this.Status;
            gridFormatRule8.Name = "Format3";
            formatConditionRuleExpression8.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            formatConditionRuleExpression8.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleExpression8.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression8.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression8.Expression = "[Status] = \'Đang xử lý\' Or [Status] = \'Processing\'";
            gridFormatRule8.Rule = formatConditionRuleExpression8;
            this.viewSMS.FormatRules.Add(gridFormatRule5);
            this.viewSMS.FormatRules.Add(gridFormatRule6);
            this.viewSMS.FormatRules.Add(gridFormatRule7);
            this.viewSMS.FormatRules.Add(gridFormatRule8);
            this.viewSMS.GridControl = this.gridSMS;
            this.viewSMS.Name = "viewSMS";
            // 
            // RealPort
            // 
            resources.ApplyResources(this.RealPort, "RealPort");
            this.RealPort.FieldName = "RealPort";
            this.RealPort.MinWidth = 24;
            this.RealPort.Name = "RealPort";
            this.RealPort.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // AppPort
            // 
            resources.ApplyResources(this.AppPort, "AppPort");
            this.AppPort.FieldName = "AppPort";
            this.AppPort.MinWidth = 24;
            this.AppPort.Name = "AppPort";
            this.AppPort.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // PhoneNumber
            // 
            resources.ApplyResources(this.PhoneNumber, "PhoneNumber");
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 24;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // PhoneTo
            // 
            resources.ApplyResources(this.PhoneTo, "PhoneTo");
            this.PhoneTo.FieldName = "PhoneTo";
            this.PhoneTo.MinWidth = 24;
            this.PhoneTo.Name = "PhoneTo";
            this.PhoneTo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridSMS
            // 
            resources.ApplyResources(this.gridSMS, "gridSMS");
            this.gridSMS.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridSMS.EmbeddedNavigator.AccessibleDescription");
            this.gridSMS.EmbeddedNavigator.AccessibleName = resources.GetString("gridSMS.EmbeddedNavigator.AccessibleName");
            this.gridSMS.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridSMS.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridSMS.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridSMS.EmbeddedNavigator.Anchor")));
            this.gridSMS.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridSMS.EmbeddedNavigator.BackgroundImage")));
            this.gridSMS.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridSMS.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridSMS.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridSMS.EmbeddedNavigator.ImeMode")));
            this.gridSMS.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridSMS.EmbeddedNavigator.Margin")));
            this.gridSMS.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridSMS.EmbeddedNavigator.MaximumSize")));
            this.gridSMS.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridSMS.EmbeddedNavigator.TextLocation")));
            this.gridSMS.EmbeddedNavigator.ToolTip = resources.GetString("gridSMS.EmbeddedNavigator.ToolTip");
            this.gridSMS.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridSMS.EmbeddedNavigator.ToolTipIconType")));
            this.gridSMS.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridSMS.EmbeddedNavigator.ToolTipTitle");
            this.gridSMS.MainView = this.viewSMS;
            this.gridSMS.Name = "gridSMS";
            this.gridSMS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewSMS});
            this.gridSMS.Click += new System.EventHandler(this.gridSMS_Click);
            // 
            // btnRetry
            // 
            resources.ApplyResources(this.btnRetry, "btnRetry");
            this.btnRetry.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRetry.ImageOptions.SvgImage")));
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_click);
            // 
            // lblCompleReport
            // 
            resources.ApplyResources(this.lblCompleReport, "lblCompleReport");
            this.lblCompleReport.Name = "lblCompleReport";
            // 
            // labelControl7
            // 
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Name = "labelControl7";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnImportExcel
            // 
            resources.ApplyResources(this.btnImportExcel, "btnImportExcel");
            this.btnImportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportExcel.ImageOptions.SvgImage")));
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ImageOptions.SvgImage = global::C3TekClient.Properties.Resources.gettingstarted;
            this.btnStart.Name = "btnStart";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.gridSMS);
            this.panel1.Name = "panel1";
            // 
            // pbSendProcess
            // 
            resources.ApplyResources(this.pbSendProcess, "pbSendProcess");
            this.pbSendProcess.Name = "pbSendProcess";
            this.pbSendProcess.Properties.AutoHeight = ((bool)(resources.GetObject("pbSendProcess.Properties.AutoHeight")));
            this.pbSendProcess.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.pbSendProcess.Properties.ShowTitle = true;
            this.pbSendProcess.ShowProgressInTaskBar = true;
            // 
            // txtPhoneTo
            // 
            resources.ApplyResources(this.txtPhoneTo, "txtPhoneTo");
            this.txtPhoneTo.Name = "txtPhoneTo";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnOpenLastSession);
            this.groupBox1.Controls.Add(this.btnSaveSession);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.txtNumberWaitNetwork);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.btnExcelSample);
            this.groupBox1.Controls.Add(this.txtDelaySecond);
            this.groupBox1.Controls.Add(this.svgImageBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrepareData);
            this.groupBox1.Controls.Add(this.txtMessageBody);
            this.groupBox1.Controls.Add(this.btnRetry);
            this.groupBox1.Controls.Add(this.lblCompleReport);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnImportExcel);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.pbSendProcess);
            this.groupBox1.Controls.Add(this.rgCallMode);
            this.groupBox1.Controls.Add(this.txtPhoneTo);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnOpenLastSession
            // 
            resources.ApplyResources(this.btnOpenLastSession, "btnOpenLastSession");
            this.btnOpenLastSession.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenLastSession.ImageOptions.Image")));
            this.btnOpenLastSession.Name = "btnOpenLastSession";
            this.btnOpenLastSession.Click += new System.EventHandler(this.btnOpenLastSession_Click);
            // 
            // btnSaveSession
            // 
            resources.ApplyResources(this.btnSaveSession, "btnSaveSession");
            this.btnSaveSession.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSession.ImageOptions.Image")));
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // labelControl8
            // 
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Name = "labelControl8";
            // 
            // txtNumberWaitNetwork
            // 
            resources.ApplyResources(this.txtNumberWaitNetwork, "txtNumberWaitNetwork");
            this.txtNumberWaitNetwork.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtNumberWaitNetwork.Name = "txtNumberWaitNetwork";
            this.txtNumberWaitNetwork.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumberWaitNetwork.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // btnExcelSample
            // 
            resources.ApplyResources(this.btnExcelSample, "btnExcelSample");
            this.btnExcelSample.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelSample.ImageOptions.Image")));
            this.btnExcelSample.Name = "btnExcelSample";
            this.btnExcelSample.Click += new System.EventHandler(this.btnExcelSample_Click);
            // 
            // txtDelaySecond
            // 
            resources.ApplyResources(this.txtDelaySecond, "txtDelaySecond");
            this.txtDelaySecond.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDelaySecond.Name = "txtDelaySecond";
            this.txtDelaySecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDelaySecond.ValueChanged += new System.EventHandler(this.txtDelaySecond_ValueChanged);
            // 
            // svgImageBox1
            // 
            resources.ApplyResources(this.svgImageBox1, "svgImageBox1");
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // btnPrepareData
            // 
            resources.ApplyResources(this.btnPrepareData, "btnPrepareData");
            this.btnPrepareData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrepareData.ImageOptions.SvgImage")));
            this.btnPrepareData.Name = "btnPrepareData";
            this.btnPrepareData.Click += new System.EventHandler(this.btnPrepareData_Click);
            // 
            // txtMessageBody
            // 
            resources.ApplyResources(this.txtMessageBody, "txtMessageBody");
            this.txtMessageBody.Name = "txtMessageBody";
            // 
            // labelControl6
            // 
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // rgCallMode
            // 
            resources.ApplyResources(this.rgCallMode, "rgCallMode");
            this.rgCallMode.Name = "rgCallMode";
            this.rgCallMode.Properties.AllowFocused = false;
            this.rgCallMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("rgCallMode.Properties.Items"))), resources.GetString("rgCallMode.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("rgCallMode.Properties.Items2"))), resources.GetString("rgCallMode.Properties.Items3"))});
            // 
            // WSMessageSMSUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::C3TekClient.Properties.Resources.send_sms_24;
            this.Name = "WSMessageSMSUI";
            this.Load += new System.EventHandler(this.WSMessageSMSUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSMS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSendProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneTo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberWaitNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelaySecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCallMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView viewSMS;
        private DevExpress.XtraGrid.GridControl gridSMS;
        private DevExpress.XtraEditors.SimpleButton btnRetry;
        private DevExpress.XtraEditors.LabelControl lblCompleReport;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ProgressBarControl pbSendProcess;
        private DevExpress.XtraEditors.TextEdit txtPhoneTo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup rgCallMode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox txtMessageBody;
        private DevExpress.XtraGrid.Columns.GridColumn RealPort;
        private DevExpress.XtraGrid.Columns.GridColumn AppPort;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneTo;
        private DevExpress.XtraGrid.Columns.GridColumn Body;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.SimpleButton btnPrepareData;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private System.Windows.Forms.NumericUpDown txtDelaySecond;
        private DevExpress.XtraEditors.SimpleButton btnExcelSample;
        private System.Windows.Forms.NumericUpDown txtNumberWaitNetwork;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnSaveSession;
        private DevExpress.XtraEditors.SimpleButton btnOpenLastSession;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}