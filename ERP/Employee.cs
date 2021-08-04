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
    public partial class Employee : Form
    {
        ClsMain SvCls = new ClsMain();

        string qry = "";

        public Employee()
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

        private void Employee_Load(object sender, EventArgs e)
        {

            btnLoadGridData_Click(null, null);
            btnLoadCombo_Click(null, null);
            btnAddNew.Select();

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
        private void GridHeading()
        {
            qry = "Select AutoNo,EmpId as[Employee ID],EmpName as[Name],FName as[Father Name],MName as[Mother Name],Sex as[Gender],DOB as[Date of Birth],MStatus as[Marid Status],SpName as[Spouse Name],Phone,NidNo as[NID],Division,Zila,Upzilla,Uneon,PreAddress as[Present Address],PerAddress as[Permanent Address],EmpGroup as[Emp Group],DesignationID,SalaryUnit as[Salary Unit],cast(Salary as decimal(10,0)) as [Salary],JoinDate as[Join Date],ConfirmDate as[Confirm Date],AcNo,ResignType as[Resign Type],ResDate as[Resign Date],ResReason as[Resign Reason],ComName as[Company Name] from Employee ORDER BY EmpID desc";
            Grid.DataSource = SvCls.GblDataTable(qry);
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboComName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComName.Select();
                return;
            }

            if (cboEmpId.Text.Trim() == "")
            {
                MessageBox.Show("Select Party Code", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEmpId.Select();
                return;
            }
            if (cboEmpName.Text.Trim() == "")
            {
                MessageBox.Show("Party Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEmpName.Select();
                return;
            }

            if (cboGender.Text.Trim() == "")
            {
                MessageBox.Show("Select Gender", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGender.Select();
                return;
            }

            if (cboMobile.Text.Trim() == "")
            {
                MessageBox.Show("Mobile Number Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMobile.Select();
                return;
            }

            if (cboDesignation.Text.Trim() == "")
            {
                MessageBox.Show("Designation Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDesignation.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                cboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into Employee(ComId,EmpID,EmpName,FName,MName,Sex,DOB,MStatus,SpName,Phone,NidNo,Division,Zila,Upzilla,Uneon,PreAddress,PerAddress,AcType,AcNo,EmpGroup,DesignationID,SalaryUnit,Salary,JoinDate,ConfirmDate,SMS,AttnBonus,PF,OverTime,sts,Resign,PFPercent,ResignType,ResDate,ResReason,PcName,UserCode)values" +
                "('" + ClsVar.GblComId + "', '" + cboEmpId.Text.Trim() + "', '" + cboEmpName.Text.Trim() + "', '" + cboFname.Text.Trim() + "', '" + cboMname.Text.Trim() + "', '" + cboGender.Text.Trim() + "', CONVERT(datetime, '" + dtDoB.Text.Trim() + "', 103), '" + cboMaritSts.Text.Trim() + "', '" + cboSpouseName.Text.Trim() + "', '" + cboMobile.Text.Trim() + "', '" + cboNID.Text.Trim() + "', '" + cboDivision.Text.Trim() + "', '" + cboZilla.Text.Trim() + "', '" + cboThana.Text.Trim() + "','" + cboUneon.Text.Trim() + "','" + cboPreAddress.Text.Trim() + "','" + cboPerAddress.Text.Trim() + "','" + cboAcType.Text.Trim() + "','" + CboAcNo.Text.Trim() + "','" + cboGroup.Text.Trim() + "', '" + cboDesignation.Text.Trim() + "', '" + cboUnitSalary.Text.Trim() + "', " + txtSalary.Text.Trim() + ", CONVERT(datetime, '" + dtJoinDate.Text.Trim() + "', 103), " +
                "CONVERT(datetime, '" + dtConfirmDate.Text.Trim() + "', 103), '" + Convert.ToInt16(ChkSMS.Checked) + "', '" + Convert.ToInt16(ChkAttnBonus.Checked) + "', '" + Convert.ToInt16(ChkPF.Checked) + "', '" + Convert.ToInt16(ChkOvTime.Checked) + "','" + Convert.ToInt16(ChkActive.Checked) + "','" + Convert.ToInt16(ChkRsign.Checked) + "','" + txtPFPrct.Text.Trim() + "','" + cboResignType.Text.Trim() + "', CONVERT(datetime, '" + dtResignDate.Text.Trim() + "', 103), '" + cboReason.Text.Trim() + "', '" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";

            SelectQry = "Select ComId,EmpName,FName,MName,Sex,DOB,MStatus,SpName,Phone,NidNo,Division,Zila,Upzilla,Uneon,PreAddress,PerAddress,AcNo,EmpGroup,DesignationID,SalaryUnit,Salary,JoinDate,ConfirmDate,SMS,AttnBonus,PF,OverTime,sts,Resign,PFPercent,ResignType,ResDate,ResReason,ComName,PcName,UserCode from Employee where EmpID='" + cboEmpId.Text.Trim() + "'";

            EdtQry = "Update Employee set ComId='" + cboComId.Text.Trim() + "',EmpName='" + cboEmpName.Text.Trim() + "',FName='" + cboFname.Text.Trim() + "',MName='" + cboMname.Text.Trim() + "',Sex='" + cboGender.Text.Trim() + "',DOB=CONVERT(datetime,'" + dtDoB.Text.Trim() + "',103),MStatus='" + cboMaritSts.Text.Trim() + "',SpName='" + cboSpouseName.Text.Trim() + "',Phone='" + cboMobile.Text.Trim() + "',NidNo='" + cboNID.Text.Trim() + "',Division='" + cboDivision.Text.Trim() + "',Zila='" + cboZilla.Text.Trim() + "',Upzilla='" + cboThana.Text.Trim() + "',Uneon='" + cboUneon.Text.Trim() + "',PreAddress='" + cboPreAddress.Text.Trim() + "',PerAddress='" + cboPerAddress.Text.Trim() + "',AcType = '"+ cboAcType.Text.Trim() +"',AcNo='" + CboAcNo.Text.Trim() + "'," +
                "EmpGroup='" + cboGroup.Text.Trim() + "',DesignationID='" + cboDesignation.Text.Trim() + "',SalaryUnit= '" + cboUnitSalary.Text.Trim() + "',Salary=" + txtSalary.Text.Trim() + ",JoinDate=CONVERT(datetime,'" + dtJoinDate.Text.Trim() + "',103),ConfirmDate=CONVERT(datetime,'" + dtConfirmDate.Text.Trim() + "',103),sms='" + Convert.ToInt16(ChkSMS.Checked) + "',AttnBonus='" + Convert.ToInt16(ChkAttnBonus.Checked) + "',pf='" + Convert.ToInt16(ChkPF.Checked) + "',OverTime='" + Convert.ToInt16(ChkOvTime.Checked) + "',sts='" + Convert.ToInt16(ChkActive.Checked) + "',Resign='" + Convert.ToInt16(ChkRsign.Checked) + "',PFPercent='" + txtPFPrct.Text.Trim() + "',ResignType='" + cboResignType.Text.Trim() + "',ResDate=CONVERT(datetime,'" + dtResignDate.Text.Trim() + "',103),ResReason='" + cboReason.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "' where EmpID='" + cboEmpId.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                ShowMessage("save", "");
                GridHeading();
                btnAddNew.Focus();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
                GridHeading();
                btnAddNew.Focus();                
            }

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
            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '"+ cboComName.Text.Trim() +"'");
            if(SvCls.GblRdrToGetData.Read())
            {
                cboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
            }
        }

        private void cboEmpId_Leave(object sender, EventArgs e)
        {
            if (cboEmpId.Text.Trim() != "")
            {
                qry = "Select ComId, AutoNo, EmpName,FName,MName,Sex,DOB,MStatus,SpName,Phone,NidNo,Division,Zila,Upzilla,Uneon,PreAddress,PerAddress,AcType,AcNo,EmpGroup,DesignationID,SalaryUnit,cast(Salary as decimal(10,0)) as [Salary],JoinDate,ConfirmDate,sts,SMS,AttnBonus,sts,PF,OverTime,Resign,ResDate,ResignType,ResReason,ComName,PFPercent from Employee where EmpID='" + cboEmpId.Text.Trim() + "'";
                SvCls.toGetData(qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboComId.Text = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    cboEmpName.Text = SvCls.GblRdrToGetData["EmpName"].ToString();
                    cboFname.Text = SvCls.GblRdrToGetData["FName"].ToString();
                    cboMname.Text = SvCls.GblRdrToGetData["MName"].ToString();
                    cboGender.Text = SvCls.GblRdrToGetData["Sex"].ToString();
                    dtDoB.Text = SvCls.GblRdrToGetData["DOB"].ToString();
                    cboMaritSts.Text = SvCls.GblRdrToGetData["MStatus"].ToString();
                    cboSpouseName.Text = SvCls.GblRdrToGetData["SpName"].ToString();
                    cboMobile.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                    cboNID.Text = SvCls.GblRdrToGetData["NidNo"].ToString();
                    cboDivision.Text = SvCls.GblRdrToGetData["Division"].ToString();
                    cboThana.Text = SvCls.GblRdrToGetData["Zila"].ToString();
                    cboZilla.Text = SvCls.GblRdrToGetData["Upzilla"].ToString();
                    cboUneon.Text = SvCls.GblRdrToGetData["Uneon"].ToString();
                    cboPreAddress.Text = SvCls.GblRdrToGetData["PreAddress"].ToString();
                    cboPerAddress.Text = SvCls.GblRdrToGetData["PerAddress"].ToString();
                    cboAcType.Text = SvCls.GblRdrToGetData["AcType"].ToString();
                    CboAcNo.Text = SvCls.GblRdrToGetData["AcNo"].ToString();
                    cboGroup.Text = SvCls.GblRdrToGetData["EmpGroup"].ToString();
                    cboDesignation.Text = SvCls.GblRdrToGetData["DesignationID"].ToString();
                    cboUnitSalary.Text = SvCls.GblRdrToGetData["SalaryUnit"].ToString();
                    txtSalary.Text = SvCls.GblRdrToGetData["Salary"].ToString();
                    dtJoinDate.Text = SvCls.GblRdrToGetData["JoinDate"].ToString();
                    dtConfirmDate.Text = SvCls.GblRdrToGetData["ConfirmDate"].ToString();


                    if (SvCls.GblRdrToGetData["sts"].ToString() == "1")
                    {
                        ChkActive.Checked = true;
                    }
                    else
                    {
                        ChkActive.Checked = false;
                    }
                    if (SvCls.GblRdrToGetData["PF"].ToString() == "1")
                    {
                        ChkPF.Checked = true;
                    }
                    else
                    {
                        ChkPF.Checked = false;
                    }
                    if (SvCls.GblRdrToGetData["OverTime"].ToString() == "1")
                    {
                        ChkOvTime.Checked = true;
                    }
                    else
                    {
                        ChkOvTime.Checked = false;
                    }
                    if (SvCls.GblRdrToGetData["SMS"].ToString() == "1")
                    {
                        ChkSMS.Checked = true;
                    }
                    else
                    {
                        ChkSMS.Checked = false;
                    }
                    if (SvCls.GblRdrToGetData["AttnBonus"].ToString() == "1")
                    {
                        ChkAttnBonus.Checked = true;
                    }
                    else
                    {
                        ChkAttnBonus.Checked = false;
                    }

                    if (SvCls.GblRdrToGetData["Resign"].ToString() == "1")
                    {
                        ChkRsign.Checked = true;
                        dtResignDate.Enabled = true;
                    }
                    else
                    {
                        ChkRsign.Checked = false;
                        dtResignDate.Enabled = false;
                    }
                    
                    cboResignType.Text = SvCls.GblRdrToGetData["ResignType"].ToString();
                    dtResignDate.Text = SvCls.GblRdrToGetData["ResDate"].ToString();
                    cboReason.Text = SvCls.GblRdrToGetData["ResReason"].ToString();
                    txtPFPrct.Text = SvCls.GblRdrToGetData["PFPercent"].ToString();

                    qry = "SELECT ComName FROM Company WHERE ComId = '" + cboComId.Text.Trim() + "'";
                    SvCls.toGetData(qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                    }
                    else { cboComName.Text = ""; }

                    ShowPicture();
                    GridHeading();
                }
                else
                {
                    cboComId.Text = "";
                    cboAutoNo.Text = "";
                    cboComName.Text = "";
                    cboEmpName.Text = "";
                    cboFname.Text = "";
                    cboMname.Text = "";
                    cboMaritSts.Text = "";
                    cboGender.Text = "";
                    cboDivision.Text = "";
                    cboZilla.Text = "";
                    cboThana.Text = "";
                    cboUneon.Text = "";
                    cboGroup.Text = "";
                    cboMobile.Text = "";
                    cboPerAddress.Text = "";
                    cboPreAddress.Text = "";
                    cboNID.Text = "";
                    cboAcType.Text = "";
                    CboAcNo.Text = "";
                    cboUnitSalary.Text = "";
                    txtSalary.Text = "0";
                    cboDesignation.Text = "";
                    txtPFPrct.Text = "";
                    cboResignType.Text = "";
                    cboReason.Text = "";
                    dtDoB.Text = "";
                    dtJoinDate.Text = "";
                    dtConfirmDate.Text = "";
                    cboSpouseName.Text = "";
                    dtResignDate.Text = "";
                    ChkActive.Checked = false;
                    ChkAttnBonus.Checked = false;
                    ChkRsign.Checked = false;
                    dtResignDate.Enabled = false;
                    ChkSMS.Checked = false;
                    ChkOvTime.Checked = false;
                    ChkPF.Checked = false;


                    ShowPicture();
                    ShowMessage("not found", "");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPicture()
        {
            string path = Application.StartupPath + "\\photo\\Employee\\" + cboEmpId.Text.Trim() + ".Jpg";
            string imagename;
            string r = "";

            try
            {
                imagename = path;
                Bitmap newimg = new Bitmap(imagename);
                Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                Pictures.Image = (Image)newimg;
            }
            catch (Exception fa)
            {

                r = fa.Message;
                imagename = Application.StartupPath + "\\photo\\Employee\\" + "00000.Jpg";
                Bitmap newimg = new Bitmap(imagename);
                Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                Pictures.Image = (Image)newimg;

                path = Application.StartupPath + "\\photo\\Employee\\" + cboEmpId.Text.Trim() + ".Jpg";
                try
                {
                    imagename = path;
                    Bitmap newimgNew = new Bitmap(imagename);
                    Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pictures.Image = (Image)newimgNew;
                }
                catch
                {
                    r = fa.Message;
                    imagename = Application.StartupPath + "\\photo\\Employee\\" + "00000.Jpg";
                    Bitmap newimgNew = new Bitmap(imagename);
                    Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pictures.Image = (Image)newimgNew;
                }

            }


            try
            {


                //if (SvCls.GblDataSet("SELECT Photo FROM photo where empid='" + cboEmpId.Text.Trim() + "'").Tables[0].Rows.Count == 1)
                //{
                //    Byte[] data = new Byte[0];
                //    data = (Byte[])(SvCls.GblDataSet("SELECT Photo FROM photo where empid='" + cboEmpId.Text.Trim() + "'").Tables[0].Rows[0]["Photo"]);
                //    MemoryStream mem = new MemoryStream(data);
                //    Pictures.Image = Image.FromStream(mem);
                //} ComDate: 20/11/2018

                //else Previous Comment
                //{

                //    imagename = Application.StartupPath + "\\photo\\" + "00000.Jpg";
                //    Bitmap newimg = new Bitmap(imagename);
                //    Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                //    Pictures.Image = (Image)newimg;
                //}


            }
            catch (Exception rev)
            {
                ShowMessage("info", "'"+ rev.Message.ToString() +"'");

                imagename = Application.StartupPath + "\\photo\\" + "00000.Jpg";
                Bitmap newimg = new Bitmap(imagename);
                Pictures.SizeMode = PictureBoxSizeMode.StretchImage;
                Pictures.Image = (Image)newimg;

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SvCls.toGetData("select isnull(max(convert(numeric,EmpID)),1000)+1 as CodeNo from Employee where isnumeric(EmpID)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboEmpId.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }
                cboEmpName.Text = "";
                cboFname.Text = "";
                cboMname.Text = "";
                cboMaritSts.Text = "";
                cboGender.Text = "";
                cboDivision.Text = "";
                cboZilla.Text = "";
                cboThana.Text = "";
                cboUneon.Text = "";
                cboGroup.Text = "";
                cboMobile.Text = "";
                cboPerAddress.Text = "";
                cboPreAddress.Text = "";
                cboNID.Text = "";
                cboAcType.Text = "";
                CboAcNo.Text = "";
                cboUnitSalary.Text = "";
                txtSalary.Text = "0";
                cboDesignation.Text = "";
                txtPFPrct.Text = "";
                cboResignType.Text = "";
                cboReason.Text = "";
                dtDoB.Text = "";
                dtJoinDate.Text = "";
                dtConfirmDate.Text = "";
                cboSpouseName.Text = "";
                dtResignDate.Text = "";
                ChkActive.Checked = false;
                ChkAttnBonus.Checked = false;
                ChkRsign.Checked = false;
                ChkSMS.Checked = false;
                ChkOvTime.Checked = false;
                ChkPF.Checked = false;

                
                ShowPicture();
                cboEmpName.Select();
                btnSave.Text = "Save";

                //GridHeading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAutoNo.Text = "";
            cboEmpId.Text = "";
            cboEmpName.Text = "";
            cboFname.Text = "";
            cboMname.Text = "";
            cboMaritSts.Text = "";
            cboGender.Text = "";
            cboDivision.Text = "";
            cboZilla.Text = "";
            cboThana.Text = "";
            cboUneon.Text = "";
            cboGroup.Text = "";
            cboMobile.Text = "";
            cboPerAddress.Text = "";
            cboPreAddress.Text = "";
            cboNID.Text = "";
            cboAcType.Text = "";
            CboAcNo.Text = "";
            cboUnitSalary.Text = "";
            txtSalary.Text = "";
            cboDesignation.Text = "";
            txtPFPrct.Text = "";
            cboResignType.Text = "";
            cboReason.Text = "";
            dtDoB.Text = "";
            dtJoinDate.Text = "";
            dtConfirmDate.Text = "";
            cboComName.Text = "";
            cboSpouseName.Text = "";
            dtResignDate.Enabled = false;
            ChkActive.Checked = false;
            ChkAttnBonus.Checked = false;
            ChkRsign.Checked = false;
            ChkSMS.Checked = false;
            ChkOvTime.Checked = false;
            ChkPF.Checked = false;
            GridHeading();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboEmpId.Text.Trim() == "")
            {
                MessageBox.Show("Plese select Employee Id", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEmpId.Select();
                return;
            }
            {
                if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SvCls.insertUpdate("Delete from Employee where EmpID='" + cboEmpId.Text.Trim() + "'/*and ComName='" + cboComName.Text.Trim() + "'*/");
                    ShowMessage("delete", "");
                    GridHeading();
                }
            }          
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            qry = "Select AutoNo,EmpId as[Employee ID],EmpName as[Name],FName as[Father Name],MName as[Mother Name],Sex as[Gender],DOB as[Date of Birth],MStatus as[Marid Status],SpName as[Spouse Name],Phone,NidNo as[NID],Division,Zila,Upzilla,Uneon,PreAddress as[Present Address],PerAddress as[Permanent Address],EmpGroup as[Emp Group],DesignationID,SalaryUnit as[Salary Unit],cast(Salary as decimal(10,0)) as [Salary],JoinDate as[Join Date],ConfirmDate as[Confirm Date],AcNo,ResignType as[Resign Type],ResDate as[Resign Date],ResReason as[Resign Reason],ComName as[Company Name] from Employee order by EmpID desc";
            Grid.DataSource = SvCls.GblDataTable(qry);
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;

            //ShowMessage("wait", "");
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            qry = "Select EmpID from Employee order by EmpID";
            cboEmpId.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboEmpId.DisplayMember = "EmpID";
            cboEmpId.Text = "";

            qry = "Select ComName from Company order by ComName";
            cboComName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            qry = "Select EmpName from Employee order by EmpName";
            cboEmpName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboEmpName.DisplayMember = "EmpName";
            cboEmpName.Text = "";

            qry = "Select FName from Employee order by EmpName";
            cboFname.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboFname.DisplayMember = "FName";
            cboFname.Text = "";

            qry = "Select MName from Employee order by EmpName";
            cboMname.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboMname.DisplayMember = "MName";
            cboMname.Text = "";

            qry = "select phone from employee order by phone";
            cboMobile.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboMobile.DisplayMember = "phone";
            cboMobile.Text = "";

            qry = "select preaddress from employee order by preaddress";
            cboPreAddress.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPreAddress.DisplayMember = "preaddress";
            cboPreAddress.Text = "";

            qry = "select peraddress from employee order by peraddress";
            cboPerAddress.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPerAddress.DisplayMember = "peraddress";
            cboPerAddress.Text = "";

            qry = "select spname from employee order by spname";
            cboSpouseName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboSpouseName.DisplayMember = "spname";
            cboSpouseName.Text = "";

            qry = "select nidno from employee order by nidno";
            cboNID.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboNID.DisplayMember = "nidno";
            cboNID.Text = "";

            qry = "select uneon from employee order by uneon";
            cboUneon.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboUneon.DisplayMember = "uneon";
            cboUneon.Text = "";

            qry = "Select AcNo from Employee order by AcNo";
            CboAcNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
            CboAcNo.DisplayMember = "AcNo";
            CboAcNo.Text = "";

            qry = "Select EmpGroup from Employee order by EmpGroup";
            cboGroup.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboGroup.DisplayMember = "EmpGroup";
            cboGroup.Text = "";

            qry = "Select DesignationID from Employee order by DesignationID";
            cboDesignation.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboDesignation.DisplayMember = "DesignationID";
            cboDesignation.Text = "";

            qry = "Select SalaryUnit from Employee order by SalaryUnit";
            cboUnitSalary.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboUnitSalary.DisplayMember = "SalaryUnit";
            cboUnitSalary.Text = "";

            qry = "Select ResReason from Employee order by ResReason";
            cboReason.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboReason.DisplayMember = "ResReason";
            cboReason.Text = "";
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboEmpId.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboEmpId_Leave(null, null);
            
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboEmpId.Select();
            }
        }

        private void txtSrcText_Leave(object sender, EventArgs e)
        {
            string qry = "";
            qry = "Select AutoNo,EmpId as[Employee ID],EmpName as[Name],FName as[Father Name],MName as[Mother Name],Sex as[Gender],DOB as[Date of Birth],MStatus as[Marid Status],SpName as[Spouse Name],Phone,NidNo as[NID],Division,Zila,Upzilla,Uneon,PreAddress as[Present Address],PerAddress as[Permanent Address],EmpGroup as[Emp Group],DesignationID,SalaryUnit as[Salary Unit],cast(Salary as decimal(10,0)) as [Salary],JoinDate as[Join Date],ConfirmDate as[Confirm Date],AcNo,ResignType as[Resign Type],ResDate as[Resign Date],ResReason as[Resign Reason],ComName as[Company Name] from Employee where ComName='" + txtSrcText.Text.Trim() + "' order by EmpID desc";
            GridSrc.DataSource = SvCls.GblDataTable(qry);
            GridSrc.Refresh();

            lblShowTotal.Text = "Total : " + GridSrc.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;

            ShowMessage("wait", "");
        }

        private void cboEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboEmpName.Select();
            }
        }

        private void cboEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboFname.Select();
            }
        }

        private void cboFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMname.Select();
            }
        }

        private void cboMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboGender.Select();
            }
        }

        private void cboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtDoB.Select();
            }
        }

        private void cboMaritSts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSpouseName.Select();
            }
        }

        private void cboMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboNID.Select();
            }
        }

        private void cboDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboZilla.Select();
            }
        }

        private void cboThana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUneon.Select();
            }
        }

        private void cboPreAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPerAddress.Select();
            }
        }

        private void cboPerAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtJoinDate.Select();
            }
        }

        private void dtDoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMaritSts.Select();
            }
        }

        private void cboSpouseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMobile.Select();
            }
        }

        private void cboNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDivision.Select();
            }
        }

        private void cboZilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboThana.Select();
            }
        }

        private void cboUnion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPreAddress.Select();
            }
        }

        private void CboAcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                ChkActive.Select();
            }
        }

        private void dtJoinDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtConfirmDate.Select();
            }
        }

        private void dtConfirmDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboGroup.Select();
            }
        }

        private void cboGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDesignation.Select();
            }
        }

        private void cboDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSalary.Select();
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUnitSalary.Select();
            }
        }

        private void cboUnitSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAcType.Select();
            }
        }

        private void txtPFPrct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtResignDate.Select();
            }
        }

        private void dtResignDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboResignType.Select();
            }
        }

        private void cboResignType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboReason.Select();
            }
        }

        private void cboReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void ChkRsign_Click(object sender, EventArgs e)
        {
            if(ChkRsign.Checked == true)
            {
                dtResignDate.Enabled = true;
            } else { dtResignDate.Enabled = false; }
        }

        private void cboAcType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                CboAcNo.Select();
            }
        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
