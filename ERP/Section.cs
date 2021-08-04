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
    public partial class Section : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        public Section()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboSecID.Text = "";
            txtName.Text = "";
            txtBName.Text = "";
            txtRmk.Text = "";
        }

        private void Section_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select AutoNo,SecID as 'Section ID',Name as 'Name',BName as 'Bangla Name',Rmk as 'Remarks' from Section");
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

            Qry = "select SecID from Section";
            cboSecID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSecID.DisplayMember = "SecID";
            cboSecID.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SecID)),100)+1 as SecID from Section where ISNUMERIC(SecID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSecID.Text = SvCls.GblRdrToGetData["SecID"].ToString();
                SvCls.GblCon.Close();
            }

            txtName.Text = "";
            txtBName.Text = "";
            txtRmk.Text = "";
            txtName.Focus();
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
            if (cboSecID.Text.Trim() == "")
            {
                MessageBox.Show("Section ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboSecID.Select();
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Section Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtName.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ComID = SvCls.GblRdrToGetData["ComId"].ToString();
            }

            Qry = "insert Section(SecID,name,Bname,Rmk,SlNo,ComId,PcName,UserCode) values('" + cboSecID.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtBName.Text.Trim() + "','" + txtRmk.Text.Trim() + "','" + cboSLNo.Text.Trim() + "','" + ComID + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select Name from Section where SecID = '" + cboSecID.Text.Trim() + "'";
            EdtQry = "update Section set name = '" + txtName.Text.Trim() + "',Bname = '" + txtBName.Text.Trim() + "',Rmk = '" + txtRmk.Text.Trim() + "',SlNo = '" + cboSLNo.Text.Trim() + "',ComId = '" + ComID + "',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where SecID= '" + cboSecID.Text.Trim() + "'";


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
            if (cboSecID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Section ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSecID.Select();
                return;
            }


            checkqry = "select * from Section where SecID = '" + cboSecID.Text.Trim() + "'";
            Qry = "delete from Section where SecID = '" + cboSecID.Text.Trim() + "'";
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

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
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

        private void cboSecID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtName.Select();
            }
        }

        private void cboSecID_Leave(object sender, EventArgs e)
        {
            if (cboSecID.Text.Trim() != "")
            {

                Qry = "select AutoNo,SecID,name,Bname,Rmk,SlNo,ComId from Section where SecID = '" + cboSecID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboSecID.Text = SvCls.GblRdrToGetData["SecID"].ToString();
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
                    cboSecID.Focus();

                }

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboSecID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboSecID_Leave(null, null);
            cboComName.Focus();
        }
    }
}
