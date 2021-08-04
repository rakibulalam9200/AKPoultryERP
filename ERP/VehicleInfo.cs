using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ERP
{
    public partial class VehicleInfo : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";
        public VehicleInfo()
        {
            InitializeComponent();
        }

        private void VehicleInfo_Load(object sender, EventArgs e)
        {
            btnAddNew.Select();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboVID.Text = "";
            cboVNo.Text = "";
            cboVType.Text = "";
            cboVIN.Text = "";
            cboVPN.Text = "";
            cboVRmk.Text = "";
            dtpResDate.Text = DateTime.Today.ToString();
            dtpLicExpDate.Text = DateTime.Today.ToString();

            cboDID.Text = "";
            cboDName.Text = "";
            cboDRmk.Text = "";

            cboHID.Text = "";
            cboHName.Text = "";
            cboHRmk.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,VID)),100)+1 as VID from VehicleInfo where ISNUMERIC(VID) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboVID.Text = SvCls.GblRdrToGetData["VID"].ToString();
                SvCls.GblCon.Close();
            }

            
            cboVNo.Text = "";
            cboVType.Text = "";
            cboVIN.Text = "";
            cboVPN.Text = "";
            cboVRmk.Text = "";
            dtpResDate.Text = DateTime.Today.ToString();
            dtpLicExpDate.Text = DateTime.Today.ToString();

            cboDID.Text = "";
            cboDName.Text = "";
            cboDRmk.Text = "";

            cboHID.Text = "";
            cboHName.Text = "";
            cboHRmk.Text = "";
            cboVNo.Focus();
        }

        private void cboVID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVNo.Select();
            }
        }

        private void cboVNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVType.Select();
            }
        }

        private void cboVType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpResDate.Select();
            }
        }

        private void dtpResDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpLicExpDate.Select();
            }
        }

        private void dtpLicExpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVIN.Select();
            }
        }

        private void cboVIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVPN.Select();
            }
        }

        private void cboPlateNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboVRmk.Select();
            }
        }

        private void cboVRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDID.Select();
            }
        }

        private void cboDID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDRmk.Select();
            }
        }

        private void cboDRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboHID.Select();
            }
        }

        private void cboHID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboHRmk.Select();
            }
        }

        private void cboHRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboVID.Text.Trim() == "")
            {
                MessageBox.Show("Vechicle ID  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboVID.Select();
                return;
            }

            if (cboVNo.Text.Trim() == "")
            {
                MessageBox.Show("Vechicle No  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboVNo.Select();
                return;
            }

            if (cboVType.Text.Trim() == "")
            {
                MessageBox.Show("Vechile Type  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboVType.Select();
                return;
            }

            if (cboVPN.Text.Trim() == "")
            {
                MessageBox.Show("Plate No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboVPN.Select();
                return;
            }
            if (cboVIN.Text.Trim() == "")
            {
                MessageBox.Show("Identification No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboVIN.Select();
                return;
            }

            if (cboDID.Text.Trim() == "")
            {
                MessageBox.Show("Driver ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboDID.Select();
                return;
            }


            SvCls.toGetData("select VNo from VehicleInfo where VNo = '"+cboVNo.Text.Trim()+"'");

            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Vechicle No  Can't Be Duplicate", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVNo.Select();
                return;
            }

            SvCls.toGetData("select VIN from VehicleInfo where VIN = '" + cboVIN.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Vechicle Identifiation No  Can't Be Duplicate", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVIN.Select();
                return;
            }

            SvCls.toGetData("select VPN from VehicleInfo where VPN = '" + cboVPN.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Vehicle Plate No Can't Be Duplicate", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVPN.Select();
                return;
            }

            Qry = "insert VehicleInfo(VID, VNo,Vtype,RegDate,LicExpDate,VIN,VPN,VRmk,DrvEmpID,DRmk,HlprEmpID,HRmk,PcName,UserCode) values ('" + cboVID.Text.Trim() + "','" + cboVNo.Text.Trim() + "','" + cboVType.Text.Trim() + "',CONVERT(datetime,'" + dtpResDate.Text.Trim() + "',103),CONVERT(datetime,'" + dtpLicExpDate.Text.Trim() + "',103),'" + cboVIN.Text.Trim() + "','" + cboVPN.Text.Trim() + "','" + cboVRmk.Text.Trim() + "','" + cboDID.Text.Trim() + "','" + cboDRmk.Text.Trim() + "','" + cboHID.Text.Trim() + "','" + cboHRmk.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            checkqry = "select VNo,Vtype from VehicleInfo where VID = '" + cboVID.Text.Trim() + "'";
            EdtQry = "update VehicleInfo set VNo = ''" + cboVNo.Text.Trim() + "'',Vtype = '" + cboVType.Text.Trim() + "',RegDate = CONVERT(datetime,'" + dtpResDate.Text.Trim() + "',103),LicExpDate = CONVERT(datetime,'" + dtpLicExpDate.Text.Trim() + "',103),VIN = '" + cboVIN.Text.Trim() + "',VPN = '" + cboVPN.Text.Trim() + "',VRmk = '" + cboVRmk.Text.Trim() + "',DrvEmpID = '" + cboDID.Text.Trim() + "',DRmk = '" + cboDRmk.Text.Trim() + "',HlprEmpID = '" + cboHID.Text.Trim() + "',HRmk = '" + cboHRmk.Text.Trim() + "',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId + "' where VID = '" + cboVID.Text.Trim() + "'";

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

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select v.AutoNo, VID as 'Vehicle ID',VNo as 'Vehicle No', Vtype as 'Vehicle Type',convert(varchar, RegDate, 103) as 'RegDate',convert(varchar, LicExpDate, 103) as 'License Expire Date',VIN as 'Identification No',VPN as 'Plate No',VRmk as'Remarks',EmpName as 'Driver Name' from VehicleInfo as v, Employee as e where e.EmpID = v.DrvEmpID");
            Grid.Refresh();


            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboVID.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Valid Vechicle ID...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboVID.Select();
                return;
            }


            checkqry = "select VNo,Vtype from VehicleInfo where VID = '"+cboVID.Text.Trim()+"'";
            Qry = "delete from VehicleInfo where VID = '" + cboVID.Text.Trim() + "'";
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

        private void cboVID_Leave(object sender, EventArgs e)
        {
            string DrID = "";
            if (cboVID.Text.Trim() != "")
            {

                Qry = "select v.AutoNo,VID,VNo, Vtype,RegDate,LicExpDate,VIN,'VPN' as VPN,VRmk,DrvEmpID,EmpName,DRmk from VehicleInfo as v,Employee as e where e.EmpID = v.DrvEmpID and VID = '" + cboVID.Text.Trim()+"'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboVID.Text = SvCls.GblRdrToGetData["VID"].ToString();
                    cboVNo.Text = SvCls.GblRdrToGetData["VNo"].ToString();
                    cboVType.Text = SvCls.GblRdrToGetData["Vtype"].ToString();
                    dtpLicExpDate.Text = SvCls.GblRdrToGetData["RegDate"].ToString();
                    dtpLicExpDate.Text = SvCls.GblRdrToGetData["LicExpDate"].ToString();
                    cboVIN.Text = SvCls.GblRdrToGetData["VIN"].ToString();
                    cboVPN.Text = SvCls.GblRdrToGetData["VPN"].ToString();
                    cboVRmk.Text = SvCls.GblRdrToGetData["VRmk"].ToString();
                    cboDName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                    cboDRmk.Text = SvCls.GblRdrToGetData["DRmk"].ToString();
                    DrID = SvCls.GblRdrToGetData["DrvEmpID"].ToString();

                    Qry = "SELECT EmpName FROM Employee where EmpID =  '" + DrID + "''";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboDName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                    }
                    else { cboDName.Text = ""; }



                    cboVNo.Focus();
                }
                else
                {
                    ShowMessage("not found", "");
                    cboVNo.Text = "";
                    cboVType.Text = "";
                    cboVIN.Text = "";
                    cboVPN.Text = "";
                    cboVRmk.Text = "";
                    dtpResDate.Text = DateTime.Today.ToString();
                    dtpLicExpDate.Text = DateTime.Today.ToString();
                    cboDID.Text = "";
                    cboDName.Text = "";
                    cboDRmk.Text = "";
                    cboHID.Text = "";
                    cboHName.Text = "";
                    cboHRmk.Text = "";
                    cboVNo.Focus();
                }

                

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboVID.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboVID_Leave(null, null);
            cboVNo.Focus();
        }

        private void cboDID_Leave(object sender, EventArgs e)
        {
            if(cboDID.Text.Trim() != "")
            {

                SvCls.toGetData("select EmpID,EmpName from Employee where EmpID = '"+cboDID.Text.Trim()+"'");

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboDName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                }

                else
                {
                    MessageBox.Show("Enter Valid Driver ID", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboDID.Select();
                    return;
                }

            }
           
        }

        private void cboHID_Leave(object sender, EventArgs e)
        {
            if (cboHID.Text.Trim() != "")
            {

                SvCls.toGetData("select EmpID,EmpName from Employee where EmpID = '" + cboHID.Text.Trim() + "'");

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboHName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                }

                else
                {
                    MessageBox.Show("Enter Valid Helper ID", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboHID.Select();
                    return;
                }

            }
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select VID from VehicleInfo";
            cboVID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboVID.DisplayMember = "VID";
            cboVID.Text = "";

            Qry = "select Vtype from VehicleInfo";
            cboVType.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboVType.DisplayMember = "Vtype";
            cboVType.Text = "";

            Qry = "select EmpID from Employee";
            cboDID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboDID.DisplayMember = "EmpID";
            cboDID.Text = "";

            Qry = "select EmpID from Employee";
            cboHID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboHID.DisplayMember = "EmpID";
            cboHID.Text = "";
        }
    }
}
