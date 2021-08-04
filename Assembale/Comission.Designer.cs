namespace ERP
{
    partial class Comission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comission));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboPartyName = new System.Windows.Forms.ComboBox();
            this.cboPartyCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.txtConv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYearlyCom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBaseCom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridParty = new System.Windows.Forms.DataGridView();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cboRmk = new System.Windows.Forms.ComboBox();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSrcParty = new System.Windows.Forms.Button();
            this.cboShortName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtItemAutoNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
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
            this.PanelTop.Size = new System.Drawing.Size(1089, 30);
            this.PanelTop.TabIndex = 28;
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
            this.label26.Location = new System.Drawing.Point(863, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(237, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Customer Comission Setup...";
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
            // MsgTimer
            // 
            this.MsgTimer.Enabled = true;
            this.MsgTimer.Interval = 5000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // btnLoadCombo
            // 
            this.btnLoadCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCombo.Image")));
            this.btnLoadCombo.Location = new System.Drawing.Point(422, 39);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(33, 28);
            this.btnLoadCombo.TabIndex = 19;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(352, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 28);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(275, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnClear_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(198, 39);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cboPartyName
            // 
            this.cboPartyName.FormattingEnabled = true;
            this.cboPartyName.Location = new System.Drawing.Point(98, 72);
            this.cboPartyName.Name = "cboPartyName";
            this.cboPartyName.Size = new System.Drawing.Size(357, 22);
            this.cboPartyName.TabIndex = 1;
            this.cboPartyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPartyName_KeyPress);
            // 
            // cboPartyCode
            // 
            this.cboPartyCode.FormattingEnabled = true;
            this.cboPartyCode.Location = new System.Drawing.Point(98, 43);
            this.cboPartyCode.Name = "cboPartyCode";
            this.cboPartyCode.Size = new System.Drawing.Size(98, 22);
            this.cboPartyCode.TabIndex = 0;
            this.cboPartyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPartyCode_KeyPress);
            this.cboPartyCode.Leave += new System.EventHandler(this.cboPartyCode_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 48;
            this.label3.Text = "Party Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "Party Code";
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(98, 122);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(357, 22);
            this.cboItemName.TabIndex = 2;
            this.cboItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItemName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 52;
            this.label4.Text = "Percent";
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(98, 147);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(61, 22);
            this.txtPerc.TabIndex = 3;
            this.txtPerc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerc_KeyPress);
            // 
            // txtConv
            // 
            this.txtConv.Location = new System.Drawing.Point(247, 147);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(61, 22);
            this.txtConv.TabIndex = 4;
            this.txtConv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConv_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Conv. TK";
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(394, 147);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(61, 22);
            this.txtTrans.TabIndex = 5;
            this.txtTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrans_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 56;
            this.label6.Text = "Van Tans (TK)";
            // 
            // txtYearlyCom
            // 
            this.txtYearlyCom.Location = new System.Drawing.Point(394, 172);
            this.txtYearlyCom.Name = "txtYearlyCom";
            this.txtYearlyCom.Size = new System.Drawing.Size(61, 22);
            this.txtYearlyCom.TabIndex = 8;
            this.txtYearlyCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearlyCom_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 62;
            this.label7.Text = "Yearly Com.";
            // 
            // txtMonCom
            // 
            this.txtMonCom.Location = new System.Drawing.Point(247, 172);
            this.txtMonCom.Name = "txtMonCom";
            this.txtMonCom.Size = new System.Drawing.Size(61, 22);
            this.txtMonCom.TabIndex = 7;
            this.txtMonCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonCom_KeyPress);
            this.txtMonCom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonCom_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 60;
            this.label8.Text = "Monthly Com.";
            // 
            // txtBaseCom
            // 
            this.txtBaseCom.Location = new System.Drawing.Point(98, 172);
            this.txtBaseCom.Name = "txtBaseCom";
            this.txtBaseCom.Size = new System.Drawing.Size(61, 22);
            this.txtBaseCom.TabIndex = 6;
            this.txtBaseCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaseCom_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 58;
            this.label9.Text = "Base Com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 68;
            this.label10.Text = "Remarks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridParty);
            this.groupBox1.Location = new System.Drawing.Point(505, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 308);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Customer List";
            // 
            // GridParty
            // 
            this.GridParty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParty.Location = new System.Drawing.Point(6, 21);
            this.GridParty.Name = "GridParty";
            this.GridParty.Size = new System.Drawing.Size(560, 281);
            this.GridParty.TabIndex = 0;
            this.GridParty.DoubleClick += new System.EventHandler(this.GridParty_DoubleClick);
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(13, 352);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1064, 286);
            this.Grid.TabIndex = 15;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            this.Grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_KeyPress);
            // 
            // cboRmk
            // 
            this.cboRmk.FormattingEnabled = true;
            this.cboRmk.Location = new System.Drawing.Point(98, 197);
            this.cboRmk.Name = "cboRmk";
            this.cboRmk.Size = new System.Drawing.Size(357, 22);
            this.cboRmk.TabIndex = 9;
            this.cboRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRmk_KeyPress);
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(379, 253);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(86, 28);
            this.btnLoadGridData.TabIndex = 14;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(306, 253);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(69, 28);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(242, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(58, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(170, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(98, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSave_KeyPress);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(98, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "All Company Commission Depend on TK per KG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSrcParty
            // 
            this.btnSrcParty.Image = ((System.Drawing.Image)(resources.GetObject("btnSrcParty.Image")));
            this.btnSrcParty.Location = new System.Drawing.Point(457, 70);
            this.btnSrcParty.Name = "btnSrcParty";
            this.btnSrcParty.Size = new System.Drawing.Size(30, 26);
            this.btnSrcParty.TabIndex = 92;
            this.btnSrcParty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSrcParty.UseVisualStyleBackColor = true;
            // 
            // cboShortName
            // 
            this.cboShortName.FormattingEnabled = true;
            this.cboShortName.Location = new System.Drawing.Point(275, 97);
            this.cboShortName.Name = "cboShortName";
            this.cboShortName.Size = new System.Drawing.Size(180, 22);
            this.cboShortName.TabIndex = 93;
            this.cboShortName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboShortName_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 94;
            this.label12.Text = "Short Name";
            // 
            // cboItemCode
            // 
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(98, 97);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(103, 22);
            this.cboItemCode.TabIndex = 95;
            this.cboItemCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItemCode_KeyPress);
            this.cboItemCode.Leave += new System.EventHandler(this.cboItemCode_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 14);
            this.label13.TabIndex = 96;
            this.label13.Text = "Item Code";
            // 
            // txtItemAutoNo
            // 
            this.txtItemAutoNo.Location = new System.Drawing.Point(45, 257);
            this.txtItemAutoNo.Name = "txtItemAutoNo";
            this.txtItemAutoNo.Size = new System.Drawing.Size(29, 22);
            this.txtItemAutoNo.TabIndex = 0;
            this.txtItemAutoNo.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 14);
            this.label14.TabIndex = 99;
            this.label14.Text = "IAuto";
            this.label14.Visible = false;
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(339, 321);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 23);
            this.lblShowTotal.TabIndex = 128;
            this.lblShowTotal.Text = "Total Item : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1089, 650);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtItemAutoNo);
            this.Controls.Add(this.cboItemCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboShortName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSrcParty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLoadGridData);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRmk);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYearlyCom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMonCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBaseCom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadCombo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cboPartyName);
            this.Controls.Add(this.cboPartyCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyComission";
            this.Load += new System.EventHandler(this.Comission_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboPartyName;
        private System.Windows.Forms.ComboBox cboPartyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.TextBox txtConv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYearlyCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBaseCom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridView GridParty;
        private System.Windows.Forms.ComboBox cboRmk;
        private System.Windows.Forms.Button btnLoadGridData;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSrcParty;
        private System.Windows.Forms.ComboBox cboShortName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboItemCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtItemAutoNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblShowTotal;
    }
}