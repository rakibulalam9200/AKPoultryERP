namespace ERP
{
    partial class DieselUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieselUsage));
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.cboSlNo = new System.Windows.Forms.ComboBox();
            this.cboComName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTheDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskGenOnTime = new System.Windows.Forms.MaskedTextBox();
            this.mskGenOffTime = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRmk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.grpSrc = new System.Windows.Forms.GroupBox();
            this.GridSrc = new System.Windows.Forms.DataGridView();
            this.btnCloseSrc = new System.Windows.Forms.Button();
            this.txtSrcText = new System.Windows.Forms.TextBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.grpSrc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSrc)).BeginInit();
            this.SuspendLayout();
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
            this.label26.Location = new System.Drawing.Point(987, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Diesel Use...";
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
            // btnLoadCombo
            // 
            this.btnLoadCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCombo.Image")));
            this.btnLoadCombo.Location = new System.Drawing.Point(447, 65);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(33, 28);
            this.btnLoadCombo.TabIndex = 79;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(377, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 28);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(300, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(223, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 76;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(121, 144);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(357, 22);
            this.cboItemGroup.TabIndex = 74;
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(121, 119);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(357, 22);
            this.cboItemName.TabIndex = 73;
            this.cboItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItemName_KeyPress);
            this.cboItemName.Leave += new System.EventHandler(this.cboItemName_Leave);
            // 
            // cboSlNo
            // 
            this.cboSlNo.FormattingEnabled = true;
            this.cboSlNo.Location = new System.Drawing.Point(121, 69);
            this.cboSlNo.Name = "cboSlNo";
            this.cboSlNo.Size = new System.Drawing.Size(98, 22);
            this.cboSlNo.TabIndex = 72;
            this.cboSlNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSlNo_KeyPress);
            // 
            // cboComName
            // 
            this.cboComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComName.FormattingEnabled = true;
            this.cboComName.ItemHeight = 14;
            this.cboComName.Location = new System.Drawing.Point(121, 38);
            this.cboComName.Name = "cboComName";
            this.cboComName.Size = new System.Drawing.Size(357, 22);
            this.cboComName.TabIndex = 71;
            this.cboComName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboComName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 81;
            this.label4.Text = "Item Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 75;
            this.label2.Text = "Serial No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Company Name";
            // 
            // dtpTheDate
            // 
            this.dtpTheDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTheDate.Location = new System.Drawing.Point(121, 94);
            this.dtpTheDate.Name = "dtpTheDate";
            this.dtpTheDate.Size = new System.Drawing.Size(98, 22);
            this.dtpTheDate.TabIndex = 82;
            this.dtpTheDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpTheDate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 83;
            this.label5.Text = "Date";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(121, 169);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(98, 22);
            this.txtQty.TabIndex = 105;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 106;
            this.label11.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 14);
            this.label6.TabIndex = 108;
            this.label6.Text = "Generator On Time";
            // 
            // mskGenOnTime
            // 
            this.mskGenOnTime.Location = new System.Drawing.Point(121, 194);
            this.mskGenOnTime.Mask = "90:00";
            this.mskGenOnTime.Name = "mskGenOnTime";
            this.mskGenOnTime.Size = new System.Drawing.Size(98, 22);
            this.mskGenOnTime.TabIndex = 109;
            this.mskGenOnTime.ValidatingType = typeof(System.DateTime);
            this.mskGenOnTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskGenOnTime_KeyPress);
            // 
            // mskGenOffTime
            // 
            this.mskGenOffTime.Location = new System.Drawing.Point(380, 194);
            this.mskGenOffTime.Mask = "90:00";
            this.mskGenOffTime.Name = "mskGenOffTime";
            this.mskGenOffTime.Size = new System.Drawing.Size(98, 22);
            this.mskGenOffTime.TabIndex = 111;
            this.mskGenOffTime.ValidatingType = typeof(System.DateTime);
            this.mskGenOffTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskGenOffTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 14);
            this.label7.TabIndex = 110;
            this.label7.Text = "Generator Off Time";
            // 
            // cboRmk
            // 
            this.cboRmk.FormattingEnabled = true;
            this.cboRmk.Location = new System.Drawing.Point(121, 219);
            this.cboRmk.Name = "cboRmk";
            this.cboRmk.Size = new System.Drawing.Size(357, 22);
            this.cboRmk.TabIndex = 112;
            this.cboRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRmk_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 113;
            this.label8.Text = "Remarks";
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(327, 256);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(83, 28);
            this.btnLoadGridData.TabIndex = 131;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(263, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(58, 28);
            this.btnExit.TabIndex = 129;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(191, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 128;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(119, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 308);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1076, 330);
            this.Grid.TabIndex = 165;
            // 
            // grpSrc
            // 
            this.grpSrc.Controls.Add(this.GridSrc);
            this.grpSrc.Controls.Add(this.btnCloseSrc);
            this.grpSrc.Controls.Add(this.txtSrcText);
            this.grpSrc.Location = new System.Drawing.Point(6, 569);
            this.grpSrc.Name = "grpSrc";
            this.grpSrc.Size = new System.Drawing.Size(1089, 67);
            this.grpSrc.TabIndex = 203;
            this.grpSrc.TabStop = false;
            this.grpSrc.Text = "Search Party Information";
            this.grpSrc.Visible = false;
            // 
            // GridSrc
            // 
            this.GridSrc.AllowUserToAddRows = false;
            this.GridSrc.AllowUserToDeleteRows = false;
            this.GridSrc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridSrc.BackgroundColor = System.Drawing.Color.White;
            this.GridSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSrc.Location = new System.Drawing.Point(12, 55);
            this.GridSrc.Name = "GridSrc";
            this.GridSrc.ReadOnly = true;
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
            this.txtSrcText.Location = new System.Drawing.Point(27, 21);
            this.txtSrcText.Name = "txtSrcText";
            this.txtSrcText.Size = new System.Drawing.Size(658, 23);
            this.txtSrcText.TabIndex = 1;
            this.txtSrcText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrcText_KeyDown);
            this.txtSrcText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrcText_KeyPress);
            this.txtSrcText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrcText_KeyUp);
            // 
            // DieselUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.grpSrc);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnLoadGridData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRmk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskGenOffTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskGenOnTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTheDate);
            this.Controls.Add(this.btnLoadCombo);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSlNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboComName);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DieselUsage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DieselUsage";
            this.Load += new System.EventHandler(this.DieselUsage_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.grpSrc.ResumeLayout(false);
            this.grpSrc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.ComboBox cboSlNo;
        private System.Windows.Forms.ComboBox cboComName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTheDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskGenOnTime;
        private System.Windows.Forms.MaskedTextBox mskGenOffTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRmk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadGridData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox grpSrc;
        private System.Windows.Forms.DataGridView GridSrc;
        private System.Windows.Forms.Button btnCloseSrc;
        private System.Windows.Forms.TextBox txtSrcText;
    }
}