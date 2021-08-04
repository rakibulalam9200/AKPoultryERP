namespace ERP
{
    partial class CreateBankAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBankAc));
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLoadCombo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cboAcPerson = new System.Windows.Forms.ComboBox();
            this.cboAcNo = new System.Windows.Forms.ComboBox();
            this.cboAcName = new System.Windows.Forms.ComboBox();
            this.cboBankId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBankInfo = new System.Windows.Forms.GroupBox();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.cboRoutingNo = new System.Windows.Forms.ComboBox();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.cboBankCode = new System.Windows.Forms.ComboBox();
            this.cboBankName = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBranchName = new System.Windows.Forms.ComboBox();
            this.btnLoadGridData = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboHeadName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CboRptBName = new System.Windows.Forms.ComboBox();
            this.CboRptBranch = new System.Windows.Forms.ComboBox();
            this.CboRptAcPerson = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.txtAutonNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBankInfo.SuspendLayout();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
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
            this.btnLoadCombo.Location = new System.Drawing.Point(438, 35);
            this.btnLoadCombo.Name = "btnLoadCombo";
            this.btnLoadCombo.Size = new System.Drawing.Size(33, 28);
            this.btnLoadCombo.TabIndex = 17;
            this.btnLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCombo.UseVisualStyleBackColor = true;
            this.btnLoadCombo.Click += new System.EventHandler(this.btnLoadCombo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(368, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(291, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(214, 35);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cboAcPerson
            // 
            this.cboAcPerson.FormattingEnabled = true;
            this.cboAcPerson.Location = new System.Drawing.Point(114, 118);
            this.cboAcPerson.Name = "cboAcPerson";
            this.cboAcPerson.Size = new System.Drawing.Size(357, 22);
            this.cboAcPerson.TabIndex = 3;
            this.cboAcPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAcPerson_KeyPress);
            // 
            // cboAcNo
            // 
            this.cboAcNo.FormattingEnabled = true;
            this.cboAcNo.Location = new System.Drawing.Point(114, 93);
            this.cboAcNo.Name = "cboAcNo";
            this.cboAcNo.Size = new System.Drawing.Size(357, 22);
            this.cboAcNo.TabIndex = 2;
            this.cboAcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAcNo_KeyPress);
            // 
            // cboAcName
            // 
            this.cboAcName.FormattingEnabled = true;
            this.cboAcName.Location = new System.Drawing.Point(114, 68);
            this.cboAcName.Name = "cboAcName";
            this.cboAcName.Size = new System.Drawing.Size(357, 22);
            this.cboAcName.TabIndex = 1;
            this.cboAcName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAcName_KeyPress);
            // 
            // cboBankId
            // 
            this.cboBankId.FormattingEnabled = true;
            this.cboBankId.Location = new System.Drawing.Point(114, 39);
            this.cboBankId.Name = "cboBankId";
            this.cboBankId.Size = new System.Drawing.Size(98, 22);
            this.cboBankId.TabIndex = 0;
            this.cboBankId.LocationChanged += new System.EventHandler(this.cboBankId_LocationChanged);
            this.cboBankId.Leave += new System.EventHandler(this.cboBankId_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "Account Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 60;
            this.label3.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "Bank ID";
            // 
            // grpBankInfo
            // 
            this.grpBankInfo.Controls.Add(this.cboAddress);
            this.grpBankInfo.Controls.Add(this.label6);
            this.grpBankInfo.Controls.Add(this.cboEmail);
            this.grpBankInfo.Controls.Add(this.cboRoutingNo);
            this.grpBankInfo.Controls.Add(this.cboPhone);
            this.grpBankInfo.Controls.Add(this.cboBankCode);
            this.grpBankInfo.Controls.Add(this.cboBankName);
            this.grpBankInfo.Controls.Add(this.label22);
            this.grpBankInfo.Controls.Add(this.label21);
            this.grpBankInfo.Controls.Add(this.label19);
            this.grpBankInfo.Controls.Add(this.label20);
            this.grpBankInfo.Location = new System.Drawing.Point(12, 171);
            this.grpBankInfo.Name = "grpBankInfo";
            this.grpBankInfo.Size = new System.Drawing.Size(468, 154);
            this.grpBankInfo.TabIndex = 5;
            this.grpBankInfo.TabStop = false;
            this.grpBankInfo.Text = "Bank Information";
            // 
            // cboAddress
            // 
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.Location = new System.Drawing.Point(102, 121);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(357, 22);
            this.cboAddress.TabIndex = 12;
            this.cboAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAddress_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 59;
            this.label6.Text = "Address";
            // 
            // cboEmail
            // 
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Location = new System.Drawing.Point(258, 96);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(201, 22);
            this.cboEmail.TabIndex = 11;
            this.cboEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEmail_KeyPress);
            // 
            // cboRoutingNo
            // 
            this.cboRoutingNo.FormattingEnabled = true;
            this.cboRoutingNo.Location = new System.Drawing.Point(102, 71);
            this.cboRoutingNo.Name = "cboRoutingNo";
            this.cboRoutingNo.Size = new System.Drawing.Size(357, 22);
            this.cboRoutingNo.TabIndex = 9;
            this.cboRoutingNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRoutingNo_KeyPress);
            // 
            // cboPhone
            // 
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Location = new System.Drawing.Point(102, 96);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(150, 22);
            this.cboPhone.TabIndex = 10;
            this.cboPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPhone_KeyPress);
            // 
            // cboBankCode
            // 
            this.cboBankCode.FormattingEnabled = true;
            this.cboBankCode.Location = new System.Drawing.Point(102, 46);
            this.cboBankCode.Name = "cboBankCode";
            this.cboBankCode.Size = new System.Drawing.Size(71, 22);
            this.cboBankCode.TabIndex = 7;
            this.cboBankCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBankCode_KeyPress);
            // 
            // cboBankName
            // 
            this.cboBankName.DropDownWidth = 500;
            this.cboBankName.FormattingEnabled = true;
            this.cboBankName.Items.AddRange(new object[] {
            "Sonali Bank Limited",
            "Janata Bank Limited",
            "Agrani Bank Limited",
            "Rupali Bank Limited",
            "BASIC Bank Limited",
            "Bangladesh Development Bank",
            "Bangladesh Krishi Bank",
            "Rajshahi Krishi Unnayan Bank",
            "Probashi Kollyan Bank",
            "AB Bank Limited",
            "Bangladesh Commerce Bank Limited",
            "Bank Asia Limited",
            "BRAC Bank Limited",
            "Citizens Bank PLC",
            "City Bank Limited",
            "Community Bank Bangladesh Limited",
            "Dhaka Bank Limited",
            "Dutch-Bangla Bank Limited",
            "Eastern Bank Limited",
            "IFIC Bank Limited",
            "Jamuna Bank Limited",
            "Meghna Bank Limited",
            "Mercantile Bank Limited",
            "Midland Bank Limited",
            "Modhumoti Bank Limited",
            "Mutual Trust Bank Limited",
            "National Bank Limited",
            "National Credit & Commerce Bank Limited",
            "NRB Bank Limited",
            "NRB Commercial Bank Ltd",
            "One Bank Limited",
            "Padma Bank Limited",
            "Premier Bank Limited",
            "Prime Bank Limited",
            "Pubali Bank Limited",
            "Shimanto Bank Ltd",
            "Southeast Bank Limited",
            "South Bangla Agriculture and Commerce Bank Limited",
            "Trust Bank Limited",
            "United Commercial Bank Ltd",
            "Uttara Bank Limited",
            "Bengal Commercial Bank Ltd",
            "Al-Arafah Islami Bank Limited",
            "EXIM Bank Limited",
            "First Security Islami Bank Limited",
            "ICB Islamic Bank Limited",
            "Islami Bank Bangladesh Limited",
            "Shahjalal Islami Bank Limited",
            "Social Islami Bank Limited",
            "Union Bank Ltd",
            "Standard Bank Limited",
            "Global Islamic Bank Ltd (former NRB Global Bank)",
            "Bank Al-Falah Limited (United Arab Emirates)",
            "Citibank N.A (United States of America)",
            "Commercial Bank of Ceylon PLC (Sri Lanka)",
            "Habib Bank Limited (Pakistan)",
            "HSBC (Hong Kong)",
            "National Bank of Pakistan (Pakistan)",
            "Standard Chartered Bank (United Kingdom)",
            "State Bank of India (India)",
            "Woori Bank (South Korea)",
            "Ansar VDP Unnayan Bank",
            "Karmashangosthan Bank",
            "Grameen Bank",
            "Jubilee Bank",
            "Palli Sanchay Bank",
            "Agrani SME Financing Company Limited",
            "Bangladesh Finance and Investment Company Limited (BD Finance)",
            "Bangladesh Industrial Finance Company Limited (BIFC)",
            "Bangladesh Infrastructure Finance Fund Limited (BIFFL)",
            "Bay Leasing & Investment Limited",
            "CVC Finance Limited",
            "Delta Brac Housing Finance Corporation Ltd. (DBH)",
            "Fareast Finance & Investment Limited",
            "FAS Finance & Investment Limited",
            "First Finance Limited",
            "GSP Finance Company (Bangladesh) Limited (GSPB)",
            "Hajj Finance Company Limited",
            "IDLC Finance Limited",
            "Industrial and Infrastructure Development Finance Company Limited (IIDFC)",
            "Infrastructure Development Company Limited (IDCOL)",
            "International Leasing and Financial Services Limited",
            "IPDC Finance Limited",
            "Islamic Finance and Investment Limited",
            "LankaBangla Finance Limited",
            "Lankan Alliance Finance Limited",
            "Meridian Finance and Investment Ltd.",
            "MIDAS Financing Limited. (MFL)",
            "National Finance Ltd",
            "National Housing Finance and Investments Limited",
            "People\'s Leasing and Financial Services Ltd",
            "Phoenix Finance and Investments Limited",
            "Premier Leasing & Finance Limited",
            "Prime Finance & Investment Ltd",
            "Reliance Finance Limited",
            "Saudi-Bangladesh Industrial and Agricultural Investment Company Limited (SABINCO)" +
                "",
            "The UAE-Bangladesh Investment Co. Ltd",
            "Union Capital Limited",
            "United Finance Limited",
            "Uttara Finance and Investments Limited"});
            this.cboBankName.Location = new System.Drawing.Point(102, 21);
            this.cboBankName.Name = "cboBankName";
            this.cboBankName.Size = new System.Drawing.Size(357, 22);
            this.cboBankName.TabIndex = 6;
            this.cboBankName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBankName_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 14);
            this.label22.TabIndex = 21;
            this.label22.Text = "Bank Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 14);
            this.label21.TabIndex = 22;
            this.label21.Text = "Branch Code";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 14);
            this.label19.TabIndex = 24;
            this.label19.Text = "Phone && Email";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 14);
            this.label20.TabIndex = 23;
            this.label20.Text = "Routing No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name";
            // 
            // cboBranchName
            // 
            this.cboBranchName.FormattingEnabled = true;
            this.cboBranchName.Location = new System.Drawing.Point(270, 216);
            this.cboBranchName.Name = "cboBranchName";
            this.cboBranchName.Size = new System.Drawing.Size(201, 22);
            this.cboBranchName.TabIndex = 8;
            this.cboBranchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBranchName_KeyPress);
            // 
            // btnLoadGridData
            // 
            this.btnLoadGridData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGridData.Image")));
            this.btnLoadGridData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGridData.Location = new System.Drawing.Point(394, 330);
            this.btnLoadGridData.Name = "btnLoadGridData";
            this.btnLoadGridData.Size = new System.Drawing.Size(86, 28);
            this.btnLoadGridData.TabIndex = 22;
            this.btnLoadGridData.Text = "Load Data";
            this.btnLoadGridData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadGridData.UseVisualStyleBackColor = true;
            this.btnLoadGridData.Click += new System.EventHandler(this.btnLoadGridData_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(324, 330);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(69, 28);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(260, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Size = new System.Drawing.Size(58, 28);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(188, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(114, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboHeadName
            // 
            this.cboHeadName.FormattingEnabled = true;
            this.cboHeadName.Location = new System.Drawing.Point(114, 143);
            this.cboHeadName.Name = "cboHeadName";
            this.cboHeadName.Size = new System.Drawing.Size(357, 22);
            this.cboHeadName.TabIndex = 4;
            this.cboHeadName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboHeadName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 77;
            this.label7.Text = "Head Name";
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.button1);
            this.grpReport.Controls.Add(this.CboRptBName);
            this.grpReport.Controls.Add(this.CboRptBranch);
            this.grpReport.Controls.Add(this.CboRptAcPerson);
            this.grpReport.Controls.Add(this.label9);
            this.grpReport.Controls.Add(this.label11);
            this.grpReport.Controls.Add(this.label12);
            this.grpReport.Location = new System.Drawing.Point(620, 35);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(468, 136);
            this.grpReport.TabIndex = 12;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(102, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Print Preview";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CboRptBName
            // 
            this.CboRptBName.FormattingEnabled = true;
            this.CboRptBName.Location = new System.Drawing.Point(102, 46);
            this.CboRptBName.Name = "CboRptBName";
            this.CboRptBName.Size = new System.Drawing.Size(357, 22);
            this.CboRptBName.TabIndex = 15;
            // 
            // CboRptBranch
            // 
            this.CboRptBranch.FormattingEnabled = true;
            this.CboRptBranch.Location = new System.Drawing.Point(102, 71);
            this.CboRptBranch.Name = "CboRptBranch";
            this.CboRptBranch.Size = new System.Drawing.Size(173, 22);
            this.CboRptBranch.TabIndex = 16;
            // 
            // CboRptAcPerson
            // 
            this.CboRptAcPerson.FormattingEnabled = true;
            this.CboRptAcPerson.Location = new System.Drawing.Point(102, 21);
            this.CboRptAcPerson.Name = "CboRptAcPerson";
            this.CboRptAcPerson.Size = new System.Drawing.Size(357, 22);
            this.CboRptAcPerson.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "Account Person";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "Branch Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Bank Name";
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 373);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1076, 265);
            this.Grid.TabIndex = 23;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(933, 347);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 23);
            this.lblShowTotal.TabIndex = 81;
            this.lblShowTotal.Text = "Total Record : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PanelTop.TabIndex = 82;
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
            this.label26.Location = new System.Drawing.Point(870, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(230, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Bank Account Information...";
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
            // txtAutonNo
            // 
            this.txtAutonNo.Location = new System.Drawing.Point(532, 36);
            this.txtAutonNo.Name = "txtAutonNo";
            this.txtAutonNo.Size = new System.Drawing.Size(37, 22);
            this.txtAutonNo.TabIndex = 87;
            this.txtAutonNo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 86;
            this.label10.Text = "Auto No";
            this.label10.Visible = false;
            // 
            // CreateBankAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.txtAutonNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.cboHeadName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLoadGridData);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboBranchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBankInfo);
            this.Controls.Add(this.btnLoadCombo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cboAcPerson);
            this.Controls.Add(this.cboAcNo);
            this.Controls.Add(this.cboAcName);
            this.Controls.Add(this.cboBankId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateBankAc";
            this.Text = "CreateBankAc";
            this.Load += new System.EventHandler(this.CreateBankAc_Load);
            this.grpBankInfo.ResumeLayout(false);
            this.grpBankInfo.PerformLayout();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.Button btnLoadCombo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cboAcPerson;
        private System.Windows.Forms.ComboBox cboAcNo;
        private System.Windows.Forms.ComboBox cboAcName;
        private System.Windows.Forms.ComboBox cboBankId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBankInfo;
        private System.Windows.Forms.ComboBox cboRoutingNo;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.ComboBox cboBankCode;
        private System.Windows.Forms.ComboBox cboBankName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.ComboBox cboBranchName;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadGridData;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboHeadName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.ComboBox CboRptBName;
        private System.Windows.Forms.ComboBox CboRptBranch;
        private System.Windows.Forms.ComboBox CboRptAcPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.TextBox txtAutonNo;
        private System.Windows.Forms.Label label10;
    }
}