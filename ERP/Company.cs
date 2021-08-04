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
    public partial class Company : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string Qry;
        string checkqry;
        string EdtQry;
        public Company()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            btnLoadGridData_Click(null, null);
            btnLoadCombo_Click(null,null);
            btnAddNew.Select();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,ComId)),0)+1 as ComID from Company where ISNUMERIC(comID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboComID.Text = SvCls.GblRdrToGetData["ComID"].ToString();
                SvCls.GblCon.Close();
            }

            cboComName.Text = "";
            cboBranchCode.Text = "";
            cboPrefix.Text = "";
            cboRptHead.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cboBranchCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComID.Text = "";
            cboComName.Text = "";
            cboBranchCode.Text = "";
            cboPrefix.Text = "";
            cboRptHead.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cboComID.Select();
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select distinct comID from Company";
            cboComID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComID.DisplayMember = "comID";
            cboComID.Text = "";

            Qry = "select distinct ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select distinct BranchCode from Company";
            cboBranchCode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBranchCode.DisplayMember = "BranchCode";
            cboBranchCode.Text = "";

            Qry = "select distinct Prefix from Company where Prefix != ''";
            cboPrefix.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboPrefix.DisplayMember = "Prefix";
            cboPrefix.Text = "";

            Qry = "select distinct RptHead from Company where RptHead != ''";
            cboRptHead.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboRptHead.DisplayMember = "RptHead";
            cboRptHead.Text = "";

            Qry = "select  AutoNO from Company";
            cboAutoNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboAutoNo.DisplayMember = "AutoNO";
            cboAutoNo.Text = "";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboComID.Text.Trim() == "")
            {
                MessageBox.Show("Company ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboComID.Select();
                return;
            }

            if (cboBranchCode.Text.Trim() == "")
            {
                MessageBox.Show("Branch Code Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBranchCode.Select();
                return;
            }

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboComName.Select();
                return;
            }

            SvCls.toGetData("select comName from Company where comName = '" + cboComName.Text.Trim() + "' and ComId <> '"+ cboComID.Text.Trim() +"'");
            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Company Name  Can't Be Duplicate", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            SvCls.toGetData("select branchcode from Company where BranchCode = '" + cboBranchCode.Text.Trim() + "' and BranchCode <> '" + cboBranchCode.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Branch Code Can't Be Duplicate", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBranchCode.Select();
            }

            Qry = "insert Company(ComID, BranchCode, Prefix, ComName,ComAddress,ComPhone,email,RptHead,PcName,UserCode) values ('"+cboComID.Text.Trim()+"','"+cboBranchCode.Text.Trim()+ "','" + cboPrefix.Text.Trim() + "','" + cboComName.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + cboRptHead.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select BranchCode, Prefix, ComName,ComAddress,ComPhone,email,RptHead,PcName,UserCode from Company where ComID = '"+cboComID.Text.Trim()+"'";
            EdtQry = "update Company set BranchCode = '" + cboBranchCode.Text.Trim() + "', Prefix = '" + cboPrefix.Text.Trim() + "',ComName =  '" + cboComName.Text.Trim() + "', ComAddress = '" + txtAddress.Text.Trim() + "',ComPhone = '" + txtPhone.Text.Trim() + "',email = '" + txtEmail.Text.Trim() + "',RptHead = '" + cboRptHead.Text.Trim() + "',PcName = '" +ClsVar.GblPcName+ "',UserCode = '" + ClsVar.GblUserId + "' where ComId = '"+cboComID.Text.Trim()+"'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("save", "");    

            }
            btnLoadGridData_Click(null, null);
            
            btnAddNew.Focus();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboComID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Valid Compnay ID...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboComID.Select();
                return;
            }
            checkqry = "select * from Company where ComID = '" + cboComID.Text.Trim() + "'";
            Qry = "delete from Company where ComID = '" + cboComID.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("delete", "");
                }
               
                else
                {
                    ShowMessage("not found", "");
                }

                btnAddNew.Select();
                btnLoadGridData_Click(null, null);
                
            }
        }

        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select  ComID as 'Company ID', BranchCode as 'Branch Code',Prefix, ComName as 'Company Name',ComAddress as 'Address',ComPhone as 'Phone',email as 'Email',RptHead as 'Report Head' from Company");
            Grid.Refresh();
            lblShowTotal_TextChanged(null, null);
        }

        private void cboComID_Leave(object sender, EventArgs e)
        {
            if (cboComID.Text.Trim() != "")
            {

                Qry = "select ComID,BranchCode, Prefix, ComName,ComAddress,ComPhone,email,RptHead from Company where ComID = '" + cboComID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboComID.Text = SvCls.GblRdrToGetData["ComID"].ToString();
                    cboBranchCode.Text = SvCls.GblRdrToGetData["BranchCode"].ToString();
                    cboPrefix.Text = SvCls.GblRdrToGetData["Prefix"].ToString();
                    cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                    txtAddress.Text = SvCls.GblRdrToGetData["ComAddress"].ToString();
                    txtPhone.Text = SvCls.GblRdrToGetData["ComPhone"].ToString();
                    txtEmail.Text = SvCls.GblRdrToGetData["email"].ToString();
                    cboRptHead.Text = SvCls.GblRdrToGetData["RptHead"].ToString();
                    cboBranchCode.Focus();
                }
                else
                {
                    ShowMessage("not found", "");

                    cboComName.Text = "";
                    cboBranchCode.Text = "";
                    cboPrefix.Text = "";
                    cboRptHead.Text = "";
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    cboBranchCode.Select();

                }
               
            }
        }

        private void lblShowTotal_TextChanged(object sender, EventArgs e)
        {
            Qry = "select count(ComID) as ComID from Company ";
            SvCls.toGetData(Qry);
            string lblMsg = "Total Record: ";

            if (SvCls.GblRdrToGetData.Read())
            {

                lblShowTotal.Text = lblMsg + SvCls.GblRdrToGetData["ComID"].ToString();
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid_Head();
            lblShowTotal_TextChanged(null, null);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboComID.Text = Grid.Rows[i].Cells[0].Value.ToString();
            cboBranchCode.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboPrefix.Text = Grid.Rows[i].Cells[2].Value.ToString();
            cboComName.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = Grid.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = Grid.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = Grid.Rows[i].Cells[6].Value.ToString();
            cboRptHead.Text = Grid.Rows[i].Cells[7].Value.ToString();
            cboComID.Focus();
        }



        private void cboComID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBranchCode.Select();
            }
        }

        private void cboBranchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPrefix.Select();
            }
        }

        private void cboPrefix_KeyPress(object sender, KeyPressEventArgs e)
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
                txtAddress.Select();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
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


        private void cboRptHead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRptHead.Select();
            }
        }

        
    }
}
