namespace ERP
{
    partial class PartyCreditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyCreditInfo));
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboPartyName = new System.Windows.Forms.ComboBox();
            this.cboPartyCode = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cboAutoNo = new System.Windows.Forms.ComboBox();
            this.cboComName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCreditInfo = new System.Windows.Forms.GroupBox();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.CboSlNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboRptRes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRptGroup = new System.Windows.Forms.ComboBox();
            this.cboRptCompany = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboComId = new System.Windows.Forms.ComboBox();
            this.grpCreditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCombo
            // 
            this.btnLoadCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCombo.Image")));
            this.btnLoadCombo.Location = new System.Drawing.Point(366, 39);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(33, 28);
            this.btnLoadCombo.TabIndex = 14;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(296, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(219, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(206, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnAddNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAddNew_KeyPress);
            // 
            // cboPartyName
            // 
            this.cboPartyName.FormattingEnabled = true;
            this.cboPartyName.Location = new System.Drawing.Point(114, 73);
            this.cboPartyName.Name = "cboPartyName";
            this.cboPartyName.Size = new System.Drawing.Size(285, 22);
            this.cboPartyName.TabIndex = 1;
            this.cboPartyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPartyName_KeyPress);
            // 
            // cboPartyCode
            // 
            this.cboPartyCode.FormattingEnabled = true;
            this.cboPartyCode.Location = new System.Drawing.Point(114, 43);
            this.cboPartyCode.Name = "cboPartyCode";
            this.cboPartyCode.Size = new System.Drawing.Size(98, 22);
            this.cboPartyCode.TabIndex = 0;
            this.cboPartyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPartyCode_KeyPress);
            this.cboPartyCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboPartyCode_KeyUp);
            this.cboPartyCode.Leave += new System.EventHandler(this.cboPartyCode_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(430, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 14);
            this.label28.TabIndex = 64;
            this.label28.Text = "Auto No";
            this.label28.Visible = false;
            // 
            // cboAutoNo
            // 
            this.cboAutoNo.FormattingEnabled = true;
            this.cboAutoNo.Location = new System.Drawing.Point(483, 36);
            this.cboAutoNo.Name = "cboAutoNo";
            this.cboAutoNo.Size = new System.Drawing.Size(83, 22);
            this.cboAutoNo.TabIndex = 63;
            this.cboAutoNo.Visible = false;
            // 
            // cboComName
            // 
            this.cboComName.FormattingEnabled = true;
            this.cboComName.Location = new System.Drawing.Point(102, 44);
            this.cboComName.Name = "cboComName";
            this.cboComName.Size = new System.Drawing.Size(285, 22);
            this.cboComName.TabIndex = 5;
            this.cboComName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboComName_KeyPress);
            this.cboComName.Leave += new System.EventHandler(this.cboComName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 61;
            this.label3.Text = "Party Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 60;
            this.label2.Text = "Party ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Company Name";
            // 
            // grpCreditInfo
            // 
            this.grpCreditInfo.Controls.Add(this.btnLoadGridData);
            this.grpCreditInfo.Controls.Add(this.CboSlNo);
            this.grpCreditInfo.Controls.Add(this.label7);
            this.grpCreditInfo.Controls.Add(this.txtCredit);
            this.grpCreditInfo.Controls.Add(this.label4);
            this.grpCreditInfo.Controls.Add(this.cboComName);
            this.grpCreditInfo.Controls.Add(this.label1);
            this.grpCreditInfo.Controls.Add(this.btnExit);
            this.grpCreditInfo.Controls.Add(this.btnSave);
            this.grpCreditInfo.Controls.Add(this.btnDelete);
            this.grpCreditInfo.Controls.Add(this.btnAddNew);
            this.grpCreditInfo.Location = new System.Drawing.Point(12, 107);
            this.grpCreditInfo.Name = "grpCreditInfo";
            this.grpCreditInfo.Size = new System.Drawing.Size(468, 160);
            this.grpCreditInfo.TabIndex = 2;
            this.grpCreditInfo.TabStop = false;
            this.grpCreditInfo.Text = "Credit Information";
            this.grpCreditInfo.Enter += new System.EventHandler(this.grpCreditInfo_Enter);
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(311, 110);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(86, 28);
            this.btnLoadGridData.TabIndex = 10;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Visible = false;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // CboSlNo
            // 
            this.CboSlNo.FormattingEnabled = true;
            this.CboSlNo.Location = new System.Drawing.Point(102, 16);
            this.CboSlNo.Name = "CboSlNo";
            this.CboSlNo.Size = new System.Drawing.Size(98, 22);
            this.CboSlNo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 78;
            this.label7.Text = "SL No";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(102, 72);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(98, 22);
            this.txtCredit.TabIndex = 6;
            this.txtCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Credit Limit";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(248, 110);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(58, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(102, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSave_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(176, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 289);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1076, 337);
            this.Grid.TabIndex = 11;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.cboRptRes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboRptGroup);
            this.groupBox2.Controls.Add(this.cboRptCompany);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(642, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 153);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credit Report";
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(88, 99);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(101, 28);
            this.btnReport.TabIndex = 74;
            this.btnReport.Text = "Credit Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboRptRes
            // 
            this.cboRptRes.FormattingEnabled = true;
            this.cboRptRes.Location = new System.Drawing.Point(88, 71);
            this.cboRptRes.Name = "cboRptRes";
            this.cboRptRes.Size = new System.Drawing.Size(321, 22);
            this.cboRptRes.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 72;
            this.label5.Text = "Responsivility";
            // 
            // cboRptGroup
            // 
            this.cboRptGroup.FormattingEnabled = true;
            this.cboRptGroup.Location = new System.Drawing.Point(88, 46);
            this.cboRptGroup.Name = "cboRptGroup";
            this.cboRptGroup.Size = new System.Drawing.Size(155, 22);
            this.cboRptGroup.TabIndex = 71;
            // 
            // cboRptCompany
            // 
            this.cboRptCompany.FormattingEnabled = true;
            this.cboRptCompany.Location = new System.Drawing.Point(88, 21);
            this.cboRptCompany.Name = "cboRptCompany";
            this.cboRptCompany.Size = new System.Drawing.Size(321, 22);
            this.cboRptCompany.TabIndex = 70;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 14);
            this.label22.TabIndex = 68;
            this.label22.Text = "Company";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 14);
            this.label21.TabIndex = 69;
            this.label21.Text = "Party Group";
            // 
            // MsgTimer
            // 
            this.MsgTimer.Enabled = true;
            this.MsgTimer.Interval = 5000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.lblWaitIco);
            this.PanelTop.Controls.Add(this.lblDelIco);
            this.PanelTop.Controls.Add(this.lblInfoIco);
            this.PanelTop.Controls.Add(this.lblSadIco);
            this.PanelTop.Controls.Add(this.lblMsg);
            this.PanelTop.Controls.Add(this.label26);
            this.PanelTop.Controls.Add(this.lblMsgIco);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1100, 30);
            this.PanelTop.TabIndex = 74;
            // 
            // lblWaitIco
            // 
            this.lblWaitIco.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Image = ((System.Drawing.Image)(resources.GetObject("lblWaitIco.Image")));
            this.lblWaitIco.Location = new System.Drawing.Point(3, 3);
            this.lblWaitIco.Name = "lblWaitIco";
            this.lblWaitIco.Size = new System.Drawing.Size(31, 24);
            this.lblWaitIco.TabIndex = 69;
            this.lblWaitIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaitIco.Visible = false;
            // 
            // lblDelIco
            // 
            this.lblDelIco.BackColor = System.Drawing.Color.Transparent;
            this.lblDelIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblDelIco.Image = ((System.Drawing.Image)(resources.GetObject("lblDelIco.Image")));
            this.lblDelIco.Location = new System.Drawing.Point(3, 3);
            this.lblDelIco.Name = "lblDelIco";
            this.lblDelIco.Size = new System.Drawing.Size(31, 24);
            this.lblDelIco.TabIndex = 68;
            this.lblDelIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelIco.Visible = false;
            // 
            // lblInfoIco
            // 
            this.lblInfoIco.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoIco.Image = ((System.Drawing.Image)(resources.GetObject("lblInfoIco.Image")));
            this.lblInfoIco.Location = new System.Drawing.Point(3, 3);
            this.lblInfoIco.Name = "lblInfoIco";
            this.lblInfoIco.Size = new System.Drawing.Size(31, 24);
            this.lblInfoIco.TabIndex = 67;
            this.lblInfoIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSadIco
            // 
            this.lblSadIco.BackColor = System.Drawing.Color.Transparent;
            this.lblSadIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSadIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblSadIco.Image = ((System.Drawing.Image)(resources.GetObject("lblSadIco.Image")));
            this.lblSadIco.Location = new System.Drawing.Point(3, 3);
            this.lblSadIco.Name = "lblSadIco";
            this.lblSadIco.Size = new System.Drawing.Size(31, 24);
            this.lblSadIco.TabIndex = 66;
            this.lblSadIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSadIco.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.Location = new System.Drawing.Point(32, 2);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(377, 26);
            this.lblMsg.TabIndex = 64;
            this.lblMsg.Text = "Notification...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(883, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(217, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Party Credit Information...";
            // 
            // lblMsgIco
            // 
            this.lblMsgIco.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgIco.ForeColor = System.Drawing.Color.White;
            this.lblMsgIco.Image = ((System.Drawing.Image)(resources.GetObject("lblMsgIco.Image")));
            this.lblMsgIco.Location = new System.Drawing.Point(3, 3);
            this.lblMsgIco.Name = "lblMsgIco";
            this.lblMsgIco.Size = new System.Drawing.Size(31, 24);
            this.lblMsgIco.TabIndex = 65;
            this.lblMsgIco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsgIco.Visible = false;
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(908, 226);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 23);
            this.lblShowTotal.TabIndex = 75;
            this.lblShowTotal.Text = "Total Record : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 76;
            this.label6.Text = "ComId";
            this.label6.Visible = false;
            // 
            // CboComId
            // 
            this.CboComId.FormattingEnabled = true;
            this.CboComId.Location = new System.Drawing.Point(483, 66);
            this.CboComId.Name = "CboComId";
            this.CboComId.Size = new System.Drawing.Size(83, 22);
            this.CboComId.TabIndex = 77;
            this.CboComId.Visible = false;
            // 
            // PartyCreditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.CboComId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.grpCreditInfo);
            this.Controls.Add(this.btnLoadCombo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboPartyName);
            this.Controls.Add(this.cboPartyCode);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cboAutoNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartyCreditInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyCreditInfo";
            this.Load += new System.EventHandler(this.PartyCreditInfo_Load);
            this.grpCreditInfo.ResumeLayout(false);
            this.grpCreditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboPartyName;
        private System.Windows.Forms.ComboBox cboPartyCode;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cboAutoNo;
        private System.Windows.Forms.ComboBox cboComName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCreditInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboRptGroup;
        private System.Windows.Forms.ComboBox cboRptCompany;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboRptRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboComId;
        private System.Windows.Forms.ComboBox CboSlNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadGridData;
    }
}