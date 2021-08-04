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
    public partial class EggSetting : Form
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
        double perc = 0.0;


        public EggSetting()
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

        private void EggSetting_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
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

            Qry = "select distinct ItemName from ItemInfo";
            cboIName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboIName.DisplayMember = "ItemName";
            cboIName.Text = "";

            Qry = "select distinct BType from BatchInfo";
            cboBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBType.DisplayMember = "BType";
            cboBType.Text = "";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAutoNo.Text = "";
            cboComName.Text = "";
            cboSetID.Text = "";
            dtpSDate.Text = DateTime.Today.ToString();
            cboIName.Text = "";
            cboIType.Text = "";
            cboMNo.Text = "";
            cboSNo.Text = "";
            cboBNo.Text = "";
            cboBType.Text = "";
            cboRmk.Text = "";
            dtpACP.Text = DateTime.Today.ToString();
            txtProdQty.Text = "";
            txtSQty.Text = "";
            txtTendPerc.Text = "";

        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SetID)),100)+1 as SetID from EggSetting");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSetID.Text = SvCls.GblRdrToGetData["SetID"].ToString();
                SvCls.GblCon.Close();
            }
            dtpSDate.Text = DateTime.Today.ToString();
            cboIName.Text = "";
            cboIType.Text = "";
            cboMNo.Text = "";
            cboSNo.Text = "";
            cboBNo.Text = "";
            cboBType.Text = "";
            cboRmk.Text = "";
            dtpACP.Text = DateTime.Today.ToString();
            txtProdQty.Text = "";
            txtSQty.Text = "";
            txtTendPerc.Text = "";
            dtpSDate.Select();
        }

        private void cboSetID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpSDate.Select();
            }
        }

        private void dtpSDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboIName.Select();
            }
        }

        private void cboIName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSNo.Select();
            }
        }

        private void cboIType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSNo.Select();
            }
        }

        private void cboSNo_KeyPress(object sender, KeyPressEventArgs e)
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
                cboMNo.Select();
            }
        }

        private void cboMNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSQty.Select();
            }
        }

        private void txtSQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpACP.Select();
            }
        }

        private void dtpACP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtProdQty.Select();
            }
        }

        private void txtProdQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRmk.Select();
            }
        }

        private void txtTendPerc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cboIName_Leave(object sender, EventArgs e)
        {
            if (cboIName.Text.Trim() != "")
            {
                SvCls.toGetData("select IGroup from ItemInfo WHERE ItemName = '" + cboIName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboIType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboIName.Select();
                    return;
                }
            }
        }

        private void cboBNo_Leave(object sender, EventArgs e)
        {
            
        }

        private void cboBType_Leave(object sender, EventArgs e)
        {
            Qry = "select BatchId from BatchInfo where  Btype  = '" + cboBType.Text.Trim() + "'";
            cboBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBNo.DisplayMember = "BatchId";
            cboBNo.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboComName.Select();
                return;
            }

            if (cboSetID.Text.Trim() == "")
            {
                MessageBox.Show("Egg Setting ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboSetID.Select();
                return;
            }

            if (cboIName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboIName.Select();
                return;
            }

            if (cboSNo.Text.Trim() == "")
            {
                MessageBox.Show("Setting No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboSNo.Select();
                return;
            }

            if (cboBType.Text.Trim() == "")
            {
                MessageBox.Show("Batch Type Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBType.Select();
                return;
            }

            if (cboBType.Text.Trim() == "")
            {
                MessageBox.Show("Batch Type Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBType.Select();
                return;
            }

            if (cboBNo.Text.Trim() == "")
            {
                MessageBox.Show("Batch No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBNo.Select();
                return;
            }

            if (cboMNo.Text.Trim() == "")
            {
                MessageBox.Show("Machine No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboMNo.Select();
                return;
            }

            if (txtSQty.Text.Trim() == "")
            {
                MessageBox.Show("Setting Quantity Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSQty.Select();
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

            if (cboIName.Text.Trim() != "")
            {
                SvCls.toGetData("select ItemCode from ItemInfo WHERE ItemName = '" + cboIName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ItemCode = SvCls.GblRdrToGetData["ItemCode"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboIName.Select();
                    return;
                }
            }

            if (cboIType.Text.Trim() != "")
            {
                SvCls.toGetData("select IGroup from ItemInfo where ItemName = '" + cboIName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboIType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Group!!!");
                    cboIType.Select();
                    return;
                }
            }

            if (cboBNo.Text.Trim() != "")
            {
                SvCls.toGetData("select BatchId,AutoNo from BatchInfo where  Btype  = '" + cboBType.Text.Trim() + "' and BatchId = '" + cboBNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    BAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["AutoNo"].ToString());
                }
                else
                {
                    ShowMessage("info", "Invalid Batch No!!!");
                    cboBNo.Select();
                    return;
                }
            }

            if(txtProdQty.Text.Trim() == "")
            {
                txtProdQty.Text = 0.ToString();
            }

            if(txtTendPerc.Text.Trim() == "")
            {
                txtTendPerc.Text = 0.ToString();
            }

            Qry = "insert EggSetting(ComId, SetID,SDate,ItemCode,BNo,SNo,MNo,qty,AppProdDt,ProdQty,TendPerc,rmk,BAutoNo,PcName,UserCode) values ('"+ComID+"','"+cboSetID.Text.Trim()+"',CONVERT(datetime,'"+dtpSDate.Text.Trim()+"',103),'"+ItemCode+"','"+cboBNo.Text.Trim()+"','"+cboSNo.Text.Trim()+"','"+cboMNo.Text.Trim()+"',"+txtSQty.Text.Trim()+",CONVERT(datetime,'"+dtpACP.Text.Trim()+"',103),"+txtProdQty.Text.Trim()+","+txtTendPerc.Text.Trim()+",'"+cboRmk.Text.Trim()+"','"+BAutoNo+"','"+ClsVar.GblPcName+"','"+ClsVar.GblUserId+"')";
            checkqry = "Select SDate,SNo from EggSetting where SetID = '" + cboSetID.Text.Trim() + "'";
            EdtQry = "update EggProduction set ComId='" + ComID + "',SDate = Convert(datetime,'" + dtpSDate.Text.Trim() + "',103),ItemCode = '" + ItemCode + "',BNo = '" + cboBNo.Text.Trim() + "',SNo = '" + cboSNo.Text.Trim() + "',MNo = '" + cboMNo.Text.Trim() + "',qty = "+txtSQty.Text.Trim()+",AppProdDt = Convert(datetime,'" + dtpACP.Text.Trim() + "',103),ProdQty = "+txtProdQty.Text.Trim()+",TendPerc = "+txtTendPerc.Text.Trim()+",,rmk = '" + cboRmk.Text.Trim() + "',BAutoNo = '" + BAutoNo + "',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where SetID = '" + cboSetID.Text.Trim() + "'";

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

        private void calculation()
        {
            if (txtSQty.Text == "" && txtProdQty.Text == "")
            {
                perc = 0.0;
            }

            if (txtSQty.Text != "" && txtProdQty.Text == "")
            {
                perc = 0.0;
            }
            if (txtSQty.Text != "" && txtProdQty.Text != "")
            {
                perc = Convert.ToDouble(txtProdQty.Text.Trim()) / Convert.ToDouble(txtSQty.Text.Trim()) * 100;
            }
            if (perc != 0)
            {
                txtTendPerc.Text = perc.ToString("#.00");
            }
            else
            {
                txtTendPerc.Text = perc.ToString();
            }
        }

        private void txtSQty_Leave(object sender, EventArgs e)
        {
            calculation();
        }

        private void txtProdQty_Leave(object sender, EventArgs e)
        {
            calculation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboSetID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Setting ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSetID.Select();
                return;
            }


            checkqry = "select SDate,SNo from EggSetting where SetID = '" + cboSetID.Text.Trim() + "'";
            Qry = "delete from EggSetting where SetID = '" + cboSetID.Text.Trim() + "'";
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

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select es.AutoNo,SetID as 'Setting ID',BType as 'Batch Type',es.BNo as 'Batch No',SDate as 'Date',ItemName as 'Item Name',Cast(qty as decimal(10,0)) as 'Quantity',SNO as 'Setting No',AppProdDt as 'AppProd. Date', cast(ProdQty as decimal(10,0)) as 'App. Quantity', MNO as 'Mach No' from EggSetting as es,ItemInfo as i, BatchInfo as b where i.ItemCode = es.ItemCode and b.AutoNo = es.BAutoNo");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void cboSetID_Leave(object sender, EventArgs e)
        {
            if (cboSetID.Text.Trim() != "")
            {

                Qry = "select AutoNo,ComId,SDate,ItemCode,BNo,SNo,MNo,qty,AppProdDt,ProdQty,TendPerc,rmk,BAutoNo from EggSetting where SetID = '" + cboSetID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    dtpSDate.Text = SvCls.GblRdrToGetData["SDate"].ToString();
                    ItemCode = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    cboBNo.Text = SvCls.GblRdrToGetData["BNo"].ToString();
                    cboSNo.Text = SvCls.GblRdrToGetData["SNo"].ToString();
                    cboMNo.Text = SvCls.GblRdrToGetData["MNo"].ToString();
                    
                    cboRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    
                    dtpACP.Text = SvCls.GblRdrToGetData["AppProdDt"].ToString();
                    txtProdQty.Text = SvCls.GblRdrToGetData["ProdQty"].ToString();
                    txtTendPerc.Text = SvCls.GblRdrToGetData["TendPerc"].ToString();
                    txtSQty.Text = SvCls.GblRdrToGetData["qty"].ToString();
                 
                    BAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["BAutoNo"].ToString());
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();


                   

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
                        cboIName.Text = SvCls.GblRdrToGetData["ItemName"].ToString();
                        cboIType.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    }

                    else
                    {
                        cboIName.Text = "";
                        cboIType.Text = "";
                    }

                    Qry = "select BType from BatchInfo where AutoNo = '" + BAutoNo + "'";
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
                    dtpSDate.Text = DateTime.Today.ToString();
                    cboIName.Text = "";
                    cboIType.Text = "";
                    cboMNo.Text = "";
                    cboSNo.Text = "";
                    cboBNo.Text = "";
                    cboBType.Text = "";
                    cboRmk.Text = "";
                    dtpACP.Text = DateTime.Today.ToString();
                    txtProdQty.Text = "";
                    txtSQty.Text = "";
                    txtTendPerc.Text = "";

                    dtpSDate.Focus();
                }

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboSetID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboSetID_Leave(null, null);
            cboComName.Focus();
        }
    }
}
