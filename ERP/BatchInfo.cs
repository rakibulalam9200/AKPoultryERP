using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
    public partial class BatchInfo : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string Qry;
        string checkqry;
        string EdtQry;
        public BatchInfo()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            if (cboBType.Text.Trim() == "")
            {
                ShowMessage("info", "Please, Select a Batch Type!!");
                cboComName.Focus();
                return;
            }

            SvCls.toGetData("select isnull(max(convert(numeric,BatchID)),100)+1 as BatchID from BatchInfo where bType = '"+ cboBType.Text.Trim() +"' and ISNUMERIC(BatchID) = 1");
            if (SvCls.GblRdrToGetData.Read())
            {
                cboBNo.Text = SvCls.GblRdrToGetData["BatchID"].ToString();
                txtChks.Select();
            }

            txtChks.Text = "";
            cboBName.Text = "";
            cboBLoc.Text = "";
            cboSLNo.Text = "";
            txtRmk.Text = "";
            txtChks.Text = "";
            txtChks.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboBNo.Text = "";
            cboBType.Text = "";
            cboBName.Text = "";
            cboBLoc.Text = "";
            cboSLNo.Text = "";
            txtRmk.Text = "";
            txtChks.Text = "";
            cboAutoNo.Text = "";
            cboComId.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }
        

        private void txtChks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBLoc.Select();
            }
        }

        private void cboChksType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBLoc.Select();
            }
        }
        
        private void cboBNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtChks.Select();
            }
        }

        private void cboBLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBName.Select();
            }
        }

        private void cboBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmk.Select();
            }
        }



        private void txtRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
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


            if (cboBNo.Text.Trim() == "")
            {
                MessageBox.Show("Batch ID  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBNo.Select();
                return;
            }

            if (cboBType.Text.Trim() == "")
            {
                MessageBox.Show("Chicks Type  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboBType.Select();
                return;
            }

            if (txtChks.Text.Trim() == "")
            {
                txtChks.Text = "0";
            }

            //SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            //if (SvCls.GblRdrToGetData.Read())
            //{
            //    cboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
            //}
            //else
            //{
            //    ShowMessage("info", "Invalid Company Name");
            //    return;
            //}

            Qry = "insert BatchInfo(ComId,BatchId,TotalChks,bType,BreedName,BLoc,rmk,sl,PcName,UserCode) values('" + cboComId.Text.Trim() + "','" + cboBNo.Text.Trim() + "'," + txtChks.Text.Trim() + ",'" + cboBType.Text.Trim() + "','" + cboBName.Text.Trim() + "','" + cboBLoc.Text.Trim() + "','" + txtRmk.Text.Trim() + "',0,'" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select BatchId from BatchInfo where BatchId = '" + cboBNo.Text.Trim() + "' and bType = '" + cboBType.Text.Trim() + "'";
            EdtQry = "update BatchInfo set ComId = '" + cboComId.Text.Trim() + "', TotalChks = " + txtChks.Text.Trim() + ", bType = '" + cboBType.Text.Trim() + "', BreedName = '" + cboBName.Text.Trim() + "',BLoc = '" + cboBLoc.Text.Trim() + "',rmk = '" + txtRmk.Text.Trim() + "', sl = 0, PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where BatchId = '" + cboBNo.Text.Trim() + "' and ComID = '" + cboComId.Text.Trim() + "'";

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
            // btnLoadCombo_Click(null, null);
            cboComName.Focus();

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

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select distinct ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select BatchId from BatchInfo where comid = '" + cboComId.Text.Trim() + "'";
            cboBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBNo.DisplayMember = "BatchId";
            cboBNo.Text = "";

            Qry = "select distinct BLoc from BatchInfo where BLoc != ''";
            cboBLoc.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBLoc.DisplayMember = "BLoc";
            cboBLoc.Text = "";

            Qry = "select distinct ChksType from BatchInfo  where ChksType != ''";
            cboBType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBType.DisplayMember = "ChksType";
            cboBType.Text = "";

            Qry = "select distinct BreedName from BatchInfo where BreedName != ''";
            cboBName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBName.DisplayMember = "BreedName";
            cboBName.Text = "";

            Qry = "select distinct SL from BatchInfo";
            cboSLNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSLNo.DisplayMember = "SL";
            cboSLNo.Text = "";

            Qry = "select AutoNo from BatchInfo";
            cboAutoNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboAutoNo.DisplayMember = "AutoNo";
            cboAutoNo.Text = "";

            Qry = "select distinct ComID from Company";
            cboComId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComId.DisplayMember = "ComID";
            cboComId.Text = "";

            txtChks.Text = "";
            txtRmk.Text = "";


        }

        private void Grid_Head()
        {
            
            lblShowTotal_TextChanged(null, null);
        }

        private void lblShowTotal_TextChanged(object sender, EventArgs e)
        {
            Qry = "select count(BatchId) as BatchId from BatchInfo";
            SvCls.toGetData(Qry);
            string lblMsg = "Total Record: ";

            if (SvCls.GblRdrToGetData.Read())
            {

                lblShowTotal.Text = lblMsg + SvCls.GblRdrToGetData["BatchId"].ToString();
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            //Grid.DataSource = SvCls.GblDataTable("select b.AutoNo as 'Auto No',bType as 'Batch Type', BatchId as 'Batch Id', cast(TotalChks as decimal(10,2)) as 'Total Chicks',  BreedName as 'Breed Name', BLoc as 'Breed Location',rmk as 'Remarks' from BatchInfo as b, Company as c where c.ComId = b.ComId");
            Grid.DataSource = SvCls.GblDataTable("select b.AutoNo as 'Auto No',bType as 'Batch Type', BatchId as 'Batch Id', cast(TotalChks as decimal(10,2)) as 'Total Chicks',  BreedName as 'Breed Name', BLoc as 'Breed Location',rmk as 'Remarks' from BatchInfo as b");
            Grid.Refresh();
            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
            //lblShowTotal_TextChanged(null, null);
        }

        private void frmBatch_Load(object sender, EventArgs e)
        {
            btnLoadGridData_Click(null, null);
            btnLoadCombo_Click(null, null);
            cboComName.Select();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboBType.Text.Trim() == "")
            {
                MessageBox.Show("Please, Select Batch Type...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBNo.Select();
                return;
            }

            checkqry = "select * from BatchInfo where BatchID = '" + cboBNo.Text.Trim() + "' and bType = '" + cboBType.Text.Trim() + "'";
            Qry = "delete from BatchInfo where BatchID = '" + cboBNo.Text.Trim() + "' and bType = '" + cboBType.Text.Trim() + "'";
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
               // btnLoadCombo_Click(null, null);

            }
        }

        private void cboBatchID_Leave(object sender, EventArgs e)
        {
            
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboBType.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboBNo.Text = Grid.Rows[i].Cells[2].Value.ToString();
            cboBNo_Leave(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void cboComName_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                cboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();

                Qry = "select BatchId from BatchInfo where comid = '"+cboComId.Text.Trim()+"'";
                cboBNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                cboBNo.DisplayMember = "BatchId";
                cboBNo.Text = "";

            }
        }

        private void cboBNo_Leave(object sender, EventArgs e)
        {
            if (cboBNo.Text.Trim() != "")
            {

                Qry = "select b.AutoNo,b.comID as ComID,ComName,cast(TotalChks as decimal(10,0)) as TotalChks,BreedName,BLoc,rmk,sl from Company as c,BatchInfo as b where BatchId = '" + cboBNo.Text.Trim() + "' and bType = '" + cboBType.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                    cboBLoc.Text = SvCls.GblRdrToGetData["BLoc"].ToString();
                    txtChks.Text = SvCls.GblRdrToGetData["TotalChks"].ToString();
                    cboBName.Text = SvCls.GblRdrToGetData["BreedName"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                    cboSLNo.Text = SvCls.GblRdrToGetData["sl"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    cboComId.Text = SvCls.GblRdrToGetData["ComID"].ToString();
                    txtChks.Focus();
                }
                else
                {
                    ShowMessage("not found", "");

                    cboBLoc.Text = "";
                    cboBName.Text = "";
                    txtRmk.Text = "";
                    txtChks.Text = "";
                    cboSLNo.Text = "";
                    cboBNo.Select();

                }

            }
        }
    }
}
