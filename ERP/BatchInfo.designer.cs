namespace ERP
{
    partial class BatchInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchInfo));
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cboSLNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBLoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboComName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.grpSrc = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GridSrc = new System.Windows.Forms.DataGridView();
            this.btnCloseSrc = new System.Windows.Forms.Button();
            this.txtSrcText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboComId = new System.Windows.Forms.ComboBox();
            this.cboAutoNo = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.grpSrc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(927, 261);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 25);
            this.lblShowTotal.TabIndex = 149;
            this.lblShowTotal.Text = "Total Record : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowTotal.TextChanged += new System.EventHandler(this.lblShowTotal_TextChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 289);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(1070, 349);
            this.Grid.TabIndex = 148;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // cboSLNo
            // 
            this.cboSLNo.FormattingEnabled = true;
            this.cboSLNo.Location = new System.Drawing.Point(315, 180);
            this.cboSLNo.Name = "cboSLNo";
            this.cboSLNo.Size = new System.Drawing.Size(79, 22);
            this.cboSLNo.TabIndex = 146;
            this.cboSLNo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 147;
            this.label8.Text = "SL No.";
            this.label8.Visible = false;
            // 
            // txtChks
            // 
            this.txtChks.Location = new System.Drawing.Point(126, 130);
            this.txtChks.Name = "txtChks";
            this.txtChks.Size = new System.Drawing.Size(143, 22);
            this.txtChks.TabIndex = 3;
            this.txtChks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChks_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 145;
            this.label7.Text = "Total Chicks";
            // 
            // txtRmk
            // 
            this.txtRmk.Location = new System.Drawing.Point(126, 205);
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(365, 22);
            this.txtRmk.TabIndex = 7;
            this.txtRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRmk_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 143;
            this.label6.Text = "Remarks";
            // 
            // cboBType
            // 
            this.cboBType.FormattingEnabled = true;
            this.cboBType.Items.AddRange(new object[] {
            "Sonali"});
            this.cboBType.Location = new System.Drawing.Point(126, 78);
            this.cboBType.Name = "cboBType";
            this.cboBType.Size = new System.Drawing.Size(143, 22);
            this.cboBType.TabIndex = 4;
            this.cboBType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChksType_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 141;
            this.label5.Text = "Batch Type";
            // 
            // cboBNo
            // 
            this.cboBNo.FormattingEnabled = true;
            this.cboBNo.Location = new System.Drawing.Point(126, 104);
            this.cboBNo.Name = "cboBNo";
            this.cboBNo.Size = new System.Drawing.Size(143, 22);
            this.cboBNo.TabIndex = 2;
            this.cboBNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBNo_KeyPress);
            this.cboBNo.Leave += new System.EventHandler(this.cboBNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 139;
            this.label4.Text = "Batch No";
            // 
            // cboBLoc
            // 
            this.cboBLoc.FormattingEnabled = true;
            this.cboBLoc.Location = new System.Drawing.Point(126, 155);
            this.cboBLoc.Name = "cboBLoc";
            this.cboBLoc.Size = new System.Drawing.Size(143, 22);
            this.cboBLoc.TabIndex = 5;
            this.cboBLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBLoc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 137;
            this.label3.Text = "Location";
            // 
            // cboBName
            // 
            this.cboBName.FormattingEnabled = true;
            this.cboBName.Location = new System.Drawing.Point(126, 180);
            this.cboBName.Name = "cboBName";
            this.cboBName.Size = new System.Drawing.Size(143, 22);
            this.cboBName.TabIndex = 6;
            this.cboBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 135;
            this.label1.Text = "Breed Name";
            // 
            // cboComName
            // 
            this.cboComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComName.FormattingEnabled = true;
            this.cboComName.Location = new System.Drawing.Point(126, 50);
            this.cboComName.Name = "cboComName";
            this.cboComName.Size = new System.Drawing.Size(365, 22);
            this.cboComName.TabIndex = 0;
            this.cboComName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboComName_KeyPress);
            this.cboComName.Leave += new System.EventHandler(this.cboComName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 133;
            this.label2.Text = "Company Name";
            // 
            // btnLoadCombo
            // 
            this.btnLoadCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCombo.Image")));
            this.btnLoadCombo.Location = new System.Drawing.Point(427, 76);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(32, 29);
            this.btnLoadCombo.TabIndex = 131;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(461, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 29);
            this.btnSearch.TabIndex = 130;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(351, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 29);
            this.btnClear.TabIndex = 129;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(275, 77);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(74, 29);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(407, 240);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(84, 29);
            this.btnLoadGridData.TabIndex = 127;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Visible = false;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(334, 240);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(67, 29);
            this.btnReport.TabIndex = 126;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(270, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(56, 29);
            this.btnExit.TabIndex = 125;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(198, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 29);
            this.btnDelete.TabIndex = 124;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(126, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(66, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.PanelTop.Size = new System.Drawing.Size(1100, 32);
            this.PanelTop.TabIndex = 150;
            // 
            // lblWaitIco
            // 
            this.lblWaitIco.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Image = ((System.Drawing.Image)(resources.GetObject("lblWaitIco.Image")));
            this.lblWaitIco.Location = new System.Drawing.Point(3, 3);
            this.lblWaitIco.Name = "lblWaitIco";
            this.lblWaitIco.Size = new System.Drawing.Size(31, 26);
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
            this.lblDelIco.Size = new System.Drawing.Size(31, 26);
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
            this.lblInfoIco.Size = new System.Drawing.Size(31, 26);
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
            this.lblSadIco.Size = new System.Drawing.Size(31, 26);
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
            this.lblMsg.Size = new System.Drawing.Size(377, 28);
            this.lblMsg.TabIndex = 64;
            this.lblMsg.Text = "Notification...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(933, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(167, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Batch Information...";
            // 
            // lblMsgIco
            // 
            this.lblMsgIco.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgIco.ForeColor = System.Drawing.Color.White;
            this.lblMsgIco.Image = ((System.Drawing.Image)(resources.GetObject("lblMsgIco.Image")));
            this.lblMsgIco.Location = new System.Drawing.Point(3, 3);
            this.lblMsgIco.Name = "lblMsgIco";
            this.lblMsgIco.Size = new System.Drawing.Size(31, 26);
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
            // grpSrc
            // 
            this.grpSrc.Controls.Add(this.comboBox1);
            this.grpSrc.Controls.Add(this.GridSrc);
            this.grpSrc.Controls.Add(this.btnCloseSrc);
            this.grpSrc.Controls.Add(this.txtSrcText);
            this.grpSrc.Controls.Add(this.label14);
            this.grpSrc.Location = new System.Drawing.Point(6, 632);
            this.grpSrc.Name = "grpSrc";
            this.grpSrc.Size = new System.Drawing.Size(996, 23);
            this.grpSrc.TabIndex = 151;
            this.grpSrc.TabStop = false;
            this.grpSrc.Text = "Search Party Information";
            this.grpSrc.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 22);
            this.comboBox1.TabIndex = 53;
            // 
            // GridSrc
            // 
            this.GridSrc.BackgroundColor = System.Drawing.Color.White;
            this.GridSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSrc.Location = new System.Drawing.Point(12, 55);
            this.GridSrc.Name = "GridSrc";
            this.GridSrc.Size = new System.Drawing.Size(1066, 539);
            this.GridSrc.TabIndex = 52;
            // 
            // btnCloseSrc
            // 
            this.btnCloseSrc.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSrc.Image")));
            this.btnCloseSrc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSrc.Location = new System.Drawing.Point(691, 19);
            this.btnCloseSrc.Name = "btnCloseSrc";
            this.btnCloseSrc.Size = new System.Drawing.Size(60, 26);
            this.btnCloseSrc.TabIndex = 2;
            this.btnCloseSrc.Text = "Close";
            this.btnCloseSrc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseSrc.UseVisualStyleBackColor = true;
            this.btnCloseSrc.Click += new System.EventHandler(this.btnCloseSrc_Click);
            // 
            // txtSrcText
            // 
            this.txtSrcText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrcText.Location = new System.Drawing.Point(265, 21);
            this.txtSrcText.Name = "txtSrcText";
            this.txtSrcText.Size = new System.Drawing.Size(420, 23);
            this.txtSrcText.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search By";
            // 
            // cboComId
            // 
            this.cboComId.FormattingEnabled = true;
            this.cboComId.Location = new System.Drawing.Point(611, 48);
            this.cboComId.Name = "cboComId";
            this.cboComId.Size = new System.Drawing.Size(57, 22);
            this.cboComId.TabIndex = 154;
            this.cboComId.Visible = false;
            // 
            // cboAutoNo
            // 
            this.cboAutoNo.FormattingEnabled = true;
            this.cboAutoNo.Location = new System.Drawing.Point(677, 48);
            this.cboAutoNo.Name = "cboAutoNo";
            this.cboAutoNo.Size = new System.Drawing.Size(58, 22);
            this.cboAutoNo.TabIndex = 152;
            this.cboAutoNo.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(508, 52);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 15);
            this.label31.TabIndex = 153;
            this.label31.Text = "ComId && AutoNo";
            this.label31.Visible = false;
            // 
            // BatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.cboComId);
            this.Controls.Add(this.cboAutoNo);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.grpSrc);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cboSLNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRmk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboBType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboBNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboComName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadCombo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLoadGridData);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBatch";
            this.Load += new System.EventHandler(this.frmBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.grpSrc.ResumeLayout(false);
            this.grpSrc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.ComboBox cboSLNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboComName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnLoadGridData;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.GroupBox grpSrc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView GridSrc;
        private System.Windows.Forms.Button btnCloseSrc;
        private System.Windows.Forms.TextBox txtSrcText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboComId;
        private System.Windows.Forms.ComboBox cboAutoNo;
        private System.Windows.Forms.Label label31;
    }
}