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
    public partial class CreateBankAc : Form
    {

        ClsMain SvCls = new ClsMain();
        string qry = "";

        public CreateBankAc()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void CreateBankAc_Load(object sender, EventArgs e)
        {
            btnLoadCombo_Click(null,null);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboAcName.Text.Trim() == "")
            {
                MessageBox.Show("Account Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboAcName.Select();
                return;
            }

            if (cboAcNo.Text.Trim() == "")
            {
                MessageBox.Show("Select Account No", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboAcNo.Select();
                return;
            }
            if (cboAcPerson.Text.Trim() == "")
            {
                MessageBox.Show("Account Person Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboAcPerson.Select();
                return;
            }

            if (cboBankName.Text.Trim() == "")
            {
                MessageBox.Show("Bank Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBankName.Select();
                return;
            }

            if (cboBranchName.Text.Trim() == "")
            {
                MessageBox.Show("Brach Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBranchName.Select();
                return;
            }     
            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into BankAcInfo(BankID,HeadID,AcName,AcNo,AcPerson,BankName,Branch,BCode,BRoutNo,BAddress,BPhone,BEmail,PcName,UserCode)values('" + cboBankId.Text.Trim() + "','" + cboHeadName.Text.Trim() + "','" + cboAcName.Text.Trim() + "','" + cboAcNo.Text.Trim() + "','" + cboAcPerson.Text.Trim() + "','" + cboBankName.Text.Trim() + "','" + cboBranchName.Text.Trim() + "','" + cboBankCode.Text.Trim() + "','" + cboRoutingNo.Text.Trim() + "','" + cboAddress.Text.Trim() + "','" + cboPhone.Text.Trim() + "','" + cboEmail.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";

            SelectQry = "Select HeadID,AcName,AcNo,AcPerson,BankName,Branch,BCode,BRoutNo,BAddress,BPhone,BEmail,PcName,UserCode from BankAcInfo where BankID='" + cboBankId.Text.Trim() + "'";

            EdtQry = "Update BankAcInfo set HeadID='" + cboHeadName.Text.Trim() + "',AcName='" + cboAcName.Text.Trim() + "',AcNo='" + cboAcNo.Text.Trim() + "',AcPerson='" + cboAcPerson.Text.Trim() + "',BankName='" + cboBankName.Text.Trim() + "',Branch='" + cboBranchName.Text.Trim() + "',BCode='" + cboBankCode.Text.Trim() + "',BRoutNo='" + cboRoutingNo.Text.Trim() + "',BAddress='" + cboAddress.Text.Trim() + "',BPhone='" + cboPhone.Text.Trim() + "',BEmail='" + cboEmail.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "' where BankID='" + cboBankId.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                ShowMessage("save", "");
                btnLoadGridData_Click(null, null);
                btnAddNew.Focus();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
                btnLoadGridData_Click(null, null);
                btnAddNew.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboBankId.Text.Trim() == "")
            {
                MessageBox.Show("Plese select Bank ID", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBankId.Select();
                return;
            }
            {
                if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SvCls.insertUpdate("Delete from BankAcInfo where BankID='" + cboBankId.Text.Trim() + "'");
                    ShowMessage("delete", "");
                    btnLoadGridData_Click(null, null);
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SvCls.toGetData("select isnull(max(convert(numeric,BankID)),1000)+1 as CodeNo from BankAcInfo where isnumeric(BankID)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboBankId.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }

                cboAcName.Text = "";
                cboAcNo.Text = "";
                cboAcPerson.Text = "";
                cboAddress.Text = "";
                cboBankCode.Text = "";
                cboBankName.Text = "";
                cboPhone.Text = "";
                cboEmail.Text = "";               
                cboBranchName.Text = "";
                cboHeadName.Text = "";
                txtAutonNo.Text = "";
                cboRoutingNo.Text = "";

                cboAcName.Select();
                btnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            qry = "Select AutoNo as[Auto No],BankID as[ID],HeadID as[Head ID],AcName as[Ac Name],AcNo as[Account No],AcPerson as[Peerson],BankName as[Bank Name],Branch,BCode as[Branch Code],BRoutNo as[Route No],BAddress as[Address],BPhone as[Phone],BEmail as[Email] from BankAcInfo";
            Grid.DataSource = SvCls.GblDataTable(qry);
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void cboBankId_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select AutoNo,HeadID,AcName,AcNo,AcPerson,BankName,Branch,BCode,BRoutNo,BAddress,BPhone,BEmail from BankAcInfo where BankID='" + cboBankId.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                txtAutonNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                cboHeadName.Text = SvCls.GblRdrToGetData["HeadID"].ToString();
                cboAcName.Text = SvCls.GblRdrToGetData["AcName"].ToString();
                cboAcNo.Text = SvCls.GblRdrToGetData["AcNo"].ToString();
                cboAcPerson.Text = SvCls.GblRdrToGetData["AcPerson"].ToString();
                cboBankName.Text = SvCls.GblRdrToGetData["BankName"].ToString();
                cboBranchName.Text = SvCls.GblRdrToGetData["Branch"].ToString();
                cboBankCode.Text = SvCls.GblRdrToGetData["BCode"].ToString();
                cboRoutingNo.Text = SvCls.GblRdrToGetData["BRoutNo"].ToString();
                cboAddress.Text = SvCls.GblRdrToGetData["BAddress"].ToString();
                cboPhone.Text = SvCls.GblRdrToGetData["BPhone"].ToString();
                cboEmail.Text = SvCls.GblRdrToGetData["BEmail"].ToString();
                btnSave.Text = "Edit";
            }
            else
            {
                cboAcName.Text = "";
                cboAcNo.Text = "";
                cboAcPerson.Text = "";
                cboAddress.Text = "";
                cboBankCode.Text = "";
                cboBankName.Text = "";
                cboPhone.Text = "";
                cboEmail.Text = "";
                cboBranchName.Text = "";
                cboRoutingNo.Text = "";
                cboHeadName.Text = "";
                txtAutonNo.Text = "";

                btnSave.Text = "Save";
                ShowMessage("not found", "");
            }
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            qry = "Select BankID from BankAcInfo";
            cboBankId.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboBankId.DisplayMember = "BankID";
            cboBankId.Text = "";

            qry = "select headid from bankacinfo order by headid";
            cboHeadName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboHeadName.DisplayMember = "headid";
            cboHeadName.Text = "";

            qry = "select acname from bankacinfo order by acname";
            cboAcName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboAcName.DisplayMember = "acname";
            cboAcName.Text = "";

            qry = "select acno from bankacinfo order by acno";
            cboAcNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboAcNo.DisplayMember = "acno";
            cboAcNo.Text = "";

            qry = "select acperson from bankacinfo order by acperson";
            cboAcPerson.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboAcPerson.DisplayMember = "acperson";
            cboAcPerson.Text = "";

            qry = "select acperson from bankacinfo order by acperson";
            CboRptAcPerson.DataSource = SvCls.GblDataSet(qry).Tables[0];
            CboRptAcPerson.DisplayMember = "acperson";
            CboRptAcPerson.Text = "";

            qry = "select bankname from bankacinfo order by bankname";
            cboBankName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboBankName.DisplayMember = "bankname";
            cboBankName.Text = "";

            qry = "select bankname from bankacinfo order by bankname";
            CboRptBName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            CboRptBName.DisplayMember = "bankname";
            CboRptBName.Text = "";

            qry = "select branch from bankacinfo order by branch";
            cboBranchName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboBranchName.DisplayMember = "branch";
            cboBranchName.Text = "";

            qry = "select branch from bankacinfo order by branch";
            CboRptBranch.DataSource = SvCls.GblDataSet(qry).Tables[0];
            CboRptBranch.DisplayMember = "branch";
            CboRptBranch.Text = "";

            qry = "select bcode from bankacinfo order by bcode";
            cboBankCode.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboBankCode.DisplayMember = "bcode";
            cboBankCode.Text = "";

            qry = "select broutno from bankacinfo order by broutno";
            cboRoutingNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboRoutingNo.DisplayMember = "broutno";
            cboRoutingNo.Text = "";

            qry = "select baddress from bankacinfo order by baddress";
            cboAddress.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboAddress.DisplayMember = "baddress";
            cboAddress.Text = "";

            qry = "select bphone from bankacinfo order by bphone";
            cboPhone.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPhone.DisplayMember = "bphone";
            cboPhone.Text = "";

            qry = "select bemail from bankacinfo order by bemail";
            cboEmail.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboEmail.DisplayMember = "bemail";
            cboEmail.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboBankId.Text = "";
            cboAcName.Text = "";
            cboAcNo.Text = "";
            cboAcPerson.Text = "";
            cboAddress.Text = "";
            cboBankCode.Text = "";
            cboBankName.Text = "";
            cboPhone.Text = "";
            cboEmail.Text = "";
            cboRoutingNo.Text = "";
            CboRptAcPerson.Text = "";
            CboRptBranch.Text = "";
            cboBranchName.Text = "";
            cboHeadName.Text = "";
            txtAutonNo.Text = "";

            btnSave.Text = "Save";

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboBankId.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboBankId_Leave(null, null);

            btnSave.Text = "Edit";
        }

        private void cboBankId_LocationChanged(object sender, EventArgs e)
        {

        }

        private void cboAcName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAcNo.Select();
            }
        }

        private void cboAcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAcPerson.Select();
            }
        }

        private void cboAcPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboHeadName.Select();
            }
        }

        private void cboHeadName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBankName.Select();
            }
        }

        private void cboBankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBankCode.Select();
            }
        }

        private void cboBankCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBranchName.Select();
            }
        }

        private void cboBranchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRoutingNo.Select();
            }
        }

        private void cboRoutingNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPhone.Select();
            }
        }

        private void cboPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboEmail.Select();
            }
        }

        private void cboEmail_KeyPress(object sender, KeyPressEventArgs e)
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
                btnSave.Select();
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
