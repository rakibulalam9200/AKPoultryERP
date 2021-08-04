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
    public partial class Warehouse : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string Qry;
        string checkqry;
        string EdtQry;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboAutoNo.Text = "";
            cboCapacity.Text = "";
            cboWhsID.Text = "";
            cboAddress.Text = "";
            txtRmk.Text = "";
            txtWhsName.Text = "";
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

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void btnAddNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboCapacity.Select();
            }
        }

        private void cboWhsID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboCapacity.Select();
            }
        }

        private void txtWhsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAddress.Select();
            }
        }

       

        private void txtRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void cboCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtWhsName.Select();
            }
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select WhsId from Whs";
            cboWhsID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboWhsID.DisplayMember = "WhsId";
            cboWhsID.Text = "";

            Qry = "select Capacity from Whs";
            cboCapacity.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCapacity.DisplayMember = "Capacity";
            cboCapacity.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,WhsId)),100)+1 as WhsId from Whs where ISNUMERIC(WhsId) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboWhsID.Text = SvCls.GblRdrToGetData["WhsId"].ToString();
                SvCls.GblCon.Close();
            }

            cboAutoNo.Text = "";
            cboCapacity.Text = "";
            cboAddress.Text = "";
            txtRmk.Text = "";
            txtWhsName.Text = "";
            cboCapacity.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboWhsID.Text.Trim() == "")
            {
                MessageBox.Show("Warehouse ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboWhsID.Select();
                return;
            }

            if (txtWhsName.Text.Trim() == "")
            {
                MessageBox.Show("Warehouse Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtWhsName.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ComID = SvCls.GblRdrToGetData["ComId"].ToString();
            }

            else
            {
                ShowMessage("info", "Blank or Invalid Company Name!!!");
                cboComName.Select();
                return;
            }

            Qry = "insert Whs(ComId,WhsId,WhsName,WhsAddress,Capacity,Rmk,UserCode,PcName) values ('"+ComID+"','"+cboWhsID.Text.Trim()+"','"+txtWhsName.Text.Trim()+"','"+cboAddress.Text.Trim()+"','"+cboCapacity.Text.Trim()+"','"+txtRmk.Text.Trim()+"','" + ClsVar.GblUserId + "','" + ClsVar.GblPcName+"')";
            checkqry = "select WhsName,WhsAddress FROM Whs where WhsId = '"+cboWhsID.Text.Trim()+"'";
            EdtQry = "update Whs set ComId = '"+ComID+"', WhsName = '" + txtWhsName.Text.Trim() + "', WhsAddress = '" + cboAddress.Text.Trim() + "', Capacity = '" + cboCapacity.Text.Trim() + "', Rmk = '" + txtRmk.Text.Trim()+ "', UserCode = '" + ClsVar.GblUserId + "', PcName = '" + ClsVar.GblPcName+"'  where WhsId = '"+cboWhsID.Text.Trim()+"'";


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

        private void cboAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmk.Select();
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select AutoNo,WhsId as 'Warehouse ID',WhsName as 'Warehouse Name',WhsAddress as 'Address',Capacity as 'Capacity',Rmk as 'Remarks' from Whs");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboWhsID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Warehouse ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboWhsID.Select();
                return;
            }


            checkqry = "select * from Whs where WhsID = '" + cboWhsID.Text.Trim() + "'";
            Qry = "delete from Whs where WhsID = '" + cboWhsID.Text.Trim() + "'";
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

        private void Warehouse_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboWhsID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboWhsID_Leave(null, null);
            cboComName.Focus();
        }

        private void cboWhsID_Leave(object sender, EventArgs e)
        {
            if (cboWhsID.Text.Trim() != "")
            {

                Qry = "select AutoNo,WhsId,WhsName,WhsAddress,Capacity,Rmk,ComId from Whs where WhsID = '" + cboWhsID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {

                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboWhsID.Text = SvCls.GblRdrToGetData["WhsID"].ToString();
                    cboCapacity.Text = SvCls.GblRdrToGetData["Capacity"].ToString();
                    cboAddress.Text = SvCls.GblRdrToGetData["WhsAddress"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    txtWhsName.Text = SvCls.GblRdrToGetData["WhsName"].ToString();
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

                }
                else
                {
                    ShowMessage("not found", "");
                    cboAutoNo.Text = "";
                    cboCapacity.Text = "";
                    cboAddress.Text = "";
                    txtRmk.Text = "";
                    txtWhsName.Text = "";
                    cboWhsID.Focus();
                }

            }
        }
    }
}
