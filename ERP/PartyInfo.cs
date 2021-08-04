using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class PartyInfo : Form
    {
        ClsMain SvCls = new ClsMain();

        ClsMain rsi = new ClsMain();
        ClsMain sri = new ClsMain();
        ClsMain msi = new ClsMain();
        ClsMain cId = new ClsMain();
        string qry = "";

        public PartyInfo()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            lblMsg.Text = "Notification...";
            lblMsgIco.Visible = false;
            lblSadIco.Visible = false;
            lblDelIco.Visible = false;
            lblWaitIco.Visible = false;
            lblInfoIco.Visible = true;

            MsgTimer.Enabled = false;
        }

        private void PartyInfo_Load(object sender, EventArgs e)
        {

            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
        

            btnAddNew.Select();
        }

        private void ShowMessage(string type, string msg)
        {
            if (type == "info")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = false;
                lblInfoIco.Visible = true;
                lblMsg.Text = msg;
                this.PanelTop.BackColor = Color.DarkBlue;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "save")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblInfoIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = true;
                lblMsg.Text = "Save Successfully....!";
                this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(73)))));
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "update")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblInfoIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = true;
                lblMsg.Text = "Edit Successfully....!";
                this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(73)))));
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "delete")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblInfoIco.Visible = false;
                lblMsgIco.Visible = false;
                lblWaitIco.Visible = false;
                lblDelIco.Visible = true;
                lblMsg.Text = "Delete Successfully....!";
                this.PanelTop.BackColor = Color.OrangeRed;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "wait")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblInfoIco.Visible = false;
                lblDelIco.Visible = false;
                lblMsgIco.Visible = false;
                lblWaitIco.Visible = true;
                lblMsg.Text = "Please wait, Loading...!";
                this.PanelTop.BackColor = Color.DarkOrange;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "not found")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblInfoIco.Visible = false;
                lblMsgIco.Visible = false;
                lblDelIco.Visible = false;
                lblWaitIco.Visible = false;
                lblSadIco.Visible = true;
                lblMsg.Text = "Sorry..! No Record Found";
                this.PanelTop.BackColor = Color.OrangeRed;
                lblMsg.ForeColor = Color.White;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            string Qry = "Select ComName from Company order by ComName";
            cboSrc.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSrc.DisplayMember = "ComName";
            cboSrc.Text = "";
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SvCls.toGetData("select isnull(max(convert(numeric,PartyCode)),999)+1 as CodeNo from PartyInfo where isnumeric(PartyCode)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboPartyCode.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }

                cboPartyName.Text = "";
                cboProName.Text = "";
                cboAddress.Text = "";
                cboConPerson.Text = "";
                cboClass.Text = "";
                cboDivision.Text = "";
                cboZilla.Text = "";
                cboThana.Text = "";
                cboUneon.Text = "";
                cboGroup.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                cboRegion.Text = "";
                cboZone.Text = "";
                cboArea.Text = "";
                cboDeadNo.Text = "";
                cboTradeLcNo.Text = "";
                cboNidNo.Text = "";
                txtTotalCheque.Text = "";
                cboResponsibility.Text = "";
                cboResMobile.Text = "";
                cboSubResponsibility.Text = "";
                cboMainResponsibility.Text = "";
                txtAcctHead.Text = "";
                txtSmsPhone.Text = "";
                chkSMS.Checked = false;

                cboPartyName.Select();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboPartyCode.Text = "";
            cboPartyName.Text = "";
            cboProName.Text = "";
            cboAddress.Text = "";
            cboConPerson.Text = "";
            cboClass.Text = "";
            cboDivision.Text = "";
            cboZilla.Text = "";
            cboThana.Text = "";
            cboUneon.Text = "";
            cboGroup.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cboRegion.Text = "";
            cboZone.Text = "";
            cboArea.Text = "";
            cboDeadNo.Text = "";
            cboTradeLcNo.Text = "";
            cboNidNo.Text = "";
            txtTotalCheque.Text = "";
            cboResponsibility.Text = "";
            cboResMobile.Text = "";
            cboSubResponsibility.Text = "";
            cboMainResponsibility.Text = "";
            txtAcctHead.Text = "";
            cboComName.Text = "";
            txtSmsPhone.Text = "";
            chkSMS.Checked = false;

            btnLoadGridData_Click(null, null);
        }
        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            qry = "Select ComName from Company ORDER BY ComId";
            cboComName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            qry = "Select PartyCode from PartyInfo order by PartyCode";
            cboPartyCode.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPartyCode.DisplayMember = "PartyCode";
            cboPartyCode.Text = "";

            qry = "Select PartyName from PartyInfo order by PartyName";
            cboPartyName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPartyName.DisplayMember = "PartyName";
            cboPartyName.Text = "";

            qry = "Select ProName from PartyInfo order by ProName";
            cboProName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboProName.DisplayMember = "ProName";
            cboProName.Text = "";

            qry = "Select Address from PartyInfo order by Address";
            cboAddress.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboAddress.DisplayMember = "Address";
            cboAddress.Text = "";

            qry = "Select ContactPerson from PartyInfo order by ContactPerson";
            cboConPerson.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboConPerson.DisplayMember = "ContactPerson";
            cboConPerson.Text = "";

            qry = "Select DISTINCT(Uneon) from PartyInfo order by Uneon";
            cboUneon.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboUneon.DisplayMember = "Uneon";
            cboUneon.Text = "";

            qry = "Select DISTINCT(PGroup) from PartyInfo order by PGroup";
            cboGroup.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboGroup.DisplayMember = "PGroup";
            cboGroup.Text = "";

            qry = "Select DISTINCT(Class) from PartyInfo order by Class";
            cboClass.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboClass.DisplayMember = "Class";
            cboClass.Text = "";

            qry = "Select DISTINCT(Zone) from PartyInfo order by Zone";
            cboZone.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboZone.DisplayMember = "Zone";
            cboZone.Text = "";

            qry = "Select DeedNo from PartyInfo order by DeedNo";
            cboDeadNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboDeadNo.DisplayMember = "DeedNo";
            cboDeadNo.Text = "";

            qry = "Select NIDNo from PartyInfo order by NIDNo";
            cboNidNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboNidNo.DisplayMember = "NIDNo";
            cboNidNo.Text = "";

            qry = "Select TradeLicence from PartyInfo order by TradeLicence";
            cboTradeLcNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboTradeLcNo.DisplayMember = "TradeLicence";
            cboTradeLcNo.Text = "";

            qry = "Select DISTINCT(Region) from PartyInfo order by Region";
            cboRegion.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboRegion.DisplayMember = "Region";
            cboRegion.Text = "";

            qry = "Select DISTINCT(Area) from PartyInfo order by Area";
            cboArea.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboArea.DisplayMember = "Area";
            cboArea.Text = "";

            qry = "Select ResName from ResInfo where ResType = 'Responsibility' order by ResName";
            cboResponsibility.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboResponsibility.DisplayMember = "ResName";
            cboResponsibility.Text = "";

            qry = "Select ResName from ResInfo where ResType = 'Sub Responsibility' order by ResName";
            cboSubResponsibility.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboSubResponsibility.DisplayMember = "ResName";
            cboSubResponsibility.Text = "";

            qry = "Select ResName from ResInfo where ResType = 'Main Responsibility' order by ResName";
            cboMainResponsibility.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboMainResponsibility.DisplayMember = "ResName";
            cboMainResponsibility.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (cboPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Party Code Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPartyCode.Select();
                return;
            }

            if (cboPartyName.Text.Trim() == "")
            {
                MessageBox.Show("Party Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPartyName.Select();
                return;
            }

            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Phone Number Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into PartyInfo (ComId,PartyCode,PartyName,ProName,Address,ContactPerson,Class,Division,Zila,Upazila,Uneon,PGroup,Phone,Email,Region,Zone,Area,DeedNo,TradeLicence,NIDNo,ChequeAmt,SMS,SMSPhone,ResId,ResMob,SubResId,MainResId,HeadID,PcName,UserCode)values" +
                "('" + txtComId.Text.Trim() + "','" + cboPartyCode.Text.Trim() + "','" + cboPartyName.Text.Trim() + "','" + cboProName.Text.Trim() + "','" + cboAddress.Text.Trim() + "','" + cboConPerson.Text.Trim() + "','" + cboClass.Text.Trim() + "','" + cboDivision.Text.Trim() + "','" + cboZilla.Text.Trim() + "','" + cboThana.Text.Trim() + "','" + cboUneon.Text.Trim() + "','" + cboGroup.Text.Trim() + "','" + txtPhone.Text.Trim() + "'," +
                "'" + txtEmail.Text.Trim() + "','" + cboRegion.Text.Trim() + "','" + cboZone.Text.Trim() + "','" + cboArea.Text.Trim() + "','" + cboDeadNo.Text.Trim() + "','" + cboTradeLcNo.Text.Trim() + "','" + cboNidNo.Text.Trim() + "','" + txtTotalCheque.Text.Trim() + "','" + chkSMS.Checked + "','" + txtSmsPhone.Text.Trim() + "','" + txtResId.Text.Trim() + "','" + cboResMobile.Text.Trim() + "','" + txtsubResId.Text.Trim() + "','" + txtMainResId.Text.Trim() + "','" + txtAcctHead.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";

            SelectQry = "Select ComId,PartyName,ProName,Address,ContactPerson,Class,Division,Zila,Upazila,Uneon,PGroup,Phone,Email,Region,Zone,Area,DeedNo,TradeLicence,NIDNo,ChequeAmt,SMS,SMSPhone,ResId,ResMob,SubResId,MainResId,HeadID,PcName,UserCode from PartyInfo where PartyCode='" + cboPartyCode.Text.Trim() + "'";

            EdtQry = "Update PartyInfo set ComId='" + txtComId.Text.Trim() + "',PartyName='" + cboPartyName.Text.Trim() + "',ProName='" + cboProName.Text.Trim() + "',Address='" + cboAddress.Text.Trim() + "',ContactPerson='" + cboConPerson.Text.Trim() + "',Class='" + cboClass.Text.Trim() + "',Division='" + cboDivision.Text.Trim() + "'," +
                "Zila='" + cboZilla.Text.Trim() + "',Upazila='" + cboThana.Text.Trim() + "',Uneon='" + cboUneon.Text.Trim() + "',PGroup='" + cboGroup.Text.Trim() + "',Phone='" + txtPhone.Text.Trim() + "',Email='" + txtEmail.Text.Trim() + "'," +
                "Region='" + cboRegion.Text.Trim() + "',Zone='" + cboZone.Text.Trim() + "',Area='" + cboArea.Text.Trim() + "',DeedNo='" + cboDeadNo.Text.Trim() + "',TradeLicence='" + cboTradeLcNo.Text.Trim() + "',NIDNo='" + cboNidNo.Text.Trim() + "',ChequeAmt='" + txtTotalCheque.Text.Trim() + "',SMS='" + chkSMS.Checked + "',SMSPhone='" + txtSmsPhone.Text.Trim() + "'," +
                "ResId='" + txtResId.Text.Trim() + "',ResMob='" + cboResMobile.Text.Trim() + "',SubResId='" + txtsubResId.Text.Trim() + "',MainResId='" + txtMainResId.Text.Trim() + "',HeadID='" + txtAcctHead.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "' where PartyCode='" + cboPartyCode.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                ShowMessage("save", "");
                btnSave.Text = "Edit";
                btnAddNew.Focus();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
                btnLoadGridData_Click(null, null);
                btnAddNew.Focus();
            }

            btnLoadGridData_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.insertUpdate("Delete from PartyInfo where PartyCode='" + cboPartyCode.Text.Trim() + "' and ComId=1");
                ShowMessage("delete", "");

                btnLoadGridData_Click(null, null);
            }
        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTop_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            //qry = "SELECT P.PartyCode as ID,P.PartyName as [Party Name],C.ComName as[Company],P.ProName as[Proprietor],P.Address,P.ContactPerson as [Contact Person],P.Class,P.Division,P.Zila,P.Upazila,P.Uneon,P.PGroup as[Party Group],P.Phone,P.Email,P.Region,P.Zone,P.Area,P.DeedNo as[Deed No],P.TradeLicence as[Trade Licence],P.NIDNo as[NID],P.ChequeAmt as[Cheque Amt],R.ResName as[Res Name],R.Phone as[Res Mobile],S.ResName as[Sub Responsibility],m.ResName as[Main Responsibility],P.HeadID as[Account Head] FROM PartyInfo P,ResInfo R,SubResInfo S,MainResInfo M,Company C where P.ResId=R.ResId and P.ResId=S.ResId and P.ResId=M.ResId and P.ComId=C.ComId  ORDER BY PartyCode DESC";
            qry = "SELECT AutoNo, PartyCode as ID,PartyName as [Party Name],Phone,Address,Class,Division,Zila,Upazila,Uneon as [Union],PGroup as [Group],Region,Zone,Area FROM PartyInfo ORDER BY PartyCode DESC";
            Grid.DataSource = SvCls.GblDataTable(qry);
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void cboPartyCode_Leave(object sender, EventArgs e)
        {
            if (cboPartyCode.Text.Trim() != "")
            {
                SvCls.toGetData("Select PartyName,ProName,Address,ContactPerson,Class,Division,Zila,Upazila,Uneon,PGroup,Phone,Email,Region,Zone,Area,DeedNo,TradeLicence,NIDNo,ChequeAmt,SMS,SMSPhone,ResMob,ResId,SubResId,MainResId,HeadID,AutoNo,ComId from PartyInfo where PartyCode='" + cboPartyCode.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboPartyName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                    cboProName.Text = SvCls.GblRdrToGetData["ProName"].ToString();
                    cboAddress.Text = SvCls.GblRdrToGetData["Address"].ToString();
                    cboConPerson.Text = SvCls.GblRdrToGetData["ContactPerson"].ToString();
                    cboClass.Text = SvCls.GblRdrToGetData["Class"].ToString();
                    cboDivision.Text = SvCls.GblRdrToGetData["Division"].ToString();
                    cboZilla.Text = SvCls.GblRdrToGetData["Zila"].ToString();
                    cboThana.Text = SvCls.GblRdrToGetData["Upazila"].ToString();
                    cboUneon.Text = SvCls.GblRdrToGetData["Uneon"].ToString();
                    cboGroup.Text = SvCls.GblRdrToGetData["PGroup"].ToString();
                    txtPhone.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                    txtEmail.Text = SvCls.GblRdrToGetData["Email"].ToString();
                    cboRegion.Text = SvCls.GblRdrToGetData["Region"].ToString();
                    cboZone.Text = SvCls.GblRdrToGetData["Zone"].ToString();
                    cboArea.Text = SvCls.GblRdrToGetData["Area"].ToString();
                    cboDeadNo.Text = SvCls.GblRdrToGetData["DeedNo"].ToString();
                    cboTradeLcNo.Text = SvCls.GblRdrToGetData["TradeLicence"].ToString();
                    cboNidNo.Text = SvCls.GblRdrToGetData["NIDNo"].ToString();
                    txtTotalCheque.Text = SvCls.GblRdrToGetData["ChequeAmt"].ToString();                   
                    cboResMobile.Text = SvCls.GblRdrToGetData["ResMob"].ToString();
                    txtResId.Text = SvCls.GblRdrToGetData["ResId"].ToString();
                    txtsubResId.Text = SvCls.GblRdrToGetData["SubResId"].ToString();
                    txtMainResId.Text = SvCls.GblRdrToGetData["MainResId"].ToString();
                    txtAcctHead.Text = SvCls.GblRdrToGetData["HeadID"].ToString();                   
                    txtSmsPhone.Text = SvCls.GblRdrToGetData["SMSPhone"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    txtComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();

                    rsi.toGetData("Select ResName from ResInfo where ResId='" + SvCls.GblRdrToGetData["ResId"].ToString() + "' and ResType = 'Responsibility'");
                    if (rsi.GblRdrToGetData.Read())
                    {
                      cboResponsibility.Text = rsi.GblRdrToGetData["ResName"].ToString();
                    }
                    sri.toGetData("Select ResName from ResInfo where ResId='" + SvCls.GblRdrToGetData["ResId"].ToString() + "' and ResType = 'Sub Responsibility'");
                    if (sri.GblRdrToGetData.Read())
                    {
                        cboSubResponsibility.Text = sri.GblRdrToGetData["ResName"].ToString();
                    }
                    msi.toGetData("Select ResName from ResInfo where ResId='" + SvCls.GblRdrToGetData["ResId"].ToString() + "' and ResType = 'Main Responsibility'");
                    if (msi.GblRdrToGetData.Read())
                    {
                        cboMainResponsibility.Text = msi.GblRdrToGetData["ResName"].ToString();
                    }

                    cId.toGetData("Select ComName from Company where ComId='" + SvCls.GblRdrToGetData["ComId"].ToString() + "'");
                    if (cId.GblRdrToGetData.Read())
                    {
                        cboComName.Text = cId.GblRdrToGetData["ComName"].ToString();
                    }
                    if (SvCls.GblRdrToGetData["SMS"].ToString() == "True")
                    {
                        chkSMS.Checked = true;
                        btnAddNew.Select();
                    }
                    else
                    {
                        chkSMS.Checked = false;
                    }              

                    
                }
                else
                {
                    ShowMessage("not found", "");

                    cboPartyName.Text = "";
                    cboProName.Text = "";
                    cboAddress.Text = "";
                    cboConPerson.Text = "";
                    cboClass.Text = "";
                    cboDivision.Text = "";
                    cboZilla.Text = "";
                    cboThana.Text = "";
                    cboUneon.Text = "";
                    cboGroup.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    cboRegion.Text = "";
                    cboZone.Text = "";
                    cboArea.Text = "";
                    cboDeadNo.Text = "";
                    cboTradeLcNo.Text = "";
                    cboNidNo.Text = "";
                    txtTotalCheque.Text = "";
                    cboResponsibility.Text = "";
                    cboResMobile.Text = "";
                    cboSubResponsibility.Text = "";
                    cboMainResponsibility.Text = "";
                    txtAcctHead.Text = "";
                    cboComName.Text = "";
                    txtSmsPhone.Text = "";
                    chkSMS.Checked = false;
                }              
            }
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked == true)
            {
                txtSmsPhone.Enabled = true;
                txtSmsPhone.Select();
            }
            else { txtSmsPhone.Enabled = false; }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowMessage("info", "This is your information");
        }

        private void PanelTop_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void cboSrc_Leave(object sender, EventArgs e)
        {
            qry = "SELECT P.AutoNo, P.PartyCode as ID,P.PartyName as [Party Name],C.ComName as[Company],P.ProName as[Proprietor],P.Address,P.ContactPerson as [Contact Person],P.Class,P.Division,P.Zila,P.Upazila,P.Uneon,P.PGroup as[Party Group],P.Phone,P.Email,P.Region,P.Zone,P.Area,P.DeedNo as[Deed No],P.TradeLicence as[Trade Licence],P.NIDNo as[NID],P.ChequeAmt as[Cheque Amt],R.ResName as[Res Name],R.Phone as[Res Mobile],S.ResName as[Sub Responsibility],m.ResName as[Main Responsibility],P.HeadID as[Account Head] FROM PartyInfo P,ResInfo R,SubResInfo S,MainResInfo M,Company C where P.ResId=R.ResId and P.ResId=S.ResId and P.ResId=M.ResId and P.ComId=C.ComId  ORDER BY PartyCode DESC";
            GridSrc.DataSource = SvCls.GblDataTable(qry);
            GridSrc.Refresh();

            lblShowTotal.Text = "Total : " + GridSrc.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;

            ShowMessage("wait", "");
        }

        private void cboComName_TextChanged(object sender, EventArgs e)
        {       
        }

        private void cboComName_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select ComId from Company where ComName='" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                txtComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
            }
        }

        private void cboPartyCode_TextChanged(object sender, EventArgs e)
        {      
            
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboPartyCode.Text = Grid.Rows[i].Cells[1].Value.ToString();

            cboPartyCode_Leave(null,null);           
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPartyCode.Select();
            }
        }

        private void cboPartyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPartyName.Select();
            }
        }

        private void cboPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboProName.Select();
            }
        }

        private void cboProName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAddress.Select();
            }
        }

        private void cboAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboConPerson.Select();
            }
        }

        private void cboConPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPhone.Select();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtEmail.Select();
            }
        }

        private void cboDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboZilla.Select();
            }
        }

        private void cboThana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUneon.Select();
            }
        }

        private void cboGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboClass.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDivision.Select();
            }
        }

        private void cboZilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboThana.Select();
            }
        }

        private void cboUnion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboGroup.Select();
            }
        }

        private void cboClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboZone.Select();
            }
        }

        private void cboZone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRegion.Select();
            }
        }

        private void cboDeadNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboArea.Select();
            }
        }

        private void cboNidNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboTradeLcNo.Select();
            }
        }

        private void txtTotalCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAcctHead.Select();
            }
        }

        private void cboRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDeadNo.Select();
            }
        }

        private void cboArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboNidNo.Select();
            }
        }

        private void cboTradeLcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotalCheque.Select();
            }
        }

        private void txtSmsNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAcctHead.Select();
            }
        }

        private void cboAcctHead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboResponsibility.Select();
            }
        }

        private void cboResponsibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboResMobile.Select();
            }
        }

        private void cboResMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSubResponsibility.Select();
            }
        }

        private void cboSubResponsibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMainResponsibility.Select();
            }
        }

        private void cboMainResponsibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar.ToString() == "\r")
            //{
            //    txtMojudAmt.Select();
            //}
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void chkSMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSmsPhone.Select();
            }
        }

        private void cboResponsibility_Leave(object sender, EventArgs e)
        {
            if(cboResponsibility.Text != "")
            {
                SvCls.toGetData("Select ResId, Phone from ResInfo ResId where ResName = '" + cboResponsibility.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtResId.Text = SvCls.GblRdrToGetData["ResId"].ToString();
                    cboResMobile.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                }
                else
                {
                    txtResId.Text = "";
                }
            }
        }

        private void cboSubResponsibility_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select ResId from ResInfo ResId where ResName = '" + cboSubResponsibility.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                txtsubResId.Text = SvCls.GblRdrToGetData["ResId"].ToString();
            }
        }

        private void cboMainResponsibility_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData(" Select ResId from ResInfo ResId where ResName = '" + cboMainResponsibility.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                txtMainResId.Text = SvCls.GblRdrToGetData["ResId"].ToString();
            }
        }
    }
}