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
    public partial class Designation : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        public Designation()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboDesID.Text = "";
            txtName.Text = "";
            txtBName.Text = "";
            txtRmk.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,DID)),100)+1 as DID from Designation where ISNUMERIC(DID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboDesID.Text = SvCls.GblRdrToGetData["DID"].ToString();
                SvCls.GblCon.Close();
            }

            txtName.Text = "";
            txtBName.Text = "";
            txtRmk.Text = "";
            txtName.Focus();
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select DID from Designation";
            cboDesID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboDesID.DisplayMember = "DID";
            cboDesID.Text = "";
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void cboDesID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtName.Select();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBName.Select();
            }
        }

        private void txtBName_KeyPress(object sender, KeyPressEventArgs e)
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboDesID.Text.Trim() == "")
            {
                MessageBox.Show("Designation ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboDesID.Select();
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Designation Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtName.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ComID = SvCls.GblRdrToGetData["ComId"].ToString();
            }

            Qry = "insert Designation(DID,name,Bname,Rmk,SlNo,ComId,PcName,UserCode) values('"+cboDesID.Text.Trim()+"','"+txtName.Text.Trim()+"','"+txtBName.Text.Trim()+"','"+txtRmk.Text.Trim()+"','"+cboSLNo.Text.Trim()+"','"+ComID+ "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select Name from Designation where DID = '"+cboDesID.Text.Trim()+"'";
            EdtQry = "update Designation set name = '"+txtName.Text.Trim()+"',Bname = '"+txtBName.Text.Trim()+"',Rmk = '"+txtRmk.Text.Trim()+"',SlNo = '"+cboSLNo.Text.Trim()+"',ComId = '"+ComID+"',PcName = '"+ClsVar.GblPcName+"',UserCode = '"+ClsVar.GblUserId+"' where DID = '"+cboDesID.Text.Trim()+"'";


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

        private void Designation_Load(object sender, EventArgs e)
        {
            cboComName.Focus();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
        }

        private void cboDesID_Leave(object sender, EventArgs e)
        {
            if (cboDesID.Text.Trim() != "")
            {

                Qry = "select AutoNo,DID,name,Bname,Rmk,SlNo,ComId from Designation where DID = '"+cboDesID.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboDesID.Text = SvCls.GblRdrToGetData["DID"].ToString();
                    txtName.Text = SvCls.GblRdrToGetData["name"].ToString();
                    txtBName.Text = SvCls.GblRdrToGetData["Bname"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    cboSLNo.Text = SvCls.GblRdrToGetData["SLNo"].ToString();

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

                }
                else
                {
                    ShowMessage("not found", "");
                    txtName.Text = "";
                    txtBName.Text = "";
                    txtRmk.Text = "";
                    cboSLNo.Text = "";
                    cboDesID.Focus();

                }

            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select AutoNo,DID as 'Designation ID',Name as 'Name',BName as 'Bangla Name',Rmk as 'Remarks' from Designation");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboDesID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Designation ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDesID.Select();
                return;
            }


            checkqry = "select * from Designation where DID = '" + cboDesID.Text.Trim() + "'";
            Qry = "delete from Designation where DID = '" + cboDesID.Text.Trim() + "'";
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

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboDesID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboDesID_Leave(null, null);
            cboComName.Focus();
        }

       
    }
}
