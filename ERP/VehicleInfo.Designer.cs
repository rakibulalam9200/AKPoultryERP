namespace ERP
{
    partial class VehicleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleInfo));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboVType = new System.Windows.Forms.ComboBox();
            this.cboVNo = new System.Windows.Forms.ComboBox();
            this.cboVID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLicExpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVIN = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboVPN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboVRmk = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDRmk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboHRmk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboHName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboHID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.PanelTop.Size = new System.Drawing.Size(1100, 30);
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
            this.label26.Location = new System.Drawing.Point(920, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(180, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Vehicle Information...";
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
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(933, 324);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 23);
            this.lblShowTotal.TabIndex = 130;
            this.lblShowTotal.Text = "Total Record : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 352);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1082, 283);
            this.Grid.TabIndex = 131;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // btnLoadCombo
            // 
            this.btnLoadCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCombo.Image")));
            this.btnLoadCombo.Location = new System.Drawing.Point(432, 15);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(33, 28);
            this.btnLoadCombo.TabIndex = 139;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(362, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 28);
            this.btnSearch.TabIndex = 137;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(285, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 138;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(208, 15);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cboVType
            // 
            this.cboVType.FormattingEnabled = true;
            this.cboVType.Location = new System.Drawing.Point(326, 46);
            this.cboVType.Name = "cboVType";
            this.cboVType.Size = new System.Drawing.Size(139, 22);
            this.cboVType.TabIndex = 134;
            this.cboVType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVType_KeyPress);
            // 
            // cboVNo
            // 
            this.cboVNo.FormattingEnabled = true;
            this.cboVNo.Location = new System.Drawing.Point(108, 46);
            this.cboVNo.Name = "cboVNo";
            this.cboVNo.Size = new System.Drawing.Size(139, 22);
            this.cboVNo.TabIndex = 133;
            this.cboVNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVNo_KeyPress);
            // 
            // cboVID
            // 
            this.cboVID.FormattingEnabled = true;
            this.cboVID.Location = new System.Drawing.Point(108, 19);
            this.cboVID.Name = "cboVID";
            this.cboVID.Size = new System.Drawing.Size(98, 22);
            this.cboVID.TabIndex = 1;
            this.cboVID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVID_KeyPress);
            this.cboVID.Leave += new System.EventHandler(this.cboVID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 141;
            this.label4.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 140;
            this.label3.Text = "Vehicle No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 135;
            this.label2.Text = "Vehicle ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 143;
            this.label1.Text = "Registration Date";
            // 
            // dtpResDate
            // 
            this.dtpResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResDate.Location = new System.Drawing.Point(108, 71);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(137, 22);
            this.dtpResDate.TabIndex = 144;
            this.dtpResDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpResDate_KeyPress);
            // 
            // dtpLicExpDate
            // 
            this.dtpLicExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicExpDate.Location = new System.Drawing.Point(326, 71);
            this.dtpLicExpDate.Name = "dtpLicExpDate";
            this.dtpLicExpDate.Size = new System.Drawing.Size(139, 22);
            this.dtpLicExpDate.TabIndex = 146;
            this.dtpLicExpDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpLicExpDate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 145;
            this.label5.Text = "Expiry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 147;
            this.label6.Text = "Identification No.";
            // 
            // cboVIN
            // 
            this.cboVIN.FormattingEnabled = true;
            this.cboVIN.Location = new System.Drawing.Point(108, 96);
            this.cboVIN.Name = "cboVIN";
            this.cboVIN.Size = new System.Drawing.Size(137, 22);
            this.cboVIN.TabIndex = 148;
            this.cboVIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVIN_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboVPN);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboVRmk);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboVNo);
            this.groupBox1.Controls.Add(this.btnLoadCombo);
            this.groupBox1.Controls.Add(this.cboVIN);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.cboVID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpLicExpDate);
            this.groupBox1.Controls.Add(this.cboVType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpResDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 154);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // cboVPN
            // 
            this.cboVPN.FormattingEnabled = true;
            this.cboVPN.Location = new System.Drawing.Point(326, 96);
            this.cboVPN.Name = "cboVPN";
            this.cboVPN.Size = new System.Drawing.Size(139, 22);
            this.cboVPN.TabIndex = 152;
            this.cboVPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPlateNo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 14);
            this.label14.TabIndex = 151;
            this.label14.Text = "Plate No.";
            // 
            // cboVRmk
            // 
            this.cboVRmk.FormattingEnabled = true;
            this.cboVRmk.Location = new System.Drawing.Point(108, 121);
            this.cboVRmk.Name = "cboVRmk";
            this.cboVRmk.Size = new System.Drawing.Size(357, 22);
            this.cboVRmk.TabIndex = 150;
            this.cboVRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboVRmk_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 149;
            this.label13.Text = "Remarks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDRmk);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboDName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboDID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 98);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Driver Information";
            // 
            // cboDRmk
            // 
            this.cboDRmk.FormattingEnabled = true;
            this.cboDRmk.Location = new System.Drawing.Point(108, 68);
            this.cboDRmk.Name = "cboDRmk";
            this.cboDRmk.Size = new System.Drawing.Size(357, 22);
            this.cboDRmk.TabIndex = 149;
            this.cboDRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDRmk_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 150;
            this.label9.Text = "Remarks";
            // 
            // cboDName
            // 
            this.cboDName.FormattingEnabled = true;
            this.cboDName.Location = new System.Drawing.Point(108, 43);
            this.cboDName.Name = "cboDName";
            this.cboDName.Size = new System.Drawing.Size(357, 22);
            this.cboDName.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 140;
            this.label7.Text = "Driver Name";
            // 
            // cboDID
            // 
            this.cboDID.FormattingEnabled = true;
            this.cboDID.Location = new System.Drawing.Point(108, 19);
            this.cboDID.Name = "cboDID";
            this.cboDID.Size = new System.Drawing.Size(98, 22);
            this.cboDID.TabIndex = 132;
            this.cboDID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDID_KeyPress);
            this.cboDID.Leave += new System.EventHandler(this.cboDID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 135;
            this.label10.Text = "Employee ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboHRmk);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboHName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboHID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(500, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 98);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Helper Information";
            // 
            // cboHRmk
            // 
            this.cboHRmk.FormattingEnabled = true;
            this.cboHRmk.Location = new System.Drawing.Point(108, 68);
            this.cboHRmk.Name = "cboHRmk";
            this.cboHRmk.Size = new System.Drawing.Size(357, 22);
            this.cboHRmk.TabIndex = 149;
            this.cboHRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboHRmk_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 150;
            this.label8.Text = "Remarks";
            // 
            // cboHName
            // 
            this.cboHName.FormattingEnabled = true;
            this.cboHName.Location = new System.Drawing.Point(108, 43);
            this.cboHName.Name = "cboHName";
            this.cboHName.Size = new System.Drawing.Size(357, 22);
            this.cboHName.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 140;
            this.label11.Text = "Helper Name";
            // 
            // cboHID
            // 
            this.cboHID.FormattingEnabled = true;
            this.cboHID.Location = new System.Drawing.Point(108, 19);
            this.cboHID.Name = "cboHID";
            this.cboHID.Size = new System.Drawing.Size(98, 22);
            this.cboHID.TabIndex = 132;
            this.cboHID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboHID_KeyPress);
            this.cboHID.Leave += new System.EventHandler(this.cboHID_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 14);
            this.label12.TabIndex = 135;
            this.label12.Text = "Employee ID";
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(336, 304);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(86, 28);
            this.btnLoadGridData.TabIndex = 156;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(263, 304);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(69, 28);
            this.btnReport.TabIndex = 155;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(199, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(58, 28);
            this.btnExit.TabIndex = 154;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(127, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 153;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(55, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 152;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // VehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnLoadGridData);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResInfo";
            this.Load += new System.EventHandler(this.VehicleInfo_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboVType;
        private System.Windows.Forms.ComboBox cboVNo;
        private System.Windows.Forms.ComboBox cboVID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpResDate;
        private System.Windows.Forms.DateTimePicker dtpLicExpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDRmk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboHRmk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboHName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboHID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboVRmk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboVPN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLoadGridData;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}