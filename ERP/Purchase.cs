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
    public partial class Purchase : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        //string PartyCode = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        double total = 0.0D;
        string LocID = "";
        double GrandTotal = 0.0D;
        double Payable = 0.0;
        //double Paid = 0.0;
        Int32 PurchaseMstrAutoNo = 0;

        string chkPurOrItem = "";
        public Purchase()
        {
            InitializeComponent();
            this.ControlBox = false;
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

        private void Purchase_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
            grpSrc.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select PurchaseCode from PurchaseMstr";
            cboPCode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboPCode.DisplayMember = "PurchaseCode";
            cboPCode.Text = "";

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

            Qry = "select PartyCode,PartyName from PartyInfo where PGroup = 'Supplier' or PGroup = 'Both'";
            cboSID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSID.DisplayMember = "partyCode";
            cboSID.Text = "";

            cboSName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSName.DisplayMember = "partyName";
            cboSName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboPCode.Text = "";
            dtpPDate.Text = DateTime.Today.ToString();
            cboSID.Text = "";
            cboSName.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            txtItemName.Text = "";
            txtItemGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            txtUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGrandTotal.Text = "";
            lblShowInfo.Text = "INFO";
            btnLoadGridData_Click(null, null);
            btnAddNew.Select();
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
                    cboDriverName.Text = SvCls.GblRdrToGetData["DName"].ToString();
                    cboMobile.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                   

                }

                else
                {
                    ShowMessage("info", "The Vechile Info Not Found!!!");
                    cboVType.Text = "";
                    cboDriverName.Text = "";
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

        private void cboICode_Leave(object sender, EventArgs e)
        {
            if (cboICode.Text.Trim() != "")
            {
                Qry = "select ShortName,itemName,IGroup,Unit,cast(BagSize as decimal(10,2)) as BagSize from ItemInfo where itemCode = '" + cboICode.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboISName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                    txtItemName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                    txtItemGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    txtUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }
                else
                {
                    ShowMessage("info", "Item Information Not Found!!!");
                    cboISName.Text = "";
                    txtItemName.Text = "";
                    txtItemGroup.Text = "";
                    txtUnit.Text = "";
                    
                }
                
            }
        }

        private void cboSID_Leave(object sender, EventArgs e)
        {
            if (cboSID.Text.Trim() != "")
            {
                Qry = "select PartyName,ProName,Phone from PartyInfo where partycode = '" + cboSID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboSName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                    lblShowInfo.Text = "ProName: " + SvCls.GblRdrToGetData["ProName"].ToString() + " // Mobile: " + SvCls.GblRdrToGetData["Phone"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Supplier ID");
                    cboSName.Text = "";
                    lblShowInfo.Text = "INFO";
                }
            }
        }

        private void cboSName_Leave(object sender, EventArgs e)
        {
            if (cboSName.Text.Trim() != "")
            {
                Qry = "select PartyCode from PartyInfo where PartyName = '" + cboSName.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboSID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Supplier Name");
                    cboSID.Text = "";
                    
                }
            }
        }

        private void cboPCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpPDate.Select();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            checkqry = "select PurchaseCode,Autono from PurchaseMstr where PartyCode = '' and TotalAmt  = 0.00 and AcPost = '' and PcName = '"+ClsVar.GblPcName+"'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                PurchaseMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                Qry = "delete from Purchase where AutoNoFormMstrTbl = "+ PurchaseMstrAutoNo + " and PcName = '" + ClsVar.GblPcName + "'";
                SvCls.insertUpdate(Qry);

                Qry = "delete from PurchaseMstr where PartyCode = '' and TotalAmt = 0.00 and PcName = '" + ClsVar.GblPcName + "'";
                SvCls.insertUpdate(Qry);
            }

            Qry = "select isnull(max(convert(numeric,PurchaseCode)),1000)+1 as PurchaseCode from PurchaseMstr";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                cboPCode.Text = SvCls.GblRdrToGetData["PurchaseCode"].ToString();
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

            Qry = "insert PurchaseMstr(ComId,PurchaseCode,PDate,PcName,UserCode) values ('" + ComID + "','" + cboPCode.Text.Trim() + "',CONVERT(datetime,'" + dtpPDate.Text.Trim() + "',103),'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            SvCls.insertUpdate(Qry);

            dtpPDate.Text = DateTime.Today.ToString();
            cboSID.Text = "";
            cboSName.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            txtItemName.Text = "";
            txtItemGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            txtUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGrandTotal.Text = "";
            dtpPDate.Select();
            btnLoadGridData_Click(null, null);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SlNo)),0)+1 as SlNo from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSNo.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                SvCls.GblCon.Close();
            }

            txtTotal.Text = "";
            txtItemGroup.Text = "";
            cboISName.Text = "";
            txtItemName.Text = "";
            cboICode.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtUPrice.Text = "";
            cboRmk.Text = "";
            txtUnit.Text = "";
            cboICode.Select();
        }

        private void dtpPDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSID.Select();
            }
        }

        private void cboSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSName.Select();
            }
        }

        private void cboSNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboILoc.Select();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar.ToString() == "\r")
            {
                txtUPrice.Select();
            }
        }

        private void txtUPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void cboVNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                cboVType.Select();
            }
        }

        private void cboVType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDriverName.Select();
            }
        }

        private void cboDriverName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar.ToString() == "\r")
            {
                btnPostAcc.Select();
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select p.AutoNo,p.SlNo as 'Serial',p.ItemCode as 'Item Code',ItemName as 'Item Name',cast(Qty as decimal(10,2)) as Quantity, cast(p.UnitPrice as decimal(10,2)) as 'Unit Price', cast(TotalPrice as decimal(10,2)) as 'Total Price' from Purchase as p,ItemInfo as i where i.ItemCode = p.ItemCode and PurchaseCode = '"+cboPCode.Text.Trim()+"'");
            Grid.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void cboSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddItem.Select();
            }
        }

        private void cboICode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboISName.Select();
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            totalCal();
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

        private void txtUPrice_KeyUp(object sender, KeyEventArgs e)
        {
            totalCal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboPCode.Text.Trim() == "")
            {
                MessageBox.Show("Purchase Code Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPCode.Select();
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
                    cboILoc.Select();
                    return;
                }
            }

            if (cboPCode.Text.Trim() != "")
            {
                SvCls.toGetData("select AutoNo from PurchaseMstr where PurchaseCode = '" + cboPCode.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    PurchaseMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }

            }

            Qry = "insert Purchase(ComId,PurchaseCode,SlNo,ItemCode,LocID,qty,UnitPrice,TotalPrice,rmk,AutoNoFormMstrTbl,PcName,UserCode) values ('" + ComID + "','" + cboPCode.Text.Trim() + "','" + cboSNo.Text.Trim() + "','" + cboICode.Text.Trim() + "','" + LocID + "'," + txtQty.Text.Trim() + "," + txtUPrice.Text.Trim() + "," + txtTotal.Text.Trim() + ",'" + cboRmk.Text.Trim() + "'," + PurchaseMstrAutoNo + ",'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select SlNo,ItemCode from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
            EdtQry = "update Purchase set ComId = '" + ComID + "',ItemCode = '" + cboICode.Text.Trim() + "',LocID = '" + LocID + "',qty = " + txtQty.Text.Trim() + ",UnitPrice = " + txtUPrice.Text.Trim() + ",TotalPrice = " + txtTotal.Text.Trim() + ",rmk = '" + cboRmk.Text.Trim() + "',AutoNoFormMstrTbl = " + PurchaseMstrAutoNo + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where PurchaseCode = '" + cboPCode.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                checkqry = "select ItemCode from Purchase where PurchaseCode = '" +cboPCode.Text.Trim() + "' and ItemCode = '" + cboICode.Text.Trim() + "' ";
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

            Qry = "select Cast(sum(TotalPrice) as decimal(10,2)) as 'GrandTotal' from Purchase where PurchaseCode = '"+cboPCode.Text.Trim()+"'";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                txtGrandTotal.Text = SvCls.GblRdrToGetData["GrandTotal"].ToString();
                GrandTotal = Convert.ToDouble(SvCls.GblRdrToGetData["GrandTotal"].ToString());
                
            }

            btnAddItem.Select();
            btnLoadGridData_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboPCode.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Purchase Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPCode.Select();
                return;
            }

            if (cboSNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Serial No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSNo.Select();
                return;
            }

            checkqry = "select Qty,ItemCode from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
            Qry = "delete from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "' and SlNo = '" + cboSNo.Text.Trim() + "'";
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

        private void cboSNo_Leave(object sender, EventArgs e)
        {
            if (cboSNo.Text.Trim() != "")
            {
                Qry = "select ItemCode,LocID,cast(Qty as decimal(10,2)) as Qty,cast(UnitPrice as decimal(10,2)) as UnitPrice,cast(TotalPrice as decimal(10,2)) as TotalPrice,rmk from Purchase where SlNo = '" + cboSNo.Text.Trim() + "' and PurchaseCode = '" + cboPCode.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboICode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    LocID = SvCls.GblRdrToGetData["LocID"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["Qty"].ToString();
                    txtUPrice.Text = SvCls.GblRdrToGetData["UnitPrice"].ToString();
                    txtTotal.Text = SvCls.GblRdrToGetData["TotalPrice"].ToString();
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
                        txtItemName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                        txtItemGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                        txtUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    }
                }

                else
                {
                    ShowMessage("not found", "");
                    cboICode.Text = "";
                    cboISName.Text = "";
                    txtItemName.Text = "";
                    txtUnit.Text = "";
                    txtItemGroup.Text = "";
                    cboILoc.Text = "";
                    txtQty.Text = "";
                    txtTotal.Text = "";
                    txtUPrice.Text = "";
                    cboRmk.Text = "";
                    
                }
            }
            
        }

        private void btnPostAcc_Click(object sender, EventArgs e)
        {
            if (cboPCode.Text.Trim() == "")
            {
                MessageBox.Show("Purchase Code Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPCode.Select();
                return;
            }

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Supplier ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSID.Select();
                return;
            }
            if(txtDue.Text.Trim() == "")
            {
                txtDue.Text = 0.ToString();
            }
            if (txtCash.Text.Trim() == "")
            {
                txtCash.Text = 0.ToString();
            }
            if (txtGrandTotal.Text.Trim() == "")
            {
                txtGrandTotal.Text = 0.ToString();
            }

            if (txtGrandTotal.Text.Trim() == "0")
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

            if (Convert.ToDouble(txtGrandTotal.Text) < Convert.ToDouble(txtCash.Text))
            {
                MessageBox.Show("Cash Amount Cann't be Bigger than Grand Total...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCash.Select();
                return;
            }

            checkqry = "select PurchaseCode,Autono from PurchaseMstr where PartyCode != '' and AcPost = 'Posted' and PurchaseCode = '"+cboPCode.Text.Trim()+"'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                EdtQry = "update PurchaseMstr set ComId = '" + ComID + "',PDate = Convert(datetime,'" + dtpPDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDriverName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',paid = " + txtCash.Text.Trim() + ",Payable = " + txtDue.Text.Trim() + ",TotalAmt = " + txtGrandTotal.Text.Trim() + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "',AcPost = 'Posted' where purchaseCode = '" + cboPCode.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
            }

            else
            {
                EdtQry = "update PurchaseMstr set ComId = '" + ComID + "',PDate = Convert(datetime,'" + dtpPDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDriverName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',paid = " + txtCash.Text.Trim() + ",Payable = " + txtDue.Text.Trim() + ",TotalAmt = " + txtGrandTotal.Text.Trim() + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "',AcPost = 'Posted' where purchaseCode = '" + cboPCode.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("save", "");
            }

            cboComName.Select();
        }

        private void grandTotalCal()
        {
            //txtGrandTotal.Text = GrandTotal.ToString();

            if(txtCash.Text == "")
            {
                txtCash.Text = 0.ToString();
            }
            if (txtGrandTotal.Text == "" && txtCash.Text == "")
            {
                Payable = 0.0D;
            }

            if (txtGrandTotal.Text == "" && txtCash.Text != "")
            {
                Payable = 0.0D;
            }

            if (txtGrandTotal.Text != "" && txtCash.Text == "")
            {
                Payable = Convert.ToDouble(txtGrandTotal.Text);
            }


            else if(txtGrandTotal.Text != "" && txtCash.Text != "")
            {
                Payable = Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtCash.Text);
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

        private void txtGrandTotal_KeyUp(object sender, KeyEventArgs e)
        {
            grandTotalCal();
        }

        private void cboPCode_Leave(object sender, EventArgs e)
        {
            if (cboPCode.Text.Trim() != "")
            {
                Qry = "select SlNo from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "' ";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboSNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                    cboSNo.DisplayMember = "SlNo";
                    cboSNo.Text = "";
                }

                Qry = "select AutoNo,ComID,PDate,PartyCode,VNo,VType,DriverName,VDM,cast(payable as decimal(10,2)) as payable,cast(paid as decimal(10,2)) as paid,cast(totalamt as decimal(10,2)) as totalamt from PurchaseMstr where PurchaseCode = '" + cboPCode.Text.Trim() + "' and partyCode != ''";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComID"].ToString();
                    dtpPDate.Text = SvCls.GblRdrToGetData["PDate"].ToString();
                    cboSID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                    cboVNo.Text = SvCls.GblRdrToGetData["VNo"].ToString();
                    txtDue.Text = SvCls.GblRdrToGetData["payable"].ToString();
                    txtCash.Text = SvCls.GblRdrToGetData["paid"].ToString();
                    txtGrandTotal.Text = SvCls.GblRdrToGetData["totalamt"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    txtComId.Text = SvCls.GblRdrToGetData["ComID"].ToString();
                    cboVType.Text = SvCls.GblRdrToGetData["VType"].ToString();
                    cboMobile.Text = SvCls.GblRdrToGetData["VDM"].ToString();
                    cboDriverName.Text = SvCls.GblRdrToGetData["DriverName"].ToString();

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

                    Qry = "select PartyName,ProName,Phone from PartyInfo where partycode = '" + cboSID.Text.Trim() + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboSName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                        lblShowInfo.Text = "ProName: " + SvCls.GblRdrToGetData["ProName"].ToString() + " // Mobile: " + SvCls.GblRdrToGetData["Phone"].ToString();
                    }
                    else
                    {
                        ShowMessage("info", "Invalid Supplier ID");
                        cboSName.Text = "";
                        lblShowInfo.Text = "INFO";
                    }

                }

                else
                {
                    purchaseNotFound();
                }

                btnLoadGridData_Click(null, null);  
            }
        }

        private void purchaseNotFound()
        {
            ShowMessage("info", "Purchase Code not found!!!");
            cboComName.Text = "";

            dtpPDate.Text = DateTime.Today.ToString();
            cboSID.Text = "";
            cboSName.Text = "";
            cboILoc.Text = "";
            cboSNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            txtItemName.Text = "";
            txtItemGroup.Text = "";
            cboILoc.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            txtUPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            txtUnit.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";
            txtCash.Text = "";
            txtDue.Text = "";
            txtGrandTotal.Text = "";

            dtpPDate.Select();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboSNo.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboSNo_Leave(null, null);
            cboSNo.Focus();
        }

        private void btnMstrDelete_Click(object sender, EventArgs e)
        {
            if (cboPCode.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Purchase Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPCode.Select();
                return;
            }            

            checkqry = "select pDate,VNo,PartyCode from PurchaseMstr where PurchaseCode = '" + cboPCode.Text.Trim() + "'";
            Qry = "delete from PurchaseMstr where PurchaseCode = '" + cboPCode.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("delete", "");
                    Qry = "delete from Purchase where PurchaseCode = '" + cboPCode.Text.Trim() + "'";
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

        private void btnAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F6)
            {
                cboVNo.Select();
            }
            if (e.KeyCode == Keys.F4)
            {
                txtCash.Focus();
            }
        }

        private void cboISName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboILoc.Select();
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
                    txtItemName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                    txtItemGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    txtUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }
                else
                {
                    ShowMessage("info", "Item Information Not Found!!!");
                    cboICode.Text = "";
                    txtItemName.Text = "";
                    txtItemGroup.Text = "";
                    txtUnit.Text = "";
                    
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select pm.AutoNo, PurchaseCode as 'Purchase Code',PartyName as 'Party Name',pm.partyCode as 'Party Code',cast(TotalAmt as decimal(10,2)) as 'Total Amount',cast(Paid as decimal(10,2)) as Paid,cast(Payable as decimal(10,2)) as Payable,VNo as 'Vechicle No' from PurchaseMstr as pm, PartyInfo as p where p.PartyCode = pm.PartyCode");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkPurOrItem = "Purchased";
            txtSrcText.Select();
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void txtSrcText_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtSrcText.Text.Trim() != "")
            {
                if(chkPurOrItem == "Purchased")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select pm.AutoNo, PurchaseCode as 'Purchase Code',PartyName as 'Party Name',pm.partyCode as 'Party Code',cast(TotalAmt as decimal(10,2)) as 'Total Amount',cast(Paid as decimal(10,2)) as Paid,cast(Payable as decimal(10,2)) as Payable,VNo as 'Vechicle No' from PurchaseMstr as pm, PartyInfo as p where p.PartyCode = pm.PartyCode and (PurchaseCode LIKE '%" + txtSrcText.Text.Trim() + "%' or PartyName LIKE '%" + txtSrcText.Text.Trim() + "%' or pm.PartyCode LIKE '%"+ txtSrcText.Text.Trim() + "%')");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if(chkPurOrItem == "Item")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select AutoNo, ItemCode as 'ItemCode', ItemName as 'ItemName',ShortName as 'Item Short Name',IGroup as 'Item group', unit as 'Unit', cast(BagSize as decimal(10,2)) as 'Bag Size'  from ItemInfo where ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ShortName LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemName LIKE '%" + txtSrcText.Text.Trim() + "%' or IGroup LIKE '%" + txtSrcText.Text.Trim()+"%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (chkPurOrItem == "Supplier")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode,PartyName,Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Supplier' or PGroup = 'Both') and PartyName Like '%" + txtSrcText.Text.Trim() + "%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (chkPurOrItem == "Vehicle")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select v.AutoNo, VNO as 'Vechicle No', Vtype as 'Vehicle Type', EmpName as 'Driver Name',Phone as 'Phone',vrmk as 'Vehicle Remarks' from VehicleInfo as v, Employee as e where v.DrvEmpID = e.EmpID and (VNO Like '%"+txtSrcText.Text.Trim()+ "%' or EmpName like '%" + txtSrcText.Text.Trim() + "%' )");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

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
            chkPurOrItem = "Item";
            txtSrcText.Select();
        }

        private void GridSrc_DoubleClick(object sender, EventArgs e)
        { 
            if(chkPurOrItem == "Purchased")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboPCode.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboPCode_Leave(null, null);
                cboPCode.Select();
            }

            if(chkPurOrItem == "Item")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboICode.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboICode_Leave(null, null);
                cboILoc.Select();
            }

            if (chkPurOrItem == "Supplier")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboSID.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboSID_Leave(null, null);
                btnAddItem.Select();
            }

            if (chkPurOrItem == "Vehicle")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboVNo.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboVNo_Leave(null, null);
                txtCash.Select();
            }

            grpSrc.Visible = false;
        }

        private void btnSearchParty_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode,PartyName,Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Supplier' or PGroup = 'Both')");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            chkPurOrItem = "Supplier";
            txtSrcText.Select();
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
            chkPurOrItem = "Vehicle";
            txtSrcText.Select();
        }

        private void btnAddNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }

            if (e.KeyCode == Keys.F4)
            {
                txtCash.Focus();
            }
        }

        private void dtpPDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }
        }

        private void cboPCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }
        }

        private void cboSID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchParty_Click(null,null);
            }
        }

        private void cboSName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearchParty_Click(null, null);
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
                btnSearchItem_Click(null,null);
            }
        }


        private void cboComName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                txtCash.Focus();
            }
        }

        private void txtSrcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtSrcText.Text == "")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    grpSrc.Visible = false;

                    if(chkPurOrItem == "Purchased")
                    {
                        cboPCode.Select();
                    }

                    if (chkPurOrItem == "Item")
                    {
                        cboICode.Select();
                    }

                    if (chkPurOrItem == "Vehicle")
                    {
                        cboVNo.Select();
                    }

                    if (chkPurOrItem == "Supplier")
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

        private void cboVNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSrcVehicle_Click(null,null);
            }
        }

        private void cboVType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSrcVehicle_Click(null, null);
            }
        }

        //private void lblShowInfo_TextChanged(object sender, EventArgs e)
        //{
        //    Qry = "select ProName,Phone from PartyInfo where PartyCode = '"+cboSID.Text.Trim()+"'";
        //    SvCls.toGetData(Qry);
        //    if (SvCls.GblRdrToGetData.Read())
        //    {
        //        lblShowInfo.Text = SvCls.GblRdrToGetData["ProName"].ToString();
        //        // + "//" + SvCls.GblRdrToGetData["ProName"].ToString();
        //    }
        //    else
        //    {
        //        lblShowInfo.Text = "";
        //    }
        //}
    }
}
