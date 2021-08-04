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
    public partial class PartyCreditInfo : Form
    {
        ClsMain SvCls = new ClsMain();
        string qry = "";

        public PartyCreditInfo()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (txtCredit.Text.Trim() == "")
            {
                MessageBox.Show("Credit Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCredit.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into CreditInfo(ComId,PartyCode,CreditLimit,PcName,UserCode,SlNo)values('" + CboComId.Text.Trim() + "','" + cboPartyCode.Text.Trim() + "'," + txtCredit.Text.Trim() + ",'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "','" + CboSlNo.Text.Trim() + "')";

            SelectQry = "Select ComId,PartyCode,CreditLimit,PcName,UserCode from CreditInfo where SlNo='" + CboSlNo.Text.Trim() + "'";

            EdtQry = "Update CreditInfo set ComId='" + CboComId.Text.Trim() + "',PartyCode='" + cboPartyCode.Text.Trim() + "',CreditLimit=" + txtCredit.Text.Trim() + ",PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "' where SlNo='" + CboSlNo.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                ShowMessage("save", "");
                GridHeading();
                btnAddNew.Focus();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
                GridHeading();
                btnAddNew.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Valid Partry Code...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPartyCode.Select();
                return;
            }
            string Qry;            
            Qry = "Delete from CreditInfo where PartyCode='" + cboPartyCode.Text.Trim() + "' and AutoNo='" + cboAutoNo.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    ShowMessage("delete", "");

                    btnAddNew.Select();
                }

                else
                {
                    ShowMessage("not found", "");
                }

                cboPartyCode.Select();
                btnLoadGridData_Click(null, null);

            }
            ShowMessage("delete","");
        }

        private void cboPartyCode_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("select Cr.AutoNo,cr.ComId,CR.SlNo,p.PartyName, cast(CreditLimit as int)as CreditLimit,C.ComName from CreditInfo CR,PartyInfo P,Company C where Cr.PartyCode=p.PartyCode and cr.ComId=c.ComId and P.PartyCode='" + cboPartyCode.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                cboPartyName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                CboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
                CboSlNo.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                txtCredit.Text = SvCls.GblRdrToGetData["CreditLimit"].ToString();
                cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                btnSave.Text = "Edit";
            }
            else 
            {
                ShowMessage("not found", "");
                cboPartyName.Text = "";
                CboSlNo.Text = "";
                cboComName.Text = "";
                txtCredit.Text = "";

                btnSave.Text = "Save";
            }          
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            qry = "Select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            qry = "Select PartyName from PartyInfo order by PartyName";
            cboPartyName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPartyName.DisplayMember = "PartyName";
            cboPartyName.Text = "";

            qry = "Select PartyCode from PartyInfo order by PartyCode";
            cboPartyCode.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPartyCode.DisplayMember = "PartyCode";
            cboPartyCode.Text = "";

            qry = "Select PGroup from PartyInfo order by PGroup";
            cboRptGroup.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboRptGroup.DisplayMember = "PGroup";
            cboRptGroup.Text = "";

            qry = "Select ResName from ResInfo order by ResName";
            cboRptRes.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboRptRes.DisplayMember = "ResName";
            cboRptRes.Text = "";

            qry = "Select ComName from Company order by ComName";
            cboRptCompany.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboRptCompany.DisplayMember = "ComName";
            cboRptCompany.Text = "";

            ShowMessage("wait","");
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

        private void PartyCreditInfo_Load(object sender, EventArgs e)
        {
            cboPartyCode.Select();
            btnLoadCombo_Click(null,null);
            GridHeading();
        }

        private void GridHeading()
        {
            qry = "select Cr.AutoNo,CR.SlNo,P.PartyCode as [Party ID],p.PartyName as [Party Name], p.Address as [Party Address], p.Phone as Phone, cast(CreditLimit as int) as Limit, C.ComName as [Company] from CreditInfo CR,PartyInfo P,Company C where Cr.PartyCode=p.PartyCode and cr.ComId=c.ComId ORDER BY cr.EntryTime DESC";
            Grid.DataSource = SvCls.GblDataTable(qry);
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
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
                this.PanelTop.BackColor = this.PanelTop.BackColor = Color.DarkBlue;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            ShowMessage("info","This is your information");
        }

        private void cboComName_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                CboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
            }
        }

        private void grpCreditInfo_Enter(object sender, EventArgs e)
        {
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPartyCode.Text.Trim() == "")
                {
                    MessageBox.Show("Please Select Party Code.....", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboPartyCode.Select();
                    return;
                }

                if (cboPartyName.Text.Trim() == "")
                {
                    MessageBox.Show("Please Select Party Name.....", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboPartyName.Select();
                    return;
                }

                SvCls.toGetData("select isnull(max(convert(numeric,SlNo)),1000)+1 as CodeNo from CreditInfo where isnumeric(SlNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboSlNo.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }
                cboComName.Text = "";
                txtCredit.Text = "";

                cboComName.Select();
                btnSave.Text = "Save";

                //GridHeading();
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
            cboComName.Text = "";
            txtCredit.Text = "";
            CboSlNo.Text = "";
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            GridHeading();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboPartyCode.Text = Grid.Rows[i].Cells[2].Value.ToString();
            cboPartyCode_Leave(null, null);

            btnSave.Text = "Edit";
        }

        private void cboPartyCode_KeyUp(object sender, KeyEventArgs e)
        {
         
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
                btnAddNew.Select();
            }
        }

        private void btnAddNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboComName.Select();
            }
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtCredit.Select();
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }
    }
}
