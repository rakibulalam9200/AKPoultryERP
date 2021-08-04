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
    public partial class EggProduction : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string LocID = "";
        Int32 BAutoNo = 0;
        string ItemCode = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";

        public EggProduction()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        private void EggProduction_Load(object sender, EventArgs e)
        {
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
            cboComName.Select();
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

            Qry = "select WhsName from Whs";
            cboItemLocation.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboItemLocation.DisplayMember = "WhsName";
            cboItemLocation.Text = "";

            Qry = "select distinct BType from BatchInfo";
            cboBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBType.DisplayMember = "BType";
            cboBType.Text = "";

            //Qry = "select distinct BNo from BatchInfo";
            //cboBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            //cboBType.DisplayMember = "BType";
            //cboBType.Text = "";

            Qry = "select distinct ItemName from ItemInfo";
            cboItemName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboItemName.DisplayMember = "ItemName";
            cboItemName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboPID.Text = "";
            dtpPDate.Text = "";
            cboItemLocation.Text = "";
            cboItemName.Text = "";
            cboType.Text = "";
            cboBType.Text = "";
            cboBNo.Text = "";
            txtWeek.Text = "";
            txtDay.Text = "";
            txtProd.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            cboRmk.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,PID)),100)+1 as PID from EggProduction");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboPID.Text = SvCls.GblRdrToGetData["PID"].ToString();
                SvCls.GblCon.Close();
            }

            dtpPDate.Text = "";
            cboItemLocation.Text = "";
            cboItemName.Text = "";
            cboType.Text = "";
            cboBType.Text = "";
            cboBNo.Text = "";
            txtWeek.Text = "";
            txtDay.Text = "";
            txtProd.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            cboRmk.Text = "";
            dtpPDate.Select();
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void cboPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpPDate.Select();
            }
        }

        private void dtpPDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemLocation.Select();
            }
        }

        private void cboItemLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemName.Select();
            }
        }

        private void cboItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBType.Select();
            }
        }

        private void cboType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBType.Select();
            }
        }

        private void cboBType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBNo.Select();
            }
        }

        private void cboBNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtWeek.Select();
            }
        }

        private void txtWeek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDay.Select();
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtProd.Select();
            }
        }

        private void txtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtQuantity.Select();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtWeight.Select();
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboComName.Select();
                return;
            }

            if (cboPID.Text.Trim() == "")
            {
                MessageBox.Show("Production ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboPID.Select();
                return;
            }

            if (cboItemLocation.Text.Trim() == "")
            {
                MessageBox.Show("Item Location Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboItemLocation.Select();
                return;
            }

            if (cboBType.Text.Trim() == "")
            {
                MessageBox.Show("Batch Type Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBType.Select();
                return;
            }

            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Production Quantity Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtQuantity.Select();
                return;
            }

            if (cboBNo.Text.Trim() == "")
            {
                MessageBox.Show("Batch No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBNo.Select();
                return;
            }

            if (cboItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboItemName.Select();
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
                    ShowMessage("info", "Invalid Company Name!!!");
                    cboComName.Select();
                    return;
                }
            }

            if (cboItemName.Text.Trim() != "")
            {
                SvCls.toGetData("select ItemCode from ItemInfo WHERE ItemName = '" + cboItemName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ItemCode = SvCls.GblRdrToGetData["ItemCode"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboItemName.Select();
                    return;
                }
            }

            if (cboItemLocation.Text.Trim() != "")
            {
                SvCls.toGetData("select WhsId from whs where WhsName = '" + cboItemLocation.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    LocID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Location!!!");
                    cboItemLocation.Select();
                    return;
                }
            }

            if (cboType.Text.Trim() != "")
            {
                SvCls.toGetData("select IGroup from ItemInfo where ItemName = '"+cboItemName.Text.Trim()+"'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Group!!!");
                    cboType.Select();
                    return;
                }
            }

            if (cboBNo.Text.Trim() != "")
            {
                SvCls.toGetData("select BatchId,AutoNo from BatchInfo where  Btype  = '"+cboBType.Text.Trim()+"' and BatchId = '"+cboBNo.Text.Trim()+"'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    BAutoNo =Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }
                else
                {
                    ShowMessage("info", "Invalid Batch ID!!!");
                    cboBNo.Select();
                    return;
                }
            }

            if(txtWeek.Text == "")
            {
                txtWeek.Text = 0.ToString();
            }

            if (txtDay.Text == "")
            {
                txtDay.Text = 0.ToString();
            }

            if (txtWeight.Text == "")
            {
                txtWeight.Text = 0.ToString();
            }

            if (txtProd.Text == "")
            {
                txtProd.Text = 0.ToString();
            }


            Qry = "insert EggProduction(ComId, PID, PDate, LocID, ItemCode, BNo, WeekNo, DayNo, Perc, qty, weigt, rmk,BAutoNo, PcName, UserCode) values('" + ComID+"', '"+cboPID.Text.Trim()+"', Convert(datetime, '"+dtpPDate.Text.Trim()+"', 103), '"+LocID+"', '"+ItemCode+"', '"+cboBNo.Text.Trim()+"', "+txtWeek.Text.Trim()+", "+txtDay.Text.Trim()+", "+txtProd.Text.Trim()+", "+txtQuantity.Text.Trim()+", "+txtWeight.Text.Trim()+", '"+cboRmk.Text.Trim()+ "','" +BAutoNo+ "', '" + ClsVar.GblPcName + "', '" + ClsVar.GblUserId+"')";
            checkqry = "Select PDate,qty from EggProduction where PID = '"+cboPID.Text.Trim()+"'";
            EdtQry = "update EggProduction set ComId='"+ComID+"',PDate = Convert(datetime,'"+dtpPDate.Text.Trim()+"',103),LocID = '"+LocID+"',ItemCode = '"+ItemCode+"',BNo = '"+cboBNo.Text.Trim()+"',WeekNo = "+txtWeek.Text.Trim()+",DayNo = "+txtDay.Text.Trim()+",Perc = "+txtProd.Text.Trim()+",qty = "+txtQuantity.Text.Trim()+",weigt = "+txtWeight.Text.Trim()+",rmk = '"+cboRmk.Text.Trim()+ "',BAutoNo = '"+BAutoNo+"',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where PID = '"+cboPID.Text.Trim()+"'";

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

            cboComName.Focus();
            btnLoadGridData_Click(null, null);

        }

        private void cboBType_Leave(object sender, EventArgs e)
        {
            Qry = "select BatchId from BatchInfo where  Btype  = '" + cboBType.Text.Trim() + "'";
            cboBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBNo.DisplayMember = "BatchId";
            cboBNo.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboPID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Production ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPID.Select();
                return;
            }


            checkqry = "select PDate,qty from EggProduction where PID = '"+cboPID.Text.Trim()+"'";
            Qry = "delete from EggProduction where PID = '" + cboPID.Text.Trim() + "'";
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

                cboComName.Select();
                btnLoadGridData_Click(null, null);
            }
        }

        private void cboItemName_Leave(object sender, EventArgs e)
        {
            if (cboItemName.Text.Trim() != "")
            {
                SvCls.toGetData("select IGroup from ItemInfo WHERE ItemName = '"+cboItemName.Text.Trim()+"'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboItemName.Select();
                    return;
                }
            }
        }

        private void cboPID_Leave(object sender, EventArgs e)
        {
            if (cboPID.Text.Trim() != "")
            {

                Qry = "select AutoNo,ComID,PID,PDate,LocID,ItemCode,BNo,WeekNo,DayNo,Perc,qty,weigt,rmk,BAutoNo from EggProduction where PID = '"+cboPID.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    dtpPDate.Text = SvCls.GblRdrToGetData["PDate"].ToString();
                    LocID = SvCls.GblRdrToGetData["LocID"].ToString();
                    ItemCode = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    cboRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    cboBNo.Text = SvCls.GblRdrToGetData["BNo"].ToString();
                    txtWeek.Text = SvCls.GblRdrToGetData["WeekNo"].ToString();
                    txtDay.Text = SvCls.GblRdrToGetData["DayNo"].ToString();
                    txtProd.Text = SvCls.GblRdrToGetData["Perc"].ToString();
                    txtQuantity.Text = SvCls.GblRdrToGetData["qty"].ToString();
                    txtWeight.Text = SvCls.GblRdrToGetData["weigt"].ToString();
                    BAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["BAutoNo"].ToString());
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                   

                    Qry = "select WhsName from Whs where WhsId = '" + LocID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboItemLocation.Text = SvCls.GblRdrToGetData["WhsName"].ToString();
                    }

                    else
                    {
                        cboItemLocation.Text = "";
                    }

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

                    Qry = "select ItemName,IGroup from ItemInfo where ItemCode = '" + ItemCode + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboItemName.Text = SvCls.GblRdrToGetData["ItemName"].ToString();
                        cboType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    }

                    else
                    {
                        cboItemName.Text = "";
                        cboType.Text = "";
                    }

                    Qry = "select BType from BatchInfo where AutoNo = '"+BAutoNo+"'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboBType.Text = SvCls.GblRdrToGetData["BType"].ToString();
                       
                    }

                    else
                    {
                        cboBType.Text = "";
                       
                    }


                }
                else
                {
                    ShowMessage("not found", "");
                    cboAutoNo.Text = "";
                    cboComName.Text = "";
                    dtpPDate.Text = DateTime.Today.ToString();
                    cboItemLocation.Text = "";
                    cboItemName.Text = "";
                    cboType.Text = "";
                    cboBType.Text = "";
                    cboBNo.Text = "";
                    txtWeek.Text = "";
                    txtDay.Text = "";
                    txtProd.Text = "";
                    txtQuantity.Text = "";
                    txtWeight.Text = "";
                    cboRmk.Text = "";

                    dtpPDate.Focus();
                }

            }

        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select ep.AutoNo,PID as 'Production ID',PDate as 'Production Date',BType as 'Batch Type',ep.BNo as 'Batch No',ItemName as 'Item Name',cast(qty as decimal(10,2)) as Quantity,ep.rmk as 'Remarks' from EggProduction as ep, whs as w, ItemInfo as i, BatchInfo as b where i.ItemCode = ep.ItemCode and b.AutoNo = ep.BAutoNo");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboPID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboPID_Leave(null, null);
            cboComName.Focus();
        }
    }
}
