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
    public partial class Challan : Form
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
        string srcType = "";
        public Challan()
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

            this.grpVechicleInfo.Location = new System.Drawing.Point(485, 191);
            this.grpVechicleInfo.Size = new System.Drawing.Size(447, 105);
            //grpVechicleInfo.Visible = true;
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select c.AutoNo,c.SL as 'Serial',c.ItemCode as 'Item Code',ItemName as 'Item Name',WhsName as 'Item Location', cast(Qty as decimal(10,2)) as Quantity, cast(UPrice as decimal(10,2)) as 'Unit Price', cast(Total as decimal(10,2)) as 'Total Price' from Challan as c,ItemInfo as i, whs as w where i.ItemCode = c.ItemCode and w.WhsId = c.LocID and CNo = '"+cboCNo.Text.Trim()+"'");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;

            GridMstr.DataSource = SvCls.GblDataTable("select cm.AutoNo,CNo as 'Challan No',Convert(datetime,cDate,103) as 'Challan Date',PartyName as 'Party Name',Cast(TotalAmt as decimal(10,2)) as 'Total Amount' from ChallanMstr as cm,PartyInfo as p where p.PartyCode = cm.PartyCode order by CNo desc");
            GridMstr.Refresh();

            lblShowTotal.Text = "Total : " + GridMstr.Rows.Count.ToString();
            GridMstr.Columns[0].Visible = false;
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            checkqry = "select CNo,Autono from ChallanMstr where PartyCode = '' and TotalAmt  = 0.00 and AcPost = '' and PcName = '" + ClsVar.GblPcName + "'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                ChallanMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                Qry = "delete from Challan where AutoNoFormMstrTbl = " + ChallanMstrAutoNo + " and PcName = '" + ClsVar.GblPcName + "'";
                SvCls.insertUpdate(Qry);

                Qry = "delete from ChallanMstr where PartyCode = '' and TotalAmt = 0.00 and PcName = '" + ClsVar.GblPcName + "'";
                SvCls.insertUpdate(Qry);
            }

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

            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";
            dtpCDate.Select();
            btnLoadGridData_Click(null, null);
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

            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";
            btnLoadGridData_Click(null, null);
            btnAddNew.Select();

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
                cboISName.Select();
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
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void cboVNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                cboVType.Select();
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

                else
                {
                    ShowMessage("info", "Invalid Item Code");
                    cboISName.Text = "";
                    cboIName.Text = "";
                    cboIGroup.Text = "";
                    cboIUnit.Text = "";
                    cboBagSize.Text = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCNo.Text.Trim() == "")
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

            if (txtUnitPrice.Text.Trim() == "")
            {
                MessageBox.Show("Unit Price Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Select();
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
                SvCls.toGetData("select WhsId from whs where WhsName = '" + cboILocation.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    LocID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Location!!!");
                    cboILocation.Select();
                    return;
                }
            }

            if (cboCNo.Text.Trim() != "")
            {
                SvCls.toGetData("select AutoNo from ChallanMstr where CNo = '" + cboCNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ChallanMstrAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }

            }

            Qry = "insert Challan(ComId,CNo,SL,ItemCode,LocID,qty,UPrice,Total,rmk,AutoNoFormMstrTbl,PcName,UserCode) values ('" + ComID + "','" + cboCNo.Text.Trim() + "','" + cboISNo.Text.Trim() + "','" + cboICode.Text.Trim() + "','" + LocID + "'," + txtQty.Text.Trim() + "," + txtUnitPrice.Text.Trim() + "," + txtTotal.Text.Trim() + ",'" + cboRmk.Text.Trim() + "'," + ChallanMstrAutoNo + ",'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select CNo,SL,ItemCode from Challan where CNo = '" + cboCNo.Text.Trim() + "' and SL = '" + cboISNo.Text.Trim() + "'";
            EdtQry = "update Challan set ComId = '" + ComID + "',ItemCode = '" + cboICode.Text.Trim() + "',LocID = '" + LocID + "',qty = " + txtQty.Text.Trim() + ",UPrice = " + txtUnitPrice.Text.Trim() + ",Total = " + txtTotal.Text.Trim() + ",rmk = '" + cboRmk.Text.Trim() + "',AutoNoFormMstrTbl = " + ChallanMstrAutoNo + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where CNo = '" + cboCNo.Text.Trim() + "' and SL = '" + cboISNo.Text.Trim() + "'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                checkqry = "select ItemCode from Challan where CNo = '" + cboCNo.Text.Trim() + "' and ItemCode = '" + cboICode.Text.Trim() + "' ";
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
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

            Qry = "select Cast(sum(Total) as decimal(10,2)) as 'GrandTotal' from Challan where CNo = '" + cboCNo.Text.Trim() + "'";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                GrandTotal = Convert.ToDouble(SvCls.GblRdrToGetData["GrandTotal"].ToString());
            }

            btnAddItem.Select();
            btnLoadGridData_Click(null, null);
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

                Qry = "select AutoNo,ComID,CDate,PartyCode,VNo,VType,DriverName,VDM,cast(payable as decimal(10,2)) as payable,cast(paid as decimal(10,2)) as paid,cast(totalamt as decimal(10,2)) as totalamt from ChallanMstr where CNO = '"+cboCNo.Text.Trim()+"' and partyCode != ''";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComID"].ToString();
                    dtpCDate.Text = SvCls.GblRdrToGetData["CDate"].ToString();
                    cboSID.Text = SvCls.GblRdrToGetData["PartyCode"].ToString();
                    cboVNo.Text = SvCls.GblRdrToGetData["VNo"].ToString();
                    cboVType.Text = SvCls.GblRdrToGetData["VType"].ToString();
                    cboDriverName.Text = SvCls.GblRdrToGetData["DriverName"].ToString();
                    cboMobile.Text = SvCls.GblRdrToGetData["VDM"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();

                    Qry = "select ComName from Company where ComId = '" + ComID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
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
            }

            btnLoadGridData_Click(null, null);
        }

        private void challanNotFound()
        {
            ShowMessage("info", "Challan not found!!!");
            cboComName.Text = "";
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

            cboVNo.Text = "";
            cboVType.Text = "";
            cboDriverName.Text = "";
            cboMobile.Text = "";

            dtpCDate.Select();
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
                        cboISName.Text = "";
                        cboIName.Text = "";
                        cboIGroup.Text = "";
                        cboIUnit.Text = "";
                    }

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
                cboILocation.Text = "";
                txtQty.Text = "";
                txtTotal.Text = "";
                txtUnitPrice.Text = "";
                cboRmk.Text = "";
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

        private void GridMstr_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = GridMstr.SelectedCells[0].RowIndex;
            cboCNo.Text = GridMstr.Rows[i].Cells[1].Value.ToString();
            cboCNo_Leave(null, null);

            cboComName.Focus();
        }

        private void cboVType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
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
                btnPostAcc.Select();
            }
        }

        private void btnAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                cboVNo.Select();
            }
        }

        private void cboISName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                cboILocation.Select();
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
                    cboBagSize.Text = SvCls.GblRdrToGetData["BagSize"].ToString();
                }
                else
                {
                    ShowMessage("info", "Item Information Not Found!!!");
                    cboICode.Text = "";
                    cboIName.Text = "";
                    cboIGroup.Text = "";
                    cboIUnit.Text = "";
                    cboBagSize.Text = "";

                }

            }
        }

        private void btnPostAcc_Click(object sender, EventArgs e)
        {
            if (cboCNo.Text.Trim() == "")
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

            if (cboSID.Text.Trim() == "")
            {
                MessageBox.Show("Supplier ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSID.Select();
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

            checkqry = "select CNo,Autono from ChallanMstr where PartyCode != '' and CNo = '" + cboCNo.Text.Trim() + "'";
            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                EdtQry = "update ChallanMstr set ComId = '" + ComID + "',CDate = Convert(datetime,'" + dtpCDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDriverName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',TotalAmt = "+GrandTotal+",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where CNo = '" + cboCNo.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
            }

            else
            {
                EdtQry = "update ChallanMstr set ComId = '" + ComID + "',CDate = Convert(datetime,'" + dtpCDate.Text.Trim() + "',103),PartyCode = '" + cboSID.Text.Trim() + "',VNo = '" + cboVNo.Text.Trim() + "',VType = '" + cboVType.Text.Trim() + "', DriverName = '" + cboDriverName.Text.Trim() + "',VDM = '" + cboMobile.Text.Trim() + "',TotalAmt = " + GrandTotal + ",PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where CNo = '" + cboCNo.Text.Trim() + "'";
                SvCls.insertUpdate(EdtQry);
                ShowMessage("save", "");
            }
            btnLoadGridData_Click(null, null);
            cboComName.Select();
        }

        private void btnMstrDelete_Click(object sender, EventArgs e)
        {
            if (cboCNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Challan No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCNo.Select();
                return;
            }

            checkqry = "select CDate,VNo,PartyCode from ChallanMstr where CNo = '" + cboCNo.Text.Trim() + "'";
            Qry = "delete from ChallanMstr where CNo = '" + cboCNo.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("delete", "");
                    Qry = "delete from Challan where CNo = '" + cboCNo.Text.Trim() + "'";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select cm.AutoNo, CNo as 'Challan No',Convert(datetime,cDate,103) as 'Challan Date',PartyName as 'Party Name',cm.partyCode as 'Party Code',cast(TotalAmt as decimal(10,2)) as 'Total Amount',VNo as 'Vechicle No',DriverName as 'Driver Name',VDM as 'Mobile No',VType as 'Vehicle Type' from ChallanMstr as cm, PartyInfo as p where p.PartyCode = cm.PartyCode");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            srcType = "Challan";
            txtSrcText.Select();
        }

        private void btnSrcParty_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode,PartyName,Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Supplier' or PGroup = 'Both')");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            srcType = "Supplier";
            txtSrcText.Select();
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select AutoNo,ItemCode as 'ItemCode', ItemName as 'ItemName',ShortName as 'Item Short Name',IGroup as 'Item group', unit as 'Unit', cast(BagSize as decimal(10,2)) as 'Bag Size'  from ItemInfo");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
            srcType = "Item";
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
            srcType = "Vehicle";
            txtSrcText.Select();
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void btnAddNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSearch_Click(null, null);
            }

        }

        private void cboICode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnFindItem_Click(null, null);
            }
        }

        private void cboISName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnFindItem_Click(null, null);
            }
        }

        private void cboVNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSrcVehicle_Click(null, null);
            }
        }

        private void cboVType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSrcVehicle_Click(null, null);
            }
        }

        private void txtSrcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSrcText.Text == "")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    grpSrc.Visible = false;

                    if (srcType == "Challan")
                    {
                        cboCNo.Select();
                    }

                    if (srcType == "Item")
                    {
                        cboICode.Select();
                    }

                    if (srcType == "Vehicle")
                    {
                        cboVNo.Select();
                    }

                    if (srcType == "Supplier")
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
                if (srcType == "Challan")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select cm.AutoNo, CNo as 'Challan No',Convert(datetime,cDate,103) as 'Challan Date',PartyName as 'Party Name',cm.partyCode as 'Party Code',cast(TotalAmt as decimal(10,2)) as 'Total Amount',VNo as 'Vechicle No',DriverName as 'Driver Name',VDM as 'Mobile No',VType as 'Vehicle Type' from ChallanMstr as cm, PartyInfo as p where p.PartyCode = cm.PartyCode and (CNo LIKE '%" + txtSrcText.Text.Trim() + "%' or PartyName LIKE '%" + txtSrcText.Text.Trim() + "%' or cm.PartyCode LIKE '%" + txtSrcText.Text.Trim() + "%')");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (srcType == "Item")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select AutoNo, ItemCode as 'ItemCode', ItemName as 'ItemName',ShortName as 'Item Short Name',IGroup as 'Item group', unit as 'Unit', cast(BagSize as decimal(10,2)) as 'Bag Size'  from ItemInfo where ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemCode LIKE '%" + txtSrcText.Text.Trim() + "%' or ShortName LIKE '%" + txtSrcText.Text.Trim() + "%' or ItemName LIKE '%" + txtSrcText.Text.Trim() + "%' or IGroup LIKE '%" + txtSrcText.Text.Trim() + "%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (srcType == "Supplier")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select p.AutoNo,PartyCode,PartyName,Area, Zone,Address as 'Address',ResName from PartyInfo as p,ResInfo as r where r.ResId = p.ResId and (PGroup = 'Supplier' or PGroup = 'Both') and PartyName Like '%" + txtSrcText.Text.Trim() + "%'");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

                if (srcType == "Vehicle")
                {
                    GridSrc.DataSource = SvCls.GblDataTable("select v.AutoNo, VNO as 'Vechicle No', Vtype as 'Vehicle Type', EmpName as 'Driver Name',Phone as 'Phone',vrmk as 'Vehicle Remarks' from VehicleInfo as v, Employee as e where v.DrvEmpID = e.EmpID and (VNO Like '%" + txtSrcText.Text.Trim() + "%' or EmpName like '%" + txtSrcText.Text.Trim() + "%' )");
                    GridSrc.Refresh();
                    GridSrc.Columns[0].Visible = false;
                }

            }
        }

        private void GridSrc_DoubleClick(object sender, EventArgs e)
        {
            if (srcType == "Challan")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboCNo.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboCNo_Leave(null, null);
                cboCNo.Select();
            }

            if (srcType == "Item")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboICode.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboICode_Leave(null, null);
                cboILocation.Select();
            }

            if (srcType == "Supplier")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboSID.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboSID_Leave(null, null);
                btnAddItem.Select();
            }

            if (srcType == "Vehicle")
            {
                int i;
                i = GridSrc.SelectedCells[0].RowIndex;
                cboVNo.Text = GridSrc.Rows[i].Cells[1].Value.ToString();
                cboVNo_Leave(null, null);
                cboVNo.Select();
            }

            txtSrcText.Text = "";
            grpSrc.Visible = false;
        }

        private void GridSrc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GridSrc_DoubleClick(null, null);
            }
        }

        private void GridSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
