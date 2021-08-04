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
    public partial class ProductionDelivery : Form
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
        Int32 ChallanMstrAutoNo = 0;
        public ProductionDelivery()
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

        private void Challan_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpVechicleInfo_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select c.AutoNo,c.SL as 'Serial',c.ItemCode as 'Item Code',ItemName as 'Item Name',WhsName as 'Item Location', cast(Qty as decimal(10,2)) as Quantity, cast(UPrice as decimal(10,2)) as 'Unit Price', cast(Total as decimal(10,2)) as 'Total Price' from Challan as c,ItemInfo as i, whs as w where i.ItemCode = c.ItemCode and w.WhsId = c.LocID and CNo = '"+cboCNo.Text.Trim()+"'");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
            
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select CNo from ChallanMstr";
            cboCNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCNo.DisplayMember = "CNo";
            cboCNo.Text = "";

            Qry = "select WhsName from whs";
            cboILocation.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboILocation.DisplayMember = "WhsName";
            cboILocation.Text = "";

            Qry = "select itemcode from itemInfo";
            cboICode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboICode.DisplayMember = "itemcode";
            cboICode.Text = "";
            

            Qry = "select PartyCode,PartyName from PartyInfo where PGroup = 'Supplier' or PGroup = 'Both'";
            cboSID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSID.DisplayMember = "partyCode";
            cboSID.Text = "";

            cboSName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSName.DisplayMember = "partyName";
            cboSName.Text = "";


        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            Qry = "delete from ChallanMstr where PartyCode = '' and VID = '' and TotalAmt = 0.00 and PcName = 'PC Name'";
            SvCls.insertUpdate(Qry);


            SvCls.toGetData("select isnull(max(convert(numeric,CNo)),1000)+1 as CNo from ChallanMstr");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboCNo.Text = SvCls.GblRdrToGetData["CNo"].ToString();
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

            Qry = "insert ChallanMstr(ComId,CNo,CDate,PcName,UserCode) values ('"+ ComID + "','"+cboCNo.Text.Trim()+"',CONVERT(datetime,'"+dtpCDate.Text.Trim()+"',103),'"+ClsVar.GblPcName+ "','" + ClsVar.GblUserId + "')";
            SvCls.insertUpdate(Qry);            
            
            dtpCDate.Text = DateTime.Today.ToString();
            cboSID.Text = "";
            cboSName.Text = "";
            cboILocation.Text = "";

            cboISNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            cboIName.Text = "";
            cboIGroup.Text = "";
            cboIUnit.Text = "";
            cboBagSize.Text = "";

            txtQty.Text = "";
            txtTotal.Text = "";
            txtUnitPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";

            dtpCDate.Select();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboCNo.Text = "";
            dtpCDate.Text = DateTime.Today.ToString();
            cboSID.Text = "";
            cboSName.Text = "";
            cboILocation.Text = "";

            cboISNo.Text = "";
            cboICode.Text = "";
            cboISName.Text = "";
            cboIName.Text = "";
            cboIGroup.Text = "";
            cboIUnit.Text = "";
            cboBagSize.Text = "";

            txtQty.Text = "";
            txtTotal.Text = "";
            txtUnitPrice.Text = "";
            cboAutoNo.Text = "";
            cboRmk.Text = "";
            

        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboCNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Challan No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCNo.Select();
                return;
            }

            if (cboISNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Serial No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCNo.Select();
                return;
            }


            checkqry = "select CNo,SL from Challan where CNo = '" + cboCNo.Text.Trim() + "' and SL = '" + cboISNo.Text.Trim() + "'";
            Qry = "delete from Challan where CNo = '"+cboCNo.Text.Trim()+"' and SL = '"+cboISNo.Text.Trim()+"'";
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

                //cboComName.Select();
                //btnLoadGridData_Click(null, null);
            }
        }

        private void cboCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpCDate.Select();
            }
        }

        private void dtpCDate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddItem.Select();
            }
        }

        private void cboSlNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboICode.Select();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SL)),0)+1 as SL from Challan where CNo = '"+cboCNo.Text.Trim()+"'");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboISNo.Text = SvCls.GblRdrToGetData["SL"].ToString();
                SvCls.GblCon.Close();
            }

            cboICode.Select();
        }

        private void cboICode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboILocation.Select();
            }
        }
        private void cboILocation_KeyPress(object sender, KeyPressEventArgs e)
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
                txtUnitPrice.Select();
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRmk.Select();
            }
        }

        

        private void cboRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void cboVNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                cboVNo_Leave(null, null);
            }


        }

        private void cboSID_Leave(object sender, EventArgs e)
        {
            if(cboSID.Text.Trim() != "")
            {
                Qry = "select PartyName from PartyInfo where partycode = '" + cboSID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if(SvCls.GblRdrToGetData.Read())
                {
                    cboSName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                }
            }
        }

        private void cboSName_Leave(object sender, EventArgs e)
        {
            if (cboSName.Text.Trim() != "")
            {
                Qry = "select PartyCode from PartyInfo where PartyName = '" +cboSName.Text.Trim()+ "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboSID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                }
            }
        }

        private void cboICode_Leave(object sender, EventArgs e)
        {
            if (cboICode.Text.Trim() != "")
            {
                Qry = "select ShortName,itemName,IGroup,Unit,cast(BagSize as decimal(10,2)) as BagSize from ItemInfo where itemCode = '"+cboICode.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboISName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                    cboIName.Text = SvCls.GblRdrToGetData["itemName"].ToString();
                    cboIGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    cboIUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    cboBagSize.Text = SvCls.GblRdrToGetData["BagSize"].ToString();
                }
            }
        }

        private void cboVNo_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboCNo.Text.Trim() == "")
            {
                MessageBox.Show("Challan No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCNo.Select();
                return;
            }

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            

            if (cboISNo.Text.Trim() == "")
            {
                MessageBox.Show("Item Serial No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboISNo.Select();
                return;
            }

            if (cboILocation.Text.Trim() == "")
            {
                MessageBox.Show("Item Location Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboILocation.Select();
                return;
            }

            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Quantity Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Select();
                return;
            }

            if (txtUnitPrice.Text.Trim() == "")
            {
                MessageBox.Show("Unit Price Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Select();
                return;
            }

            if (cboSName.Text.Trim() == "")
            {
                MessageBox.Show("Supplier Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSName.Select();
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

            if (cboILocation.Text.Trim() != "")
            {
                SvCls.toGetData("select WhsId from whs where WhsName = '" + cboILocation.Text.Trim()+"'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    LocID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Company Name");
                    cboComName.Select();
                    return;
                }
            }

            if (cboILocation.Text.Trim() != "")
            {
                SvCls.toGetData("select WhsId from whs where WhsName = '" + cboILocation.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    LocID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Company Name");
                    cboComName.Select();
                    return;
                }
            }

            if (cboCNo.Text.Trim() != "")
            {
                SvCls.toGetData("select AutoNo from ChallanMstr where CNo = '"+cboCNo.Text.Trim()+"'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ChallanMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }

            }

            Qry = "insert Challan(ComId,CNo,SL,ItemCode,LocID,qty,UPrice,Total,rmk,AutoNoFormMstrTbl,PcName,UserCode) values ('"+ComID+"','"+cboCNo.Text.Trim()+"','"+cboISNo.Text.Trim()+"','"+cboICode.Text.Trim()+"','"+LocID+"',"+txtQty.Text.Trim()+","+txtUnitPrice.Text.Trim()+","+txtTotal.Text.Trim()+",'"+cboRmk.Text.Trim()+"',"+ ChallanMstrAutoNo + ",'"+ClsVar.GblPcName+ "','" + ClsVar.GblUserId + "')";
            checkqry = "select CNo,SL,ItemCode from Challan where CNo = '"+cboCNo.Text.Trim()+ "' and SL = '" + cboISNo.Text.Trim() + "'";
            EdtQry = "update Challan set ComId = '"+ComID+"',ItemCode = '"+cboICode.Text.Trim()+"',LocID = '"+ LocID + "',qty = "+txtQty.Text.Trim()+",UPrice = "+txtUnitPrice.Text.Trim()+",Total = "+txtTotal.Text.Trim()+",rmk = '"+cboRmk.Text.Trim()+"',AutoNoFormMstrTbl = "+ChallanMstrAutoNo+",PcName = '"+ClsVar.GblPcName+"',UserCode = '"+ClsVar.GblUserId+"' where CNo = '"+cboCNo.Text.Trim()+"' and SL = '"+cboISNo.Text.Trim()+"'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                checkqry = "select ItemCode from Challan where CNo = '"+cboCNo.Text.Trim()+ "' and ItemCode = '" + cboICode.Text.Trim() + "' ";
                SvCls.toGetData(checkqry);
                if(SvCls.GblRdrToGetData.Read())
                {
                    ShowMessage("info", "ItemCode Cann't be duplicate in a Challan!!!");
                }
                else
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("save", "");
                }
                
            }

            Qry = "select Cast(sum(Total) as decimal(10,2)) as 'GrandTotal' from Challan where CNo = '"+cboCNo.Text.Trim()+"'";
            SvCls.toGetData(Qry);
            if(SvCls.GblRdrToGetData.Read())
            {
                GrandTotal = Convert.ToDouble(SvCls.GblRdrToGetData["GrandTotal"].ToString());
            }
            EdtQry = "update ChallanMstr set ComID = '" + ComID + "',CNo = '" + cboCNo.Text.Trim() + "',CDate = CONVERT(datetime,'" + dtpCDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',TotalAmt = " +GrandTotal+ ",Rmk = '" + cboRmk.Text.Trim() + "',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where CNo = '" + cboCNo.Text.Trim() + "'";
            SvCls.insertUpdate(EdtQry);
            cboComName.Select();

        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text == "" && txtUnitPrice.Text == "")
            {
                total = 0.0D;
            }

            if (txtQty.Text == "" && txtUnitPrice.Text != "")
            {
                total = 0.0D;
            }

            if (txtQty.Text != "" && txtUnitPrice.Text != "")
            {
                total = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
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


        private void txtUnitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text == "" && txtUnitPrice.Text == "")
            {
                total = 0.0D;
            }

            if (txtQty.Text != "" && txtUnitPrice.Text == "")
            {
                total = 0.0D;
            }

            if (txtQty.Text != "" && txtUnitPrice.Text != "")
            {
                total = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
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

        private void cboCNo_Leave(object sender, EventArgs e)
        {
            if (cboCNo.Text.Trim() != "")
            {
                Qry = "select CNo,SL from Challan where CNo = '" + cboCNo.Text.Trim() + "' ";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboISNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                    cboISNo.DisplayMember = "SL";
                    cboISNo.Text = "";
                }

                Qry = "select ComID,CNo,CDate,PartyCode,VNo from ChallanMstr where CNo = '" + cboCNo.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComID"].ToString();
                    dtpCDate.Text = SvCls.GblRdrToGetData["CDate"].ToString();
                    cboSID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();

                    Qry = "select ComName from Company where ComId = '" + ComID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                    }
                    cboSID_Leave(null, null);
                    cboVNo_Leave(null, null);
                    
                }
            }

            btnLoadGridData_Click(null, null);
        }

        private void cboISNo_Leave(object sender, EventArgs e)
        {
            if (cboISNo.Text.Trim() != "")
            {
                Qry = "select ItemCode,LocID,cast(Qty as decimal(10,2)) as Qty,cast(UPrice as decimal(10,2)) as UPrice,cast(Total as decimal(10,2)) as Total,rmk from Challan where SL = '" + cboISNo.Text.Trim()+"' and CNo = '"+cboCNo.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboICode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    LocID = SvCls.GblRdrToGetData["LocID"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["Qty"].ToString();
                    txtUnitPrice.Text = SvCls.GblRdrToGetData["UPrice"].ToString();
                    txtTotal.Text = SvCls.GblRdrToGetData["Total"].ToString();
                    cboRmk.Text = SvCls.GblRdrToGetData["rmk"].ToString();

                    Qry = "select WhsName from whs where WhsId = '"+LocID+"'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboILocation.Text = SvCls.GblRdrToGetData["WhsName"].ToString();
                    }

                    else
                    {
                        cboILocation.Text = "";
                    }
                    cboICode_Leave(null, null);

                }
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboISNo.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboISNo_Leave(null, null);
            
            cboISNo.Focus();
        }
        
        private void cboMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

       
    }
}
