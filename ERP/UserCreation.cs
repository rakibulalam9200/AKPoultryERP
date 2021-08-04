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
    public partial class UserCreation : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        public UserCreation()
        {
            InitializeComponent();
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboEmpID.Text = "";
            txtDisName.Text = "";
            cboUserID.Text = "";
            txtUserName.Text = "";
            txtPwd.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,UserID)),100)+1 as UserID from LoginUser where ISNUMERIC(UserID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboUserID.Text = SvCls.GblRdrToGetData["UserID"].ToString();
                SvCls.GblCon.Close();
            }

            txtDisName.Text = "";
            txtUserName.Text = "";
            txtPwd.Text = "";
            cboEmpID.Focus();
        }

        private void UserCreation_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);

        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select EmpID from Employee";
            cboEmpID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboEmpID.DisplayMember = "EmpID";
            cboEmpID.Text = "";

            Qry = "select UserID from LoginUser";
            cboUserID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboUserID.DisplayMember = "UserID";
            cboUserID.Text = "";


            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";
        }

        private void cboEmpID_Leave(object sender, EventArgs e)
        {
            if (cboEmpID.Text.Trim() != "")
            {

                SvCls.toGetData("select EmpID,EmpName from Employee where EmpID = '" + cboEmpID.Text.Trim() + "'");

                if (SvCls.GblRdrToGetData.Read())
                {
                    txtDisName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                }

                else
                {
                    MessageBox.Show("Enter Valid Employee ID", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboEmpID.Select();
                    return;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void cboEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDisName.Select();
            }
        }

        private void cboUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboEmpID.Select();
            }
        }

        private void txtDisName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUserName.Select();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPwd.Select();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
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
            if (cboUserID.Text.Trim() == "")
            {
                MessageBox.Show("User ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboUserID.Select();
                return;
            }

            if (txtDisName.Text.Trim() == "")
            {
                MessageBox.Show("Display Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDisName.Select();
                return;
            }

            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("UserName Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUserName.Select();
                return;
            }

            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Password Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPwd.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ComID = SvCls.GblRdrToGetData["ComId"].ToString();
            }
            

            Qry = "insert LoginUser(ComId,UserID,empID,DisplayName,UserName,pwd,PcName,UserCode) values ('"+ ComID + "','"+ cboUserID.Text.Trim()+ "','"+cboEmpID.Text.Trim()+"','"+txtDisName.Text.Trim()+"','"+txtUserName.Text.Trim()+"','"+txtPwd.Text.Trim()+"','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select ComId,UserName from LoginUser where UserID = '" + cboUserID.Text.Trim() + "'";
            EdtQry = "update LoginUser set ComId = '" + ComID + "',empID = '"+cboEmpID.Text.Trim()+"',DisplayName = '"+txtDisName.Text.Trim()+"',UserName = '"+txtUserName.Text.Trim()+"',pwd = '"+txtPwd.Text.Trim()+"',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "'  where UserID = '" + cboUserID.Text.Trim() + "'";

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
            if (cboUserID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid User ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboUserID.Select();
                return;
            }


            checkqry = "select * from LoginUser where UserID = '" + cboUserID.Text.Trim() + "'";
            Qry = "delete from LoginUser where UserID = '" + cboUserID.Text.Trim() + "'";
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

        private void cboUserID_Leave(object sender, EventArgs e)
        {
            if (cboUserID.Text.Trim() != "")
            {

                Qry = "select AutoNo,ComId,UserID,empID,DisplayName,UserName,pwd,PcName,UserCode from LoginUser where UserID = '"+cboUserID.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {    
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboEmpID.Text = SvCls.GblRdrToGetData["empID"].ToString();
                    txtDisName.Text = SvCls.GblRdrToGetData["DisplayName"].ToString();
                    txtUserName.Text = SvCls.GblRdrToGetData["UserName"].ToString();
                    txtPwd.Text = SvCls.GblRdrToGetData["pwd"].ToString();

                    Qry = "select ComName from Company where ComId = '"+ComID+"'";
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
                    cboEmpID.Text = "";
                    txtDisName.Text = "";
                    txtUserName.Text = "";
                    txtPwd.Text = "";
                    cboComName.Focus();

                }

            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select AutoNo,UserID as 'User ID',empID as 'Employee ID',DisplayName as 'Display Name',UserName as 'User Name' from LoginUser");
            Grid.Refresh();

            //select u.AutoNo,ComName,UserID as 'User ID',empID as 'Employee ID',DisplayName as 'Display Name',UserName as 'User Name' from LoginUser as u,Company as c where c.ComId = u.ComId
            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboUserID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboUserID_Leave(null, null);
            cboComName.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
