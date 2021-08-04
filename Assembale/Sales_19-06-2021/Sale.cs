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
    public partial class Sale : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        //string PartyCode = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        string chkSearch = "";
        double total = 0.0D;
        string LocID = "";
        double GrandTotal = 0.0D;
        double Payable = 0.0;
        //double Paid = 0.0;
        Int32 SaleMstrAutoNo = 0;
        Int32 ISBAutoNo = 0;
        Int32 ESBAutoNo = 0;

        public Sale()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
            grpSrc.Visible = false;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboSID.Text = "";
            dtpSDate.Text = DateTime.Today.ToString();
            cboCName.Text = "";
            cboCID.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            cboIName.Text = "";
            cboIGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            cboIUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGTotal.Text = "";
            cboISBType.Text = "";
            cboESBType.Text = "";
            cboISBNo.Text = "";
            cboESBNo.Text = "";
            btnAddItem.Enabled = false;
            cboESBNo.Enabled = false;
            cboISBNo.Enabled = false;
            lblShowInfo.Text = "INFO";
            btnLoadGridData_Click(null, null);
            btnAddNew.Select();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Qry = "delete from SaleMstr where PartyCode = '' and TotalAmt = 0.00 and PcName = '" + ClsVar.GblPcName + "'";
            SvCls.insertUpdate(Qry);

            checkqry = "select SID from SaleMstr where PartyCode != '' and TotalAmt  != 0.00 and PcName = '" + ClsVar.GblPcName + "'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {

            }
            else
            {
                Qry = "delete from Sale where SID = '" + cboSID.Text.Trim() + "' and PcName = '" + ClsVar.GblPcName + "'";
                SvCls.insertUpdate(Qry);
            }

            SvCls.toGetData("select isnull(max(convert(numeric,SID)),1000)+1 as SID from SaleMstr");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSID.Text = SvCls.GblRdrToGetData["SID"].ToString();
                SvCls.GblCon.Close();
            }

            if (cboComName.Text.Trim() != "")
            {
                SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Company Name");
                    cboComName.Select();
                    return;
                }
            }

            Qry = "insert SaleMstr(ComId,SID,SDate,PcName,UserCode) values ('" + ComID + "','" + cboSID.Text.Trim() + "',CONVERT(datetime,'" + dtpSDate.Text.Trim() + "',103),'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            SvCls.insertUpdate(Qry);

            dtpSDate.Text = DateTime.Today.ToString();
            cboCName.Text = "";
            cboCID.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            cboIName.Text = "";
            cboIGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            cboIUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGTotal.Text = "";
            cboISBNo.Text = "";
            cboESBNo.Text = "";
            cboISBType.Text = "";
            cboESBType.Text = "";
            dtpSDate.Select();
            btnAddItem.Enabled = false;
            cboESBNo.Enabled = false;
            cboISBNo.Enabled = false;
            lblShowInfo.Text = "INFO";
            btnLoadGridData_Click(null, null);
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select s.AutoNo,s.SlNo as 'Serial',s.ItemCode as 'Item Code',ItemName as 'Item Name',cast(Qty as decimal(10,2)) as Quantity, cast(s.UPrice as decimal(10,2)) as 'Unit Price', cast(Total as decimal(10,2)) as 'Total Price' from Sale as s,ItemInfo as i where i.ItemCode = s.ItemCode and SID ='"+cboSID.Text.Trim()+"'");
            Grid.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select SID from SaleMstr";
            cboSID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSID.DisplayMember = "SID";
            cboSID.Text = "";

            Qry = "select WhsName from whs";
            cboILoc.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboILoc.DisplayMember = "WhsName";
            cboILoc.Text = "";

            Qry = "select itemcode from itemInfo";
            cboICode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboICode.DisplayMember = "itemcode";
            cboICode.Text = "";

            Qry = "select ShortName from ItemInfo";
            cboISName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboISName.DisplayMember = "ShortName";
            cboISName.Text = "";

            Qry = "select VNo from VehicleInfo";
            cboVNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboVNo.DisplayMember = "VNo";
            cboVNo.Text = "";

            Qry = "select PartyCode,PartyName from PartyInfo where PGroup = 'Customer'";
            cboCID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCID.DisplayMember = "partyCode";
            cboCID.Text = "";

            cboCName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCName.DisplayMember = "partyName";
            cboCName.Text = "";

            Qry = "select VNo from VehicleInfo";
            cboVNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboVNo.DisplayMember = "VNo";
            cboVNo.Text = "";

            Qry = "select distinct BType from BatchInfo";
            cboISBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboISBType.DisplayMember = "BType";
            cboISBType.Text = "";

            

            Qry = "select distinct BType from BatchInfo";
            cboESBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboESBType.DisplayMember = "BType";
            cboESBType.Text = "";


        }

        private void cboCID_Leave(object sender, EventArgs e)
        {
            if (cboCID.Text.Trim() != "")
            {
                Qry = "select PartyName,ProName,Phone from PartyInfo where partycode = '" + cboCID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    btnAddItem.Enabled = true;
                    cboCName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                    lblShowInfo.Text = "ProName: " + SvCls.GblRdrToGetData["ProName"].ToString() + " // Mobile: " + SvCls.GblRdrToGetData["Phone"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Customer ID");
                    cboCName.Text = "";
                    lblShowInfo.Text = "INFO";
                }
            }
        }

        private void cboCName_Leave(object sender, EventArgs e)
        {
            if (cboCName.Text.Trim() != "")
            {
                Qry = "select PartyCode,ProName,Phone from PartyInfo where PartyName = '" + cboCName.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboCID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                    lblShowInfo.Text = "ProName: " + SvCls.GblRdrToGetData["ProName"].ToString() + " // Mobile: " + SvCls.GblRdrToGetData["Phone"].ToString();

                }
                else
                {
                    ShowMessage("info", "Invalid Customer Name");
                    cboSID.Text = "";
                }
            }
        }

        private void cboICode_Leave(object sender, EventArgs e)
        {
            if (cboICode.Text.Trim() != "")
            {
                Qry = "select ShortName,itemName,IGroup,Unit,cast(BagSize as decimal(10,2)) as BagSize from ItemInfo where itemCode = '" + cboICode.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboISName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                    cboIName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                    cboIGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    cboIUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }

                else
                {
                    ShowMessage("info", "Item Information Not Found!!!");
                    cboISName.Text = "";
                    cboIName.Text  = "";
                    cboIGroup.Text = "";
                    cboIUnit.Text  = "";
                }
            }
        }

        private void cboVNo_Leave(object sender, EventArgs e)
        {
            if (cboVNo.Text.Trim() != "")
            {
                Qry = "select Vtype,DrvEmpID,e.EmpName as 'DName',e.Phone as 'Phone' from VehicleInfo as v,Employee as e where e.EmpID = v.DrvEmpID and VNo =  '" + cboVNo.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboVType.Text = SvCls.GblRdrToGetData["Vtype"].ToString();
                    cboDName.Text = SvCls.GblRdrToGetData["DName"].ToString();
                    cboMobile.Text = SvCls.GblRdrToGetData["Phone"].ToString();


                }

                else
                {
                    ShowMessage("info", "The Vechile Info Not Found!!!");
                    cboVType.Text = "";
                    cboDName.Text = "";
                    cboMobile.Text = "";

                }
            }
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void dtpSDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboCID.Select();
            }
        }

        private void cboCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboCName.Select();
            }
        }

        private void cboCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddItem.Select();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SlNo)),0)+1 as SlNo from Sale where SID = '" + cboSID.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSNo.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                SvCls.GblCon.Close();
            }
            cboICode.Select();
            
        }

        private void cboSNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboICode.Select();
            }
        }

        private void cboICode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboISName.Select();
            }
        }

        private void cboILoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtQty.Select();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUPrice.Select();
            }
        }

        private void txtUPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
               cboRmk.Select();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRmk.Select();
            }
        }

        private void cboRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void cboISBType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cboISBType.Text !="")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    cboISBNo.Select();
                }
            }
            else
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    cboESBType.Select();
                }
            }
            
        }

        private void cboISBNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboESBType.Select();
            }
        }

        private void cboESBType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboESBType.Text != "")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    cboESBNo.Select();
                }
            }
            else
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    cboVNo.Select();
                }
            }
            
        }

        private void cboESBNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVNo.Select();
            }
        }

        private void cboVNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVType.Select();
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnPostAcc.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Sale ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSID.Select();
                return;
            }

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (cboSNo.Text.Trim() == "")
            {
                MessageBox.Show("Item Serial No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSNo.Select();
                return;
            }
            if (cboICode.Text.Trim() == "")
            {
                MessageBox.Show("Item Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboICode.Select();
                return;
            }          

            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Quantity Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Select();
                return;
            }

            if (txtUPrice.Text.Trim() == "")
            {
                MessageBox.Show("Unit Price Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUPrice.Select();
                return;
            }

            if (cboComName.Text.Trim() != "")
            {
                SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Company Name");
                    cboComName.Select();
                    return;
                }
            }

            if (cboILoc.Text.Trim() != "")
            {
                SvCls.toGetData("select WhsId from whs where WhsName = '" + cboILoc.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    LocID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Location!!!");
                    cboComName.Select();
                    return;
                }
            }

            if (cboSID.Text.Trim() != "")
            {
                SvCls.toGetData("select AutoNo from Sale where SID = '" + cboSID.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    SaleMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }
            }

            Qry = "insert Sale(ComId,SID,SlNo,ItemCode,LocID,qty,UPrice,Total,rmk,AutoNoFormMstrTbl,PcName,UserCode) values ('" + ComID + "','" + cboSID.Text.Trim() + "','" + cboSNo.Text.Trim() + "','" + cboICode.Text.Trim() + "','" + LocID + "'," + txtQty.Text.Trim() + "," + txtUPrice.Text.Trim() + "," + txtTotal.Text.Trim() + ",'" + cboRmk.Text.Trim() + "'," + SaleMstrAutoNo + ",'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select SlNo,ItemCode from Sale where SID = '" + cboSID.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
            EdtQry = "update Sale set ComId = '" + ComID + "',ItemCode = '" + cboICode.Text.Trim() + "',LocID = '" + LocID + "',qty = " + txtQty.Text.Trim() + ",UPrice = " + txtUPrice.Text.Trim() + ",Total = " + txtTotal.Text.Trim() + ",rmk = '" + cboRmk.Text.Trim() + "',AutoNoFormMstrTbl = " + SaleMstrAutoNo + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where PurchaseCode = '" + cboSID.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                checkqry = "select ItemCode from Sale where SID = '" + cboSID.Text.Trim() + "' and ItemCode = '" + cboICode.Text.Trim() + "'";
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ShowMessage("info", "ItemCode Cann't be duplicate in a Purchase!!!");
                }
                else
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("save", "");
                }

            }

            Qry = "select Cast(sum(Total) as decimal(10,2)) as 'GrandTotal' from Sale where SID = '" + cboSID.Text.Trim() + "'";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                txtGTotal.Text = SvCls.GblRdrToGetData["GrandTotal"].ToString();
                GrandTotal = Convert.ToDouble(SvCls.GblRdrToGetData["GrandTotal"].ToString());

            }

            btnAddItem.Select();
            btnLoadGridData_Click(null, null);
        }

        private void cboISBType_Leave(object sender, EventArgs e)
        {
            if(cboISBType.Text != "")
            {
                checkqry = "Select BType from BatchInfo where BType = '"+cboISBType.Text.Trim()+"'";
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboISBNo.Enabled = true;
                    Qry = "select BatchId from BatchInfo where BType = '" + cboISBType.Text.Trim() + "'";
                    cboISBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                    cboISBNo.DisplayMember = "BatchId";
                    cboISBNo.Text = "";
                }
                else
                {
                    ShowMessage("info", "Invalid Item Sale For Batch Type...");
                    cboISBType.Select();
                    return;
                }
            }
            
            
        }

        private void cboESBType_Leave(object sender, EventArgs e)
        {
            if (cboESBType.Text != "")
            {
                checkqry = "select BType from BatchInfo where BType = '"+cboESBType.Text.Trim()+"'";
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboESBNo.Enabled = true;
                    Qry = "select BatchId from BatchInfo where BType = '" + cboESBType.Text.Trim() + "'";
                    cboESBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                    cboESBNo.DisplayMember = "BatchId";
                    cboESBNo.Text = "";
                }
                else
                {
                    ShowMessage("info", "Invalid Egg Sale From Batch Type...");
                    cboESBType.Select();
                    return;
                }
            }

        }

        private void totalCal()
        {
            if (txtQty.Text == "" && txtUPrice.Text == "")
            {
                total = 0.0D;
            }

            if (txtQty.Text == "" && txtUPrice.Text != "")
            {
                total = 0.0D;
            }

            if (txtQty.Text != "" && txtUPrice.Text == "")
            {
                total = 0.0D;
            }

            if (txtQty.Text != "" && txtUPrice.Text != "")
            {
                total = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtUPrice.Text);
            }
            if (total != 0)
            {
                txtTotal.Text = total.ToString("#.00");
            }
            else
            {
                txtTotal.Text = total.ToString();
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            totalCal();
        }

        private void txtUPrice_KeyUp(object sender, KeyEventArgs e)
        {
            totalCal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Sale ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSID.Select();
                return;
            }

            if (cboSNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Serial No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSNo.Select();
                return;
            }


            checkqry = "select Qty,ItemCode from Sale where SID = '" + cboSID.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
            Qry = "delete from Sale where SID = '" + cboSID.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
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

                btnAddItem.Select();
                btnLoadGridData_Click(null, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboISName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboILoc.Select();
            }
        }

        private void btnAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                cboISBType.Select();
            }
            if (e.KeyCode == Keys.F4)
            {
                txtCash.Focus();
            }
        }

        private void cboSNo_Leave(object sender, EventArgs e)
        {
            if (cboSNo.Text.Trim() != "")
            {
                Qry = "select ItemCode,LocID,cast(Qty as decimal(10,2)) as Qty,cast(UPrice as decimal(10,2)) as UPrice,cast(Total as decimal(10,2)) as Total,rmk from Sale where SlNo = '"+cboSNo.Text.Trim()+"' and SID = '"+cboSID.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboICode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    LocID = SvCls.GblRdrToGetData["LocID"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["Qty"].ToString();
                    txtUPrice.Text = SvCls.GblRdrToGetData["UPrice"].ToString();
                    txtTotal.Text = SvCls.GblRdrToGetData["Total"].ToString();
                    cboRmk.Text = SvCls.GblRdrToGetData["rmk"].ToString();

                    Qry = "select WhsName from whs where WhsId = '" + LocID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboILoc.Text = SvCls.GblRdrToGetData["WhsName"].ToString();
                    }

                    else
                    {
                        cboILoc.Text = "";
                    }
                    Qry = "select ShortName,itemName,IGroup,Unit,cast(BagSize as decimal(10,2)) as BagSize from ItemInfo where itemCode = '" + cboICode.Text.Trim() + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboISName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                        cboIName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                        cboIGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                        cboIUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    }
                }

                else
                {
                    ShowMessage("not found", "");
                    cboICode.Text = "";
                    cboISName.Text = "";
                    cboIName.Text = "";
                    cboIUnit.Text = "";
                    cboIGroup.Text = "";
                    cboILoc.Text = "";
                    txtQty.Text = "";
                    txtTotal.Text = "";
                    txtUPrice.Text = "";
                    cboRmk.Text = "";

                }
            }
        }

        private void cboSID_Leave(object sender, EventArgs e)
        {
             if (cboSID.Text.Trim() != "")
             {
                 Qry = "select SlNo from Sale where SID = '" + cboSID.Text.Trim() + "' ";
                 SvCls.toGetData(Qry);
                 if (SvCls.GblRdrToGetData.Read())
                 {
                     cboSNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                     cboSNo.DisplayMember = "SlNo";
                     cboSNo.Text = "";
                 }

                 Qry = "select AutoNo,ComID,SDate,PartyCode,ISBAutoNo,ESBAutoNo,VNo,VType,DriverName,VDM,cast(payable as decimal(10,2)) as payable,cast(paid as decimal(10,2)) as paid,cast(totalamt as decimal(10,2)) as totalamt from SaleMstr where SID = '" + cboSID.Text.Trim() + "' and partyCode != ''";
                 SvCls.toGetData(Qry);
                 if (SvCls.GblRdrToGetData.Read())
                 {
                     ComID = SvCls.GblRdrToGetData["ComID"].ToString();
                     dtpSDate.Text = SvCls.GblRdrToGetData["SDate"].ToString();
                     cboCID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                     cboVNo.Text = SvCls.GblRdrToGetData["VNo"].ToString();
                     txtDue.Text = SvCls.GblRdrToGetData["payable"].ToString();
                     txtCash.Text = SvCls.GblRdrToGetData["paid"].ToString();
                     txtGTotal.Text = SvCls.GblRdrToGetData["totalamt"].ToString();
                     cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                     txtComId.Text = SvCls.GblRdrToGetData["ComID"].ToString();
                     cboVType.Text = SvCls.GblRdrToGetData["VType"].ToString();
                     cboMobile.Text = SvCls.GblRdrToGetData["VDM"].ToString();
                     cboDName.Text = SvCls.GblRdrToGetData["DriverName"].ToString();
                     ISBAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["ISBAutoNo"].ToString());
                     ESBAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["ESBAutoNo"].ToString());

                    Qry = "select ComName from Company where ComId = '" + ComID + "'";
                     SvCls.toGetData(Qry);
                     if (SvCls.GblRdrToGetData.Read())
                     {
                         cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                     }
                     else
                     {
                         cboComName.Text = "";
                     }

                     Qry = "select PartyName,ProName,Phone from PartyInfo where partycode = '" + cboCID.Text.Trim() + "'";
                     SvCls.toGetData(Qry);
                     if (SvCls.GblRdrToGetData.Read())
                     {
                         cboCName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                         lblShowInfo.Text = "ProName: " + SvCls.GblRdrToGetData["ProName"].ToString() + " // Mobile: " + SvCls.GblRdrToGetData["Phone"].ToString();
                     }
                     else
                     {
                        
                         cboCName.Text = "";
                         lblShowInfo.Text = "INFO";
                     }


                    Qry = "select BType,BatchID from BatchInfo where AutoNo = "+ISBAutoNo+"";
                    SvCls.toGetData(Qry);
                    if(SvCls.GblRdrToGetData.Read())
                    {
                       cboISBType.Text= SvCls.GblRdrToGetData["BType"].ToString();
                       cboISBNo.Text = SvCls.GblRdrToGetData["BatchID"].ToString();
                    }
                    else
                    {
                        cboISBType.Text = "";
                        cboISBNo.Text = "";
                    }

                    Qry = "select BType,BatchID from BatchInfo where AutoNo = " + ESBAutoNo + "";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboESBType.Text = SvCls.GblRdrToGetData["BType"].ToString();
                        cboESBNo.Text = SvCls.GblRdrToGetData["BatchID"].ToString();
                    }
                    else
                    {
                        cboESBType.Text = "";
                        cboESBNo.Text = "";
                    }

                }

                 else
                 {
                     SaleNotFound();
                 }

                 btnLoadGridData_Click(null, null);
             }
        }

        private void SaleNotFound()
        {
            ShowMessage("info", "Sale ID not found!!!");
            cboComName.Text = "";

            dtpSDate.Text = DateTime.Today.ToString();
            cboCName.Text = "";
            cboCID.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            cboIName.Text = "";
            cboIGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            cboIUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGTotal.Text = "";
            cboISBType.Text = "";
            cboESBType.Text = "";
            cboISBNo.Text = "";
            cboESBNo.Text = "";
            lblShowInfo.Text = "INFO";

           // dtpSDate.Select();
        }

        private void cboCID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchParty_Click(null, null);
            }
        }

        private void cboCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchParty_Click(null, null);
            }
        }

        private void btnSearchParty_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode as 'Customer Code',PartyName as 'Customer Name',Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Customer')");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkSearch = "Customer";
            txtSrcText.Select();
        }

        private void cboSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                dtpSDate.Select();
            }
        }

        private void cboISName_Leave(object sender, EventArgs e)
        {
            if (cboISName.Text.Trim() != "")
            {
                Qry = "select itemCode,itemName,IGroup,Unit,cast(BagSize as decimal(10,2)) as BagSize from ItemInfo where ShortName = '" + cboISName.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboICode.Text = SvCls.GblRdrToGetData["itemCode"].ToString();
                    cboIName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                    cboIGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    cboIUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }
                else
                {
                    ShowMessage("info", "Item Information Not Found!!!");
                    cboICode.Text = "";
                    cboIName.Text = "";
                    cboIGroup.Text = "";
                    cboIUnit.Text = "";

                }

            }
        }

        private void cboICode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchItem_Click(null, null);
            }
        }

        private void cboISName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchItem_Click(null, null);
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select AutoNo,ItemCode as 'ItemCode', ItemName as 'ItemName',ShortName as 'Item Short Name',IGroup as 'Item group', unit as 'Unit', cast(BagSize as decimal(10,2)) as 'Bag Size'  from ItemInfo");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkSearch = "Item";
            txtSrcText.Select();
        }

        private void cboVType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDName.Select();
            }
        }

        private void cboDName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMobile.Select();
            }
        }

        private void cboMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtCash.Select();
            }
        }

        private void cboVNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSrcVehicle_Click(null, null);
            }
        }


        private void grandTotalCal()
        {
            //txtGrandTotal.Text = GrandTotal.ToString();

            if (txtCash.Text == "")
            {
                txtCash.Text = 0.ToString();
            }
            if (txtGTotal.Text == "" && txtCash.Text == "")
            {
                Payable = 0.0D;
            }

            if (txtGTotal.Text == "" && txtCash.Text != "")
            {
                Payable = 0.0D;
            }

            if (txtGTotal.Text != "" && txtCash.Text == "")
            {
                Payable = Convert.ToDouble(txtGTotal.Text);
            }


            else if (txtGTotal.Text != "" && txtCash.Text != "")
            {
                Payable = Convert.ToDouble(txtGTotal.Text) - Convert.ToDouble(txtCash.Text);
            }

            if (Payable != 0)
            {
                txtDue.Text = Payable.ToString("#.00");
            }
            else
            {
                txtDue.Text = Payable.ToString();
            }
        }
        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            grandTotalCal();
        }

        private void txtGTotal_KeyUp(object sender, KeyEventArgs e)
        {
            grandTotalCal();
        }

        private void btnPostAcc_Click(object sender, EventArgs e)
        {
            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Sales ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSID.Select();
                return;
            }

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (cboCID.Text.Trim() == "")
            {
                MessageBox.Show("Customer ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCID.Select();
                return;
            }
            if (txtDue.Text.Trim() == "")
            {
                txtDue.Text = 0.ToString();
            }
            if (txtCash.Text.Trim() == "")
            {
                txtCash.Text = 0.ToString();
            }
            if (txtGTotal.Text.Trim() == "")
            {
                txtGTotal.Text = 0.ToString();
            }

            if (txtGTotal.Text.Trim() == "0")
            {
                MessageBox.Show("Please, Add Item...", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddItem.Select();
                return;
            }

            if (cboComName.Text.Trim() != "")
            {
                SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Company Name");
                    cboComName.Select();
                    return;
                }
            }
            
            if(cboISBType.Text.Trim() == "" || cboISBNo.Text.Trim() == "")
            {
                ShowMessage("info", "Invalid Item Sale For Batch Type/Batch No");
                cboISBType.Select();
            }

            if(cboISBType.Text.Trim() != "" && cboISBNo.Text.Trim() != "")
            {
               
                    SvCls.toGetData("select autoNo  from batchinfo where btype = '"+cboISBType.Text.Trim()+"' and batchid = '"+cboISBNo.Text.Trim()+"'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        ISBAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["autoNo"].ToString());
                    }
                    else
                    {
                        ShowMessage("info", "Invalid Item Sale For Batch Type/Batch No");
                        cboISBType.Select();
                    }
                
            }

            if (cboESBType.Text.Trim() != "" && cboESBNo.Text.Trim() != "")
            {

                SvCls.toGetData("select autoNo  from batchinfo where btype = '" + cboESBType.Text.Trim() + "' and batchid = '" + cboESBNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ESBAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["autoNo"].ToString());
                }
                else
                {
                    ShowMessage("info", "Invalid Egg Sale From Batch Type/Batch No");
                    cboESBType.Select();
                }

            }


            if (Convert.ToDouble(txtGTotal.Text) < Convert.ToDouble(txtCash.Text))
            {
                MessageBox.Show("Cash Amount Cann't be Bigger than Grand Total...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCash.Select();
                return;
            }

            checkqry = "select SID,Autono from SaleMstr where PartyCode != '' and AcPost = 'Posted' and SID = '" + cboSID.Text.Trim() + "'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                EdtQry = "update SaleMstr set ComId = '" + ComID + "',SDate = Convert(datetime,'" + dtpSDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',ISBAutoNo = "+ISBAutoNo+",ESBAutoNo = "+ESBAutoNo+",VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',paid = " + txtCash.Text.Trim() + ",Payable = " + txtDue.Text.Trim() + ",TotalAmt = " + txtGTotal.Text.Trim() + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "',AcPost = 'Posted' where SID = '" + cboSID.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
            }

            else
            {
                EdtQry = "update SaleMstr set ComId = '" + ComID + "',SDate = Convert(datetime,'" + dtpSDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',ISBAutoNo = " + ISBAutoNo + ",ESBAutoNo = " + ESBAutoNo + ",VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',paid = " + txtCash.Text.Trim() + ",Payable = " + txtDue.Text.Trim() + ",TotalAmt = " + txtGTotal.Text.Trim() + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "',AcPost = 'Posted' where SID = '" + cboSID.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("save", "");
            }

            cboComName.Select();
        }

        private void cboISBNo_Leave(object sender, EventArgs e)
        {
            if (cboISBType.Text.Trim() != "" && cboISBNo.Text.Trim() != "")
            {

                SvCls.toGetData("select autoNo  from batchinfo where btype = '" + cboISBType.Text.Trim() + "' and batchid = '" + cboISBNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    
                }
                else
                {
                    ShowMessage("info", "Invalid Item Sale For Batch No");
                    cboISBNo.Select();
                }

            }
        }

        private void cboESBNo_Leave(object sender, EventArgs e)
        {
            if (cboESBType.Text.Trim() != "" && cboESBNo.Text.Trim() != "")
            {

                SvCls.toGetData("select autoNo  from batchinfo where btype = '" + cboESBType.Text.Trim() + "' and batchid = '" + cboESBNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    
                }
                else
                {
                    ShowMessage("info", "Invalid Egg Sale From Batch No");
                    cboESBNo.Select();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select sm.AutoNo, SID as 'Sale ID',PartyName as 'Customer Name',sm.partyCode as 'Customer Code',cast(TotalAmt as decimal(10,2)) as 'Total Amount',cast(Paid as decimal(10,2)) as Paid,cast(Payable as decimal(10,2)) as Payable,VNo as 'Vechicle No' from SaleMstr as sm, PartyInfo as p where p.PartyCode = sm.PartyCode");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkSearch = "Sale";
            txtSrcText.Select();
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Sale ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSID.Select();
                return;
            }

            checkqry = "select SDate,VNo,PartyCode from SaleMstr where SID = '" + cboSID.Text.Trim() + "' and AcPost = 'Posted'";
            Qry = "delete from SaleMstr where SID = '" + cboSID.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("delete", "");
                    Qry = "delete from Sale where SID = '" + cboSID.Text.Trim() + "'";
                    SvCls.insertUpdate(Qry);
                }

                else
                {
                    ShowMessage("not found", "");
                }

                cboComName.Select();
                btnLoadGridData_Click(null, null);
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboSNo.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboSNo_Leave(null, null);
            cboSNo.Focus();
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void btnSrcVehicle_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select v.AutoNo, VNO as 'Vechile No', Vtype as 'Vechile Type', EmpName as 'Driver Name',Phone as 'Phone',vrmk as 'Vechicle Remarks' from VehicleInfo as v, Employee as e where v.DrvEmpID = e.EmpID");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkSearch = "Vehicle";
            txtSrcText.Select();
        }

        private void txtSrcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSrcText.Text == "")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    grpSrc.Visible = false;

                    if (chkSearch == "Sale")
                    {
                        cboSID.Select();
                    }

                    if (chkSearch == "Item")
                    {
                        cboICode.Select();
                    }

                    if (chkSearch == "Vehicle")
                    {
                        cboVNo.Select();
                    }

                    if (chkSearch == "Customer")
                    {
                        cboSID.Select();
                    }
                }
            }
        }

        private void txtSrcText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                GridSrc.Focus();
            }
        }

        private void txtSrcText_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSrcText.Text.Trim() != "")
            {
                if (chkSearch == "Sale")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("Select sm.AutoNo, SID as 'Sale ID', PartyName as 'Customer Name', sm.partyCode as 'Customer Code', cast(TotalAmt as decimal(10, 2)) as 'Total Amount', cast(Paid as decimal(10, 2)) as Paid, cast(Payable as decimal(10, 2)) as Payable, VNo as 'Vechicle No' from SaleMstr as sm, PartyInfo as p where p.PartyCode = sm.PartyCode and(SID LIKE '%" + txtSrcText.Text.Trim() + "%' or PartyName LIKE '%" + txtSrcText.Text.Trim() + "%' or sm.PartyCode LIKE '%" + txtSrcText.Text.Trim() + "%')");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (chkSearch == "Item")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select AutoNo, ItemCode as 'ItemCode', ItemName as 'ItemName',ShortName as 'Item Short Name',IGroup as 'Item group', unit as 'Unit', cast(BagSize as decimal(10,2)) as 'Bag Size'  from ItemInfo where ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ShortName LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemName LIKE '%" + txtSrcText.Text.Trim() + "%' or IGroup LIKE '%" + txtSrcText.Text.Trim() + "%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (chkSearch == "Customer")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode,PartyName,Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Customer') and PartyName Like '%" + txtSrcText.Text.Trim() + "%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (chkSearch == "Vehicle")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select v.AutoNo, VNO as 'Vechicle No', Vtype as 'Vehicle Type', EmpName as 'Driver Name',Phone as 'Phone',vrmk as 'Vehicle Remarks' from VehicleInfo as v, Employee as e where v.DrvEmpID = e.EmpID and (VNO Like '%" + txtSrcText.Text.Trim() + "%' or EmpName like '%" + txtSrcText.Text.Trim() + "%' )");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

            }
        }

        private void cboSID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }
        }

        private void dtpSDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }
        }

        private void GridSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void GridSrc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GridSrc_DoubleClick(null, null);
            }
        }

        private void GridSrc_DoubleClick(object sender, EventArgs e)
        {
            if (chkSearch == "Sale")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboSID.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboSID_Leave(null, null);
                cboSID.Select();
            }

            if (chkSearch == "Item")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboICode.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboICode_Leave(null, null);
                cboILoc.Select();
            }

            if (chkSearch == "Customer")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboSID.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboSID_Leave(null, null);
                btnAddItem.Select();
            }

            if (chkSearch == "Vehicle")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboVNo.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboVNo_Leave(null, null);
                txtCash.Select();
            }

            grpSrc.Visible = false;
        }
    }
}
