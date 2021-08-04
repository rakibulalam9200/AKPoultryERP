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
    public partial class ResInfo : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string Qry;
        string checkqry;
        string EdtQry;
        public ResInfo()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboResID.Text = "";
            cboResType.Text = "";
            cboResName.Text = "";
            cboEmpID.Text = "";
            txtResPerson.Text = "";
            txtPhone.Text = "";
            cboDivision.Text = "";
            cboZila.Text = "";
            cboUpazila.Text = "";
            cboUnion.Text = "";
            btnAddNew.Select();
        }

        private void cboResID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboResName.Select();
            }
        }

        private void cboResName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboResType.Select();
            }
        }



        private void cboEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtResPerson.Select();
            }
        }

        private void txtResPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPhone.Select();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDivision.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDivision.Select();
            }
        }

        private void cboDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboZila.Select();
            }
        }

        private void cboZila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUpazila.Select();
            }
        }

        private void cboUpazila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUnion.Select();
            }
        }

        private void cboUnion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,ResID)),100)+1 as ResID from ResInfo where ISNUMERIC(ResID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboResID.Text = SvCls.GblRdrToGetData["ResID"].ToString();
                SvCls.GblCon.Close();
                cboResName.Focus();
            }

            cboResName.Text = "";
            cboResType.Text = "";
            cboEmpID.Text = "";
            txtResPerson.Text = "";
            txtPhone.Text = "";
            cboDivision.Text = "";
            cboZila.Text = "";
            cboUpazila.Text = "";
            cboUnion.Text = "";
            cboResName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboResID.Text.Trim() == "")
            {
                MessageBox.Show("Responsibility ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboResID.Select();
                return;
            }

            if (cboResType.Text.Trim() == "")
            {
                MessageBox.Show("Please, Select Responsibility Type", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboResType.Select();
                return;
            }


            if (cboResName.Text.Trim() == "")
            {
                MessageBox.Show("Responsibility Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboResName.Select();
                return;
            }


            Qry = "insert ResInfo(ResID,ResName,ResType,EmpId,ResPerson,Phone,Division,Zila,Upazila,Uneon,PcName,UserCode) values ('" + cboResID.Text.Trim() + "','" + cboResName.Text.Trim() + "','" + cboResType.Text.Trim() + "','" + cboEmpID.Text.Trim() + "','" + txtResPerson.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + cboDivision.Text.Trim() + "','" + cboZila.Text.Trim() + "','" + cboUpazila.Text.Trim() + "','" + cboUnion.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select ResID,ResName from ResInfo where ResID = '" + cboResID.Text.Trim() + "'";
            EdtQry = "update ResInfo set ResType = '"+ cboResType.Text.Trim() +"', ResName = '" + cboResName.Text.Trim() + "',ResPerson = '" + txtResPerson.Text.Trim() + "', Phone = '" + txtPhone.Text.Trim() + "', Division = '" + cboDivision.Text.Trim() + "',Zila = '" + cboZila.Text.Trim() + "',Upazila = '" + cboUpazila.Text.Trim() + "',Uneon = '" + cboUnion.Text.Trim() + "',PcName = 'MyPc',UserCode = 'userCode' where ResID = '" + cboResID.Text.Trim() + "'";

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

            btnAddNew.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboResID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Valid Responsiblity Name...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboResName.Select();
                return;
            }


            checkqry = "select * from ResInfo where ResID = '" + cboResID.Text.Trim() + "'";
            Qry = "delete from ResInfo where ResID = '" + cboResID.Text.Trim() + "'";
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
            }
        }

        private void cboEmpID_Leave(object sender, EventArgs e)
        {
            if (cboEmpID.Text.Trim() != "")
            {

                Qry = "select AutoNo,EmpID, EmpName,Phone,Division,Zila,Upzilla,Uneon from Employee where EmpID = '" + cboEmpID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    txtResPerson.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                    txtPhone.Text = SvCls.GblRdrToGetData["Phone"].ToString();

                    cboDivision.Text = SvCls.GblRdrToGetData["Division"].ToString();
                    cboZila.Text = SvCls.GblRdrToGetData["Zila"].ToString();
                    cboUpazila.Text = SvCls.GblRdrToGetData["Upzilla"].ToString();
                    cboUnion.Text = SvCls.GblRdrToGetData["Uneon"].ToString();
                    btnSave.Focus();
                }
                else
                {
                    ShowMessage("not found", "");
                    txtResPerson.Text = "";
                    txtPhone.Text = "";
                    cboDivision.Text = "";
                    cboZila.Text = "";
                    cboUpazila.Text = "";
                    cboUnion.Text = "";
                    cboEmpID.Focus();
                }

            }
        }

        private void cboResID_Leave(object sender, EventArgs e)
        {
            if (cboResID.Text.Trim() != "")
            {

                Qry = "select autoNo,ResName, ResType, EmpID, ResPerson,Phone, Division,Zila,Upazila,Uneon from ResInfo where ResId = '" + cboResID.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboAutoNo.Text = SvCls.GblRdrToGetData["autoNo"].ToString();
                    cboResName.Text = SvCls.GblRdrToGetData["ResName"].ToString();
                    cboResType.Text = SvCls.GblRdrToGetData["ResType"].ToString();
                    cboEmpID.Text = SvCls.GblRdrToGetData["EmpID"].ToString();
                    txtResPerson.Text = SvCls.GblRdrToGetData["ResPerson"].ToString();
                    txtPhone.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                    cboDivision.Text = SvCls.GblRdrToGetData["Division"].ToString();
                    cboZila.Text = SvCls.GblRdrToGetData["Zila"].ToString();
                    cboUpazila.Text = SvCls.GblRdrToGetData["Upazila"].ToString();
                    cboUnion.Text = SvCls.GblRdrToGetData["Uneon"].ToString();

                }
                else
                {
                    ShowMessage("not found", "");
                    cboResName.Text = "";
                    cboResType.Text = "";
                    cboEmpID.Text = "";
                    txtResPerson.Text = "";
                    txtPhone.Text = "";
                    cboDivision.Text = "";
                    cboZila.Text = "";
                    cboUpazila.Text = "";
                    cboUnion.Text = "";
                    cboResID.Focus();

                }

            }
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select distinct ResName from ResInfo";
            cboResName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboResName.DisplayMember = "ResName";
            cboResName.Text = "";

            Qry = "select distinct ResID from ResInfo";
            cboResID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboResID.DisplayMember = "ResID";
            cboResID.Text = "";

            Qry = "select empID from Employee";
            cboEmpID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboEmpID.DisplayMember = "empID";
            cboEmpID.Text = "";

            Qry = "SELECT  distinct Division FROM ResInfo order by Division";
            cboDivision.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboDivision.DisplayMember = "Division";
            cboDivision.Text = "";

            Qry = "SELECT  distinct Zila FROM ResInfo order by Zila";
            cboZila.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboZila.DisplayMember = "Zila";
            cboZila.Text = "";

            Qry = "SELECT  distinct Upazila as 'Upzilla' FROM ResInfo order by Upzilla";
            cboUpazila.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboUpazila.DisplayMember = "Upzilla";
            cboUpazila.Text = "";

            Qry = "SELECT  distinct Uneon FROM ResInfo order by Uneon";
            cboUnion.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboUnion.DisplayMember = "Uneon";
            cboUnion.Text = "";

            Qry = "SELECT  AutoNo FROM ResInfo";
            cboAutoNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboAutoNo.DisplayMember = "AutoNo";
            cboAutoNo.Text = "";
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select autoNo as 'Auto No',ResID as 'ID', ResName as 'Responsibility Name', ResType as Type, EmpID as 'Employee ID', ResPerson as 'Person Name',Phone, Division,Zila as 'District',Upazila,Uneon as 'Union' from ResInfo");
            Grid.Refresh();

           
            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void Responsibility_Load(object sender, EventArgs e)
        {
            btnAddNew.Focus();
            btnLoadGridData_Click(null, null);
            btnLoadCombo_Click(null, null);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboResID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboResID_Leave(null, null);
            cboResName.Focus();
        }

        private void cboResType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboEmpID.Select();
            }
        }

        private void btnSrcEmployee_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 40);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select EmpId as 'Employee ID',EmpName as 'Name',Phone,Division,Zila as 'District',Upzilla,Uneon as 'Union' from Employee");
            GridSrc.Refresh();
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void GridSrc_DoubleClick(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
            int i;
            i = GridSrc.SelectedCells[0].RowIndex;
            cboEmpID.Text = GridSrc.Rows[i].Cells[0].Value.ToString();
            cboEmpID_Leave(null, null);
            btnSave.Focus();
        }

        private void txtSrcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            GridSrc.DataSource = SvCls.GblDataTable("select EmpId as 'Employee ID',EmpName as 'Name',Phone,Division,Zila as 'District',Upzilla,Uneon as 'Union' from Employee where  EmpID LIKE '%"+ txtSrcText.Text.Trim()+ "%'  or EmpName LIKE '%" + txtSrcText.Text.Trim() + "%' or Phone LIKE '%" + txtSrcText.Text.Trim() + "%'");
            GridSrc.Refresh();
        }
    }
}
